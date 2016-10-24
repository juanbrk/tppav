Imports System.ComponentModel

Public Class frm_addProovedor
    Dim cerrar As Boolean = False

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cerrar = False
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim prov As Proveedor = New Proveedor()
        cerrar = True

        If txt_telefono.Text = String.Empty Then
            MsgBox("Debe insertar un numero de telefono en el campo de telefono")
            Return
        Else
            Try
                prov.telefono = (Convert.ToInt32(txt_telefono.Text)).ToString 'obligamos a que sean solo numeros
            Catch ex As Exception
                MsgBox("Solo puede introducir números en el campo telefono")
                Return
            End Try
        End If

        If txt_email.Text = String.Empty Then
            prov.email = "Sin mail"
        Else
            prov.email = txt_email.Text
        End If

        If txt_razonSocial.Text = String.Empty Then
            MsgBox("Debe ingresar una razón social")
            Return
        Else
            prov.razon_social = txt_razonSocial.Text
        End If

        If txt_direccion.Text = String.Empty Then
            prov.direccion = "N/D"
        Else
            prov.direccion = txt_direccion.Text
        End If

        Dim provService As New ProveedorService
        If provService.agregarProveedor(prov) Then
            MsgBox("Proveedor agregado con éxito", MsgBoxStyle.OkOnly)
            cerrar = False
            Me.Close()
        Else
            MsgBox("Hubo un error al agregar el proveedor")
            Return
        End If
    End Sub

    Private Sub frm_addProovedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub



End Class