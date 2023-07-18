Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Controls
Imports FontAwesome.Sharp

Public Class Zaposleni

    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim Sql As String = "Select * FROM KORISNIK WHERE ZAPOSLEN <> 'Ne'"
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()
        Connection.Open()
        DataAdapter.Fill(DS, "KORISNIK")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "KORISNIK"
        DataGridView1.Columns(9).Visible = False

        DataGridView1.Columns(2).Width = 123
        DataGridView1.Columns(5).Width = 120
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim emailPattern As String = "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        Dim emailRegex As New Regex(emailPattern)

        If Not emailRegex.IsMatch(TextBox3.Text.Trim()) Then
            MessageBox.Show("Molimo unesite validnu e-poštu.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ovdje dodajte kod za unos podataka u bazu ili druge radnje nakon provjere ispravnosti email adrese

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" Then
            Dim insertQuery As String = "INSERT INTO KORISNIK (IME_KORISNIKA,PREZIME_KORISNIKA,MAIL_KORISNIKA,BROJ_TELEFONA_KORISNIKA,ADRESA_KORISNIKA,USERNAME,PASSWORD,PLATA,ZAPOSLEN) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
            ExecuteQuery(insertQuery)
            MessageBox.Show("Uspešno ste uneli novog korisnika", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        load_data()
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxID.Text = "" Then
            MessageBox.Show("Izaberite korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deleteQuery As String = "delete from KORISNIK where ID_KORISNIKA = " & TextBoxID.Text
            ExecuteQuery(deleteQuery)
            TextBoxID.Text = ""
            MessageBox.Show("Korisnik je obrisan", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        load_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim emailPattern As String = "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        Dim emailRegex As New Regex(emailPattern)

        If Not emailRegex.IsMatch(TextBox3.Text.Trim()) Then
            MessageBox.Show("Molimo unesite validnu e-poštu.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TextBoxID.Text = "" Then
            MessageBox.Show("Izaberite korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim command As New SqlCommand("UPDATE KORISNIK SET IME_KORISNIKA = @ik ,PREZIME_KORISNIKA = @pk , MAIL_KORISNIKA = @mk ,BROJ_TELEFONA_KORISNIKA = @btk ,ADRESA_KORISNIKA = @ak ,USERNAME = @un ,PASSWORD = @pw ,PLATA = @p ,ZAPOSLEN = @z WHERE ID_KORISNIKA = @id", connection)

            command.Parameters.Add("@ik", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@pk", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@mk", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@btk", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@ak", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBox6.Text
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = TextBox7.Text
            command.Parameters.Add("@p", SqlDbType.VarChar).Value = TextBox8.Text
            command.Parameters.Add("@z", SqlDbType.VarChar).Value = TextBox9.Text
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Korisnik je ažuriran", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Korisnik nije ažuriran", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            connection.Close()
        End If
        load_data()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBoxID.Text = ""
        DataGridView1.ClearSelection()
        load_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count AndAlso e.ColumnIndex <> 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim index As Integer
            index = e.RowIndex
            'Dim selectedrow As DataGridViewRow = DataGridView1.Rows(index)

            TextBoxID.Text = selectedrow.Cells(0).Value.ToString
            TextBox1.Text = selectedrow.Cells(1).Value.ToString
            TextBox2.Text = selectedrow.Cells(2).Value.ToString
            TextBox3.Text = selectedrow.Cells(3).Value.ToString
            TextBox4.Text = selectedrow.Cells(4).Value.ToString
            TextBox5.Text = selectedrow.Cells(5).Value.ToString
            TextBox6.Text = selectedrow.Cells(6).Value.ToString
            TextBox7.Text = selectedrow.Cells(7).Value.ToString
            TextBox8.Text = selectedrow.Cells(8).Value.ToString
            TextBox9.Text = selectedrow.Cells(9).Value.ToString

        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim sqlQuery As String = "SELECT * FROM KORISNIK WHERE (IME_KORISNIKA LIKE '%' + @searchTerm + '%' OR PREZIME_KORISNIKA LIKE '%' + @searchTerm + '%') AND ZAPOSLEN <> 'Ne'"
        Dim searchTerm As String = TextBox10.Text
        Dim dt As New DataTable

        ' Create a SqlConnection object to connect to the database.
        Using conn As New SqlConnection(connString)
            ' Create a SqlCommand object to execute the SQL query.
            Using cmd As New SqlCommand(sqlQuery, conn)
                ' Add the search term parameter to the SqlCommand object.
                cmd.Parameters.AddWithValue("@searchTerm", searchTerm)

                ' Create a SqlDataAdapter object to populate the DataTable with the search results.
                Using da As New SqlDataAdapter(cmd)
                    ' Fill the DataTable with the search results.
                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Set the DataGridView's DataSource property to the DataTable.
        DataGridView1.DataSource = dt
        DataGridView1.Columns(9).Visible = False

        DataGridView1.Columns(2).Width = 123
        DataGridView1.Columns(5).Width = 120
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

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

    'Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
    '    If Not TextBox3.Text.Contains("@") Then
    '        MessageBox.Show("Molimo unesite validnu e-poštu.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class