Public Class frm_estadisticas_articulos
    Private Sub frm_estadisticas_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable3' table. You can move, or remove it, as needed.
        Me.DataTable3TableAdapter.Fill(Me.DataSet1.DataTable3)
        'TODO: This line of code loads data into the 'DataSet1.DataTable2' table. You can move, or remove it, as needed.
        Me.DataTable2TableAdapter.Fill(Me.DataSet1.DataTable2)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class