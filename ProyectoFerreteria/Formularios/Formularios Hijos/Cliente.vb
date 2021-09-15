Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Cliente

    Dim _ClientesBol As New Bol_Cliente()
    Dim _Cliente As New E_Cliente()
    Dim _FacturaVentaBol As New Bol_FacturaVenta()
    Dim IDAux As Integer
    Dim MontoFaltante As Integer
    Dim _Funcion As New Func
#Region "Metodos de apoyo"
    Public Sub LlenarDataGridViewClientes()
        DataGridINVENTARIO.Rows.Clear()
        Dim ListaClientes
        ListaClientes = _ClientesBol.ObtenerListaClientes()
        For I As Integer = 0 To ListaClientes.Count() - 1
            DataGridINVENTARIO.Rows.Add(ListaClientes(I).ID_P, ListaClientes(I).Nombre_P, ListaClientes(I).Apellido_P, ListaClientes(I).Cedula_P, ListaClientes(I).Direccion_P, ListaClientes(I).Telefono_P, "Editar", "Eliminar")
        Next
        Label17.Hide()
    End Sub

    Public Sub LlenarDataGridViewFacturasPendientes()
        DataGridView2.Rows.Clear()
        Dim ListaFacturas = _FacturaVentaBol.ObtenerMontosFacturaPendiente(IDAux)
        If (Not (ListaFacturas Is Nothing) AndAlso ListaFacturas.count > 0) Then
            For Index = 0 To ListaFacturas.count - 1
                DataGridView2.Rows.Add(ListaFacturas(Index).P_ID_Factura, ListaFacturas(Index).P_MontoTotal, ListaFacturas(Index).P_MontoPagado, ListaFacturas(Index).P_MontoRestante)
            Next
        End If
    End Sub
    Public Sub LlenarDataGridViewClientesFiltro(ByVal TipoFiltro As Integer, ByVal CadenaFiltro As String)
        DataGridINVENTARIO.Rows.Clear()
        Dim ListaClientes
        ListaClientes = _ClientesBol.FiltrosCliente(TipoFiltro, CadenaFiltro)
        If (ListaClientes.count > 0) Then
            For I As Integer = 0 To ListaClientes.Count() - 1
                DataGridINVENTARIO.Rows.Add(ListaClientes(I).ID_P, ListaClientes(I).Nombre_P, ListaClientes(I).Apellido_P, ListaClientes(I).Cedula_P, ListaClientes(I).Direccion_P, ListaClientes(I).Telefono_P, "Editar", "Eliminar")
            Next
        End If
        Label17.Hide()
    End Sub

    Public Sub ListarCliente(ByVal ID As Integer)
        Dim Cliente = _ClientesBol.ObtenerCliente(ID)
        VentaBox.Text = Cliente.Nombre_P
        TextBox1.Text = Cliente.Apellido_P
        TextBox2.Text = Cliente.Telefono_P
        TextBox4.Text = Cliente.Direccion_P
        TextBox3.Text = Cliente.Cedula_P
    End Sub

    Public Sub LLenarAbonos(ByVal ID As Integer)
        DataGridView1.Rows.Clear()
        Dim ListaAbonos = _FacturaVentaBol.ObtenerAbonosFactura(ID)
        If (Not (ListaAbonos Is Nothing) AndAlso ListaAbonos.count > 0) Then
            For Index = 0 To ListaAbonos.count - 1
                DataGridView1.Rows.Add(ListaAbonos(Index).P_NumeroAbono, ListaAbonos(Index).P_FechaPago, ListaAbonos(Index).P_Descripcion, ListaAbonos(Index).P_MontoAbono)
            Next
        End If
    End Sub

#End Region


#Region "Eventos"
    Private Sub DataGridINVENTARIO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridINVENTARIO.CellContentClick
        If (e.ColumnIndex = 6) Then
            BunifuFlatButton3.Visible = True
            Me.Cursor = Cursors.WaitCursor
            ListarCliente(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
            IDAux = DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 7) Then
            Dim resulta As Integer = MessageBox.Show("¿Esta seguro que desea eliminar?", "Cliente", MessageBoxButtons.YesNo)
            If resulta = DialogResult.No Then

                MsgBox("No se elimino el cliente", MsgBoxStyle.Information, "INFORMACION")
            ElseIf resulta = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor
                _ClientesBol.EliminarCliente(DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value)
                If (_ClientesBol.Errores.Length = 0) Then
                    LlenarDataGridViewClientes()
                    MsgBox("El cliente fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Else
                    MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If
                Me.Cursor = Cursors.Default
            End If

        End If



    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Cliente.Nombre_P = VentaBox.Text
        _Cliente.Apellido_P = TextBox1.Text
        _Cliente.Telefono_P = TextBox2.Text
        _Cliente.Cedula_P = TextBox3.Text
        _Cliente.Direccion_P = TextBox4.Text
        _ClientesBol.InsertarCliente(_Cliente)
        If (_ClientesBol.Errores.Length = 0) Then
            LlenarDataGridViewClientes()
            MsgBox("El cliente fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        _Cliente.Nombre_P = VentaBox.Text
        _Cliente.Apellido_P = TextBox1.Text
        _Cliente.Telefono_P = TextBox2.Text
        _Cliente.Cedula_P = TextBox3.Text
        _Cliente.Direccion_P = TextBox4.Text
        _Cliente.ID_P = IDAux
        _ClientesBol.ActualizarCliente(_Cliente)
        If (_ClientesBol.Errores.Length = 0) Then
            LlenarDataGridViewClientes()
            BunifuFlatButton3.Visible = False
            MsgBox("El cliente fue actualizado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ClientesBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub VentaBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VentaBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox4.Select()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboBoxBusqueda.SelectedIndex = 0
        _funcion.ALTERNARColorDataGrid(DataGridINVENTARIO)
        Dim HiloCliente As New Thread(AddressOf LlenarDataGridViewClientes)
        HiloCliente.Start()
    End Sub

    Private Sub FiltrarBoton_Click(sender As Object, e As EventArgs) Handles FiltrarBoton.Click
        If (ComboBoxBusqueda.SelectedItem = "Codigo") Then
            LlenarDataGridViewClientesFiltro(0, TextBoxBusqueda.Text)
        ElseIf (ComboBoxBusqueda.SelectedItem = "Cedula") Then
            LlenarDataGridViewClientesFiltro(1, TextBoxBusqueda.Text)
        ElseIf (ComboBoxBusqueda.SelectedItem = "Telefono") Then
            LlenarDataGridViewClientesFiltro(2, TextBoxBusqueda.Text)
        Else
            LlenarDataGridViewClientes()
        End If
    End Sub


    Private Sub DataGridINVENTARIO_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridINVENTARIO.RowHeaderMouseClick
        DataGridView2.Rows.Clear()
        Me.Cursor = Cursors.WaitCursor
        IDAux = DataGridINVENTARIO.Rows(e.RowIndex).Cells(0).Value
        DataGridView2.Rows.Clear()
        DataGridView1.Rows.Clear()
        LlenarDataGridViewFacturasPendientes()
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub DataGridView2_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        Me.Cursor = Cursors.WaitCursor
        MontoFaltante = DataGridView2.Rows(e.RowIndex).Cells(3).Value
        DataGridView1.Rows.Clear()
        LLenarAbonos(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
        TextBox6.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox7.Enabled = True
        NumericUpDown1.Enabled = True
        BunifuFlatButton2.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim _Abono As New E_AbonoCliente
        _Abono.P_Descripcion = TextBox7.Text
        _Abono.P_FechaPago = DateTimePicker1.Value
        _Abono.P_ID_Cliente = IDAux
        _Abono.P_ID_Empleado = Principal.EmpleadoActivo.ID_P
        _Abono.P_MontoAbono = NumericUpDown1.Value
        _Abono.P_NumeroFactura = TextBox6.Text
        If (MontoFaltante - _Abono.P_MontoAbono >= 0) Then
            _FacturaVentaBol.InsertarAbono(_Abono)
            If (_FacturaVentaBol.Errores.Length = 0) Then
                LlenarDataGridViewFacturasPendientes()
                LLenarAbonos(_Abono.P_NumeroFactura)
                MsgBox("El abono fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                TextBox6.Text = ""
                TextBox7.Enabled = False
                NumericUpDown1.Enabled = False
                BunifuFlatButton2.Enabled = False
            Else
                MsgBox(_FacturaVentaBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El monto ingresado supera el total de la deuda, debe ingresar un monto inferior", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub
#End Region
End Class