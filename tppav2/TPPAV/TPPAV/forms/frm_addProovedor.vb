Public Class frm_addProovedor

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_rznSocial.Click

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_direccion.Text = String.Empty
        txt_email.Text = String.Empty
        txt_razonSocial.Text = String.Empty
        txt_telefono.Text = String.Empty

    End Sub
End Class