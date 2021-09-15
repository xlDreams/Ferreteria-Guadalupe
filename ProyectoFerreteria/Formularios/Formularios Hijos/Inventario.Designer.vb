<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupDataGrid = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.FiltrarBoton = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBoxBusqueda = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad_M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Elim = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EditarButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ProveedorCombo = New System.Windows.Forms.ComboBox()
        Me.VentaBox = New System.Windows.Forms.NumericUpDown()
        Me.CompraBox = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CategoriaCombo = New System.Windows.Forms.ComboBox()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ExistenciaDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MaxStockDown2 = New System.Windows.Forms.NumericUpDown()
        Me.MinStockDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Porcentaje = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MedidaCombo = New System.Windows.Forms.ComboBox()
        Me.DescripcionBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Marcabox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupDataGrid.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridINVENTARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExistenciaDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxStockDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinStockDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1307, 45)
        Me.Panel2.TabIndex = 68
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Actualizar"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(1102, 10)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.SlateBlue
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.MediumPurple
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(138, 29)
        Me.BunifuFlatButton2.TabIndex = 50
        Me.BunifuFlatButton2.Text = "Actualizar"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(57, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 22
        Me.PictureBox7.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(153, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Inventario"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GroupDataGrid)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1307, 733)
        Me.Panel1.TabIndex = 69
        '
        'GroupDataGrid
        '
        Me.GroupDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupDataGrid.BackColor = System.Drawing.Color.White
        Me.GroupDataGrid.Controls.Add(Me.Label13)
        Me.GroupDataGrid.Controls.Add(Me.VScrollBar1)
        Me.GroupDataGrid.Controls.Add(Me.FiltrarBoton)
        Me.GroupDataGrid.Controls.Add(Me.Label17)
        Me.GroupDataGrid.Controls.Add(Me.ComboBoxBusqueda)
        Me.GroupDataGrid.Controls.Add(Me.label1)
        Me.GroupDataGrid.Controls.Add(Me.PictureBox2)
        Me.GroupDataGrid.Controls.Add(Me.Label3)
        Me.GroupDataGrid.Controls.Add(Me.DataGridINVENTARIO)
        Me.GroupDataGrid.Controls.Add(Me.TextBoxBusqueda)
        Me.GroupDataGrid.Location = New System.Drawing.Point(411, 24)
        Me.GroupDataGrid.Name = "GroupDataGrid"
        Me.GroupDataGrid.Size = New System.Drawing.Size(838, 677)
        Me.GroupDataGrid.TabIndex = 10
        Me.GroupDataGrid.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Salmon
        Me.Label13.Location = New System.Drawing.Point(396, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 18)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "No hay Resultados"
        Me.Label13.Visible = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VScrollBar1.Location = New System.Drawing.Point(814, 84)
        Me.VScrollBar1.Maximum = 200
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 522)
        Me.VScrollBar1.TabIndex = 68
        '
        'FiltrarBoton
        '
        Me.FiltrarBoton.Location = New System.Drawing.Point(671, 55)
        Me.FiltrarBoton.Name = "FiltrarBoton"
        Me.FiltrarBoton.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarBoton.TabIndex = 67
        Me.FiltrarBoton.Text = "Filtrar"
        Me.FiltrarBoton.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(396, 294)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 18)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Cargando..."
        '
        'ComboBoxBusqueda
        '
        Me.ComboBoxBusqueda.BackColor = System.Drawing.Color.LemonChiffon
        Me.ComboBoxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBusqueda.FormattingEnabled = True
        Me.ComboBoxBusqueda.Items.AddRange(New Object() {"Codigo", "Marca", "Descripcion", "Todo"})
        Me.ComboBoxBusqueda.Location = New System.Drawing.Point(243, 55)
        Me.ComboBoxBusqueda.Name = "ComboBoxBusqueda"
        Me.ComboBoxBusqueda.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBusqueda.TabIndex = 32
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.LightCoral
        Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(273, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(277, 26)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Informacion del Producto"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox2.Location = New System.Drawing.Point(2, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(835, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(99, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Busqueda Por:"
        '
        'DataGridINVENTARIO
        '
        Me.DataGridINVENTARIO.AllowUserToAddRows = False
        Me.DataGridINVENTARIO.AllowUserToDeleteRows = False
        Me.DataGridINVENTARIO.AllowUserToOrderColumns = True
        Me.DataGridINVENTARIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridINVENTARIO.BackgroundColor = System.Drawing.Color.White
        Me.DataGridINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridINVENTARIO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Marca, Me.Descripcion, Me.Categoria, Me.Stock_Min, Me.Stock_Max, Me.Existencia, Me.Unidad_M, Me.Precio_C, Me.Precio_Venta, Me.Fecha_Ing, Me.Proveedor_ID, Me.Edit, Me.Elim})
        Me.DataGridINVENTARIO.Location = New System.Drawing.Point(6, 84)
        Me.DataGridINVENTARIO.Name = "DataGridINVENTARIO"
        Me.DataGridINVENTARIO.Size = New System.Drawing.Size(826, 522)
        Me.DataGridINVENTARIO.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 80
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 250
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Stock_Min
        '
        Me.Stock_Min.HeaderText = "Stock Minimo"
        Me.Stock_Min.Name = "Stock_Min"
        Me.Stock_Min.Width = 60
        '
        'Stock_Max
        '
        Me.Stock_Max.HeaderText = "Stock Maximo"
        Me.Stock_Max.Name = "Stock_Max"
        Me.Stock_Max.Width = 60
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Existencia Actual"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Width = 60
        '
        'Unidad_M
        '
        Me.Unidad_M.HeaderText = "Unidad de medida"
        Me.Unidad_M.Name = "Unidad_M"
        '
        'Precio_C
        '
        Me.Precio_C.HeaderText = "Precio de compra"
        Me.Precio_C.Name = "Precio_C"
        '
        'Precio_Venta
        '
        Me.Precio_Venta.HeaderText = "Precio de venta"
        Me.Precio_Venta.Name = "Precio_Venta"
        '
        'Fecha_Ing
        '
        Me.Fecha_Ing.HeaderText = "Fecha Ingreso"
        Me.Fecha_Ing.Name = "Fecha_Ing"
        '
        'Proveedor_ID
        '
        Me.Proveedor_ID.HeaderText = "Proveedor"
        Me.Proveedor_ID.Name = "Proveedor_ID"
        '
        'Edit
        '
        Me.Edit.HeaderText = "Acción 1"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Editar"
        '
        'Elim
        '
        Me.Elim.HeaderText = "Acción 2"
        Me.Elim.Name = "Elim"
        Me.Elim.Text = "Eliminar"
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(379, 55)
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxBusqueda.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.EditarButton)
        Me.GroupBox1.Controls.Add(Me.ProveedorCombo)
        Me.GroupBox1.Controls.Add(Me.VentaBox)
        Me.GroupBox1.Controls.Add(Me.CompraBox)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CategoriaCombo)
        Me.GroupBox1.Controls.Add(Me.IDBox)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ExistenciaDown1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.MaxStockDown2)
        Me.GroupBox1.Controls.Add(Me.MinStockDown1)
        Me.GroupBox1.Controls.Add(Me.Porcentaje)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MedidaCombo)
        Me.GroupBox1.Controls.Add(Me.DescripcionBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Marcabox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.pictureBox8)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 678)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'EditarButton
        '
        Me.EditarButton.Activecolor = System.Drawing.Color.Tomato
        Me.EditarButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditarButton.BackColor = System.Drawing.Color.Salmon
        Me.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditarButton.BorderRadius = 0
        Me.EditarButton.ButtonText = "                        Editar"
        Me.EditarButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditarButton.DisabledColor = System.Drawing.Color.Gray
        Me.EditarButton.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButton.Iconcolor = System.Drawing.Color.Transparent
        Me.EditarButton.Iconimage = CType(resources.GetObject("EditarButton.Iconimage"), System.Drawing.Image)
        Me.EditarButton.Iconimage_right = Nothing
        Me.EditarButton.Iconimage_right_Selected = Nothing
        Me.EditarButton.Iconimage_Selected = Nothing
        Me.EditarButton.IconMarginLeft = 0
        Me.EditarButton.IconMarginRight = 0
        Me.EditarButton.IconRightVisible = False
        Me.EditarButton.IconRightZoom = 0R
        Me.EditarButton.IconVisible = False
        Me.EditarButton.IconZoom = 50.0R
        Me.EditarButton.IsTab = False
        Me.EditarButton.Location = New System.Drawing.Point(46, 503)
        Me.EditarButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.EditarButton.Name = "EditarButton"
        Me.EditarButton.Normalcolor = System.Drawing.Color.Salmon
        Me.EditarButton.OnHovercolor = System.Drawing.Color.Coral
        Me.EditarButton.OnHoverTextColor = System.Drawing.Color.White
        Me.EditarButton.selected = False
        Me.EditarButton.Size = New System.Drawing.Size(281, 55)
        Me.EditarButton.TabIndex = 66
        Me.EditarButton.Text = "                        Editar"
        Me.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditarButton.Textcolor = System.Drawing.Color.White
        Me.EditarButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarButton.Visible = False
        '
        'ProveedorCombo
        '
        Me.ProveedorCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProveedorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProveedorCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProveedorCombo.FormattingEnabled = True
        Me.ProveedorCombo.Items.AddRange(New Object() {"Cargando..."})
        Me.ProveedorCombo.Location = New System.Drawing.Point(143, 398)
        Me.ProveedorCombo.Name = "ProveedorCombo"
        Me.ProveedorCombo.Size = New System.Drawing.Size(217, 21)
        Me.ProveedorCombo.TabIndex = 65
        '
        'VentaBox
        '
        Me.VentaBox.DecimalPlaces = 2
        Me.VentaBox.Location = New System.Drawing.Point(144, 340)
        Me.VentaBox.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.VentaBox.Name = "VentaBox"
        Me.VentaBox.Size = New System.Drawing.Size(216, 20)
        Me.VentaBox.TabIndex = 64
        '
        'CompraBox
        '
        Me.CompraBox.DecimalPlaces = 2
        Me.CompraBox.Location = New System.Drawing.Point(143, 313)
        Me.CompraBox.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.CompraBox.Name = "CompraBox"
        Me.CompraBox.Size = New System.Drawing.Size(76, 20)
        Me.CompraBox.TabIndex = 63
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 369)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 62
        '
        'CategoriaCombo
        '
        Me.CategoriaCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CategoriaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriaCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CategoriaCombo.FormattingEnabled = True
        Me.CategoriaCombo.Items.AddRange(New Object() {"Carpintería", "Construcción", "Eléctricidad", "Hogar", "Máquina y herramientas"})
        Me.CategoriaCombo.Location = New System.Drawing.Point(143, 193)
        Me.CategoriaCombo.Name = "CategoriaCombo"
        Me.CategoriaCombo.Size = New System.Drawing.Size(218, 21)
        Me.CategoriaCombo.TabIndex = 61
        '
        'IDBox
        '
        Me.IDBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IDBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDBox.Location = New System.Drawing.Point(144, 55)
        Me.IDBox.MaxLength = 15
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(217, 20)
        Me.IDBox.TabIndex = 60
        Me.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Location = New System.Drawing.Point(15, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 18)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(16, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 18)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Proveedor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(15, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Existencia"
        '
        'ExistenciaDown1
        '
        Me.ExistenciaDown1.Location = New System.Drawing.Point(143, 250)
        Me.ExistenciaDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.ExistenciaDown1.Name = "ExistenciaDown1"
        Me.ExistenciaDown1.Size = New System.Drawing.Size(217, 20)
        Me.ExistenciaDown1.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(14, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 18)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Stock Min / Max"
        '
        'MaxStockDown2
        '
        Me.MaxStockDown2.Location = New System.Drawing.Point(263, 220)
        Me.MaxStockDown2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.MaxStockDown2.Name = "MaxStockDown2"
        Me.MaxStockDown2.Size = New System.Drawing.Size(97, 20)
        Me.MaxStockDown2.TabIndex = 52
        '
        'MinStockDown1
        '
        Me.MinStockDown1.Location = New System.Drawing.Point(143, 220)
        Me.MinStockDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.MinStockDown1.Name = "MinStockDown1"
        Me.MinStockDown1.Size = New System.Drawing.Size(96, 20)
        Me.MinStockDown1.TabIndex = 51
        '
        'Porcentaje
        '
        Me.Porcentaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Porcentaje.Location = New System.Drawing.Point(229, 313)
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.Size = New System.Drawing.Size(73, 20)
        Me.Porcentaje.TabIndex = 46
        Me.Porcentaje.Text = "15"
        Me.Porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(308, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Aplicar %"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(15, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 18)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Venta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(15, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Compra:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(18, 369)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha:"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Tomato
        Me.BunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Salmon
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "                        Agregar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(46, 503)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Salmon
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Coral
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(281, 55)
        Me.BunifuFlatButton1.TabIndex = 38
        Me.BunifuFlatButton1.Text = "                        Agregar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(12, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Categoría:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(15, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Medida:"
        '
        'MedidaCombo
        '
        Me.MedidaCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MedidaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedidaCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MedidaCombo.FormattingEnabled = True
        Me.MedidaCombo.Items.AddRange(New Object() {"Cargando..."})
        Me.MedidaCombo.Location = New System.Drawing.Point(143, 280)
        Me.MedidaCombo.Name = "MedidaCombo"
        Me.MedidaCombo.Size = New System.Drawing.Size(217, 21)
        Me.MedidaCombo.TabIndex = 32
        '
        'DescripcionBox
        '
        Me.DescripcionBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DescripcionBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionBox.Location = New System.Drawing.Point(144, 114)
        Me.DescripcionBox.MaxLength = 100
        Me.DescripcionBox.Multiline = True
        Me.DescripcionBox.Name = "DescripcionBox"
        Me.DescripcionBox.Size = New System.Drawing.Size(217, 71)
        Me.DescripcionBox.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(14, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Marca :"
        '
        'Marcabox
        '
        Me.Marcabox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Marcabox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Marcabox.Location = New System.Drawing.Point(144, 88)
        Me.Marcabox.MaxLength = 15
        Me.Marcabox.Name = "Marcabox"
        Me.Marcabox.Size = New System.Drawing.Size(217, 20)
        Me.Marcabox.TabIndex = 28
        Me.Marcabox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightCoral
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(87, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 26)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Agregar Producto"
        '
        'pictureBox8
        '
        Me.pictureBox8.BackColor = System.Drawing.Color.LightCoral
        Me.pictureBox8.Location = New System.Drawing.Point(1, 7)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(366, 29)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox8.TabIndex = 27
        Me.pictureBox8.TabStop = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1307, 778)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupDataGrid.ResumeLayout(False)
        Me.GroupDataGrid.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridINVENTARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentaBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExistenciaDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxStockDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinStockDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label5 As Label
    Private WithEvents pictureBox8 As PictureBox
    Friend WithEvents GroupDataGrid As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents Label3 As Label
    Friend WithEvents DataGridINVENTARIO As DataGridView
    Friend WithEvents TextBoxBusqueda As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents Marcabox As TextBox
    Friend WithEvents DescripcionBox As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents MedidaCombo As ComboBox
    Private WithEvents Label7 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents Label11 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Porcentaje As TextBox
    Friend WithEvents ComboBoxBusqueda As ComboBox
    Private WithEvents Label8 As Label
    Friend WithEvents ExistenciaDown1 As NumericUpDown
    Private WithEvents Label12 As Label
    Friend WithEvents MaxStockDown2 As NumericUpDown
    Friend WithEvents MinStockDown1 As NumericUpDown
    Private WithEvents Label14 As Label
    Private WithEvents Label16 As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents CategoriaCombo As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents VentaBox As NumericUpDown
    Friend WithEvents CompraBox As NumericUpDown
    Friend WithEvents ProveedorCombo As ComboBox
    Private WithEvents Label17 As Label
    Friend WithEvents EditarButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents FiltrarBoton As Button
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Min As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Max As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents Unidad_M As DataGridViewTextBoxColumn
    Friend WithEvents Precio_C As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Ing As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor_ID As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Elim As DataGridViewButtonColumn
    Friend WithEvents VScrollBar1 As VScrollBar
    Private WithEvents Label13 As Label
End Class
