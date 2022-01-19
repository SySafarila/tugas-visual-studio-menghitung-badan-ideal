Imports System.Data.Odbc
Public Class Form1
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String
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

    Sub Koneksi()
        ' Memanggil database yaitu nama database kita adalah kampus
        MyDB = "Driver={MySQL ODBC 3.51 Driver};Database=beratbadan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
            MsgBox("Koneksi berhasil")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
End Class
