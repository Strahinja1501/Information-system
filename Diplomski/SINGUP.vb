Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SINGUP
    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub SINGUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim Sql As String = "Select * FROM KORISNIK"
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()
        Connection.Open()
        DataAdapter.Fill(DS, "ZAPOSLENI")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then
            Dim insertQuery As String = "INSERT INTO KORISNIK (IME_KORISNIKA,PREZIME_KORISNIKA,MAIL_KORISNIKA,BROJ_TELEFONA_KORISNIKA,ADRESA_KORISNIKA,USERNAME,PASSWORD,ZAPOSLEN) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            ExecuteQuery(insertQuery)
            MessageBox.Show("Uspešno ste se registrovali", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            LogIn.Show()
        Else
            MessageBox.Show("Sva polja moraju biti popunjena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'Dim insertQuery As String = "INSERT INTO KORISNIK (IME_KORISNIKA,PREZIME_KORISNIKA,MAIL_KORISNIKA,BROJ_TELEFONA_KORISNIKA,ADRESA_KORISNIKA,USERNAME,PASSWORD) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"

        'ExecuteQuery(insertQuery)

        'MessageBox.Show("You have beed Sing Up", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Me.Close()
        'LogIn.Show()

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "@" AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "_" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        If Not TextBox3.Text.Contains("@") Then
            MessageBox.Show("Molimo unesite validnu e-poštu.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

End Class