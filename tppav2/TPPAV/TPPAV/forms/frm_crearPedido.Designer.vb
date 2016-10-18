<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_crearPedido
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
        Dim Label4 As System.Windows.Forms.Label
        Me.dtp_entrega = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nro_factura = New System.Windows.Forms.TextBox()
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.col_art_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_detalle = New System.Windows.Forms.Button()
        Me.btn_reg_pedido = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(56, 259)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(48, 13)
        Label4.TabIndex = 10
        Label4.Text = "Detalles:"
        '
        'dtp_entrega
        '
        Me.dtp_entrega.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.dtp_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_entrega.Location = New System.Drawing.Point(254, 44)
        Me.dtp_entrega.Name = "dtp_entrega"
        Me.dtp_entrega.Size = New System.Drawing.Size(138, 20)
        Me.dtp_entrega.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de entrega:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'cbo_cliente
        '
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Location = New System.Drawing.Point(254, 103)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(121, 21)
        Me.cbo_cliente.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(53, 152)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(34, 13)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.Location = New System.Drawing.Point(251, 152)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(27, 13)
        Me.txt_total.TabIndex = 5
        Me.txt_total.Text = "total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numero de Factura:"
        '
        'txt_nro_factura
        '
        Me.txt_nro_factura.Location = New System.Drawing.Point(254, 201)
        Me.txt_nro_factura.Name = "txt_nro_factura"
        Me.txt_nro_factura.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_factura.TabIndex = 7
        '
        'btn_cliente
        '
        Me.btn_cliente.Location = New System.Drawing.Point(409, 103)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_cliente.TabIndex = 8
        Me.btn_cliente.Text = "Agregar"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'dgv_detalles
        '
        Me.dgv_detalles.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_art_nom, Me.col_cantidad, Me.col_precio, Me.col_descuento})
        Me.dgv_detalles.Location = New System.Drawing.Point(46, 315)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.Size = New System.Drawing.Size(443, 156)
        Me.dgv_detalles.TabIndex = 9
        '
        'col_art_nom
        '
        Me.col_art_nom.HeaderText = "Articulo"
        Me.col_art_nom.Name = "col_art_nom"
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio U."
        Me.col_precio.Name = "col_precio"
        '
        'col_descuento
        '
        Me.col_descuento.HeaderText = "Descuento"
        Me.col_descuento.Name = "col_descuento"
        '
        'btn_detalle
        '
        Me.btn_detalle.Location = New System.Drawing.Point(254, 259)
        Me.btn_detalle.Name = "btn_detalle"
        Me.btn_detalle.Size = New System.Drawing.Size(100, 23)
        Me.btn_detalle.TabIndex = 11
        Me.btn_detalle.Text = "Agregar Detalle"
        Me.btn_detalle.UseVisualStyleBackColor = True
        '
        'btn_reg_pedido
        '
        Me.btn_reg_pedido.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_reg_pedido.Location = New System.Drawing.Point(390, 507)
        Me.btn_reg_pedido.Name = "btn_reg_pedido"
        Me.btn_reg_pedido.Size = New System.Drawing.Size(94, 23)
        Me.btn_reg_pedido.TabIndex = 12
        Me.btn_reg_pedido.Text = "Registrar Pedido"
        Me.btn_reg_pedido.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(275, 507)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_crearPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 570)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_reg_pedido)
        Me.Controls.Add(Me.btn_detalle)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.dgv_detalles)
        Me.Controls.Add(Me.btn_cliente)
        Me.Controls.Add(Me.txt_nro_factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.cbo_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_entrega)
        Me.Name = "frm_crearPedido"
        Me.Text = "Crear Pedido"
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_entrega As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_cliente As ComboBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nro_factura As TextBox
    Friend WithEvents btn_cliente As Button
    Friend WithEvents dgv_detalles As DataGridView
    Friend WithEvents btn_detalle As Button
    Friend WithEvents btn_reg_pedido As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents col_art_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_descuento As DataGridViewTextBoxColumn
End Class
