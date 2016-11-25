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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
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
        Me.btn_detalle = New System.Windows.Forms.Button()
        Me.btn_reg_pedido = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_extra1 = New System.Windows.Forms.TextBox()
        Me.txt_extra2 = New System.Windows.Forms.TextBox()
        Me.cb_efectivo = New System.Windows.Forms.CheckBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_neto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_prendas = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(47, 259)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(48, 13)
        Label4.TabIndex = 10
        Label4.Text = "Detalles:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(485, 103)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(66, 13)
        Label7.TabIndex = 16
        Label7.Text = "*Descuento:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(485, 152)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(44, 13)
        Label8.TabIndex = 17
        Label8.Text = "*Extra1:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(485, 204)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(44, 13)
        Label9.TabIndex = 18
        Label9.Text = "*Extra2:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(485, 259)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(46, 13)
        Label6.TabIndex = 23
        Label6.Text = "Usuario:"
        '
        'dtp_entrega
        '
        Me.dtp_entrega.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.dtp_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_entrega.Location = New System.Drawing.Point(214, 44)
        Me.dtp_entrega.Name = "dtp_entrega"
        Me.dtp_entrega.Size = New System.Drawing.Size(138, 20)
        Me.dtp_entrega.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de entrega:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'cbo_cliente
        '
        Me.cbo_cliente.FormattingEnabled = True
        Me.cbo_cliente.Location = New System.Drawing.Point(214, 103)
        Me.cbo_cliente.Name = "cbo_cliente"
        Me.cbo_cliente.Size = New System.Drawing.Size(100, 21)
        Me.cbo_cliente.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(44, 152)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(34, 13)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.Location = New System.Drawing.Point(211, 152)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(27, 13)
        Me.txt_total.TabIndex = 5
        Me.txt_total.Text = "total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numero de Factura:"
        '
        'txt_nro_factura
        '
        Me.txt_nro_factura.Location = New System.Drawing.Point(214, 201)
        Me.txt_nro_factura.Name = "txt_nro_factura"
        Me.txt_nro_factura.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_factura.TabIndex = 7
        '
        'btn_cliente
        '
        Me.btn_cliente.Location = New System.Drawing.Point(338, 101)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(56, 23)
        Me.btn_cliente.TabIndex = 8
        Me.btn_cliente.Text = "Agregar"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'dgv_detalles
        '
        Me.dgv_detalles.AllowUserToAddRows = False
        Me.dgv_detalles.AllowUserToDeleteRows = False
        Me.dgv_detalles.AllowUserToResizeRows = False
        Me.dgv_detalles.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_art_nom, Me.col_cantidad, Me.col_precio})
        Me.dgv_detalles.Location = New System.Drawing.Point(85, 329)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.ReadOnly = True
        Me.dgv_detalles.Size = New System.Drawing.Size(344, 156)
        Me.dgv_detalles.TabIndex = 9
        '
        'col_art_nom
        '
        Me.col_art_nom.HeaderText = "Articulo"
        Me.col_art_nom.Name = "col_art_nom"
        Me.col_art_nom.ReadOnly = True
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio U."
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = True
        '
        'btn_detalle
        '
        Me.btn_detalle.Location = New System.Drawing.Point(214, 259)
        Me.btn_detalle.Name = "btn_detalle"
        Me.btn_detalle.Size = New System.Drawing.Size(100, 23)
        Me.btn_detalle.TabIndex = 11
        Me.btn_detalle.Text = "Agregar Detalle"
        Me.btn_detalle.UseVisualStyleBackColor = True
        '
        'btn_reg_pedido
        '
        Me.btn_reg_pedido.Location = New System.Drawing.Point(300, 503)
        Me.btn_reg_pedido.Name = "btn_reg_pedido"
        Me.btn_reg_pedido.Size = New System.Drawing.Size(94, 23)
        Me.btn_reg_pedido.TabIndex = 12
        Me.btn_reg_pedido.Text = "Registrar Pedido"
        Me.btn_reg_pedido.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(185, 503)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(424, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(2, 300)
        Me.Label5.TabIndex = 14
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(601, 100)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(100, 20)
        Me.txt_descuento.TabIndex = 19
        '
        'txt_extra1
        '
        Me.txt_extra1.Location = New System.Drawing.Point(601, 149)
        Me.txt_extra1.Name = "txt_extra1"
        Me.txt_extra1.Size = New System.Drawing.Size(100, 20)
        Me.txt_extra1.TabIndex = 20
        '
        'txt_extra2
        '
        Me.txt_extra2.Location = New System.Drawing.Point(601, 201)
        Me.txt_extra2.Name = "txt_extra2"
        Me.txt_extra2.Size = New System.Drawing.Size(100, 20)
        Me.txt_extra2.TabIndex = 21
        '
        'cb_efectivo
        '
        Me.cb_efectivo.AutoSize = True
        Me.cb_efectivo.Checked = True
        Me.cb_efectivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_efectivo.Location = New System.Drawing.Point(488, 50)
        Me.cb_efectivo.Name = "cb_efectivo"
        Me.cb_efectivo.Size = New System.Drawing.Size(65, 17)
        Me.cb_efectivo.TabIndex = 22
        Me.cb_efectivo.Text = "Efectivo"
        Me.cb_efectivo.UseVisualStyleBackColor = True
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(632, 258)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(41, 13)
        Me.lbl_usuario.TabIndex = 24
        Me.lbl_usuario.Text = "usuario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(485, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total Neto:"
        '
        'lbl_neto
        '
        Me.lbl_neto.AutoSize = True
        Me.lbl_neto.Location = New System.Drawing.Point(632, 370)
        Me.lbl_neto.Name = "lbl_neto"
        Me.lbl_neto.Size = New System.Drawing.Size(48, 13)
        Me.lbl_neto.TabIndex = 26
        Me.lbl_neto.Text = "totalneto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(601, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "*Campos opcionales"
        '
        'lbl_prendas
        '
        Me.lbl_prendas.AutoSize = True
        Me.lbl_prendas.Location = New System.Drawing.Point(632, 433)
        Me.lbl_prendas.Name = "lbl_prendas"
        Me.lbl_prendas.Size = New System.Drawing.Size(66, 13)
        Me.lbl_prendas.TabIndex = 29
        Me.lbl_prendas.Text = "totalPrendas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(485, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Cantidad de Prendas:"
        '
        'frm_crearPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 566)
        Me.Controls.Add(Me.lbl_prendas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_neto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.cb_efectivo)
        Me.Controls.Add(Me.txt_extra2)
        Me.Controls.Add(Me.txt_extra1)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents txt_extra1 As TextBox
    Friend WithEvents txt_extra2 As TextBox
    Friend WithEvents cb_efectivo As CheckBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents col_art_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_neto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_prendas As Label
    Friend WithEvents Label13 As Label
End Class
