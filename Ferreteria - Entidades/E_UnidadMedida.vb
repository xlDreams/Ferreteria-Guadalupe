Public Class E_UnidadMedida

    'Definición de la entidad Unidad De Medida'
    Private ID_UnidadMedida As Integer
    Private Nombre As String

    'Propiedades de escritura y lectura'
    Public Property P_ID_UnidadMedida As Integer
        Get
            Return ID_UnidadMedida
        End Get
        Set(value As Integer)
            ID_UnidadMedida = value
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

End Class
