Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades
Public Class Bol_Gastos

    Private Dai_Gastos As New Dai_GastoA()
    Public Errores As New StringBuilder
    Public Sub InsertarGastos(ByVal Gastos As E_Gastos)
        Errores.Clear()
        Try
            If (Gastos.P_ID_Empleado = 0 Or Gastos.P_Fecha = Nothing) Then
                Errores.Append("CAMPOS VACIOS." + vbNewLine)
            End If
            If (Gastos.P_Descripcion = "") Then
                Errores.Append("lA DESCRIPCION no puede estar vacia." + vbNewLine)
            End If
            If (Gastos.P_Cantidad = 0) Then
                Errores.Append("Debe contener al menos alguna cantidad." + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Gastos.Insert(Gastos)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al insertar el Gasto.")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Function ObtenerGastos()
        Errores.Clear()
        Try
            Return Dai_Gastos.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al listar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    'Extraer datos
    Public Function ObtenerIDGastos(ByVal ID_Gasto As Integer)
        Errores.Clear()
        Try
            Return Dai_Gastos.GetByID(ID_Gasto)
        Catch Ex As Exception
            Errores.Append("Hubo un error al listar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function
    Public Sub ActualizarGasto(ByVal Gasto As E_Gastos)
        Errores.Clear()
        Try
            If (Gasto.P_ID_Empleado = 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Gasto.P_Descripcion = "") Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Gasto.P_Cantidad < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If


            If (Errores.Length = 0) Then
                Dai_Gastos.Update(Gasto)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al actulizar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Sub EliminarGasto(ByVal ID As Integer)
        Errores.Clear()
        Try
            Dai_Gastos.Delete(ID)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al eliminar el proveedor.")
            Else
                Errores.Append("No se puede eliminar el Gasto porque tiene depedencias, si lo quiere eliminar proceda a quitarlas.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Function ObtenerDato(ByVal Fecha As Date)
        Errores.Clear()
        Try

            Return Dai_Gastos.GetGasto(Fecha)

        Catch Ex As Exception
            Errores.Append("Hubo un error al obtener los datos")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
        Return 0
    End Function

End Class
