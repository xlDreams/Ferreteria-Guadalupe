Public Class E_Empleado

    'Definición de la entidad Empleado'
    Private ID As Integer
    Private Nombre As String
    Private Apellido As String
    Private Cedula As String
    Private Telefono As String
    Private Usuario As String
    Private Contraseña As String
    Private Rol As String

    'Propiedades de lectura y escritura'
    Public Property ID_P As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property
    Public Property Nombre_P As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Property Apellido_P As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property
    Public Property Cedula_P As String
        Get
            Return Cedula
        End Get
        Set(value As String)
            Cedula = value
        End Set
    End Property
    Public Property Telefono_P As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Public Property Usuario_P As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            Usuario = value
        End Set
    End Property
    Public Property Contraseña_P As String
        Get
            Return Contraseña
        End Get
        Set(value As String)
            Contraseña = value
        End Set
    End Property

    Public Property Rol_P As String
        Get
            Return Rol
        End Get
        Set(value As String)
            Rol = value
        End Set
    End Property

End Class

