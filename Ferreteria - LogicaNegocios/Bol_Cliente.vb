
Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

' Logica de negocios con la entidad cliente'
Public Class Bol_Cliente
    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Cliente As New Dai_Cliente()
    Public Errores As New StringBuilder

    Public Function ObtenerListaClientes()
        Errores.Clear()
        Try
            Return Dai_Cliente.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de clientes")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCliente(ByVal ID As Integer)
        Errores.Clear()
        Try
            Return Dai_Cliente.GetByID(ID)
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer los datos del cliente")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    Public Sub InsertarCliente(ByVal Cliente As E_Cliente)
        Errores.Clear()
        Try
            If (Cliente.Nombre_P = "") Then
                Errores.Append("El nombre del cliente no puede estar vacio" + vbNewLine)
            End If
            If (Cliente.Telefono_P = "" Or Cliente.Telefono_P.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio ni ser menor que 8 digitos" + vbNewLine)
            End If
            If (Cliente.Direccion_P = "") Then
                Errores.Append("La dirección no puede estar vacia" + vbNewLine)
            End If
            If (Cliente.Apellido_P = "") Then
                Errores.Append("El apellido no puede estar vacio" + vbNewLine)
            End If
            If (Cliente.Cedula_P = "") Then
                Errores.Append("La cedula no puede estar vacia" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Cliente.Insert(Cliente)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al insertar el cliente")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Sub ActualizarCliente(ByVal Cliente As E_Cliente)
        Errores.Clear()
        Try
            If (Cliente.Nombre_P = "") Then
                Errores.Append("El nombre del cliente no puede estar vacio" + vbNewLine)
            End If
            If (Cliente.Telefono_P = "" Or Cliente.Telefono_P.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio ni ser menor que 8 digitos" + vbNewLine)
            End If
            If (Cliente.Direccion_P = "") Then
                Errores.Append("La dirección no puede estar vacia" + vbNewLine)
            End If
            If (Cliente.Apellido_P = "") Then
                Errores.Append("El apellido no puede estar vacio" + vbNewLine)
            End If
            If (Cliente.Cedula_P = "") Then
                Errores.Append("La cedula no puede estar vacia" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Cliente.Update(Cliente)
            End If

        Catch Ex As Exception
            Errores.Append("Hubo un error al actualizar el cliente")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub
    Public Sub EliminarCliente(ByVal ID As Integer)
        Errores.Clear()
        Try
            Dai_Cliente.Delete(ID)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al eliminar el cliente")
            Else
                Errores.Append("No se puede eliminar el cliente porque tiene depedencias, si lo quiere eliminar proceda a quitarlas.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Function FiltrosCliente(ByVal Tipo_Filtro As Integer, ByVal CadenaFiltro As String)
        Errores.Clear()
        Try
            Return Dai_Cliente.Filtro(Tipo_Filtro, CadenaFiltro)
        Catch Ex As Exception
            Errores.Append("Hubo un error al realizar el filtro")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
        Return Nothing
    End Function


    Public Function ObtenerIDClientes()
        Errores.Clear()
        Try
            Dim Clientes = Dai_Cliente.GetAll()
            Dim IDClientes(Clientes.count - 1) As String
            For I As Integer = 0 To Clientes.count - 1
                IDClientes(I) = Clientes(I).Nombre_P + " " + Clientes(I).Apellido_P + " #" + Clientes(I).ID_P.ToString()
            Next
            Return IDClientes
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de clientes")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

End Class
