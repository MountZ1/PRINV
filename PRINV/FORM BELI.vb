Imports System.Data.OleDb
Imports System.Runtime.InteropServices.ComTypes

Public Class FORMBELI
    Public LOKASI As String
    Public KONEKSI As String
    Public SQLSTR As String
    Public CONN As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DA As New OleDb.OleDbDataAdapter
    Public DS As New DataSet
    Public DT As New DataTable
    Public DR As OleDbDataReader
    Public XFAKTUR As String
    Public XKODESP As String
    Public XKODEBRG As String
    Public XNAMABRG As String
    Public XHRGBELI As Integer
    Public XJUMLAH As Integer
    Public XTOTAL As Integer
    Private Sub FORMBELI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSI = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        CONN = New OleDb.OleDbConnection(KONEKSI)
        CONN.Open()
        '''''''''''
        SQLSTR = "SELECT * FROM SUPPLIER ORDER BY NAMASP"
        CMD = New OleDbCommand(SQLSTR, CONN)
        DR = CMD.ExecuteReader
        TXTKODESUP.Items.Clear()
        While DR.Read
            TXTKODESUP.Items.Add(DR("KODESP") & " ")
        End While
        DR.Close()
        '''''''''''
        SQLSTR = "SELECT * FROM BARANG ORDER BY NAMABRG"
        CMD = New OleDbCommand(SQLSTR, CONN)
        DR = CMD.ExecuteReader
        TXTKODEBRG.Items.Clear()
        While DR.Read
            TXTKODEBRG.Items.Add(DR("KODEBRG") & " ")
        End While
        DR.Close()
        ATURDATAGRID()
    End Sub
    Sub ATURDATAGRID()
        DGV()

        With DataGridView1
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
            .Columns(2).HeaderText = "HARGA BELI"
            .Columns(2).DataPropertyName = "HARGABELI"
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
    Sub KOSONG()
        TXTFAKTUR.Text = ""
        TXTKODESUP.Text = ""
        TXTNAMASUP.Text = ""
        TXTNAMABRG.Text = ""
        TXTKODEBRG.Text = ""
        TXTJUMLAH.Text = ""
        TXTHRGBELI.Text = ""
        TXTJUMLAH.Text = ""
        SQLSTR = "DELETE * FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, CONN)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        TXTFAKTUR.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, CONN)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub FORMBELI_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        KOSONG()
        DGV()
    End Sub
    Private Sub TXTKODESUP_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKODESUP.SelectedValueChanged
        XKODESP = Microsoft.VisualBasic.Left(TXTKODESUP.Text, 5)
        SQLSTR = "SELECT KODESP,NAMASP FROM SUPPLIER WHERE KODESP='" & XKODESP & "'"
        CMD = New OleDbCommand(SQLSTR, CONN)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMASUP.Text = DR("NAMASP")
        End While
        DR.Close()
        TXTKODEBRG.Focus()
    End Sub
    Private Sub TXTKODEBRG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTKODEBRG.SelectedIndexChanged
        XKODEBRG = Microsoft.VisualBasic.Left(TXTKODEBRG.Text, 5)
        SQLSTR = "SELECT NAMABRG,HRGBELI FROM BARANG WHERE KODEBRG='" & XKODEBRG & "'"
        CMD = New OleDbCommand(SQLSTR, CONN)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNAMABRG.Text = DR("NAMABRG")
            TXTHRGBELI.Text = Format(DR("HRGBELI"), "#,#")
            XNAMABRG = DR("NAMABRG")
            XHRGBELI = DR("HRGBELI")
        End While
        DR.Close()
        TXTJUMLAH.Focus()
    End Sub
    Private Sub TXTJUMLAH_TextChanged(sender As Object, e As EventArgs) Handles TXTJUMLAH.TextChanged
        If TXTJUMLAH.Text = "" Then TXTJUMLAH.Text = 0
        XTOTAL = XHRGBELI * TXTJUMLAH.Text
        TXTTOTAL.Text = Format(XTOTAL, "#,#")
    End Sub
    Private Sub BTTAMBAH_Click(sender As Object, e As EventArgs) Handles BTTAMBAH.Click
        XTOTAL = TXTTOTAL.Text
        SQLSTR = "INSERT INTO DETAILBELISEMU VALUES ('" & XKODEBRG & "','" & XNAMABRG & "','" & XHRGBELI & "','" & XJUMLAH & "','" & XTOTAL & "')"
        CMD = New OleDbCommand(SQLSTR, CONN)
        CMD.ExecuteNonQuery()
        DGV()
        TXTNAMABRG.Text = ""
        TXTKODEBRG.Text = ""
        TXTJUMLAH.Text = ""
        TXTHRGBELI.Text = ""
        TXTJUMLAH.Text = ""
        TXTKODEBRG.Focus()
    End Sub
    Private Sub BTSIMPAN_Click(sender As Object, e As EventArgs) Handles BTSIMPAN.Click
        SQLSTR = "INSERT INTO BELI VALUES('" & TXTFAKTUR.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & XKODESP & "')"
        CMD = New OleDbCommand(SQLSTR, CONN)
        CMD.ExecuteNonQuery()
        '''''''''''''''''''''
        SQLSTR = "INSERT INTO DETAILBELI (KODEBRG,HARGABELI,JUMLAH) Select KODEBRG,HARGABELI,JUMLAH FROM DETAILBELISEMU"
        CMD = New OleDbCommand(SQLSTR, CONN)
        CMD.ExecuteNonQuery()
        '''''''''''''''''''''
        SQLSTR = "UPDATE DETAILBELI Set FAKTUR = '" & TXTFAKTUR.Text & "'WHERE DETAILBELI.FAKTUR Is Null"
        CMD = New OleDbCommand(SQLSTR, CONN)
        CMD.ExecuteNonQuery()
        '''''''''''''''''''''
        KOSONG()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
    Private Sub FORMBELI_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        CONN.Close()
    End Sub
End Class