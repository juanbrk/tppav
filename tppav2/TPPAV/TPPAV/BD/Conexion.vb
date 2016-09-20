Public Class Conexion
    Private conexion_string As String = "Provider=SQLOLEDB;Data Source=DESKTOP-HK05I7G\SQLEXPRESS;Initial Catalog=Tppav;Persist Security Info=True;User ID=sa;Password=thyssenkrupps"

    Public Function getCommander() As OleDb.OleDbCommand
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand

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

End Class
