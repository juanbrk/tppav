Public Class frm_usrLogin
    Dim usuario As Usuario
    Dim validado As Boolean = False
    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim res As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT * FROM Usuarios WHERE nombre='" + txt_usuario.Text + "' AND password='" + txt_password.Text + "'")

        If res.Rows.Count = 1 Then
            usuario = New Usuario
            usuario.nombre = res.Rows.Item(0).Item("nombre").ToString()
            usuario.idUsuario = Integer.Parse(res.Rows.Item(0).Item("idUsuario").ToString())
            validado = True
            Me.Close()
        Else
            MsgBox("El usuario no existe o el password es incorrecto")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Public Function getValidado() As Boolean
        Return validado
    End Function

    Public Function getUsuario() As Usuario
        Return usuario
    End Function
End Class
