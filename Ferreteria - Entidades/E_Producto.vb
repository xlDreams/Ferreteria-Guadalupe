Public Class E_Producto

    'Definición de la entidad Producto'

    Private ID_Producto As String
    Private Marca As String
    Private Descripcion As String
    Private Categoria As String
    '  Private Nombre As String
    Private Stock_Minimo As Integer
    Private Stock_Maximo As Integer
    Private Existencia As Integer
    Private ID_UnidadMedida As Integer
    Private NombreUnidadMedida As String
    Private PrecioCompra As Decimal
    Private PrecioVenta As Decimal
    Private FechaIngreso As Date
    Private ID_Proveedor As Integer
    Private NombreProveedor As String

    'Propiedades de lectura y escritura'

    Public Property P_ID_Producto As String
        Get
            Return ID_Producto
        End Get
        Set(value As String)
            ID_Producto = value
        End Set
    End Property
    Public Property P_Marca As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property
    Public Property P_Descripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
    Public Property P_Categoria As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property
    ' Public Property P_Nombre As String
    'Get
    'Return Nombre
    'End Get
    'Set(value As String)
    '      Nombre = value
    'End Set
    'End Property
    Public Property P_Stock_Minimo As Integer
        Get
            Return Stock_Minimo
        End Get
        Set(value As Integer)
            Stock_Minimo = value
        End Set
    End Property
    Public Property P_Stock_Maximo As Integer
        Get
            Return Stock_Maximo
        End Get
        Set(value As Integer)
            Stock_Maximo = value
        End Set
    End Property
    Public Property P_Existencia As Integer
        Get
            Return Existencia
        End Get
        Set(value As Integer)
            Existencia = value
        End Set
    End Property
    Public Property P_ID_UnidadMedida As Integer
        Get
            Return ID_UnidadMedida
        End Get
        Set(value As Integer)
            ID_UnidadMedida = value
        End Set
    End Property
    Public Property P_NombreUnidadMedida As String
        Get
            Return NombreUnidadMedida
        End Get
        Set(value As String)
            NombreUnidadMedida = value
        End Set
    End Property
    Public Property P_PrecioCompra As Decimal
        Get
            Return PrecioCompra
        End Get
        Set(value As Decimal)
            PrecioCompra = value
        End Set
    End Property
    Public Property P_PrecioVenta As Decimal
        Get
            Return PrecioVenta
        End Get
        Set(value As Decimal)
            PrecioVenta = value
        End Set
    End Property
    Public Property P_FechaIngreso As Date
        Get
            Return FechaIngreso
        End Get
        Set(value As Date)
            FechaIngreso = value
        End Set
    End Property
    Public Property P_ID_Proveedor As Integer
        Get
            Return ID_Proveedor
        End Get
        Set(value As Integer)
            ID_Proveedor = value
        End Set
    End Property
    Public Property P_NombreProveedor As String
        Get
            Return NombreProveedor
        End Get
        Set(value As String)
            NombreProveedor = value
        End Set
    End Property
End Class
