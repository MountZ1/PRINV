Imports System.Data
Imports System.Data.OleDb
Public Class FormHAKAKSES
    Public LOKASI As String
    Public KONEKSI As String
    Public SQLSTR As String
    Public CONN As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DABELI As New OleDb.OleDbDataAdapter
    Public DA As New OleDb.OleDbDataAdapter
    Public DT As New DataTable
    Public DTBELI As New DataTable
    Public DS As New DataSet
    Private Sub FormHAKAKSES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSI = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        CONN = New OleDb.OleDbConnection(KONEKSI)
        CONN.Open()
    End Sub
    Private Sub FormHAKAKSES_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SQLSTR = "SELECT * FROM HAKAKSES"
        DA = New OleDbDataAdapter(SQLSTR, CONN)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim A As Integer
        For A = 1 To DataGridView1.Rows.Count - 1
            SQLSTR = "UPDATE HAKAKSES SET MASTER=" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value &
                ",TRANSAKSI=" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value &
                ",CETAK=" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value &
                ",HAKAKSES=" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(4).Value &
                ",SELESAI=" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(5).Value &
                " WHERE JABATAN='" & DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(0).Value & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, CONN)
            CMD.ExecuteNonQuery()
        Next
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        CONN.Close()
        Me.Close()
    End Sub
End Class