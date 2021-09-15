<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.bunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tarjetadecontrol = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.mensaje = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'bunifuCustomLabel1
        '
        Me.bunifuCustomLabel1.AutoSize = True
        Me.bunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.bunifuCustomLabel1.Location = New System.Drawing.Point(126, 121)
        Me.bunifuCustomLabel1.Name = "bunifuCustomLabel1"
        Me.bunifuCustomLabel1.Size = New System.Drawing.Size(161, 20)
        Me.bunifuCustomLabel1.TabIndex = 9
        Me.bunifuCustomLabel1.Text = "Ferreteria Guadalupe"
        '
        'bunifuFlatButton1
        '
        Me.bunifuFlatButton1.Activecolor = System.Drawing.Color.SlateBlue
        Me.bunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton1.BorderRadius = 6
        Me.bunifuFlatButton1.ButtonText = "Iniciar Sesion"
        Me.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton1.Iconimage = Nothing
        Me.bunifuFlatButton1.Iconimage_right = CType(resources.GetObject("bunifuFlatButton1.Iconimage_right"), System.Drawing.Image)
        Me.bunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton1.Iconimage_Selected = Nothing
        Me.bunifuFlatButton1.IconMarginLeft = 0
        Me.bunifuFlatButton1.IconMarginRight = 0
        Me.bunifuFlatButton1.IconRightVisible = True
        Me.bunifuFlatButton1.IconRightZoom = 0R
        Me.bunifuFlatButton1.IconVisible = True
        Me.bunifuFlatButton1.IconZoom = 90.0R
        Me.bunifuFlatButton1.IsTab = False
        Me.bunifuFlatButton1.Location = New System.Drawing.Point(255, 286)
        Me.bunifuFlatButton1.Name = "bunifuFlatButton1"
        Me.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.RoyalBlue
        Me.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuFlatButton1.selected = False
        Me.bunifuFlatButton1.Size = New System.Drawing.Size(145, 48)
        Me.bunifuFlatButton1.TabIndex = 7
        Me.bunifuFlatButton1.Text = "Iniciar Sesion"
        Me.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(160, 32)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(98, 84)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 8
        Me.pictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.bunifuMaterialTextbox2)
        Me.groupBox1.Controls.Add(Me.bunifuMaterialTextbox1)
        Me.groupBox1.Location = New System.Drawing.Point(47, 144)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(311, 136)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        '
        'bunifuMaterialTextbox2
        '
        Me.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.White
        Me.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.bunifuMaterialTextbox2.HintText = "Contraseña"
        Me.bunifuMaterialTextbox2.isPassword = False
        Me.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.RoyalBlue
        Me.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.DodgerBlue
        Me.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.bunifuMaterialTextbox2.LineThickness = 3
        Me.bunifuMaterialTextbox2.Location = New System.Drawing.Point(48, 72)
        Me.bunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2"
        Me.bunifuMaterialTextbox2.Size = New System.Drawing.Size(218, 33)
        Me.bunifuMaterialTextbox2.TabIndex = 3
        Me.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuMaterialTextbox1
        '
        Me.bunifuMaterialTextbox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.White
        Me.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.bunifuMaterialTextbox1.HintText = "Usuario"
        Me.bunifuMaterialTextbox1.isPassword = False
        Me.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.RoyalBlue
        Me.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DodgerBlue
        Me.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.RoyalBlue
        Me.bunifuMaterialTextbox1.LineThickness = 3
        Me.bunifuMaterialTextbox1.Location = New System.Drawing.Point(48, 31)
        Me.bunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1"
        Me.bunifuMaterialTextbox1.Size = New System.Drawing.Size(218, 33)
        Me.bunifuMaterialTextbox1.TabIndex = 2
        Me.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(378, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 26)
        Me.Panel1.TabIndex = 11
        '
        'Tarjetadecontrol
        '
        Me.Tarjetadecontrol.Fixed = True
        Me.Tarjetadecontrol.Horizontal = True
        Me.Tarjetadecontrol.TargetControl = Me.Panel1
        Me.Tarjetadecontrol.Vertical = True
        '
        'mensaje
        '
        Me.mensaje.AutoSize = True
        Me.mensaje.Location = New System.Drawing.Point(24, 301)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(0, 13)
        Me.mensaje.TabIndex = 12
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.mensaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bunifuCustomLabel1)
        Me.Controls.Add(Me.bunifuFlatButton1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents bunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents bunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents bunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Private WithEvents bunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tarjetadecontrol As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents mensaje As Label
End Class
