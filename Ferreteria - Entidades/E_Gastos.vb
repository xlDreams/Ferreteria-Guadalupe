Public Class E_Gastos
    Private ID As Integer
    Private ID_Empleado As Integer
    Private Fecha As Date
    Private Descripcion As String
    Private Cantidad As Double

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

    Public Property P_Descripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Property P_Cantidad As Double
        Get
            Return Cantidad
        End Get
        Set(value As Double)
            Cantidad = value
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
