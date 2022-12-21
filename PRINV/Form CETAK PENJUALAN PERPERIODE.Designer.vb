<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCTKJLPERPERIODE
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
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.BTPREVIEW = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXTTANGGAL = New System.Windows.Forms.ComboBox()
        Me.TXTMULAI = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PDJUALPERPERIODE = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCLOSE.Location = New System.Drawing.Point(534, 201)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(160, 48)
        Me.BTCLOSE.TabIndex = 13
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'BTPREVIEW
        '
        Me.BTPREVIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTPREVIEW.Location = New System.Drawing.Point(264, 201)
        Me.BTPREVIEW.Name = "BTPREVIEW"
        Me.BTPREVIEW.Size = New System.Drawing.Size(160, 48)
        Me.BTPREVIEW.TabIndex = 14
        Me.BTPREVIEW.Text = "PREVIEW"
        Me.BTPREVIEW.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(59, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(848, 360)
        Me.DataGridView1.TabIndex = 12
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTANGGAL.FormattingEnabled = True
        Me.TXTTANGGAL.Location = New System.Drawing.Point(490, 135)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.Size = New System.Drawing.Size(228, 37)
        Me.TXTTANGGAL.TabIndex = 10
        '
        'TXTMULAI
        '
        Me.TXTMULAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMULAI.FormattingEnabled = True
        Me.TXTMULAI.Location = New System.Drawing.Point(490, 89)
        Me.TXTMULAI.Name = "TXTMULAI"
        Me.TXTMULAI.Size = New System.Drawing.Size(228, 37)
        Me.TXTMULAI.Sorted = True
        Me.TXTMULAI.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SAMPAI TANGGAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "MULAI TANGGAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FORM CETAK PENJUALAN PERPERIODE"
        '
        'PDJUALPERPERIODE
        '
        '
        'FormCTKJLPERPERIODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 690)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTPREVIEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.TXTMULAI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCTKJLPERPERIODE"
        Me.Text = "Form CETAK PENJUALAN PERPERIODE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTCLOSE As Button
    Friend WithEvents BTPREVIEW As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTTANGGAL As ComboBox
    Friend WithEvents TXTMULAI As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PDJUALPERPERIODE As Printing.PrintDocument
End Class
