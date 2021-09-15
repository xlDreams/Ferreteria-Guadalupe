Imports System.Text
Imports Ferreteria___AccesoDatos
Imports Ferreteria___Entidades

Public Class Bol_Arqueo
    Private Dai_Arqueo As New Dai_Arqueo()
    Public Errores As New StringBuilder
    Public Sub Insertar(ByVal Arqueo As E_Arqueo)
        Errores.Clear()
        If (Arqueo.AB1000 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB500 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB200 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB100 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB50 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB20 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AB10 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AM5 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AM1 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AM050 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AD50 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AD20 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AD10 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AD5 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If
        If (Arqueo.AD1 < 0) Then
            Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
        End If


        If (Errores.Length = 0) Then
            Try
                Dai_Arqueo.Insert(Arqueo)
            Catch Ex As Exception
                If (Ex.HResult <> -2146232060) Then
                    Errores.Append("Hubo un error al insertar al arqueo")
                Else
                    Errores.Append("El ID que trata insertar ya se encuentra registrado en la base de datos, por favor escriba otro.")
                End If
                If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                    Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
                End If
            End Try
        End If
    End Sub



    Public Function ObtenerArqueo()
        Errores.Clear()
        Try
            Return Dai_Arqueo.GetAll()
        Catch Ex As Exception
            Errores.Append("Hubo un error al listar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function
    Public Function ObtenerIDArqueo(ByVal ID_ARQUEO As Integer)
        Errores.Clear()
        Try
            Return Dai_Arqueo.GetByID(ID_ARQUEO)
        Catch Ex As Exception
            Errores.Append("Hubo un error al listar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
            Return Nothing
        End Try
    End Function


    Public Sub ActualizarArqueo(ByVal Arqueo As E_Arqueo)
        Errores.Clear()
        Try
            If (Arqueo.AB1000 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB500 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB200 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB100 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB50 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB20 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AB10 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AM5 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AM1 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AM050 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AD50 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AD20 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AD10 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AD5 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If
            If (Arqueo.AD1 < 0) Then
                Errores.Append("NO PUEDEN INGRESAR DATOS NULOS" + vbNewLine)
            End If

            If (Errores.Length = 0) Then
                Dai_Arqueo.Update(Arqueo)
            End If
        Catch Ex As Exception
            Errores.Append("Hubo un error al actulizar el Arqueo")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
    End Sub


    Public Function ObtenerDato(ByVal Fecha As Date)
        Errores.Clear()
        Try

            Return Dai_Arqueo.GetRes(Fecha)

        Catch Ex As Exception
            Errores.Append("Hubo un error al obtener los datos")
            If (Not Log.GenerarLog(Ex.ToString()) = 1) Then
                Errores.Append(vbLf + "Ocurrio un error al escribir en el Log" + vbLf + "Intentelo de nuevo mas tarde")
            End If
        End Try
        Return 0
    End Function


End Class
