<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCTKPMBELIANPERPERIODE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTMULAI = New System.Windows.Forms.ComboBox()
        Me.TXTTANGGAL = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTPREVIEW = New System.Windows.Forms.Button()
        Me.PDBELIPERIODE = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(631, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM CETAK PEMBELIAN PERPERIODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MULAI TANGGAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SAMPAI TANGGAL"
        '
        'TXTMULAI
        '
        Me.TXTMULAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMULAI.FormattingEnabled = True
        Me.TXTMULAI.Location = New System.Drawing.Point(473, 66)
        Me.TXTMULAI.Name = "TXTMULAI"
        Me.TXTMULAI.Size = New System.Drawing.Size(228, 37)
        Me.TXTMULAI.TabIndex = 2
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTANGGAL.FormattingEnabled = True
        Me.TXTTANGGAL.Location = New System.Drawing.Point(473, 112)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(228, 37)
        Me.TXTTANGGAL.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(848, 360)
        Me.DataGridView1.TabIndex = 3
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCLOSE.Location = New System.Drawing.Point(517, 178)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(160, 48)
        Me.BTCLOSE.TabIndex = 5
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTPREVIEW
        '
        Me.BTPREVIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTPREVIEW.Location = New System.Drawing.Point(247, 178)
        Me.BTPREVIEW.Name = "BTPREVIEW"
        Me.BTPREVIEW.Size = New System.Drawing.Size(160, 48)
        Me.BTPREVIEW.TabIndex = 6
        Me.BTPREVIEW.Text = "PREVIEW"
        Me.BTPREVIEW.UseVisualStyleBackColor = True
        '
        'FormCTKPMBELIANPERPERIODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 653)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTPREVIEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.TXTMULAI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCTKPMBELIANPERPERIODE"
        Me.Text = "Form CETAK PEMBELIAN PERPERIODE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTMULAI As ComboBox
    Friend WithEvents TXTTANGGAL As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTPREVIEW As Button
    Friend WithEvents PDBELIPERIODE As Printing.PrintDocument
End Class
