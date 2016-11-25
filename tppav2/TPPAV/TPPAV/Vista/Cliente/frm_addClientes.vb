Imports System.ComponentModel

Public Class frm_addClientes
    Dim msj_errorTipoDato As String = "Por favor, ingrese solo numeros en el campo telefono"
    Dim error_title As String = "Error"
    'la bandera sirve para saber si estamos en modo editar o en modo añadir'
    Dim cerrar As Boolean = False
    Property bandera As Boolean = True
    Dim cli As Cliente = New Cliente()


    Public Sub modoEditar(ByVal client As Cliente)
        'bandera en falso significa que es modo editar, por default esta en modo añadir (true)'
        bandera = False
        'pasamos los datos del cliente que entro por parametro a los text fields'
        'tambien seteamos el cliente de la clase (para usarlo despues)'
        cli = client
        txt_nombre.Text = cli.nombre
        txt_apellido.Text = cli.apellido
        txt_direccion.Text = cli.direccion
        'txt_barrio.Text = cli.zona
        txt_telefono.Text = cli.telefono.ToString
        txt_dni.Text = cli.dni
        txt_mail.Text = cli.mail
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'instanciamos el servicio de cliente para poder hacer modificaciones en la bd'
        cerrar = True
        Dim clien As ClienteService = New ClienteService()

        'seteamos los atributos de nuestro cliente, con los modificados (o no) de los txt fields'
        If txt_nombre.Text Is String.Empty Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Exclamation, "Gestor de Clientes")
            Return
        Else
            cli.nombre = txt_nombre.Text
        End If
        If txt_apellido.Text Is String.Empty Then
            MsgBox("Debe ingresar un apellido", MsgBoxStyle.Exclamation, "Gestor de Clientes")
            Return
        Else
            cli.apellido = txt_apellido.Text
        End If
        If txt_direccion.Text Is String.Empty Then
            cli.direccion = "Sin Direccion"
        Else
            cli.direccion = txt_direccion.Text
        End If
        If cbo_barrios.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un barrio", MsgBoxStyle.Exclamation, "Gestor de Clientes")
            Return
        Else
            cli.barrio = New Barrio
            cli.barrio.ID_BARRIO = Convert.ToInt32(cbo_barrios.SelectedValue.ToString)
        End If
        If cb_descripcion.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una descripcion", MsgBoxStyle.Exclamation, "Gestor de Clientes")
            Return
        Else
            cli.descripcion = cb_descripcion.SelectedItem.ToString
        End If
        If txt_dni.Text Is String.Empty Then
            cli.dni = "Sin DNI/CUIT"
        Else
            cli.dni = txt_dni.Text
        End If
        If txt_mail.Text Is String.Empty Then
            cli.mail = "Sin Mail"
        Else
            cli.mail = txt_mail.Text
        End If

        If txt_telefono Is String.Empty Then
            MsgBox("Debe ingresar un número de teléfono", MsgBoxStyle.Exclamation, "Gestor de Clientes")
            Return
        Else
            Try
                cli.telefono = Integer.Parse(txt_telefono.Text)
            Catch ex As Exception
                Try
                    cli.telefono = Long.Parse(txt_telefono.Text)
                Catch ex1 As Exception
                    MsgBox("Solo puede ingresar números en el campo teléfono", MsgBoxStyle.Exclamation, "Gestor de Clientes")
                    Return
                End Try
            End Try
        End If

        If bandera Then
            Try
                'agregamos un NUEVO cliente, por la bandera nos dimos cuenta que habia que agregarlo'
                If clien.agregarCliente(cli) = 1 Then
                    MsgBox("Cliente agregado con éxito")
                    cerrar = False
                End If
                'refrescamos la grilla del listar clientes y la hacemos visible'

            Catch ex As Exception
                MsgBox("Error al agregar el cliente", MsgBoxStyle.OkOnly, "Base de Datos")
            End Try
        Else
            Try

                If clien.updateCliente(cli) = 1 Then
                    MsgBox("Cliente actualizado con éxito")
                    cerrar = False
                End If
                'volvemos a setear la bandera a true, que seria el modo añadir'
                bandera = True

            Catch ex As Exception
                MsgBox("Error al actualizar el cliente", MsgBoxStyle.OkOnly, "Base de Datos")
            End Try
        End If

    End Sub

    Private Sub btn_addBarrio_Click(sender As Object, e As EventArgs) Handles btn_addBarrio.Click
        'Me.Hide()
        'frm_addBarrio.bandera = True
        'frm_addBarrio.Show()
        'Me.Hide()
        'frm_addBarrio.ShowDialog()

        ' Estas lineas hacen que aparezca la form addBarrio y despues se reciba un resultado desde 
        'DialogResult 
        Dim dialog As frm_addBarrio
        dialog = New frm_addBarrio()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.OK Then
            cargarBarrios()
        End If
        'Esto va si traemos un resultado desde otra form.
        'If result = Windows.Forms.DialogResult.Yes Then
        '    txt_barrio.Text = dialog.Note
        'Else
        'End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cerrar = False
        Me.Close()

    End Sub

    Private Sub cargarBarrios()
        Dim barriosService As BarrioService = New BarrioService
        cbo_barrios.DataSource = New List(Of Object) 'sirve de clear'
        cbo_barrios.DataSource = barriosService.listarBarrios
        cbo_barrios.DisplayMember = "nombre"
        cbo_barrios.ValueMember = "ID_BARRIO"
        cbo_barrios.SelectedIndex = -1
    End Sub
    Private Sub frm_addClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarBarrios()
        cargarDescripciones()
    End Sub

    Private Sub cargarDescripciones()
        cb_descripcion.Items.Clear()
        cb_descripcion.Items.Add("Consumidor Final")
        cb_descripcion.Items.Add("Monotributista")
        cb_descripcion.Items.Add("Responsable Inscripto")
    End Sub

    Private Sub frm_addClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub
End Class