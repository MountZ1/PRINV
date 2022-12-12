Public Class Form_MENUUTAMA
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
End Class