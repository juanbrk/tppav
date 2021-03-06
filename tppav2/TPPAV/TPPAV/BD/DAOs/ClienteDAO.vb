﻿Imports TPPAV

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
                    .telefono = row.Item("Telefono").ToString
                Else
                    .telefono = "Sin telefono"
                End If
                If Not TypeOf row.Item("DNI") Is DBNull Then
                    .dni = row.Item("DNI").ToString
                Else
                    .dni = "Sin DNI/CUIT"
                End If
                If Not TypeOf row.Item("Descripcion") Is DBNull Then
                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If
                If Not TypeOf row.Item("Mail") Is DBNull Then
                    .mail = row.Item("Mail").ToString
                Else
                    .mail = "Sin mail"
                End If
            End With
            clientes.Add(cli)
        Next

        Return clientes
    End Function

    Friend Function pedidosPorMes(mes As Integer) As DataTable
        Dim str As String = "SELECT c.Cliente_id,c.Nombre,c.Apellido,COUNT(p.Pedido_id) FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id " +
            "WHERE MONTH(p.Fecha_entrega)=" + mes.ToString +
            " GROUP BY c.Cliente_id,c.Nombre,c.Apellido"
        Return BdHelper.getDBHelper.ConsultaSQL(str)
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
        Dim strsql As String = "INSERT INTO Clientes (Nombre,Apellido,Direccion,Telefono,barrio_id,Mail,DNI,Descripcion) VALUES ('" & cli.nombre & "','" &
            cli.apellido & "','" & cli.direccion & "', " & cli.telefono & ", " & cli.barrio.ID_BARRIO & ",'" & cli.mail & "','" & cli.dni & "','" & cli.descripcion & "')"
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function updateCliente(ByVal cli As Cliente) As Integer
        Dim strsql As String = "UPDATE Clientes SET Nombre='" & cli.nombre & "', Apellido='" & cli.apellido & "', Direccion='" & cli.direccion & "', barrio_id=" &
            cli.barrio.ID_BARRIO & ", Telefono=" & cli.telefono & ", Mail='" & cli.mail & "', DNI='" & cli.dni & "', Descripcion='" & cli.descripcion & "' WHERE Cliente_id=" & cli.idCliente
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
