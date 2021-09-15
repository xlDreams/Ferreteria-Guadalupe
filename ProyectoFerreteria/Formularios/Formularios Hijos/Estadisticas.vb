Imports System.Threading
Imports Ferreteria___LogicaNegocios

Public Class Estadisticas

#Region "Metodos de apoyo"

    Private _EstadisticasBol As New Bol_Estadistica()
    Public Sub EstablecerEstadisticas()

        Label7.Text = _EstadisticasBol.ObtenerEstadistica(1, Nothing)
        Label8.Text = _EstadisticasBol.ObtenerEstadistica(2, Nothing)
        Label9.Text = _EstadisticasBol.ObtenerEstadistica(3, Nothing)
        Label10.Text = _EstadisticasBol.ObtenerEstadistica(4, Nothing)

        Label19.Text = _EstadisticasBol.ObtenerEstadistica(5, DateTimePicker1.Value).ToString() + " C$" 'este voy ocupar :v
        Label17.Text = _EstadisticasBol.ObtenerEstadistica(6, DateTimePicker2.Value).ToString() + " C$"
        Label12.Text = ""
        Label12.Text = _EstadisticasBol.ObtenerEstadistica(7, DateTimePicker2.Value).ToString() + " C$"
        Me.Cursor = Cursors.Default
        If (Not _EstadisticasBol.Errores.Length = 0) Then
            MsgBox(_EstadisticasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Eventos"
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker2.CustomFormat = "MM/yyyy"
        DateTimePicker3.CustomFormat = "yyyy"
        CheckForIllegalCrossThreadCalls = False
        Me.Cursor = Cursors.WaitCursor
        Dim HiloEstadisticas As New Thread(AddressOf EstablecerEstadisticas)
        HiloEstadisticas.Start()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.Cursor = Cursors.WaitCursor
        Dim HiloEstadisticas As New Thread(AddressOf EstablecerEstadisticas)
        HiloEstadisticas.Start()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.Cursor = Cursors.WaitCursor
        Dim HiloEstadisticas As New Thread(AddressOf EstablecerEstadisticas)
        HiloEstadisticas.Start()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Me.Cursor = Cursors.WaitCursor
        Dim HiloEstadisticas As New Thread(AddressOf EstablecerEstadisticas)
        HiloEstadisticas.Start()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Cursor = Cursors.WaitCursor
        Dim HiloEstadisticas As New Thread(AddressOf EstablecerEstadisticas)
        HiloEstadisticas.Start()
    End Sub

#End Region


End Class