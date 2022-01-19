﻿Imports System.Data.Odbc
Public Class Form1
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String

    Dim bb As Single
    Dim tb As Single
    Dim bi As Single

    Dim Nama As String
    Dim Id As String
    Dim Hasil As String
    Private Sub BtnCek_Click(sender As Object, e As EventArgs) Handles BtnCek.Click
        If tbId.Text = "" Or tbNama.Text = "" Or TextTinggiBadan.Text = "" Or TextBeratBadan.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Call Koneksi()
            Call CekBeratBadan()

            Dim InputData As String = "Insert into hasilcek values('" & Id & "','" & Nama & "','" & Hasil & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("Input data berhasil")

            Call TampilkanData()

            Nama = ""
            Id = ""
        End If
    End Sub

    Sub Koneksi()
        ' Memanggil database yaitu nama database kita adalah kampus
        MyDB = "Driver={MySQL ODBC 3.51 Driver};Database=beratbadan;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
            ' MsgBox("Koneksi berhasil")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()

        Call TampilkanData()

    End Sub

    Sub TampilkanData()
        Call Koneksi()

        Da = New OdbcDataAdapter("Select * From hasilcek", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "hasilcek")

        DataGridView1.DataSource = Ds.Tables("hasilcek")
    End Sub

    Sub CekBeratBadan()
        Nama = tbNama.Text
        Id = tbId.Text


        tb = TextTinggiBadan.Text
        bb = TextBeratBadan.Text
        bi = (tb - 110) * 1.1

        If (bb > (1.1 * bi)) Then
            MessageBox.Show("Anda gemuuuuk")
            Hasil = "Gemuk"
        Else
            If (bb < (0.9 * bi)) Then
                MessageBox.Show("Anda Kuruuuus")
                Hasil = "Kurus"
            Else
                MessageBox.Show("Anda ideal, gooood")
                Hasil = "Ideal"
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If tbId.Text = "" Or tbNama.Text = "" Or TextTinggiBadan.Text = "" Or TextBeratBadan.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Call CekBeratBadan()
            Call Koneksi()

            Dim EditData As String = "Update hasilcek set nama='" & Nama & "',hasil='" & Hasil & "'where id='" & Id & "'"
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("Edit data berhasil")

            Call TampilkanData()

        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbId.Text = "" Then
            MsgBox("Pastikan field ID terisi")
        Else
            ' Call CekBeratBadan()
            Call Koneksi()

            Dim HapusData As String = "delete from hasilcek where id='" & tbId.Text & "'"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus")

            Call TampilkanData()

        End If
    End Sub
End Class
