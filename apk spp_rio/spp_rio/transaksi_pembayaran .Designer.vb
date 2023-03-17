<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi_pembayaran
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtthnbayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtblnbayar = New System.Windows.Forms.TextBox()
        Me.txtidbayar = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtjmlbayar = New System.Windows.Forms.TextBox()
        Me.dttbayar = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.txtidptgs = New System.Windows.Forms.ComboBox()
        Me.txtnisn = New System.Windows.Forms.ComboBox()
        Me.txtidspp = New System.Windows.Forms.ComboBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "ID Petugas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "ID SPP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(434, 42)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = " Transaksi Pembayaran"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkCyan
        Me.Button5.Location = New System.Drawing.Point(772, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 27)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Tahun di Bayar"
        '
        'txtthnbayar
        '
        Me.txtthnbayar.Location = New System.Drawing.Point(48, 324)
        Me.txtthnbayar.Name = "txtthnbayar"
        Me.txtthnbayar.Size = New System.Drawing.Size(132, 20)
        Me.txtthnbayar.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Bulan Bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "NISN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "ID Pembayaran"
        '
        'txtblnbayar
        '
        Me.txtblnbayar.Location = New System.Drawing.Point(222, 233)
        Me.txtblnbayar.Name = "txtblnbayar"
        Me.txtblnbayar.Size = New System.Drawing.Size(127, 20)
        Me.txtblnbayar.TabIndex = 99
        '
        'txtidbayar
        '
        Me.txtidbayar.Location = New System.Drawing.Point(48, 141)
        Me.txtidbayar.Name = "txtidbayar"
        Me.txtidbayar.Size = New System.Drawing.Size(132, 20)
        Me.txtidbayar.TabIndex = 96
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(641, 421)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 27)
        Me.Button4.TabIndex = 95
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(505, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 27)
        Me.Button3.TabIndex = 94
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 27)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgv_user
        '
        Me.dgv_user.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_user.Location = New System.Drawing.Point(378, 141)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.Size = New System.Drawing.Size(473, 264)
        Me.dgv_user.TabIndex = 92
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(-6, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 79)
        Me.Panel1.TabIndex = 88
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 460)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(903, 81)
        Me.FlowLayoutPanel1.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(227, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 18)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Jumlah Bayar"
        '
        'txtjmlbayar
        '
        Me.txtjmlbayar.Location = New System.Drawing.Point(217, 407)
        Me.txtjmlbayar.Name = "txtjmlbayar"
        Me.txtjmlbayar.Size = New System.Drawing.Size(132, 20)
        Me.txtjmlbayar.TabIndex = 112
        '
        'dttbayar
        '
        Me.dttbayar.Location = New System.Drawing.Point(217, 324)
        Me.dttbayar.Name = "dttbayar"
        Me.dttbayar.Size = New System.Drawing.Size(132, 20)
        Me.dttbayar.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Tanggal Bayar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(766, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 27)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtidptgs
        '
        Me.txtidptgs.FormattingEnabled = True
        Me.txtidptgs.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtidptgs.Location = New System.Drawing.Point(222, 141)
        Me.txtidptgs.Name = "txtidptgs"
        Me.txtidptgs.Size = New System.Drawing.Size(132, 21)
        Me.txtidptgs.TabIndex = 115
        '
        'txtnisn
        '
        Me.txtnisn.FormattingEnabled = True
        Me.txtnisn.Items.AddRange(New Object() {"122", "123", "143", "223", "234", "254", "341", "345", "456", "731"})
        Me.txtnisn.Location = New System.Drawing.Point(48, 233)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(132, 21)
        Me.txtnisn.TabIndex = 116
        '
        'txtidspp
        '
        Me.txtidspp.FormattingEnabled = True
        Me.txtidspp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.txtidspp.Location = New System.Drawing.Point(48, 406)
        Me.txtidspp.Name = "txtidspp"
        Me.txtidspp.Size = New System.Drawing.Size(132, 21)
        Me.txtidspp.TabIndex = 117
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(690, 107)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(161, 20)
        Me.txtcari.TabIndex = 118
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(645, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 18)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Cari"
        '
        'transaksi_pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(901, 540)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.txtidspp)
        Me.Controls.Add(Me.txtnisn)
        Me.Controls.Add(Me.txtidptgs)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtjmlbayar)
        Me.Controls.Add(Me.dttbayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtthnbayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtblnbayar)
        Me.Controls.Add(Me.txtidbayar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv_user)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transaksi_pembayaran"
        Me.Text = "transaksi_pembayaran"
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtthnbayar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtblnbayar As TextBox
    Friend WithEvents txtidbayar As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtjmlbayar As TextBox
    Friend WithEvents dttbayar As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents txtidptgs As ComboBox
    Friend WithEvents txtnisn As ComboBox
    Friend WithEvents txtidspp As ComboBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label10 As Label
End Class
