Imports System.Data
Imports System.Data.OleDb
Public Class Form9
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\GAD_MARKS.accdb")
        conn.Open()
        cmd = New OleDbCommand("select * from Table1", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Table1")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Table1"
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class