Imports TPPAV

Public Class PedidoDAO
    Friend Function getAll() As List(Of Pedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT * FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id")

        Dim ped As Pedido
        Dim listaPedidos As New List(Of Pedido)
        For Each row As DataRow In data.Rows
            ped = New Pedido()
            With ped
                .id_pedido = Convert.ToInt32(row.Item("Pedido_id").ToString)
                .fecha_pedido = Convert.ToDateTime(row.Item("Fecha_pedido").ToString)
                .cliente = New Cliente
                .cliente.nombre = row.Item("Nombre").ToString()
                If Not IsDBNull(row.Item("Fecha_entrega")) Then

                    .fecha_entrega = Convert.ToDateTime(row.Item("Fecha_entrega").ToString)
                Else
                    .fecha_entrega = Nothing
                End If
                .total = Convert.ToDouble(row.Item("Total").ToString)
                .nro_factura = Convert.ToInt32(row.Item("Nro_factura").ToString)
            End With
            listaPedidos.Add(ped)
        Next
        Return listaPedidos
    End Function

    Friend Function darDeBaja(id As Integer) As Integer
        Throw New NotImplementedException()
    End Function

    Friend Function addPedido(ped As Pedido) As Integer
        Dim str As List(Of String) = New List(Of String)
        'primero armamos el sql para registrar el pedido y lo agregamos a la lista
        str.Add("INSERT INTO Pedido (Cliente_id, Fecha_pedido, Fecha_entrega, Total, Nro_factura) VALUES (" + ped.cliente.idCliente.ToString + ", GETDATE(), @FechaEntrega," + ped.total.ToString + ", " + ped.nro_factura.ToString + ")")
        'ahora añadimos cada uno de los detalles
        For i = 0 To ped.detalles.Count - 1
            Dim det As DetallePedido = ped.detalles.ElementAt(i)
            str.Add("INSERT INTO Detalle_pedido (Detalle_id, Pedido_id, Precio_unidad, Cantidad, Descuento, Articulo_id) VALUES (" + (i + 1).ToString + ", @id, " + det.precioU.ToString + ", " + det.cantidad.ToString + ", " + det.descuento.ToString + ", " + det.articulo.idArticulo.ToString + ")")
        Next
        Return BdHelper.getDBHelper.ejecutarSQLTransaction(str, ped.fecha_entrega)
    End Function

    Friend Function verDetalles(id As Integer) As List(Of DetallePedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT d.Detalle_id as id, d.Precio_unidad as precioU , d.Cantidad as cant , d.Descuento as dec , a.Nombre as nomArt FROM Pedido p JOIN Detalle_pedido d ON
                                   p.Pedido_id=d.Pedido_id JOIN Articulo a ON a.Id_articulo=d.Articulo_id WHERE p.Pedido_id=" & id.ToString)
        Dim det As DetallePedido
        Dim listaDetalles As New List(Of DetallePedido)
        For Each row As DataRow In data.Rows
            det = New DetallePedido()
            With det
                .id_detalle = Convert.ToInt32(row.Item("id").ToString)
                .precioU = Convert.ToDouble(row.Item("precioU").ToString)
                .articulo = New Articulo
                .articulo.nombre = row.Item("nomArt").ToString()
                .cantidad = Convert.ToInt32(row.Item("cant").ToString)
                .descuento = Convert.ToDouble(row.Item("dec").ToString)
            End With
            listaDetalles.Add(det)
        Next
        Return listaDetalles
    End Function
End Class
