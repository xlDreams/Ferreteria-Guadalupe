Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad UnidadesDeMedida'
Public Class Dai_UnidadMedida
    Dim Query As String

    'Lista todas las unidades de medidas existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaUnidades As New List(Of E_UnidadMedida)
            Query = "SELECT * FROM UNIDAD_DE_MEDIDA"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Unidad As New E_UnidadMedida
                        _Unidad.P_ID_UnidadMedida = Lector("ID_Unidad_De_Medida")
                        _Unidad.P_Nombre = Lector("Nombre")
                        ListaUnidades.Add(_Unidad)
                    End While
                    Return ListaUnidades
                End Using
            End Using
        End Using
    End Function

    'Listar una unidad de medida en concreto ' 
    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM UNIDAD_DE_MEDIDA
                     WHERE ID_UNIDAD_DE_MEDIDA = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim _Unidad As New E_UnidadMedida
                    Lector.Read()
                    _Unidad.P_ID_UnidadMedida = Lector("ID_Unidad_De_Medida")
                    _Unidad.P_Nombre = Lector("Nombre")
                    Return _Unidad
                End Using
            End Using
        End Using
    End Function

    'Inserta una unidad de medida'
    Public Sub Insert(ByVal UnidadDeMedida As E_UnidadMedida)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO UNIDAD_DE_MEDIDA 
                     VALUES(@NOMBRE)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@NOMBRE", UnidadDeMedida.P_Nombre)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Actualzia una unidad de medida'
    Public Sub Update(ByVal UnidadDeMedida As E_UnidadMedida)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE UNIDAD_DE_MEDIDA 
                     SET NOMBRE = @NOMBRE
                     WHERE ID_UNIDAD_DE_MEDIDA = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@NOMBRE", UnidadDeMedida.P_Nombre)
                CMD.Parameters.AddWithValue("@ID", UnidadDeMedida.P_ID_UnidadMedida)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Elimina una unidad de medida'
    Public Sub Delete(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM UNIDAD_DE_MEDIDA 
                     WHERE ID_UNIDAD_DE_MEDIDA = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
