Imports System.Data.SqlClient
Imports System.Windows
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Porudzbenice
    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        'Dim korisnikId As Integer = GlobalVariables.ID_KORISNIKA
        '
        ''Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        ''Dim Sql As String = "SELECT PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, IME_KORISNIKA, PREZIME_KORISNIKA, USLUGA FROM PORUDZBENICA JOIN ARTIKLI ON PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA JOIN KORISNIK ON PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA"
        ''Dim Connection As New SqlConnection(ConnectionString)
        ''Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        ''Dim DS As New DataSet()
        ''Connection.Open()
        ''DataAdapter.Fill(DS, "PORUDZBENICA_ARTIKLI_KORISNIK")
        ''DataGridView1.DataSource = DS
        ''DataGridView1.DataMember = "PORUDZBENICA_ARTIKLI_KORISNIK"
        ''
        ''TextBox9.Text = GlobalVariables.ID_KORISNIKA
        '
        'Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        'Dim conn As New SqlConnection(connString)
        '
        'Dim query As String = "Select PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, KORISNIK.IME_KORISNIKA, KORISNIK.PREZIME_KORISNIKA, ARTIKLI.IME_KLIME, ARTIKLI.IME_DELA,ARTIKLI.CENA, PORUDZBENICA.KOLICINA, PORUDZBENICA.USLUGA From PORUDZBENICA Join ARTIKLI On PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA Join KORISNIK On PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA Where KORISNIK.ID_KORISNIKA = @KorisnikID"
        ''Dim query As String = "Select PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, IME_KORISNIKA, PREZIME_KORISNIKA, CENA, KOLICINA, USLUGA From PORUDZBENICA Join ARTIKLI On PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA Join KORISNIK On PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA Where KORISNIK.ID_KORISNIKA = @KorisnikID"
        'Dim asdf As String = "Select SUM(CAST(CENA As Decimal(10,2))) FROM PORUDZBENICA P INNER JOIN ARTIKLI A On P.ID_ARTIKLA = A.ID_ARTIKLA WHERE P.ID_KORISNIKA = @KorisnikId"
        '
        '
        'Dim cmd As New SqlCommand(query, conn)
        'cmd.Parameters.AddWithValue("@KorisnikId", korisnikId)
        '
        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable()
        '
        'Try
        '    conn.Open()
        '    adapter.Fill(table)
        '    DataGridView1.DataSource = table
        'Catch ex As Exception
        '    MessageBox.Show("Došlo je Do greške prilikom dohvatanja porudžbina: " & ex.Message)
        'Finally
        '    conn.Close()
        'End Try
        '
        'Dim ID_KORISNIKA As Integer = ID_KORISNIKA ' Zamijenite 123 s odgovarajućim korisnikId
        '
        'Using connection As New SqlConnection(connString)
        '    Using command As New SqlCommand(asdf, connection)
        '        command.Parameters.AddWithValue("@KorisnikId", korisnikId)
        '
        '        connection.Open()
        '        Dim result As Object = command.ExecuteScalar()
        '
        '        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
        '            TextBox3.Text = result.ToString() & " dinara"
        '        Else
        '            TextBox3.Text = "Nema rezultata."
        '        End If
        '    End Using
        'End Using

        'START____________________________________________________________________________________radi ali samo na jednoj porudzbenici

        'Dim korisnikId As Integer = GlobalVariables.ID_KORISNIKA
        'Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        'Dim conn As New SqlConnection(connString)
        '
        'Dim query As String = "Select PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, KORISNIK.IME_KORISNIKA, KORISNIK.PREZIME_KORISNIKA, ARTIKLI.IME_KLIME, ARTIKLI.IME_DELA,ARTIKLI.CENA, PORUDZBENICA.KOLICINA, PORUDZBENICA.USLUGA From PORUDZBENICA Join ARTIKLI On PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA Join KORISNIK On PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA Where KORISNIK.ID_KORISNIKA = @KorisnikID"
        'Dim asdf As String = "SELECT A.CENA, P.KOLICINA FROM PORUDZBENICA P INNER JOIN ARTIKLI A ON P.ID_ARTIKLA = A.ID_ARTIKLA WHERE P.ID_KORISNIKA = @KorisnikId"
        '
        '
        'Dim cmd As New SqlCommand(query, conn)
        'cmd.Parameters.AddWithValue("@KorisnikId", korisnikId)
        '
        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable()
        '
        'Try
        '    conn.Open()
        '    adapter.Fill(table)
        '    DataGridView1.DataSource = table
        'Catch ex As Exception
        '    MessageBox.Show("Došlo je Do greške prilikom dohvatanja porudžbina: " & ex.Message)
        'Finally
        '    conn.Close()
        'End Try
        '
        'Dim ID_KORISNIKA As Integer = ID_KORISNIKA ' Zamijenite 123 s odgovarajućim korisnikId
        '
        'Using connection As New SqlConnection(connString)
        '    Using command As New SqlCommand(asdf, connection)
        '        command.Parameters.AddWithValue("@KorisnikId", korisnikId)
        '
        '        connection.Open()
        '        Dim reader As SqlDataReader = command.ExecuteReader()
        '
        '        If reader.HasRows AndAlso reader.Read() Then
        '            ' Pročitaj vrednosti iz rezultata upita
        '            Dim cena As Decimal = Convert.ToDecimal(reader("CENA"))
        '            Dim kolicina As Integer = Convert.ToInt32(reader("KOLICINA"))
        '
        '            ' Izračunaj ukupnu cenu
        '            Dim ukupnaCena As Decimal = cena * kolicina
        '
        '            TextBox3.Text = ukupnaCena.ToString() & " dinara"
        '        Else
        '            TextBox3.Text = "Nema rezultata."
        '        End If
        '
        '        reader.Close()
        '    End Using
        'End Using

        'END______________________________________________________________________________________

        'start
        Dim korisnikId As Integer = GlobalVariables.ID_KORISNIKA
        Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim conn As New SqlConnection(connString)

        Dim query As String = "Select PORUDZBENICA.ID_PORUDZBENICE, ARTIKLI.ID_ARTIKLA, KORISNIK.ID_KORISNIKA, KORISNIK.IME_KORISNIKA, KORISNIK.PREZIME_KORISNIKA, ARTIKLI.IME_KLIME, ARTIKLI.IME_DELA,ARTIKLI.CENA, PORUDZBENICA.KOLICINA, PORUDZBENICA.USLUGA From PORUDZBENICA Join ARTIKLI On PORUDZBENICA.ID_ARTIKLA = ARTIKLI.ID_ARTIKLA Join KORISNIK On PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA Where KORISNIK.ID_KORISNIKA = @KorisnikID"
        Dim asdf As String = "SELECT A.CENA, P.KOLICINA FROM PORUDZBENICA P INNER JOIN ARTIKLI A ON P.ID_ARTIKLA = A.ID_ARTIKLA WHERE P.ID_KORISNIKA = @KorisnikId"


        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@KorisnikId", korisnikId)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            conn.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Došlo je Do greške prilikom dohvatanja porudžbina: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Dim ID_KORISNIKA As Integer = ID_KORISNIKA ' Zamijenite 123 s odgovarajućim korisnikId
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(asdf, connection)
                command.Parameters.AddWithValue("@KorisnikId", korisnikId)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim ukupnaSuma As Decimal = 0

                While reader.Read()
                    ' Pročitaj vrednosti iz rezultata upita za svaku porudžbinu
                    Dim cena As Decimal = Convert.ToDecimal(reader("CENA"))
                    Dim kolicina As Integer = Convert.ToInt32(reader("KOLICINA"))

                    ' Izračunaj ukupnu cenu za trenutnu porudžbinu i dodaj je u ukupnu sumu
                    Dim ukupnaCena As Decimal = cena * kolicina
                    ukupnaSuma += ukupnaCena
                End While

                reader.Close()

                If ukupnaSuma > 0 Then
                    TextBox3.Text = ukupnaSuma.ToString() & " dinara"
                Else
                    TextBox3.Text = "Nema rezultata."
                End If
            End Using
        End Using
        'end

        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(4).Width = 123
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = False

        DataGridView1.Columns("IME_KLIME").HeaderText = "KLIMA"
        DataGridView1.Columns("IME_DELA").HeaderText = "DEO"

        'DataGridView1.Columns(7).Visible = False 'usluga
        'DataGridView1.Columns(6).Visible = False 'kolicina

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    If TextBoxID.Text = "" Then
    '        MessageBox.Show("Izaberite porudžbinu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        Dim deleteQuery As String = "delete from PORUDZBENICA where ID_PORUDZBENICE = " & TextBoxID.Text
    '        ExecuteQuery(deleteQuery)
    '        TextBoxID.Text = ""
    '        MessageBox.Show("Porudžbina je obrisana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '
    '    load_data()
    'End Sub

    'PROVA START______________________________________________________________________________________________

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxID.Text = "" Then
            MessageBox.Show("Izaberite porudžbinu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim porudzbenicaID As Integer = Convert.ToInt32(TextBoxID.Text)

            ' Dobavi informacije o porudžbenici
            Dim porudzbenicaQuery As String = "SELECT * FROM PORUDZBENICA WHERE ID_PORUDZBENICE = " & porudzbenicaID
            Dim conn As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")
            Dim porudzbenicaCmd As New SqlCommand(porudzbenicaQuery, conn)

            Try
                conn.Open()
                Dim porudzbenicaReader As SqlDataReader = porudzbenicaCmd.ExecuteReader()

                If porudzbenicaReader.Read() Then
                    Dim kolicina As Integer = Integer.Parse(porudzbenicaReader("KOLICINA").ToString())
                    Dim artikalID As Integer = Integer.Parse(porudzbenicaReader("ID_ARTIKLA").ToString())

                    ' Oduzmi količinu iz tabele PORUDZBENICA
                    Dim deleteQuery As String = "DELETE FROM PORUDZBENICA WHERE ID_PORUDZBENICE = " & porudzbenicaID
                    ExecuteQuery(deleteQuery)

                    ' Saberi količinu u tabeli ARTIKLI
                    Dim updateQuery As String = "UPDATE ARTIKLI SET STANJE = STANJE + " & kolicina & " WHERE ID_ARTIKLA = " & artikalID
                    ExecuteQuery(updateQuery)

                    TextBoxID.Text = ""
                    MessageBox.Show("Porudžbina je obrisana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                porudzbenicaReader.Close()
            Catch ex As Exception
                MessageBox.Show("Greška pri brisanju porudžbine: " & ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If

        load_data()
    End Sub

    'PROVA END________________________________________________________________________________________________

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
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
            TextBox1.Text = selectedRow.Cells(5).Value.ToString
            TextBox2.Text = selectedRow.Cells(6).Value.ToString
            TextBox4.Text = selectedRow.Cells(7).Value.ToString
            TextBox5.Text = selectedRow.Cells(8).Value.ToString

        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Dim ime_prezime_korisnika As String = TextBox10.Text

        Dim cmd As New SqlCommand("SELECT PORUDZBENICA.ID_PORUDZBENICE, PORUDZBENICA.ID_ARTIKLA, PORUDZBENICA.ID_KORISNIKA, KORISNIK.IME_KORISNIKA, KORISNIK.PREZIME_KORISNIKA, PORUDZBENICA.KOLICINA, PORUDZBENICA.USLUGA FROM PORUDZBENICA INNER JOIN KORISNIK ON PORUDZBENICA.ID_KORISNIKA = KORISNIK.ID_KORISNIKA WHERE KORISNIK.IME_KORISNIKA + ' ' + KORISNIK.PREZIME_KORISNIKA LIKE '%" & ime_prezime_korisnika & "%'", connection)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(4).Width = 123
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)
        load_data()

    End Sub
End Class