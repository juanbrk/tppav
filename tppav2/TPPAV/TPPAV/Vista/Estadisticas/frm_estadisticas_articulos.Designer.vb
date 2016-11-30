<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estadisticas_articulos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TPPAV.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2TableAdapter = New TPPAV.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.DataTable3TableAdapter = New TPPAV.DataSet1TableAdapters.DataTable3TableAdapter()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable3BindingSource
        '
        Me.DataTable3BindingSource.DataMember = "DataTable3"
        Me.DataTable3BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable3BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPPAV.articulos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(43, 40)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(822, 455)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'frm_estadisticas_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 602)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_estadisticas_articulos"
        Me.Text = "Estadisticas de Artículos"
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable2TableAdapter As DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents DataTable3BindingSource As BindingSource
    Friend WithEvents DataTable3TableAdapter As DataSet1TableAdapters.DataTable3TableAdapter
End Class
