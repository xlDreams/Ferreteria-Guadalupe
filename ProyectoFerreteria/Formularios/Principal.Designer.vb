<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.BarControl = New Bunifu.Framework.UI.BunifuCards()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelSecundario = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AnimacionFlecha = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AnimacionPanelSecundario = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tarjetadecontrol = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BarControl.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSecundario.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarControl
        '
        Me.BarControl.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BarControl.BorderRadius = 5
        Me.BarControl.BottomSahddow = True
        Me.BarControl.color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BarControl.Controls.Add(Me.Nombre)
        Me.BarControl.Controls.Add(Me.Label1)
        Me.BarControl.Controls.Add(Me.PictureBox6)
        Me.BarControl.Controls.Add(Me.PictureBox1)
        Me.BarControl.Controls.Add(Me.Label15)
        Me.AnimacionFlecha.SetDecoration(Me.BarControl, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelSecundario.SetDecoration(Me.BarControl, BunifuAnimatorNS.DecorationType.None)
        Me.BarControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BarControl.LeftSahddow = False
        Me.BarControl.Location = New System.Drawing.Point(0, 0)
        Me.BarControl.Name = "BarControl"
        Me.BarControl.RightSahddow = False
        Me.BarControl.ShadowDepth = 20
        Me.BarControl.Size = New System.Drawing.Size(1388, 38)
        Me.BarControl.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nombre.AutoSize = True
        Me.AnimacionPanelSecundario.SetDecoration(Me.Nombre, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.Nombre, BunifuAnimatorNS.DecorationType.None)
        Me.Nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.Color.White
        Me.Nombre.Location = New System.Drawing.Point(1234, 14)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(61, 17)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.AnimacionPanelSecundario.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1068, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Concectado Como:"
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1341, 14)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.AnimacionPanelSecundario.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.AnimacionPanelSecundario.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(46, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ferreteria Guadalupe"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BarControl
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelSecundario
        '
        Me.PanelSecundario.BackColor = System.Drawing.Color.White
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton11)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton10)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton9)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton8)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton7)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton6)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton5)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton4)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton3)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton2)
        Me.PanelSecundario.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelSecundario.Controls.Add(Me.Panel1)
        Me.AnimacionFlecha.SetDecoration(Me.PanelSecundario, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelSecundario.SetDecoration(Me.PanelSecundario, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSecundario.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSecundario.Location = New System.Drawing.Point(0, 38)
        Me.PanelSecundario.Name = "PanelSecundario"
        Me.PanelSecundario.Size = New System.Drawing.Size(50, 750)
        Me.PanelSecundario.TabIndex = 3
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.ButtonText = "    Configuracion"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton11, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton11, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = CType(resources.GetObject("BunifuFlatButton11.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = True
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = True
        Me.BunifuFlatButton11.IconZoom = 100.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(0, 580)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton11.TabIndex = 15
        Me.BunifuFlatButton11.Text = "    Configuracion"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton11, "Configuracion y perfil")
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "    Estadistica"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = CType(resources.GetObject("BunifuFlatButton10.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 85.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(0, 532)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton10.selected = False
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton10.TabIndex = 14
        Me.BunifuFlatButton10.Text = "    Estadistica"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton10, "Configuracion y perfil")
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "    Cliente"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 80.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(0, 484)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton9.TabIndex = 13
        Me.BunifuFlatButton9.Text = "    Cliente"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton9, "Configuracion y perfil")
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "     F Vista"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 65.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(0, 436)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton8.TabIndex = 12
        Me.BunifuFlatButton8.Text = "     F Vista"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton8, "Configuracion y perfil")
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "    F Compra"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 82.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 388)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton7.TabIndex = 11
        Me.BunifuFlatButton7.Text = "    F Compra"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton7, " Estadisticas")
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "    Medida"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 85.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 340)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton6.TabIndex = 10
        Me.BunifuFlatButton6.Text = "    Medida"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton6, "   Media")
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "    Arqueo"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 80.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 292)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton5.TabIndex = 9
        Me.BunifuFlatButton5.Text = "    Arqueo"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton5, "Arqueo")
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "     Proveedores"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 72.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 244)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton4.TabIndex = 8
        Me.BunifuFlatButton4.Text = "     Proveedores"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton4, "Egreso con provedores")
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "     Venta"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 65.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 196)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton3.TabIndex = 7
        Me.BunifuFlatButton3.Text = "     Venta"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton3, "Facturacion")
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "   Inventario"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 148)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton2.TabIndex = 6
        Me.BunifuFlatButton2.Text = "   Inventario"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton2, "Inventario")
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.SteelBlue
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "    DashBoard"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelSecundario.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 75.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 100)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSteelBlue
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(50, 48)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "    DashBoard"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton1, "Pantalla Principal")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.AnimacionFlecha.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelSecundario.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 100)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnimacionPanelSecundario.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'AnimacionFlecha
        '
        Me.AnimacionFlecha.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.AnimacionFlecha.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(50)
        Animation2.RotateCoeff = 1.0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.AnimacionFlecha.DefaultAnimation = Animation2
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Control
        Me.PanelContenedor.Controls.Add(Me.PictureBox3)
        Me.AnimacionFlecha.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelSecundario.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(50, 38)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1338, 750)
        Me.PanelContenedor.TabIndex = 4
        '
        'PictureBox3
        '
        Me.AnimacionPanelSecundario.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'AnimacionPanelSecundario
        '
        Me.AnimacionPanelSecundario.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.AnimacionPanelSecundario.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.AnimacionPanelSecundario.DefaultAnimation = Animation1
        '
        'Tarjetadecontrol
        '
        Me.Tarjetadecontrol.Fixed = True
        Me.Tarjetadecontrol.Horizontal = True
        Me.Tarjetadecontrol.TargetControl = Me.BarControl
        Me.Tarjetadecontrol.Vertical = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1388, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelSecundario)
        Me.Controls.Add(Me.BarControl)
        Me.AnimacionPanelSecundario.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionFlecha.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarControl.ResumeLayout(False)
        Me.BarControl.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSecundario.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarControl As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelSecundario As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AnimacionFlecha As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents AnimacionPanelSecundario As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Tarjetadecontrol As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
End Class
