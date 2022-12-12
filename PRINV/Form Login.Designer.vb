<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLOGIN
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BTLOGIN = New System.Windows.Forms.Button()
        Me.BTCLOSE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTPASSWORD = New System.Windows.Forms.TextBox()
        Me.TXTJABATAN = New System.Windows.Forms.TextBox()
        Me.TXTNMPEMAKAI = New System.Windows.Forms.TextBox()
        Me.TXTKDPEMAKAI = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(300, 291)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(183, 24)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "SHOW PASSWORD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BTLOGIN
        '
        Me.BTLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLOGIN.Location = New System.Drawing.Point(207, 399)
        Me.BTLOGIN.Name = "BTLOGIN"
        Me.BTLOGIN.Size = New System.Drawing.Size(110, 45)
        Me.BTLOGIN.TabIndex = 17
        Me.BTLOGIN.Text = "LOGIN"
        Me.BTLOGIN.UseVisualStyleBackColor = True
        '
        'BTCLOSE
        '
        Me.BTCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCLOSE.Location = New System.Drawing.Point(438, 399)
        Me.BTCLOSE.Name = "BTCLOSE"
        Me.BTCLOSE.Size = New System.Drawing.Size(110, 45)
        Me.BTCLOSE.TabIndex = 18
        Me.BTCLOSE.Text = "CLOSE"
        Me.BTCLOSE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(605, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 264)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TXTPASSWORD
        '
        Me.TXTPASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASSWORD.Location = New System.Drawing.Point(300, 249)
        Me.TXTPASSWORD.Name = "TXTPASSWORD"
        Me.TXTPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD.Size = New System.Drawing.Size(182, 35)
        Me.TXTPASSWORD.TabIndex = 13
        '
        'TXTJABATAN
        '
        Me.TXTJABATAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJABATAN.Location = New System.Drawing.Point(300, 190)
        Me.TXTJABATAN.Name = "TXTJABATAN"
        Me.TXTJABATAN.Size = New System.Drawing.Size(220, 35)
        Me.TXTJABATAN.TabIndex = 14
        '
        'TXTNMPEMAKAI
        '
        Me.TXTNMPEMAKAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNMPEMAKAI.Location = New System.Drawing.Point(300, 138)
        Me.TXTNMPEMAKAI.Name = "TXTNMPEMAKAI"
        Me.TXTNMPEMAKAI.Size = New System.Drawing.Size(248, 35)
        Me.TXTNMPEMAKAI.TabIndex = 15
        '
        'TXTKDPEMAKAI
        '
        Me.TXTKDPEMAKAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTKDPEMAKAI.FormattingEnabled = True
        Me.TXTKDPEMAKAI.Location = New System.Drawing.Point(300, 90)
        Me.TXTKDPEMAKAI.Name = "TXTKDPEMAKAI"
        Me.TXTKDPEMAKAI.Size = New System.Drawing.Size(182, 37)
        Me.TXTKDPEMAKAI.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NAMA PEMAKAI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "JABATAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "KODE PEMAKAI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FORM LOGIN PEMAKAI"
        '
        'FormLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 505)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BTLOGIN)
        Me.Controls.Add(Me.BTCLOSE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXTPASSWORD)
        Me.Controls.Add(Me.TXTJABATAN)
        Me.Controls.Add(Me.TXTNMPEMAKAI)
        Me.Controls.Add(Me.TXTKDPEMAKAI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLOGIN"
        Me.Text = "Form LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BTLOGIN As Button
    Friend WithEvents BTCLOSE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXTPASSWORD As TextBox
    Friend WithEvents TXTJABATAN As TextBox
    Friend WithEvents TXTNMPEMAKAI As TextBox
    Friend WithEvents TXTKDPEMAKAI As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
