Public Class Proveedor
    Public Property idProveedor As Integer
    Public Property razon_social As String
    Public Property direccion As String
    Public Property email As String
    Public Property telefono As String

    Public Overrides Function toString() As String
        Return razon_social
    End Function
End Class
