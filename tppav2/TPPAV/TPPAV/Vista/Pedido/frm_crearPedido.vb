Public Class frm_crearPedido
    Dim detalles As List(Of DetallePedido) = New List(Of DetallePedido)
    Private Sub frm_crearPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarClientes()
        dgv_detalles.AutoGenerateColumns = False
        txt_total.Text = ""
        lbl_neto.Text = ""
        dtp_entrega.MinDate = DateTime.Today
        Dim usuario As Usuario = Me.Tag
        lbl_usuario.Text = usuario.nombre
        lbl_prendas.Text = "0"
    End Sub

    Public Sub cargarClientes()
        Dim client_service As ClienteService = New ClienteService
        Dim clientes As List(Of Cliente) = client_service.listarClientes

        cbo_cliente.DataSource = clientes
        cbo_cliente.DisplayMember = "fullname"
        cbo_cliente.ValueMember = "idCliente"
    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        Dim add As frm_addClientes = New frm_addClientes

        Dim res As DialogResult = add.ShowDialog()
        'Dim result As DialogResult = add.ShowDialog(Me)
        If res = DialogResult.OK Then
            Me.cargarClientes()
        End If

    End Sub

    Private Function contarPrendas() As Integer
        Dim cant As Integer = 0
        For Each detalle As DetallePedido In detalles
            cant += detalle.cantidad
        Next
        Return cant
    End Function

    Private Sub btn_detalle_Click(sender As Object, e As EventArgs) Handles btn_detalle.Click
        Dim add As frm_addDetalle = New frm_addDetalle
        Dim res As DialogResult = add.ShowDialog()
        If res = DialogResult.OK Then
            Dim detail As DetallePedido = add.obtenerDetalle()
            detalles.Add(detail)
            cargarGrilla
        End If


    End Sub

    Private Sub cargarGrilla()
        'dgv_detalles.Rows.Clear()
        dgv_detalles.DataSource = ""
        dgv_detalles.DataSource = detalles
        dgv_detalles.Columns.Item(0).DataPropertyName = "articulo"
        dgv_detalles.Columns.Item(1).DataPropertyName = "cantidad"
        dgv_detalles.Columns.Item(2).DataPropertyName = "precioU"

        Dim total As Double = calcularTotal()
        txt_total.Text = "$ " & total.ToString
        actualizarNeto(total)
        lbl_prendas.Text = contarPrendas.ToString
    End Sub

    Private Function calcularTotal() As Double
        Dim total As Double = 0
        For Each det As DetallePedido In detalles
            total += det.cantidad * det.precioU
        Next
        Return total
    End Function

    Public Sub actualizarNeto(ByVal total As Double)
        Dim desc As Double = 0
        Dim extra1 As Double = 0
        Dim extra2 As Double = 0
        If Not txt_extra1.Text Is String.Empty Then
            Try
                extra1 = Double.Parse(txt_extra1.Text)
            Catch ex As Exception

            End Try
        End If
        If Not txt_descuento.Text Is String.Empty Then
            Try
                desc = Double.Parse(txt_descuento.Text)
            Catch ex As Exception

            End Try
        End If
        If Not txt_extra2.Text Is String.Empty Then
            Try
                extra2 = Double.Parse(txt_extra2.Text)
            Catch ex As Exception

            End Try
        End If



        lbl_neto.Text = "$ " & (total - desc + extra1 + extra2).ToString



    End Sub


    Private Sub btn_reg_pedido_Click(sender As Object, e As EventArgs) Handles btn_reg_pedido.Click

        If detalles.Count = 0 Then
            MsgBox("Primero debe agregar detalles", MsgBoxStyle.Critical)
            Return
        End If
        Dim pedido As Pedido = New Pedido
        pedido.cliente = cbo_cliente.SelectedItem
        pedido.fecha_entrega = dtp_entrega.Value

        If txt_nro_factura.Text = String.Empty Then
            MsgBox("Debe ingresar un numero de factura", MsgBoxStyle.Exclamation)
            Return
        Else
            Try
                pedido.nro_factura = Convert.ToInt32(txt_nro_factura.Text.ToString)
            Catch ex As Exception
                MsgBox("Solo puede ingresar numeros en el numero de factura", MsgBoxStyle.Exclamation)
                Return
            End Try
        End If

        If txt_extra1.Text Is String.Empty Then
            pedido.extra1 = 0
        Else
            Try
                pedido.extra1 = Double.Parse(txt_extra1.Text)
            Catch ex As Exception

            End Try
        End If

        If txt_extra2.Text Is String.Empty Then
            pedido.extra2 = 0
        Else
            Try
                pedido.extra2 = Double.Parse(txt_extra2.Text)
            Catch ex As Exception

            End Try
        End If

        If txt_descuento.Text Is String.Empty Then
            pedido.descuento = 0
        Else
            Try
                pedido.descuento = Double.Parse(txt_descuento.Text)
            Catch ex As Exception

            End Try
        End If
        pedido.efectivo = cb_efectivo.Checked
        pedido.detalles = detalles
        pedido.total = calcularTotal()
        pedido.usuario = Me.Tag

        Dim pedidoservice As PedidoService = New PedidoService
        If pedidoservice.agregarPedido(pedido) = 1 Then
            MsgBox("Se ha registrado el pedido!", MsgBoxStyle.Information, "Base de Datos")
            Me.Close()
        Else
            MsgBox("Hubo un error al registrar el pedido")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_descuento_TextChanged(sender As Object, e As EventArgs) Handles txt_descuento.TextChanged
        actualizarNeto(calcularTotal)
    End Sub
    Private Sub txt_extra1_TextChanged(sender As Object, e As EventArgs) Handles txt_extra1.TextChanged
        actualizarNeto(calcularTotal)
    End Sub
    Private Sub txt_extra2_TextChanged(sender As Object, e As EventArgs) Handles txt_extra2.TextChanged
        actualizarNeto(calcularTotal)
    End Sub
End Class