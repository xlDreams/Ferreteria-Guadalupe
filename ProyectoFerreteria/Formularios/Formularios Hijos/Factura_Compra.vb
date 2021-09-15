Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios



Public Class Factura_Compra

    Dim _FacturaCompraBol As New Bol_FacturaCompra()
    Dim _ProveedorBol As New Bol_Proveedor()
    Dim _Factura As New E_FacturaCompra()
    Dim IDAux As Integer
    Dim IDProveedor As Integer
    Dim MontoFaltante As Integer

#Region "Metodos de apoyo"
    Public Sub LlenarDataGridViewFacturas()
        DataGridView1.Rows.Clear()
        Dim ListaFacturas
        ListaFacturas = _FacturaCompraBol.LeerFacturas()
        For I As Integer = 0 To ListaFacturas.Count() - 1
            DataGridView1.Rows.Add(ListaFacturas(I).P_ID, ListaFacturas(I).P_ID_Proveedor, ListaFacturas(I).P_NombreProveedor, ListaFacturas(I).P_Total, ListaFacturas(I).P_Fecha, ListaFacturas(I).P_Estado)
        Next
        LlenarComboboxProveedores()
        Label17.Hide()
    End Sub

    Public Sub LlenarDataGridViewFacturasPendientes()
        DataGridView3.Rows.Clear()
        Dim ListaFacturas = _FacturaCompraBol.ObtenerMontosFacturaPendiente(IDAux)
        If (Not (ListaFacturas Is Nothing) AndAlso ListaFacturas.count > 0) Then
            For Index = 0 To ListaFacturas.count - 1
                DataGridView3.Rows.Add(ListaFacturas(Index).P_ID_Factura, ListaFacturas(Index).P_MontoTotal, ListaFacturas(Index).P_MontoPagado, ListaFacturas(Index).P_MontoRestante)
            Next
        End If
    End Sub


    Public Sub LLenarAbonos(ByVal ID As Integer)
        DataGridView2.Rows.Clear()
        Dim ListaAbonos = _FacturaCompraBol.ObtenerAbonosFactura(ID)
        If (Not (ListaAbonos Is Nothing) AndAlso ListaAbonos.count > 0) Then
            For Index = 0 To ListaAbonos.count - 1
                DataGridView2.Rows.Add(ListaAbonos(Index).P_NumeroAbono, ListaAbonos(Index).P_FechaPago, ListaAbonos(Index).P_Descripcion, ListaAbonos(Index).P_MontoAbono)
            Next
        End If
    End Sub

    Public Sub LlenarComboboxProveedores()
        Try
            Dim ListaProveedores = _ProveedorBol.ObtenerIDProveedores()
            ComboBox2.Items.Clear()
            If (_ProveedorBol.Errores.Length = 0) Then
                For I As Integer = 0 To ListaProveedores.length - 1
                    ComboBox2.Items.Add(ListaProveedores(I))
                Next
                ComboBox2.SelectedIndex = 0
                ComboBox3.SelectedIndex = 0
            Else
                MsgBox(_ProveedorBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub Factura_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim HiloFacturas As New Thread(AddressOf LlenarDataGridViewFacturas)
        HiloFacturas.Start()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Factura.P_ID_Proveedor = ComboBox2.Text.Split("#"c)(1)
        _Factura.P_Fecha = DateTimePicker2.Value
        _Factura.P_Tipo = ComboBox3.Text
        _Factura.P_Total = NumericUpDown2.Value
        If (ComboBox3.Text = "Contado") Then
            _Factura.P_Estado = "Pagada"
        Else
            _Factura.P_Estado = "Pendiente"
        End If
        _FacturaCompraBol.InsertarFactura(_Factura)
        If (_FacturaCompraBol.Errores.Length = 0) Then
            LlenarDataGridViewFacturas()
            MsgBox("La factura fue ingresada exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_FacturaCompraBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        DataGridView2.Rows.Clear()
        Me.Cursor = Cursors.WaitCursor
        IDAux = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        IDProveedor = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        DataGridView3.Rows.Clear()
        DataGridView2.Rows.Clear()
        LlenarDataGridViewFacturasPendientes()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridView3_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView3.RowHeaderMouseClick
        Me.Cursor = Cursors.WaitCursor
        MontoFaltante = DataGridView3.Rows(e.RowIndex).Cells(3).Value
        DataGridView2.Rows.Clear()
        LLenarAbonos(DataGridView3.Rows(e.RowIndex).Cells(0).Value)
        TextBox6.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
        TextBox7.Enabled = True
        NumericUpDown1.Enabled = True
        BunifuFlatButton2.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim _Abono As New E_AbonoProveedor
        _Abono.P_Descripcion = TextBox7.Text
        _Abono.P_FechaPago = DateTimePicker1.Value
        _Abono.P_ID_Proveedor = IDProveedor
        _Abono.P_ID_Empleado = Principal.EmpleadoActivo.ID_P
        _Abono.P_MontoAbono = NumericUpDown1.Value
        _Abono.P_NumeroFactura = TextBox6.Text
        If (MontoFaltante - _Abono.P_MontoAbono >= 0) Then
            _FacturaCompraBol.InsertarAbono(_Abono)
            If (_FacturaCompraBol.Errores.Length = 0) Then
                LlenarDataGridViewFacturasPendientes()
                LlenarDataGridViewFacturas()
                LLenarAbonos(_Abono.P_NumeroFactura)
                MsgBox("El abono fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                TextBox6.Text = ""
                TextBox7.Enabled = False
                NumericUpDown1.Enabled = False
                BunifuFlatButton2.Enabled = False
            Else
                MsgBox(_FacturaCompraBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El monto ingresado supera el total de la deuda, debe ingresar un monto inferior", MsgBoxStyle.Critical, "Error")
        End If
    End Sub





#End Region
End Class