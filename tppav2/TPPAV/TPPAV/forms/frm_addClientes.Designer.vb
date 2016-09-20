<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addClientes
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_barrio = New System.Windows.Forms.Label()
        Me.lbl_telCliente = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_addBarrio = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(13, 23)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(58, 17)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 79)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(58, 17)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(12, 143)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(67, 17)
        Me.lbl_direccion.TabIndex = 2
        Me.lbl_direccion.Text = "Direccion"
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(302, 143)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(46, 17)
        Me.lbl_barrio.TabIndex = 3
        Me.lbl_barrio.Text = "Barrio"
        '
        'lbl_telCliente
        '
        Me.lbl_telCliente.AutoSize = True
        Me.lbl_telCliente.Location = New System.Drawing.Point(10, 206)
        Me.lbl_telCliente.Name = "lbl_telCliente"
        Me.lbl_telCliente.Size = New System.Drawing.Size(64, 17)
        Me.lbl_telCliente.TabIndex = 4
        Me.lbl_telCliente.Text = "Telefono"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(13, 44)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(268, 22)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(13, 100)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(268, 22)
        Me.txt_apellido.TabIndex = 6
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(13, 164)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(268, 22)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_barrio
        '
        Me.txt_barrio.Location = New System.Drawing.Point(305, 164)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.Size = New System.Drawing.Size(144, 22)
        Me.txt_barrio.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(13, 226)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(198, 22)
        Me.txt_telefono.TabIndex = 9
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(362, 313)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(87, 34)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "Aceptar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(113, 313)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(135, 34)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Limpiar campos"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_addBarrio
        '
        Me.btn_addBarrio.Location = New System.Drawing.Point(345, 192)
        Me.btn_addBarrio.Name = "btn_addBarrio"
        Me.btn_addBarrio.Size = New System.Drawing.Size(104, 32)
        Me.btn_addBarrio.TabIndex = 12
        Me.btn_addBarrio.Text = "Nuevo barrio"
        Me.btn_addBarrio.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(254, 313)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(102, 34)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_addClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 359)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_addBarrio)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_barrio)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_telCliente)
        Me.Controls.Add(Me.lbl_barrio)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "frm_addClientes"
        Me.Text = "Agregar nuevo cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_barrio As System.Windows.Forms.Label
    Friend WithEvents lbl_telCliente As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_barrio As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_addBarrio As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
