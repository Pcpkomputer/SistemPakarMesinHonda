Public Class FormPilihKerusakan
    Private Sub FormPilihKerusakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter("SELECT kerusakan.id_kerusakan, kerusakan.nama_kerusakan FROM kerusakan WHERE kerusakan.id_kerusakan NOT IN (SELECT DISTINCT(aturan.id_kerusakan) FROM data_aturan INNER JOIN aturan ON aturan.id_aturan=data_aturan.id_aturan)", Koneksi.bukaKoneksi())
        Dim ds As New DataSet
        adapter.Fill(ds, "tabelkerusakan")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tabelkerusakan"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.ReadOnly = True


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As String = DataGridView1.CurrentCell.RowIndex

        Dim id As String = DataGridView1.Rows(row).Cells(0).Value.ToString()
        Dim value As String = DataGridView1.Rows(row).Cells(1).Value.ToString()

        FormAturan.TextBox2.Text = id
        Me.Close()
    End Sub
End Class