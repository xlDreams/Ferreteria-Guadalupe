'Definición de la entidad MontoFactura'
Public Class E_MontoFactura

    Private ID_Factura As Integer
    Private MontoTotal As Decimal
    Private MontoPagado As Decimal
    Private MontoRestante As Decimal

    'Propiedades de escritura y lectura'

    Public Property P_ID_Factura As Integer
        Get
            Return ID_Factura
        End Get
        Set(value As Integer)
            ID_Factura = value
        End Set
    End Property

    Public Property P_MontoTotal As Decimal
        Get
            Return MontoTotal
        End Get
        Set(value As Decimal)
            MontoTotal = value
        End Set
    End Property

    Public Property P_MontoPagado As Decimal
        Get
            Return MontoPagado
        End Get
        Set(value As Decimal)
            MontoPagado = value
        End Set
    End Property

    Public Property P_MontoRestante As Decimal
        Get
            Return MontoRestante
        End Get
        Set(value As Decimal)
            MontoRestante = value
        End Set
    End Property

End Class
