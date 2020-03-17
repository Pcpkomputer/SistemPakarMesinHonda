
Public Class FormAturanDetailGejala

    Public Sub isiDG(str As String)
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter(String.Format("SELECT data_aturan.id_gejala, gejala.nama_gejala FROM data_aturan INNER JOIN gejala ON gejala.id_gejala=data_aturan.id_gejala WHERE id_aturan='{0}'", str), Koneksi.bukaKoneksi())
        Dim data As New DataSet
        adapter.Fill(data, "tabeldetailgejala")

        DataGridView1.DataSource = data
        DataGridView1.DataMember = "tabeldetailgejala"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormAturanDetailGejala_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class