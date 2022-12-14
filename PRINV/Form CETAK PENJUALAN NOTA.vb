Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FormCKTNOTA
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public KONEKSISTRING As String
    Public LOKASI As String
    Public DA As New OleDb.OleDbDataAdapter
    Public DT As New DataTable
    Dim DR As OleDbDataReader
    Dim BARIS As Integer
    Dim FTJDL As Font = New Font("CALIBRI", 14, FontStyle.Bold, GraphicsUnit.Point)
    Dim FTDT As Font = New Font("CALIBRI", 12, FontStyle.Regular, GraphicsUnit.Point)
    Dim KIRI As StringFormat = New StringFormat
    Dim TENGAH As StringFormat = New StringFormat
    Dim KANAN As StringFormat = New StringFormat
    Dim NOMOR As Integer
    Dim TOTAL As Double
    Private Sub FormCKTNOTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM JUAL ORDER BY NOTA"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTNONOT.Items.Clear()
        While DR.Read
            TXTNONOT.Items.Add(DR("NOTA"))
        End While
        KOSONG()
        DR.Close()
    End Sub
    Sub KOSONG()
        TXTNONOT.Text = ""
        TXTTGL.Text = ""
        TXTNMCST.Text = ""
        TXTKDCST.Text = ""
        SQLSTR = "DELETE FROM DETAILJUALSEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        TXTNONOT.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILJUALSEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub FormCKTNOTA_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        DGV()
    End Sub
    Private Sub TXTNONOT_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTNONOT.SelectedValueChanged
        SQLSTR = "SELECT * FROM QUERYJUAL WHERE NOTA='" & TXTNONOT.Text & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTTGL.Text = DR("TANGGAL")
            TXTKDCST.Text = DR("KODECS")
            TXTNMCST.Text = DR("NAMACS")
        End While
        DR.Close()

        SQLSTR = "DELETE * FROM DETAILJUALSEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "INSERT INTO DETAILJUALSEMU ( KODEBRG, NAMABRG,HRGJUAL, JUMLAH,TOTAL ) SELECT " &
            "QUERYJUAL.KODEBRG,QUERYJUAL.NAMABRG,QUERYJUAL.HRGJUAL,QUERYJUAL.JUMLAH,QUERYJUAL.TOTAL " &
            " FROM QUERYJUAL WHERE NOTA ='" & TXTNONOT.Text & "'"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        DGV()
        BTPREVIEW.Focus()
    End Sub
    Private Sub PDJUALNOTA_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDJUALNOTA.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        With e.Graphics
            .DrawString("LAPORAN PENJUALAN PERNOTA", FTJDL, Brushes.Blue, 300, 25, TENGAH)
            .DrawString("NO. NOTA : " & TXTNONOT.Text, FTDT, Brushes.Black, 30, 70, KIRI)
            .DrawString("TANGGAL : " & TXTTGL.Text, FTDT, Brushes.Black, 30, 90, KIRI)
            .DrawString("KODE CUSTOMER : " & TXTKDCST.Text, FTDT, Brushes.Black, 30, 90, KIRI)
            .DrawString("NAMA CUSTOMER : " & TXTNMCST.Text, FTDT, Brushes.Black, 240, 90, KIRI)
            .DrawLine(Pens.Black, 30, 110, 600, 110)
            .DrawString("NOMOR", FTDT, Brushes.Black, 100, 115, KANAN)
            .DrawString("KODEBRG", FTDT, Brushes.Black, 125, 115, KIRI)
            .DrawString("NAMA BARANG", FTDT, Brushes.Black, 200, 115, KIRI)
            .DrawString("HRG JUAL", FTDT, Brushes.Black, 400, 115, KANAN)
            .DrawString("JUMLAH", FTDT, Brushes.Black, 500, 115, KANAN)
            .DrawString("TOTAL", FTDT, Brushes.Black, 575, 115, KANAN)
            .DrawLine(Pens.Black, 30, 140, 600, 140)
        End With
        BARIS = 145
        NOMOR = 1
        TOTAL = 0
        SQLSTR = "SELECT * FROM DETAILJUALSEMU"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            With e.Graphics
                .DrawString(NOMOR, FTDT, Brushes.Black, 100, BARIS, KANAN)
                .DrawString(DR("KODEBRG"), FTDT, Brushes.Black, 125, BARIS, KIRI)
                .DrawString(DR("NAMABRG"), FTDT, Brushes.Black, 200, BARIS, KIRI)
                .DrawString(Format(DR("HRGJUAL"), "#,#"), FTDT, Brushes.Black, 400, BARIS, KANAN)
                .DrawString(DR("JUMLAH"), FTDT, Brushes.Black, 475, BARIS, KANAN)
                .DrawString(Format(DR("TOTAL"), "#,#"), FTDT, Brushes.Black, 575, BARIS, KANAN)
            End With
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
            TOTAL = TOTAL + DR("TOTAL")
        End While
        With e.Graphics
            .DrawLine(Pens.Black, 30, BARIS + 5, 600, BARIS + 5)
            .DrawString("TOTAL :", FTDT, Brushes.Black, 500, BARIS + 10, KANAN)
            .DrawString(Format(TOTAL, "#,#"), FTDT, Brushes.Black, 575, BARIS + 10, KANAN)
            .DrawLine(Pens.Black, 30, BARIS + 30, 600, BARIS + 30)
        End With
        DR.Close()
    End Sub
    Private Sub BTPREVIEW_Click(sender As Object, e As EventArgs) Handles BTPREVIEW.Click
        PDJUALNOTA.Print()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
End Class