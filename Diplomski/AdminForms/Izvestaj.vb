Imports System.Data.SqlClient
Imports System.Windows
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Izvestaj
    Private Sub Izvestaj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        Dim connectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        '
        'DataGridView1.Columns.Add("Opis", "Opis")
        'DataGridView1.Columns.Add("Vrednosti", "Vrednosti")
        '
        'DataGridView1.Columns(0).Width = 200
        'DataGridView1.Columns(1).Width = 60
        '
        'DataGridView1.RowTemplate.Height = 50 '
        '
        'DataGridView1.DefaultCellStyle.Font = New Font("Arial", 16)
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '
        'Using connection As New SqlConnection(connectionString)
        '    connection.Open()
        '
        '    ' Broj korisnika s "zaposlen" = 'da'
        '    Dim query1 As String = "SELECT COUNT(*) FROM KORISNIK WHERE zaposlen = 'da'"
        '    Using command1 As New SqlCommand(query1, connection)
        '        Dim brojZaposlenih As Integer = CInt(command1.ExecuteScalar())
        '        DataGridView1.Rows.Add("Broj zaposlenih", brojZaposlenih)
        '    End Using
        '
        '    ' Broj korisnika s "zaposlen" = 'ne'
        '    Dim query2 As String = "SELECT COUNT(*) FROM KORISNIK WHERE zaposlen = 'ne'"
        '    Using command2 As New SqlCommand(query2, connection)
        '        Dim brojNezaposlenih As Integer = CInt(command2.ExecuteScalar())
        '        DataGridView1.Rows.Add("Broj mušterija", brojNezaposlenih)
        '    End Using
        '
        '    ' Ukupan broj porudžbenica
        '    Dim query3 As String = "SELECT COUNT(*) FROM Porudzbenica"
        '    Using command3 As New SqlCommand(query3, connection)
        '        Dim ukupanBrojPorudzbenica As Integer = CInt(command3.ExecuteScalar())
        '        DataGridView1.Rows.Add("Ukupan broj porudžbenica", ukupanBrojPorudzbenica)
        '    End Using
        '
        '    ' Ukupan broj artikala s ime_klime <> ''
        '    Dim query4 As String = "SELECT COUNT(*) FROM Artikli WHERE ime_klime <> ''"
        '    Using command4 As New SqlCommand(query4, connection)
        '        Dim ukupanBrojArtikalaImeKlime As Integer = CInt(command4.ExecuteScalar())
        '        DataGridView1.Rows.Add("Ukupan broj klima", ukupanBrojArtikalaImeKlime)
        '    End Using
        '
        '    ' Ukupan broj artikala s ime_dela <> ''
        '    Dim query5 As String = "SELECT COUNT(*) FROM Artikli WHERE ime_dela <> ''"
        '    Using command5 As New SqlCommand(query5, connection)
        '        Dim ukupanBrojArtikalaImeDela As Integer = CInt(command5.ExecuteScalar())
        '        DataGridView1.Rows.Add("Ukupan broj delova", ukupanBrojArtikalaImeDela)
        '    End Using
        'End Using

        'Start_______RADI

        '' Dohvati podatke iz baze podataka
        'Dim query As String = "SELECT ARTIKLI.IME_KLIME, ARTIKLI.IME_DELA, ARTIKLI.STANJE, CAST(ARTIKLI.CENA AS DECIMAL(10, 2)) AS CENA, " &
        '                      "CAST(ARTIKLI.CENA AS DECIMAL(10, 2)) * CAST(ARTIKLI.STANJE AS DECIMAL(10, 2)) AS UKUPNA_CENA " &
        '                      "FROM ARTIKLI"
        'Dim connection As New SqlConnection(connectionString)
        'Dim command As New SqlCommand(query, connection)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        '
        'Try
        '    connection.Open()
        '
        '    ' Prikaz podataka u DataGridView-u
        '    adapter.Fill(table)
        '    DataGridView1.DataSource = table
        '
        'Catch ex As Exception
        '    MessageBox.Show("Greška prilikom dohvatanja podataka: " & ex.Message)
        'Finally
        '    connection.Close()
        'End Try

        'END_________

        'start____

        Dim query As String = "SELECT ARTIKLI.IME_KLIME, ARTIKLI.IME_DELA, ARTIKLI.STANJE, CAST(ARTIKLI.CENA AS DECIMAL(10, 2)) AS CENA, " &
                      "CAST(ARTIKLI.CENA AS DECIMAL(10, 2)) * CAST(ARTIKLI.STANJE AS DECIMAL(10, 2)) AS UKUPNA_CENA " &
                      "FROM ARTIKLI"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()


        Try
            connection.Open()

            ' Prikaz podataka u DataGridView-u
            adapter.Fill(table)
            DataGridView1.DataSource = table

            ' Broj klima
            Dim query1 As String = "SELECT COUNT(*) FROM Artikli WHERE ime_klime <> ''"
            Using command4 As New SqlCommand(query1, connection)
                Dim ukupanBrojArtikalaImeKlime As Integer = CInt(command4.ExecuteScalar())
                TextBox1.Text = ukupanBrojArtikalaImeKlime.ToString()
            End Using

            'Broj delova
            Dim query2 As String = "SELECT COUNT(*) FROM Artikli WHERE ime_dela <> ''"
            Using command4 As New SqlCommand(query2, connection)
                Dim ukupanBrojArtikalaImeDela As Integer = CInt(command4.ExecuteScalar())
                TextBox2.Text = ukupanBrojArtikalaImeDela.ToString()
            End Using

            'broj UKUPNA_CENA
            Dim query5 As String = "SELECT SUM(CAST(CENA AS DECIMAL(10, 2)) * CAST(STANJE AS DECIMAL(10, 2))) FROM Artikli"
            Using command5 As New SqlCommand(query5, connection)
                Dim ukupnaCena As Decimal = Convert.ToDecimal(command5.ExecuteScalar())
                TextBox4.Text = ukupnaCena.ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Greška prilikom dohvatanja podataka: " & ex.Message)
        Finally
            connection.Close()
        End Try

        DataGridView1.Columns("IME_KLIME").HeaderText = "KLIME"
        DataGridView1.Columns("IME_DELA").HeaderText = "DELOVI"
        DataGridView1.Columns("CENA").HeaderText = "POJEDINAČNA CENA"
        DataGridView1.Columns("UKUPNA_CENA").HeaderText = "UKUPNA CENA"
        DataGridView1.RowTemplate.Height = 30
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 16)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        table.DefaultView.Sort = "IME_KLIME DESC"

        'end______

    End Sub
End Class