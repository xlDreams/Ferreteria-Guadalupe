Imports System.Data.SqlClient

'Operaciones CRUD con la entidad Estadistica'
Public Class Dai_Estadistica
    Dim Query As String


    'Devuelve la cantidad de proveedores que existen'
    Public Function GetEstadisticaProveedor()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM PROVEEDOR"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    'Devuelve la cantidad de clientes que existen'
    Public Function GetEstadisticaCliente()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM CLIENTE"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    'Devuelve la cantidad de productos existentes'
    Public Function GetEstadisticaProducto()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM PRODUCTO"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    'Devuelve la cantidad de empleados existentes'
    Public Function GetEstadisticaEmpleado()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT COUNT(*) FROM EMPLEADO"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    'Devuelve las ganancia de un dia'
    Public Function GetEstadisticaGananciaDia(ByVal Dia As Date)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT SUM(ABS((DESCUENTO / 100 -1)  * SUBTOTAL)) 
                     FROM FACTURAVENTA
                     WHERE FECHA = @FECHA;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@FECHA", Dia.Year.ToString() + "-" + Dia.Month.ToString() + "-" + Dia.Day.ToString())
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function



    'Devuelve EL TOTAL DE VENTA DE FACTURAS PARA EL ARQUEO'


    'Devuelve las ganancia mensual'
    Public Function GetEstadisticaGananciaMensual(ByVal Dia As Date)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT SUM(ABS((DESCUENTO / 100 -1)  * SUBTOTAL)) 
                     FROM FACTURAVENTA
                     WHERE MONTH(FECHA) = @MES AND YEAR(FECHA) = @AÑO;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@MES", Dia.Month.ToString())
                CMD.Parameters.AddWithValue("@AÑO", Dia.Year.ToString())
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    'Devuelve las ganancia de un año'
    Public Function GetEstadisticaGananciaAño(ByVal Dia As Date)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT SUM(ABS((DESCUENTO / 100 -1)  * SUBTOTAL)) 
                     FROM FACTURAVENTA
	                 WHERE YEAR(FECHA) = @AÑO;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@AÑO", Dia.Year)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

End Class
