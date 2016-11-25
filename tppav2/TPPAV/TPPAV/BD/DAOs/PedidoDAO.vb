Imports TPPAV

Public Class PedidoDAO
    'modificado con nuevos campos 22-11'
    Friend Function getAll() As List(Of Pedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT p.*,c.Nombre as NombreC,u.Nombre as NombreU FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Usuarios u ON p.idUsuario=u.idUsuario")

        Dim ped As Pedido
        Dim listaPedidos As New List(Of Pedido)
        For Each row As DataRow In data.Rows
            ped = New Pedido()
            With ped
                .id_pedido = Convert.ToInt32(row.Item("Pedido_id").ToString)
                .fecha_pedido = Convert.ToDateTime(row.Item("Fecha_pedido").ToString)
                .cliente = New Cliente
                .cliente.nombre = row.Item("NombreC").ToString()
                If Not IsDBNull(row.Item("Fecha_entrega")) Then

                    .fecha_entrega = Convert.ToDateTime(row.Item("Fecha_entrega").ToString)
                Else
                    .fecha_entrega = Nothing
                End If
                .total = Convert.ToDouble(row.Item("Total").ToString)
                .nro_factura = Convert.ToInt32(row.Item("Nro_factura").ToString)
                If Not IsDBNull(row.Item("Descuento")) Then

                    .descuento = Convert.ToDouble(row.Item("Descuento").ToString)
                Else
                    .descuento = 0
                End If

                If Not IsDBNull(row.Item("Extra1")) Then

                    .extra1 = Convert.ToDouble(row.Item("Extra1").ToString)
                Else
                    .extra1 = 0
                End If

                If Not IsDBNull(row.Item("Extra2")) Then

                    .extra2 = Convert.ToDouble(row.Item("Extra2").ToString)
                Else
                    .extra2 = 0
                End If
                .efectivo = Convert.ToBoolean(row.Item("Efectivo").ToString)
                .usuario = New Usuario
                .usuario.nombre = row.Item("NombreU").ToString
            End With
            listaPedidos.Add(ped)
        Next
        Return listaPedidos
    End Function

    Friend Function getAllTerminados() As List(Of Pedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT p.*,c.Nombre as NombreC,u.Nombre as NombreU FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Usuarios u ON p.idUsuario=u.idUsuario WHERE p.Terminado=1")

        Dim ped As Pedido
        Dim listaPedidos As New List(Of Pedido)
        For Each row As DataRow In data.Rows
            ped = New Pedido()
            With ped
                .id_pedido = Convert.ToInt32(row.Item("Pedido_id").ToString)
                .fecha_pedido = Convert.ToDateTime(row.Item("Fecha_pedido").ToString)
                .cliente = New Cliente
                .cliente.nombre = row.Item("NombreC").ToString()
                If Not IsDBNull(row.Item("Fecha_entrega")) Then

                    .fecha_entrega = Convert.ToDateTime(row.Item("Fecha_entrega").ToString)
                Else
                    .fecha_entrega = Nothing
                End If
                .total = Convert.ToDouble(row.Item("Total").ToString)
                .nro_factura = Convert.ToInt32(row.Item("Nro_factura").ToString)
                If Not IsDBNull(row.Item("Descuento")) Then

                    .descuento = Convert.ToDouble(row.Item("Descuento").ToString)
                Else
                    .descuento = 0
                End If

                If Not IsDBNull(row.Item("Extra1")) Then

                    .extra1 = Convert.ToDouble(row.Item("Extra1").ToString)
                Else
                    .extra1 = 0
                End If

                If Not IsDBNull(row.Item("Extra2")) Then

                    .extra2 = Convert.ToDouble(row.Item("Extra2").ToString)
                Else
                    .extra2 = 0
                End If
                .efectivo = Convert.ToBoolean(row.Item("Efectivo").ToString)
                .usuario = New Usuario
                .usuario.nombre = row.Item("NombreU").ToString
            End With
            listaPedidos.Add(ped)
        Next
        Return listaPedidos
    End Function

    Friend Function getAllNoTerminados() As List(Of Pedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT p.*,c.Nombre as NombreC,u.Nombre as NombreU FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Usuarios u ON p.idUsuario=u.idUsuario WHERE p.Terminado=0")

        Dim ped As Pedido
        Dim listaPedidos As New List(Of Pedido)
        For Each row As DataRow In data.Rows
            ped = New Pedido()
            With ped
                .id_pedido = Convert.ToInt32(row.Item("Pedido_id").ToString)
                .fecha_pedido = Convert.ToDateTime(row.Item("Fecha_pedido").ToString)
                .cliente = New Cliente
                .cliente.nombre = row.Item("NombreC").ToString()
                If Not IsDBNull(row.Item("Fecha_entrega")) Then

                    .fecha_entrega = Convert.ToDateTime(row.Item("Fecha_entrega").ToString)
                Else
                    .fecha_entrega = Nothing
                End If
                .total = Convert.ToDouble(row.Item("Total").ToString)
                .nro_factura = Convert.ToInt32(row.Item("Nro_factura").ToString)
                If Not IsDBNull(row.Item("Descuento")) Then

                    .descuento = Convert.ToDouble(row.Item("Descuento").ToString)
                Else
                    .descuento = 0
                End If

                If Not IsDBNull(row.Item("Extra1")) Then

                    .extra1 = Convert.ToDouble(row.Item("Extra1").ToString)
                Else
                    .extra1 = 0
                End If

                If Not IsDBNull(row.Item("Extra2")) Then

                    .extra2 = Convert.ToDouble(row.Item("Extra2").ToString)
                Else
                    .extra2 = 0
                End If
                .efectivo = Convert.ToBoolean(row.Item("Efectivo").ToString)
                .usuario = New Usuario
                .usuario.nombre = row.Item("NombreU").ToString
            End With
            listaPedidos.Add(ped)
        Next
        Return listaPedidos
    End Function
    Friend Function getAllDeCliente(ByVal id As String) As DataTable
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT p.*,(c.Nombre + ' ' + c.Apellido) as Nombre, u.Nombre as NombreU FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Usuarios ON p.idUsuario=u.idUsuario WHERE p.Cliente_id=" + id)

        Return data
    End Function

    Friend Function getAllEntreFechas(ByVal desde As String, ByVal hasta As String) As DataTable
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT p.*,(c.Nombre + ' ' + c.Apellido) as Nombre, u.Nombre as NombreU FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Usuarios ON p.idUsuario=u.idUsuario WHERE p.Fecha_entrega BETWEEN '" + desde + "' AND '" + hasta + "'")

        Return data
    End Function

    Friend Function darDeBaja(id As Integer) As Integer
        Throw New NotImplementedException()
    End Function
    'modificado 22-11'
    Friend Function addPedido(ped As Pedido) As Integer
        Dim str As List(Of String) = New List(Of String)
        Dim efectivo As Integer
        If ped.efectivo Then
            efectivo = 1
        Else
            efectivo = 0
        End If
        'primero armamos el sql para registrar el pedido y lo agregamos a la lista
        str.Add("INSERT INTO Pedido (Cliente_id, Fecha_pedido, Fecha_entrega, Total, Nro_factura, Descuento, Efectivo, Extra1, Extra2, idUsuario) " +
            "VALUES (" + ped.cliente.idCliente.ToString + ", GETDATE(), @FechaEntrega," + ped.total.ToString.Replace(",", ".") + ", " + ped.nro_factura.ToString + ", " + ped.descuento.ToString.Replace(",", ".") +
            ", " + efectivo.ToString.Replace(",", ".") + ", " + ped.extra1.ToString.Replace(",", ".") + ", " + ped.extra2.ToString.Replace(",", ".") + ", " + ped.usuario.idUsuario.ToString + ")")
        'ahora añadimos cada uno de los detalles
        For i = 0 To ped.detalles.Count - 1
            Dim det As DetallePedido = ped.detalles.ElementAt(i)
            str.Add("INSERT INTO Detalle_pedido (Detalle_id, Pedido_id, Precio_unidad, Cantidad, Articulo_id) VALUES (" + (i + 1).ToString + ", @id, " + det.precioU.ToString.Replace(",", ".") + ", " + det.cantidad.ToString + ", " + det.articulo.idArticulo.ToString + ")")
        Next
        Return BdHelper.getDBHelper.ejecutarSQLTransaction(str, ped.fecha_entrega)
    End Function

    Friend Function verDetalles(id As Integer) As List(Of DetallePedido)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT d.Detalle_id as id, d.Precio_unidad as precioU , d.Cantidad as cant , a.Nombre as nomArt FROM Pedido p JOIN Detalle_pedido d ON
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
            End With
            listaDetalles.Add(det)
        Next
        Return listaDetalles
    End Function

    Friend Function terminarPedido(id As Integer) As Integer
        Return BdHelper.getDBHelper.ejecutarSQL("UPDATE Pedido SET Terminado=1 WHERE Pedido_id=" + id.ToString)
    End Function
End Class
