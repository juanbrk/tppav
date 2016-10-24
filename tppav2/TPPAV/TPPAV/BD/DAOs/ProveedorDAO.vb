Imports TPPAV

Public Class ProveedorDAO
    Friend Function getAll() As List(Of Proveedor)
        Dim nuevoProveedor As Proveedor
        Dim listaProveedores As New List(Of Proveedor)
        Dim strSQL = "SELECT * FROM Proveedores"

        For Each row As DataRow In BdHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            nuevoProveedor = New Proveedor()
            With nuevoProveedor
                .idProveedor = Convert.ToInt32(row.Item("Id_proveedor").ToString)
                .razon_social = row.Item("Razon_social").ToString

                If Not IsDBNull(row.Item("Direccion")) Then
                    .direccion = row.Item("Direccion").ToString
                End If
                If Not IsDBNull(row.Item("Email")) Then
                    .email = row.Item("Email").ToString
                End If
                If Not IsDBNull(row.Item("Telefono")) Then
                    .telefono = row.Item("Telefono").ToString
                End If

            End With
            listaProveedores.Add(nuevoProveedor)
        Next

        Return listaProveedores
    End Function

    Friend Function darDeBaja(id As Integer) As Integer
        Throw New NotImplementedException()
    End Function

    Friend Function addProveedor(prov As Proveedor) As Integer
        Dim str As String = "INSERT INTO Proveedores (Razon_social, Direccion, Email, Telefono) VALUES ('" + prov.razon_social + "','" + prov.direccion + "','" + prov.email + "','" + prov.telefono + "')"
        Return BdHelper.getDBHelper.ejecutarSQL(str)
    End Function

    Friend Function updateProveedor(prov As Proveedor) As Integer
        Dim str As String = "UPDATE Proveedores SET Razon_social='" + prov.razon_social + "', Direccion='" + prov.direccion + "', Email='" + prov.email + "', Telefono='" + prov.telefono + "'"
        Return BdHelper.getDBHelper.ejecutarSQL(str)
    End Function
End Class
