Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Empleado'
Public Class Dai_Empleado
    Dim Query As String

    'Verifica si un usuario (Empleado) existe dentro de la BD'
    Public Function VerificarUsuario(ByVal Empleado As E_Empleado)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT ID,NOMBRE,APELLIDO FROM EMPLEADO
                     WHERE USUARIO = @Usuario AND Contraseña = @Contraseña"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@Usuario", Empleado.Usuario_P)
                CMD.Parameters.AddWithValue("@Contraseña", Empleado.Contraseña_P)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    If (Lector.HasRows) Then
                        Lector.Read()
                        Empleado.ID_P = Lector("ID")
                        Empleado.Nombre_P = Lector("NOMBRE")
                        Empleado.Apellido_P = Lector("APELLIDO")
                        Return Empleado
                    Else
                        Return Nothing
                    End If
                End Using
            End Using
        End Using
    End Function

    'Lista todos los empleados existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaEmpleados As New List(Of E_Empleado)
            Query = "SELECT * FROM EMPLEADO;"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Empleado As New E_Empleado
                        _Empleado.ID_P = Lector("ID")
                        _Empleado.Nombre_P = Lector("Nombre")
                        _Empleado.Apellido_P = Lector("Apellido")
                        _Empleado.Cedula_P = Lector("Cedula")
                        _Empleado.Telefono_P = Lector("Telefono")
                        _Empleado.Usuario_P = Lector("Usuario")
                        If (Lector("Rol") = "A") Then
                            _Empleado.Rol_P = "Administrador"
                        Else
                            _Empleado.Rol_P = "Empleado"
                        End If
                        ListaEmpleados.Add(_Empleado)
                    End While
                    Return ListaEmpleados
                End Using
            End Using
        End Using
    End Function

    'Listar un empleado en concreto ' 
    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM EMPLEADO
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Lector.Read()
                    Dim _Empleado As New E_Empleado
                    _Empleado.ID_P = Lector("ID")
                    _Empleado.Nombre_P = Lector("Nombre")
                    _Empleado.Apellido_P = Lector("Apellido")
                    _Empleado.Cedula_P = Lector("Cedula")
                    _Empleado.Telefono_P = Lector("Telefono")
                    _Empleado.Usuario_P = Lector("Usuario")
                    If (Lector("Rol") = "A") Then
                        _Empleado.Rol_P = "Administrador"
                    Else
                        _Empleado.Rol_P = "Empleado"
                    End If
                    Return _Empleado
                End Using
            End Using
        End Using
    End Function

    'Inserta un empleado'
    Public Sub Insert(ByVal Empleado As E_Empleado)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO EMPLEADO 
                     VALUES(@NOMBRE,@APELLIDO,@CEDULA,@TELEFONO,@USUARIO,@CONTRASEÑA,@ROL)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Empleado.ID_P)
                CMD.Parameters.AddWithValue("@NOMBRE", Empleado.Nombre_P)
                CMD.Parameters.AddWithValue("@APELLIDO", Empleado.Apellido_P)
                CMD.Parameters.AddWithValue("@CEDULA", Empleado.Cedula_P)
                CMD.Parameters.AddWithValue("@TELEFONO", Empleado.Telefono_P)
                CMD.Parameters.AddWithValue("@USUARIO", Empleado.Usuario_P)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", Empleado.Contraseña_P)
                CMD.Parameters.AddWithValue("@ROL", Empleado.Rol_P)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Actualiza un Empleado'
    Public Sub Update(ByVal Empleado As E_Empleado)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE EMPLEADO
                     SET NOMBRE = @NOMBRE,APELLIDO = @APELLIDO,CEDULA = @CEDULA,TELEFONO = @TELEFONO,USUARIO = @USUARIO,CONTRASEÑA = @CONTRASEÑA,ROL = @ROL
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Empleado.ID_P)
                CMD.Parameters.AddWithValue("@NOMBRE", Empleado.Nombre_P)
                CMD.Parameters.AddWithValue("@APELLIDO", Empleado.Apellido_P)
                CMD.Parameters.AddWithValue("@CEDULA", Empleado.Cedula_P)
                CMD.Parameters.AddWithValue("@TELEFONO", Empleado.Telefono_P)
                CMD.Parameters.AddWithValue("@USUARIO", Empleado.Usuario_P)
                CMD.Parameters.AddWithValue("@CONTRASEÑA", Empleado.Contraseña_P)
                CMD.Parameters.AddWithValue("@ROL", Empleado.Rol_P)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Elimina un Empleado'
    Public Sub Delete(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM EMPLEADO
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Obtinene el ID del empleado - Estoy utilizando este para el arqueo'
    Public Function GetByName(ByVal Name As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT ID FROM EMPLEADO
                     WHERE usuario = @Nombre"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@Nombre", Name)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Lector.Read()
                    Dim _Empleado As New E_Empleado
                    _Empleado.ID_P = Lector("ID")


                    Return _Empleado
                End Using
            End Using
        End Using
    End Function




End Class
