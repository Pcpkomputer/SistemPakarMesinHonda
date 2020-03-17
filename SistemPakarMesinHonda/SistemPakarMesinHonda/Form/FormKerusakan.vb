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
End Class