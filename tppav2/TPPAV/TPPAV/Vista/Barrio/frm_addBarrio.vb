Imports System.ComponentModel

Public Class frm_addBarrio
    Dim error_title As String = "Error"
    Dim cerrar As Boolean = False
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
        cerrar = False
        Me.Close()
    End Sub

    Public Sub modoEditar(ByVal barri As Barrio)
        bandera = False
        barrio = barri
        txt_nomBarrio.Text = barrio.nombre
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim barService As BarrioService = New BarrioService()
        cerrar = True
        barrio.nombre = txt_nomBarrio.Text

        If bandera Then

            Try

                If barService.agregarBarrio(barrio) = 1 Then
                    cerrar = False
                    Me.Close()
                Else
                    MsgBox("Error al agregar barrio")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar barrio, probablemente el nombre ya exista", MsgBoxStyle.OkOnly, error_title)
            End Try
        Else
            Try

                If barService.updateBarrio(barrio) = 1 Then
                    bandera = True
                    cerrar = False
                    Me.Close()
                Else
                    MsgBox("Error al actualizar barrio")
                End If
            Catch ex As Exception
                MsgBox("Error al modificar barrio", MsgBoxStyle.OkOnly, error_title)
            End Try
        End If
    End Sub

    Private Sub frm_addBarrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_addBarrio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub
End Class