Public Class TalleService
    Dim talleDao As New TalleDAO

    Public Function getall() As List(Of Talle)
        Return talleDao.getAll()
    End Function
End Class
