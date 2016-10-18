Public Class frm_crearPedido
    Dim detalles As List(Of DetallePedido) = New List(Of DetallePedido)
    Private Sub frm_crearPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarClientes()
        dgv_detalles.AutoGenerateColumns = False
        txt_total.Text = ""
        dtp_entrega.MinDate = DateTime.Today
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
        dgv_detalles.Columns.Item(3).DataPropertyName = "descuento"

        txt_total.Text = "$ " & calcularTotal()
    End Sub

    Private Function calcularTotal() As Integer
        Dim total As Double = 0
        For Each det As DetallePedido In detalles
            total += (det.cantidad * det.precioU) - det.descuento
        Next
        Return total
    End Function

    Private Sub btn_reg_pedido_Click(sender As Object, e As EventArgs) Handles btn_reg_pedido.Click

        If detalles.Count = 0 Then
            MsgBox("Primero debe agregar detalles", MsgBoxStyle.Critical)
            Return
        End If
        Dim pedido As Pedido = New Pedido

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

        pedido.detalles = detalles
        pedido.total = calcularTotal()


    End Sub
End Class