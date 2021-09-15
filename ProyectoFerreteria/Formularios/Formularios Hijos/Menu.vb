Public Class Menu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        GroupBox1.BackColor = Color.Gainsboro
    End Sub

    Private Sub GroupBox1_MouseLeave(sender As Object, e As EventArgs) Handles GroupBox1.MouseLeave
        GroupBox1.BackColor = Color.White
    End Sub
End Class