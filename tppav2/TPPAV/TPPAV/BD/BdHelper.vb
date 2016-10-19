Imports System.Data.SqlClient

Public Class BdHelper
    Private Shared instance As BdHelper
    Private con As Conexion = New Conexion()
    Private Sub New()

    End Sub

    Public Shared Function getDBHelper() As BdHelper
        If IsNothing(instance) Then
            instance = New BdHelper()
        End If
        Return instance
    End Function

    Public Function ejecutarSQL(ByVal strSql As String) As Integer
        Try
            Dim comm = con.getCommander()
            comm.CommandText = strSql
            Return comm.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        End Try
    End Function

    Public Function ejecutarSQLTransaction(ByVal strSql As List(Of String), ByVal fecha As Date) As Integer
        Dim tran As SqlTransaction = Nothing
        Dim cmd As SqlCommand = New SqlCommand
        Dim comm As SqlConnection = New SqlConnection
        Try
            comm = con.getConnection()
            tran = comm.BeginTransaction


            cmd.Connection = comm
            cmd.CommandType = CommandType.Text
            cmd.Transaction = tran
            cmd.CommandText = strSql.ElementAt(0) 'REGISTRA EL PEDIDO'
            cmd.Parameters.AddWithValue("@FechaEntrega", fecha)
            Dim bandera As Integer = cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT MAX(Pedido_id) as id FROM Pedido"
            Dim tabla As DataTable = New DataTable
            tabla.Load(cmd.ExecuteReader)
            Dim idpedido As Integer = Convert.ToInt32(tabla.Rows.Item(0).Item("id"))
            cmd.Parameters.Clear()


            cmd.CommandText = "SET IDENTITY_INSERT Detalle_pedido ON"
            cmd.ExecuteNonQuery()

            cmd.Parameters.AddWithValue("@id", idpedido)
            For i = 1 To strSql.Count - 1
                cmd.CommandText = strSql.ElementAt(i)

                If cmd.ExecuteNonQuery() <> 1 Then
                    MsgBox("Error en la sentencia: " + strSql.ElementAt(i), MsgBoxStyle.Critical)
                    Throw New Exception
                End If

            Next
            cmd.CommandText = "SET IDENTITY_INSERT Detalle_pedido OFF"
            cmd.ExecuteNonQuery()
            tran.Commit()
            Return 1
        Catch ex As Exception
            tran.Rollback()
            Throw ex
        Finally
            ' Cierra la conexión
            tran.Dispose()
            comm.Close()
            comm.Dispose()
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim tabla As New DataTable
        Try
            Dim comm = con.getCommander()
            comm.CommandText = strSql
            tabla.Load(comm.ExecuteReader)
            Return tabla
        Catch ex As SqlException
            Throw ex
        End Try
    End Function
End Class
