Public Class ClienteService
    Private clidao As ClienteDAO
    Public Sub New()
        clidao = New ClienteDAO()
    End Sub

    Public Function listarClientes() As List(Of Cliente)
        Return clidao.getAll()
    End Function

    Public Function darDeBajaCliente(id As Integer) As Integer
        Return clidao.darDeBaja(id)
    End Function

    Public Function agregarCliente(cli As Cliente) As Integer
        Return clidao.addCliente(cli)
    End Function

    Public Function updateCliente(cli As Cliente) As Integer
        Return clidao.updateCliente(cli)
    End Function
End Class
