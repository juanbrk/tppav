Public Class CategoriaService
    Private catDao As CategoriaDAO
    Public Sub New()
        catDao = New CategoriaDAO()
    End Sub

    Public Function listarCategorias() As List(Of CategoriaArt)
        Return catDao.getAll()
    End Function

    Public Function addCategoria(ByVal cat As CategoriaArt)
        Return catDao.add(cat)
    End Function
End Class
