Public Class Articulo
    Public Property idArticulo As Integer
    Public Property nombre As String
    Public Property descripcion As String
    Public Property precioU As Double
    Public Property categoria As CategoriaArt
    Public Property proveedor As Proveedor
    Public Property talle As Talle
    Public Overrides Function toString() As String
        Return nombre
    End Function
End Class
