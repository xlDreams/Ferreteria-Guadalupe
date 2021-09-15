Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Cliente'
Public Class Dai_Cliente
    Dim Query As String

    'Lista todos los clientes existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaClientes As New List(Of E_Cliente)
            Query = "SELECT * FROM CLIENTE;"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Cliente As New E_Cliente
                        _Cliente.ID_P = Lector("ID")
                        _Cliente.Nombre_P = Lector("Nombre")
                        _Cliente.Apellido_P = Lector("Apellido")
                        _Cliente.Cedula_P = Lector("Cedula")
                        _Cliente.Telefono_P = Lector("Telefono")
                        _Cliente.Direccion_P = Lector("Direccion")
                        ListaClientes.Add(_Cliente)
                    End While
                    Return ListaClientes
                End Using
            End Using
        End Using
    End Function

    Public Function Filtro(ByVal TipoFiltro As Integer, ByVal FiltroCadena As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim listaClientes As New List(Of E_Cliente)
            Query = "SELECT * FROM CLIENTE
                     WHERE"
            If (TipoFiltro = 0) Then
                Query = Query + " ID = @PA;"
            ElseIf (TipoFiltro = 1) Then
                Query = Query + " CEDULA = @PA"
            Else
                Query = Query + " TELEFONO =  @PA"
            End If
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@PA", FiltroCadena)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Cliente As New E_Cliente
                        _Cliente.ID_P = Lector("ID")
                        _Cliente.Nombre_P = Lector("Nombre")
                        _Cliente.Apellido_P = Lector("Apellido")
                        _Cliente.Cedula_P = Lector("Cedula")
                        _Cliente.Telefono_P = Lector("Telefono")
                        _Cliente.Direccion_P = Lector("Direccion")
                        ListaClientes.Add(_Cliente)
                    End While
                    Return ListaClientes
                End Using
            End Using
        End Using
    End Function



    'Listar un cliente en concreto ' 
    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM CLIENTE
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Lector.Read()
                    Dim _Cliente As New E_Cliente
                    _Cliente.ID_P = Lector("ID")
                    _Cliente.Nombre_P = Lector("Nombre")
                    _Cliente.Apellido_P = Lector("Apellido")
                    _Cliente.Cedula_P = Lector("Cedula")
                    _Cliente.Telefono_P = Lector("Telefono")
                    _Cliente.Direccion_P = Lector("Direccion")
                    Return _Cliente
                End Using
            End Using
        End Using
    End Function

    'Inserta un cliente'
    Public Sub Insert(ByVal Cliente As E_Cliente)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO CLIENTE 
                     VALUES(@NOMBRE,@APELLIDO,@CEDULA,@DIRECCION,@TELEFONO)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@NOMBRE", Cliente.Nombre_P)
                CMD.Parameters.AddWithValue("@APELLIDO", Cliente.Apellido_P)
                CMD.Parameters.AddWithValue("@CEDULA", Cliente.Cedula_P)
                CMD.Parameters.AddWithValue("@DIRECCION", Cliente.Direccion_P)
                CMD.Parameters.AddWithValue("@TELEFONO", Cliente.Telefono_P)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Actualiza un Cliente'
    Public Sub Update(ByVal Cliente As E_Cliente)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE CLIENTE
                     SET NOMBRE = @NOMBRE,APELLIDO = @APELLIDO,CEDULA = @CEDULA,TELEFONO = @TELEFONO,DIRECCION = @DIRECCION
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Cliente.ID_P)
                CMD.Parameters.AddWithValue("@NOMBRE", Cliente.Nombre_P)
                CMD.Parameters.AddWithValue("@APELLIDO", Cliente.Apellido_P)
                CMD.Parameters.AddWithValue("@CEDULA", Cliente.Cedula_P)
                CMD.Parameters.AddWithValue("@DIRECCION", Cliente.Direccion_P)
                CMD.Parameters.AddWithValue("@TELEFONO", Cliente.Telefono_P)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Elimina un cliente'
    Public Sub Delete(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM CLIENTE
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
