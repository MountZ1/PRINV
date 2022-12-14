Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FormCTKPMBELIANPERPERIODE
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
    Dim XMULAI As String
    Dim XSAMPAI As String
    Private Sub FormCTKPMBELIANPERPERIODE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()

        SQLSTR = "SELECT * FROM QUERYBELI ORDER BY TANGGAL"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTMULAI.Items.Clear()
        TXTTANGGAL.Items.Clear()
        While DR.Read
            TXTMULAI.Items.Add(DR("TANGGAL"))
            TXTTANGGAL.Items.Add(DR("TANGGAL"))
        End While
        DR.Close()
    End Sub
    Sub KOSONG()
        TXTMULAI.Text = ""
        TXTTANGGAL.Text = ""
        TXTMULAI.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM QUERYBELI WHERE FAKTUR IS NULL"
        DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub FormCTKPMBELIANPERPERIODE_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
        DGV()
    End Sub
    Private Sub TXTMULAI_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTMULAI.SelectedValueChanged
        If TXTTANGGAL.Text <> "" Then
            XMULAI = Strings.Mid(TXTMULAI.Text, 4, 2) & "/" & Strings.Left(TXTMULAI.Text, 2) & "/" & Strings.Right(TXTMULAI.Text, 4)
            XSAMPAI = Strings.Mid(TXTTANGGAL.Text, 4, 2) & "/" & Strings.Left(TXTTANGGAL.Text, 2) & "/" & Strings.Right(TXTTANGGAL.Text, 4)
            SQLSTR = "SELECT * FROM QUERYBELI WHERE TANGGAL BETWEEN #" & XMULAI & "# AND #" & XSAMPAI & "#"
            DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
            DT.Clear()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        End If
    End Sub
    Private Sub TXTTANGGAL_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTTANGGAL.SelectedValueChanged
        If TXTMULAI.Text <> "" Then
            XMULAI = Strings.Mid(TXTMULAI.Text, 4, 2) & "/" & Strings.Left(TXTMULAI.Text, 2) & "/" & Strings.Right(TXTMULAI.Text, 4)
            XSAMPAI = Strings.Mid(TXTTANGGAL.Text, 4, 2) & "/" & Strings.Left(TXTTANGGAL.Text, 2) & "/" & Strings.Right(TXTTANGGAL.Text, 4)
            SQLSTR = "SELECT * FROM QUERYBELI WHERE TANGGAL BETWEEN #" & XMULAI & "# AND #" & XSAMPAI & "#"
            DA = New OleDbDataAdapter(SQLSTR, KONEKSI)
            DT.Clear()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        End If
    End Sub
    Private Sub PDBELIPERIODE_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDBELIPERIODE.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        With e.Graphics
            .DrawString("LAPORAN PEMBELIAN PERPERIODE", FTJDL, Brushes.Blue, 400, 25, TENGAH)
            .DrawString("TANGGAL " & TXTMULAI.Text & " S/D " & TXTTANGGAL.Text, FTJDL, Brushes.Blue, 400, 50, TENGAH)
            .DrawLine(Pens.Black, 10, 95, 800, 95)
            .DrawString("NO.", FTDT, Brushes.Black, 50, 100, KANAN)
            .DrawString("FAKTUR", FTDT, Brushes.Black, 60, 100, KIRI)
            .DrawString("TANGGAL", FTDT, Brushes.Black, 120, 100, KIRI)
            .DrawString("NAMA SUPPLIER", FTDT, Brushes.Black, 210, 100, KIRI)
            .DrawString("KODEBRG", FTDT, Brushes.Black, 350, 100, KIRI)
            .DrawString("NAMA BARANG", FTDT, Brushes.Black, 435, 100, KIRI)
            .DrawString("HRG BELI", FTDT, Brushes.Black, 620, 100, KANAN)
            .DrawString("JUMLAH", FTDT, Brushes.Black, 700, 100, KANAN)
            .DrawString("TOTAL", FTDT, Brushes.Black, 775, 100, KANAN)
            .DrawLine(Pens.Black, 10, 125, 800, 125)
        End With
        BARIS = 130
        NOMOR = 1
        TOTAL = 0
        XMULAI = Strings.Mid(TXTMULAI.Text, 4, 2) & "/" & Strings.Left(TXTMULAI.Text, 2) & "/" & Strings.Right(TXTMULAI.Text, 4)
        XSAMPAI = Strings.Mid(TXTTANGGAL.Text, 4, 2) & "/" & Strings.Left(TXTTANGGAL.Text, 2) & "/" & Strings.Right(TXTTANGGAL.Text, 4)
        SQLSTR = "SELECT * FROM QUERYBELI ORDER BY TANGGAL"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            With e.Graphics
                .DrawString(NOMOR, FTDT, Brushes.Black, 50, BARIS, KANAN)
                .DrawString(DR("FAKTUR"), FTDT, Brushes.Black, 60, BARIS, KIRI)
                .DrawString(DR("TANGGAL"), FTDT, Brushes.Black, 120, BARIS, KIRI)
                .DrawString(DR("NAMASP"), FTDT, Brushes.Black, 210, BARIS, KIRI)
                .DrawString(DR("KODEBRG"), FTDT, Brushes.Black, 350, BARIS, KIRI)
                .DrawString(DR("NAMABRG"), FTDT, Brushes.Black, 435, BARIS, KIRI)
                .DrawString(Format(DR("HRGBELI"), "#,#"), FTDT, Brushes.Black, 620, BARIS, KANAN)
                .DrawString(DR("JUMLAH"), FTDT, Brushes.Black, 675, BARIS, KANAN)
                .DrawString(Format(DR("TOTAL"), "#,#"), FTDT, Brushes.Black, 775, BARIS, KANAN)
                NOMOR = NOMOR + 1
                BARIS = BARIS + 20
                TOTAL = TOTAL + DR("TOTAL")
            End With
        End While
        With e.Graphics
            .DrawLine(Pens.Black, 10, BARIS + 5, 800, BARIS + 5)
            .DrawString("TOTAL :", FTDT, Brushes.Black, 675, BARIS + 10, KANAN)
            .DrawString(Format(TOTAL, "#,#"), FTDT, Brushes.Black, 775, BARIS + 10, KANAN)
            .DrawLine(Pens.Black, 10, BARIS + 30, 800, BARIS + 30)
        End With
        DR.Close()
    End Sub
    Private Sub BTPREVIEW_Click(sender As Object, e As EventArgs) Handles BTPREVIEW.Click
        PDBELIPERIODE.Print()
    End Sub
    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Close()
    End Sub
End Class