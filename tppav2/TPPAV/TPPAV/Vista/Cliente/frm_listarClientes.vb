Public Class frm_listarClientes
    Private Sub frm_listarClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        'de la fila seleccionada agarro la celda de la columna col_id y tomo el valor, ese valor lo paso a Integer'
        Dim cli As Cliente = dgv_listaClientes.CurrentRow.DataBoundItem
        'uso el servicio de cliente, que es el que se comunica con los daos que se comunican con la bd'
        Dim clienteService As New ClienteService
        'llamo al metodo darDeBajaCliente del servicio de cliente, y le paso el id'
        clienteService.darDeBajaCliente(cli.idCliente)
        'cargo la grilla de nuevo, para simular que se refresca'
        Me.cargarGrilla()
    End Sub

    Public Sub cargarGrilla()
        Dim clienteService As New ClienteService
        'limpio la grilla'
        dgv_listaClientes.AutoGenerateColumns = False
        dgv_listaClientes.DataSource = ""
        dgv_listaClientes.DataSource = clienteService.listarClientes
        dgv_listaClientes.Columns.Item(0).DataPropertyName = "idCliente"
        dgv_listaClientes.Columns.Item(1).DataPropertyName = "nombre"
        dgv_listaClientes.Columns.Item(2).DataPropertyName = "apellido"
        dgv_listaClientes.Columns.Item(3).DataPropertyName = "direccion"
        dgv_listaClientes.Columns.Item(4).DataPropertyName = "barrio"
        dgv_listaClientes.Columns.Item(5).DataPropertyName = "telefono"
        dgv_listaClientes.Columns.Item(6).DataPropertyName = "mail"
        dgv_listaClientes.Columns.Item(7).DataPropertyName = "dni"
        dgv_listaClientes.Columns.Item(8).DataPropertyName = "descripcion"

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'Me.Hide()
        'ShowDialog lo que hace es mostrar una form en forma de dialog, para obtener un resultado
        'esta Form es "duenia" de la form addClientes y recibira los resultados que le provea esa form
        'frm_addClientes.ShowDialog()
        Dim dialog As frm_addClientes
        dialog = New frm_addClientes()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.OK Then
            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        Dim cl As Cliente = dgv_listaClientes.CurrentRow.DataBoundItem

        Dim addcli As frm_addClientes = New frm_addClientes

        'seteo el modoeditar de frmaddclientes'
        addcli.modoEditar(cl)
        'hago visible al formulario frmaddclientes'
        Dim res As DialogResult = addcli.ShowDialog
        If res = DialogResult.OK Then
            Me.cargarGrilla()
        End If
    End Sub

End Class