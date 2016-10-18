Public Class Cliente
    Public Property idCliente As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property direccion As String
    Public Property barrio As Barrio
    Public Property telefono As Integer

    'Override al toString para poder llamarlo desde el dataGridView
    Public Overrides Function toString() As String
        Return nombre
    End Function

    Public Property fullname As String
        Get
            Return apellido & " " & nombre
        End Get
        Set(value As String)

        End Set
    End Property
End Class
