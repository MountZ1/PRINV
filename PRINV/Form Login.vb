Imports System.Data
Imports System.Data.OleDb
Public Class FormLOGIN
    Public SQLSTR As String
    Public KONEKSI As OleDb.OleDbConnection
    Public CMD As OleDb.OleDbCommand
    Public DA As OleDb.OleDbDataAdapter
    Public DT As DataTable
    Public DR As OleDbDataReader
    Public KONEKSISTRING As String
    Public LOKASI As String
    Public XKODEPK As String
    Public XPASSWORD As String
    Private Sub FormLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOKASI = System.Environment.CurrentDirectory
        KONEKSISTRING = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & LOKASI & "\DBINV.mdb"
        KONEKSI = New OleDb.OleDbConnection(KONEKSISTRING)
        KONEKSI.Open()
        '''''''''''''
        SQLSTR = "SELECT * FROM PEMAKAI"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        TXTKDPEMAKAI.Items.Clear()
        While DR.Read
            TXTKDPEMAKAI.Items.Add(DR("KODEPK") & "")
        End While
        DR.Close()
    End Sub
    Sub KOSONG()
        TXTKDPEMAKAI.Text = ""
        TXTNMPEMAKAI.Text = ""
        TXTJABATAN.Text = ""
        TXTPASSWORD.Text = ""
        PictureBox1.Image = Nothing
        TXTKDPEMAKAI.Focus()
    End Sub
    Private Sub FormLOGIN_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        KOSONG()
    End Sub
    Private Sub TXTKDPEMAKAI_SelectedValueChanged(sender As Object, e As EventArgs) Handles TXTKDPEMAKAI.SelectedValueChanged
        XKODEPK = Microsoft.VisualBasic.Left(TXTKDPEMAKAI.Text, 5)
        SQLSTR = "SELECT * FROM PEMAKAI WHERE KODEPK='" & XKODEPK & "'"
        CMD = New OleDb.OleDbCommand(SQLSTR, KONEKSI)
        DR = CMD.ExecuteReader
        While DR.Read
            TXTNMPEMAKAI.Text = DR("NAMAPK")
            TXTJABATAN.Text = DR("JABATAN")
            XPASSWORD = DR("PASWORD")
            PictureBox1.Image = Image.FromFile(DR("foto"))
        End While
        DR.Close()
        TXTPASSWORD.Focus()
    End Sub
    Private Sub BTLOGIN_Click(sender As Object, e As EventArgs) Handles BTLOGIN.Click
        If TXTPASSWORD.Text = XPASSWORD Then
            Select Case TXTJABATAN.Text
                Case "MANAGER"
                    Form_MENUUTAMA.MASTERToolStripMenuItem.Enabled = False
                    Form_MENUUTAMA.TRANSAKSIPEMBELIANToolStripMenuItem.Enabled = False
                    Form_MENUUTAMA.CETAKBARANGToolStripMenuItem.Enabled = True
                    Form_MENUUTAMA.SELESAIToolStripMenuItem.Enabled = True
                Case "KEUANGAN"
                    Form_MENUUTAMA.MASTERToolStripMenuItem.Enabled = False
                    Form_MENUUTAMA.TRANSAKSIPEMBELIANToolStripMenuItem.Enabled = True
                    Form_MENUUTAMA.CETAKBARANGToolStripMenuItem.Enabled = True
                    Form_MENUUTAMA.SELESAIToolStripMenuItem.Enabled = True
                Case "ADMINISTRASI"
                    Form_MENUUTAMA.MASTERToolStripMenuItem.Enabled = True
                    Form_MENUUTAMA.TRANSAKSIPEMBELIANToolStripMenuItem.Enabled = False
                    Form_MENUUTAMA.CETAKBARANGToolStripMenuItem.Enabled = True
                    Form_MENUUTAMA.SELESAIToolStripMenuItem.Enabled = True
            End Select
            Form_MENUUTAMA.ShowDialog()
        Else
            Dim X As String
            X = MsgBox("PASSWORD SALAH!!", vbOKOnly)
            TXTPASSWORD.Text = ""
            TXTPASSWORD.Focus()
        End If
        If TXTPASSWORD.Text = XPASSWORD Then
            SQLSTR = "SELECT * FROM HAKAKSES WHERE JABATAN ='" & TXTJABATAN.Text & "'"
            CMD = New OleDbCommand(SQLSTR, KONEKSI)
            DR = CMD.ExecuteReader
            While DR.Read
                If DR("MASTER") = True Then
                    Form_MENUUTAMA.MASTERToolStripMenuItem.Enabled = True
                Else
                    Form_MENUUTAMA.MASTERToolStripMenuItem.Enabled = False
                End If
                If DR("TRANSAKSI") = True Then
                    Form_MENUUTAMA.TRANSAKSIToolStripMenuItem.Enabled = True
                Else
                    Form_MENUUTAMA.TRANSAKSIToolStripMenuItem.Enabled = False
                End If
                If DR("CETAK") = True Then
                    Form_MENUUTAMA.CETAKToolStripMenuItem.Enabled = True
                Else
                    Form_MENUUTAMA.CETAKToolStripMenuItem.Enabled = False
                End If
                If DR("HAKAKSES") = True Then
                    Form_MENUUTAMA.HAKAKSESToolStripMenuItem.Enabled = True
                Else
                    Form_MENUUTAMA.HAKAKSESToolStripMenuItem.Enabled = False
                End If
                If DR("SELESAI") = True Then
                    Form_MENUUTAMA.SELESAIToolStripMenuItem.Enabled = True
                Else
                    Form_MENUUTAMA.SELESAIToolStripMenuItem.Enabled = False
                End If
            End While
            DR.Close()
            Form_MENUUTAMA.ShowDialog()
        Else
            Dim X As String
            X = MsgBox("PASSWORD SALAH!!", vbOKOnly)
            TXTPASSWORD.Text = ""
            TXTPASSWORD.Focus()
        End If
    End Sub

    Private Sub BTCLOSE_Click(sender As Object, e As EventArgs) Handles BTCLOSE.Click
        Me.Close()
        KONEKSI.Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TXTPASSWORD.PasswordChar = ""
        Else
            TXTPASSWORD.PasswordChar = "*"
        End If
    End Sub
End Class