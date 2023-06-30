Imports System.Data.OleDb

Public Class Form7
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form12.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\GAD_MARKS.accdb")
        cn.Open()
        cmd = New OleDbCommand("update Table1 set Textbox3.text=" & TextBox4.Text & " where ROLL=" & TextBox2.Text, cn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("record updated")
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LAB - 2 PC - 20\Desktop\expt27.mdb")
        cn.Open()
        cmd = New OleDbCommand("Delete from table1 where NAME=" & TextBox1.Text, cn)
        cmd.ExecuteNonQuery() 'not return values 
        MessageBox.Show("record deleted")
        cn.Close()
    End Sub
End Class