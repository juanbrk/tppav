Imports System.ComponentModel

Public Class frm_addArticulo
    Dim cerrar As Boolean = False
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cerrar = False
        Me.Close()
    End Sub

    Private Sub frm_addArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cerrar = True
    End Sub

    Private Sub frm_addArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim art As New Articulo
        cerrar = True
        If txt_nomArticulo.Text = String.Empty Then
            MsgBox("Debe ingresar un nombre de articulo")
        ElseIf txt_precXUnidad.Text = String.Empty Then
            MsgBox("Debe ingresar un precio unitario")
        End If
    End Sub
End Class