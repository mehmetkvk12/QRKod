Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Imports ThoughtWorks.QRCode.Codec.Util
Imports Qr.Net.Imaging
Imports System.Text
Public Class AnaForm
    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeviyeCBox.DropDownStyle = ComboBoxStyle.DropDownList
        SeviyeCBox.SelectedIndex = 1
        MetinRBtn.Checked = True
        VersiyonNUD.Minimum = 1
        VersiyonNUD.Maximum = 40
        VersiyonNUD.Value = 6
        OlcekNUD.Value = 4
        QRPBox.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub QRKodOlusturBtn_Click(sender As Object, e As EventArgs) Handles QRKodOlusturBtn.Click
        Dim Veri As String = VeriTBox.Text.Trim
        If Veri = String.Empty Then
            MessageBox.Show("QR kodu oluşrutulacak veri bulunamadı. Veri girişi yapınız.", "Hata")
            Exit Sub
        End If
        'QR kodun Veri Tipini Belirle
        Dim QRKodOlusturucu As New QRCodeEncoder
        If MetinRBtn.Checked Then
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
            Veri = BuyukHarf(Veri)
            VeriTBox.Text = Veri
        ElseIf SayiRBtn.Checked Then
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC
        Else
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        End If
        'QR kodun Hata Düzeltme Seviyesini Belirle
        Select Case SeviyeCBox.SelectedIndex
            Case 0
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            Case 1
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
            Case 2
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            Case Else
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        End Select
        'QR kodun Versiyonunu Belirle
        QRKodOlusturucu.QRCodeVersion = VersiyonNUD.Value
        'QR kodun Ölçeğini Belirle
        QRKodOlusturucu.QRCodeScale = OlcekNUD.Value
        Try
            Dim Resim As Image
            Dim QRBilgi = QRKodOlusturucu.Encode(Veri, Encoding.UTF8)
            Dim QRResim As New QrImage
            Resim = QRResim.CreateImage(QRBilgi)
            QRPBox.Image = Resim
        Catch ex As Exception
            MessageBox.Show("QR Kod oluşturulacak veri ile ilgili hata oluştu. Başka bir versiyon veya doğrulama seviyesi seçiniz.", "Hata")
        End Try

    End Sub
    Private Function BuyukHarf(Metin As String) As String
        Metin = Metin.ToUpper
        Dim Turkce As String = "ÖÇŞİĞÜ"
        Dim English As String = "OCSIGU"
        For i = 0 To Turkce.Count - 1
            Metin = Metin.Replace(Turkce(i), English(i))
        Next
        Return Metin
    End Function

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        If IsNothing(QRPBox.Image) Then
            MessageBox.Show("Öncelikle bir QR Kod oluşturmalısınız.", "Hata")
            Exit Sub
        End If
        KaydetSFD.FileName = String.Empty
        KaydetSFD.Filter = "JPEG Dosyası|*.jpg|PNG Dosyası|*.png"
        If KaydetSFD.ShowDialog = DialogResult.OK Then
            Dim DosyaAdi As String = KaydetSFD.FileName
            Dim Resim As Image = QRPBox.Image
            If KaydetSFD.FilterIndex = 1 Then
                Resim.Save(DosyaAdi, Imaging.ImageFormat.Jpeg)
            Else
                Resim.Save(DosyaAdi, Imaging.ImageFormat.Png)
            End If
        End If
    End Sub

    Private Sub YazdirBtn_Click(sender As Object, e As EventArgs) Handles YazdirBtn.Click
        If IsNothing(QRPBox.Image) Then
            MessageBox.Show("Öncelikle bir QR Kod oluşturmalısınız.", "Hata")
            Exit Sub
        End If
        QRDoc.DocumentName = ""
        QRDoc.DefaultPageSettings.Margins = New Printing.Margins(1, 1, 1, 1)
        YaziciDiyalog.Document = QRDoc
        If YaziciDiyalog.ShowDialog = DialogResult.OK Then
            QRDoc.Print()
        End If
    End Sub

    Private Sub QRDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles QRDoc.PrintPage
        e.Graphics.DrawImage(QRPBox.Image, 20, 20)
    End Sub

    Private Sub OkuBtn_Click(sender As Object, e As EventArgs) Handles OkuBtn.Click
        DosyaAcOFD.FileName = String.Empty
        'DosyaAcOFD.Filter = "JPEG Dosyası|*.jpg;*.jpeg|PNG Dosyası|*.png"
        If DosyaAcOFD.ShowDialog = DialogResult.OK Then
            Dim DosyaAdi As String = DosyaAcOFD.FileName
            Dim Resim As Image = Image.FromFile(DosyaAdi)
            QRPBox.Image = Resim
            Try
                Dim QROkuyucu As New QRCodeDecoder
                Dim Veri As String = QROkuyucu.decode(New QRCodeBitmapImage(New Bitmap(Resim)), Encoding.UTF8)
                VeriTBox.Text = Veri
            Catch ex As Exception
                MessageBox.Show("QR Kod okunamadı. Başka bir QR Kod deneyiniz.", "Hata")
            End Try
        End If
    End Sub

    Private Sub QRPBox_Click(sender As Object, e As EventArgs) Handles QRPBox.Click

    End Sub
End Class
