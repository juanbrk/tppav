Public Class frm_listarPedidosTerminados
    Private Sub frm_listarPedidosTerminados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPedidos()
        lbl_id.Text = ""
        btn_buscar.Enabled = False
    End Sub
    Private Sub cargarPedidos()
        Dim pedidos As PedidoService = New PedidoService
        dgv_pedidos.AutoGenerateColumns = False
        dgv_pedidos.DataSource = ""
        dgv_pedidos.DataSource = pedidos.listarPedidosTerminados
        dgv_pedidos.Columns.Item(0).DataPropertyName = "id_pedido"
        dgv_pedidos.Columns.Item(1).DataPropertyName = "cliente"
        dgv_pedidos.Columns.Item(2).DataPropertyName = "fecha_pedido"
        dgv_pedidos.Columns.Item(3).DataPropertyName = "fecha_entrega"
        dgv_pedidos.Columns.Item(4).DataPropertyName = "total"
        dgv_pedidos.Columns.Item(5).DataPropertyName = "nro_factura"
        dgv_pedidos.Columns.Item(6).DataPropertyName = "efectivo"
        dgv_pedidos.Columns.Item(7).DataPropertyName = "descuento"
        dgv_pedidos.Columns.Item(8).DataPropertyName = "extra1"
        dgv_pedidos.Columns.Item(9).DataPropertyName = "extra2"
        dgv_pedidos.Columns.Item(10).DataPropertyName = "usuario"
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim ped As Pedido = dgv_pedidos.CurrentRow.DataBoundItem

        Dim service As PedidoService = New PedidoService
        Dim detalles As List(Of DetallePedido) = service.verDetalle(ped.id_pedido)

        dgv_detalles.AutoGenerateColumns = False
        dgv_detalles.DataSource = "" 'sirve para "resetear" el datasource
        dgv_detalles.DataSource = detalles
        dgv_detalles.Columns.Item(0).DataPropertyName = "id_detalle"
        dgv_detalles.Columns.Item(1).DataPropertyName = "precioU"
        dgv_detalles.Columns.Item(2).DataPropertyName = "cantidad"
        dgv_detalles.Columns.Item(3).DataPropertyName = "articulo"
    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick

        If Not dgv_pedidos.CurrentRow Is Nothing Then
            btn_buscar.Enabled = True
            lbl_id.Text = dgv_pedidos.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

End Class