<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtIdKendaraan = New TextBox()
        txtTipeKendaraan = New TextBox()
        Label3 = New Label()
        cbJenisKendaraan = New ComboBox()
        Label4 = New Label()
        txtMerkKendaraan = New TextBox()
        Label5 = New Label()
        txtTahunProduksi = New TextBox()
        Label6 = New Label()
        txtPlatNomor = New TextBox()
        Label7 = New Label()
        txtHargaSewa = New TextBox()
        btnBuat = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        txtCari = New TextBox()
        dgvKendaraan = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvKendaraan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Orange
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(739, 149)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 11)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(712, 118)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 23)
        Label1.TabIndex = 2
        Label1.Text = "Tipe Kendaraan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 23)
        Label2.TabIndex = 3
        Label2.Text = "Merk Kendaraan"
        ' 
        ' txtIdKendaraan
        ' 
        txtIdKendaraan.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdKendaraan.Location = New Point(192, 160)
        txtIdKendaraan.Name = "txtIdKendaraan"
        txtIdKendaraan.Size = New Size(166, 31)
        txtIdKendaraan.TabIndex = 4
        ' 
        ' txtTipeKendaraan
        ' 
        txtTipeKendaraan.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTipeKendaraan.Location = New Point(192, 197)
        txtTipeKendaraan.Name = "txtTipeKendaraan"
        txtTipeKendaraan.Size = New Size(516, 31)
        txtTipeKendaraan.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 23)
        Label3.TabIndex = 6
        Label3.Text = "ID Kendaraan"
        ' 
        ' cbJenisKendaraan
        ' 
        cbJenisKendaraan.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbJenisKendaraan.FormattingEnabled = True
        cbJenisKendaraan.Items.AddRange(New Object() {"Mobil", "Motor"})
        cbJenisKendaraan.Location = New Point(546, 160)
        cbJenisKendaraan.Name = "cbJenisKendaraan"
        cbJenisKendaraan.Size = New Size(162, 31)
        cbJenisKendaraan.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(364, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(176, 23)
        Label4.TabIndex = 8
        Label4.Text = "Jenis Kendaraan"
        ' 
        ' txtMerkKendaraan
        ' 
        txtMerkKendaraan.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMerkKendaraan.Location = New Point(192, 234)
        txtMerkKendaraan.Name = "txtMerkKendaraan"
        txtMerkKendaraan.Size = New Size(516, 31)
        txtMerkKendaraan.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 23)
        Label5.TabIndex = 10
        Label5.Text = "Tahun Produksi"
        ' 
        ' txtTahunProduksi
        ' 
        txtTahunProduksi.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTahunProduksi.Location = New Point(192, 271)
        txtTahunProduksi.Name = "txtTahunProduksi"
        txtTahunProduksi.Size = New Size(224, 31)
        txtTahunProduksi.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(422, 274)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 23)
        Label6.TabIndex = 12
        Label6.Text = "Plat Nomor"
        ' 
        ' txtPlatNomor
        ' 
        txtPlatNomor.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlatNomor.Location = New Point(546, 271)
        txtPlatNomor.Name = "txtPlatNomor"
        txtPlatNomor.Size = New Size(162, 31)
        txtPlatNomor.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 23)
        Label7.TabIndex = 14
        Label7.Text = "Harga Sewa"
        ' 
        ' txtHargaSewa
        ' 
        txtHargaSewa.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHargaSewa.Location = New Point(192, 308)
        txtHargaSewa.Name = "txtHargaSewa"
        txtHargaSewa.Size = New Size(516, 31)
        txtHargaSewa.TabIndex = 15
        ' 
        ' btnBuat
        ' 
        btnBuat.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuat.Location = New Point(12, 347)
        btnBuat.Name = "btnBuat"
        btnBuat.Size = New Size(165, 34)
        btnBuat.TabIndex = 16
        btnBuat.Text = "Buat"
        btnBuat.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(192, 347)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(165, 34)
        btnEdit.TabIndex = 17
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(364, 347)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(165, 34)
        btnHapus.TabIndex = 18
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(543, 347)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(165, 34)
        btnBatal.TabIndex = 19
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCari.ForeColor = Color.DimGray
        txtCari.Location = New Point(12, 387)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(696, 31)
        txtCari.TabIndex = 20
        txtCari.Text = "Cari..."
        ' 
        ' dgvKendaraan
        ' 
        dgvKendaraan.BackgroundColor = SystemColors.ControlLightLight
        dgvKendaraan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKendaraan.Location = New Point(12, 424)
        dgvKendaraan.Name = "dgvKendaraan"
        dgvKendaraan.RowHeadersWidth = 62
        dgvKendaraan.Size = New Size(696, 200)
        dgvKendaraan.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 636)
        Controls.Add(dgvKendaraan)
        Controls.Add(txtCari)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnBuat)
        Controls.Add(txtHargaSewa)
        Controls.Add(Label7)
        Controls.Add(txtPlatNomor)
        Controls.Add(Label6)
        Controls.Add(txtTahunProduksi)
        Controls.Add(Label5)
        Controls.Add(txtMerkKendaraan)
        Controls.Add(Label4)
        Controls.Add(cbJenisKendaraan)
        Controls.Add(Label3)
        Controls.Add(txtTipeKendaraan)
        Controls.Add(txtIdKendaraan)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvKendaraan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdKendaraan As TextBox
    Friend WithEvents txtTipeKendaraan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbJenisKendaraan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMerkKendaraan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTahunProduksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPlatNomor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents btnBuat As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvKendaraan As DataGridView

End Class
