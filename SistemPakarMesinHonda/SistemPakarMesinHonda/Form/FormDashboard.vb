Public Class FormDashboard

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub GejalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GejalaToolStripMenuItem.Click
        Dim formGejala As New FormGejala
        formGejala.MdiParent = Me
        formGejala.Show()
    End Sub

    Private Sub DataKerusakanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKerusakanToolStripMenuItem.Click
        Dim formKerusakan As New FormKerusakan
        formKerusakan.MdiParent = Me
        formKerusakan.Show()
    End Sub

    Private Sub DataAturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAturanToolStripMenuItem.Click
        FormAturan.Hide()
        FormAturan.MdiParent = Me
        FormAturan.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        FormDiagnosis.MdiParent = Me
        FormDiagnosis.Show()
    End Sub
End Class
