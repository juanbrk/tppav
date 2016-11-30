Imports TPPAV
Public Class BarrioDao
    Friend Function getAll() As List(Of Barrio)
        Dim nuevoBarrio As Barrio
        Dim listaBarrios As New List(Of Barrio)
        Dim strSQL = "SELECT * FROM Barrio"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Bug a partir de los datos de la/s filas de la tabla Bugs

        For Each row As DataRow In BdHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            nuevoBarrio = New Barrio()
            With nuevoBarrio
                .ID_BARRIO = Convert.ToInt32(row.Item("id_barrio").ToString)
                .nombre = row.Item("nombre").ToString
                .provincia = row.Item("provincia").ToString
            End With
            listaBarrios.Add(nuevoBarrio)
        Next

        Return listaBarrios
    End Function

    Public Function getIdNuevoBarrio() As Integer
        Dim strSQL = "SELECT MAX (id_barrio) as id FROM Barrio"
        Dim countTablaBarrios = BdHelper.getDBHelper().ConsultaSQL(strSQL).Rows.Item(0).Item("id").ToString
        Return countTablaBarrios + 1

    End Function

    Public Function darDeBaja(ByVal idBarrio As Integer) As Integer
        Dim strsql As String = "DELETE FROM Barrio WHERE id_barrio=" & idBarrio
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch Ex As Exception
            Throw Ex
        End Try

    End Function

    Public Function addBarrio(ByVal barrioIngresado As Barrio) As Integer
        Dim strsql As String = "INSERT INTO Barrio (nombre,provincia) VALUES ('" & barrioIngresado.nombre & "','" & barrioIngresado.provincia & "')"
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function updateBarrio(ByVal barrioAActualizar As Barrio) As Integer
        Dim strsql As String = "UPDATE Barrio SET  nombre='" & barrioAActualizar.nombre & "',provincia='" & barrioAActualizar.provincia & "' WHERE id_barrio=" & barrioAActualizar.ID_BARRIO
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ventasXBarrioXMes(ByVal mes As String, ByVal año As String) As DataTable
        Dim tabla As DataTable
        If mes <> 0 Then
            tabla = BdHelper.getDBHelper.ConsultaSQL("SELECT p.Pedido_id, p.Total, b.nombre, b.provincia FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Barrio b ON b.id_barrio=c.barrio_id WHERE YEAR(p.Fecha_entrega)='" + año + "' AND MONTH(p.Fecha_entrega)='" + mes + "'")
        Else
            tabla = BdHelper.getDBHelper.ConsultaSQL("SELECT p.Pedido_id, p.Total, b.nombre, b.provincia FROM Pedido p JOIN Clientes c ON p.Cliente_id=c.Cliente_id JOIN Barrio b ON b.id_barrio=c.barrio_id")

        End If
        Return tabla
    End Function

End Class
