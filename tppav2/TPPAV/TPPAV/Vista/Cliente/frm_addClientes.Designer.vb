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
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_addBarrio = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cbo_barrios = New System.Windows.Forms.ComboBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_descripcion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 19)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(9, 64)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(9, 116)
        Me.lbl_direccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_direccion.TabIndex = 2
        Me.lbl_direccion.Text = "Direccion"
        '
        'lbl_barrio
        '
        Me.lbl_barrio.AutoSize = True
        Me.lbl_barrio.Location = New System.Drawing.Point(256, 22)
        Me.lbl_barrio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_barrio.Name = "lbl_barrio"
        Me.lbl_barrio.Size = New System.Drawing.Size(34, 13)
        Me.lbl_barrio.TabIndex = 3
        Me.lbl_barrio.Text = "Barrio"
        '
        'lbl_telCliente
        '
        Me.lbl_telCliente.AutoSize = True
        Me.lbl_telCliente.Location = New System.Drawing.Point(8, 167)
        Me.lbl_telCliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telCliente.Name = "lbl_telCliente"
        Me.lbl_telCliente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telCliente.TabIndex = 4
        Me.lbl_telCliente.Text = "Telefono"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(10, 36)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(168, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(10, 79)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(168, 20)
        Me.txt_apellido.TabIndex = 6
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(10, 133)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(168, 20)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(10, 184)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(168, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'btn_add
        '
        Me.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_add.Location = New System.Drawing.Point(293, 242)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 28)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "Aceptar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_addBarrio
        '
        Me.btn_addBarrio.Location = New System.Drawing.Point(259, 62)
        Me.btn_addBarrio.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_addBarrio.Name = "btn_addBarrio"
        Me.btn_addBarrio.Size = New System.Drawing.Size(78, 26)
        Me.btn_addBarrio.TabIndex = 12
        Me.btn_addBarrio.Text = "Nuevo barrio"
        Me.btn_addBarrio.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(201, 242)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 28)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'cbo_barrios
        '
        Me.cbo_barrios.FormattingEnabled = True
        Me.cbo_barrios.Location = New System.Drawing.Point(259, 36)
        Me.cbo_barrios.Name = "cbo_barrios"
        Me.cbo_barrios.Size = New System.Drawing.Size(121, 21)
        Me.cbo_barrios.TabIndex = 14
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(212, 184)
        Me.txt_dni.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(168, 20)
        Me.txt_dni.TabIndex = 18
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(212, 133)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(168, 20)
        Me.txt_mail.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "DNI o CUIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mail"
        '
        'cb_descripcion
        '
        Me.cb_descripcion.FormattingEnabled = True
        Me.cb_descripcion.Location = New System.Drawing.Point(13, 242)
        Me.cb_descripcion.Name = "cb_descripcion"
        Me.cb_descripcion.Size = New System.Drawing.Size(143, 21)
        Me.cb_descripcion.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripcion"
        '
        'frm_addClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 303)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_descripcion)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_barrios)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_addBarrio)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_telCliente)
        Me.Controls.Add(Me.lbl_barrio)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_addBarrio As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents cbo_barrios As ComboBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_descripcion As ComboBox
    Friend WithEvents Label3 As Label
End Class
