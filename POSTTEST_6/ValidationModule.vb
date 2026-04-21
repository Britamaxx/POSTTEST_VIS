Module ValidationModule

    Public Function IsEmpty(control As Control, pesan As String) As Boolean
        If control.Text.Trim() = "" Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            control.Focus()
            Return True
        End If
        Return False
    End Function

    Public Function IsNumber(control As Control, pesan As String) As Boolean
        If Not IsNumeric(control.Text) Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            control.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiInput(
        txtId As TextBox,
        cbJenis As ComboBox,
        txtTipe As TextBox,
        txtMerk As TextBox,
        txtTahun As TextBox,
        txtPlat As TextBox,
        txtHarga As TextBox
    ) As Boolean

        If IsEmpty(txtId, "ID Kendaraan wajib diisi!") Then Return False
        If cbJenis.Text = "" Then
            MessageBox.Show("Jenis kendaraan wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbJenis.Focus()
            Return False
        End If
        If IsEmpty(txtTipe, "Tipe kendaraan wajib diisi!") Then Return False
        If IsEmpty(txtMerk, "Merk kendaraan wajib diisi!") Then Return False
        If IsEmpty(txtTahun, "Tahun produksi wajib diisi!") Then Return False
        If IsEmpty(txtPlat, "Plat nomor wajib diisi!") Then Return False
        If IsEmpty(txtHarga, "Harga sewa wajib diisi!") Then Return False

        If Not IsNumber(txtTahun, "Tahun harus berupa angka!") Then Return False
        If Not IsNumber(txtHarga, "Harga harus berupa angka!") Then Return False

        Return True
    End Function

End Module