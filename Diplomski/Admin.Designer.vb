<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.izvestaj = New FontAwesome.Sharp.IconButton()
        Me.musterija = New FontAwesome.Sharp.IconButton()
        Me.porudzbenica = New FontAwesome.Sharp.IconButton()
        Me.odjaviteSe = New FontAwesome.Sharp.IconButton()
        Me.magacin = New FontAwesome.Sharp.IconButton()
        Me.zaposleni = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.izvestaj)
        Me.PanelMenu.Controls.Add(Me.musterija)
        Me.PanelMenu.Controls.Add(Me.porudzbenica)
        Me.PanelMenu.Controls.Add(Me.odjaviteSe)
        Me.PanelMenu.Controls.Add(Me.magacin)
        Me.PanelMenu.Controls.Add(Me.zaposleni)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(190, 545)
        Me.PanelMenu.TabIndex = 0
        '
        'izvestaj
        '
        Me.izvestaj.Dock = System.Windows.Forms.DockStyle.Top
        Me.izvestaj.FlatAppearance.BorderSize = 0
        Me.izvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.izvestaj.ForeColor = System.Drawing.Color.White
        Me.izvestaj.IconChar = FontAwesome.Sharp.IconChar.RankingStar
        Me.izvestaj.IconColor = System.Drawing.Color.White
        Me.izvestaj.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.izvestaj.IconSize = 36
        Me.izvestaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.izvestaj.Location = New System.Drawing.Point(0, 374)
        Me.izvestaj.Name = "izvestaj"
        Me.izvestaj.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.izvestaj.Size = New System.Drawing.Size(190, 60)
        Me.izvestaj.TabIndex = 9
        Me.izvestaj.Text = "Izveštaj"
        Me.izvestaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.izvestaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.izvestaj.UseVisualStyleBackColor = True
        '
        'musterija
        '
        Me.musterija.Dock = System.Windows.Forms.DockStyle.Top
        Me.musterija.FlatAppearance.BorderSize = 0
        Me.musterija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.musterija.ForeColor = System.Drawing.Color.White
        Me.musterija.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.musterija.IconColor = System.Drawing.Color.White
        Me.musterija.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.musterija.IconSize = 36
        Me.musterija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.musterija.Location = New System.Drawing.Point(0, 314)
        Me.musterija.Name = "musterija"
        Me.musterija.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.musterija.Size = New System.Drawing.Size(190, 60)
        Me.musterija.TabIndex = 8
        Me.musterija.Text = "Mušterije"
        Me.musterija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.musterija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.musterija.UseVisualStyleBackColor = True
        '
        'porudzbenica
        '
        Me.porudzbenica.Dock = System.Windows.Forms.DockStyle.Top
        Me.porudzbenica.FlatAppearance.BorderSize = 0
        Me.porudzbenica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.porudzbenica.ForeColor = System.Drawing.Color.White
        Me.porudzbenica.IconChar = FontAwesome.Sharp.IconChar.File
        Me.porudzbenica.IconColor = System.Drawing.Color.White
        Me.porudzbenica.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.porudzbenica.IconSize = 36
        Me.porudzbenica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.porudzbenica.Location = New System.Drawing.Point(0, 254)
        Me.porudzbenica.Name = "porudzbenica"
        Me.porudzbenica.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.porudzbenica.Size = New System.Drawing.Size(190, 60)
        Me.porudzbenica.TabIndex = 7
        Me.porudzbenica.Text = "Porudžbenice"
        Me.porudzbenica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.porudzbenica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.porudzbenica.UseVisualStyleBackColor = True
        '
        'odjaviteSe
        '
        Me.odjaviteSe.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.odjaviteSe.FlatAppearance.BorderSize = 0
        Me.odjaviteSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odjaviteSe.ForeColor = System.Drawing.Color.White
        Me.odjaviteSe.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        Me.odjaviteSe.IconColor = System.Drawing.Color.White
        Me.odjaviteSe.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.odjaviteSe.IconSize = 36
        Me.odjaviteSe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.odjaviteSe.Location = New System.Drawing.Point(0, 485)
        Me.odjaviteSe.Name = "odjaviteSe"
        Me.odjaviteSe.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.odjaviteSe.Size = New System.Drawing.Size(190, 60)
        Me.odjaviteSe.TabIndex = 5
        Me.odjaviteSe.Text = "Odjavite se"
        Me.odjaviteSe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.odjaviteSe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.odjaviteSe.UseVisualStyleBackColor = True
        '
        'magacin
        '
        Me.magacin.Dock = System.Windows.Forms.DockStyle.Top
        Me.magacin.FlatAppearance.BorderSize = 0
        Me.magacin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.magacin.ForeColor = System.Drawing.Color.White
        Me.magacin.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.magacin.IconColor = System.Drawing.Color.White
        Me.magacin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.magacin.IconSize = 36
        Me.magacin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.magacin.Location = New System.Drawing.Point(0, 194)
        Me.magacin.Name = "magacin"
        Me.magacin.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.magacin.Size = New System.Drawing.Size(190, 60)
        Me.magacin.TabIndex = 2
        Me.magacin.Text = "Artikli"
        Me.magacin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.magacin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.magacin.UseVisualStyleBackColor = True
        '
        'zaposleni
        '
        Me.zaposleni.Dock = System.Windows.Forms.DockStyle.Top
        Me.zaposleni.FlatAppearance.BorderSize = 0
        Me.zaposleni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zaposleni.ForeColor = System.Drawing.Color.White
        Me.zaposleni.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.zaposleni.IconColor = System.Drawing.Color.White
        Me.zaposleni.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.zaposleni.IconSize = 36
        Me.zaposleni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.zaposleni.Location = New System.Drawing.Point(0, 134)
        Me.zaposleni.Name = "zaposleni"
        Me.zaposleni.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.zaposleni.Size = New System.Drawing.Size(190, 60)
        Me.zaposleni.TabIndex = 1
        Me.zaposleni.Text = "Zaposleni"
        Me.zaposleni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.zaposleni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.zaposleni.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(190, 134)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblFormTitle)
        Me.Panel2.Controls.Add(Me.IconCurrentForm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(190, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 54)
        Me.Panel2.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(44, 21)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(35, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(190, 54)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(938, 491)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(304, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(313, 231)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1128, 545)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents magacin As FontAwesome.Sharp.IconButton
    Friend WithEvents zaposleni As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents odjaviteSe As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents musterija As FontAwesome.Sharp.IconButton
    Friend WithEvents porudzbenica As FontAwesome.Sharp.IconButton
    Friend WithEvents izvestaj As FontAwesome.Sharp.IconButton
End Class
