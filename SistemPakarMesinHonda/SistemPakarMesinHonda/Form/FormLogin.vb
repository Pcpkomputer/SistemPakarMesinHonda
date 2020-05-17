Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username, password As String
        username = TextBox1.Text
        password = TextBox2.Text

        If username.Length > 0 And password.Length > 0 Then
            If username = "admin" And password = "admin" Then
                FormDashboard.Show()
                Me.Hide()
            Else
                MsgBox("Login gagal!")
            End If
        Else
            MsgBox("Isikan data login!")
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class