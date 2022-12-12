<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCUSTOMER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTKDCST = New System.Windows.Forms.TextBox()
        Me.TXTNMCST = New System.Windows.Forms.TextBox()
        Me.TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.TXTNMRTLP = New System.Windows.Forms.TextBox()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.BTHAPUS = New System.Windows.Forms.Button()
        Me.BTBLANK = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM DATA CUSTOMER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KODE CUSTOMER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NAMA CUSTOMER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ALAMAT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NOMOR TELEPON"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTKDCST
        '
        Me.TXTKDCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKDCST.Location = New System.Drawing.Point(365, 61)
        Me.TXTKDCST.Name = "TXTKDCST"
        Me.TXTKDCST.Size = New System.Drawing.Size(197, 35)
        Me.TXTKDCST.TabIndex = 2
        '
        'TXTNMCST
        '
        Me.TXTNMCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMCST.Location = New System.Drawing.Point(365, 109)
        Me.TXTNMCST.Name = "TXTNMCST"
        Me.TXTNMCST.Size = New System.Drawing.Size(369, 35)
        Me.TXTNMCST.TabIndex = 2
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTALAMAT.Location = New System.Drawing.Point(365, 154)
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.Size = New System.Drawing.Size(369, 35)
        Me.TXTALAMAT.TabIndex = 2
        '
        'TXTNMRTLP
        '
        Me.TXTNMRTLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMRTLP.Location = New System.Drawing.Point(365, 197)
        Me.TXTNMRTLP.Name = "TXTNMRTLP"
        Me.TXTNMRTLP.Size = New System.Drawing.Size(197, 35)
        Me.TXTNMRTLP.TabIndex = 2
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSIMPAN.Location = New System.Drawing.Point(157, 272)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(103, 34)
        Me.BTSIMPAN.TabIndex = 3
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'BTHAPUS
        '
        Me.BTHAPUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTHAPUS.Location = New System.Drawing.Point(278, 272)
        Me.BTHAPUS.Name = "BTHAPUS"
        Me.BTHAPUS.Size = New System.Drawing.Size(103, 34)
        Me.BTHAPUS.TabIndex = 3
        Me.BTHAPUS.Text = "HAPUS"
        Me.BTHAPUS.UseVisualStyleBackColor = True
        '
        'BTBLANK
        '
        Me.BTBLANK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBLANK.Location = New System.Drawing.Point(400, 272)
        Me.BTBLANK.Name = "BTBLANK"
        Me.BTBLANK.Size = New System.Drawing.Size(120, 34)
        Me.BTBLANK.TabIndex = 3
        Me.BTBLANK.Text = "BLANKFORM"
        Me.BTBLANK.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCLOSE.Location = New System.Drawing.Point(537, 272)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(103, 34)
        Me.BTCLOSE.TabIndex = 3
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 322)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(763, 301)
        Me.DataGridView1.TabIndex = 4
        '
        'FormCUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 635)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANK)
        Me.Controls.Add(Me.BTHAPUS)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Controls.Add(Me.TXTNMRTLP)
        Me.Controls.Add(Me.TXTALAMAT)
        Me.Controls.Add(Me.TXTNMCST)
        Me.Controls.Add(Me.TXTKDCST)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCUSTOMER"
        Me.Text = "Form CUSTOMER"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTKDCST As TextBox
    Friend WithEvents TXTNMCST As TextBox
    Friend WithEvents TXTALAMAT As TextBox
    Friend WithEvents TXTNMRTLP As TextBox
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents BTHAPUS As Button
    Friend WithEvents BTBLANK As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
