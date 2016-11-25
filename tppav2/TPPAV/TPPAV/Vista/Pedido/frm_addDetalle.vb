Imports System.ComponentModel

Public Class frm_addDetalle
    Dim banderaCategoria As Boolean = False
    Dim banderaArt As Boolean = False
    Dim detalle As New DetallePedido
    Dim cerrar As Boolean = False
    Private Sub frm_addDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servicecat As CategoriaService = New CategoriaService
        Dim categorias As List(Of CategoriaArt) = servicecat.listarCategorias
        cbo_categorias.DataSource = categorias
        cbo_categorias.DisplayMember = "nombre"
        cbo_categorias.ValueMember = "idCat"

        cbo_categorias.SelectedIndex = -1
        banderaCategoria = True
    End Sub

    Private Sub cbo_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categorias.SelectedIndexChanged
        If banderaCategoria Then

            Dim catID As String = cbo_categorias.SelectedValue.ToString
            Dim serviceArt As ArticuloService = New ArticuloService
            Dim articulos As List(Of Articulo) = serviceArt.listarArticulosDeCategoria(catID)
            cbo_articulos.DataSource = articulos
            cbo_articulos.DisplayMember = "nombre"
            cbo_articulos.ValueMember = "idArticulo"
            cbo_articulos.SelectedIndex = -1
            banderaArt = True
            txt_precio.Text = ""
        End If
    End Sub

    Friend Function obtenerDetalle() As DetallePedido
        Return detalle
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        cerrar = True
        If cbo_categorias.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una categoría", MsgBoxStyle.Information)
            Return
        End If

        If txt_cantidad.Text = String.Empty Then
            MsgBox("Debe introducir la cantidad de productos del detalle", MsgBoxStyle.Information)
            Return
        Else
            Try
                detalle.cantidad = Convert.ToInt32(txt_cantidad.Text)
            Catch ex As Exception
                MsgBox("Solo puede introducir numeros en el campo cantidad", MsgBoxStyle.Information)
                Return
            End Try
        End If

        If txt_precio.Text = String.Empty Then
            MsgBox("Debe introducir el precio unitario de los productos del detalle", MsgBoxStyle.Information)
            Return
        Else
            Try
                detalle.precioU = Convert.ToDouble(txt_precio.Text)
            Catch ex As Exception
                MsgBox("Solo puede introducir numeros con decimales en el campo precio", MsgBoxStyle.Information)
                Return
            End Try
        End If


        If cbo_articulos.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un artículo", MsgBoxStyle.Information)
            Return
        Else
            detalle.articulo = cbo_articulos.SelectedItem
        End If
        cerrar = False
        Me.Close()

    End Sub

    Private Sub frm_addDetalle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cerrar = False
        Me.Close()
    End Sub

    Private Sub cbo_articulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_articulos.SelectedIndexChanged
        If banderaArt Then
            Dim art As Articulo = cbo_articulos.SelectedItem
            If Not art Is Nothing Then
                txt_precio.Text = art.precioU.ToString
            End If

        End If
    End Sub
End Class