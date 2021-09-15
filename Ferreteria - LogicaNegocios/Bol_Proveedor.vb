Imports System.Text
Imports System.Text.RegularExpressions
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

'Logica de negocios de la entidad Proveedor'
Public Class Bol_Proveedor

    'Definicion de valores retornados en funciones :
    '  1  -> Exito en la operación
    '  0  -> Exito en la operación pero no fue realizada (Por datos que no coinciden o que no existen)
    ' -1  -> Error por Excepción usualmente por base de datos'
    ' -2  -> Error controlado por la aplicación (Por ejemplo datos mal ingresados etc.)

    'Importacion de la clase Dai y creación de variable que contendra los errores'
    Private Dai_Proveedor As New Dai_Proveedor()
    Public Errores As New StringBuilder

    'Obtiene la lista de proveedores y las muestra en formato ID'
    Public Function ObtenerIDProveedores()
        Errores.Clear()
        Try
            Dim ListaProveedores = Dai_Proveedor.GetAll()
            Dim ProveedoresID(ListaProveedores.count - 1) As String
            For I As Integer = 0 To ListaProveedores.count - 1
                ProveedoresID(I) = ListaProveedores(I).P_Nombre + " #" + ListaProveedores(I).P_ID_Proveedor.ToString()
            Next
            Return ProveedoresID
        Catch Ex As Exception
            Errores.Append("Hubo un error al leer la lista de proveedores")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function

    'para el editar
    Public Function ObtenerProveedor(ByVal ID_Proveedor As Integer)
        Errores.Clear()
        Try
            Return Dai_Proveedor.GetByID(ID_Proveedor)
        Catch Ex As Exception
            Errores.Append("Hubo un error al recuperar la información del proveedor")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function


    'Para el datagrid
    Public Function ObtenerProveedores()
        Errores.Clear()
        Try
            Return Dai_Proveedor.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al listar los proveedores")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function


    Public Sub InsertarProveedor(ByVal Proveedor As E_Proveedor)
        Errores.Clear()
        Try
            If (Proveedor.P_Telefono = "" Or Proveedor.P_Telefono.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio o ser menor que 8 digitos." + vbNewLine)
            End If
            If (Proveedor.P_Nombre = "") Then
                Errores.Append("El nombre del proveedor no puede estar vacio." + vbNewLine)
            End If
            If (Proveedor.P_Direccion = "") Then
                Errores.Append("La dirección del proveedor no puede estar vacia." + vbNewLine)
            End If
            If (Proveedor.P_Correo = "" Or Not Regex.IsMatch(Proveedor.P_Correo, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")) Then
                Errores.Append("El correo del proveedor no puede estar vacio, o tener un mal formato" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Proveedor.Insert(Proveedor)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al insertar el proveedor.")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

    Public Sub ActualizarProveedor(ByVal Proveedor As E_Proveedor)
        Errores.Clear()
        Try
            If (Proveedor.P_Telefono = "" Or Proveedor.P_Telefono.Length < 8) Then
                Errores.Append("El telefono no puede estar vacio o ser menor que 8 digitos.")
            End If
            If (Proveedor.P_Nombre = "") Then
                Errores.Append("El nombre del proveedor no puede estar vacio.")
            End If
            If (Proveedor.P_Direccion = "") Then
                Errores.Append("La dirección del proveedor no puede estar vacia.")
            End If
            If (Proveedor.P_Correo = "" And Not Regex.IsMatch(Proveedor.P_Correo, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")) Then
                Errores.Append("El correo del proveedor no puede estar vacio y debe tener un formato correcto")
            End If
            If (Errores.Length = 0) Then
                Dai_Proveedor.Update(Proveedor)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al actulizar el proveedor")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub
    Public Sub EliminarProveedor(ByVal ID As Integer)
        Errores.Clear()
        Try
            Dai_Proveedor.Delete(ID)
        Catch Ex As Exception
            If (Ex.HResult <> -2146232060) Then
                Errores.Append("Hubo un error al eliminar el proveedor.")
            Else
                Errores.Append("No se puede eliminar el proveedor porque tiene depedencias, si lo quiere eliminar proceda a quitarlas.")
            End If
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub

End Class
