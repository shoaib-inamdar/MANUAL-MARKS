Imports System.Data
Imports System.Data.OleDb
Public Class Form8
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GAD_MARKSDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.GAD_MARKSDataSet.Table1)
        'TODO: This line of code loads data into the 'GADDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.GADDataSet.Table1)

    End Sub

    Private Sub Table1BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Table1BindingSource.CurrentChanged

    End Sub

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