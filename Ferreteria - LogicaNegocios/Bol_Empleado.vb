
Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

' Logica de negocios con la entidad empleado'
Public Class Bol_Empleado
    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Empleado As New Dai_Empleado()
    Public Errores As New StringBuilder

    'Permite saber si un usuario existe'
    Public Function AutenticarUsuario(ByVal Empleado As E_Empleado)
        Errores.Clear()
        If (Empleado.Usuario_P = "") Then
            Errores.Append("No se ingreso ningun usuario." + vbNewLine)
        End If
        If (Empleado.Contraseña_P = "") Then
            Errores.Append("No se ingreso ninguna contraseña." + vbNewLine)
        End If

        If (Errores.Length = 0) Then
            Try
                Dim EmpleadoR = Dai_Empleado.VerificarUsuario(Empleado)
                If (EmpleadoR Is Nothing) Then
                    Errores.Append("Los datos ingresados no coinciden con ningun usuario, Por favor escriba datos validos. ")
                End If
                Return EmpleadoR
            Catch Ex As Exception
                Errores.Append("Hubo un error al realizar la operación")
                If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                End If
            End Try
        End If
        Return Nothing
    End Function

    Public Function ObtenerEmpleados()
        Errores.Clear()
        Try
            Return Dai_Empleado.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de empleados")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Function ObtenerEmpleado(ByVal ID As Integer)
        Errores.Clear()
        Try
            Return Dai_Empleado.GetByID(ID)
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer los datos del empleado")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Sub InsertarEmpleado(ByVal Empleado As E_Empleado)
        Errores.Clear()
        Try
            If (Empleado.Nombre_P = "") Then
                Errores.Append("El nombre del empleado no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Telefono_P = "" Or Empleado.Telefono_P.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio ni ser menor que 8 digitos" + vbNewLine)
            End If
            If (Empleado.Usuario_P = "") Then
                Errores.Append("El usuario no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Apellido_P = "") Then
                Errores.Append("El apellido no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Cedula_P = "") Then
                Errores.Append("La cedula no puede estar vacia" + vbNewLine)
            End If
            If (Empleado.Contraseña_P = "") Then
                Errores.Append("La contraseña no puede estar vacia" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Empleado.Insert(Empleado)
            End If

        Catch Ex As Exception
            Errores.Append("Hubo un error al insertar el empleado")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Sub ActualizarEmpleado(ByVal Empleado As E_Empleado)
        Errores.Clear()
        Try
            If (Empleado.Nombre_P = "") Then
                Errores.Append("El nombre del empleado no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Telefono_P = "" Or Empleado.Telefono_P.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio ni ser menor que 8 digitos" + vbNewLine)
            End If
            If (Empleado.Usuario_P = "") Then
                Errores.Append("El usuario no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Apellido_P = "") Then
                Errores.Append("El apellido no puede estar vacio" + vbNewLine)
            End If
            If (Empleado.Cedula_P = "") Then
                Errores.Append("La cedula no puede estar vacia" + vbNewLine)
            End If
            If (Empleado.Contraseña_P = "") Then
                Errores.Append("La contraseña no puede estar vacia" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Empleado.Update(Empleado)
            End If

        Catch Ex As Exception
            Errores.Append("Hubo un error al actualizar el empleado")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub
    Public Sub EliminarEmpleado(ByVal ID As Integer)
        Errores.Clear()
        Try
            Dai_Empleado.Delete(ID)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al eliminar el empleado")
            Else
                Errores.Append("No se puede eliminar el empleado porque tiene depedencias, si lo quiere eliminar proceda a quitarlas.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub










    'Parte de obtener ID por medio del nombre --- ARQUEO
    Public Function ObtenerNameEmpleado(ByVal Name As String)
        Errores.Clear()
        Try
            Return Dai_Empleado.GetByName(Name)
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer los datos del empleado")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

End Class
