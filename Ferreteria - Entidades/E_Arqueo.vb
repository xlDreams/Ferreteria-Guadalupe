Public Class E_Arqueo

    'Definición de la entidad Arqueo'

    Private Fecha As Date
    Private ID As Integer
    Private ID_EMPLEADO As Integer
    Private Caja_Chica As Double
    Private total As Double
    Private B1000 As Integer
    Private B500 As Integer
    Private B200 As Integer
    Private B100 As Integer
    Private B50 As Integer
    Private B20 As Integer
    Private B10 As Integer
    Private M1 As Integer
    Private M5 As Integer
    Private M050 As Integer
    Private D50 As Integer
    Private D20 As Integer
    Private D10 As Integer
    Private D5 As Integer
    Private D1 As Integer

    Public Property P_Fecha As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Property AB1000 As Integer
        Get
            Return B1000
        End Get
        Set(value As Integer)
            B1000 = value
        End Set
    End Property

    Public Property AB500 As Integer
        Get
            Return B500
        End Get
        Set(value As Integer)
            B500 = value
        End Set
    End Property

    Public Property AB200 As Integer
        Get
            Return B200
        End Get
        Set(value As Integer)
            B200 = value
        End Set
    End Property

    Public Property AB100 As Integer
        Get
            Return B100
        End Get
        Set(value As Integer)
            B100 = value
        End Set
    End Property

    Public Property AB50 As Integer
        Get
            Return B50
        End Get
        Set(value As Integer)
            B50 = value
        End Set
    End Property

    Public Property AB20 As Integer
        Get
            Return B20
        End Get
        Set(value As Integer)
            B20 = value
        End Set
    End Property

    Public Property AB10 As Integer
        Get
            Return B10
        End Get
        Set(value As Integer)
            B10 = value
        End Set
    End Property

    Public Property AM1 As Integer
        Get
            Return M1
        End Get
        Set(value As Integer)
            M1 = value
        End Set
    End Property

    Public Property AM5 As Integer
        Get
            Return M5
        End Get
        Set(value As Integer)
            M5 = value
        End Set
    End Property


    Public Property AM050 As Integer
        Get
            Return M050
        End Get
        Set(value As Integer)
            M050 = value
        End Set
    End Property


    Public Property AD50 As Integer
        Get
            Return D50
        End Get
        Set(value As Integer)
            D50 = value
        End Set
    End Property

    Public Property AD20 As Integer
        Get
            Return D20
        End Get
        Set(value As Integer)
            D20 = value
        End Set
    End Property

    Public Property AD10 As Integer
        Get
            Return D10
        End Get
        Set(value As Integer)
            D10 = value
        End Set
    End Property

    Public Property AD5 As Integer
        Get
            Return D5
        End Get
        Set(value As Integer)
            D5 = value
        End Set
    End Property

    Public Property AD1 As Integer
        Get
            Return D1
        End Get
        Set(value As Integer)
            D1 = value
        End Set
    End Property

    Public Property P_ID_EMPLEADO As Integer
        Get
            Return ID_EMPLEADO
        End Get
        Set(value As Integer)
            ID_EMPLEADO = value
        End Set
    End Property

    Public Property P_Caja_Chica As Double
        Get
            Return Caja_Chica
        End Get
        Set(value As Double)
            Caja_Chica = value
        End Set
    End Property

    Public Property P_Total As Double
        Get
            Return total
        End Get
        Set(value As Double)
            total = value
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
