Imports System.Data
Imports System.Data.SqlClient
Imports System.Web
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LogIn
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim conn As New SqlConnection(connString)
        Dim cmd As New SqlCommand("SELECT * FROM KORISNIK WHERE USERNAME = @Username AND PASSWORD = @Password", conn)

        cmd.Parameters.AddWithValue("@Username", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

        Try
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                GlobalVariables.ID_KORISNIKA = reader("ID_KORISNIKA")
                If reader("ZAPOSLEN") = "Da" Then
                    Dim adminForm As New Admin()
                    adminForm.Show()
                    Me.Hide()
                Else
                    Dim customerForm As New Musterijaa()
                    customerForm.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Pogrešan Username ili Password", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        SINGUP.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.BackColor = Color.DodgerBlue
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.White
        Label4.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class
