﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarPedidos
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
        Me.dgv_detalles = New System.Windows.Forms.DataGridView()
        Me.col_id_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_ped = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_ent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_efec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_extra1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_extra2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_usu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_terminado = New System.Windows.Forms.Button()
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_detalles
        '
        Me.dgv_detalles.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_det, Me.col_precio, Me.col_cant, Me.col_art})
        Me.dgv_detalles.Location = New System.Drawing.Point(422, 313)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.ReadOnly = True
        Me.dgv_detalles.Size = New System.Drawing.Size(444, 176)
        Me.dgv_detalles.TabIndex = 0
        '
        'col_id_det
        '
        Me.col_id_det.HeaderText = "Detalle ID"
        Me.col_id_det.Name = "col_id_det"
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio Uni."
        Me.col_precio.Name = "col_precio"
        '
        'col_cant
        '
        Me.col_cant.HeaderText = "Cantidad"
        Me.col_cant.Name = "col_cant"
        '
        'col_art
        '
        Me.col_art.HeaderText = "Articulo"
        Me.col_art.Name = "col_art"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(518, 255)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar detalle"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_nom_cli, Me.col_fecha_ped, Me.col_fecha_ent, Me.col_total, Me.col_nro, Me.col_efec, Me.col_descuento, Me.col_extra1, Me.col_extra2, Me.col_usu})
        Me.dgv_pedidos.Location = New System.Drawing.Point(60, 72)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.ReadOnly = True
        Me.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pedidos.Size = New System.Drawing.Size(1143, 150)
        Me.dgv_pedidos.TabIndex = 2
        '
        'col_id
        '
        Me.col_id.HeaderText = "Pedido ID"
        Me.col_id.Name = "col_id"
        '
        'col_nom_cli
        '
        Me.col_nom_cli.HeaderText = "Cliente"
        Me.col_nom_cli.Name = "col_nom_cli"
        '
        'col_fecha_ped
        '
        Me.col_fecha_ped.HeaderText = "Fecha Pedido"
        Me.col_fecha_ped.Name = "col_fecha_ped"
        '
        'col_fecha_ent
        '
        Me.col_fecha_ent.HeaderText = "Fecha Entrega"
        Me.col_fecha_ent.Name = "col_fecha_ent"
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        '
        'col_nro
        '
        Me.col_nro.HeaderText = "Num Fac"
        Me.col_nro.Name = "col_nro"
        '
        'col_efec
        '
        Me.col_efec.HeaderText = "Efectivo"
        Me.col_efec.Name = "col_efec"
        '
        'col_descuento
        '
        Me.col_descuento.HeaderText = "Descuento"
        Me.col_descuento.Name = "col_descuento"
        '
        'col_extra1
        '
        Me.col_extra1.HeaderText = "Extra1"
        Me.col_extra1.Name = "col_extra1"
        '
        'col_extra2
        '
        Me.col_extra2.HeaderText = "Extra2"
        Me.col_extra2.Name = "col_extra2"
        '
        'col_usu
        '
        Me.col_usu.HeaderText = "Creador"
        Me.col_usu.Name = "col_usu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pedidos no terminados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Pedido seleccionado:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(371, 260)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(15, 13)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "id"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(613, 518)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_terminado
        '
        Me.btn_terminado.Location = New System.Drawing.Point(725, 255)
        Me.btn_terminado.Name = "btn_terminado"
        Me.btn_terminado.Size = New System.Drawing.Size(170, 23)
        Me.btn_terminado.TabIndex = 7
        Me.btn_terminado.Text = "Marcar pedido como terminado"
        Me.btn_terminado.UseVisualStyleBackColor = True
        '
        'frm_listarPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 561)
        Me.Controls.Add(Me.btn_terminado)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.dgv_detalles)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_listarPedidos"
        Me.Text = "Listado de Pedidos"
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_detalles As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_nom_cli As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_ped As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_ent As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents col_nro As DataGridViewTextBoxColumn
    Friend WithEvents col_efec As DataGridViewTextBoxColumn
    Friend WithEvents col_descuento As DataGridViewTextBoxColumn
    Friend WithEvents col_extra1 As DataGridViewTextBoxColumn
    Friend WithEvents col_extra2 As DataGridViewTextBoxColumn
    Friend WithEvents col_usu As DataGridViewTextBoxColumn
    Friend WithEvents col_id_det As DataGridViewTextBoxColumn
    Friend WithEvents col_precio As DataGridViewTextBoxColumn
    Friend WithEvents col_cant As DataGridViewTextBoxColumn
    Friend WithEvents col_art As DataGridViewTextBoxColumn
    Friend WithEvents btn_terminado As Button
End Class
