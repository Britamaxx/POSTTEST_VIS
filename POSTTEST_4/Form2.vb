Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_1.Text = G_Nama
        LBL_2.Text = G_Division
        LBL_3.Text = G_Role
        LBL_4.Text = G_Email
        LBL_5.Text = G_Phone
        LBL_6.Text = G_Specialization
        LBL_7.Text = G_ID
        LBL_8.Text = G_DOB
        LBL_9.Text = G_AccessLevel
        PB_2.Image = G_Photo
    End Sub
End Class