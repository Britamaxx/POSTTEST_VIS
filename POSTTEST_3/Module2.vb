Module Module2

    Public Function InputKosong(nama As String, umur As String, phone As String,
                                alamat As String, gender As Boolean,
                                hobby As String, foto As Image, logo As Image) As Boolean

        If nama = "" Or umur = "" Or phone = "" Or alamat = "" _
            Or gender = False _
            Or hobby = "" _
            Or foto Is Nothing _
            Or logo Is Nothing Then

            Return True
        End If

        Return False
    End Function


    Public Function HanyaAngka(e As KeyPressEventArgs) As Boolean
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            Return True
        End If
        Return False
    End Function


    Public Function HanyaHuruf(e As KeyPressEventArgs) As Boolean
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(8) And Not e.KeyChar = " " Then
            Return True
        End If
        Return False
    End Function

End Module