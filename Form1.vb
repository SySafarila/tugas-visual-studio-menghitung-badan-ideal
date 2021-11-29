Public Class Form1
    Private Sub BtnCek_Click(sender As Object, e As EventArgs) Handles BtnCek.Click
        Dim bb As Single
        Dim tb As Single
        Dim bi As Single

        tb = TextTinggiBadan.Text
        bb = TextBeratBadan.Text
        bi = (tb - 110) * 1.1

        If (bb > (1.1 * bi)) Then
            MessageBox.Show("Anda gemuuuuk")
        Else
            If (bb < (0.9 * bi)) Then
                MessageBox.Show("Anda Kuruuuus")
            Else
                MessageBox.Show("Anda ideal, gooood")
            End If
        End If
    End Sub
End Class
