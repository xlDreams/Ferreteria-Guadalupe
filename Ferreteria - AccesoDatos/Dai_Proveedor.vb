Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Proveedor'
Public Class Dai_Proveedor

    Dim Query As String

    'Lista todos los proveedores existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaProveedores As New List(Of E_Proveedor)
            Query = "SELECT * FROM PROVEEDOR"
            Using CMD As New SqlCommand(Query, Conn)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Proveedor As New E_Proveedor
                        _Proveedor.P_ID_Proveedor = Lector("ID")
                        _Proveedor.P_Nombre = Lector("Nombre")
                        _Proveedor.P_Telefono = Lector("Telefono")
                        _Proveedor.P_Correo = Lector("Correo")
                        _Proveedor.P_Direccion = Lector("Direccion")
                        ListaProveedores.Add(_Proveedor)
                    End While
                    Return ListaProveedores
                End Using
            End Using
        End Using
    End Function

    'Listar un proveedor en concreto ' 
    Public Function GetByID(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM PROVEEDOR
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim _Proveedor As New E_Proveedor
                    Lector.Read()
                    _Proveedor.P_ID_Proveedor = Lector("ID")
                    _Proveedor.P_Nombre = Lector("Nombre")
                    _Proveedor.P_Telefono = Lector("Telefono")
                    _Proveedor.P_Correo = Lector("Correo")
                    _Proveedor.P_Direccion = Lector("Direccion")
                    Return _Proveedor
                End Using
            End Using
        End Using
    End Function

    'Inserta un proveedor'
    Public Sub Insert(ByVal Proveedor As E_Proveedor)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO PROVEEDOR 
                     VALUES(@NOMBRE,@TELEFONO,@CORREO,@DIRECCION)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@NOMBRE", Proveedor.P_Nombre)
                CMD.Parameters.AddWithValue("@TELEFONO", Proveedor.P_Telefono)
                CMD.Parameters.AddWithValue("@CORREO", Proveedor.P_Correo)
                CMD.Parameters.AddWithValue("@DIRECCION", Proveedor.P_Direccion)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Actualiza un Proveedor'
    Public Sub Update(ByVal Proveedor As E_Proveedor)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE PROVEEDOR
                     SET NOMBRE = @NOMBRE, TELEFONO = @TELEFONO,CORREO = @CORREO,Direccion = @DIRECCION
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", Proveedor.P_ID_Proveedor)
                CMD.Parameters.AddWithValue("@NOMBRE", Proveedor.P_Nombre)
                CMD.Parameters.AddWithValue("@TELEFONO", Proveedor.P_Telefono)
                CMD.Parameters.AddWithValue("@CORREO", Proveedor.P_Correo)
                CMD.Parameters.AddWithValue("@DIRECCION", Proveedor.P_Direccion)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Elimina un proveedor'
    Public Sub Delete(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM PROVEEDOR 
                     WHERE ID = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Filtro(ByVal TipoFiltro As Integer, ByVal FiltroCadena As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaProductos As New List(Of E_Producto)
            Query = "SELECT PR.*,P.NOMBRE AS PROVEEDORNOMBRE,U.NOMBRE AS UNIDADMEDIDA
                     FROM PRODUCTO PR, PROVEEDOR P,UNIDAD_DE_MEDIDA U
                     WHERE P.ID = PR.ID_PROVEEDOR And U.ID_UNIDAD_DE_MEDIDA = PR.ID_UNIDAD_DE_MEDIDA
                    "
            If (TipoFiltro = 0) Then
                Query = Query + " AND PR.ID_PRODUCTO = @PA;"
            ElseIf (TipoFiltro = 1) Then
                Query = Query + "AND PR.NOMBRE = @PA"
            Else
                Query = Query + "AND PR.MARCA =  @PA"
            End If
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@PA", FiltroCadena)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Producto As New E_Producto
                        _Producto.P_ID_Producto = Lector("ID_Producto")
                        _Producto.P_Marca = Lector("Marca")
                        _Producto.P_Descripcion = Lector("Descripcion")
                        _Producto.P_Categoria = Lector("Categoria")
                        '_Producto.P_Nombre = Lector("Nombre")
                        _Producto.P_Stock_Minimo = Lector("Stock_Min")
                        _Producto.P_Stock_Maximo = Lector("Stock_Max")
                        _Producto.P_Existencia = Lector("Existencia")
                        _Producto.P_ID_UnidadMedida = Lector("ID_Unidad_De_Medida")
                        _Producto.P_PrecioCompra = Lector("PrecioCompra")
                        _Producto.P_PrecioVenta = Lector("PrecioVenta")
                        _Producto.P_FechaIngreso = Lector("FechaIngreso")
                        _Producto.P_ID_Proveedor = Lector("ID_Proveedor")
                        _Producto.P_NombreProveedor = Lector("PROVEEDORNOMBRE")
                        _Producto.P_NombreUnidadMedida = Lector("UNIDADMEDIDA")
                        ListaProductos.Add(_Producto)
                    End While
                    Return ListaProductos
                End Using
            End Using
        End Using
    End Function




End Class
