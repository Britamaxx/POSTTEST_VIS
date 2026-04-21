Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form2
    Sub Kosong()
        txtIdTransaksi.Clear()
        txtIdKendaraan.Clear()
        txtNama.Clear()
        txtNomorHp.Clear()
        cbStatus.SelectedIndex = -1
        dtpSewa.Value = Now
        dtpKembali.Value = Now
        txtLamaSewa.Clear()
        txtIdTransaksi.Focus()
    End Sub

    Sub TampilData()
        Call Koneksi()
        Da = New MySqlDataAdapter("SELECT * FROM tbtransaksi", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        dgvTransaksi.DataSource = Dt
    End Sub

    Function AmbilHargaSewa(id As String) As Decimal
        Call Koneksi()
        Dim harga As Decimal = 0
        Dim str As String = "SELECT hargaSewa FROM tbkendaraan WHERE idKendaraan = '" & id & "'"
        Cmd = New MySqlCommand(str, Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            harga = Rd("hargaSewa")
        End If
        Rd.Close()
        Return harga
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
        Call Kosong()
    End Sub

    Private Sub btnBuat_Click(sender As Object, e As EventArgs) Handles btnBuat.Click
        If txtIdTransaksi.Text = "" Or txtIdKendaraan.Text = "" Or txtLamaSewa.Text = "" Then
            MessageBox.Show("Data belum lengkap!")
            Exit Sub
        End If

        Try
            Dim hargaPerHari As Decimal = AmbilHargaSewa(txtIdKendaraan.Text)
            If hargaPerHari = 0 Then
                MessageBox.Show("ID Kendaraan tidak ditemukan di database!")
                Exit Sub
            End If

            Dim total As Decimal = hargaPerHari * CDec(txtLamaSewa.Text)

            Call Koneksi()
            Dim sql As String = "INSERT INTO tbtransaksi VALUES ('" &
                txtIdTransaksi.Text & "','" &
                txtNama.Text & "','" &
                txtNomorHp.Text & "','" &
                txtIdKendaraan.Text & "','" &
                dtpSewa.Value.ToString("yyyy-MM-dd") & "','" &
                dtpKembali.Value.ToString("yyyy-MM-dd") & "','" &
                txtLamaSewa.Text & "','" &
                total & "','" &
                cbStatus.Text & "')"

            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Transaksi Berhasil Dibuat. Total Bayar: " & total.ToString("N0"))
            Call TampilData()
            Call Kosong()
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim hargaPerHari As Decimal = AmbilHargaSewa(txtIdKendaraan.Text)
            Dim total As Decimal = hargaPerHari * CDec(txtLamaSewa.Text)

            Call Koneksi()
            Dim sql As String = "UPDATE tbtransaksi SET " &
                "namaPelanggan='" & txtNama.Text & "'," &
                "nomorHp='" & txtNomorHp.Text & "'," &
                "idKendaraan='" & txtIdKendaraan.Text & "'," &
                "tanggalSewa='" & dtpSewa.Value.ToString("yyyy-MM-dd") & "'," &
                "tanggalKembali='" & dtpKembali.Value.ToString("yyyy-MM-dd") & "'," &
                "lamaSewa='" & txtLamaSewa.Text & "'," &
                "totalHarga='" & total & "'," &
                "status='" & cbStatus.Text & "' " &
                "WHERE idTransaksi='" & txtIdTransaksi.Text & "'"

            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data Transaksi Diupdate")
            Call TampilData()
            Call Kosong()
        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdTransaksi.Text = "" Then Exit Sub

        If MessageBox.Show("Hapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Call Koneksi()
            Dim sql As String = "DELETE FROM tbtransaksi WHERE idTransaksi='" & txtIdTransaksi.Text & "'"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()
            Call TampilData()
            Call Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        Try
            Dim i As Integer = dgvTransaksi.CurrentRow.Index
            txtIdTransaksi.Text = dgvTransaksi.Item(0, i).Value
            txtNama.Text = dgvTransaksi.Item(1, i).Value
            txtNomorHp.Text = dgvTransaksi.Item(2, i).Value
            txtIdKendaraan.Text = dgvTransaksi.Item(3, i).Value
            dtpSewa.Value = dgvTransaksi.Item(4, i).Value
            dtpKembali.Value = dgvTransaksi.Item(5, i).Value
            txtLamaSewa.Text = dgvTransaksi.Item(6, i).Value
            cbStatus.Text = dgvTransaksi.Item(8, i).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPindahForm_Click(sender As Object, e As EventArgs) Handles btnPindahForm.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class