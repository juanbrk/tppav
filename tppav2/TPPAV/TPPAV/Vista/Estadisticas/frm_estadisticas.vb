Imports Microsoft.Reporting.WinForms

Public Class frm_estadisticas
    Private Sub frm_estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Clientes2' table. You can move, or remove it, as needed.
        Me.Clientes2TableAdapter.Fill(Me.DataSet1.Clientes2)
        'TODO: This line of code loads data into the 'DataSet1.Pedido2' table. You can move, or remove it, as needed.
        'Me.Pedido2TableAdapter.(Me.DataSet1.Pedido2)


        Me.rpt.RefreshReport()

        cbo_meses.Items.Add("Enero")
        cbo_meses.Items.Add("Febrero")
        cbo_meses.Items.Add("Marzo")
        cbo_meses.Items.Add("Abril")
        cbo_meses.Items.Add("Mayo")
        cbo_meses.Items.Add("Junio")
        cbo_meses.Items.Add("Julio")
        cbo_meses.Items.Add("Agosto")
        cbo_meses.Items.Add("Septiembre")
        cbo_meses.Items.Add("Octubre")
        cbo_meses.Items.Add("Noviembre")
        cbo_meses.Items.Add("Diciembre")
        Me.rpt.RefreshReport()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim mes As Integer = cbo_meses.SelectedIndex + 1
        rpt.Reset()

        Dim service As New ClienteService
        Dim tabla As DataTable = service.pedidosPorMes(mes)

        rpt.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", tabla))
        rpt.LocalReport.ReportEmbeddedResource = "TPPAV.Report2.rdlc"

        Dim P As ReportParameter = New ReportParameter("mes", cbo_meses.SelectedItem.ToString, False)
        Dim lista As New List(Of ReportParameter)
        lista.Add(P)
        rpt.LocalReport.SetParameters(lista)
        rpt.RefreshReport()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class