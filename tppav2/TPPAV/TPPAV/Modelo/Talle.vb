Public Class Talle
    Property idTalle As Integer
    Property nombre As String

    Public Overrides Function toString() As String
        Return nombre
    End Function
End Class
