Imports System.Threading
Imports Ferreteria___Entidades
Imports Ferreteria___LogicaNegocios

Public Class Arqueo
    Dim CONTEO As Integer = 0
    Private _ArqueoBOL As New Bol_Arqueo()
    Private _GastosBOL As New Bol_Gastos
    Private _GastosE As New E_Gastos
    Private _ArqueE As New E_Arqueo
    Private _EmpleadoBol As New Bol_Empleado
    Private _Empleado As New E_Empleado
    Private _EstadisticasBol As New Bol_Estadistica()
    Dim SumaNumeric As Double
    Dim SumaGANACIA As Double
    Dim ID_Empl As Integer
    Dim FechaT As Date
    Dim Dolar As Double = 32.0
    Dim caja As Integer
    Dim VentaDelDia As Double
    Dim boleano As Boolean = True
    Dim IDTemp As Integer
    Dim Arqueodia As Integer
    Dim mensaje As Boolean = False




#Region "Boton insertar"

    'Oca si lees esto chupala :V
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Verificarnumeric()

        ComprobarArqueExistente(DateTimePicker1.Value)
        comprobarventa()
        If Arqueodia = 0 Then
            Dim redon As Decimal
            redon = Math.Round(SumaGANACIA)
            redon = SumaGANACIA - redon
            redon = Math.Abs(redon)
            If redon > 0.4 Then
                SumaGANACIA = Math.Round(SumaGANACIA) + 1
            ElseIf redon < 0.5 Then
                SumaGANACIA = Math.Round(SumaGANACIA)
            End If
            If SumaNumeric = SumaGANACIA Then
                Dim result As Integer = MessageBox.Show("Arqueo Completo ¿Desea GUARDAR el arqueo?", "Arqueo", MessageBoxButtons.YesNo)

                If result = DialogResult.No Then
                    MessageBox.Show("No se guardaron los cambios")
                ElseIf result = DialogResult.Yes Then
                    TextBox2.Text = SumaGANACIA
                    TextBox1.Text = 0

                    InsertarArqueo()
                    _ArqueoBOL.Insertar(_ArqueE)
                    MsgBox("Se guardaron los cambios", MsgBoxStyle.Information, "ARQUEO")
                    LlenarDataGridViewArqueo()

                End If

            ElseIf VentaDelDia = 0 Then
                MsgBox("No hay ventas", MsgBoxStyle.Exclamation, "VENTAS")

            Else
                If boleano = True Then
                    TextBox1.Text = ""



                    Dim RESL As Double = SumaNumeric - SumaGANACIA

                    If RESL < 0 Then
                        TextBox1.Text = Math.Abs(RESL)
                    Else
                        TextBox1.Text = RESL
                    End If



                    MsgBox("TIENE DIFERENCIAS DE " + TextBox1.Text.ToString, MsgBoxStyle.Critical, "ARQUEO")

                Else

                    boleano = True

                End If
            End If
        End If
    End Sub

#End Region



#Region "Metodos de apoyo :v "


    Public Sub ComprobarArqueExistente(fechaDia As Date)
        Try
            Arqueodia = _ArqueoBOL.ObtenerDato(fechaDia)
            If Arqueodia > 0 Then
                Arqueodia = 1
                MsgBox("Ya se realizo el arqueo si ingreso una nueva venta o gasto edite el arqueo del dia de hoy para actualizar", MsgBoxStyle.Information, "ARQUEO")
                mensaje = False
            Else
                Arqueodia = 0
                mensaje = True
            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub LlenarDataGridViewArqueo()
        DataGridArqueo.Rows.Clear()
        Dim ListaArqueo
        ListaArqueo = _ArqueoBOL.ObtenerArqueo()
        For I As Integer = 0 To ListaArqueo.Count() - 1
            DataGridArqueo.Rows.Add(ListaArqueo(I).P_ID, ListaArqueo(I).P_ID_EMPLEADO, ListaArqueo(I).P_Fecha, ListaArqueo(I).AB1000, ListaArqueo(I).AB500, ListaArqueo(I).AB200, ListaArqueo(I).AB100, ListaArqueo(I).AB50, ListaArqueo(I).AB20, ListaArqueo(I).AB10, ListaArqueo(I).AM5, ListaArqueo(I).AM1, ListaArqueo(I).AM050, ListaArqueo(I).AD50, ListaArqueo(I).AD20, ListaArqueo(I).AD10, ListaArqueo(I).AD5, ListaArqueo(I).AD1, ListaArqueo(I).P_Caja_Chica, ListaArqueo(I).P_Total, "Editar")
        Next
        Label32.Hide()
    End Sub

    Public Sub LlenarDataGridViewGastos()
        DataGridGastos.Rows.Clear()
        Dim ListaGastos
        ListaGastos = _GastosBOL.ObtenerGastos()
        For I As Integer = 0 To ListaGastos.Count() - 1
            DataGridGastos.Rows.Add(ListaGastos(I).P_ID, ListaGastos(I).P_ID_EMPLEADO, ListaGastos(I).P_Fecha, ListaGastos(I).P_Descripcion, ListaGastos(I).P_Cantidad, "Editar", "Eliminar")

        Next
        Label2.Hide()
    End Sub

    Public Sub ListarEmpleadoID(ByVal Nombre As String)
        Try
            Dim Empleado = _EmpleadoBol.ObtenerNameEmpleado(Nombre)
            Dim _EmpleadoID As Integer


            _EmpleadoID = Empleado.ID_P
            TextBox8.Text = Empleado.ID_P
        Catch ex As Exception
            MsgBox("hay un problema  al IDENTIFICAR el usuario", MsgBoxStyle.Critical, "ARQUEO")
        End Try

    End Sub

    Public Sub Verificarnumeric()

        SumaNumeric = 0
        '------------------------ Moneda -------------------------'
        If TextBox9.Text > 32.0 Then

            If NumericUpDown1.Value > 0 Then                                 'Moneda de  5
                SumaNumeric = 5 * NumericUpDown1.Value
            End If
            If NumericUpDown2.Value > 0 Then                             'Moneda de  1
                SumaNumeric = SumaNumeric + NumericUpDown2.Value
            End If
            If NumericUpDown3.Value > 0 Then                             'Moneda de  50 centavos
                SumaNumeric = SumaNumeric + (NumericUpDown3.Value * 0.5)
            End If
            '------------------------ Billete -------------------------'
            If NumericUpDown4.Value > 0 Then                             'Billete de 1000
                SumaNumeric = SumaNumeric + (NumericUpDown4.Value * 1000)
            End If

            If NumericUpDown5.Value > 0 Then                             'Billete de 500
                SumaNumeric = SumaNumeric + (NumericUpDown5.Value * 500)
            End If

            If NumericUpDown6.Value > 0 Then                             'Billete de 200
                SumaNumeric = SumaNumeric + (NumericUpDown6.Value * 200)
            End If

            If NumericUpDown7.Value > 0 Then                             'Billete de 100
                SumaNumeric = SumaNumeric + (NumericUpDown7.Value * 100)
            End If

            If NumericUpDown8.Value > 0 Then                             'Billete de 50
                SumaNumeric = SumaNumeric + (NumericUpDown8.Value * 50)
            End If

            If NumericUpDown9.Value > 0 Then                              'Billete de 20
                SumaNumeric = SumaNumeric + (NumericUpDown9.Value * 20)
            End If

            If NumericUpDown10.Value > 0 Then                              'Billete de 10
                SumaNumeric = SumaNumeric + (NumericUpDown10.Value * 10)
            End If
            '------------------------ Dolar -------------------------'
            If NumericUpDown11.Value > 0 Then                              'Billete de 50
                SumaNumeric = SumaNumeric + (Dolar * (50 * NumericUpDown11.Value))
            End If
            If NumericUpDown12.Value > 0 Then                              'Billete de 20
                SumaNumeric = SumaNumeric + (Dolar * (20 * NumericUpDown12.Value))
            End If
            If NumericUpDown13.Value > 0 Then                              'Billete de 10
                SumaNumeric = SumaNumeric + (Dolar * (10 * NumericUpDown13.Value))
            End If
            If NumericUpDown14.Value > 0 Then                              'Billete de 5
                SumaNumeric = SumaNumeric + (Dolar * (5 * NumericUpDown14.Value))
            End If
            If NumericUpDown15.Value > 0 Then                              'Billete de 1
                SumaNumeric = SumaNumeric + (Dolar * (1 * NumericUpDown15.Value))

            End If
        Else
            MsgBox("El valor del Dolar es menor a la cantidad valida", MsgBoxStyle.Information, "INFORMACION")
            boleano = False
        End If


    End Sub

    Public Sub InsertarArqueo()

        'Moneda de  5
        _ArqueE.AM5 = NumericUpDown1.Value

        'Moneda de  1
        _ArqueE.AM1 = NumericUpDown2.Value

        'Moneda de  50 centavos
        _ArqueE.AM050 = NumericUpDown3.Value

        '------------------------ Billete -------------------------'
        'Billete de 1000
        _ArqueE.AB1000 = NumericUpDown4.Value


        'Billete de 500
        _ArqueE.AB500 = NumericUpDown5.Value


        'Billete de 200
        _ArqueE.AB200 = NumericUpDown6.Value


        'Billete de 100
        _ArqueE.AB100 = NumericUpDown7.Value


        'Billete de 50
        _ArqueE.AB50 = NumericUpDown8.Value


        'Billete de 20
        _ArqueE.AB20 = NumericUpDown9.Value


        'Billete de 10
        _ArqueE.AB10 = NumericUpDown10.Value

        '------------------------ Dolar -------------------------'
        'Billete de 50
        _ArqueE.AD50 = NumericUpDown11.Value

        'Billete de 20
        _ArqueE.AD20 = NumericUpDown12.Value

        'Billete de 10
        _ArqueE.AD10 = NumericUpDown13.Value

        'Billete de 5
        _ArqueE.AD5 = NumericUpDown14.Value

        'Billete de 1
        _ArqueE.AD1 = NumericUpDown15.Value

        'Caja_Chica
        _ArqueE.P_Caja_Chica = TextBox4.Text

        'Total
        _ArqueE.P_Total = TextBox2.Text

        'ID_EMpleado
        _ArqueE.P_ID_EMPLEADO = TextBox8.Text
        'Fecha
        _ArqueE.P_Fecha = DateTimePicker1.Value


    End Sub

    Public Sub InsertarGasto()
        _GastosE.P_ID_Empleado = TextBox8.Text
        _GastosE.P_Fecha = DateTimePicker1.Value
        _GastosE.P_Descripcion = TextBox6.Text
        _GastosE.P_Cantidad = NumericUpDown16.Value
    End Sub

    Public Sub ActualizarArqueo()



        'Moneda de  5
        _ArqueE.AM5 = NumericUpDown1.Value

        'Moneda de  1
        _ArqueE.AM1 = NumericUpDown2.Value

        'Moneda de  50 centavos
        _ArqueE.AM050 = NumericUpDown3.Value

        '------------------------ Billete -------------------------'
        'Billete de 1000
        _ArqueE.AB1000 = NumericUpDown4.Value


        'Billete de 500
        _ArqueE.AB500 = NumericUpDown5.Value


        'Billete de 200
        _ArqueE.AB200 = NumericUpDown6.Value


        'Billete de 100
        _ArqueE.AB100 = NumericUpDown7.Value


        'Billete de 50
        _ArqueE.AB50 = NumericUpDown8.Value


        'Billete de 20
        _ArqueE.AB20 = NumericUpDown9.Value


        'Billete de 10
        _ArqueE.AB10 = NumericUpDown10.Value

        '------------------------ Dolar -------------------------'
        'Billete de 50
        _ArqueE.AD50 = NumericUpDown11.Value

        'Billete de 20
        _ArqueE.AD20 = NumericUpDown12.Value

        'Billete de 10
        _ArqueE.AD10 = NumericUpDown13.Value

        'Billete de 5
        _ArqueE.AD5 = NumericUpDown14.Value

        'Billete de 1
        _ArqueE.AD1 = NumericUpDown15.Value

        'Caja_Chica
        _ArqueE.P_Caja_Chica = TextBox4.Text

        'Total
        _ArqueE.P_Total = SumaNumeric

        'Conserva los mismos datos
        _ArqueE.P_ID_EMPLEADO = ID_Empl
        _ArqueE.P_Fecha = FechaT
        _ArqueE.P_ID = IDTemp


    End Sub

    Public Sub ActualizarGasto()
        _GastosE.P_ID = IDTemp
        _GastosE.P_ID_Empleado = ID_Empl
        _GastosE.P_Fecha = FechaT
        _GastosE.P_Descripcion = TextBox6.Text
        _GastosE.P_Cantidad = NumericUpDown16.Value
    End Sub

    Public Sub ListarArqueo(ByVal ID As Integer)

        Dim arqueo = _ArqueoBOL.ObtenerIDArqueo(ID)
        ID_Empl = arqueo.P_ID_EMPLEADO
        NumericUpDown1.Value = arqueo.AM5

        'Moneda de  1
        NumericUpDown2.Value = arqueo.AM1

        'Moneda de  50 centavos
        NumericUpDown3.Value = arqueo.AM050

        '------------------------ Billete -------------------------'
        'Billete de 1000
        NumericUpDown4.Value = arqueo.AB1000


        'Billete de 500
        NumericUpDown5.Value = arqueo.AB500


        'Billete de 200
        NumericUpDown6.Value = arqueo.AB200


        'Billete de 100
        NumericUpDown7.Value = arqueo.AB100


        'Billete de 50
        NumericUpDown8.Value = arqueo.AB50


        'Billete de 20
        NumericUpDown9.Value = arqueo.AB20


        'Billete de 10
        NumericUpDown10.Value = arqueo.AB10

        '------------------------ Dolar -------------------------'
        'Billete de 50
        NumericUpDown11.Value = arqueo.AD50

        'Billete de 20
        NumericUpDown12.Value = arqueo.AD20

        'Billete de 10
        NumericUpDown13.Value = arqueo.AD10

        'Billete de 5
        NumericUpDown14.Value = arqueo.AD5

        'Billete de 1
        NumericUpDown15.Value = arqueo.AD1

        'Caja_Chica
        TextBox4.Text = arqueo.P_Caja_Chica

        'Total
        TextBox2.Text = arqueo.P_Total

        'ID_EMpleado
        TextBox8.Text = arqueo.P_ID_EMPLEADO
        'Fecha

        FechaT = arqueo.P_Fecha
    End Sub

    Public Sub ListarGastos(ByVal ID As Integer)

        Dim Gasto = _GastosBOL.ObtenerIDGastos(ID)
        ID_Empl = Gasto.P_ID_EMPLEADO
        NumericUpDown16.Value = Gasto.P_Cantidad
        TextBox6.Text = Gasto.P_Descripcion
        FechaT = Gasto.P_Fecha
    End Sub

    Public Sub comprobarventa()


        Try
            VentaDelDia = _EstadisticasBol.ObtenerEstadistica(5, DateTimePicker1.Value)
            SumaGANACIA = caja + VentaDelDia
            Try
                Dim X As Double = _GastosBOL.ObtenerDato(DateTimePicker1.Value)
                If X > 0 Then
                    If MENSAJE = True Then
                        MsgBox("Tenga en cuenta que hay Gastos autorizados para el dia de HOY", MsgBoxStyle.Information, "ARQUEO")
                    End If

                    If caja > X Then
                            SumaGANACIA = VentaDelDia + (caja - X)
                        Else
                            SumaGANACIA = (VentaDelDia + caja) - X
                        End If


                    End If
            Catch ex As Exception

            End Try



            Math.Abs(SumaGANACIA)
        Catch ex As Exception
            MsgBox("Para Arquear tiene que haber alguna venta en el dia", MsgBoxStyle.Information, "ARQUEO")
            VentaDelDia = 0

            TextBox1.Text = ""

        End Try

    End Sub


#End Region







    Private Sub Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        Try
INICIO:
            caja = InputBox("Saldo Inicial(Caja Chica)", "SALDO")

            If caja < 1000 Then
                MsgBox("CAJA DEBE SER MAYOR A 1000", MsgBoxStyle.Information, "CAJA")
                GoTo INICIO
            Else
                TextBox4.Text = caja
            End If
        Catch ex As Exception
            MsgBox("Debe ingresar solo numeros", MsgBoxStyle.Exclamation, "CAJA")
            GoTo INICIO
        End Try


        TextBox7.Text = Principal.UsuarioActivo.ToUpper
        ListarEmpleadoID(Principal.UsuarioActivo)


        comprobarventa()

        Dim HiloArqueo As New Thread(AddressOf LlenarDataGridViewArqueo)
        Dim HiloGastos As New Thread(AddressOf LlenarDataGridViewGastos)
        HiloArqueo.Start()
        HiloGastos.Start()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim VentaSeleccionada As Double
        VentaSeleccionada = _EstadisticasBol.ObtenerEstadistica(5, FechaT).ToString()
        boleano = True

        Verificarnumeric()
        comprobarventa()
        Dim redon As Decimal
        redon = Math.Round(SumaGANACIA)
        redon = SumaGANACIA - redon
        redon = Math.Abs(redon)
        If redon > 0.5 Then
            SumaGANACIA = Math.Round(SumaGANACIA) + 1
        ElseIf redon < 0.5 Then
            SumaGANACIA = Math.Round(SumaGANACIA)
        End If
        If SumaNumeric = SumaGANACIA Then
            Dim resulta As Integer = MessageBox.Show("Arqueo Completo ¿Desea ACTUALIZAR el arqueo?", "Arqueo", MessageBoxButtons.YesNo)

            If resulta = DialogResult.No Then
                MessageBox.Show("No se guardaron los cambios")

            ElseIf resulta = DialogResult.Yes Then


                ActualizarArqueo()
                _ArqueoBOL.ActualizarArqueo(_ArqueE)
                comprobarventa()
                TextBox1.Text = 0
                TextBox2.Text = ""
                MsgBox("Se actualizaron los DATOS", MsgBoxStyle.Information, "ARQUEO")
                LlenarDataGridViewArqueo()
                boleano = False
                If (_ArqueoBOL.Errores.Length = 0) Then
                    LlenarDataGridViewArqueo()
                    BunifuFlatButton3.Visible = False

                Else
                    MsgBox("Ocurrio un error", MsgBoxStyle.Information, "Informacion")
                    MsgBox(_ArqueoBOL.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If

            End If



        Else
            If boleano = True Then
                TextBox1.Text = ""
                Dim RESL As Double = SumaNumeric - SumaGANACIA

                If RESL < 0 Then
                    TextBox1.Text = Math.Abs(RESL)
                Else
                    TextBox1.Text = RESL
                End If
                MsgBox("TIENE DIFERENCIAS DE " + TextBox1.Text, MsgBoxStyle.Critical, "ARQUEO")
                SumaNumeric = 0

            End If



        End If
    End Sub

    Private Sub DataGridArqueo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridArqueo.CellContentClick

        If (e.ColumnIndex = 20) Then
            BunifuFlatButton3.Visible = True
            Me.Cursor = Cursors.WaitCursor
            IDTemp = DataGridArqueo.Rows(e.RowIndex).Cells(0).Value
            ListarArqueo(IDTemp)
            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub DataGridaGastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridGastos.CellContentClick

        If (e.ColumnIndex = 5) Then

            Me.Cursor = Cursors.WaitCursor
            IDTemp = DataGridGastos.Rows(e.RowIndex).Cells(0).Value
            ListarGastos(IDTemp)
            BunifuFlatButton4.Visible = True
            Me.Cursor = Cursors.Default
        ElseIf (e.ColumnIndex = 6) Then
            Dim resulta As Integer = MessageBox.Show("¿Esta seguro que desea eliminar?", "Gasto", MessageBoxButtons.YesNo)

            If resulta = DialogResult.No Then
                MessageBox.Show("No se elimino el gasto")

            ElseIf resulta = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                _GastosBOL.EliminarGasto(DataGridGastos.Rows(e.RowIndex).Cells(0).Value)
                If (_GastosBOL.Errores.Length = 0) Then
                    LlenarDataGridViewGastos()
                    MsgBox("El Gasto fue eliminado exitosamente", MsgBoxStyle.OkOnly, "Exito")
                Else
                    MsgBox(_GastosBOL.Errores.ToString(), MsgBoxStyle.Critical, "Error")
                End If
                Me.Cursor = Cursors.Default

            End If
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        If NumericUpDown16.Value > 0 Then
            Dim descripciontext As String = TextBox6.Text

            Dim longitud As Integer = Len(descripciontext)
            If longitud > 10 Then
                InsertarGasto()
                _GastosBOL.InsertarGastos(_GastosE)
                LlenarDataGridViewGastos()
            Else
                MsgBox("Es de utilidad escribir una descripcion para no tener problemas en el futuro", MsgBoxStyle.Critical, "Informacion")
            End If
        Else
            MsgBox("El gasto debe ser mayor a 0", MsgBoxStyle.Critical, "Informacion")
            NumericUpDown16.Focus()
        End If


    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If NumericUpDown16.Value > 0 Then
            Dim descripciontext As String = TextBox6.Text
            ' Returns 11.
            Dim longitud As Integer = Len(descripciontext)
            If longitud > 10 Then
                ActualizarGasto()
                _GastosBOL.ActualizarGasto(_GastosE)
                LlenarDataGridViewGastos()
                MsgBox("Se actualizo el Gasto", MsgBoxStyle.Information, "Informacion")
            Else

                MsgBox("La descripcion debe ser superior o igual a 10 caracteres", MsgBoxStyle.Critical, "Informacion")
            End If
        Else
            MsgBox("El gasto debe ser mayor a 0", MsgBoxStyle.Critical, "Informacion")
            NumericUpDown16.Focus()
        End If
    End Sub
End Class