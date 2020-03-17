Public Class FormPilihGejala
    Private Sub FormPilihGejala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter("SELECT gejala.id_gejala,gejala.nama_gejala FROM gejala", Koneksi.bukaKoneksi())
        Dim ds As New DataSet
        adapter.Fill(ds, "tabelgejala")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tabelgejala"
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As String = DataGridView1.CurrentCell.RowIndex

        Dim id As String = DataGridView1.Rows(row).Cells(0).Value.ToString()
        Dim value As String = DataGridView1.Rows(row).Cells(1).Value.ToString()


        Dim sudahada As Boolean = False
        For i = 0 To FormAturan.ListView1.Items.Count - 1
            If FormAturan.ListView1.Items(i).SubItems(0).Text = id Then
                sudahada = True
            End If
        Next

        If sudahada Then
            MsgBox("Duplikat data!")
        Else
            FormAturan.ListView1.Items.Add(New ListViewItem(New String() {id, value}))
        End If


        Me.Close()
    End Sub
End Class