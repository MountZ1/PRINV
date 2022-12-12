<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJUAL
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
        Me.TXTNONOTA = New System.Windows.Forms.TextBox()
        Me.TXTNMCST = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTTAMBAH = New System.Windows.Forms.Button()
        Me.BTSIMPAN = New System.Windows.Forms.Button()
        Me.BTBLANK = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.TXTNMBRG = New System.Windows.Forms.TextBox()
        Me.TXTHRGJUAL = New System.Windows.Forms.TextBox()
        Me.TXTJUMLAH = New System.Windows.Forms.TextBox()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.DGVDETAILJUAL = New System.Windows.Forms.DataGridView()
        Me.DTGV1 = New System.Windows.Forms.DataGridView()
        Me.TXTKDCST = New System.Windows.Forms.ComboBox()
        Me.TXTKDBRG = New System.Windows.Forms.ComboBox()
        CType(Me.DGVDETAILJUAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM TRANSAKSI PENJUALAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO NOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TANGGAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "KODE CUSTOMER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(446, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NAMA CUSTOMER"
        '
        'TXTNONOTA
        '
        Me.TXTNONOTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNONOTA.Location = New System.Drawing.Point(247, 84)
        Me.TXTNONOTA.Name = "TXTNONOTA"
        Me.TXTNONOTA.Size = New System.Drawing.Size(166, 35)
        Me.TXTNONOTA.TabIndex = 2
        '
        'TXTNMCST
        '
        Me.TXTNMCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMCST.Location = New System.Drawing.Point(696, 131)
        Me.TXTNMCST.Name = "TXTNMCST"
        Me.TXTNMCST.ReadOnly = True
        Me.TXTNMCST.Size = New System.Drawing.Size(263, 35)
        Me.TXTNMCST.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(247, 131)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 35)
        Me.DateTimePicker1.TabIndex = 3
        '
        'BTTAMBAH
        '
        Me.BTTAMBAH.Location = New System.Drawing.Point(184, 183)
        Me.BTTAMBAH.Name = "BTTAMBAH"
        Me.BTTAMBAH.Size = New System.Drawing.Size(128, 42)
        Me.BTTAMBAH.TabIndex = 5
        Me.BTTAMBAH.Text = "TAMBAH"
        Me.BTTAMBAH.UseVisualStyleBackColor = True
        '
        'BTSIMPAN
        '
        Me.BTSIMPAN.Location = New System.Drawing.Point(352, 183)
        Me.BTSIMPAN.Name = "BTSIMPAN"
        Me.BTSIMPAN.Size = New System.Drawing.Size(128, 42)
        Me.BTSIMPAN.TabIndex = 5
        Me.BTSIMPAN.Text = "SIMPAN"
        Me.BTSIMPAN.UseVisualStyleBackColor = True
        '
        'BTBLANK
        '
        Me.BTBLANK.Location = New System.Drawing.Point(518, 183)
        Me.BTBLANK.Name = "BTBLANK"
        Me.BTBLANK.Size = New System.Drawing.Size(128, 42)
        Me.BTBLANK.TabIndex = 5
        Me.BTBLANK.Text = "BLANKFORM"
        Me.BTBLANK.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Location = New System.Drawing.Point(683, 183)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(128, 42)
        Me.BTCLOSE.TabIndex = 5
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'TXTNMBRG
        '
        Me.TXTNMBRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMBRG.Location = New System.Drawing.Point(269, 245)
        Me.TXTNMBRG.Name = "TXTNMBRG"
        Me.TXTNMBRG.ReadOnly = True
        Me.TXTNMBRG.Size = New System.Drawing.Size(197, 35)
        Me.TXTNMBRG.TabIndex = 2
        '
        'TXTHRGJUAL
        '
        Me.TXTHRGJUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHRGJUAL.Location = New System.Drawing.Point(472, 246)
        Me.TXTHRGJUAL.Name = "TXTHRGJUAL"
        Me.TXTHRGJUAL.ReadOnly = True
        Me.TXTHRGJUAL.Size = New System.Drawing.Size(197, 35)
        Me.TXTHRGJUAL.TabIndex = 2
        '
        'TXTJUMLAH
        '
        Me.TXTJUMLAH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJUMLAH.Location = New System.Drawing.Point(675, 245)
        Me.TXTJUMLAH.Name = "TXTJUMLAH"
        Me.TXTJUMLAH.Size = New System.Drawing.Size(88, 35)
        Me.TXTJUMLAH.TabIndex = 2
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(769, 245)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(190, 35)
        Me.TXTTOTAL.TabIndex = 2
        '
        'DGVDETAILJUAL
        '
        Me.DGVDETAILJUAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDETAILJUAL.Location = New System.Drawing.Point(74, 297)
        Me.DGVDETAILJUAL.Name = "DGVDETAILJUAL"
        Me.DGVDETAILJUAL.RowHeadersWidth = 62
        Me.DGVDETAILJUAL.RowTemplate.Height = 28
        Me.DGVDETAILJUAL.Size = New System.Drawing.Size(884, 191)
        Me.DGVDETAILJUAL.TabIndex = 7
        '
        'DTGV1
        '
        Me.DTGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGV1.Location = New System.Drawing.Point(12, 502)
        Me.DTGV1.Name = "DTGV1"
        Me.DTGV1.RowHeadersWidth = 62
        Me.DTGV1.RowTemplate.Height = 28
        Me.DTGV1.Size = New System.Drawing.Size(1004, 227)
        Me.DTGV1.TabIndex = 8
        '
        'TXTKDCST
        '
        Me.TXTKDCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKDCST.FormattingEnabled = True
        Me.TXTKDCST.Location = New System.Drawing.Point(696, 83)
        Me.TXTKDCST.Name = "TXTKDCST"
        Me.TXTKDCST.Size = New System.Drawing.Size(261, 37)
        Me.TXTKDCST.TabIndex = 9
        '
        'TXTKDBRG
        '
        Me.TXTKDBRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKDBRG.FormattingEnabled = True
        Me.TXTKDBRG.Location = New System.Drawing.Point(74, 243)
        Me.TXTKDBRG.Name = "TXTKDBRG"
        Me.TXTKDBRG.Size = New System.Drawing.Size(189, 37)
        Me.TXTKDBRG.TabIndex = 9
        '
        'FormJUAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 755)
        Me.Controls.Add(Me.TXTKDBRG)
        Me.Controls.Add(Me.TXTKDCST)
        Me.Controls.Add(Me.DTGV1)
        Me.Controls.Add(Me.DGVDETAILJUAL)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.BTBLANK)
        Me.Controls.Add(Me.BTSIMPAN)
        Me.Controls.Add(Me.BTTAMBAH)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.TXTJUMLAH)
        Me.Controls.Add(Me.TXTHRGJUAL)
        Me.Controls.Add(Me.TXTNMBRG)
        Me.Controls.Add(Me.TXTNMCST)
        Me.Controls.Add(Me.TXTNONOTA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormJUAL"
        Me.Text = "FORMJUAL"
        CType(Me.DGVDETAILJUAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTNONOTA As TextBox
    Friend WithEvents TXTNMCST As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BTTAMBAH As Button
    Friend WithEvents BTSIMPAN As Button
    Friend WithEvents BTBLANK As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents TXTNMBRG As TextBox
    Friend WithEvents TXTHRGJUAL As TextBox
    Friend WithEvents TXTJUMLAH As TextBox
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents DGVDETAILJUAL As DataGridView
    Friend WithEvents DTGV1 As DataGridView
    Friend WithEvents TXTKDCST As ComboBox
    Friend WithEvents TXTKDBRG As ComboBox
End Class
