Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Producto'

Public Class Dai_Producto
    Dim Query As String

    'Lista todos los productos existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaProductos As New List(Of E_Producto)
            Query = "SELECT PR.*,P.NOMBRE AS PROVEEDORNOMBRE,U.NOMBRE AS UNIDADMEDIDA
                     FROM PRODUCTO PR, PROVEEDOR P,UNIDAD_DE_MEDIDA U
                     WHERE P.ID = PR.ID_PROVEEDOR AND U.ID_UNIDAD_DE_MEDIDA = PR.ID_UNIDAD_DE_MEDIDA;
                    "
            Using CMD As New SqlCommand(Query, Conn)
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

    'Lista un producto por ID'
    Public Function GetByID(ByVal ID_Producto As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT * FROM PRODUCTO
                     WHERE ID_PRODUCTO = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID_Producto)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Lector.Read()
                    Dim _Producto As New E_Producto
                    _Producto.P_ID_Producto = Lector("ID_Producto")
                    _Producto.P_Marca = Lector("Marca")
                    _Producto.P_Descripcion = Lector("Descripcion")
                    _Producto.P_Categoria = Lector("Categoria")
                    '    _Producto.P_Nombre = Lector("Nombre")
                    _Producto.P_Stock_Minimo = Lector("Stock_Min")
                    _Producto.P_Stock_Maximo = Lector("Stock_Max")
                    _Producto.P_Existencia = Lector("Existencia")
                    _Producto.P_ID_UnidadMedida = Lector("ID_Unidad_De_Medida")
                    _Producto.P_PrecioCompra = Lector("PrecioCompra")
                    _Producto.P_PrecioVenta = Lector("PrecioVenta")
                    _Producto.P_FechaIngreso = Lector("FechaIngreso")
                    _Producto.P_ID_Proveedor = Lector("ID_Proveedor")

                    Return _Producto
                End Using
            End Using
        End Using
    End Function

    'Inserta un producto en la BD'
    Public Sub Insert(ByVal Producto As E_Producto)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO PRODUCTO 
                     VALUES(@ID_Producto,@Marca,@Descripcion,@Categoria,@Stock_Min,@Stock_Max,@Existencia,@ID_Unidad_De_Medida,@PrecioCompra,@PrecioVenta,@FechaIngreso,@ID_Proveedor)"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Producto", Producto.P_ID_Producto)
                CMD.Parameters.AddWithValue("@Marca", Producto.P_Marca)
                CMD.Parameters.AddWithValue("@Descripcion", Producto.P_Descripcion)
                CMD.Parameters.AddWithValue("@Categoria", Producto.P_Categoria)
                'CMD.Parameters.AddWithValue("@Nombre", Producto.P_Nombre)
                CMD.Parameters.AddWithValue("@Stock_Min", Producto.P_Stock_Minimo)
                CMD.Parameters.AddWithValue("@Stock_Max", Producto.P_Stock_Maximo)
                CMD.Parameters.AddWithValue("@Existencia", Producto.P_Existencia)
                CMD.Parameters.AddWithValue("@ID_Unidad_De_Medida", Producto.P_ID_UnidadMedida)
                CMD.Parameters.AddWithValue("@PrecioCompra", Producto.P_PrecioCompra)
                CMD.Parameters.AddWithValue("@PrecioVenta", Producto.P_PrecioVenta)
                CMD.Parameters.AddWithValue("@FechaIngreso", Producto.P_FechaIngreso)
                CMD.Parameters.AddWithValue("@ID_Proveedor", Producto.P_ID_Proveedor)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Actualiza un producto en la BD'
    Public Sub Update(ByVal Producto As E_Producto)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "UPDATE  PRODUCTO 
                    SET Marca = @Marca,Descripcion = @Descripcion,Categoria = @Categoria,Stock_Min = @Stock_Min,Stock_Max = @Stock_Max,Existencia = @Existencia,ID_Unidad_De_Medida = @ID_Unidad_De_Medida,PrecioCompra = @PrecioCompra,PrecioVenta = @PrecioVenta,FechaIngreso = @FechaIngreso,ID_Proveedor = @ID_Proveedor
                    WHERE ID_PRODUCTO = @ID_Producto "
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Producto", Producto.P_ID_Producto)
                CMD.Parameters.AddWithValue("@Marca", Producto.P_Marca)
                CMD.Parameters.AddWithValue("@Descripcion", Producto.P_Descripcion)
                CMD.Parameters.AddWithValue("@Categoria", Producto.P_Categoria)
                ' CMD.Parameters.AddWithValue("@Nombre", Producto.P_Nombre)
                CMD.Parameters.AddWithValue("@Stock_Min", Producto.P_Stock_Minimo)
                CMD.Parameters.AddWithValue("@Stock_Max", Producto.P_Stock_Maximo)
                CMD.Parameters.AddWithValue("@Existencia", Producto.P_Existencia)
                CMD.Parameters.AddWithValue("@ID_Unidad_De_Medida", Producto.P_ID_UnidadMedida)
                CMD.Parameters.AddWithValue("@PrecioCompra", Producto.P_PrecioCompra)
                CMD.Parameters.AddWithValue("@PrecioVenta", Producto.P_PrecioVenta)
                CMD.Parameters.AddWithValue("@FechaIngreso", Producto.P_FechaIngreso)
                CMD.Parameters.AddWithValue("@ID_Proveedor", Producto.P_ID_Proveedor)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Elimina un producto en la BD'
    Public Sub Delete(ByVal ID_Producto As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "DELETE FROM PRODUCTO 
                     WHERE ID_PRODUCTO = @ID_Producto"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_Producto", ID_Producto)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Filtro(ByVal TipoFiltro As Integer, ByVal FiltroCadena As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim ListaProductos As New List(Of E_Producto)
            Query = "SELECT PR.*,P.Nombre AS PROVEEDORNOMBRE,U.NOMBRE AS UNIDADMEDIDA
                     FROM PRODUCTO PR, PROVEEDOR P,UNIDAD_DE_MEDIDA U
                     WHERE P.ID = PR.ID_PROVEEDOR And U.ID_UNIDAD_DE_MEDIDA = PR.ID_UNIDAD_DE_MEDIDA
                    "
            If (TipoFiltro = 0) Then
                Query = Query + " AND PR.ID_PRODUCTO like '%'+@PA+'%'"
            ElseIf (TipoFiltro = 1) Then
                Query = Query + "AND PR.Descripcion like  '%'+@PA+'%'"
            Else
                Query = Query + "AND PR.MARCA like  '%'+@PA+'%'"
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
                        ' _Producto.P_Nombre = Lector("Nombre")
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

    'Obtiene el stock de un producto'
    Public Function GetStockProducto(ByVal ID As String)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT EXISTENCIA 
                     FROM PRODUCTO WHERE ID_Producto = @ID"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

End Class
