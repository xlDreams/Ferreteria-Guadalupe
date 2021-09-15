
' Esta clase se encarga de generar los logs de errores'
Imports System.IO

Public Class Log

    'Este metodo escribe en el log, Si no existe lo crear de lo contrario solo escribe encima de el'

    'Valores de retorno : '
    '  1 -> Se escribio con exito en el Log'
    ' -1 -> Ocurrio un error al escribir en el log '

    Public Shared Function GenerarLog(ByVal ErrorTxt As String)
        Try
            'Obtenemos la ruta donde se ejecuta el programa'
            Dim RutaLog As String = "Errores.txt"
            'Si el archivo no existe lo creamos'
            If (Not System.IO.File.Exists(RutaLog)) Then
                System.IO.File.Create(RutaLog).Dispose()
            End If

            'Escribimos el Error en el log'
            Dim Stream As StreamWriter
            Stream = File.AppendText(RutaLog)
            Stream.Write("[" + Date.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]" + "  " + ErrorTxt + vbNewLine)
            Stream.Flush()
            Stream.Close()
            Return 1
        Catch ExWrite As Exception
            Return -1
        End Try
    End Function


End Class
