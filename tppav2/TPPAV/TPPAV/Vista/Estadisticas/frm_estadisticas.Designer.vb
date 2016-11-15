<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estadisticas
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Clientes2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TPPAV.DataSet1()
        Me.cbo_meses = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rpt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Pedido2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pedido2TableAdapter = New TPPAV.DataSet1TableAdapters.Pedido2TableAdapter()
        Me.Clientes2TableAdapter = New TPPAV.DataSet1TableAdapters.Clientes2TableAdapter()
        CType(Me.Clientes2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clientes2BindingSource
        '
        Me.Clientes2BindingSource.DataMember = "Clientes2"
        Me.Clientes2BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbo_meses
        '
        Me.cbo_meses.FormattingEnabled = True
        Me.cbo_meses.Location = New System.Drawing.Point(216, 94)
        Me.cbo_meses.Name = "cbo_meses"
        Me.cbo_meses.Size = New System.Drawing.Size(120, 21)
        Me.cbo_meses.TabIndex = 1
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(457, 94)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(89, 23)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "Buscar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(621, 94)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(90, 23)
        Me.btn_cerrar.TabIndex = 3
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Buscar estadísticas de cantidad de pedidos realizados por mes por cliente"
        '
        'rpt
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Clientes2BindingSource
        Me.rpt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt.LocalReport.ReportEmbeddedResource = "TPPAV.Report2.rdlc"
        Me.rpt.Location = New System.Drawing.Point(51, 142)
        Me.rpt.Name = "rpt"
        Me.rpt.Size = New System.Drawing.Size(721, 433)
        Me.rpt.TabIndex = 6
        '
        'Pedido2BindingSource
        '
        Me.Pedido2BindingSource.DataMember = "Pedido2"
        Me.Pedido2BindingSource.DataSource = Me.DataSet1
        '
        'Pedido2TableAdapter
        '
        Me.Pedido2TableAdapter.ClearBeforeFill = True
        '
        'Clientes2TableAdapter
        '
        Me.Clientes2TableAdapter.ClearBeforeFill = True
        '
        'frm_estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 587)
        Me.Controls.Add(Me.rpt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cbo_meses)
        Me.Name = "frm_estadisticas"
        Me.Text = "Estadísticas de clientes"
        CType(Me.Clientes2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents cbo_meses As ComboBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rpt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Pedido2BindingSource As BindingSource
    Friend WithEvents Pedido2TableAdapter As DataSet1TableAdapters.Pedido2TableAdapter
    Friend WithEvents Clientes2BindingSource As BindingSource
    Friend WithEvents Clientes2TableAdapter As DataSet1TableAdapters.Clientes2TableAdapter
End Class
