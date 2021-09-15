Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Proveedor'
Public Class Dai_GastoA

    Dim Query As String


    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaGastosA As New List(Of E_Gastos)
            Query = "SELECT * FROM GastosA"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Gastos As New E_Gastos
                        _Gastos.P_ID = Lector("ID")
                        _Gastos.P_ID_Empleado = Lector("ID_Empleado")
                        _Gastos.P_Fecha = Lector("Fecha")
                        _Gastos.P_Descripcion = Lector("Descripcion")
                        _Gastos.P_Cantidad = Lector("Cantidad")

                        ListaGastosA.Add(_Gastos)
                    End While
                    Return ListaGastosA
                End Using
            End Using
        End Using
    End Function


    Public Sub Insert(ByVal Gastos As E_Gastos)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO GastosA
                     VALUES(@ID_Empleado,@Fecha,@Descripcion,@Cantidad)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Empleado", Gastos.P_ID_Empleado)
                CMD.Parameters.AddWithValue("@Fecha", Gastos.P_Fecha)
                CMD.Parameters.AddWithValue("@Descripcion", Gastos.P_Descripcion)
                CMD.Parameters.AddWithValue("@Cantidad", Gastos.P_Cantidad)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Update(ByVal Gastos As E_Gastos)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE GastosA
                     SET ID_Empleado = @ID_Empleado, Fecha = @Fecha ,Descripcion = @Descripcion ,Cantidad = @Cantidad
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Gastos.P_ID)
                CMD.Parameters.AddWithValue("@ID_Empleado", Gastos.P_ID_Empleado)
                CMD.Parameters.AddWithValue("@Fecha", Gastos.P_Fecha)
                CMD.Parameters.AddWithValue("@Descripcion", Gastos.P_Descripcion)
                CMD.Parameters.AddWithValue("@Cantidad", Gastos.P_Cantidad)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM GastosA
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim _Gastos As New E_Gastos
                    Lector.Read()
                    _Gastos.P_ID = Lector("ID")
                    _Gastos.P_ID_Empleado = Lector("ID_Empleado")
                    _Gastos.P_Fecha = Lector("Fecha")
                    _Gastos.P_Descripcion = Lector("Descripcion")
                    _Gastos.P_Cantidad = Lector("Cantidad")
                    Return _Gastos
                End Using
            End Using
        End Using
    End Function

    Public Sub Delete(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM GastosA 
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function GetGasto(ByVal Dia As Date)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT SUM(Cantidad) 
                     FROM GastosA
                     WHERE FECHA = @FECHA;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@FECHA", Dia.Year.ToString() + "-" + Dia.Month.ToString() + "-" + Dia.Day.ToString())
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function
End Class
