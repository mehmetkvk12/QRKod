<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OkuBtn = New System.Windows.Forms.Button()
        Me.YazdirBtn = New System.Windows.Forms.Button()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.QRKodOlusturBtn = New System.Windows.Forms.Button()
        Me.OlcekNUD = New System.Windows.Forms.NumericUpDown()
        Me.VersiyonNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SeviyeCBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ByteRBtn = New System.Windows.Forms.RadioButton()
        Me.SayiRBtn = New System.Windows.Forms.RadioButton()
        Me.MetinRBtn = New System.Windows.Forms.RadioButton()
        Me.VeriTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QRPBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.KaydetSFD = New System.Windows.Forms.SaveFileDialog()
        Me.QRDoc = New System.Drawing.Printing.PrintDocument()
        Me.YaziciDiyalog = New System.Windows.Forms.PrintDialog()
        Me.DosyaAcOFD = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OlcekNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersiyonNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QRPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(891, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OkuBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.YazdirBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KaydetBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.QRKodOlusturBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OlcekNUD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VersiyonNUD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SeviyeCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VeriTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.QRPBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(891, 606)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 2
        '
        'OkuBtn
        '
        Me.OkuBtn.Image = Global.QRKod.My.Resources.Resources.qr_code_read
        Me.OkuBtn.Location = New System.Drawing.Point(185, 522)
        Me.OkuBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.OkuBtn.Name = "OkuBtn"
        Me.OkuBtn.Size = New System.Drawing.Size(83, 62)
        Me.OkuBtn.TabIndex = 12
        Me.OkuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.OkuBtn, "QR Kodu Oku")
        Me.OkuBtn.UseVisualStyleBackColor = True
        '
        'YazdirBtn
        '
        Me.YazdirBtn.Image = Global.QRKod.My.Resources.Resources.print
        Me.YazdirBtn.Location = New System.Drawing.Point(103, 522)
        Me.YazdirBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.YazdirBtn.Name = "YazdirBtn"
        Me.YazdirBtn.Size = New System.Drawing.Size(83, 62)
        Me.YazdirBtn.TabIndex = 11
        Me.YazdirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.YazdirBtn, "QR Kodu Yazdır")
        Me.YazdirBtn.UseVisualStyleBackColor = True
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Image = Global.QRKod.My.Resources.Resources.Save
        Me.KaydetBtn.Location = New System.Drawing.Point(20, 522)
        Me.KaydetBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(83, 62)
        Me.KaydetBtn.TabIndex = 10
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.KaydetBtn, "Qr Kodu Kaydet")
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'QRKodOlusturBtn
        '
        Me.QRKodOlusturBtn.Image = Global.QRKod.My.Resources.Resources.Qr_Code
        Me.QRKodOlusturBtn.Location = New System.Drawing.Point(20, 460)
        Me.QRKodOlusturBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.QRKodOlusturBtn.Name = "QRKodOlusturBtn"
        Me.QRKodOlusturBtn.Size = New System.Drawing.Size(248, 62)
        Me.QRKodOlusturBtn.TabIndex = 9
        Me.QRKodOlusturBtn.Text = "QR Kod Oluştur"
        Me.QRKodOlusturBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.QRKodOlusturBtn.UseVisualStyleBackColor = True
        '
        'OlcekNUD
        '
        Me.OlcekNUD.Location = New System.Drawing.Point(180, 417)
        Me.OlcekNUD.Margin = New System.Windows.Forms.Padding(4)
        Me.OlcekNUD.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.OlcekNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.OlcekNUD.Name = "OlcekNUD"
        Me.OlcekNUD.Size = New System.Drawing.Size(83, 22)
        Me.OlcekNUD.TabIndex = 8
        Me.OlcekNUD.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'VersiyonNUD
        '
        Me.VersiyonNUD.Location = New System.Drawing.Point(20, 417)
        Me.VersiyonNUD.Margin = New System.Windows.Forms.Padding(4)
        Me.VersiyonNUD.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.VersiyonNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VersiyonNUD.Name = "VersiyonNUD"
        Me.VersiyonNUD.Size = New System.Drawing.Size(83, 22)
        Me.VersiyonNUD.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.VersiyonNUD, "QR Kod Versiyonunu Seç")
        Me.VersiyonNUD.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 398)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ölçek:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 398)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Versiyon:"
        '
        'SeviyeCBox
        '
        Me.SeviyeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeviyeCBox.FormattingEnabled = True
        Me.SeviyeCBox.Items.AddRange(New Object() {"Düşük", "Orta", "Kaliteli", "Yüksek"})
        Me.SeviyeCBox.Location = New System.Drawing.Point(20, 368)
        Me.SeviyeCBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SeviyeCBox.Name = "SeviyeCBox"
        Me.SeviyeCBox.Size = New System.Drawing.Size(248, 24)
        Me.SeviyeCBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 348)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Doğrulama Seviyesi:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ByteRBtn)
        Me.GroupBox1.Controls.Add(Me.SayiRBtn)
        Me.GroupBox1.Controls.Add(Me.MetinRBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 230)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(249, 114)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veri Türü"
        '
        'ByteRBtn
        '
        Me.ByteRBtn.AutoSize = True
        Me.ByteRBtn.Location = New System.Drawing.Point(27, 82)
        Me.ByteRBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ByteRBtn.Name = "ByteRBtn"
        Me.ByteRBtn.Size = New System.Drawing.Size(55, 20)
        Me.ByteRBtn.TabIndex = 2
        Me.ByteRBtn.Text = "Byte"
        Me.ByteRBtn.UseVisualStyleBackColor = True
        '
        'SayiRBtn
        '
        Me.SayiRBtn.AutoSize = True
        Me.SayiRBtn.Location = New System.Drawing.Point(27, 54)
        Me.SayiRBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SayiRBtn.Name = "SayiRBtn"
        Me.SayiRBtn.Size = New System.Drawing.Size(55, 20)
        Me.SayiRBtn.TabIndex = 1
        Me.SayiRBtn.Text = "Sayı"
        Me.SayiRBtn.UseVisualStyleBackColor = True
        '
        'MetinRBtn
        '
        Me.MetinRBtn.AutoSize = True
        Me.MetinRBtn.Checked = True
        Me.MetinRBtn.Location = New System.Drawing.Point(27, 26)
        Me.MetinRBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.MetinRBtn.Name = "MetinRBtn"
        Me.MetinRBtn.Size = New System.Drawing.Size(60, 20)
        Me.MetinRBtn.TabIndex = 0
        Me.MetinRBtn.TabStop = True
        Me.MetinRBtn.Text = "Metin"
        Me.MetinRBtn.UseVisualStyleBackColor = True
        '
        'VeriTBox
        '
        Me.VeriTBox.Location = New System.Drawing.Point(20, 43)
        Me.VeriTBox.Margin = New System.Windows.Forms.Padding(4)
        Me.VeriTBox.Multiline = True
        Me.VeriTBox.Name = "VeriTBox"
        Me.VeriTBox.Size = New System.Drawing.Size(248, 179)
        Me.VeriTBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.VeriTBox, "QR Kodu Oluşturulacak Veriyi Giriniz")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Veri:"
        '
        'QRPBox
        '
        Me.QRPBox.BackColor = System.Drawing.Color.White
        Me.QRPBox.Location = New System.Drawing.Point(0, 0)
        Me.QRPBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QRPBox.Name = "QRPBox"
        Me.QRPBox.Size = New System.Drawing.Size(235, 192)
        Me.QRPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.QRPBox.TabIndex = 0
        Me.QRPBox.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'QRDoc
        '
        '
        'YaziciDiyalog
        '
        Me.YaziciDiyalog.UseEXDialog = True
        '
        'DosyaAcOFD
        '
        Me.DosyaAcOFD.FileName = "OpenFileDialog1"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 652)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AnaForm"
        Me.Text = "QR Kod"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OlcekNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VersiyonNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QRPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents QRKodOlusturBtn As Button
    Friend WithEvents OlcekNUD As NumericUpDown
    Friend WithEvents VersiyonNUD As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SeviyeCBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ByteRBtn As RadioButton
    Friend WithEvents SayiRBtn As RadioButton
    Friend WithEvents MetinRBtn As RadioButton
    Friend WithEvents VeriTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QRPBox As PictureBox
    Friend WithEvents OkuBtn As Button
    Friend WithEvents YazdirBtn As Button
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents KaydetSFD As SaveFileDialog
    Friend WithEvents QRDoc As Printing.PrintDocument
    Friend WithEvents YaziciDiyalog As PrintDialog
    Friend WithEvents DosyaAcOFD As OpenFileDialog
End Class
