Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class FormCETAKFAKTURPEMBELIAN
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM BELI ORDER BY FAKTUR"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTNOFAKTUR.Items.Clear()
        While DR.Read
            TXTNOFAKTUR.Items.Add(DR("FAKTUR"))
        End While
        DR.Close()
        KOSONG()
    End Sub
    Sub KOSONG()
        TXTNOFAKTUR.Text = ""
        TXTKDSUP.Text = ""
        TXTNMSUP.Text = ""
        TXTTANGGAL.Text = ""
        SQLSTR = "DELETE FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        TXTNOFAKTUR.Focus()
    End Sub

    Sub DGV()
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub TXTNOFAKTUR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTNOFAKTUR.SelectedIndexChanged
        SQLSTR = "SELECT * FROM QUERYBELI WHERE FAKTUR='" & TXTNOFAKTUR.Text & "'"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTTANGGAL.Text = DR("TANGGAL")
            TXTKDSUP.Text = DR("KODESP")
            TXTNMSUP.Text = DR("NAMASP")
        End While
        DR.Close()

        SQLSTR = "DELETE * FROM DETAILBELISEMU"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        SQLSTR = "INSERT INTO DETAILBELISEMU (KODEBRG,NAMABRG,HARGABELI,JUMLAH,TOTAL) SELECT" &
            " QUERYBELI.KODEBRG,QUERYBELI.NAMABRG,QUERYBELI.HARGABELI, QUERYBELI.JUMLAH, QUERYBELI.TOTAL " &
            "FROM QUERYBELI WHERE FAKTUR ='" & TXTNOFAKTUR.Text & "'"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        CMD.ExecuteNonQuery()

        DGV()
        BTPREVIEW.Focus()
    End Sub
    Private Sub PDBELI_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDBELI.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far


        e.Graphics.DrawString("LAPORAN PEMBELIAN PERFAKTUR", FTJDL, Brushes.Blue, 300, 25, TENGAH)
        e.Graphics.DrawString("NO. FAKTUR : " & TXTNOFAKTUR.Text, FTDT, Brushes.Black, 30, 70, KIRI)
        e.Graphics.DrawString("TANGGAL    : " & TXTTANGGAL.Text, FTDT, Brushes.Black, 30, 90, KIRI)
        e.Graphics.DrawString("KODE SUPPLIER : " & TXTKDSUP.Text, FTDT, Brushes.Black, 240, 70, KIRI)
        e.Graphics.DrawString("NAMA SUPPLIER : " & TXTNMSUP.Text, FTDT, Brushes.Black, 240, 90, KIRI)
        e.Graphics.DrawLine(Pens.Black, 30, 110, 600, 110)
        e.Graphics.DrawString("NOMOR", FTDT, Brushes.Black, 100, 115, KANAN)
        e.Graphics.DrawString("KODEBRG", FTDT, Brushes.Black, 125, 115, KIRI)
        e.Graphics.DrawString("NAMA BARANG", FTDT, Brushes.Black, 200, 115, KIRI)
        e.Graphics.DrawString("HRG BELI", FTDT, Brushes.Black, 400, 115, KANAN)
        e.Graphics.DrawString("JUMLAH", FTDT, Brushes.Black, 500, 115, KANAN)
        e.Graphics.DrawString("TOTAL", FTDT, Brushes.Black, 575, 115, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, 140, 600, 140)

        BARIS = 145
        NOMOR = 1
        TOTAL = 0
        SQLSTR = "SELECT * FROM DETAILBELISEMU"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            e.Graphics.DrawString(NOMOR, FTDT, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODEBRG"), FTDT, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMABRG"), FTDT, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(Format(DR("HARGABELI"), "#,#"), FTDT, Brushes.Black, 400, BARIS, KANAN)
            e.Graphics.DrawString(DR("JUMLAH"), FTDT, Brushes.Black, 475, BARIS, KANAN)
            e.Graphics.DrawString(Format(DR("TOTAL"), "#,#"), FTDT, Brushes.Black, 575, BARIS, KANAN)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
            TOTAL = TOTAL + DR("TOTAL")
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 600, BARIS + 5)
        e.Graphics.DrawString("TOTAL : ", FTDT, Brushes.Black, 500, BARIS + 10, KANAN)
        e.Graphics.DrawString(Format(TOTAL, "#,#"), FTDT, Brushes.Black, 575, BARIS + 10, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 30, 600, BARIS + 30)
        DR.Close()
    End Sub
    Private Sub BTPREVIEW_Click(sender As Object, e As EventArgs) Handles BTPREVIEW.Click
        PDBELI.Print()

    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
End Class