Public Class frm_listarProovedores
    Private Sub frm_listarProovedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarProveedores()
    End Sub

    Private Sub cargarProveedores()
        Dim provService As New ProveedorService
        Dim lista As List(Of Proveedor) = New List(Of Proveedor)
        lista = provService.listarProveedores

        dgv_proveedores.AutoGenerateColumns = False
        dgv_proveedores.DataSource = ""
        dgv_proveedores.DataSource = lista
        dgv_proveedores.Columns.Item(0).DataPropertyName = "idProveedor"
        dgv_proveedores.Columns.Item(1).DataPropertyName = "razon_social"
        dgv_proveedores.Columns.Item(2).DataPropertyName = "direccion"
        dgv_proveedores.Columns.Item(3).DataPropertyName = "email"
        dgv_proveedores.Columns.Item(4).DataPropertyName = "telefono"

    End Sub

    Private Sub btn_ext_Click(sender As Object, e As EventArgs) Handles btn_ext.Click
        Me.Close()
    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim add As frm_addProovedor = New frm_addProovedor
        Dim result As DialogResult = add.ShowDialog(Me)
        If result = DialogResult.OK Then
            cargarProveedores()
        End If

    End Sub
End Class