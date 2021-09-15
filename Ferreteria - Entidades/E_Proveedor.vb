Public Class E_Proveedor

    'Definición de la entidad Proveedor'
    Private ID_Proveedor As Integer
    Private Nombre As String
    Private Telefono As String
    Private Correo As String
    Private Direccion As String

    'Propiedades de lectura y escritura'
    Public Property P_ID_Proveedor As Integer
        Get
            Return ID_Proveedor
        End Get
        Set(value As Integer)
            ID_Proveedor = value
        End Set
    End Property
    Public Property P_Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Property P_Telefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Public Property P_Correo As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property
    Public Property P_Direccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
End Class
