Imports TPPAV

Public Class ClienteDAO
    Friend Function getAll() As List(Of Cliente)
        Dim cli As Cliente
        Dim clientes As New List(Of Cliente)
        Dim strSQL = "SELECT c.*,b.id_barrio as idbar,b.nombre as nombar  FROM Clientes c JOIN Barrio b ON c.barrio_id=b.id_barrio"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Bug a partir de los datos de la/s filas de la tabla Bugs

        For Each row As DataRow In BdHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            cli = New Cliente()
            With cli
                .idCliente = Convert.ToInt32(row.Item("Cliente_id").ToString)
                .nombre = row.Item("Nombre").ToString
                .apellido = row.Item("Apellido").ToString
                .direccion = row.Item("Direccion").ToString
                .barrio = New Barrio
                .barrio.ID_BARRIO = Convert.ToInt32(row.Item("idbar").ToString)
                .barrio.nombre = row.Item("nombar").ToString
                '.zona = row.Item("Zona").ToString cambiar para conseguir el barrio
                If Not TypeOf row.Item("Telefono") Is DBNull Then
                    .telefono = Convert.ToInt32(row.Item("Telefono").ToString)
                Else
                    .telefono = 0
                End If
            End With
            clientes.Add(cli)
        Next

        Return clientes
    End Function

    Public Function darDeBaja(ByVal id As Integer) As Integer
        Dim strsql As String = "DELETE FROM Clientes WHERE Cliente_id=" & id
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch Ex As Exception
            Throw Ex
        End Try

    End Function

    Public Function addCliente(ByVal cli As Cliente) As Integer
        Dim strsql As String = "INSERT INTO Clientes (Nombre,Apellido,Direccion,Telefono,barrio_id) VALUES ('" & cli.nombre & "','" &
            cli.apellido & "','" & cli.direccion & "', " & cli.telefono & ", " & cli.barrio.ID_BARRIO & ")"
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function updateCliente(ByVal cli As Cliente) As Integer
        Dim strsql As String = "UPDATE Clientes SET Nombre='" & cli.nombre & "', Apellido='" & cli.apellido & "', Direccion='" & cli.direccion & "', id_barrio=" &
            cli.barrio.ID_BARRIO & ", Telefono=" & cli.telefono & " WHERE Cliente_id=" & cli.idCliente
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
