Public Class frm_addBarrio
    Dim msj_errorTipoDato As String = "Por favor, ingrese solo numeros en el campo telefono"
    Dim error_title As String = "Error"
    Property bandera As Boolean = True
    Dim cantBarrios As Integer = 0
    Dim barrio As Barrio = New Barrio()
    'Esto obtiene el valor ingresado en el nombre del barrio y lo devuelve a la forma principal, la que es duenia de esta forma. 
    'Public Property Note As String
    '    Get
    '        Return txt_nomBarrio.Text
    '    End Get
    '    Set(value As String)

    '    End Set
    'End Property

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

    End Sub

    Public Sub modoEditar(ByVal barri As Barrio)
        bandera = False
        barrio = barri
        txt_nomBarrio.Text = barrio.nombre
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim barService As BarrioService = New BarrioService()

        barrio.nombre = txt_nomBarrio.Text

        If bandera Then

            Try

                barService.agregarBarrio(barrio)
                frm_listarBarrios.cargarGrilla()
                frm_listarBarrios.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(msj_errorTipoDato, MsgBoxStyle.OkOnly, error_title)
            End Try
        Else
            Try

                barService.updateBarrio(barrio)
                bandera = True
                frm_listarBarrios.cargarGrilla()
                frm_listarBarrios.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(msj_errorTipoDato, MsgBoxStyle.OkOnly, error_title)
            End Try
        End If
    End Sub
End Class