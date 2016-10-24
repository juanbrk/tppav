Imports System.ComponentModel

Public Class frm_addCategoriaArticulo
    Dim cerrar As Boolean = False
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cerrar = False
        Me.Close()


    End Sub

    Private Sub frm_addCategoriaArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_addCategoriaArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        cerrar = True 'falta codigo para añadir categoria'
    End Sub
End Class