Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices.ComTypes

Public Class FormJUAL
    Public LOKASI As String
    Public KONEKSISTRING As String
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DA As New OleDb.OleDbDataAdapter
    Public DT As New DataTable
    Public DAJUAL As New OleDb.OleDbDataAdapter
    Public DTJUAL As New DataTable
    Public DS As New DataSet
    Public DR As OleDbDataReader
    Public XNOTA As String
    Public XKODECS As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XHRGJUAL As Integer
    Public XJUMLAH As Integer
    Public XTOTAL As Integer
    Private Sub FormJUAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
        ''''''''''''''
        SQLSTR = "SELECT * FROM CUSTOMER ORDER BY NAMACS"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKDCST.Items.Clear()
        While DR.Read
            TXTKDCST.Items.Add(DR("KODECS") & " ")
        End While
        DR.Close()
        '''''''''''''
        SQLSTR = "SELECT * FROM BARANG ORDER BY NAMABRG"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKDBRG.Items.Clear()
        While DR.Read
            TXTKDBRG.Items.Add(DR("KODEBRG") & " ")
        End While
        DR.Close()
        ATURDATAGRIDKECIL()
        ATURDATAGRIDBESAR()
    End Sub
    Sub ATURDATAGRIDKECIL()
        DGV()

        With DGVDETAILJUAL
            .Columns(0).HeaderText = "KODE BARANG"
            .Columns(0).DataPropertyName = "KODEBRG"
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_1
            .Columns(1).HeaderText = "NAMA BARANG"
            .Columns(1).DataPropertyName = "NAMABRG"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_2
            .Columns(2).HeaderText = "HARGA JUAL"
            .Columns(2).DataPropertyName = "HRGJUAL"
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_3
            .Columns(3).HeaderText = "JUMLAH"
            .Columns(3).DataPropertyName = "JUMLAH"
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_4
            .Columns(4).HeaderText = "TOTAL"
            .Columns(4).DataPropertyName = "TOTAL"
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_5
        End With
    End Sub
    Sub ATURDATAGRIDBESAR()
        DGVJL()

        With DTGV1
            .Columns(0).HeaderText = "NOTA"
            .Columns(0).DataPropertyName = "NOTA"
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_1
            .Columns(1).HeaderText = "TANGGAL"
            .Columns(1).DataPropertyName = "TANGGAL"
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_2
            .Columns(2).HeaderText = "KODE CUSTOMER"
            .Columns(2).DataPropertyName = "KODECS"
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'END_OF_COLUMN_3
            .Columns(3).HeaderText = "NAMA CUSTOMER"
            .Columns(3).DataPropertyName = "NAMACS"
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'END_OF_COLUMN_4
            .Columns(4).HeaderText = "KODE BARANG"
            .Columns(4).DataPropertyName = "KODEBRG"
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'END_OF_COLUMN_5
            .Columns(5).HeaderText = "NAMA BARANG"
            .Columns(5).DataPropertyName = "NAMABRG"
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'END_OF_COLUMN_6
            .Columns(6).HeaderText = "HARGA JUAL"
            .Columns(6).DataPropertyName = "HRGJUAL"
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_7
            .Columns(7).HeaderText = "JUMLAH"
            .Columns(7).DataPropertyName = "JUMLAH"
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_8
            .Columns(8).HeaderText = "TOTAL"
            .Columns(8).DataPropertyName = "TOTAL"
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Format = "#,#"
            'END_OF_COLUMN_9
        End With
    End Sub
    Sub KOSONG()
        TXTNONOTA.Text = ""
        TXTKDCST.Text = ""
        TXTNMCST.Text = ""
        TXTNMBRG.Text = ""
        TXTKDBRG.Text = ""
        TXTJUMLAH.Text = ""
        TXTHRGJUAL.Text = ""
        TXTTOTAL.Text = ""
        SQLSTR = "DELETE * FROM DETAILJUALSEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DGVDETAILJUAL.DataSource = DT
        TXTNONOTA.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILJUALSEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DGVDETAILJUAL.DataSource = DT
    End Sub
    Sub DGVJL()
        SQLSTR = "SELECT * FROM QUERYJUAL"
        DAJUAL = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DTJUAL.Clear()
        DAJUAL.Fill(DTJUAL)
        DTGV1.DataSource = DTJUAL
    End Sub
    Private Sub FormJUAL_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
        DGVJL()
    End Sub
    Private Sub TXTKDCST_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKDCST.SelectedValueChanged
        XKODECS = Microsoft.VisualBasic.Left(TXTKDCST.Text, 5)
        SQLSTR = "SELECT KODECS,NAMACS FROM CUSTOMER WHERE KODECS='" & XKODECS & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNMCST.Text = DR("NAMACS")
        End While
        DR.Close()
        TXTKDBRG.Focus()
    End Sub
    Private Sub TXTKDBRG_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKDBRG.SelectedValueChanged
        XKODEBRG = Microsoft.VisualBasic.Left(TXTKDBRG.Text, 6)
        SQLSTR = "SELECT NAMABRG,HRGJUAL FROM BARANG WHERE KODEBRG='" & XKODEBRG & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNMBRG.Text = DR("NAMABRG")
            TXTHRGJUAL.Text = Format(DR("HRGJUAL"), "#,#")
            XNAMABRG = DR("NAMABRG")
            XHRGJUAL = DR("HRGJUAL")
        End While
        DR.Close()
        TXTJUMLAH.Focus()
    End Sub
    Private Sub TXTJUMLAH_TextChanged(sender As Object, e As EventArgs) Handles TXTJUMLAH.TextChanged
        If TXTJUMLAH.Text = "" Then TXTJUMLAH.Text = 0
        XTOTAL = XHRGJUAL * TXTJUMLAH.Text
        TXTTOTAL.Text = Format(XTOTAL, "#,#")
    End Sub
    Private Sub BTTAMBAH_Click(sender As Object, e As EventArgs) Handles BTTAMBAH.Click
        XJUMLAH = TXTJUMLAH.Text
        SQLSTR = "INSERT INTO DETAILJUALSEMU VALUES ('" & XKODEBRG & "','" & XNAMABRG & "'," & XHRGJUAL & "," & XJUMLAH & "," & XTOTAL & ")"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()
        DGV()
        TXTNMBRG.Text = ""
        TXTKDBRG.Text = ""
        TXTJUMLAH.Text = ""
        TXTHRGJUAL.Text = ""
        TXTTOTAL.Text = ""
    End Sub
    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "INSERT INTO JUAL VALUES ('" & TXTNONOTA.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & XKODECS & "')"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()
        SQLSTR = "INSERT INTO DETAILJUAL (KODEBRG, HRGJUAL, JUMLAH) SELECT DETAILJUALSEMU.KODEBRG," & "DETAILJUALSEMU.HRGJUAL, DETAILJUALSEMU.JUMLAH FROM DETAILJUALSEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()
        SQLSTR = "UPDATE DETAILJUAL SET NOTA ='" & TXTNONOTA.Text & "' WHERE DETAILJUAL.NOTA IS NULL"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()
        KOSONG()
        DGVJL()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
End Class