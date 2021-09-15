Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad FacturaCompra'

Public Class Dai_FacturaCompra
    Dim Query As String

    'Devuelve todas las facturas existentes'
    Public Function GetAll()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT FC.*,P.Nombre
                     FROM FACTURACOMPRA FC, Proveedor P
                     WHERE FC.ID_Proveedor = P.ID ;"
            Using CMD As New SqlCommand(Query, Conn)
                Dim ListaFacturas As New List(Of E_FacturaCompra)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While Lector.Read()
                        Dim _Factura As New E_FacturaCompra
                        _Factura.P_ID = Lector("ID")
                        _Factura.P_Estado = Lector("Estado")
                        _Factura.P_Fecha = Lector("Fecha")
                        _Factura.P_ID_Proveedor = Lector("ID_Proveedor")
                        _Factura.P_NombreProveedor = Lector("Nombre")
                        _Factura.P_Tipo = Lector("Tipo")
                        _Factura.P_Total = Lector("Total")
                        ListaFacturas.Add(_Factura)
                    End While
                    Return ListaFacturas
                End Using
            End Using
        End Using
    End Function

    'Inserta una factura de compra'
    Public Sub Insert(ByVal Factura As E_FacturaCompra)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "INSERT INTO FACTURACOMPRA
                     VALUES(@ID_PROVEEDOR,@TOTAL,@TIPO,@FECHA,@ESTADO);"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_PROVEEDOR", Factura.P_ID_Proveedor)
                CMD.Parameters.AddWithValue("@TOTAL", Factura.P_Total)
                CMD.Parameters.AddWithValue("@TIPO", Factura.P_Tipo)
                CMD.Parameters.AddWithValue("@FECHA", Factura.P_Fecha)
                CMD.Parameters.AddWithValue("@ESTADO", Factura.P_Estado)
                CMD.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    'Devuelve la cantidad de facturas que existen'
    Public Function GetLastID()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT MAX(ID_Factura)  FROM FACTURACOMPRA"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function GetFacturasPendientes(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "
                        SELECT T.ID,T.Total,ISNULL(SUM(AB.Cantidad),0) AS MontoPagado, (T.Total- ISNULL(SUM(AB.Cantidad),0) ) AS MontoRestante
                        FROM
	                        (	
		                        SELECT FA.ID,FA.Total
		                        FROM   FACTURACOMPRA FA
		                        WHERE FA.ID = @ID   AND  FA.ESTADO = 'Pendiente'
	                        ) AS T
                        LEFT JOIN AbonoProvedores AB ON T.ID = AB.ID_Factura
                        GROUP BY T.ID,T.Total
                    "
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Dim ListaFacturas As New List(Of E_MontoFactura)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While (Lector.Read)
                        Dim _MontoFactura As New E_MontoFactura
                        _MontoFactura.P_ID_Factura = Lector("ID")
                        _MontoFactura.P_MontoPagado = Lector("MONTOPagado")
                        _MontoFactura.P_MontoRestante = Lector("MONTORestante")
                        _MontoFactura.P_MontoTotal = Lector("TOTAL")
                        ListaFacturas.Add(_MontoFactura)
                    End While
                End Using
                Return ListaFacturas
            End Using
        End Using
    End Function

    Public Function GetAbonosFactura(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = " SELECT * FROM ABONOPROVEDORES
                      WHERE ID_FACTURA = @ID;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Dim ListaAbonos As New List(Of E_AbonoProveedor)
                Dim I = 0
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim Isd = 1
                    While (Lector.Read())
                        Dim _Abono As New E_AbonoProveedor
                        _Abono.P_NumeroAbono = Isd
                        _Abono.P_MontoAbono = Lector("Cantidad")
                        _Abono.P_FechaPago = Lector("Fecha")
                        _Abono.P_Descripcion = Lector("Descripcion")
                        Isd = Isd + 1
                        ListaAbonos.Add(_Abono)
                    End While
                End Using
                Return ListaAbonos
            End Using
        End Using
    End Function

    Public Sub InsertAbono(ByVal Abono As E_AbonoProveedor)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()

            Query = "INSERT INTO AbonoProvedores 
                     VALUES(@ID_FACTURA,@ID_PROVEEDOR,@ID_EMPLEADO,@FECHA,@DESCRIPCION,@CANTIDAD);"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_FACTURA", Abono.P_NumeroFactura)
                CMD.Parameters.AddWithValue("@ID_PROVEEDOR", Abono.P_ID_Proveedor)
                CMD.Parameters.AddWithValue("@ID_EMPLEADO", Abono.P_ID_Empleado)
                CMD.Parameters.AddWithValue("@FECHA", Abono.P_FechaPago)
                CMD.Parameters.AddWithValue("@DESCRIPCION", Abono.P_Descripcion)
                CMD.Parameters.AddWithValue("@CANTIDAD", Abono.P_MontoAbono)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
