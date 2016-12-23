<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarCategoria
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
        Me.dgv_categorias = New System.Windows.Forms.DataGridView()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_categorias
        '
        Me.dgv_categorias.AllowUserToAddRows = False
        Me.dgv_categorias.AllowUserToDeleteRows = False
        Me.dgv_categorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_categorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_nombre, Me.col_descripcion})
        Me.dgv_categorias.Location = New System.Drawing.Point(54, 41)
        Me.dgv_categorias.Name = "dgv_categorias"
        Me.dgv_categorias.ReadOnly = True
        Me.dgv_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_categorias.Size = New System.Drawing.Size(422, 193)
        Me.dgv_categorias.TabIndex = 10
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_editar.Image = Global.TPPAV.My.Resources.Resources.user
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(77, 260)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_editar.Size = New System.Drawing.Size(82, 89)
        Me.btn_editar.TabIndex = 17
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Image = Global.TPPAV.My.Resources.Resources.rubbish_bin
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(171, 260)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 89)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Image = Global.TPPAV.My.Resources.Resources.add_user
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(269, 260)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_add.Size = New System.Drawing.Size(88, 89)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_exit.Image = Global.TPPAV.My.Resources.Resources._exit
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(367, 260)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(8)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_exit.Size = New System.Drawing.Size(88, 89)
        Me.btn_exit.TabIndex = 14
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'col_id
        '
        Me.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_id.HeaderText = "Id Categoria"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_descripcion
        '
        Me.col_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_descripcion.HeaderText = "Descripcion"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        '
        'frm_listarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 369)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.dgv_categorias)
        Me.Name = "frm_listarCategoria"
        Me.Text = "Listado de Categorias"
        CType(Me.dgv_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents dgv_categorias As DataGridView
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As DataGridViewTextBoxColumn
End Class
