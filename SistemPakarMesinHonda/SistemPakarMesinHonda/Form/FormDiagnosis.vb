Public Class FormDiagnosis
    Private Sub FormDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.CheckBoxes = True

        ListView1.Columns.Add("", 30, HorizontalAlignment.Left)          'Add column 1
        ListView1.Columns.Add("ID Gejala", 200, HorizontalAlignment.Left) 'Add column 2
        ListView1.Columns.Add("Gejala Kerusakan", 170, HorizontalAlignment.Left) 'Add column 3

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbCommand(String.Format("SELECT * FROM gejala"), Koneksi.bukaKoneksi())
        Dim reader As OleDb.OleDbDataReader = adapter.ExecuteReader

        While reader.Read
            ListView1.Items.Add(New ListViewItem({"", reader.Item(0).ToString, reader.Item(1).ToString}))

        End While


        'Use this to set the first column to be displayed as the last column
        ListView1.Columns(0).DisplayIndex = ListView1.Columns.Count - 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim formHasil As New FormHasilDiagnosa
        formHasil.MdiParent = FormDashboard
        formHasil.setIdentitas(TextBox1.Text, TextBox2.Text)

        Dim list As New List(Of String)()
        For i = 0 To ListView1.Items.Count - 1

            If ListView1.Items(i).Checked = True Then
                Dim newitem As String = ListView1.Items(i).SubItems(1).Text
                list.Add("'" + newitem + "'")
                formHasil.tambahGejala(ListView1.Items(i).SubItems(1).Text, ListView1.Items(i).SubItems(2).Text)
            End If

        Next

        If list.Count > 0 And TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then

            Dim stringJoin As String = String.Join(",", list)

            Koneksi.tutupKoneksi()
            Dim query As New OleDb.OleDbCommand(String.Format("SELECT COUNT(data_aturan.id_aturan) AS c, data_aturan.id_aturan 
FROM data_aturan WHERE data_aturan.id_gejala IN ({0}) GROUP BY data_aturan.id_aturan", stringJoin), Koneksi.bukaKoneksi())
            Dim reader As OleDb.OleDbDataReader = query.ExecuteReader

            Dim total As Integer = 0

            While reader.Read
                total = total + reader.Item(0)
            End While
            reader.Close()

            Koneksi.tutupKoneksi()
            Dim query2 As New OleDb.OleDbCommand(String.Format("SELECT COUNT(data_aturan.id_aturan) AS c, data_aturan.id_aturan , kerusakan.nama_kerusakan
FROM data_aturan INNER JOIN aturan ON data_aturan.id_aturan=aturan.id_aturan INNER JOIN kerusakan ON kerusakan.id_kerusakan=aturan.id_kerusakan 
WHERE data_aturan.id_gejala IN ({0}) GROUP BY data_aturan.id_aturan, kerusakan.nama_kerusakan", stringJoin), Koneksi.bukaKoneksi())
            Dim r2 As OleDb.OleDbDataReader = query2.ExecuteReader
            While r2.Read
                Dim namakerusakan = r2.Item(2).ToString
                Dim presentase = r2.Item(0) / total

                formHasil.tambahPresentase(namakerusakan, Math.Round(presentase * 100).ToString() + "%")

            End While
            formHasil.Show()
            Me.Close()
        Else
            MsgBox("Isikan semua data!")
        End If





    End Sub
End Class