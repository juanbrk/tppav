Public Class frm_addClientes
    Dim msj_errorTipoDato As String = "Por favor, ingrese solo numeros en el campo telefono"
    Dim error_title As String = "Error"
    Property bandera As Boolean = True
    Dim cli As Cliente = New Cliente()

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_apellido.Text = String.Empty
        txt_barrio.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_nombre.Text = String.Empty
        txt_telefono.Text = String.Empty

    End Sub

    Public Sub modoEditar(ByVal client As Cliente)
        bandera = False
        cli = client
        txt_nombre.Text = cli.nombre
        txt_apellido.Text = cli.apellido
        txt_direccion.Text = cli.direccion
        txt_barrio.Text = cli.zona
        txt_telefono.Text = cli.telefono.ToString
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim clien As ClienteService = New ClienteService()

        cli.nombre = txt_nombre.Text
        cli.apellido = txt_apellido.Text
        cli.direccion = txt_direccion.Text
        cli.zona = txt_barrio.Text
        If bandera Then

            Try
                cli.telefono = Integer.Parse(txt_telefono.Text)
                clien.agregarCliente(cli)
                frm_listarClientes.cargarGrilla()
                frm_listarClientes.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(msj_errorTipoDato, MsgBoxStyle.OkOnly, error_title)
            End Try
        Else
            Try
                cli.telefono = Integer.Parse(txt_telefono.Text)
                clien.updateCliente(cli)
                bandera = True
                frm_listarClientes.cargarGrilla()
                frm_listarClientes.Show()
                Me.Hide()
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

        'Esto va si traemos un resultado desde otra form.
        'If result = Windows.Forms.DialogResult.Yes Then
        '    txt_barrio.Text = dialog.Note
        'Else
        'End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()

    End Sub
End Class