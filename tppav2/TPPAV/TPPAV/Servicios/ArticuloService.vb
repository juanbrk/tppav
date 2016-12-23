Public Class ArticuloService
    Private artDao As ArticuloDao
    Public Sub New()
        artDao = New ArticuloDao()
    End Sub

    Public Function listarArticulos() As List(Of Articulo)
        Return artDao.getAll()
    End Function

    Public Function listarArticulosDeCategoria(catID As String) As List(Of Articulo)
        Return artDao.articulosDeCategoria(catID)
    End Function
    Public Function getCountArticulos() As Integer
        Return artDao.getIdNuevoArticulo()
    End Function

    Public Function darDeBajaArticulo(id As Integer) As Integer
        Return artDao.darDeBaja(id)
    End Function

    Public Function agregarArticulo(art As Articulo) As Integer
        Return artDao.addArticulo(art)
    End Function

    Public Function updateArticulo(art As Articulo) As Integer
        Return artDao.updateArticulo(art)
    End Function
End Class
