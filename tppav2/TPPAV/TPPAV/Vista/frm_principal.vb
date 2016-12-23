Public Class frm_principal
    Dim usuario As New Usuario
    Private Sub AñadirNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem.Click
        Dim add As frm_crearPedido = New frm_crearPedido
        add.Tag = usuario
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
        Dim listar As New frm_listarArticulo
        listar.ShowDialog()
        'listar articulos
    End Sub

    Private Sub AñadirNuevoToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AñadirNuevoToolStripMenuItem3.Click
        Dim add As frm_addCategoriaArticulo = New frm_addCategoriaArticulo
        add.ShowDialog()
    End Sub

    Private Sub ListarTodosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListarTodosToolStripMenuItem3.Click
        Dim listar As New frm_listarCategoria
        listar.ShowDialog()
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

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        'TODO: This line of code loads data into the 'DataSet1.Pedido' table. You can move, or remove it, as needed.
        'Me.PedidoTableAdapter.Fill(Me.DataSet1.Pedido)

        Dim logueo As New frm_usrLogin
        logueo.ShowDialog()
        If logueo.getValidado Then
            usuario = logueo.getUsuario
            Label2.Text = usuario.nombre
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rep As New frm_rep
        rep.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim est As New frm_estadisticas
        est.ShowDialog()
    End Sub

    Private Sub ListarTerminadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarTerminadosToolStripMenuItem.Click
        Dim listar As frm_listarPedidosTerminados = New frm_listarPedidosTerminados
        listar.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim est As New frm_estadisticas_barrios
        est.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim est As New frm_estadisticas_articulos
        est.ShowDialog()
    End Sub
End Class