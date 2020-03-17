Public Class FormLaporanDiagnosis

    Public ids As String
    Public txtnama_, txtmobil_ As String
    Public Sub New(id As String, n As String, m As String)
        ids = id
        txtnama_ = n
        txtmobil_ = m
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FormLaporanDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New LaporanDiagnosis
        report.Refresh()


        Dim txtNama As CrystalDecisions.CrystalReports.Engine.TextObject = report.Section3.ReportObjects("txtNama")
        Dim txtMobil As CrystalDecisions.CrystalReports.Engine.TextObject = report.Section3.ReportObjects("txtMobil")

        txtNama.Text = txtnama_
        txtMobil.Text = txtmobil_

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.SelectionFormula = "{Command.nama_kerusakan}='" & ids & "'"
    End Sub
End Class