Public Class BarrioService
    Private barrdao As BarrioDao
    Public Sub New()
        barrdao = New BarrioDao()
    End Sub

    Public Function listarBarrios() As List(Of Barrio)
        Return barrdao.getAll()
    End Function
    Public Function getCountBarrios() As Integer
        Return barrdao.getIdNuevoBarrio()
    End Function

    Public Function darDeBajaBarrio(id As Integer) As Integer
        Return barrdao.darDeBaja(id)
    End Function

    Public Function agregarBarrio(unBarrio As Barrio) As Integer
        Return barrdao.addBarrio(unBarrio)
    End Function

    Public Function updateBarrio(unBarrio As Barrio) As Integer
        Return barrdao.updateBarrio(unBarrio)
    End Function

End Class
