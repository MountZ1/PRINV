Imports System.Data
Imports System.Data.OleDb

Public Class FormPemakai
    Public SQLSTR As String
    Public KONEKSI As New OleDb.OleDbConnection
    Public CMD As New OleDb.OleDbCommand
    Public DA As New OleDb.OleDbDataAdapter
    Public DT As New DataTable
    Public DR As OleDbDataReader
    Public LOKASI As String
    Public KONEKSISTRING As String
    Public XFOTO As String
    Private Sub FormPemakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
    End Sub
    Sub KOSONG()
        TXTKDPEMAKAI.Text = ""
        TXTNMPEMAKAI.Text = ""
        TXTJABATAN.Text = ""
        TXTPASSWORD.Text = ""
        PictureBox1.Image = Nothing
        TXTKDPEMAKAI.Focus()
    End Sub
    Sub DGV()
        SQLSTR = "SELECT * FROM PEMAKAI"
        DA = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub
    Private Sub FormPemakai_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DGV()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OFD.ShowDialog()
        PictureBox1.Image = Image.FromFile(OFD.FileName)
        XFOTO = OFD.FileName
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQLSTR = "SELECT * FROM PEMAKAI WHERE KODEPK='" & TXTKDPEMAKAI.Text & "'"
        DA = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            SQLSTR = "UPDATE PEMAKAI SET KODEPK='" & TXTKDPEMAKAI.Text & "',NAMAPK='" & TXTNMPEMAKAI.Text & "',JABATAN'" & TXTJABATAN.Text & "',PASWORD='" & TXTPASSWORD.Text & "',FOTO='" & XFOTO & "'WHERE KODEPK='" & TXTKDPEMAKAI.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        Else
            SQLSTR = "INSERT INTO PEMAKAI VALUES ('" & TXTKDPEMAKAI.Text & "','" & TXTNMPEMAKAI.Text & "','" & TXTJABATAN.Text & "','" & TXTPASSWORD.Text & "','" & XFOTO & "')"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub
    Private Sub TXTKDPEMAKAI_Leave(sender As Object, e As EventArgs) Handles TXTKDPEMAKAI.Leave
        SQLSTR = "SELECT * FROM PEMAKAI WHERE KODEPK='" & TXTKDPEMAKAI.Text & "'"
        DA = New OleDb.OleDbDataAdapter(SQLSTR, KONEKSI)
        DT.Clear()
        DA.Fill(DT)
        DataGridView1.DataSource = DT
        If DT.Rows.Count > 0 Then
            TXTNMPEMAKAI.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(1).Value
            TXTJABATAN.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(2).Value
            TXTPASSWORD.Text = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(3).Value
            PictureBox1.Image = Image.FromFile(DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(4).Value)
            XFOTO = DataGridView1.Rows.Item(DataGridView1.CurrentRow.Index).Cells(4).Value
        End If
        DGV()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As String
        X = MsgBox("INGIN MENGHAPUS USER " & TXTNMPEMAKAI.Text & "??", MsgBoxStyle.YesNo)
        If X = vbYes Then
            SQLSTR = "DELETE FROM PEMAKAI WHERE KODEPK='" & TXTKDPEMAKAI.Text & "'"
            CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
            CMD.ExecuteNonQuery()
        End If
        KOSONG()
        DGV()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KOSONG()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
    Private Sub FormPemakai_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        KONEKSI.Close()
    End Sub
End Class