Public Class frm_listarClientes
    Private Sub frm_listarClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_cli = Integer.Parse(dgv_listaClientes.CurrentRow.Cells.Item("col_id").Value)
        Dim clienteService As New ClienteService
        clienteService.darDeBajaCliente(id_cli)
        Me.cargarGrilla()
    End Sub
    
    Public Sub cargarGrilla()
        Dim clienteService As New ClienteService
        dgv_listaClientes.Rows.Clear()
        For Each cli In clienteService.listarClientes()
            With cli
                dgv_listaClientes.Rows.Add(New String() {.idCliente.ToString, .nombre, .apellido, .direccion, .zona, .telefono})
            End With
        Next
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'Me.Hide()
        'ShowDialog lo que hace es mostrar una form en forma de dialog, para obtener un resultado
        'esta Form es "duenia" de la form addClientes y recibira los resultados que le provea esa form
        'frm_addClientes.ShowDialog()
        Dim dialog As frm_addClientes
        dialog = New frm_addClientes()
        Dim result As DialogResult = dialog.ShowDialog(Me)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim cl As Cliente = New Cliente
        cl.idCliente = Integer.Parse(dgv_listaClientes.CurrentRow.Cells.Item("col_id").Value)
        cl.nombre = dgv_listaClientes.CurrentRow.Cells.Item("col_nomCliente").Value
        cl.apellido = dgv_listaClientes.CurrentRow.Cells.Item("col_apellido").Value
        cl.direccion = dgv_listaClientes.CurrentRow.Cells.Item("col_direccion").Value
        cl.zona = dgv_listaClientes.CurrentRow.Cells.Item("col_barrio").Value
        cl.telefono = Integer.Parse(dgv_listaClientes.CurrentRow.Cells.Item("col_telefono").Value)
        Me.Hide()
        frm_addClientes.modoEditar(cl)
        frm_addClientes.Show()
    End Sub

    Private Sub dgv_listaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listaClientes.CellContentClick

    End Sub
End Class