Public Class frm_usrLogin
    Public cnn_string As String = "Data Source=DESKTOP-HK05I7G\SQLEXPRESS I  3k52016\Clase02\First ConnectionDB\Data Source\UsersDB.mdb"

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim cnn As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim table As New Data.DataTable

        'Asignamos la cadena de conexión al objeto Connection
        cnn.ConnectionString = cnn_string
        'Abrimos la conexión
        cnn.Open()
        'Asociamos el objeto Command con la conexión abierta
        cmd.Connection = cnn
        'Definimos el tipo de comando a ejecutar como cadena
        cmd.CommandType = CommandType.Text
        'Asignamos la sentencia SQL a ejecutar mediante el objeto Command
        cmd.CommandText = "Select * From users where n_usuario='" & txt_usuario.Text & "' AND password='" & txt_password.Text & "'"
        'Ejecutamos el comando validando que la sentencia recupera al menos una fila
        table.Load(cmd.ExecuteReader)
        If table.Rows.Count > 0 Then
            lbl_mensaje.ForeColor = Color.Green
            lbl_mensaje.Text = "Bienvenido usuario: " + table.Rows(0).Item("n_real").ToString
        Else
            lbl_mensaje.ForeColor = Color.Red
            lbl_mensaje.Text = "Usuario o clave incorrectos"
        End If

        'Cerramos la conexión
        cnn.Close()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
