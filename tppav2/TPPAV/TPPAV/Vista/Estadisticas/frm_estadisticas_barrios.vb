Imports Microsoft.Reporting.WinForms

Public Class frm_estadisticas_barrios
    Private Sub frm_estadisticas_barrios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)
        'TODO: This line of code loads data into the 'DataSet1.Clientes2' table. You can move, or remove it, as needed.
        Me.Clientes2TableAdapter.Fill(Me.DataSet1.Clientes2)
        'cbo_años.Items.Add("2016")
        For i = 2016 To System.DateTime.Today.Year + 1
            cbo_años.Items.Add(i.ToString)
        Next
        cbo_años.SelectedIndex = 0
        cbo_meses.Items.Add("-")
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
        cbo_meses.SelectedIndex = 0
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_totales_Click(sender As Object, e As EventArgs) Handles btn_totales.Click

        cargarReporte("Report3")

    End Sub

    Private Sub cargarReporte(ByVal rep As String)
        Dim service As New BarrioService
        Dim tabla As DataTable = service.ventasXBarrioXMes(cbo_meses.SelectedIndex.ToString, cbo_años.SelectedItem)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", tabla))
        ReportViewer1.LocalReport.ReportPath = IO.Path.Combine(Application.StartupPath.Replace("\bin\Debug", "\"), "Vista\Estadisticas\" + rep + ".rdlc")

        ReportViewer1.RefreshReport()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_cantidades_Click(sender As Object, e As EventArgs) Handles btn_cantidades.Click
        cargarReporte("Report1")
    End Sub
End Class