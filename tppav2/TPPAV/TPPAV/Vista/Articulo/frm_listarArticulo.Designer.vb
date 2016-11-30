<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarArticulo
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
        Me.dgv_articulos = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_preciou = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_articulos
        '
        Me.dgv_articulos.AllowUserToAddRows = False
        Me.dgv_articulos.AllowUserToDeleteRows = False
        Me.dgv_articulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_nombre, Me.col_descripcion, Me.col_preciou, Me.col_prov})
        Me.dgv_articulos.Location = New System.Drawing.Point(19, 105)
        Me.dgv_articulos.Name = "dgv_articulos"
        Me.dgv_articulos.ReadOnly = True
        Me.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulos.Size = New System.Drawing.Size(551, 193)
        Me.dgv_articulos.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID Articulo"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_descripcion
        '
        Me.col_descripcion.HeaderText = "Descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        '
        'col_preciou
        '
        Me.col_preciou.HeaderText = "Precio Unitario"
        Me.col_preciou.Name = "col_preciou"
        Me.col_preciou.ReadOnly = True
        '
        'col_prov
        '
        Me.col_prov.HeaderText = "Proveedor"
        Me.col_prov.Name = "col_prov"
        Me.col_prov.ReadOnly = True
        '
        'cbo_categorias
        '
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Location = New System.Drawing.Point(163, 45)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(144, 21)
        Me.cbo_categorias.TabIndex = 1
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(442, 43)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 2
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elegir modelo:"
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_editar.Image = Global.TPPAV.My.Resources.Resources.user
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(108, 314)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_editar.Size = New System.Drawing.Size(82, 89)
        Me.btn_editar.TabIndex = 9
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Image = Global.TPPAV.My.Resources.Resources.rubbish_bin
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(202, 314)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 89)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Image = Global.TPPAV.My.Resources.Resources.add_user
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(300, 314)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_add.Size = New System.Drawing.Size(88, 89)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_exit.Image = Global.TPPAV.My.Resources.Resources._exit
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(398, 314)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Size = New System.Drawing.Size(88, 89)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_listarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 420)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.dgv_articulos)
        Me.Name = "frm_listarArticulo"
        Me.Text = "Listado de Artículos"
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_articulos As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents col_preciou As DataGridViewTextBoxColumn
    Friend WithEvents col_prov As DataGridViewTextBoxColumn
    Friend WithEvents cbo_categorias As ComboBox
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_exit As Button
End Class
