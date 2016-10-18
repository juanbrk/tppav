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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.col_idProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_razonSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ext
        '
        Me.btn_ext.Location = New System.Drawing.Point(352, 177)
        Me.btn_ext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ext.Name = "btn_ext"
        Me.btn_ext.Size = New System.Drawing.Size(56, 29)
        Me.btn_ext.TabIndex = 0
        Me.btn_ext.Text = "Salir"
        Me.btn_ext.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(236, 177)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 28)
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idProv, Me.col_razonSoc, Me.col_direccion, Me.col_email, Me.col_telefono})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(541, 124)
        Me.DataGridView1.TabIndex = 3
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
        'frm_listarProovedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 223)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_proveedores)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_ext)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_listarProovedores"
        Me.Text = "frm_listarProovedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ext As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents lbl_proveedores As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents col_idProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razonSoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
