Module Module1

    Public JudulBuku(100) As String
    Public GenreBuku(100) As String
    Public JumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        JudulBuku(JumlahBuku) = judul
        GenreBuku(JumlahBuku) = genre
        JumlahBuku += 1
    End Sub

    Public Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To JumlahBuku - 1
            If JudulBuku(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub HapusBuku(ByRef judul As String)
        Dim index As Integer = CariBuku(judul)

        If index <> -1 Then
            For i As Integer = index To JumlahBuku - 2
                JudulBuku(i) = JudulBuku(i + 1)
                GenreBuku(i) = GenreBuku(i + 1)
            Next
            JumlahBuku -= 1
        End If
    End Sub

End Module
