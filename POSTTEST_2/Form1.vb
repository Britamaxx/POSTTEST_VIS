Public Class Form1

    Function TampilkanBuku() As String
        Dim hasil As String = ""

        For i As Integer = 0 To JumlahBuku - 1
            hasil &= JudulBuku(i) & " - " & GenreBuku(i) & vbCrLf
        Next

        Return hasil
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim genre() As String = {
            "Action", "Adventure", "Biography", "Children", "Classic", "Comedy",
            "Crime", "Drama", "Dystopian", "Education", "Essay", "Fantasy",
            "Fiction", "Graphic Novel", "Historical", "Horror", "Mystery",
            "Motivation", "Non-Fiction", "Philosophy", "Poetry", "Psychology",
            "Romance", "Religion", "Science", "Science Fiction", "Self-Help",
            "Slice of Life", "Technology", "Thriller", "Travel"
        }
        CB_1.Items.AddRange(genre)
    End Sub

    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        If TB_1.Text = "" Or CB_1.Text = "" Then
            MessageBox.Show("Judul dan Genre harus diisi", "Peringatan!")
        Else
            TambahBuku(TB_1.Text, CB_1.Text)
            RTB_1.Text = TampilkanBuku()
            MessageBox.Show("Buku berhasil ditambahkan", "Sukses!")
            TB_1.Clear()
        End If
    End Sub

    Private Sub BT_2_Click(sender As Object, e As EventArgs) Handles BT_2.Click
        If TB_2.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus", "Peringatan!")
        Else
            Dim index As Integer = CariBuku(TB_2.Text)

            If index = -1 Then
                MessageBox.Show("Judul buku tidak ditemukan", "Error!")
            Else
                HapusBuku(TB_2.Text)
                RTB_1.Text = TampilkanBuku()
                MessageBox.Show("Buku berhasil dihapus", "Sukses!")
            End If

            TB_2.Clear()
        End If
    End Sub
End Class
