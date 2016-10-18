Public Class Pedido
    Public Property id_pedido As Integer
    Public Property fecha_pedido As DateTime
    Public Property fecha_entrega As DateTime
    Public Property total As Double
    Public Property nro_factura As Integer
    Public Property cliente As Cliente

    Public Property detalles As List(Of DetallePedido)
End Class
