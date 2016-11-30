Public Class TalleDAO
    Public Function getAll() As List(Of Talle)
        Dim tabla As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT * FROM Talle")
        Dim lista As New List(Of Talle)
        For Each row As DataRow In tabla.Rows
            Dim tal As New Talle
            tal.idTalle = Integer.Parse(row.Item("idTalle").ToString)
            tal.nombre = row.Item("nombre").ToString
            lista.Add(tal)
        Next

        Return lista
    End Function
End Class
