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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_nomCate = New System.Windows.Forms.TextBox()
        Me.rtx_descripcion = New System.Windows.Forms.RichTextBox()
        Me.lbl_nomCat = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(217, 157)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(112, 25)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Agregar categoria"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(109, 157)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(91, 25)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_nomCate
        '
        Me.txt_nomCate.Location = New System.Drawing.Point(12, 27)
        Me.txt_nomCate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomCate.Name = "txt_nomCate"
        Me.txt_nomCate.Size = New System.Drawing.Size(319, 20)
        Me.txt_nomCate.TabIndex = 2
        '
        'rtx_descripcion
        '
        Me.rtx_descripcion.Location = New System.Drawing.Point(12, 72)
        Me.rtx_descripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.rtx_descripcion.Name = "rtx_descripcion"
        Me.rtx_descripcion.Size = New System.Drawing.Size(318, 79)
        Me.rtx_descripcion.TabIndex = 3
        Me.rtx_descripcion.Text = ""
        '
        'lbl_nomCat
        '
        Me.lbl_nomCat.AutoSize = True
        Me.lbl_nomCat.Location = New System.Drawing.Point(10, 11)
        Me.lbl_nomCat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nomCat.Name = "lbl_nomCat"
        Me.lbl_nomCat.Size = New System.Drawing.Size(91, 13)
        Me.lbl_nomCat.TabIndex = 4
        Me.lbl_nomCat.Text = "Nombre categoria"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(10, 55)
        Me.lbl_descripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 5
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'frm_addCategoriaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 192)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nomCat)
        Me.Controls.Add(Me.rtx_descripcion)
        Me.Controls.Add(Me.txt_nomCate)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_add)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_addCategoriaArticulo"
        Me.Text = "Agregar nueva categoria de articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_nomCate As System.Windows.Forms.TextBox
    Friend WithEvents rtx_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_nomCat As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
End Class
