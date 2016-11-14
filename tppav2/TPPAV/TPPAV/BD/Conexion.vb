Imports System.Data.SqlClient

Public Class Conexion
    Private conexion_string As String = "Data Source=DESKTOP-QCJTRBS\MSQLSERVER;Initial Catalog=Tppav;Persist Security Info=True;User ID=sa;Password=dijstra"

    Public Function getCommander() As SqlCommand
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            conexion.ConnectionString = conexion_string
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            Return cmd
        Catch ex As Exception
            Throw ex
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function getConnection() As SqlConnection
        Dim conexion As New SqlConnection

        Try
            conexion.ConnectionString = conexion_string
            conexion.Open()

            Return conexion
        Catch ex As Exception
            Throw ex
            conexion.Close()
            conexion.Dispose()
        End Try
    End Function

End Class
