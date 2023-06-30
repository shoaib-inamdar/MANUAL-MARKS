Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "student" And TextBox2.Text = "student" Then
            Form2.Show()
        Else
            MsgBox("wrong username or password")
        End If
    End Sub
End Class
