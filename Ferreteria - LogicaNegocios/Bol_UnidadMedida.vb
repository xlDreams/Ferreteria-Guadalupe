Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

'Logica de negocios de la entidad UnidadDeMedida'
Public Class Bol_UnidadMedida

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'

    Private Dai_UnidadMedida As New Dai_UnidadMedida()
    Public Errores As New StringBuilder

    Public Function ObtenerIDUnidadesMedida()
        Errores.Clear()
        Try
            Dim Unidades = Dai_UnidadMedida.GetAll()
            Dim IDUnidades(Unidades.count - 1) As String
            For I As Integer = 0 To Unidades.count - 1
                IDUnidades(I) = Unidades(I).P_Nombre + "#" + Unidades(I).P_ID_UnidadMedida.ToString()
            Next
            Return IDUnidades
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de unidades de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUnidadesDeMedidas()
        Errores.Clear()
        Try
            Return Dai_UnidadMedida.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de unidades de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUnidadDeMedida(ByVal UnidadMedida As Integer)
        Errores.Clear()
        Try
            Return Dai_UnidadMedida.GetByID(UnidadMedida)
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de unidades de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Sub InsertarUnidadMedida(ByVal Unidad As E_UnidadMedida)
        Errores.Clear()
        Try
            If (Unidad.P_Nombre = "") Then
                Errores.Append("El nombre de la unidad de medida no puede estar vacia")
            End If
            If (Errores.Length = 0) Then
                Dai_UnidadMedida.Insert(Unidad)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al insertar la unidad de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Sub ActualizarUnidadMedida(ByVal Unidad As E_UnidadMedida)
        Errores.Clear()
        Try
            If (Unidad.P_Nombre = "") Then
                Errores.Append("El nombre de la unidad de medida no puede estar vacia")
            End If
            If (Errores.Length = 0) Then
                Dai_UnidadMedida.Update(Unidad)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de unidades de medida")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub
    Public Sub EliminarUnidadMedida(ByVal ID As Integer)
        Errores.Clear()
        Try
            Dai_UnidadMedida.Delete(ID)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al eliminar la unidad.")
            Else
                Errores.Append("No se puede eliminar la unidad de medida porque tiene depedencias, si la quiere eliminar proceda a quitarlas.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub




End Class
