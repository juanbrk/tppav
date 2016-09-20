<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addProovedor
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
        Me.lbl_rznSocial = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_razonSocial = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_rznSocial
        '
        Me.lbl_rznSocial.AutoSize = True
        Me.lbl_rznSocial.Location = New System.Drawing.Point(12, 18)
        Me.lbl_rznSocial.Name = "lbl_rznSocial"
        Me.lbl_rznSocial.Size = New System.Drawing.Size(89, 17)
        Me.lbl_rznSocial.TabIndex = 0
        Me.lbl_rznSocial.Text = "Razon social"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(12, 61)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(67, 17)
        Me.lbl_direccion.TabIndex = 1
        Me.lbl_direccion.Text = "Direccion"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(12, 104)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(42, 17)
        Me.lbl_email.TabIndex = 2
        Me.lbl_email.Text = "Email"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(228, 104)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(64, 17)
        Me.lbl_telefono.TabIndex = 3
        Me.lbl_telefono.Text = "Telefono"
        '
        'txt_razonSocial
        '
        Me.txt_razonSocial.Location = New System.Drawing.Point(13, 36)
        Me.txt_razonSocial.Name = "txt_razonSocial"
        Me.txt_razonSocial.Size = New System.Drawing.Size(427, 22)
        Me.txt_razonSocial.TabIndex = 4
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(13, 79)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(427, 22)
        Me.txt_direccion.TabIndex = 5
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(13, 125)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(178, 22)
        Me.txt_email.TabIndex = 6
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(231, 124)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(209, 22)
        Me.txt_telefono.TabIndex = 7
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(364, 183)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 31)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Agregar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(231, 183)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(115, 31)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Limpiar campos"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_addProovedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 222)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_razonSocial)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_rznSocial)
        Me.Name = "frm_addProovedor"
        Me.Text = "Agregar nuevo proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_rznSocial As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_razonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
