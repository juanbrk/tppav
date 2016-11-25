<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addBarrio
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
        Me.lbl_nomBarrio = New System.Windows.Forms.Label()
        Me.txt_nomBarrio = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_nomBarrio
        '
        Me.lbl_nomBarrio.AutoSize = True
        Me.lbl_nomBarrio.Location = New System.Drawing.Point(10, 16)
        Me.lbl_nomBarrio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nomBarrio.Name = "lbl_nomBarrio"
        Me.lbl_nomBarrio.Size = New System.Drawing.Size(90, 13)
        Me.lbl_nomBarrio.TabIndex = 0
        Me.lbl_nomBarrio.Text = "Nombre del barrio"
        '
        'txt_nomBarrio
        '
        Me.txt_nomBarrio.Location = New System.Drawing.Point(159, 16)
        Me.txt_nomBarrio.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomBarrio.Name = "txt_nomBarrio"
        Me.txt_nomBarrio.Size = New System.Drawing.Size(168, 20)
        Me.txt_nomBarrio.TabIndex = 1
        '
        'btn_add
        '
        Me.btn_add.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_add.Location = New System.Drawing.Point(269, 95)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(56, 25)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Agregar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_salir.Location = New System.Drawing.Point(203, 95)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(59, 25)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Cancelar"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(159, 57)
        Me.txt_provincia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(167, 20)
        Me.txt_provincia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de la provincia"
        '
        'frm_addBarrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 131)
        Me.Controls.Add(Me.txt_provincia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_nomBarrio)
        Me.Controls.Add(Me.lbl_nomBarrio)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_addBarrio"
        Me.Text = "Agregar nuevo barrio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nomBarrio As System.Windows.Forms.Label
    Friend WithEvents txt_nomBarrio As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents txt_provincia As TextBox
    Friend WithEvents Label1 As Label
End Class
