Imports System.IO
Imports System.Drawing

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PB_1.SizeMode = PictureBoxSizeMode.StretchImage
        PB_2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub


    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog = DialogResult.OK Then

            Try
                If File.Exists(ofd.FileName) Then

                    Using fs As New FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)
                        PB_1.Image = Image.FromStream(fs)
                    End Using

                Else
                    MessageBox.Show("File tidak ditemukan")
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal membuka gambar")
            End Try

        End If

    End Sub


    Private Sub BT_2_Click(sender As Object, e As EventArgs) Handles BT_2.Click

        Dim genderSelected As Boolean = RB_1.Checked Or RB_2.Checked
        Dim h As String = AmbilHobby()

        If InputKosong(TB_1.Text, TB_2.Text, TB_3.Text, TB_4.Text,
                       genderSelected, h, PB_1.Image, PB_2.Image) Then

            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        Nama = TB_1.Text
        Umur = TB_2.Text
        Phone = TB_3.Text
        Address = TB_4.Text
        DOB = DTP_1.Value.ToShortDateString
        Hobby = h
        Foto = PB_1.Image
        Logo = PB_2.Image

        If RB_1.Checked Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If

        Form2.Show()
        Me.Hide()

    End Sub


    Function AmbilHobby() As String

        Dim h As String = ""

        If CB_1.Checked Then h &= "Gaming, "
        If CB_2.Checked Then h &= "Travelling, "
        If CB_3.Checked Then h &= "Reading, "
        If CB_4.Checked Then h &= "Swimming, "
        If CB_5.Checked Then h &= "Dancing, "
        If CB_6.Checked Then h &= "Gardening, "
        If CB_7.Checked Then h &= "Fishing, "
        If CB_8.Checked Then h &= "Hiking, "
        If CB_9.Checked Then h &= "Hunting, "
        If CB_10.Checked Then h &= "Gambling, "

        Return h

    End Function


    Private Sub TB_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_2.KeyPress
        e.Handled = HanyaAngka(e)
    End Sub

    Private Sub TB_3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_3.KeyPress
        e.Handled = HanyaAngka(e)
    End Sub

    Private Sub TB_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_1.KeyPress
        e.Handled = HanyaHuruf(e)
    End Sub

End Class