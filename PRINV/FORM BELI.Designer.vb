<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMBELI
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTFAKTUR = New System.Windows.Forms.TextBox()
        Me.TXTNAMASUP = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTTAMBAH = New System.Windows.Forms.Button()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.BTBLANK = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.TXTNAMABRG = New System.Windows.Forms.TextBox()
        Me.TXTHRGBELI = New System.Windows.Forms.TextBox()
        Me.TXTJUMLAH = New System.Windows.Forms.TextBox()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXTKODESUP = New System.Windows.Forms.ComboBox()
        Me.TXTKODEBRG = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM TRANSAKSI PEMBELIAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO FAKTUR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TANGGAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "KODE SUPPLIER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(390, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NAMA SUPPLIER"
        '
        'TXTFAKTUR
        '
        Me.TXTFAKTUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFAKTUR.Location = New System.Drawing.Point(213, 76)
        Me.TXTFAKTUR.Name = "TXTFAKTUR"
        Me.TXTFAKTUR.Size = New System.Drawing.Size(152, 35)
        Me.TXTFAKTUR.TabIndex = 2
        '
        'TXTNAMASUP
        '
        Me.TXTNAMASUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAMASUP.Location = New System.Drawing.Point(613, 141)
        Me.TXTNAMASUP.Name = "TXTNAMASUP"
        Me.TXTNAMASUP.ReadOnly = True
        Me.TXTNAMASUP.Size = New System.Drawing.Size(302, 35)
        Me.TXTNAMASUP.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 149)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 26)
        Me.DateTimePicker1.TabIndex = 3
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Location = New System.Drawing.Point(197, 199)
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Size = New System.Drawing.Size(126, 36)
        Me.BTTAMBAH.TabIndex = 5
        Me.BTTAMBAH.Text = "TAMBAH"
        Me.BTTAMBAH.UseVisualStyleBackColor = True
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Location = New System.Drawing.Point(357, 199)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(126, 36)
        Me.BTSIMPAN.TabIndex = 5
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'BTBLANK
        '
        Me.BTBLANK.Location = New System.Drawing.Point(520, 199)
        Me.BTBLANK.Name = "BTBLANK"
        Me.BTBLANK.Size = New System.Drawing.Size(126, 36)
        Me.BTBLANK.TabIndex = 5
        Me.BTBLANK.Text = "BLANKFORM"
        Me.BTBLANK.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Location = New System.Drawing.Point(677, 199)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(126, 36)
        Me.BTCLOSE.TabIndex = 5
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'TXTNAMABRG
        '
        Me.TXTNAMABRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAMABRG.Location = New System.Drawing.Point(201, 254)
        Me.TXTNAMABRG.Name = "TXTNAMABRG"
        Me.TXTNAMABRG.ReadOnly = True
        Me.TXTNAMABRG.Size = New System.Drawing.Size(190, 35)
        Me.TXTNAMABRG.TabIndex = 7
        '
        'TXTHRGBELI
        '
        Me.TXTHRGBELI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHRGBELI.Location = New System.Drawing.Point(397, 256)
        Me.TXTHRGBELI.Name = "TXTHRGBELI"
        Me.TXTHRGBELI.ReadOnly = True
        Me.TXTHRGBELI.Size = New System.Drawing.Size(200, 35)
        Me.TXTHRGBELI.TabIndex = 7
        '
        'TXTJUMLAH
        '
        Me.TXTJUMLAH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJUMLAH.Location = New System.Drawing.Point(603, 256)
        Me.TXTJUMLAH.Name = "TXTJUMLAH"
        Me.TXTJUMLAH.Size = New System.Drawing.Size(111, 35)
        Me.TXTJUMLAH.TabIndex = 7
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(720, 256)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(195, 35)
        Me.TXTTOTAL.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(945, 344)
        Me.DataGridView1.TabIndex = 8
        '
        'TXTKODESUP
        '
        Me.TXTKODESUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKODESUP.FormattingEnabled = True
        Me.TXTKODESUP.Location = New System.Drawing.Point(613, 79)
        Me.TXTKODESUP.Name = "TXTKODESUP"
        Me.TXTKODESUP.Size = New System.Drawing.Size(302, 37)
        Me.TXTKODESUP.TabIndex = 9
        '
        'TXTKODEBRG
        '
        Me.TXTKODEBRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKODEBRG.FormattingEnabled = True
        Me.TXTKODEBRG.Location = New System.Drawing.Point(48, 252)
        Me.TXTKODEBRG.Name = "TXTKODEBRG"
        Me.TXTKODEBRG.Size = New System.Drawing.Size(133, 37)
        Me.TXTKODEBRG.TabIndex = 9
        '
        'FORMBELI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 660)
        Me.Controls.Add(Me.TXTKODEBRG)
        Me.Controls.Add(Me.TXTKODESUP)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.TXTJUMLAH)
        Me.Controls.Add(Me.TXTHRGBELI)
        Me.Controls.Add(Me.TXTNAMABRG)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANK)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Controls.Add(Me.BTTAMBAH)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXTNAMASUP)
        Me.Controls.Add(Me.TXTFAKTUR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMBELI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM BELI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTFAKTUR As TextBox
    Friend WithEvents TXTNAMASUP As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BTTAMBAH As Button
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents BTBLANK As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents TXTNAMABRG As TextBox
    Friend WithEvents TXTHRGBELI As TextBox
    Friend WithEvents TXTJUMLAH As TextBox
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTKODESUP As ComboBox
    Friend WithEvents TXTKODEBRG As ComboBox
End Class
