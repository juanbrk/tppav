﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listarBarrios
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
        Me.dgv_listadoBarrios = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.dgv_listadoBarrios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_listadoBarrios
        '
        Me.dgv_listadoBarrios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_listadoBarrios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgv_listadoBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listadoBarrios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_nom})
        Me.dgv_listadoBarrios.Location = New System.Drawing.Point(13, 13)
        Me.dgv_listadoBarrios.Name = "dgv_listadoBarrios"
        Me.dgv_listadoBarrios.RowTemplate.Height = 24
        Me.dgv_listadoBarrios.Size = New System.Drawing.Size(255, 150)
        Me.dgv_listadoBarrios.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID Barrio"
        Me.col_id.Name = "col_id"
        Me.col_id.Width = 92
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "Nombre"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.Width = 87
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_editar.Image = Global.TPPAV.My.Resources.Resources.user
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(13, 176)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_editar.Size = New System.Drawing.Size(110, 110)
        Me.btn_editar.TabIndex = 6
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Image = Global.TPPAV.My.Resources.Resources.rubbish_bin
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_eliminar.Location = New System.Drawing.Point(158, 176)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_eliminar.Size = New System.Drawing.Size(110, 110)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Image = Global.TPPAV.My.Resources.Resources.add_user
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_add.Location = New System.Drawing.Point(288, 176)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_add.Size = New System.Drawing.Size(110, 110)
        Me.btn_add.TabIndex = 8
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
        Me.btn_exit.Location = New System.Drawing.Point(418, 176)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(10)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(3)
        Me.btn_exit.Size = New System.Drawing.Size(110, 110)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'listarBarrios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 375)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.dgv_listadoBarrios)
        Me.Name = "listarBarrios"
        Me.Text = "Listado de barrios"
        CType(Me.dgv_listadoBarrios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_listadoBarrios As System.Windows.Forms.DataGridView
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
End Class
