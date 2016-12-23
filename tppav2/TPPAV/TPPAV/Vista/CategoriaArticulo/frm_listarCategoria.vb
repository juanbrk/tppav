Public Class frm_listarCategoria
    Private Sub frm_listarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCategorias()

    End Sub
    Private Sub cargarCategorias()
        Dim service As New CategoriaService
        dgv_categorias.AutoGenerateColumns = False
        dgv_categorias.DataSource = service.listarCategorias
        dgv_categorias.Columns.Item(0).DataPropertyName = "idCat"
        dgv_categorias.Columns.Item(1).DataPropertyName = "nombre"
        dgv_categorias.Columns.Item(2).DataPropertyName = "descripcion"

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If dgv_categorias.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar una categoria para editarla", MsgBoxStyle.Exclamation, "Gestor de categorias")
        Else
            Dim cat As CategoriaArt = dgv_categorias.CurrentRow.DataBoundItem
            Dim editar As New frm_addCategoriaArticulo
            'falta codigo para pasarle la categoria actual'
            Dim result As DialogResult = editar.ShowDialog
            If result = DialogResult.OK Then
                Me.cargarCategorias()
            End If
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim add As New frm_addCategoriaArticulo

        Dim result As DialogResult = add.ShowDialog
        If result = DialogResult.OK Then
            Me.cargarCategorias()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If dgv_categorias.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar una categoria para eliminarla", MsgBoxStyle.Exclamation, "Gestor de categorias")
        Else
            Dim cat As CategoriaArt = dgv_categorias.CurrentRow.DataBoundItem
            Dim service As New CategoriaService

            If service.eliminarCategoria(cat.idCat) Then
                MsgBox("Categoria eliminada con éxito", MsgBoxStyle.Information, "Gestor de categorias")
                Me.cargarCategorias()
            Else
                MsgBox("No se pudo eliminar la categoria, probablemente este relacionada con un artículo existente", MsgBoxStyle.Information, "Gestor de categorias")
            End If
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class