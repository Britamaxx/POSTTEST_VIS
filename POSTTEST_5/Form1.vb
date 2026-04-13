Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form1

    Sub Kosong()
        txtIdKendaraan.Clear()
        cbJenisKendaraan.SelectedIndex = -1
        txtTipeKendaraan.Clear()
        txtMerkKendaraan.Clear()
        txtTahunProduksi.Clear()
        txtPlatNomor.Clear()
        txtHargaSewa.Clear()
        txtIdKendaraan.Focus()
    End Sub

    Sub TampilData()
        Call Koneksi()
        Da = New MySqlDataAdapter("SELECT * FROM tbkendaraan", Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        dgvKendaraan.DataSource = Dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilData()
    End Sub

    Private Sub btnBuat_Click(sender As Object, e As EventArgs) Handles btnBuat.Click

        If Not ValidasiInput(txtIdKendaraan, cbJenisKendaraan, txtTipeKendaraan,
                             txtMerkKendaraan, txtTahunProduksi, txtPlatNomor, txtHargaSewa) Then Exit Sub

        Call Koneksi()

        Dim sql As String = "INSERT INTO tbkendaraan VALUES ('" &
            txtIdKendaraan.Text & "','" &
            cbJenisKendaraan.Text & "','" &
            txtTipeKendaraan.Text & "','" &
            txtMerkKendaraan.Text & "','" &
            txtTahunProduksi.Text & "','" &
            txtPlatNomor.Text & "','" &
            txtHargaSewa.Text & "')"

        Cmd = New MySqlCommand(sql, Conn)
        Cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil ditambahkan")

        Call TampilData()
        Call Kosong()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If Not ValidasiInput(txtIdKendaraan, cbJenisKendaraan, txtTipeKendaraan,
                             txtMerkKendaraan, txtTahunProduksi, txtPlatNomor, txtHargaSewa) Then Exit Sub

        Call Koneksi()

        Dim sql As String = "UPDATE tbkendaraan SET " &
            "jenisKendaraan='" & cbJenisKendaraan.Text & "'," &
            "tipeKendaraan='" & txtTipeKendaraan.Text & "'," &
            "merkKendaraan='" & txtMerkKendaraan.Text & "'," &
            "tahunProduksi='" & txtTahunProduksi.Text & "'," &
            "platNomor='" & txtPlatNomor.Text & "'," &
            "hargaSewa='" & txtHargaSewa.Text & "' " &
            "WHERE idKendaraan='" & txtIdKendaraan.Text & "'"

        Cmd = New MySqlCommand(sql, Conn)
        Cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diupdate")

        Call TampilData()
        Call Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtIdKendaraan.Text = "" Then
            MessageBox.Show("Pilih data yang akan dihapus!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Call Koneksi()

            Dim sql As String = "DELETE FROM tbkendaraan WHERE idKendaraan='" & txtIdKendaraan.Text & "'"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus")

            Call TampilData()
            Call Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub dgvKendaraan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKendaraan.CellClick
        If dgvKendaraan.CurrentRow Is Nothing Then Exit Sub

        Dim i As Integer = dgvKendaraan.CurrentRow.Index

        txtIdKendaraan.Text = dgvKendaraan.Item(0, i).Value
        cbJenisKendaraan.Text = dgvKendaraan.Item(1, i).Value
        txtTipeKendaraan.Text = dgvKendaraan.Item(2, i).Value
        txtMerkKendaraan.Text = dgvKendaraan.Item(3, i).Value
        txtTahunProduksi.Text = dgvKendaraan.Item(4, i).Value
        txtPlatNomor.Text = dgvKendaraan.Item(5, i).Value
        txtHargaSewa.Text = dgvKendaraan.Item(6, i).Value
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        Call Koneksi()

        Dim sql As String = "SELECT * FROM tbkendaraan WHERE " &
            "idKendaraan LIKE '%" & txtCari.Text & "%' OR " &
            "jenisKendaraan LIKE '%" & txtCari.Text & "%' OR " &
            "tipeKendaraan LIKE '%" & txtCari.Text & "%' OR " &
            "merkKendaraan LIKE '%" & txtCari.Text & "%' OR " &
            "platNomor LIKE '%" & txtCari.Text & "%'"

        Da = New MySqlDataAdapter(sql, Conn)
        Dt = New DataTable
        Da.Fill(Dt)
        dgvKendaraan.DataSource = Dt

    End Sub

End Class