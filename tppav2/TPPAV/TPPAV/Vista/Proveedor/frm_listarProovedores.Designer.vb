<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarProovedores
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
        Me.btn_ext = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_proveedores = New System.Windows.Forms.Label()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.col_idProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_razonSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ext
        '
        Me.btn_ext.Location = New System.Drawing.Point(420, 179)
        Me.btn_ext.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ext.Name = "btn_ext"
        Me.btn_ext.Size = New System.Drawing.Size(70, 23)
        Me.btn_ext.TabIndex = 0
        Me.btn_ext.Text = "Salir"
        Me.btn_ext.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(224, 179)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 23)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'lbl_proveedores
        '
        Me.lbl_proveedores.AutoSize = True
        Me.lbl_proveedores.Location = New System.Drawing.Point(10, 11)
        Me.lbl_proveedores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_proveedores.Name = "lbl_proveedores"
        Me.lbl_proveedores.Size = New System.Drawing.Size(67, 13)
        Me.lbl_proveedores.TabIndex = 2
        Me.lbl_proveedores.Text = "Proveedores"
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idProv, Me.col_razonSoc, Me.col_direccion, Me.col_email, Me.col_telefono})
        Me.dgv_proveedores.Location = New System.Drawing.Point(12, 28)
        Me.dgv_proveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.RowTemplate.Height = 24
        Me.dgv_proveedores.Size = New System.Drawing.Size(541, 124)
        Me.dgv_proveedores.TabIndex = 3
        '
        'col_idProv
        '
        Me.col_idProv.HeaderText = "Id proveedor"
        Me.col_idProv.Name = "col_idProv"
        '
        'col_razonSoc
        '
        Me.col_razonSoc.HeaderText = "Razon social"
        Me.col_razonSoc.Name = "col_razonSoc"
        '
        'col_direccion
        '
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email"
        Me.col_email.Name = "col_email"
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(324, 179)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'frm_listarProovedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 223)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_proveedores)
        Me.Controls.Add(Me.lbl_proveedores)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_ext)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_listarProovedores"
        Me.Text = "Proveedores"
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ext As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents lbl_proveedores As System.Windows.Forms.Label
    Friend WithEvents dgv_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents col_idProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razonSoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_agregar As Button
End Class
