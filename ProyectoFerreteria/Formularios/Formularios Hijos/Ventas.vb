Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios


Public Class Ventas

    'Instancias ulitilizadas'
    Private _ProductosBol As New Bol_Producto()
    Private _ClientesBol As New Bol_Cliente()
    Private _FacturaVentaBol As New Bol_FacturaVenta()
    Private _MedidaBol As New Bol_UnidadMedida
    Private _Factura As New E_FacturaVenta()
    Dim _Funcion As New Func
    Dim AuxCantidad As Decimal

#Region "Metodos de apoyo"
    Public Sub LlenarComboboxProducto()
        Dim ListaProducto = _ProductosBol.ListarIDProductos()
        For I = 0 To ListaProducto.length - 1
            ComboBox2.Items.Add(ListaProducto(I))
        Next
        ComboBox2.SelectedIndex = 0
        ComboBoxBusqueda.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0

    End Sub

    Public Sub LlenarComboboxCliente()
        Dim ListaClientes = _ClientesBol.ObtenerIDClientes()
        For I = 0 To ListaClientes.length - 1
            ComboBoxBusqueda.Items.Add(ListaClientes(I))
        Next
    End Sub

    Public Sub ActualizarPrecios()
        Dim SubTotal = 0.00
        For I = 0 To DataGridINVENTARIO.Rows.Count - 1
            DataGridINVENTARIO.Rows(I).Cells(0).Value = (I + 1).ToString()
            SubTotal = SubTotal + (Decimal.Parse(DataGridINVENTARIO.Rows(I).Cells(6).Value.ToString.Split("C"c)(0)) * DataGridINVENTARIO.Rows(I).Cells(5).Value)
        Next
        TextBox3.Text = Math.Round(SubTotal, 3).ToString()
        TextBox6.Text = Math.Round(Math.Abs(((NumericUpDown2.Value / 100) - 1) * Decimal.Parse(TextBox3.Text)), 3)
    End Sub

    Public Function Repetido(ByVal ID As String)
        For I = 0 To DataGridINVENTARIO.Rows.Count - 1
            Dim codigo = DataGridINVENTARIO.Rows(I).Cells(1).Value
            If ID = codigo.ToString Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region

#Region "Eventos"


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim ID As String = Nothing
        If RadioButton1.Checked = True Then
            ID = ComboBox2.Text.Split("#"c)(1).Split(":"c)(0)

        ElseIf RadioButton2.Checked = True Then
            ID = TextBox4.Text
        End If
        ID = ID.Trim()
        If (Repetido(ID) = False) Then
            If RadioButton1.Checked = True Then
                If ((_ProductosBol.ObtenerStockProducto(ID) - NumericUpDown1.Value) >= 0) Then
                    ComboBoxBusqueda_Leave(Nothing, New EventArgs())
                    Dim res = _ProductosBol.LeerProducto(ID)
                    Dim res2 = _MedidaBol.ObtenerUnidadDeMedida(res.P_ID_UnidadMedida)
                    DataGridINVENTARIO.Rows.Add(DataGridINVENTARIO.Rows.Count + 1, res.P_ID_Producto, res.P_Marca, res.P_Descripcion, res2.P_Nombre, NumericUpDown1.Value, res.P_PrecioVenta & " C$", "Eliminar")


                    ' DataGridINVENTARIO.Rows.Add(DataGridINVENTARIO.Rows.Count + 1, TextBox2.Text.Split("#"c)(1).Split(":"c)(0), TextBox2.Text.Split("#"c)(0), TextBox2.Text.Split("#"c)(1).Split(":"c)(1), NumericUpDown1.Value, "Eliminar")
                ElseIf ComboBox2.Text = "" Then
                    MsgBox("Verifique el Campo", MsgBoxStyle.Critical, "FACTURA")
                    ComboBox2.Focus()
                Else
                    MsgBox("No hay suficiente Stock para cubrir dicha cantidad.", MsgBoxStyle.Critical, "FACTURA")
                End If

            ElseIf RadioButton2.Checked = True Then
                If ((_ProductosBol.ObtenerStockProducto(TextBox4.Text) - NumericUpDown1.Value) >= 0) Then
                    ComboBoxBusqueda_Leave(Nothing, New EventArgs())
                    Dim res = _ProductosBol.LeerProducto(TextBox4.Text)
                    Dim res2 = _MedidaBol.ObtenerUnidadDeMedida(res.P_ID_UnidadMedida)
                    DataGridINVENTARIO.Rows.Add(DataGridINVENTARIO.Rows.Count + 1, res.P_ID_Producto, res.P_Marca, res.P_Descripcion, res2.P_Nombre, NumericUpDown1.Value, res.P_PrecioVenta & " C$", "Eliminar")

                Else
                    MsgBox("No hay suficiente Stock para cubrir dicha cantidad.", MsgBoxStyle.Critical, "FACTURA")
                End If

            End If


        Else
            MsgBox("Ya ha añadido este producto a la lista.", MsgBoxStyle.Critical, "FACTURA")
        End If
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _funcion.ALTERNARColorDataGrid(DataGridINVENTARIO)
            LlenarComboboxCliente()
            LlenarComboboxProducto()
            RadioButton1.Select()
            ' TextBox2.Text = ComboBox2.SelectedItem
            Caja.Text = Principal.EmpleadoActivo.Usuario_P


            TextBoxBusqueda.Text = _FacturaVentaBol.ObtenerUltimoID()
            ComboBox2.Text = ""
        Catch ex As Exception

        End Try


    End Sub



    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        'TextBox2.Text = ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBoxBusqueda_Leave(sender As Object, e As EventArgs) Handles ComboBoxBusqueda.Leave
        If (ComboBoxBusqueda.SelectedItem Is Nothing) Then
            ComboBoxBusqueda.SelectedIndex = 0
        End If
    End Sub

    Private Sub DataGridINVENTARIO_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridINVENTARIO.RowsAdded
        ActualizarPrecios()
    End Sub



    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        TextBox6.Text = Math.Round(Math.Abs(((NumericUpDown2.Value / 100) - 1) * Decimal.Parse(TextBox3.Text)), 3)
    End Sub

    Private Sub DataGridINVENTARIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellContentClick
        If (e.ColumnIndex = 7) Then
            Try
                DataGridINVENTARIO.Rows.RemoveAt(e.RowIndex)
                ActualizarPrecios()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub DataGridINVENTARIO_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellValueChanged
        Try
            If (e.ColumnIndex = 5) Then
                If Not ((_ProductosBol.ObtenerStockProducto(DataGridINVENTARIO.Rows(e.RowIndex).Cells(1).Value) - DataGridINVENTARIO.Rows(e.RowIndex).Cells(5).Value) >= 0) Then
                    DataGridINVENTARIO.Rows(e.RowIndex).Cells(5).Value = AuxCantidad
                    MsgBox("No hay suficiente stock para este producto", MsgBoxStyle.Critical, "FACTURA")
                End If
            End If
        Catch ex As Exception

        End Try
        ActualizarPrecios()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Try
            _Factura.P_Tipo = ComboBox1.SelectedItem
            _Factura.P_SubTotal = TextBox3.Text
            _Factura.P_ID_Empleado = Principal.EmpleadoActivo.ID_P
            _Factura.P_ID_Cliente = ComboBoxBusqueda.Text.Split("#"c)(1)
            _Factura.P_Fecha = DateTimePicker1.Value
            _Factura.P_Motivo_Anulacion = ""
        Catch ex As Exception
            MsgBox("algunos campos estan vacios verifique", MsgBoxStyle.Critical, "FACTURA")
        End Try


        Try
            If TextBox1.Text > TextBox6.Text Then
                Dim resl As Double
                resl = TextBox1.Text - TextBox6.Text
                Math.Abs(resl)
                MsgBox("Su cambio es: " + resl.ToString, MsgBoxStyle.Information, "Cambio")
            Else
                TextBox1.Clear()

            End If

        Catch ex As Exception

        End Try


        If (ComboBox1.SelectedItem = "Credito") Then
            _Factura.P_Estado = "Pendiente"
        Else
            _Factura.P_Estado = "Pagada"
        End If
        _Factura.P_Descuento = NumericUpDown2.Value

        Dim ListaItems As New List(Of E_DetalleFactura)
        For I = 0 To DataGridINVENTARIO.Rows.Count - 1
            Dim LineaFactura As New E_DetalleFactura
            LineaFactura.P_ID_Factura = TextBoxBusqueda.Text
            LineaFactura.P_Cantidad = DataGridINVENTARIO.Rows(I).Cells(5).Value
            LineaFactura.P_ID_Producto = DataGridINVENTARIO.Rows(I).Cells(1).Value
            LineaFactura.P_N_Linea = (I + 1)


            'esto era el error que daba
            LineaFactura.P_Precio = DataGridINVENTARIO.Rows(I).Cells(6).Value.split("C"c)(0)
            ListaItems.Add(LineaFactura)
        Next
        If (DataGridINVENTARIO.Rows.Count > 0) Then
            _FacturaVentaBol.InsertarFactura(_Factura, ListaItems)
            Me.Cursor = Cursors.WaitCursor
            If (_FacturaVentaBol.Errores.Length = 0) Then
                MsgBox("La factura fue insertada correctamente", MsgBoxStyle.OkOnly, "Exito")
                Dim resl As Integer
                resl = Integer.Parse(TextBoxBusqueda.Text) + 1
                TextBoxBusqueda.Text = Math.Abs(resl)
                TextBox3.Text = "0"
                NumericUpDown2.Value = 0
                TextBox6.Text = "0"
                DataGridINVENTARIO.Rows.Clear()
            Else
                MsgBox(_FacturaVentaBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
            Me.Cursor = Cursors.Default
        Else
            MsgBox("Debe añadir al menos un elemento a la factura", MsgBoxStyle.Exclamation, "Aviso")
        End If

    End Sub

    'Evento para que se dispare el cambio de objeto tras completar una busqueda'
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2_SelectionChangeCommitted(sender, e)
    End Sub

    Private Sub DataGridINVENTARIO_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridINVENTARIO.CellBeginEdit
        If (e.ColumnIndex = 5) Then
            AuxCantidad = DataGridINVENTARIO.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If


    End Sub






#End Region
End Class