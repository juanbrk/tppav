﻿Public Class PedidoService
    Private pedidao As PedidoDAO
    Public Sub New()
        pedidao = New PedidoDAO()
    End Sub

    Public Function listarPedidos() As List(Of Pedido)
        Return pedidao.getAll()
    End Function

    Public Function darDeBajaPedido(id As Integer) As Integer
        Return pedidao.darDeBaja(id)
    End Function

    Public Function agregarPedido(ped As Pedido) As Integer
        Return pedidao.addPedido(ped)
    End Function

    Public Function verDetalle(id As Integer) As List(Of DetallePedido)
        Return pedidao.verDetalles(id)
    End Function


End Class
