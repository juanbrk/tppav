<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addArticulo
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
        Me.txt_descripcion = New System.Windows.Forms.RichTextBox()
        Me.txt_precXUnidad = New System.Windows.Forms.TextBox()
        Me.txt_precXCaja = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_proveedores = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(9, 7)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(85, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "*Nombre articulo"
        '
        'lbl_precXUni
        '
        Me.lbl_precXUni.AutoSize = True
        Me.lbl_precXUni.Location = New System.Drawing.Point(9, 118)
        Me.lbl_precXUni.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_precXUni.Name = "lbl_precXUni"
        Me.lbl_precXUni.Size = New System.Drawing.Size(103, 26)
        Me.lbl_precXUni.TabIndex = 1
        Me.lbl_precXUni.Text = "*Precio por unidad $" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_precXCaja
        '
        Me.lbl_precXCaja.AutoSize = True
        Me.lbl_precXCaja.Location = New System.Drawing.Point(216, 118)
        Me.lbl_precXCaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_precXCaja.Name = "lbl_precXCaja"
        Me.lbl_precXCaja.Size = New System.Drawing.Size(87, 13)
        Me.lbl_precXCaja.TabIndex = 2
        Me.lbl_precXCaja.Text = "Precio por caja $"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(9, 44)
        Me.lbl_descripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 3
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'txt_nomArticulo
        '
        Me.txt_nomArticulo.Location = New System.Drawing.Point(11, 24)
        Me.txt_nomArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nomArticulo.Name = "txt_nomArticulo"
        Me.txt_nomArticulo.Size = New System.Drawing.Size(402, 20)
        Me.txt_nomArticulo.TabIndex = 4
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(11, 61)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(402, 38)
        Me.txt_descripcion.TabIndex = 5
        Me.txt_descripcion.Text = ""
        '
        'txt_precXUnidad
        '
        Me.txt_precXUnidad.Location = New System.Drawing.Point(116, 115)
        Me.txt_precXUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_precXUnidad.Name = "txt_precXUnidad"
        Me.txt_precXUnidad.Size = New System.Drawing.Size(96, 20)
        Me.txt_precXUnidad.TabIndex = 6
        '
        'txt_precXCaja
        '
        Me.txt_precXCaja.Location = New System.Drawing.Point(310, 115)
        Me.txt_precXCaja.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_precXCaja.Name = "txt_precXCaja"
        Me.txt_precXCaja.Size = New System.Drawing.Size(103, 20)
        Me.txt_precXCaja.TabIndex = 7
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(322, 203)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(101, 27)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Agregar articulo"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(204, 203)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(94, 27)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cbo_categorias
        '
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Location = New System.Drawing.Point(91, 155)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(121, 21)
        Me.cbo_categorias.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "*Categoría"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Proveedor"
        '
        'cbo_proveedores
        '
        Me.cbo_proveedores.FormattingEnabled = True
        Me.cbo_proveedores.Location = New System.Drawing.Point(296, 155)
        Me.cbo_proveedores.Name = "cbo_proveedores"
        Me.cbo_proveedores.Size = New System.Drawing.Size(121, 21)
        Me.cbo_proveedores.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Los campos con * son obligatorios"
        '
        'frm_addArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 253)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_proveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_precXCaja)
        Me.Controls.Add(Me.txt_precXUnidad)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nomArticulo)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_precXCaja)
        Me.Controls.Add(Me.lbl_precXUni)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_addArticulo"
        Me.Text = "Agregar nuevo articulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_precXUni As System.Windows.Forms.Label
    Friend WithEvents lbl_precXCaja As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_nomArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_precXUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_precXCaja As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cbo_categorias As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_proveedores As ComboBox
    Friend WithEvents Label3 As Label
End Class
