Imports System.Data
Imports System.Data.OleDb

Public Class FormBARANG
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DABRG As New OleDb.OleDbDataAdapter
    Public DTBRG As New DataTable
    Public KONEKSISTRING As String
    Public LOKASI As String
    Private Sub FormBARANG_Load(sender As Object, e As EventArgs) Handles Me.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
        TXTKODEBRG.Focus()
        ATURDATAGRID()
    End Sub
    Sub ATURDATAGRID()
        DGV()

        DataGridView1.Columns(0).HeaderText = "KODE BARANG"
        DataGridView1.Columns(0).DataPropertyName = "KODEBRG"
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'END_OF_COLOUM_1
        DataGridView1.Columns(1).HeaderText = "NAMA BARANG"
        DataGridView1.Columns(1).DataPropertyName = "NAMABRG"
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'END_OF_COLOUM_2
        DataGridView1.Columns(2).HeaderText = "HARGA BELI"
        DataGridView1.Columns(2).DataPropertyName = "HRGBELI"
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_3
        DataGridView1.Columns(3).HeaderText = "HARGA JUAL"
        DataGridView1.Columns(3).DataPropertyName = "HRGJUAL"
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_4
        DataGridView1.Columns(4).HeaderText = "JUMLAH AWAL"
        DataGridView1.Columns(4).DataPropertyName = "JMLAWAL"
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_5
        DataGridView1.Columns(5).HeaderText = "JUMLAH BELI"
        DataGridView1.Columns(5).DataPropertyName = "JMLBELI"
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_6
        DataGridView1.Columns(6).HeaderText = "JUMLAH JUAL"
        DataGridView1.Columns(6).DataPropertyName = "JMLAWAL"
        DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_7
        DataGridView1.Columns(7).HeaderText = "JUMLAH STOK"
        DataGridView1.Columns(7).DataPropertyName = "JMLSTOK"
        DataGridView1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(7).DefaultCellStyle.Format = "#,#"
        'END_OF_COLOUM_8

    End Sub
    Sub BLANKFORM()
        TXTHRGBELI.Text = ""
        TXTHRGBELI.Text = ""
        TXTHRGJUAL.Text = ""
        TXTHRGJUAL.Text = ""
        TXTJMLAWAL.Text = ""
        TXTKODEBRG.Text = ""
        TXTNAMABRG.Text = ""
    End Sub
    Sub DGV()
        SQLSTR = "UPDATE BARANG SET JMLBELI = 0, JMLJUAL = 0, JMLSTOK = 0"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG INNER JOIN DETAILBELI ON BARANG.KODEBRG=DETAILBELI.KODEBRG SET JMLBELI = JMLBELI + JUMLAH"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG INNER JOIN DETAILJUAL ON BARANG.KODEBRG=DETAILJUAL.KODEBRG SET JMLJUAL = JMLJUAL + JUMLAH"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "UPDATE BARANG SET JMLSTOK = JMLAWAL + JMLBELI - JMLJUAL"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "SELECT * FROM BARANG"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DataGridView1.DataSource = DTBRG
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BLANKFORM()
        DGV()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQLSTR = "SELECT * FROM BARANG WHERE KODEBRG='" & TXTKODEBRG.Text & "'"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DataGridView1.DataSource = DTBRG
        If DTBRG.Rows.Count > 0 Then
            SQLSTR = "UPDATE BARANG SET KODEBRG='" & TXTKODEBRG.Text & "',NAMABRG='" & TXTNAMABRG.Text & "',HRGBELI=" & TXTHRGBELI.Text & ",HRGJUAL=" & TXTHRGJUAL.Text & ",JMAWAL=" & TXTJMLAWAL.Text & " WHERE KODEBRG='" & TXTKODEBRG.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO BARANG VALUES ('" & TXTKODEBRG.Text & "','" & TXTNAMABRG.Text & "','" &
                TXTHRGBELI.Text & "','" & TXTHRGJUAL.Text & "','" & (TXTJMLAWAL.Text) & "',0,0,0)"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        BLANKFORM()
        DGV()
    End Sub
    Private Sub TXTKODEBRG_LEAVE(sender As Object, e As EventArgs) Handles TXTKODEBRG.Leave
        SQLSTR = "SELECT * FROM BARANG WHERE KODEBRG='" & TXTKODEBRG.Text & "'"
        DABRG = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DTBRG.Clear()
        DABRG.Fill(DTBRG)
        DataGridView1.DataSource = DTBRG
        If DTBRG.Rows.Count > 0 Then
            TXTNAMABRG.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
            TXTHRGBELI.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value
            TXTHRGJUAL.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value
            TXTJMLAWAL.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(4).Value
        End If
        DGV()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As String
        Dim XKODEBRG As String
        XKODEBRG = TXTKODEBRG.Text
        X = MsgBox("DATA BARANG " & TXTNAMABRG.Text & " JADI DIHAPUS ! ", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM BARANG WHERE KODEBRG='" & XKODEBRG & "'"
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
