Imports TPPAV

Public Class ArticuloDAO
    Friend Function getAll() As List(Of Articulo)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT a.*, c.Nombre as nomart, p.Razon_social as nomprov,t.nombre as tallenom FROM Articulo a JOIN Categoria_articulo c on a.Categoria_id=c.Id_categoria JOIN Proveedores p ON p.Id_proveedor=a.Proveedor_id JOIN Talle t ON a.Talle_id=t.idTalle")

        Dim art As Articulo
        Dim listaArticulos As New List(Of Articulo)
        For Each row As DataRow In data.Rows
            art = New Articulo()
            With art
                .idArticulo = Convert.ToInt32(row.Item("Id_articulo").ToString)
                .nombre = row.Item("Nombre").ToString
                .categoria = New CategoriaArt
                .categoria.nombre = row.Item("nomart").ToString()
                .proveedor = New Proveedor
                .proveedor.razon_social = row.Item("nomprov").ToString()
                If Not IsDBNull(row.Item("Descripcion")) Then

                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If
                .talle = New Talle
                .talle.nombre = row.Item("tallenom").ToString
            End With
            listaArticulos.Add(art)
        Next
        Return listaArticulos
    End Function

    Friend Function articulosDeCategoria(catID As String) As List(Of Articulo)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT a.*, c.Nombre as nomart, p.Razon_social as nomprov, t.nombre as tallenom FROM Articulo a JOIN Categoria_articulo c on a.Categoria_id=c.Id_categoria LEFT JOIN Proveedores p ON a.Proveedor_id=p.Id_proveedor JOIN Talle t ON a.Talle_id=t.idTalle WHERE a.Categoria_id=" + catID)

        Dim art As Articulo
        Dim listaArticulos As New List(Of Articulo)
        For Each row As DataRow In data.Rows
            art = New Articulo()
            With art
                .idArticulo = Convert.ToInt32(row.Item("Id_articulo").ToString)
                .nombre = row.Item("Nombre").ToString
                .categoria = New CategoriaArt
                .categoria.nombre = row.Item("nomart").ToString()
                .precioU = Double.Parse(row.Item("Precio_unidad").ToString)
                If Not IsDBNull(row.Item("Descripcion")) Then

                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If
                .proveedor = New Proveedor
                If Not IsDBNull(row.Item("nomprov")) Then

                    .proveedor.razon_social = row.Item("nomprov").ToString
                Else
                    .proveedor.razon_social = "Sin proveedor"
                End If
                .talle = New Talle
                .talle.nombre = row.Item("tallenom").ToString
            End With
            listaArticulos.Add(art)
        Next
        Return listaArticulos
    End Function

    Friend Function getIdNuevoArticulo() As Integer
        Throw New NotImplementedException()
    End Function

    Friend Function darDeBaja(id As Integer) As Integer
        Dim str As String = "DELETE FROM Articulo WHERE Id_articulo=" + id.ToString
        Try
            Return BdHelper.getDBHelper.ejecutarSQL(str)
        Catch e As Exception
            Return 0
        End Try

    End Function

    Friend Function addArticulo(art As Articulo) As Integer
        Dim strsql As String
        If art.proveedor Is Nothing Then
            strsql = "INSERT INTO Articulo (Nombre,Descripcion,Precio_unidad,Categoria_id,Talle_id) VALUES ('" + art.nombre + "','" +
            art.descripcion + "'," + art.precioU.ToString + ", " + art.categoria.idCat.ToString + "," + art.talle.idTalle.ToString + ")"
        Else
            strsql = "INSERT INTO Articulo (Nombre,Descripcion,Precio_unidad,Categoria_id,Proveedor_id,Talle_id) VALUES ('" + art.nombre + "','" +
            art.descripcion + "'," + art.precioU.ToString + ", " + art.categoria.idCat.ToString + "," + art.proveedor.idProveedor.ToString + "," + art.talle.idTalle.ToString + ")"
        End If

        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
            Return 0
        End Try
    End Function

    Friend Function updateArticulo(art As Articulo) As Integer
        Dim str As String
        If art.proveedor Is Nothing Then
            str = "UPDATE Articulo SET Nombre='" & art.nombre & "',Descripcion='" & art.descripcion & "',Precio_Unidad=" & art.precioU.ToString & ",Categoria_id=" & art.categoria.idCat.ToString & ",Proveedor_id=NULL, Talle_id=" & art.talle.idTalle.ToString & " WHERE Id_articulo=" & art.idArticulo.ToString
        Else
            str = "UPDATE Articulo SET Nombre='" & art.nombre & "',Descripcion='" & art.descripcion & "',Precio_Unidad=" & art.precioU.ToString & ",Categoria_id=" & art.categoria.idCat.ToString & ",Proveedor_id=" & art.proveedor.idProveedor.ToString & ",Talle_id=" & art.talle.idTalle.ToString & " WHERE Id_articulo=" & art.idArticulo.ToString
        End If
        Try
            Return BdHelper.getDBHelper.ejecutarSQL(str)
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
