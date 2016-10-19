<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addCategoriaArticulo
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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_nomCate = New System.Windows.Forms.TextBox()
        Me.rtx_descripcion = New System.Windows.Forms.RichTextBox()
        Me.lbl_nomCat = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(289, 193)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(150, 31)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Agregar categoria"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(145, 193)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(121, 31)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "Limpiar campos"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_nomCate
        '
        Me.txt_nomCate.Location = New System.Drawing.Point(16, 33)
        Me.txt_nomCate.Name = "txt_nomCate"
        Me.txt_nomCate.Size = New System.Drawing.Size(424, 22)
        Me.txt_nomCate.TabIndex = 2
        '
        'rtx_descripcion
        '
        Me.rtx_descripcion.Location = New System.Drawing.Point(16, 88)
        Me.rtx_descripcion.Name = "rtx_descripcion"
        Me.rtx_descripcion.Size = New System.Drawing.Size(423, 96)
        Me.rtx_descripcion.TabIndex = 3
        Me.rtx_descripcion.Text = ""
        '
        'lbl_nomCat
        '
        Me.lbl_nomCat.AutoSize = True
        Me.lbl_nomCat.Location = New System.Drawing.Point(13, 13)
        Me.lbl_nomCat.Name = "lbl_nomCat"
        Me.lbl_nomCat.Size = New System.Drawing.Size(121, 17)
        Me.lbl_nomCat.TabIndex = 4
        Me.lbl_nomCat.Text = "Nombre categoria"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(13, 68)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbl_descripcion.TabIndex = 5
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'frm_categoriaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 236)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nomCat)
        Me.Controls.Add(Me.rtx_descripcion)
        Me.Controls.Add(Me.txt_nomCate)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "frm_categoriaArticulo"
        Me.Text = "Agregar nueva categoria de articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents txt_nomCate As System.Windows.Forms.TextBox
    Friend WithEvents rtx_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_nomCat As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
End Class
