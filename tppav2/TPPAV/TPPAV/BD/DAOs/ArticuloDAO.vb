Imports TPPAV

Public Class ArticuloDAO
    Friend Function getAll() As List(Of Articulo)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT a.*, c.Nombre as nomart, p.Razon_social as nomprov FROM Articulo a JOIN Categoria_articulo c on a.Categoria_id=c.Id_categoria LEFT JOIN Proveedores p ON p.Id_proveedor=a.Proveedor_id")

        Dim art As Articulo
        Dim listaArticulos As New List(Of Articulo)
        For Each row As DataRow In data.Rows
            art = New Articulo()
            With art
                .idArticulo = Convert.ToInt32(row.Item("Id_articulo").ToString)
                .nombre = row.Item("Nombre").ToString
                .categoria = New CategoriaArt
                .categoria.nombre = row.Item("nomart").ToString()
                If Not IsDBNull(row.Item("nomprov")) Then
                    .proveedor = New Proveedor
                    .proveedor.razon_social = row.Item("nomprov").ToString()
                Else
                    '.precioCaja = Nothing
                End If

                If Not IsDBNull(row.Item("Precio_caja")) Then

                    .precioCaja = Convert.ToDouble(row.Item("Precio_caja").ToString)
                Else
                    .precioCaja = Nothing
                End If
                If Not IsDBNull(row.Item("Descripcion")) Then

                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If

            End With
            listaArticulos.Add(art)
        Next
        Return listaArticulos
    End Function

    Friend Function articulosDeCategoria(catID As String) As List(Of Articulo)
        Dim data As DataTable = BdHelper.getDBHelper.ConsultaSQL("SELECT a.*, c.Nombre as nomart, p.Razon_social as nomprov FROM Articulo a JOIN Categoria_articulo c on a.Categoria_id=c.Id_categoria LEFT JOIN Proveedores p ON p.Id_proveedor=a.Proveedor_id WHERE a.Categoria_id=" + catID)

        Dim art As Articulo
        Dim listaArticulos As New List(Of Articulo)
        For Each row As DataRow In data.Rows
            art = New Articulo()
            With art
                .idArticulo = Convert.ToInt32(row.Item("Id_articulo").ToString)
                .nombre = row.Item("Nombre").ToString
                .categoria = New CategoriaArt
                .categoria.nombre = row.Item("nomart").ToString()
                If Not IsDBNull(row.Item("nomprov")) Then
                    .proveedor = New Proveedor
                    .proveedor.razon_social = row.Item("nomprov").ToString()
                Else
                    '.precioCaja = Nothing
                End If
                If Not IsDBNull(row.Item("Precio_caja")) Then

                    .precioCaja = Convert.ToDouble(row.Item("Precio_caja").ToString)
                Else
                    .precioCaja = Nothing
                End If
                If Not IsDBNull(row.Item("Descripcion")) Then

                    .descripcion = row.Item("Descripcion").ToString
                Else
                    .descripcion = "Sin descripcion"
                End If

            End With
            listaArticulos.Add(art)
        Next
        Return listaArticulos
    End Function

    Friend Function getIdNuevoArticulo() As Integer
        Throw New NotImplementedException()
    End Function

    Friend Function darDeBaja(id As Integer) As Integer
        Throw New NotImplementedException()
    End Function

    Friend Function addArticulo(art As Articulo) As Integer
        Dim strsql As String
        If art.proveedor Is Nothing Then
            strsql = "INSERT INTO Articulo (Nombre,Descripcion,Precio_unidad,Precio_caja,Categoria_id) VALUES ('" + art.nombre + "','" +
            art.descripcion + "'," + art.precioU.ToString + ", " + art.precioCaja.ToString + ", " + art.categoria.idCat.ToString + ")"
        Else
            strsql = "INSERT INTO Articulo (Nombre,Descripcion,Precio_unidad,Precio_caja,Categoria_id,Proveedor_id) VALUES ('" + art.nombre + "','" +
            art.descripcion + "'," + art.precioU.ToString + ", " + art.precioCaja.ToString + ", " + art.categoria.idCat.ToString + "," + art.proveedor.idProveedor.ToString + ")"
        End If

        Try
            Return BdHelper.getDBHelper().ejecutarSQL(strsql)
        Catch ex As Exception
            Throw ex
            Return 0
        End Try
    End Function

    Friend Function updateArticulo(art As Articulo) As Integer
        Throw New NotImplementedException()
    End Function
End Class
