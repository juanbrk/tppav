Public Class Usuario
    Public Property idUsuario As Integer
    Public Property nombre As String

    Public Overrides Function toString() As String
        Return nombre
    End Function
End Class
