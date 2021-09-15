Public Class E_DetalleFactura

    'Definición de la entidad DetalleFactura'
    Private ID_Factura As Integer
    Private N_Linea As Integer
    Private Cantidad As Integer
    Private ID_Producto As String
    Private Precio As Decimal

    'Propiedades de escritura y lectura DetalleFactura'
    Public Property P_ID_Factura As Integer
        Get
            Return ID_Factura
        End Get
        Set(value As Integer)
            ID_Factura = value
        End Set
    End Property
    Public Property P_N_Linea As Integer
        Get
            Return N_Linea
        End Get
        Set(value As Integer)
            N_Linea = value
        End Set
    End Property

    Public Property P_Cantidad As Integer
        Get
            Return Cantidad
        End Get
        Set(value As Integer)
            Cantidad = value
        End Set
    End Property
    Public Property P_ID_Producto As String
        Get
            Return ID_Producto
        End Get
        Set(value As String)
            ID_Producto = value
        End Set
    End Property
    Public Property P_Precio As Decimal
        Get
            Return Precio
        End Get
        Set(value As Decimal)
            Precio = value
        End Set
    End Property
End Class
