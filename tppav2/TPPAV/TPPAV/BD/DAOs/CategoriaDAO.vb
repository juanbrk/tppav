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
End Class
