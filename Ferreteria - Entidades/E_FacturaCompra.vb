Public Class E_FacturaCompra
    'Definición de la entidad FacturaCompra'
    Private ID As Integer
    Private ID_Proveedor As Integer
    Private Total As Integer
    Private Tipo As String
    Private Fecha As Date
    Private NombreProveedor As String
    Private Estado As String

    'Propiedades de escritura y lectura'
    Public Property P_ID_Proveedor As Integer
        Get
            Return ID_Proveedor
        End Get
        Set(value As Integer)
            ID_Proveedor = value
        End Set
    End Property

    Public Property P_Total As Integer
        Get
            Return Total
        End Get
        Set(value As Integer)
            Total = value
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

    Public Property P_Fecha As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
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

    Public Property P_NombreProveedor As String
        Get
            Return NombreProveedor
        End Get
        Set(value As String)
            NombreProveedor = value
        End Set
    End Property

    Public Property P_ID As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property
End Class
