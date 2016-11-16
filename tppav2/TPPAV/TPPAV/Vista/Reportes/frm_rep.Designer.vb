<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rep
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
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_hasta = New System.Windows.Forms.DateTimePicker()
        Me.btn_fechas = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.cbo_clientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rpt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New TPPAV.DataSet1()
        Me.Pedido2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pedido2TableAdapter = New TPPAV.DataSet1TableAdapters.Pedido2TableAdapter()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataSource = GetType(TPPAV.Pedido)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-1, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(855, 1)
        Me.Label7.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(-1, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(855, 1)
        Me.Label6.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Hasta"
        '
        'dtp_desde
        '
        Me.dtp_desde.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_desde.Location = New System.Drawing.Point(213, 151)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(138, 20)
        Me.dtp_desde.TabIndex = 21
        '
        'dtp_hasta
        '
        Me.dtp_hasta.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hasta.Location = New System.Drawing.Point(419, 151)
        Me.dtp_hasta.Name = "dtp_hasta"
        Me.dtp_hasta.Size = New System.Drawing.Size(138, 20)
        Me.dtp_hasta.TabIndex = 20
        '
        'btn_fechas
        '
        Me.btn_fechas.Location = New System.Drawing.Point(644, 145)
        Me.btn_fechas.Name = "btn_fechas"
        Me.btn_fechas.Size = New System.Drawing.Size(92, 26)
        Me.btn_fechas.TabIndex = 19
        Me.btn_fechas.Text = "Buscar pedidos"
        Me.btn_fechas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "-Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Buscar Pedidos No terminados por:"
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(644, 49)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(92, 26)
        Me.btn_clientes.TabIndex = 16
        Me.btn_clientes.Text = "Buscar pedidos"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'cbo_clientes
        '
        Me.cbo_clientes.FormattingEnabled = True
        Me.cbo_clientes.Location = New System.Drawing.Point(213, 49)
        Me.cbo_clientes.Name = "cbo_clientes"
        Me.cbo_clientes.Size = New System.Drawing.Size(161, 21)
        Me.cbo_clientes.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "-Cliente"
        '
        'rpt
        '
        Me.rpt.AutoSize = True
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.PedidoBindingSource
        Me.rpt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt.LocalReport.ReportEmbeddedResource = "TPPAV.Report1.rdlc"
        Me.rpt.Location = New System.Drawing.Point(82, 245)
        Me.rpt.Name = "rpt"
        Me.rpt.Size = New System.Drawing.Size(674, 309)
        Me.rpt.TabIndex = 26
        Me.rpt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(705, 589)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 27
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'frm_rep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 641)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.rpt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_desde)
        Me.Controls.Add(Me.dtp_hasta)
        Me.Controls.Add(Me.btn_fechas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.cbo_clientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_rep"
        Me.Text = "Reportes de Pedidos"
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_desde As DateTimePicker
    Friend WithEvents dtp_hasta As DateTimePicker
    Friend WithEvents btn_fechas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_clientes As Button
    Friend WithEvents cbo_clientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rpt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Pedido2BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Pedido2TableAdapter As DataSet1TableAdapters.Pedido2TableAdapter
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents btn_cerrar As Button
End Class
