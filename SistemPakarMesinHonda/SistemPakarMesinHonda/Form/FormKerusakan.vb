Public Class FormKerusakan

    Private Sub RefreshGrid()
        Dim dataset As DataSet = KontrolKerusakan.ReadData()
        DataGridView1.DataSource = dataset
        DataGridView1.DataMember = "tabelkerusakan"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.Columns(0).ReadOnly = True
        TextBox1.Text = IdBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Function IdBaru() As String
        Dim id As String = "err"
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand("SELECT TOP 1 * FROM kerusakan ORDER BY id_kerusakan DESC", Koneksi.bukaKoneksi())
        Dim reader As OleDb.OleDbDataReader = query.ExecuteReader()
        While reader.Read
            id = reader.Item(0)
        End While
        Dim digit As Integer
        id = id.Substring(1)
        Int32.TryParse(id, digit)
        digit = digit + 1
        Dim result = "K" + digit.ToString("D4")
        Return result
    End Function


    Private Sub FormKerusakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idkerusakan, namakerusakan, sistemkerusakan, solusi As String
        idkerusakan = TextBox1.Text
        namakerusakan = TextBox2.Text
        sistemkerusakan = TextBox3.Text
        solusi = RichTextBox1.Text

        If (namakerusakan.Length > 0 And sistemkerusakan.Length > 0 And solusi.Length > 0) Then
            Dim entitasKerusakan As New EntitasKerusakan

            With entitasKerusakan
                .id_kerusakan_ = idkerusakan
                .nama_kerusakan_ = namakerusakan
                .sistem_kerusakan_ = sistemkerusakan
                .solusi_ = solusi
            End With

            KontrolKerusakan.CreateData(entitasKerusakan)
            MsgBox("Data berhasil ditambahkan!")
            RefreshGrid()
        Else
            MsgBox("Masukkan semua data!")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim row As String = DataGridView1.CurrentCell.RowIndex

        Dim id As String = DataGridView1.Rows(row).Cells(0).Value.ToString()
        Dim value As String = DataGridView1.Rows(row).Cells(1).Value.ToString()
        Dim sistemkerusakan As String = DataGridView1.Rows(row).Cells(2).Value.ToString()
        Dim solusi As String = DataGridView1.Rows(row).Cells(3).Value.ToString()

        Dim entitasKerusakan As New EntitasKerusakan
        With entitasKerusakan
            .id_kerusakan_ = id
            .nama_kerusakan_ = value
            .sistem_kerusakan_ = sistemkerusakan
            .solusi_ = solusi
        End With

        KontrolKerusakan.UpdateData(entitasKerusakan)
        MsgBox("Data berhasil diperbaharui!")
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = 46 Then
            Dim row As String = DataGridView1.CurrentCell.RowIndex

            Dim id As String = DataGridView1.Rows(row).Cells(0).Value.ToString()
            Dim value As String = DataGridView1.Rows(row).Cells(1).Value.ToString()
            Dim sistemkerusakan As String = DataGridView1.Rows(row).Cells(2).Value.ToString()
            Dim solusi As String = DataGridView1.Rows(row).Cells(3).Value.ToString()

            KontrolKerusakan.DeleteData(id)
            MsgBox("Data berhasil dihapus!")
            RefreshGrid()

        End If
    End Sub
End Class