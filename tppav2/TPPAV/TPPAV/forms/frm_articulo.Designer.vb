<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_articulo
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
        Me.lbl_precXUni = New System.Windows.Forms.Label()
        Me.lbl_precXCaja = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_nomArticulo = New System.Windows.Forms.TextBox()
        Me.rtxt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.txt_precXUnidad = New System.Windows.Forms.TextBox()
        Me.txt_precXCaja = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(12, 9)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(108, 17)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre articulo"
        '
        'lbl_precXUni
        '
        Me.lbl_precXUni.AutoSize = True
        Me.lbl_precXUni.Location = New System.Drawing.Point(12, 142)
        Me.lbl_precXUni.Name = "lbl_precXUni"
        Me.lbl_precXUni.Size = New System.Drawing.Size(132, 34)
        Me.lbl_precXUni.TabIndex = 1
        Me.lbl_precXUni.Text = "Precio por unidad $" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_precXCaja
        '
        Me.lbl_precXCaja.AutoSize = True
        Me.lbl_precXCaja.Location = New System.Drawing.Point(273, 142)
        Me.lbl_precXCaja.Name = "lbl_precXCaja"
        Me.lbl_precXCaja.Size = New System.Drawing.Size(115, 17)
        Me.lbl_precXCaja.TabIndex = 2
        Me.lbl_precXCaja.Text = "Precio por caja $"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(12, 54)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbl_descripcion.TabIndex = 3
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'txt_nomArticulo
        '
        Me.txt_nomArticulo.Location = New System.Drawing.Point(15, 30)
        Me.txt_nomArticulo.Name = "txt_nomArticulo"
        Me.txt_nomArticulo.Size = New System.Drawing.Size(359, 22)
        Me.txt_nomArticulo.TabIndex = 4
        '
        'rtxt_descripcion
        '
        Me.rtxt_descripcion.Location = New System.Drawing.Point(15, 75)
        Me.rtxt_descripcion.Name = "rtxt_descripcion"
        Me.rtxt_descripcion.Size = New System.Drawing.Size(359, 46)
        Me.rtxt_descripcion.TabIndex = 5
        Me.rtxt_descripcion.Text = ""
        '
        'txt_precXUnidad
        '
        Me.txt_precXUnidad.Location = New System.Drawing.Point(141, 139)
        Me.txt_precXUnidad.Name = "txt_precXUnidad"
        Me.txt_precXUnidad.Size = New System.Drawing.Size(126, 22)
        Me.txt_precXUnidad.TabIndex = 6
        '
        'txt_precXCaja
        '
        Me.txt_precXCaja.Location = New System.Drawing.Point(395, 142)
        Me.txt_precXCaja.Name = "txt_precXCaja"
        Me.txt_precXCaja.Size = New System.Drawing.Size(136, 22)
        Me.txt_precXCaja.TabIndex = 7
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(396, 201)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(135, 33)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Agregar articulo"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(247, 201)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(126, 33)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Limpiar campos"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 246)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_precXCaja)
        Me.Controls.Add(Me.txt_precXUnidad)
        Me.Controls.Add(Me.rtxt_descripcion)
        Me.Controls.Add(Me.txt_nomArticulo)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_precXCaja)
        Me.Controls.Add(Me.lbl_precXUni)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "frm_articulo"
        Me.Text = "Agregar nuevo articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_precXUni As System.Windows.Forms.Label
    Friend WithEvents lbl_precXCaja As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_nomArticulo As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_precXUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_precXCaja As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
