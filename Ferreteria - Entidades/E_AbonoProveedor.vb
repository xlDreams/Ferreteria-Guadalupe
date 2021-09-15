'Definición de la entidad AbonosProveedor
Public Class E_AbonoProveedor
    Private NumeroAbono As Integer
    Private FechaPago As Date
    Private Descripcion As String
    Private MontoAbono As Decimal
    Private NumeroFactura As Integer
    Private ID_Empleado As Integer
    Private ID_Proveedor As Integer

    Public Property P_NumeroAbono As Integer
        Get
            Return NumeroAbono
        End Get
        Set(value As Integer)
            NumeroAbono = value
        End Set
    End Property
    Public Property P_FechaPago As Date
        Get
            Return FechaPago
        End Get
        Set(value As Date)
            FechaPago = value
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
    Public Property P_MontoAbono As Decimal
        Get
            Return MontoAbono
        End Get
        Set(value As Decimal)
            MontoAbono = value
        End Set
    End Property
    Public Property P_NumeroFactura As Integer
        Get
            Return NumeroFactura
        End Get
        Set(value As Integer)
            NumeroFactura = value
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
    Public Property P_ID_Proveedor As Integer
        Get
            Return ID_Proveedor
        End Get
        Set(value As Integer)
            ID_Proveedor = value
        End Set
    End Property

End Class
