<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estadisticas_barrios
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btn_totales = New System.Windows.Forms.Button()
        Me.btn_cantidades = New System.Windows.Forms.Button()
        Me.cbo_meses = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_años = New System.Windows.Forms.ComboBox()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TPPAV.DataSet1()
        Me.Clientes2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes2TableAdapter = New TPPAV.DataSet1TableAdapters.Clientes2TableAdapter()
        Me.DataTable2TableAdapter = New TPPAV.DataSet1TableAdapters.DataTable2TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DataTable2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPPAV.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 98)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(859, 523)
        Me.ReportViewer1.TabIndex = 0
        '
        'btn_totales
        '
        Me.btn_totales.Location = New System.Drawing.Point(127, 43)
        Me.btn_totales.Name = "btn_totales"
        Me.btn_totales.Size = New System.Drawing.Size(112, 23)
        Me.btn_totales.TabIndex = 1
        Me.btn_totales.Text = "Totales por zona"
        Me.btn_totales.UseVisualStyleBackColor = True
        '
        'btn_cantidades
        '
        Me.btn_cantidades.Location = New System.Drawing.Point(293, 43)
        Me.btn_cantidades.Name = "btn_cantidades"
        Me.btn_cantidades.Size = New System.Drawing.Size(112, 23)
        Me.btn_cantidades.TabIndex = 2
        Me.btn_cantidades.Text = "Cantidades por zona"
        Me.btn_cantidades.UseVisualStyleBackColor = True
        '
        'cbo_meses
        '
        Me.cbo_meses.FormattingEnabled = True
        Me.cbo_meses.Location = New System.Drawing.Point(654, 43)
        Me.cbo_meses.Name = "cbo_meses"
        Me.cbo_meses.Size = New System.Drawing.Size(95, 21)
        Me.cbo_meses.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(558, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtrado por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(688, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(811, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Año"
        '
        'cbo_años
        '
        Me.cbo_años.FormattingEnabled = True
        Me.cbo_años.Location = New System.Drawing.Point(777, 43)
        Me.cbo_años.Name = "cbo_años"
        Me.cbo_años.Size = New System.Drawing.Size(97, 21)
        Me.cbo_años.TabIndex = 6
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clientes2BindingSource
        '
        Me.Clientes2BindingSource.DataMember = "Clientes2"
        Me.Clientes2BindingSource.DataSource = Me.DataSet1
        '
        'Clientes2TableAdapter
        '
        Me.Clientes2TableAdapter.ClearBeforeFill = True
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(777, 647)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_estadisticas_barrios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 682)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_años)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_meses)
        Me.Controls.Add(Me.btn_cantidades)
        Me.Controls.Add(Me.btn_totales)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_estadisticas_barrios"
        Me.Text = "Estadísticas de barrios"
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Clientes2BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Clientes2TableAdapter As DataSet1TableAdapters.Clientes2TableAdapter
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents DataTable2TableAdapter As DataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents btn_totales As Button
    Friend WithEvents btn_cantidades As Button
    Friend WithEvents cbo_meses As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_años As ComboBox
    Friend WithEvents Button1 As Button
End Class
