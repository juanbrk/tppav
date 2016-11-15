<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirNuevoToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTodosToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TPPAV.DataSet1()
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTableAdapter = New TPPAV.DataSet1TableAdapters.PedidoTableAdapter()
        Me.DataTable1TableAdapter = New TPPAV.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.Pedido2TableAdapter1 = New TPPAV.DataSet1TableAdapters.Pedido2TableAdapter()
        Me.Pedido2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.BarriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem, Me.ListarTodosToolStripMenuItem})
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'AñadirNuevoToolStripMenuItem
        '
        Me.AñadirNuevoToolStripMenuItem.Name = "AñadirNuevoToolStripMenuItem"
        Me.AñadirNuevoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem
        '
        Me.ListarTodosToolStripMenuItem.Name = "ListarTodosToolStripMenuItem"
        Me.ListarTodosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem.Text = "Listar todos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem1, Me.ListarTodosToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AñadirNuevoToolStripMenuItem1
        '
        Me.AñadirNuevoToolStripMenuItem1.Name = "AñadirNuevoToolStripMenuItem1"
        Me.AñadirNuevoToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem1.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem1
        '
        Me.ListarTodosToolStripMenuItem1.Name = "ListarTodosToolStripMenuItem1"
        Me.ListarTodosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem1.Text = "Listar todos"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem2, Me.ListarTodosToolStripMenuItem2})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'AñadirNuevoToolStripMenuItem2
        '
        Me.AñadirNuevoToolStripMenuItem2.Name = "AñadirNuevoToolStripMenuItem2"
        Me.AñadirNuevoToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem2.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem2
        '
        Me.ListarTodosToolStripMenuItem2.Name = "ListarTodosToolStripMenuItem2"
        Me.ListarTodosToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem2.Text = "Listar todos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem3, Me.ListarTodosToolStripMenuItem3})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'AñadirNuevoToolStripMenuItem3
        '
        Me.AñadirNuevoToolStripMenuItem3.Name = "AñadirNuevoToolStripMenuItem3"
        Me.AñadirNuevoToolStripMenuItem3.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem3.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem3
        '
        Me.ListarTodosToolStripMenuItem3.Name = "ListarTodosToolStripMenuItem3"
        Me.ListarTodosToolStripMenuItem3.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem3.Text = "Listar todos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem4, Me.ListarTodosToolStripMenuItem4})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AñadirNuevoToolStripMenuItem4
        '
        Me.AñadirNuevoToolStripMenuItem4.Name = "AñadirNuevoToolStripMenuItem4"
        Me.AñadirNuevoToolStripMenuItem4.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem4.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem4
        '
        Me.ListarTodosToolStripMenuItem4.Name = "ListarTodosToolStripMenuItem4"
        Me.ListarTodosToolStripMenuItem4.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem4.Text = "Listar todos"
        '
        'BarriosToolStripMenuItem
        '
        Me.BarriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirNuevoToolStripMenuItem5, Me.ListarTodosToolStripMenuItem5})
        Me.BarriosToolStripMenuItem.Name = "BarriosToolStripMenuItem"
        Me.BarriosToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BarriosToolStripMenuItem.Text = "Barrios"
        '
        'AñadirNuevoToolStripMenuItem5
        '
        Me.AñadirNuevoToolStripMenuItem5.Name = "AñadirNuevoToolStripMenuItem5"
        Me.AñadirNuevoToolStripMenuItem5.Size = New System.Drawing.Size(145, 22)
        Me.AñadirNuevoToolStripMenuItem5.Text = "Añadir nuevo"
        '
        'ListarTodosToolStripMenuItem5
        '
        Me.ListarTodosToolStripMenuItem5.Name = "ListarTodosToolStripMenuItem5"
        Me.ListarTodosToolStripMenuItem5.Size = New System.Drawing.Size(145, 22)
        Me.ListarTodosToolStripMenuItem5.Text = "Listar todos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 84)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reportes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 84)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Estadísticas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bienvenido "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "L"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "Pedido"
        Me.PedidoBindingSource.DataSource = Me.DataSet1
        '
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Pedido2TableAdapter1
        '
        Me.Pedido2TableAdapter1.ClearBeforeFill = True
        '
        'Pedido2BindingSource
        '
        Me.Pedido2BindingSource.DataMember = "Pedido2"
        Me.Pedido2BindingSource.DataSource = Me.DataSet1
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(569, 340)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_principal"
        Me.Text = "Gestión de Pedidos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedido2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents BarriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirNuevoToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ListarTodosToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PedidoTableAdapter As DataSet1TableAdapters.PedidoTableAdapter
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents Pedido2TableAdapter1 As DataSet1TableAdapters.Pedido2TableAdapter
    Friend WithEvents Pedido2BindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
