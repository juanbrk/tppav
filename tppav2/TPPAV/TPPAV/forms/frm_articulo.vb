Public Class frm_articulo

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_nomArticulo.Text = String.Empty
        txt_precXCaja.Text = String.Empty
        txt_precXUnidad.Text = String.Empty
        rtxt_descripcion.Text = String.Empty
    End Sub
End Class