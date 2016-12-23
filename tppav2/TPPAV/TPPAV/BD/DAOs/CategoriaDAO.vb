Imports TPPAV

Public Class CategoriaDAO
    Friend Function getAll() As List(Of CategoriaArt)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT * FROM Categoria_articulo")

        Dim cat As CategoriaArt
        Dim listaCategorias As New List(Of CategoriaArt)
        For Each row As DataRow In data.Rows
            cat = New CategoriaArt()
            With cat
                .idCat = Convert.ToInt32(row.Item("Id_categoria").ToString)
                .nombre = row.Item("Nombre").ToString

                If Not IsDBNull(row.Item("Descripcion")) Then

                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If

            End With
            listaCategorias.Add(cat)
        Next
        Return listaCategorias
    End Function

    Friend Function update(cat As CategoriaArt) As Object
        Dim str = "UPDATE Categoria_articulo SET Nombre='" + cat.nombre + "',Descripcion='" + cat.descripcion + "' WHERE Id_categoria=" + cat.idCat.ToString
        Try
            Return BdHelper.getDBHelper.ejecutarSQL(str)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Friend Function eliminar(catid As Integer) As Object
        Dim str As String = "DELETE FROM Categoria_articulo WHERE Id_categoria=" + catid.ToString
        Try
            Return BdHelper.getDBHelper.ejecutarSQL(str)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Friend Function add(cat As CategoriaArt) As Object
        Dim strsql As String = "INSERT INTO Categoria_articulo (Nombre,Descripcion) VALUES ('" & cat.nombre & "','" + cat.descripcion + "')"
        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
