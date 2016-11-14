<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarClientes
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
        Me.dgv_listaClientes = New System.Windows.Forms.DataGridView()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barrio_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nomCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_listaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listaClientes
        '
        Me.dgv_listaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_listaClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.barrio_id, Me.col_nomCliente, Me.col_apellido, Me.col_direccion, Me.col_barrio, Me.col_telefono})
        Me.dgv_listaClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_listaClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgv_listaClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv_listaClientes.Name = "dgv_listaClientes"
        Me.dgv_listaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_listaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_listaClientes.RowTemplate.Height = 24
        Me.dgv_listaClientes.Size = New System.Drawing.Size(713, 203)
        Me.dgv_listaClientes.StandardTab = True
        Me.dgv_listaClientes.TabIndex = 0
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_editar.Image = Global.TPPAV.My.Resources.Resources.user
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(141, 223)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_editar.Size = New System.Drawing.Size(82, 89)
        Me.btn_editar.TabIndex = 5
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Image = Global.TPPAV.My.Resources.Resources.rubbish_bin
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(238, 223)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_eliminar.Size = New System.Drawing.Size(82, 89)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.Image = Global.TPPAV.My.Resources.Resources.add_user
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(336, 223)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_add.Size = New System.Drawing.Size(82, 89)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Agregar"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.Image = Global.TPPAV.My.Resources.Resources._exit
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.Location = New System.Drawing.Point(434, 223)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_exit.Size = New System.Drawing.Size(82, 89)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id cliente"
        Me.col_id.Name = "col_id"
        '
        'barrio_id
        '
        Me.barrio_id.HeaderText = "Column1"
        Me.barrio_id.Name = "barrio_id"
        Me.barrio_id.Visible = False
        '
        'col_nomCliente
        '
        Me.col_nomCliente.HeaderText = "Nombre cliente"
        Me.col_nomCliente.Name = "col_nomCliente"
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        '
        'col_direccion
        '
        Me.col_direccion.HeaderText = "Direccion"
        Me.col_direccion.Name = "col_direccion"
        '
        'col_barrio
        '
        Me.col_barrio.HeaderText = "Barrio"
        Me.col_barrio.Name = "col_barrio"
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        '
        'frm_listarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(713, 340)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.dgv_listaClientes)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_listarClientes"
        Me.Text = "Listado de Clientes"
        CType(Me.dgv_listaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_listaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents barrio_id As DataGridViewTextBoxColumn
    Friend WithEvents col_nomCliente As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_direccion As DataGridViewTextBoxColumn
    Friend WithEvents col_barrio As DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As DataGridViewTextBoxColumn
End Class
