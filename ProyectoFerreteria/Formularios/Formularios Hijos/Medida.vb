Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Medida

    'Instancias ulitilizadas'
    Private _UnidadesMedidasBol As New Bol_UnidadMedida()
    Private _Medida As New E_UnidadMedida()
    Private _IDTemp As New Integer
    Dim _funcion As New Func
#Region "Metodos de apoyo"
    'Llenar DatagridView de medidas
    Public Sub LlenarDataGridViewMedidas()
        DataGridUnidades.Rows.Clear()
        Dim ListaMedidas
        ListaMedidas = _UnidadesMedidasBol.ObtenerUnidadesDeMedidas()
        For I As Integer = 0 To ListaMedidas.Count() - 1
            DataGridUnidades.Rows.Add(ListaMedidas(I).P_ID_UnidadMedida, ListaMedidas(I).P_Nombre, "Editar", "Eliminar")
        Next
        Label17.Hide()
    End Sub
    'Lista una unidad solamente y pone sus datos en el textbox'
    Public Sub ListarUnidaDeMedida(ByVal ID As Integer)
        Dim UnidadMedida As E_UnidadMedida
        UnidadMedida = _UnidadesMedidasBol.ObtenerUnidadDeMedida(ID)
        UnidadBox.Text = UnidadMedida.P_Nombre
    End Sub
#End Region

    'Boton para insertar producto'
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        _Medida.P_Nombre = UnidadBox.Text
        _UnidadesMedidasBol.InsertarUnidadMedida(_Medida)
        If (_UnidadesMedidasBol.Errores.Length = 0) Then
            LlenarDataGridViewMedidas()
            MsgBox("La unidad de medida fue añadida exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_UnidadesMedidasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'Boton para actualizar producto'
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        _Medida.P_Nombre = UnidadBox.Text
        _Medida.P_ID_UnidadMedida = _IDTemp
        _UnidadesMedidasBol.ActualizarUnidadMedida(_Medida)
        LlenarDataGridViewMedidas()
        If (_UnidadesMedidasBol.Errores.Length = 0) Then
            BunifuFlatButton2.Hide()
            MsgBox("La unidad de medida fue actualizada exitosamente", MsgBoxStyle.OkOnly, "Exito")
        Else
            MsgBox(_UnidadesMedidasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub DataGridUnidades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUnidades.CellContentClick
        If (e.ColumnIndex = 2) Then
            BunifuFlatButton2.Visible = True
            Me.Cursor = Cursors.WaitCursor
            ListarUnidaDeMedida(DataGridUnidades.Rows(e.RowIndex).Cells(0).Value)
            _IDTemp = DataGridUnidades.Rows(e.RowIndex).Cells(0).Value
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 3) Then

            Dim resulta As Integer = MessageBox.Show("¿Esta seguro que desea eliminar?", "MEDIDA", MessageBoxButtons.YesNo)
            If resulta = DialogResult.No Then

                MsgBox("No se elimino la medida", MsgBoxStyle.Information, "INFORMACION")
            ElseIf resulta = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor
                Try
                    _UnidadesMedidasBol.EliminarUnidadMedida(DataGridUnidades.Rows(e.RowIndex).Cells(0).Value)
                Catch ex As Exception

                End Try

                If (_UnidadesMedidasBol.Errores.Length = 0) Then
                    LlenarDataGridViewMedidas()
                    MsgBox("La unidad de medida fue eliminada exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Else
                    MsgBox(_UnidadesMedidasBol.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If
                Me.Cursor = Cursors.Default

            End If


        End If
    End Sub


    Private Sub Medida_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        _funcion.ALTERNARColorDataGrid(DataGridUnidades)
        Dim HiloMedidas As New Thread(AddressOf LlenarDataGridViewMedidas)
        HiloMedidas.Start()
    End Sub

End Class