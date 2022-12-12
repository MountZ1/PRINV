Imports System.Data
Imports System.Data.OleDb
Public Class FormCUSTOMER
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DACS As New OleDb.OleDbDataAdapter
    Public DTCS As New DataTable
    Public KONEKSISTRING As String
    Public LOKASI As String
    Public XFOTO As String
    Private Sub FormCUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
        ATURDATAGRID()
    End Sub
    Sub ATURDATAGRID()
        DGV()

        DataGridView1.Columns(0).HeaderText = "KODE CUSTOMER"
        DataGridView1.Columns(0).DataPropertyName = "KODECS"
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'END_OF_COLOUM_1
        DataGridView1.Columns(1).HeaderText = "NAMA CUSTOMER"
        DataGridView1.Columns(1).DataPropertyName = "NAMACS"
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'END_OF_COLOUM_2
        DataGridView1.Columns(2).HeaderText = "ALAMAT CUSTOMER"
        DataGridView1.Columns(2).DataPropertyName = "ALAMATCS"
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'END_OF_COLOUM_3
        DataGridView1.Columns(3).HeaderText = "TELEPON CUSTOMER"
        DataGridView1.Columns(3).DataPropertyName = "TELPONCS"
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        'END_OF_COLOUM_4
    End Sub
    Sub KOSONG()
        TXTKDCST.Text = ""
        TXTNMCST.Text = ""
        TXTALAMAT.Text = ""
        TXTNMRTLP.Text = ""
        TXTKDCST.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM CUSTOMER"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DataGridView1.DataSource = DTCS
    End Sub
    Private Sub FormCUSTOMER_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "SELECT * FROM CUSTOMER WHERE KODECS='" & TXTKDCST.Text & "'"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DataGridView1.DataSource = DTCS
        If DTCS.Rows.Count > 0 Then
            SQLSTR = "UPDATE CUSTOMER SET KODECS='" & TXTKDCST.Text & "',NAMACS='" & TXTNMCST.Text & "',ALAMAT='" & TXTALAMAT.Text & "',TELPONCS='" & TXTNMRTLP.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO CUSTOMER VALUES ('" & TXTKDCST.Text & "','" & TXTNMCST.Text & "','" & TXTALAMAT.Text & "','" & TXTNMRTLP.Text & "')"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub
    Private Sub TXTKDCST_Leave(sender As Object, e As EventArgs) Handles TXTKDCST.Leave
        SQLSTR = "SELECT * FROM CUSTOMER WHERE KODECS='" & TXTKDCST.Text & "'"
        DACS = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTCS.Clear()
        DACS.Fill(DTCS)
        DataGridView1.DataSource = DTCS
        If DTCS.Rows.Count > 0 Then
            TXTNMCST.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
            TXTALAMAT.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value
            TXTNMRTLP.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value
        End If
        DGV()
    End Sub
    Private Sub BTHAPUS_Click(sender As Object, e As EventArgs) Handles BTHAPUS.Click
        Dim X As String
        X = MsgBox("DATA CUSTOMER " & TXTNMCST.Text & " TELAH DIHAPUS", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM CUSTOMER WHERE KODECS='" & TXTKDCST.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub
    Private Sub BTBLANK_Click(sender As Object, e As EventArgs) Handles BTBLANK.Click
        KOSONG()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
    Private Sub FormCUSTOMER_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        KONEKSI.Close()
    End Sub
End Class