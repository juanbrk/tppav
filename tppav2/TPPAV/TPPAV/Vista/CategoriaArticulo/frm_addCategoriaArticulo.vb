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
        Dim cate As New CategoriaArt
        If txt_nomCate.Text = String.Empty Then
            MsgBox("Debe ingresar un nombre de categoría")
            Return
        Else
            cate.nombre = txt_nomCate.Text
        End If

        If txt_descripcion.Text = String.Empty Then
            If MsgBox("Desea ingresar una descripción?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Return
            End If
        Else
            cate.descripcion = txt_descripcion.Text
        End If

        Dim service As New CategoriaService
        If service.addCategoria(cate) = 1 Then
            MsgBox("Se ha registrado la categoría con éxito")
            cerrar = False
            Me.Close()
        Else
            MsgBox("Hubo un error al registrar la categoría")
        End If
    End Sub
End Class