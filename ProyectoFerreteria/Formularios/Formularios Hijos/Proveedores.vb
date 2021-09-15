Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Proveedores

    'Instancias ulitilizadas'
    Private _ProveedoresBol As New Bol_Proveedor()
    Private _Proveedor As New E_Proveedor()
    Private IDTemp As Integer
    Private _Funcion As New Func

#Region "Metodos de apoyo"
    Public Sub LlenarDataGridViewProveedores()
        DataGridProveedores.Rows.Clear()
        Dim ListaProveedores
        ListaProveedores = _ProveedoresBol.ObtenerProveedores()
        For I As Integer = 0 To ListaProveedores.Count() - 1
            DataGridProveedores.Rows.Add(ListaProveedores(I).P_ID_Proveedor, ListaProveedores(I).P_Nombre, ListaProveedores(I).P_Telefono, ListaProveedores(I).P_Correo, ListaProveedores(I).P_Direccion, "Editar", "Eliminar")
        Next
        Label17.Hide()
    End Sub

    Public Sub ListarProveedor(ByVal ID As Integer)
        Dim Proveedor = _ProveedoresBol.ObtenerProveedor(ID)
        VentaBox.Text = Proveedor.P_Nombre
        TextBox1.Text = Proveedor.P_Telefono
        TextBox3.Text = Proveedor.P_Correo
        TextBox4.Text = Proveedor.P_Direccion
    End Sub

#End Region

#Region "Eventos"
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        _Funcion.ALTERNARColorDataGrid(DataGridProveedores)
        Dim HiloProveedores As New Thread(AddressOf LlenarDataGridViewProveedores)
        HiloProveedores.Start()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Proveedor.P_Nombre = VentaBox.Text
        _Proveedor.P_Telefono = TextBox1.Text
        _Proveedor.P_Correo = TextBox3.Text
        _Proveedor.P_Direccion = TextBox4.Text
        _ProveedoresBol.InsertarProveedor(_Proveedor)
        If (_ProveedoresBol.Errores.Length = 0) Then
            LlenarDataGridViewProveedores()
            MsgBox("El proveedor fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ProveedoresBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub


    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        _Proveedor.P_Nombre = VentaBox.Text
        _Proveedor.P_Telefono = TextBox1.Text
        _Proveedor.P_Correo = TextBox3.Text
        _Proveedor.P_Direccion = TextBox4.Text
        _Proveedor.P_ID_Proveedor = IDTemp
        _ProveedoresBol.ActualizarProveedor(_Proveedor)
        If (_ProveedoresBol.Errores.Length = 0) Then
            LlenarDataGridViewProveedores()
            BunifuFlatButton2.Visible = False
            MsgBox("El proveedor fue actualizado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_ProveedoresBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub DataGridProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProveedores.CellContentClick
        If (e.ColumnIndex = 5) Then
            BunifuFlatButton2.Visible = True
            Me.Cursor = Cursors.WaitCursor
            IDTemp = DataGridProveedores.Rows(e.RowIndex).Cells(0).Value
            ListarProveedor(IDTemp)
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 6) Then
            Me.Cursor = Cursors.WaitCursor
            Try
                _ProveedoresBol.EliminarProveedor(DataGridProveedores.Rows(e.RowIndex).Cells(0).Value)
            Catch ex As Exception

            End Try

            If (_ProveedoresBol.Errores.Length = 0) Then
                LlenarDataGridViewProveedores()
                MsgBox("El proveedor fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
            Else
                MsgBox(_ProveedoresBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 13 Then
                e.Handled = True
            ElseIf (e.KeyChar = ChrW(Keys.Enter)) Then
                TextBox3.Select()
            End If
        End If
    End Sub

    Private Sub VentaBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VentaBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox4.Select()
        End If
    End Sub


#End Region

End Class