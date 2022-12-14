<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCETAKFAKTURPEMBELIAN
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
        Me.TXTNOFAKTUR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTANGGAL = New System.Windows.Forms.TextBox()
        Me.TXTKDSUP = New System.Windows.Forms.TextBox()
        Me.TXTNMSUP = New System.Windows.Forms.TextBox()
        Me.BTPREVIEW = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PDBELI = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM CETAK PEMBELIAN PERFAKTUR"
        '
        'TXTNOFAKTUR
        '
        Me.TXTNOFAKTUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOFAKTUR.FormattingEnabled = True
        Me.TXTNOFAKTUR.Location = New System.Drawing.Point(218, 78)
        Me.TXTNOFAKTUR.Name = "TXTNOFAKTUR"
        Me.TXTNOFAKTUR.Size = New System.Drawing.Size(209, 37)
        Me.TXTNOFAKTUR.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NO. FAKTUR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TANGGAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "KODE SUPPLIER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(444, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "NAMA SUPPLIER"
        '
        'TXTTANGGAL
        '
        Me.TXTTANGGAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTANGGAL.Location = New System.Drawing.Point(218, 135)
        Me.TXTTANGGAL.Name = "TXTTANGGAL"
        Me.TXTTANGGAL.ReadOnly = True
        Me.TXTTANGGAL.Size = New System.Drawing.Size(209, 35)
        Me.TXTTANGGAL.TabIndex = 3
        '
        'TXTKDSUP
        '
        Me.TXTKDSUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKDSUP.Location = New System.Drawing.Point(666, 75)
        Me.TXTKDSUP.Name = "TXTKDSUP"
        Me.TXTKDSUP.ReadOnly = True
        Me.TXTKDSUP.Size = New System.Drawing.Size(209, 35)
        Me.TXTKDSUP.TabIndex = 3
        '
        'TXTNMSUP
        '
        Me.TXTNMSUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMSUP.Location = New System.Drawing.Point(666, 135)
        Me.TXTNMSUP.Name = "TXTNMSUP"
        Me.TXTNMSUP.ReadOnly = True
        Me.TXTNMSUP.Size = New System.Drawing.Size(209, 35)
        Me.TXTNMSUP.TabIndex = 3
        '
        'BTPREVIEW
        '
        Me.BTPREVIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTPREVIEW.Location = New System.Drawing.Point(218, 203)
        Me.BTPREVIEW.Name = "BTPREVIEW"
        Me.BTPREVIEW.Size = New System.Drawing.Size(160, 48)
        Me.BTPREVIEW.TabIndex = 4
        Me.BTPREVIEW.Text = "PREVIEW"
        Me.BTPREVIEW.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCLOSE.Location = New System.Drawing.Point(488, 203)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(160, 48)
        Me.BTCLOSE.TabIndex = 4
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(837, 354)
        Me.DataGridView1.TabIndex = 5
        '
        'PDBELI
        '
        '
        'FormCETAKFAKTURPEMBELIAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 653)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTPREVIEW)
        Me.Controls.Add(Me.TXTNMSUP)
        Me.Controls.Add(Me.TXTKDSUP)
        Me.Controls.Add(Me.TXTTANGGAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNOFAKTUR)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCETAKFAKTURPEMBELIAN"
        Me.Text = "Form CETAK PEMBELIAN PERFAKTUR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNOFAKTUR As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTTANGGAL As TextBox
    Friend WithEvents TXTKDSUP As TextBox
    Friend WithEvents TXTNMSUP As TextBox
    Friend WithEvents BTPREVIEW As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PDBELI As Printing.PrintDocument
End Class
