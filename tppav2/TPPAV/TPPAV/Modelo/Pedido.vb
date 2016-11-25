Public Class Pedido
    Public Property id_pedido As Integer
    Public Property fecha_pedido As DateTime
    Public Property fecha_entrega As DateTime
    Public Property total As Double
    Public Property nro_factura As Integer
    Public Property cliente As Cliente

    Public Property detalles As List(Of DetallePedido)

    Public Property descuento As Double
    Public Property extra1 As Double
    Public Property extra2 As Double
    Public Property usuario As Usuario
    Public Property efectivo As Boolean
End Class
