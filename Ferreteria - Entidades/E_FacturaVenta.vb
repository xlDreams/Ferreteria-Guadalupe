Public Class E_FacturaVenta
    'Definición de la entidad FacturaVenta'

    Private ID_Factura As Integer
    Private SubTotal As Decimal
    Private Descuento As Decimal
    Private Estado As String
    Private Tipo As String
    Private ID_Cliente As Integer
    Private ID_Empleado As Integer
    Private Fecha As Date
    Private Bandera_Anulacion As Boolean
    Private Motivo_Anulacion As String

    'Propiedades de lectura y escritura de la entidad'
    Public Property P_ID_Factura As Integer
        Get
            Return ID_Factura
        End Get
        Set(value As Integer)
            ID_Factura = value
        End Set
    End Property

    Public Property P_SubTotal As Decimal
        Get
            Return SubTotal
        End Get
        Set(value As Decimal)
            SubTotal = value
        End Set
    End Property

    Public Property P_Descuento As Decimal
        Get
            Return Descuento
        End Get
        Set(value As Decimal)
            Descuento = value
        End Set
    End Property

    Public Property P_Estado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property

    Public Property P_Tipo As String
        Get
            Return Tipo
        End Get
        Set(value As String)
            Tipo = value
        End Set
    End Property

    Public Property P_ID_Cliente As Integer
        Get
            Return ID_Cliente
        End Get
        Set(value As Integer)
            ID_Cliente = value
        End Set
    End Property

    Public Property P_ID_Empleado As Integer
        Get
            Return ID_Empleado
        End Get
        Set(value As Integer)
            ID_Empleado = value
        End Set
    End Property

    Public Property P_Fecha As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Property P_Bandera_Anulacion As Boolean
        Get
            Return Bandera_Anulacion
        End Get
        Set(value As Boolean)
            Bandera_Anulacion = value
        End Set
    End Property

    Public Property P_Motivo_Anulacion As String
        Get
            Return Motivo_Anulacion
        End Get
        Set(value As String)
            Motivo_Anulacion = value
        End Set
    End Property
End Class
