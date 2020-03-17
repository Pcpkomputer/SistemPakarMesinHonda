Public Class FormHasilDiagnosa
    Public nama_, mobil_ As String

    Public Sub setIdentitas(nama As String, mobil As String)
        nama_ = nama
        mobil_ = mobil
    End Sub

    Public Sub tambahGejala(idgejala As String, namagejala As String)

        ListView1.Items.Add(New ListViewItem(New String() {idgejala, namagejala}))

    End Sub

    Public Sub tambahPresentase(namakerusakan As String, presentase As String)
        ListView2.Items.Add(New ListViewItem(New String() {namakerusakan, presentase}))
    End Sub

    Private Sub FormHasilDiagnosa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details


        ListView1.Columns.Add("ID Gejala", 200, HorizontalAlignment.Left) 'Add column 2
        ListView1.Columns.Add("Gejala Kerusakan", 170, HorizontalAlignment.Left) 'Add column 3

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        ListView2.View = View.Details



        ListView2.Columns.Add("Nama Kerusakan", 250) 'Add column 2
        ListView2.Columns.Add("Presentase Diagnosis", 150) 'Add column 3




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim namakerusakan As String = ListView2.Items(ListView2.FocusedItem.Index).SubItems(0).Text
            'MsgBox(mobil_)
            Dim formLembar As New FormLaporanDiagnosis(namakerusakan, nama_, mobil_)

            formLembar.Show()

        Catch ex As Exception

        End Try

    End Sub
End Class