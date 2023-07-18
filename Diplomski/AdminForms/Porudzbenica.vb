Imports System.Data.SqlClient
Imports System.Windows

Public Class Porudzbenica
    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim Sql As String = "SELECT PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, IME_KORISNIKA, PREZIME_KORISNIKA, USLUGA, KOLICINA FROM PORUDZBENICA JOIN ARTIKLI ON PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA JOIN KORISNIK ON PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA"
        'Dim Sql As String = "Select * FROM PORUDZBENICA"
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()
        Connection.Open()
        DataAdapter.Fill(DS, "PORUDZBENICA_ARTIKLI_KORISNIK")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "PORUDZBENICA_ARTIKLI_KORISNIK"

        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(4).Width = 125
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Function ExecuteScalarQuery(query As String) As Object
        Dim result As Object = Nothing
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand(query, conn)
            result = cmd.ExecuteScalar()
        End Using
        Return result
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox5.Text <> "" Then
        '     Dim insertQuery As String = "INSERT INTO PORUDZBENICA (ID_ARTIKLA, ID_KORISNIKA, USLUGA) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "')"
        '     ExecuteQuery(insertQuery)
        '     MessageBox.Show("Uspešno ste uneli novou porudžbenicu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Else
        '     MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End If
        '
        'load_data()

        Try
            Dim query As String = "SELECT COUNT(*) FROM KORISNIK WHERE ID_KORISNIKA = '" & TextBox2.Text & "'"
            Dim count As Integer = Convert.ToInt32(ExecuteScalarQuery(query))
            If count > 0 Then
                query = "SELECT COUNT(*) FROM ARTIKLI WHERE ID_ARTIKLA = '" & TextBox1.Text & "'"
                count = Convert.ToInt32(ExecuteScalarQuery(query))
                If count > 0 Then
                    query = "INSERT INTO PORUDZBENICA (ID_ARTIKLA, ID_KORISNIKA, USLUGA) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox5.Text & "')"
                    ExecuteQuery(query)
                    MessageBox.Show("Uspešno ste uneli novou porudžbenicu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Uneli ste nepostojećи artikal", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Unetli ste nepostojeću mušteriju", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Polja nisu lepo popunjena. Molimo unesite ispravne vrijednosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        load_data()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxID.Text = "" Then
            MessageBox.Show("Izaberite porudžbinu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim deleteQuery As String = "delete from PORUDZBENICA where ID_PORUDZBENICE = " & TextBoxID.Text
            ExecuteQuery(deleteQuery)
            TextBoxID.Text = ""
            MessageBox.Show("Porudžbina je obrisana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        load_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If TextBoxID.Text = "" Then
        '    MessageBox.Show("Izaberite porudžbinu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    Dim command As New SqlCommand("UPDATE PORUDZBENICA SET ID_KORISNIKA = @idk ,ID_ARTIKLA = @ida ,USLUGA = @u WHERE ID_PORUDZBENICE = @id", connection)
        '
        '    command.Parameters.Add("@idk", SqlDbType.VarChar).Value = TextBox2.Text
        '    command.Parameters.Add("@ida", SqlDbType.VarChar).Value = TextBox1.Text
        '    command.Parameters.Add("@u", SqlDbType.VarChar).Value = TextBox5.Text
        '    command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text
        '
        '    connection.Open()
        '
        '    If command.ExecuteNonQuery() = 1 Then
        '        MessageBox.Show("Porudžbina je ažurirana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("Porudžbina nije ažuriran", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        '    connection.Close()
        'End If
        'load_data()

        Dim connectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Dim query As String = "UPDATE PORUDZBENICA SET ID_ARTIKLA = @ID_ARTIKLA, ID_KORISNIKA = @ID_KORISNIKA, USLUGA = @USLUGA WHERE ID_PORUDZBENICE = @ID_PORUDZBENICE"

        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@ID_PORUDZBENICE", TextBoxID.Text)
        cmd.Parameters.AddWithValue("@ID_ARTIKLA", TextBox1.Text)
        cmd.Parameters.AddWithValue("@ID_KORISNIKA", TextBox2.Text)
        cmd.Parameters.AddWithValue("@USLUGA", TextBox5.Text)

        Try
            connection.Open()

            ' provjeri da li postoji ID_ARTIKLA u tabeli ARTIKAL '
            Dim cmdCheckArtikal As New SqlCommand("SELECT COUNT(*) FROM ARTIKLI WHERE ID_ARTIKLA = @ID_ARTIKLA", connection)
            cmdCheckArtikal.Parameters.AddWithValue("@ID_ARTIKLA", TextBox1.Text)
            Dim artikalCount As Integer = Convert.ToInt32(cmdCheckArtikal.ExecuteScalar())
            If artikalCount = 0 Then
                MessageBox.Show("Artikal sa datim ID-jem ne postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' provjeri da li postoji ID_KORISNIKA u tabeli KORISNIK '
            Dim cmdCheckKorisnik As New SqlCommand("SELECT COUNT(*) FROM KORISNIK WHERE ID_KORISNIKA = @ID_KORISNIKA", connection)
            cmdCheckKorisnik.Parameters.AddWithValue("@ID_KORISNIKA", TextBox2.Text)
            Dim korisnikCount As Integer = Convert.ToInt32(cmdCheckKorisnik.ExecuteScalar())
            If korisnikCount = 0 Then
                MessageBox.Show("Korisnik sa datim ID-jem ne postoji u bazi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' izvrši UPDATE operaciju '
            cmd.ExecuteNonQuery()

            MessageBox.Show("Podaci uspešno ažurirani!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Došlo je do greške prilikom ažuriranja baze: " & ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        load_data()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox5.Text = ""
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
            TextBox2.Text = selectedrow.Cells(2).Value.ToString
            TextBox1.Text = selectedrow.Cells(1).Value.ToString
            TextBox5.Text = selectedRow.Cells(5).Value.ToString

        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Dim ime_prezime_korisnika As String = TextBox10.Text

        Dim cmd As New SqlCommand("SELECT PORUDZBENICA.ID_PORUDZBENICE, PORUDZBENICA.ID_ARTIKLA, PORUDZBENICA.ID_KORISNIKA, KORISNIK.IME_KORISNIKA, KORISNIK.PREZIME_KORISNIKA, PORUDZBENICA.USLUGA FROM PORUDZBENICA INNER JOIN KORISNIK ON PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA WHERE KORISNIK.IME_KORISNIKA + ' ' + KORISNIK.PREZIME_KORISNIKA LIKE '%" & ime_prezime_korisnika & "%'", connection)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        'Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        'Dim sqlQuery As String = "SELECT p.*, k.IME_KORISNIKA, k.PREZIME_KORISNIKA " &
        '                     "FROM PORUDZBENICA p " &
        '                     "INNER JOIN KORISNIK k ON p.ID_KORISNIKA = k.ID_KORISNIKA " &
        '                     "WHERE k.IME_KORISNIKA LIKE '%' + @searchTerm + '%' OR k.PREZIME_KORISNIKA LIKE '%' + @searchTerm + '%'"
        'Dim searchTerm As String = TextBox10.Text
        'Dim dt As New DataTable
        '
        '' Create a SqlConnection object to connect to the database.
        'Using conn As New SqlConnection(connString)
        '    ' Create a SqlCommand object to execute the SQL query.
        '    Using cmd As New SqlCommand(sqlQuery, conn)
        '        ' Add the search term parameter to the SqlCommand object.
        '        cmd.Parameters.AddWithValue("@searchTerm", searchTerm)
        '
        '        ' Create a SqlDataAdapter object to populate the DataTable with the search results.
        '        Using da As New SqlDataAdapter(cmd)
        '            ' Fill the DataTable with the search results.
        '            da.Fill(dt)
        '        End Using
        '    End Using
        'End Using

        ' Set the DataGridView's DataSource property to the DataTable.
        'DataGridView1.DataSource = dt
        'DataGridView1.Columns("ID_PORUDZBENICE").DisplayIndex = 0
        'DataGridView1.Columns("ID_ARTIKLA").DisplayIndex = 1
        'DataGridView1.Columns("ID_KORISNIKA").DisplayIndex = 2
        'DataGridView1.Columns("IME_KORISNIKA").DisplayIndex = 3
        'DataGridView1.Columns("PREZIME_KORISNIKA").DisplayIndex = 4
        'DataGridView1.Columns("USLUGA").DisplayIndex = 5

        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(4).Width = 125
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class