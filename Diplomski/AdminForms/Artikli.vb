Imports System.Data.SqlClient
Public Class Artikli

    Dim connection As New SqlConnection("Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True")

    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Public Sub load_data()
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim Sql As String = "Select * FROM ARTIKLI"
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        Dim DS As New DataSet()
        Connection.Open()
        DataAdapter.Fill(DS, "ARTIKLI")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "ARTIKLI"
        'DataGridView1.Columns(0).Visible = False

        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)
        DataGridView1.Sort(DataGridView1.Columns("IME_DELA"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" Then
            Dim insertQuery As String = "INSERT INTO ARTIKLI (IME_KLIME,SERIJSKI_BROJ_KLIME,IME_DELA,SERIJSKI_BROJ_DELA,CENA,INVERTER,GAS,GARANCIJA,BOJA,STANJE) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox11.Text & "')"
            ExecuteQuery(insertQuery)
            MessageBox.Show("Uspešno ste uneli novi artikal", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox11.Text <> "" Then
            Dim insertQuery As String = "INSERT INTO ARTIKLI (IME_KLIME,SERIJSKI_BROJ_KLIME,IME_DELA,SERIJSKI_BROJ_DELA,CENA,INVERTER,GAS,GARANCIJA,BOJA,STANJE) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox11.Text & "')"
            ExecuteQuery(insertQuery)
            MessageBox.Show("Uspešno ste uneli novi artikal", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Sva polja moraju biti popunjena", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        load_data()
    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub ExecuteDeleteQuery(ByVal query As String, ByVal recordId As Integer)
        Dim ConnectionString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Using connection As New SqlConnection(ConnectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_ARTIKLA", recordId)
            Try
                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Artikal je uspešno obrisan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Izaberite novi artikal.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Ne možete obrisati artikal ako se nalazi na porudžbenici.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBoxID.Text) Then
            MessageBox.Show("Izaberite korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "DELETE FROM ARTIKLI WHERE ID_ARTIKLA = @ID_ARTIKLA"
        Dim ID_ARTIKLA As Integer = Integer.Parse(TextBoxID.Text)
        ExecuteDeleteQuery(query, ID_ARTIKLA)

        load_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxID.Text = "" Then
            MessageBox.Show("Izaberite artikal", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim command As New SqlCommand("UPDATE ARTIKLI SET IME_KLIME = @ik ,SERIJSKI_BROJ_KLIME = @sbk , IME_DELA = @idla ,SERIJSKI_BROJ_DELA = @sbd ,CENA = @c ,INVERTER = @i , GAS = @g, GARANCIJA = @gar ,BOJA = @b ,STANJE = @st WHERE ID_ARTIKLA = @id", connection)

            command.Parameters.Add("@ik", SqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@sbk", SqlDbType.VarChar).Value = TextBox2.Text
            command.Parameters.Add("@idla", SqlDbType.VarChar).Value = TextBox3.Text
            command.Parameters.Add("@sbd", SqlDbType.VarChar).Value = TextBox4.Text
            command.Parameters.Add("@c", SqlDbType.VarChar).Value = TextBox5.Text
            command.Parameters.Add("@i", SqlDbType.VarChar).Value = TextBox6.Text
            command.Parameters.Add("@g", SqlDbType.VarChar).Value = TextBox7.Text
            command.Parameters.Add("@gar", SqlDbType.VarChar).Value = TextBox8.Text
            command.Parameters.Add("@b", SqlDbType.VarChar).Value = TextBox9.Text
            command.Parameters.Add("@st", SqlDbType.VarChar).Value = TextBox11.Text
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBoxID.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Artikal je ažuriran", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Artikal nije ažuriran", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            TextBox1.Text = selectedrow.Cells(1).Value.ToString
            TextBox2.Text = selectedrow.Cells(2).Value.ToString
            TextBox3.Text = selectedrow.Cells(3).Value.ToString
            TextBox4.Text = selectedrow.Cells(4).Value.ToString
            TextBox5.Text = selectedrow.Cells(5).Value.ToString
            TextBox6.Text = selectedrow.Cells(6).Value.ToString
            TextBox7.Text = selectedrow.Cells(7).Value.ToString
            TextBox8.Text = selectedrow.Cells(8).Value.ToString
            TextBox9.Text = selectedRow.Cells(9).Value.ToString
            TextBox11.Text = selectedRow.Cells(10).Value.ToString

        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connString As String = "Data Source=DESKTOP-BUESBJO\MSSQLSERVER01;Initial Catalog=DiplomskiFinal;Integrated Security=True"
        Dim sqlQuery As String = "SELECT * FROM ARTIKLI WHERE IME_KLIME LIKE '%' + @searchTerm + '%' OR IME_DELA LIKE '%' + @searchTerm + '%'"
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

        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(4).Width = 150
        DataGridView1.DefaultCellStyle.Font = New Font("Malgun Gothic", 12)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
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