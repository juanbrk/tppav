Imports System.ComponentModel
Imports TPPAV

Public Class frm_addArticulo
    Dim cerrar As Boolean = False
    Dim bandera As Boolean = True
    Dim articulo As New Articulo
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
        Else
            articulo.proveedor = Nothing
        End If


        Dim service As New ArticuloService
        If bandera Then
            Try
                'agregamos un NUEVO cliente, por la bandera nos dimos cuenta que habia que agregarlo'
                If service.agregarArticulo(articulo) = 1 Then
                    MsgBox("Articulo agregado con éxito")
                    cerrar = False
                End If
                'refrescamos la grilla del listar clientes y la hacemos visible'

            Catch ex As Exception
                MsgBox("Error al agregar el articulo", MsgBoxStyle.OkOnly, "Base de Datos")
                Return
            End Try
        Else
            Try

                If service.updateArticulo(articulo) = 1 Then
                    MsgBox("Articulo actualizado con éxito")
                    cerrar = False
                End If
                'volvemos a setear la bandera a true, que seria el modo añadir'
                'bandera = True no es necesario

            Catch ex As Exception
                MsgBox("Error al actualizar el articulo", MsgBoxStyle.OkOnly, "Base de Datos")
                Return
            End Try
        End If
        Me.Close()
    End Sub

    Friend Sub modoEditar(art As Articulo)
        bandera = False

        articulo = art
        txt_nomArticulo.Text = art.nombre
        txt_descripcion.Text = art.descripcion
        txt_precXUnidad.Text = art.precioU.ToString
    End Sub
End Class