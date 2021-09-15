Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Crud de la entidad arqueo'

Public Class Dai_Arqueo
    Dim Query As String
    'Inserta las cantidades a la tabla arqueo en la BD'
    Public Sub Insert(ByVal Arqueo As E_Arqueo)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO Arqueo 
                     VALUES(@ID_Empleado,@Fecha,@B1000,@B500,@B200,@B100,@B50,@B20,@B10,@M5,@M1,@M050,@D50,@D20,@D10,@D5,@D1,@Caja_Chica,@Total)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Empleado", Arqueo.P_ID_EMPLEADO)
                CMD.Parameters.AddWithValue("@Fecha", Arqueo.P_Fecha)
                CMD.Parameters.AddWithValue("@B1000", Arqueo.AB1000)
                CMD.Parameters.AddWithValue("@B500", Arqueo.AB500)
                CMD.Parameters.AddWithValue("@B200", Arqueo.AB200)
                CMD.Parameters.AddWithValue("@B100", Arqueo.AB100)
                CMD.Parameters.AddWithValue("@B50", Arqueo.AB50)
                CMD.Parameters.AddWithValue("@B20", Arqueo.AB20)
                CMD.Parameters.AddWithValue("@B10", Arqueo.AB10)
                CMD.Parameters.AddWithValue("@M5 ", Arqueo.AM5)
                CMD.Parameters.AddWithValue("@M1 ", Arqueo.AM1)
                CMD.Parameters.AddWithValue("@M050", Arqueo.AM050)
                CMD.Parameters.AddWithValue("@D50", Arqueo.AD50)
                CMD.Parameters.AddWithValue("@D20", Arqueo.AD20)
                CMD.Parameters.AddWithValue("@D10", Arqueo.AD10)
                CMD.Parameters.AddWithValue("@D5", Arqueo.AD5)
                CMD.Parameters.AddWithValue("@D1", Arqueo.AD1)
                CMD.Parameters.AddWithValue("@Caja_Chica", Arqueo.P_Caja_Chica)
                CMD.Parameters.AddWithValue("@Total", Arqueo.P_Total)

                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub



    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaArqueo As New List(Of E_Arqueo)
            Query = "SELECT * FROM Arqueo"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Arqueo As New E_Arqueo
                        _Arqueo.P_ID = Lector("ID")
                        _Arqueo.P_ID_EMPLEADO = Lector("ID_Empleado")
                        _Arqueo.P_Fecha = Lector("Fecha")
                        _Arqueo.AB1000 = Lector("B1000")
                        _Arqueo.AB500 = Lector("B500")
                        _Arqueo.AB200 = Lector("B200")
                        _Arqueo.AB100 = Lector("B100")
                        _Arqueo.AB50 = Lector("B50")
                        _Arqueo.AB20 = Lector("B20")
                        _Arqueo.AB10 = Lector("B10")
                        _Arqueo.AM5 = Lector("M5")
                        _Arqueo.AM1 = Lector("M1")
                        _Arqueo.AM050 = Lector("M050")
                        _Arqueo.AD50 = Lector("D50")
                        _Arqueo.AD20 = Lector("D20")
                        _Arqueo.AD10 = Lector("D10")
                        _Arqueo.AD5 = Lector("D5")
                        _Arqueo.AD1 = Lector("D1")
                        _Arqueo.P_Caja_Chica = Lector("Caja_Chica")
                        _Arqueo.P_Total = Lector("Total")

                        ListaArqueo.Add(_Arqueo)
                    End While
                    Return ListaArqueo
                End Using
            End Using
        End Using
    End Function
    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM Arqueo
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim _Arqueo As New E_Arqueo
                    Lector.Read()
                    _Arqueo.P_ID = Lector("ID")
                    _Arqueo.P_ID_EMPLEADO = Lector("ID_Empleado")
                    _Arqueo.P_Fecha = Lector("Fecha")
                    _Arqueo.AB1000 = Lector("B1000")
                    _Arqueo.AB500 = Lector("B500")
                    _Arqueo.AB200 = Lector("B200")
                    _Arqueo.AB100 = Lector("B100")
                    _Arqueo.AB50 = Lector("B50")
                    _Arqueo.AB20 = Lector("B20")
                    _Arqueo.AB10 = Lector("B10")
                    _Arqueo.AM5 = Lector("M5")
                    _Arqueo.AM1 = Lector("M1")
                    _Arqueo.AM050 = Lector("M050")
                    _Arqueo.AD50 = Lector("D50")
                    _Arqueo.AD20 = Lector("D20")
                    _Arqueo.AD10 = Lector("D10")
                    _Arqueo.AD5 = Lector("D5")
                    _Arqueo.AD1 = Lector("D1")
                    _Arqueo.P_Caja_Chica = Lector("Caja_Chica")
                    _Arqueo.P_Total = Lector("Total")
                    Return _Arqueo
                End Using
            End Using
        End Using
    End Function
    Public Sub Update(ByVal Arqueo As E_Arqueo)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE Arqueo
                     SET ID_Empleado=@ID_Empleado,
                     Fecha=@Fecha,
                     B1000=@B1000,
                     B500=@B500,
                     B200=@B200,
                     B100=@B100,
                     B50=@B50,
                     B20=@B20,
                     B10=@B10,
                     M5=@M5,
                     M1=@M1,
                     M050=@M050,
                     D50=@D50,
                     D20=@D20,
                     D10=@D10,
                     D5=@D5,
                     D1=@D1,
                     Caja_Chica=@Caja_Chica,
                     Total=@Total
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Arqueo.P_ID)
                CMD.Parameters.AddWithValue("@ID_Empleado", Arqueo.P_ID_EMPLEADO)
                CMD.Parameters.AddWithValue("@Fecha", Arqueo.P_Fecha)
                CMD.Parameters.AddWithValue("@B1000", Arqueo.AB1000)
                CMD.Parameters.AddWithValue("@B500", Arqueo.AB500)
                CMD.Parameters.AddWithValue("@B200", Arqueo.AB200)
                CMD.Parameters.AddWithValue("@B100", Arqueo.AB100)
                CMD.Parameters.AddWithValue("@B50", Arqueo.AB50)
                CMD.Parameters.AddWithValue("@B20", Arqueo.AB20)
                CMD.Parameters.AddWithValue("@B10", Arqueo.AB10)
                CMD.Parameters.AddWithValue("@M5 ", Arqueo.AM5)
                CMD.Parameters.AddWithValue("@M1 ", Arqueo.AM1)
                CMD.Parameters.AddWithValue("@M050", Arqueo.AM050)
                CMD.Parameters.AddWithValue("@D50", Arqueo.AD50)
                CMD.Parameters.AddWithValue("@D20", Arqueo.AD20)
                CMD.Parameters.AddWithValue("@D10", Arqueo.AD10)
                CMD.Parameters.AddWithValue("@D5", Arqueo.AD5)
                CMD.Parameters.AddWithValue("@D1", Arqueo.AD1)
                CMD.Parameters.AddWithValue("@Caja_Chica", Arqueo.P_Caja_Chica)
                CMD.Parameters.AddWithValue("@Total", Arqueo.P_Total)

                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetRes(ByVal Dia As Date)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT count(*) 
                     FROM Arqueo
                     WHERE FECHA = @Fecha;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@Fecha", Dia.Year.ToString() + "-" + Dia.Month.ToString() + "-" + Dia.Day.ToString())
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function




End Class
