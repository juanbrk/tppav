Public Class frm_listarBarrios

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialog As frm_addBarrio
        dialog = New frm_addBarrio()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.OK Then
            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim id_barri = Integer.Parse(dgv_listadoBarrios.CurrentRow.Cells.Item("col_id").Value)
        Dim barrioService As New BarrioService
        barrioService.darDeBajaBarrio(id_barri)
        Me.cargarGrilla()
    End Sub
    Public Sub cargarGrilla()
        Dim barrioService As New BarrioService
        dgv_listadoBarrios.AutoGenerateColumns = False
        dgv_listadoBarrios.DataSource = ""
        dgv_listadoBarrios.DataSource = barrioService.listarBarrios
        dgv_listadoBarrios.Columns.Item(0).DataPropertyName = "ID_BARRIO"
        dgv_listadoBarrios.Columns.Item(1).DataPropertyName = "nombre"
        dgv_listadoBarrios.Columns.Item(2).DataPropertyName = "provincia"

    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim barr As Barrio = New Barrio
        barr.ID_BARRIO = Integer.Parse(dgv_listadoBarrios.CurrentRow.Cells.Item("col_id").Value)
        barr.nombre = dgv_listadoBarrios.CurrentRow.Cells.Item("col_nom").Value
        Dim add As frm_addBarrio = New frm_addBarrio

        add.modoEditar(barr)
        Dim result As DialogResult = add.ShowDialog
        If result = DialogResult.OK Then
            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub frm_listarBarrios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarGrilla()
    End Sub
End Class