Imports System.ComponentModel

Public Class frm_addClientes
    Dim msj_errorTipoDato As String = "Por favor, ingrese solo numeros en el campo telefono"
    Dim error_title As String = "Error"
    'la bandera sirve para saber si estamos en modo editar o en modo añadir'
    Dim cerrar As Boolean = False
    Property bandera As Boolean = True
    Dim cli As Cliente = New Cliente()

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_apellido.Text = String.Empty
        'txt_barrio.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_nombre.Text = String.Empty
        txt_telefono.Text = String.Empty

    End Sub

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
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'instanciamos el servicio de cliente para poder hacer modificaciones en la bd'
        cerrar = True
        Dim clien As ClienteService = New ClienteService()

        'seteamos los atributos de nuestro cliente, con los modificados (o no) de los txt fields'
        cli.nombre = txt_nombre.Text
        cli.apellido = txt_apellido.Text
        cli.direccion = txt_direccion.Text
        cli.barrio = New Barrio
        cli.barrio.ID_BARRIO = Convert.ToInt32(cbo_barrios.SelectedValue.ToString)
        'cli.zona = txt_barrio.Text
        'si esta en modo añadir..'
        If bandera Then

            Try
                'el telefono se setea dentro del try porque el parse puede dar error'
                cli.telefono = Integer.Parse(txt_telefono.Text)
                'agregamos un NUEVO cliente, por la bandera nos dimos cuenta que habia que agregarlo'
                If clien.agregarCliente(cli) = 1 Then
                    MsgBox("Cliente agregado con éxito")
                    cerrar = False
                End If
                'refrescamos la grilla del listar clientes y la hacemos visible'



            Catch ex As Exception
                MsgBox(msj_errorTipoDato, MsgBoxStyle.OkOnly, error_title)
            End Try
        Else
            Try
                cli.telefono = Integer.Parse(txt_telefono.Text)
                'modificamos un cliente ya existente en la base de datos'

                If clien.updateCliente(cli) = 1 Then
                    MsgBox("Cliente actualizado con éxito")
                    cerrar = False
                End If
                'volvemos a setear la bandera a true, que seria el modo añadir'
                bandera = True

            Catch ex As Exception
                MsgBox(msj_errorTipoDato, MsgBoxStyle.OkOnly, error_title)
            End Try
        End If

    End Sub

    Private Sub btn_addBarrio_Click(sender As Object, e As EventArgs) Handles btn_addBarrio.Click
        'Me.Hide()
        'frm_addBarrio.bandera = True
        'frm_addBarrio.Show()
        'Me.Hide()
        'frm_addBarrio.ShowDialog()

        'http://www.dreamincode.net/forums/topic/332553-passing-data-between-forms/
        'https://support.microsoft.com/es-ar/kb/315711
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
    End Sub
    Private Sub frm_addClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarBarrios()
    End Sub

    Private Sub frm_addClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub
End Class