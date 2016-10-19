Public Class frm_principal
    Private Sub AñadirNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem.Click
        Dim add As frm_crearPedido = New frm_crearPedido
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem.Click
        Dim listar As frm_listarPedidos = New frm_listarPedidos
        listar.ShowDialog()
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem1.Click
        Dim add As frm_addClientes = New frm_addClientes
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem1.Click
        Dim listar As frm_listarClientes = New frm_listarClientes
        listar.ShowDialog()
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem2.Click
        Dim add As frm_addArticulo = New frm_addArticulo
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem2.Click
        'listar articulos
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem3.Click
        Dim add As frm_addCategoriaArticulo = New frm_addCategoriaArticulo
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem3.Click
        'listar categorias
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem4.Click
        Dim add As frm_addProovedor = New frm_addProovedor
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem4.Click
        Dim listar As frm_listarProovedores = New frm_listarProovedores
        listar.ShowDialog()
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem5.Click
        Dim add As frm_addBarrio = New frm_addBarrio
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem5.Click
        Dim listar As frm_listarBarrios = New frm_listarBarrios
        listar.ShowDialog()
    End Sub
End Class