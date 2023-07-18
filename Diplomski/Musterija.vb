Imports System.Data.SqlClient
Imports FontAwesome.Sharp
Public Class Musterijaa
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleRight
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    'otvaranje vise formi u okviru jedne
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    'meni dugmici
    Private Sub magacin_Click(sender As Object, e As EventArgs) Handles magacin.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New Klime)
    End Sub

    Private Sub delovi_Click(sender As Object, e As EventArgs) Handles porudzbenica.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New Delovi)
    End Sub

    Private Sub porudzbenica_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New Porudzbenice)
    End Sub

    Private Sub odjaviteSe_Click(sender As Object, e As EventArgs) Handles odjaviteSe.Click
        Dim result As Integer
        result = MessageBox.Show("Da li želite da se odjavite?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            LogIn.Show()
        Else
            ' Korisnik klikne No nema akcije
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.White
        lblFormTitle.Text = "Home"
    End Sub

    Private Sub Musterijaa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
End Class