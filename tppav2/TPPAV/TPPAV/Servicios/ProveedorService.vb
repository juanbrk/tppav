Public Class ProveedorService
    Private provDAO As ProveedorDAO
    Public Sub New()
        provDAO = New ProveedorDAO()
    End Sub

    Public Function listarProveedores() As List(Of Proveedor)
        Return provDAO.getAll()
    End Function

    Public Function darProveedorDeBaja(id As Integer) As Integer
        Return provDAO.darDeBaja(id)
    End Function

    Public Function agregarProveedor(prov As Proveedor) As Integer
        Return provDAO.addProveedor(prov)
    End Function

    Public Function updateProveedor(prov As Proveedor) As Integer
        Return provDAO.updateProveedor(prov)
    End Function
End Class
