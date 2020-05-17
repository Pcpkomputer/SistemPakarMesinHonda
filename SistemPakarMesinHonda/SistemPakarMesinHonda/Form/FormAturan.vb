Public Class FormAturan

    Private Sub refreshGrid()
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        ListView1.Clear()

        ListView1.View = View.Details
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("ID Gejala", 100)
        ListView1.Columns.Add("Nama Gejala", 150)

        'ListView1.Items.Add(New ListViewItem(New String() {"111", "555"}))


        Dim dataset As DataSet = KontrolAturan.ReadData()
        DataGridView2.DataSource = dataset
        DataGridView2.DataMember = "tabelaturan"
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ReadOnly = True

        TextBox1.Text = idBaru()
        TextBox2.Text = ""



    End Sub

    Private Function idBaru() As String
        Dim id As String = "err"
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand("SELECT TOP 1 * FROM aturan ORDER BY id_aturan DESC", Koneksi.bukaKoneksi())
        Dim reader As OleDb.OleDbDataReader = query.ExecuteReader()
        While reader.Read
            id = reader.Item(0)
        End While
        Dim digit As Integer
        id = id.Substring(1)
        Int32.TryParse(id, digit)
        digit = digit + 1
        Dim result = "A" + digit.ToString("D4")
        Return result
    End Function

    Private Sub FormAturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FormPilihKerusakan.MdiParent = FormDashboard
        FormPilihKerusakan.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPilihGejala.MdiParent = FormDashboard
        FormPilihGejala.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim idaturan, idkerusakan As String
        idaturan = TextBox1.Text
        idkerusakan = TextBox2.Text

        If idaturan.Length > 0 And idkerusakan.Length > 0 And ListView1.Items.Count > 0 Then

            Koneksi.tutupKoneksi()
            Dim query As New OleDb.OleDbCommand(String.Format("INSERT INTO aturan VALUES ('{0}','{1}')", idaturan, idkerusakan), Koneksi.bukaKoneksi())
            query.ExecuteNonQuery()

            For i = 0 To ListView1.Items.Count - 1
                Koneksi.tutupKoneksi()
                Dim q As New OleDb.OleDbCommand(String.Format("INSERT INTO data_aturan VALUES ('{0}','{1}')", idaturan, ListView1.Items(i).SubItems(0).Text), Koneksi.bukaKoneksi())
                q.ExecuteNonQuery()

            Next

            MsgBox("Data berhasil ditambahkan!")
            refreshGrid()

        Else
            MsgBox("Isikan semua data!")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If DataGridView2.CurrentCell.RowIndex > -1 Then
            Dim row As String = DataGridView2.CurrentCell.RowIndex
            Dim value As String = DataGridView2.Rows(row).Cells(0).Value.ToString()

            FormAturanDetailGejala.isiDG(value)
            FormAturanDetailGejala.MdiParent = FormDashboard
            FormAturanDetailGejala.Show()

        End If

    End Sub
End Class