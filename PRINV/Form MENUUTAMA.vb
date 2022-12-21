Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class Form_MENUUTAMA
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public KONEKSISTRING As String
    Public LOKASI As String
    Dim DR As OleDbDataReader
    Dim BARIS As Integer
    Dim FONTJUDUL As Font = New Font("CALIBRI", 14, FontStyle.Bold, GraphicsUnit.Point)
    Dim FONTDATA As Font = New Font("CALIBRI", 12, FontStyle.Regular, GraphicsUnit.Point)
    Dim KIRI As StringFormat = New StringFormat
    Dim TENGAH As StringFormat = New StringFormat
    Dim KANAN As StringFormat = New StringFormat
    Dim NOMOR As Integer

    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        FormBARANG.ShowDialog()
    End Sub
    Private Sub DATASUPPLIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATASUPPLIERToolStripMenuItem.Click
        FormSUPLLIER.ShowDialog()
    End Sub
    Private Sub TRANSAKSIPEMBELIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIPEMBELIANToolStripMenuItem.Click
        FORMBELI.ShowDialog()
    End Sub
    Private Sub DATACUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATACUSTOMERToolStripMenuItem.Click
        FormCUSTOMER.ShowDialog()
    End Sub
    Private Sub TRANSAKSIPENJUALANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIPENJUALANToolStripMenuItem.Click
        FormJUAL.ShowDialog()
    End Sub
    Private Sub SELESAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELESAIToolStripMenuItem.Click
        End
    End Sub
    Private Sub Form_MENUUTAMA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub
    Private Sub PDBARANG_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDBARANG.PrintPage
        KIRI.Alignment = StringAlignment.Near
        TENGAH.Alignment = StringAlignment.Center
        KANAN.Alignment = StringAlignment.Far

        e.Graphics.DrawString("LAPORAN DATA BARANG", FONTJUDUL, Brushes.Blue, 450, 25, TENGAH)
        e.Graphics.DrawLine(Pens.Black, 30, 70, 805, 70)
        e.Graphics.DrawString("NOMOR", FONTDATA, Brushes.Black, 100, 75, KANAN)
        e.Graphics.DrawString("KODEBRG", FONTDATA, Brushes.Black, 125, 75, KIRI)
        e.Graphics.DrawString("NAMA BARANG", FONTDATA, Brushes.Black, 200, 75, KIRI)
        e.Graphics.DrawString("HRG BELI", FONTDATA, Brushes.Black, 400, 75, KANAN)
        e.Graphics.DrawString("HRG JUAL", FONTDATA, Brushes.Black, 500, 75, KANAN)
        e.Graphics.DrawString("JML AWAL", FONTDATA, Brushes.Black, 575, 75, KANAN)
        e.Graphics.DrawString("JML BELI", FONTDATA, Brushes.Black, 650, 75, KANAN)
        e.Graphics.DrawString("JML JUAL", FONTDATA, Brushes.Black, 725, 75, KANAN)
        e.Graphics.DrawString("JML STOK", FONTDATA, Brushes.Black, 800, 75, KANAN)
        e.Graphics.DrawLine(Pens.Black, 30, 100, 805, 1000)
        BARIS = 105
        NOMOR = 1
        SQLSTR = "SELECT * FROM BARANG"
        CMD = New OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            e.Graphics.DrawString(NOMOR, FONTDATA, Brushes.Black, 100, BARIS, KANAN)
            e.Graphics.DrawString(DR("KODEBRG"), FONTDATA, Brushes.Black, 125, BARIS, KIRI)
            e.Graphics.DrawString(DR("NAMABRG"), FONTDATA, Brushes.Black, 200, BARIS, KIRI)
            e.Graphics.DrawString(Format(DR("HRGBELI"), "#,#"), FONTDATA, Brushes.Black, 400, BARIS, KANAN)
            e.Graphics.DrawString(Format(DR("HRGJUAL"), "#,#"), FONTDATA, Brushes.Black, 500, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLAWAL"), FONTDATA, Brushes.Black, 575, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLBELI"), FONTDATA, Brushes.Black, 650, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLJUAL"), FONTDATA, Brushes.Black, 725, BARIS, KANAN)
            e.Graphics.DrawString(DR("JMLSTOK"), FONTDATA, Brushes.Black, 800, BARIS, KANAN)
            NOMOR = NOMOR + 1
            BARIS = BARIS + 20
        End While
        e.Graphics.DrawLine(Pens.Black, 30, BARIS + 5, 805, BARIS + 5)
        DR.Close()
    End Sub
    Private Sub CETAKBARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKBARANGToolStripMenuItem.Click
        PDBARANG.Print()
    End Sub
    Private Sub CETAKFAKTURPEMBELIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKFAKTURPEMBELIANToolStripMenuItem.Click
        FormCETAKFAKTURPEMBELIAN.ShowDialog()
    End Sub
    Private Sub CETAKPEMBELIANPERPERIODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKPEMBELIANPERPERIODEToolStripMenuItem.Click
        FormCTKPMBELIANPERPERIODE.ShowDialog()
    End Sub
    Private Sub CETAKPENJUALANPERPERIODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKPENJUALANPERPERIODEToolStripMenuItem.Click
        FormCTKJLPERPERIODE.ShowDialog()
    End Sub
    Private Sub CETAKPENJUALANPERNOTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CETAKPENJUALANPERNOTAToolStripMenuItem.Click
        FormCKTNOTA.ShowDialog()
    End Sub
    Private Sub HAKAKSESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAKAKSESToolStripMenuItem.Click
        FormHAKAKSES.ShowDialog()
    End Sub
    Private Sub DATAPEMAKAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAPEMAKAIToolStripMenuItem.Click
        FormPemakai.ShowDialog()
    End Sub
End Class