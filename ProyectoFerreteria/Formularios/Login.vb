
Imports Ferreteria___LogicaNegocios
Imports Ferreteria___Entidades

Public Class Login

    Private _EmpleadoBoi As New Bol_Empleado()
    Private _Empleado As New E_Empleado()

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub bunifuMaterialTextbox1_MouseEnter(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox1.MouseEnter
        If bunifuMaterialTextbox1.Text = "Usuario" Then
            bunifuMaterialTextbox1.Text = ""
            bunifuMaterialTextbox1.Focus()
        End If
    End Sub

    Private Sub bunifuMaterialTextbox1_MouseLeave(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox1.MouseLeave
        If bunifuMaterialTextbox1.Text = "" Then
            bunifuMaterialTextbox1.Text = "Usuario"
        End If
    End Sub

    Private Sub bunifuMaterialTextbox2_MouseEnter(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox2.MouseEnter
        If bunifuMaterialTextbox2.Text = "Contraseña" Then
            bunifuMaterialTextbox2.Text = ""
            bunifuMaterialTextbox2.Focus()
        End If
    End Sub

    Private Sub bunifuMaterialTextbox2_MouseLeave(sender As Object, e As EventArgs) Handles bunifuMaterialTextbox2.MouseLeave
        If bunifuMaterialTextbox2.Text = "" Then
            bunifuMaterialTextbox2.Text = "Contraseña"
            bunifuMaterialTextbox2.isPassword = False
        Else
            bunifuMaterialTextbox2.isPassword = True
        End If
    End Sub

    Private Sub bunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles bunifuFlatButton1.Click

        inicio_sesion()

    End Sub


    Public Sub inicio_sesion()
        _Empleado.Usuario_P = bunifuMaterialTextbox1.Text
        _Empleado.Contraseña_P = bunifuMaterialTextbox2.Text
        Principal.EmpleadoActivo = _EmpleadoBoi.AutenticarUsuario(_Empleado)
        If (_EmpleadoBoi.Errores.Length = 0) Then
            Principal.UsuarioActivo = bunifuMaterialTextbox1.Text
            Principal.Show()
            Me.Hide()
        Else
            MsgBox(_EmpleadoBoi.Errores.ToString(), MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bunifuFlatButton1.Select()
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bunifuMaterialTextbox1.KeyPress
        If (e.KeyChar = (Convert.ToChar(Keys.Enter))) Then

            inicio_sesion()

        End If

    End Sub

    Private Sub bunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bunifuMaterialTextbox2.KeyPress
        If (e.KeyChar = (Convert.ToChar(Keys.Enter))) Then

            inicio_sesion()

        End If

    End Sub
End Class
