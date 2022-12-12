Imports System.Data
Imports System.Data.OleDb
Public Class FormSUPLLIER
    Dim SQLSTR As String
    Dim KONEKSI As New OleDb.OleDbConnection
    Dim CMD As New OleDb.OleDbCommand
    Dim DASP As New OleDb.OleDbDataAdapter
    Dim DTSP As New DataTable
    Dim KONEKSISTRING As String
    Dim LOKASI As String
    Private Sub FormSUPLLIER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.MDB"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
        ATURDATAGRIDVIEW()
    End Sub
    Sub ATURDATAGRIDVIEW()
        DGV()

        With DataGridView1
            .Columns(0).HeaderText = "KODE SUPPLIER"
            .Columns(0).DataPropertyName = "KODESP"
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_1
            .Columns(1).HeaderText = "NAMA SUPPLIER"
            .Columns(1).DataPropertyName = "NAMASP"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_2
            .Columns(2).HeaderText = "ALAMAT SUPPLIER"
            .Columns(2).DataPropertyName = "ALAMATSP"
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_3
            .Columns(3).HeaderText = "NO TELEPON"
            .Columns(3).DataPropertyName = "TELPONSP"
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_4
        End With
    End Sub
    Sub BLANKFORM()
        TXTKODESUP.Text = ""
        TXTNAMASUP.Text = ""
        TXTALAMAT.Text = ""
        TXTNOTELP.Text = ""
        TXTKODESUP.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM SUPPLIER"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DataGridView1.DataSource = DTSP
    End Sub
    Private Sub FORM1_ACTIVATED(sender As Object, e As EventArgs) Handles MyBase.Activated
        DGV()
        BLANKFORM()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        SQLSTR = "SELECT * FROM SUPPLIER WHERE KODESP='" & TXTKODESUP.Text & "'"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DataGridView1.DataSource = DTSP
        If DTSP.Rows.Count > 0 Then
            SQLSTR = "UPDATE SUPPLIER SET KODESP='" & TXTKODESUP.Text & "',NAMASP='" & TXTNAMASUP.Text & "',ALAMATSP=" & TXTALAMAT.Text & ",TELPONSP=" & TXTNOTELP.Text & " WHERE KODESP='" & TXTKODESUP.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO SUPPLIER VALUES ('" & TXTKODESUP.Text & "','" & TXTNAMASUP.Text & "','" & TXTALAMAT.Text & "','" & TXTNOTELP.Text & "')"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        BLANKFORM()
        DGV()
    End Sub
    Private Sub TXTKODESUP_LEAVE(sender As Object, e As EventArgs) Handles TXTKODESUP.Leave
        SQLSTR = "SELECT * FROM SUPPLIER WHERE KODESP='" & TXTKODESUP.Text & "'"
        DASP = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTSP.Clear()
        DASP.Fill(DTSP)
        DataGridView1.DataSource = DTSP
        If DTSP.Rows.Count > 0 Then
            TXTNAMASUP.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
            TXTALAMAT.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value
            TXTNOTELP.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value
        End If
        DGV()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As String
        Dim XKODESP As String
        XKODESP = TXTKODESUP.Text
        X = MsgBox("DATA SUPPLIER " & TXTNAMASUP.Text & " JADI DIHAPUS ! ", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM SUPPLIER WHERE KODESP='" & XKODESP & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BLANKFORM()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub FORM1_LEAVE(sender As Object, e As EventArgs) Handles Me.Leave
        KONEKSI.Close()
    End Sub
End Class
