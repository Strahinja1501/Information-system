Imports System.Data.SqlClient
Public Class Delovi

    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim Sql As String = "Select * FROM ARTIKLI WHERE IME_DELA <> ''"
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()
        Connection.Open()
        DataAdapter.Fill(DS, "ARTIKLI")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "ARTIKLI"
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False

        DataGridView1.Columns(4).Width = 150
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

        TextBox9.Text = GlobalVariables.ID_KORISNIKA
    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim conn As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")
    '    Dim cmd As New SqlCommand()
    '    cmd.CommandType = CommandType.Text
    '
    '    If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
    '        Dim insertQuery As String = "INSERT INTO PORUDZBENICA (ID_KORISNIKA,ID_ARTIKLA,USLUGA,KOLICINA) VALUES('" & TextBox9.Text & "','" & TextBoxID.Text & "','" & TextBox3.Text & "','" & TextBox11.Text & "')"
    '        ExecuteQuery(insertQuery)
    '
    '        MessageBox.Show("Uspešno ste uneli novi artikal", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    '
    '    load_data()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            Dim stanje As Integer = Integer.Parse(TextBox11.Text)

            ' Provjeri je li količina dovoljna
            If stanje <= GetDostupnaKolicina() Then
                ' Oduzmi količinu iz tabele ARTIKLI
                Dim updateQuery As String = "UPDATE ARTIKLI SET STANJE = STANJE - " & stanje & " WHERE ID_ARTIKLA = '" & TextBoxID.Text & "'"
                ExecuteQuery(updateQuery)

                ' Dodaj novu porudžbenicu
                Dim insertQuery As String = "INSERT INTO PORUDZBENICA (ID_KORISNIKA, ID_ARTIKLA, USLUGA, KOLICINA) VALUES ('" & TextBox9.Text & "', '" & TextBoxID.Text & "', '" & TextBox3.Text & "', '" & TextBox11.Text & "')"
                ExecuteQuery(insertQuery)

                MessageBox.Show("Uspešno ste uneli novi artikal", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Nema dovoljno na stanju", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        load_data()
    End Sub

    Private Function GetDostupnaKolicina() As Integer
        Dim dostupnaKolicina As Integer = 0

        ' Izvrši upit za dobijanje trenutne količine iz tabele ARTIKLI
        Dim selectQuery As String = "SELECT STANJE FROM ARTIKLI WHERE ID_ARTIKLA = '" & TextBoxID.Text & "'"
        Dim conn As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")
        Dim cmd As New SqlCommand(selectQuery, conn)

        Try
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                dostupnaKolicina = Integer.Parse(reader("STANJE").ToString())
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Greška pri dobijanju dostupne količine: " & ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return dostupnaKolicina
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
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
            TextBox1.Text = selectedrow.Cells(3).Value.ToString
            TextBox2.Text = selectedrow.Cells(4).Value.ToString
            TextBox5.Text = selectedrow.Cells(5).Value.ToString
            TextBox8.Text = selectedrow.Cells(8).Value.ToString
            TextBox4.Text = selectedrow.Cells(9).Value.ToString

        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim sqlQuery As String = "SELECT * FROM ARTIKLI WHERE (IME_KLIME LIKE '%' + @searchTerm + '%' OR IME_DELA LIKE '%' + @searchTerm + '%') AND IME_DELA <> ''"
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
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False

        DataGridView1.Columns(4).Width = 150
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class