Imports System.Data.SqlClient
Imports Ferreteria___Entidades

'Operaciones CRUD con la entidad Empleado'

Public Class Dai_FacturaVenta
    Dim Query As String



    'Inserta una factura de venta'
    Public Sub Insert(ByVal Factura As E_FacturaVenta, ByVal Lineas As List(Of E_DetalleFactura))
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Dim Transaccion As SqlTransaction
            Transaccion = Conn.BeginTransaction("Transaccion")
            Try
                Query = "INSERT INTO FACTURAVENTA 
                     VALUES(@SUBTOTAL,@DESCUENTO,@ESTADO,@TIPO,@ID_CLIENTE,@ID_EMPLEADO,@FECHA,@BANDERA_ANULACION,@MOTIVO_ANULACION);"
                Using CMD As New SqlCommand(Query, Conn)
                    CMD.Transaction = Transaccion
                    CMD.Parameters.AddWithValue("@SUBTOTAL", Factura.P_SubTotal)
                    CMD.Parameters.AddWithValue("@DESCUENTO", Factura.P_Descuento)
                    CMD.Parameters.AddWithValue("@ESTADO", Factura.P_Estado)
                    CMD.Parameters.AddWithValue("@TIPO", Factura.P_Tipo)
                    CMD.Parameters.AddWithValue("@ID_CLIENTE", Factura.P_ID_Cliente)
                    CMD.Parameters.AddWithValue("@ID_EMPLEADO", Factura.P_ID_Empleado)
                    CMD.Parameters.AddWithValue("@FECHA", Factura.P_Fecha)
                    CMD.Parameters.AddWithValue("@BANDERA_ANULACION", Factura.P_Bandera_Anulacion)
                    CMD.Parameters.AddWithValue("@MOTIVO_ANULACION", Factura.P_Motivo_Anulacion)
                    CMD.ExecuteNonQuery()
                    Query = "INSERT INTO DETALLEFACTURA 
                         VALUES(@ID_FACTURA,@N_LINEA,@CANTIDAD,@ID_PRODUCTO,@PRECIO);"
                    CMD.CommandText = Query
                    For I As Integer = 0 To Lineas.Count() - 1 Step 1
                        CMD.Parameters.Clear()
                        CMD.Parameters.AddWithValue("@ID_FACTURA", Lineas(I).P_ID_Factura)
                        CMD.Parameters.AddWithValue("@N_LINEA", (I + 1).ToString())
                        CMD.Parameters.AddWithValue("@CANTIDAD", Lineas(I).P_Cantidad)
                        CMD.Parameters.AddWithValue("@ID_PRODUCTO", Lineas(I).P_ID_Producto)
                        CMD.Parameters.AddWithValue("@PRECIO", Lineas(I).P_Precio)
                        CMD.ExecuteNonQuery()
                    Next
                    Transaccion.Commit()
                End Using
            Catch Ex As SqlException
                Transaccion.Rollback()
                Throw New ArgumentException("Error al efectuar factura : " + Ex.ToString())
            End Try
        End Using

    End Sub

    'Devuelve la cantidad de facturas que existen'
    Public Function GetLastID()
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "SELECT MAX(ID_Factura)  FROM FACTURAVENTA"
            Using CMD As New SqlCommand(Query, Conn)
                Return CMD.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function GetFacturasPendientes(ByVal ID As Integer)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()
            Query = "
                        SELECT T.ID_Factura,T.SubTotal,ISNULL(SUM(AB.Cantidad),0) AS MontoPagado, (T.SubTotal- ISNULL(SUM(AB.Cantidad),0) ) AS MontoRestante
                        FROM
	                        (	
		                        SELECT FA.ID_Factura,FA.SubTotal
		                        FROM   FACTURAVENTA FA
		                        WHERE FA.ID_Cliente = @ID  AND  FA.ESTADO = 'Pendiente' AND FA.Bandera_Anulacion = 0 
	                        ) AS T
                        LEFT JOIN AbonoCliente AB ON T.ID_Factura = AB.ID_Factura
                        GROUP BY T.ID_Factura,T.SubTotal
                    "
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Dim ListaFacturas As New List(Of E_MontoFactura)
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    While (Lector.Read)
                        Dim _MontoFactura As New E_MontoFactura
                        _MontoFactura.P_ID_Factura = Lector("ID_FACTURA")
                        _MontoFactura.P_MontoPagado = Lector("MONTOPagado")
                        _MontoFactura.P_MontoRestante = Lector("MONTORestante")
                        _MontoFactura.P_MontoTotal = Lector("SubTotal")
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
            Query = " SELECT * FROM ABONOCLIENTE
                      WHERE ID_FACTURA = @ID;"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID", ID)
                Dim ListaAbonos As New List(Of E_AbonoCliente)
                Dim I = 0
                Using Lector As SqlDataReader = CMD.ExecuteReader()
                    Dim Isd = 1
                    While (Lector.Read())
                        Dim _Abono As New E_AbonoCliente
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

    Public Sub InsertAbono(ByVal Abono As E_AbonoCliente)
        Using Conn As New SqlConnection(My.Resources.CadenaConexion)
            Conn.Open()

            Query = "INSERT INTO AbonoCliente 
                     VALUES(@ID_FACTURA,@ID_CLIENTE,@ID_EMPLEADO,@FECHA,@DESCRIPCION,@CANTIDAD);"
            Using CMD As New SqlCommand(Query, Conn)
                CMD.Parameters.AddWithValue("@ID_FACTURA", Abono.P_NumeroFactura)
                CMD.Parameters.AddWithValue("@ID_CLIENTE", Abono.P_ID_Cliente)
                CMD.Parameters.AddWithValue("@ID_EMPLEADO", Abono.P_ID_Empleado)
                CMD.Parameters.AddWithValue("@FECHA", Abono.P_FechaPago)
                CMD.Parameters.AddWithValue("@DESCRIPCION", Abono.P_Descripcion)
                CMD.Parameters.AddWithValue("@CANTIDAD", Abono.P_MontoAbono)
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class
