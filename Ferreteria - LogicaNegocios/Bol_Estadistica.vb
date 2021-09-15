
Imports System.Text
Imports Ferreteria___AccesoDatos

' Logica de negocios con la entidad estadistica'
Public Class Bol_Estadistica

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Estadistica As New Dai_Estadistica()
    Public Errores As New StringBuilder

    'Obtiene las estadistica de un tipo'
    Public Function ObtenerEstadistica(ByVal Tipo As Integer, Fecha As Date)
        Errores.Clear()
        Try
            Select Case Tipo
                Case 1
                    Return Dai_Estadistica.GetEstadisticaProveedor()
                Case 2
                    Return Dai_Estadistica.GetEstadisticaCliente()
                Case 3
                    Return Dai_Estadistica.GetEstadisticaProducto()
                Case 4
                    Return Dai_Estadistica.GetEstadisticaEmpleado()
                Case 5
                    Return Dai_Estadistica.GetEstadisticaGananciaDia(Fecha)
                Case 6
                    Return Dai_Estadistica.GetEstadisticaGananciaMensual(Fecha)
                Case 7
                    Return Dai_Estadistica.GetEstadisticaGananciaAño(Fecha)

            End Select
        Catch Ex As Exception
            Errores.Append("Hubo un error al obtener los datos")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
        Return 0
    End Function

End Class
