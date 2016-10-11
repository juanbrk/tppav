Public Class frm_listarBarrios

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialog As frm_addBarrio
        dialog = New frm_addBarrio()
        Dim result As DialogResult = dialog.ShowDialog(Me)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_barri = Integer.Parse(dgv_listadoBarrios.CurrentRow.Cells.Item("col_id").Value)
        Dim barrioService As New BarrioService
        barrioService.darDeBajaBarrio(id_barri)
        Me.cargarGrilla()
    End Sub
    Public Sub cargarGrilla()
        Dim barrioService As New BarrioService
        dgv_listadoBarrios.Rows.Clear()
        For Each barr In barrioService.listarBarrios()
            With barr
                dgv_listadoBarrios.Rows.Add(New String() {.ID_BARRIO.ToString, .nombre})
            End With
        Next
    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim barr As Barrio = New Barrio
        barr.ID_BARRIO = Integer.Parse(dgv_listadoBarrios.CurrentRow.Cells.Item("col_id").Value)
        barr.nombre = dgv_listadoBarrios.CurrentRow.Cells.Item("col_nom").Value
        Me.Hide()
        frm_addBarrio.modoEditar(barr)
        frm_addBarrio.Show()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frm_listarBarrios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub
End Class