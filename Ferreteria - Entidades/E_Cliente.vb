Public Class E_Cliente
    'Definición de la entidad Empleado'
    Private ID As Integer
    Private Nombre As String
    Private Apellido As String
    Private Cedula As String
    Private Telefono As String
    Private Direccion As String


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
    Public Property Direccion_P As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property


End Class
