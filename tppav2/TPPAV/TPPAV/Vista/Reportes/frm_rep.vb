Imports Microsoft.Reporting.WinForms

Public Class frm_rep
    Public Sub cargarClientes()
        Dim client_service As ClienteService = New ClienteService
        Dim clientes As List(Of Cliente) = client_service.listarClientes

        cbo_clientes.DataSource = clientes
        cbo_clientes.DisplayMember = "fullname"
        cbo_clientes.ValueMember = "idCliente"
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim cli As Cliente = cbo_clientes.SelectedItem

        'rpt.LocalReport.SetParameters({New ReportParameter("cid", cli.fullname.ToString)})
        dgv_rep.DataSource = ""
        Dim ser As New PedidoService
        dgv_rep.DataSource = ser.listarPedidosDeCliente(cli.idCliente.ToString)

    End Sub

    Private Sub frm_rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Pedido2' table. You can move, or remove it, as needed.
        ' Me.Pedido2TableAdapter(DataSet1.Pedido2)
        'DataSet1.Pedido2.
        cargarClientes()

    End Sub

    Private Sub btn_fechas_Click(sender As Object, e As EventArgs) Handles btn_fechas.Click
        dgv_rep.DataSource = ""
        Dim ser As New PedidoService
        Dim desde As String = dtp_desde.Value.Month.ToString + "/" + dtp_desde.Value.Day.ToString + "/" + dtp_desde.Value.Year.ToString
        Dim hasta As String = dtp_hasta.Value.Month.ToString + "/" + dtp_hasta.Value.Day.ToString + "/" + dtp_hasta.Value.Year.ToString
        dgv_rep.DataSource = ser.listarPedidosEntreFechas(desde, hasta)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class