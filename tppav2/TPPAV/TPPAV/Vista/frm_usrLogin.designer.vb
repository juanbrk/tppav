<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usrLogin
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
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.MaskedTextBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(44, 9)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(61, 17)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(44, 56)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(73, 17)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(47, 30)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(216, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(47, 77)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(216, 22)
        Me.txt_password.TabIndex = 1
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(299, 120)
        Me.btn_ingresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(104, 28)
        Me.btn_ingresar.TabIndex = 2
        Me.btn_ingresar.Text = "&Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(171, 120)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(107, 28)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "&Salir"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.Location = New System.Drawing.Point(25, 154)
        Me.lbl_mensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 27)
        Me.lbl_mensaje.TabIndex = 4
        '
        'frm_usrLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 159)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_usrLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label

End Class
