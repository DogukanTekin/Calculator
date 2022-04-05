Public Class Form1
    Dim islem, sil As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox2.Text = 0
        TextBox3.Text = 1
        ' 12+12+12+12....= gibi aynı sembolle yapılan işlemleri yaptırabiliyorum 12/12/12.... vs çalışıyor. 12+12+12*2/5 = gibi işlemlerde sorun yaşıyorum.'
        ' Algoritma olarak buton tıklama takibi düşündüm '
        ' Örnek olarak * butonu için if koşul şartları içerisinde eğer öncesinde + butonuna tıklanıldıysa gerekli işlemleri yap ve sonra çarpma işlemine geç ' 
        ' Bütün işlem butonlarına if ekleyip öncesinde tıklanan buton takibi yapmaya çalıştım '
        ' Algoritmamın bu sorunu çözeceğini düşünüyorum fakat yeterli kod bilgisine sahip olmadığım için düşündüklerimi programa aktaramadım. '
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        islem = "arti"
        TextBox2.Text = (Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox1.Text)).ToString
        TextBox1.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        islem = "eksi"
        If (TextBox2.Text = 0) Then
            TextBox2.Text = (Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text)).ToString
            TextBox1.Text = (TextBox2.Text).ToString
        Else
            TextBox2.Text = (Convert.ToInt32(TextBox2.Text) - Convert.ToInt32(TextBox1.Text)).ToString
            TextBox1.Text = (TextBox2.Text).ToString
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        islem = "carpi"
        TextBox3.Text = (Convert.ToInt32(TextBox3.Text) * Convert.ToInt32(TextBox1.Text)).ToString
        TextBox1.Text = (TextBox3.Text).ToString
        TextBox1.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        islem = "bolu"
        If (TextBox3.Text = 1) Then
            TextBox3.Text = (Convert.ToSingle(TextBox1.Text) / Convert.ToSingle(TextBox3.Text)).ToString
            TextBox1.Text = (TextBox3.Text).ToString
        Else
            TextBox3.Text = (Convert.ToSingle(TextBox3.Text) / Convert.ToSingle(TextBox1.Text)).ToString
            TextBox1.Text = (TextBox3.Text).ToString
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (islem = "arti") Then
            TextBox1.Text = (Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox1.Text)).ToString
        ElseIf (islem = "bolu") Then
            TextBox1.Text = (Convert.ToSingle(TextBox3.Text) / Convert.ToSingle(TextBox1.Text)).ToString
        ElseIf (islem = "eksi") Then
            TextBox1.Text = (Convert.ToInt32(TextBox2.Text) - Convert.ToInt32(TextBox1.Text)).ToString
        ElseIf (islem = "carpi") Then
            TextBox1.Text = (Convert.ToInt32(TextBox3.Text) * Convert.ToInt32(TextBox1.Text)).ToString
        End If
        TextBox2.Text = 0
        TextBox3.Text = 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Clear()
        TextBox2.Text = 0
        TextBox3.Text = 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        sil = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        TextBox1.Text = sil
    End Sub
End Class
