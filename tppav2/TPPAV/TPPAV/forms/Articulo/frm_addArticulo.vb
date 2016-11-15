Imports System.ComponentModel

Public Class frm_addArticulo
    Dim cerrar As Boolean = False
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        cerrar = False
        Me.Close()
    End Sub

    Private Sub frm_addArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servicecat As CategoriaService = New CategoriaService
        Dim categorias As List(Of CategoriaArt) = servicecat.listarCategorias
        cbo_categorias.DataSource = categorias
        cbo_categorias.DisplayMember = "nombre"
        cbo_categorias.ValueMember = "idCat"

        cbo_categorias.SelectedIndex = -1

        Dim serviceprov As New ProveedorService
        Dim proveedores As List(Of Proveedor) = serviceprov.listarProveedores
        cbo_proveedores.DataSource = proveedores
        cbo_proveedores.DisplayMember = "razon_social"
        cbo_proveedores.ValueMember = "idProveedor"

        cbo_proveedores.SelectedIndex = -1
        cerrar = True
    End Sub

    Private Sub frm_addArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = cerrar
        cerrar = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        cerrar = True
        Dim articulo As New Articulo
        'primero validaciones de campos obligatorios
        If txt_nomArticulo.Text = String.Empty Then
            MsgBox("Debe ingresar un nombre de artículo", MsgBoxStyle.Information, "Faltan datos")
            Return
        Else
            articulo.nombre = txt_nomArticulo.Text
        End If

        If txt_precXUnidad.Text = String.Empty Then
            MsgBox("Debe ingresar un precio unitario de artículo", MsgBoxStyle.Information, "Faltan datos")
            Return
        Else
            articulo.precioU = Double.Parse(txt_precXUnidad.Text)
        End If

        If txt_descripcion.Text = String.Empty Then
            articulo.descripcion = ""
        Else
            articulo.descripcion = txt_descripcion.Text
        End If

        If cbo_categorias.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una categoría", MsgBoxStyle.Information, "Faltan datos")
            Return
        Else
            articulo.categoria = cbo_categorias.SelectedItem
        End If

        If Not cbo_proveedores.SelectedIndex = -1 Then
            articulo.proveedor = cbo_proveedores.SelectedItem
        End If

        If txt_precXCaja.Text = String.Empty Then
            articulo.precioCaja = 0.0
        Else
            articulo.precioCaja = Double.Parse(txt_precXCaja.Text)
        End If

        Dim service As New ArticuloService
        If service.agregarArticulo(articulo) = 1 Then
            MsgBox("Se ha agregado el artículo con éxito", MsgBoxStyle.Information, "Sistema")
            cerrar = False
            Me.Close()
        Else
            MsgBox("No se ha podido agregar el artículo", MsgBoxStyle.Exclamation, "Sistema")
        End If
    End Sub
End Class