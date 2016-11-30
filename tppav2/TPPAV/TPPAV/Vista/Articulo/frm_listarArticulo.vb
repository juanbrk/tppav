Public Class frm_listarArticulo
    Private Sub frm_listarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servicecat As CategoriaService = New CategoriaService
        Dim categorias As List(Of CategoriaArt) = servicecat.listarCategorias
        cbo_categorias.DataSource = categorias
        cbo_categorias.DisplayMember = "nombre"
        cbo_categorias.ValueMember = "idCat"

        cbo_categorias.SelectedIndex = -1
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        If cbo_categorias.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una categoria para filtrar", MsgBoxStyle.Exclamation, "Gestor de Artículos")
            Return
        End If
        cargarArticulos()

    End Sub

    Public Sub cargarArticulos()
        Dim serviceArt As New ArticuloService
        dgv_articulos.AutoGenerateColumns = False
        dgv_articulos.DataSource = ""
        dgv_articulos.DataSource = serviceArt.listarArticulosDeCategoria(cbo_categorias.SelectedValue)
        dgv_articulos.Columns.Item(0).DataPropertyName = "idArticulo"
        dgv_articulos.Columns.Item(1).DataPropertyName = "nombre"
        dgv_articulos.Columns.Item(2).DataPropertyName = "descripcion"
        dgv_articulos.Columns.Item(3).DataPropertyName = "precioU"
        dgv_articulos.Columns.Item(4).DataPropertyName = "proveedor"
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialog As New frm_addArticulo
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.OK Then
            Me.cargarArticulos()
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim art As Articulo = dgv_articulos.CurrentRow.DataBoundItem

        Dim addart As frm_addArticulo = New frm_addArticulo

        'seteo el modoeditar de frmaddclientes'
        addart.modoEditar(art)
        'hago visible al formulario frmaddclientes'
        Dim res As DialogResult = addart.ShowDialog
        If res = DialogResult.OK Then
            Me.cargarArticulos()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class