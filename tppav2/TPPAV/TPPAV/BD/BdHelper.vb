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
        Catch ex As OleDb.OleDbException
            Throw Ex
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        Dim tabla As New DataTable
        Try
            Dim comm = con.getCommander()
            comm.CommandText = strSql
            tabla.Load(comm.ExecuteReader)
            Return tabla
        Catch ex As OleDb.OleDbException
            Throw ex
        End Try
    End Function
End Class
