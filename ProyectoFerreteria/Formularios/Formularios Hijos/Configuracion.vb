Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Configuracion

    Dim _EmpleadosBol As New Bol_Empleado()
    Dim _Empleado As New E_Empleado()
    Dim IDAux As Integer
    Dim _funcion As New Func

#Region "Metodos de apoyo"
    Public Sub LlenarDataGridViewUsuarios()
        DataGridView1.Rows.Clear()
        Dim ListaCuentas
        ListaCuentas = _EmpleadosBol.ObtenerEmpleados()
        For I As Integer = 0 To ListaCuentas.Count() - 1
            DataGridView1.Rows.Add(ListaCuentas(I).ID_P, ListaCuentas(I).Nombre_P, ListaCuentas(I).Apellido_P, ListaCuentas(I).Cedula_P, ListaCuentas(I).Telefono_P, ListaCuentas(I).Usuario_P, ListaCuentas(I).Rol_P, "Editar", "Eliminar")
        Next
        Label17.Hide()
    End Sub

    Public Sub ListarEmpleado(ByVal ID As Integer)
        Dim Empleado = _EmpleadosBol.ObtenerEmpleado(ID)
        VentaBox.Text = Empleado.Nombre_P
        TextBox1.Text = Empleado.Apellido_P
        TextBox2.Text = Empleado.Telefono_P
        TextBox6.Text = Empleado.Cedula_P
        ComboBox1.SelectedItem = Empleado.Rol_P
        TextBox3.Text = Empleado.Usuario_P
    End Sub


#End Region

#Region "Eventos"

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        _Empleado.Nombre_P = VentaBox.Text
        _Empleado.Apellido_P = TextBox1.Text
        _Empleado.Telefono_P = TextBox2.Text
        _Empleado.Cedula_P = TextBox6.Text
        _Empleado.Rol_P = ComboBox1.SelectedItem.ToString.Chars(0)
        _Empleado.Usuario_P = TextBox3.Text
        _Empleado.Contraseña_P = TextBox4.Text
        _Empleado.ID_P = IDAux
        _EmpleadosBol.ActualizarEmpleado(_Empleado)
        If (_EmpleadosBol.Errores.Length = 0) Then
            LlenarDataGridViewUsuarios()
            MsgBox("El empleado fue actualizado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_EmpleadosBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Empleado.Nombre_P = VentaBox.Text
        _Empleado.Apellido_P = TextBox1.Text
        _Empleado.Telefono_P = TextBox2.Text
        _Empleado.Cedula_P = TextBox6.Text
        _Empleado.Rol_P = ComboBox1.SelectedItem.ToString.Chars(0)
        _Empleado.Usuario_P = TextBox3.Text
        _Empleado.Contraseña_P = TextBox4.Text
        _EmpleadosBol.InsertarEmpleado(_Empleado)
        If (_EmpleadosBol.Errores.Length = 0) Then
            LlenarDataGridViewUsuarios()
            MsgBox("El empleado fue ingresado exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_EmpleadosBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If (e.ColumnIndex = 7) Then
            BunifuFlatButton2.Visible = True
            Me.Cursor = Cursors.WaitCursor
            ListarEmpleado(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            IDAux = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 8) Then

            Dim resulta As Integer = MessageBox.Show("¿Esta seguro que desea eliminar?", "USUARIO", MessageBoxButtons.YesNo)
            If resulta = DialogResult.No Then

                MsgBox("No se elimino el Empleado", MsgBoxStyle.Information, "INFORMACION")

            ElseIf resulta = DialogResult.Yes Then


                Me.Cursor = Cursors.WaitCursor
                _EmpleadosBol.EliminarEmpleado(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                If (_EmpleadosBol.Errores.Length = 0) Then
                    LlenarDataGridViewUsuarios()
                    MsgBox("El empleado fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Else
                    MsgBox(_EmpleadosBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If
                Me.Cursor = Cursors.Default

            End If

        End If
    End Sub

    Private Sub VentaBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VentaBox.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox6.Select()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            TextBox4.Select()
        End If
    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _funcion.ALTERNARColorDataGrid(DataGridView1)
        CheckForIllegalCrossThreadCalls = False
        Dim HiloEmpleados As New Thread(AddressOf LlenarDataGridViewUsuarios)
        HiloEmpleados.Start()
        ComboBox1.SelectedItem = "Administrador"
    End Sub


#End Region
End Class