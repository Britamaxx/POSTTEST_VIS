Imports System.Drawing

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PB_1.SizeMode = PictureBoxSizeMode.StretchImage
        PB_2.SizeMode = PictureBoxSizeMode.StretchImage

        LB_1.Text = Nama
        LB_2.Text = Umur
        LB_3.Text = Gender
        LB_4.Text = DOB
        LB_5.Text = Phone
        LB_6.Text = Hobby
        LB_7.Text = Address

        PB_2.Image = Foto

    End Sub

End Class