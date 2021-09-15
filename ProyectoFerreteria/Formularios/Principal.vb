Imports Ferreteria___Entidades

Public Class Principal

    Public Shared UsuarioActivo As String
    Dim Nombrea As String
    Private Inventario As New Inventario()
    Private UnidadMedida As New Medida()
    Private Provedor As New Proveedores()
    Private Configuracion As New Configuracion()
    Private Estadistica As New Estadisticas()
    Private Venta As New Ventas()
    Private Cliente As New Cliente()
    Private FacturaVista As New Factura_Vista()
    Private FacturaCompra As New Factura_Compra()


    Public Shared EmpleadoActivo As New E_Empleado


    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Image = System.Drawing.Bitmap.FromFile("IconoLogin.PNG")
        PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play1.PNG")
        Nombrea = UsuarioActivo
        Nombre.Text = Nombrea.ToUpper()
        Abrirform(New Menu)
    End Sub



    Private Sub Abrirform(ByVal formhijo As Object)
        If (Me.PanelContenedor.Controls.Count > 0) Then
            Me.PanelContenedor.Controls.RemoveAt(0)
            Dim fh As Form = TryCast(formhijo, Form)
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelSecundario.Width = 50 Then
            AnimacionPanelSecundario.ShowSync(PanelSecundario)
            PictureBox1.Visible = False
            AnimacionFlecha.ShowSync(PictureBox1)
            PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play2.PNG")
            PanelSecundario.Width = 170
        ElseIf PanelSecundario.Width = 170 Then
            AnimacionPanelSecundario.ShowSync(PanelSecundario)
            PictureBox1.Visible = False
            AnimacionFlecha.ShowSync(PictureBox1)
            PictureBox1.Image = System.Drawing.Bitmap.FromFile("Play1.PNG")
            PanelSecundario.Width = 50
        End If
        PictureBox1.Width = 18
        PictureBox1.Height = 18
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Abrirform(New Menu())
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Abrirform(Inventario)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Abrirform(Provedor)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Abrirform(Ventas)
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        Abrirform(UnidadMedida)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Abrirform(New Arqueo)
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Abrirform(Factura_Compra)
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        Abrirform(Factura_Vista)
    End Sub

    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        Abrirform(Cliente)
    End Sub

    Private Sub BunifuFlatButton10_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton10.Click
        Abrirform(Estadistica)
    End Sub

    Private Sub BunifuFlatButton11_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton11.Click
        Abrirform(Configuracion)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) 

    End Sub
End Class