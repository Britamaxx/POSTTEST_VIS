<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        txtIdTransaksi = New TextBox()
        cbStatus = New ComboBox()
        txtIdKendaraan = New TextBox()
        dtpSewa = New DateTimePicker()
        Label5 = New Label()
        dtpKembali = New DateTimePicker()
        Label6 = New Label()
        txtNama = New TextBox()
        Label7 = New Label()
        txtNomorHp = New TextBox()
        btnBuat = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvTransaksi = New DataGridView()
        btnPindahForm = New Button()
        Label8 = New Label()
        txtLamaSewa = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Orange
        PictureBox1.Location = New Point(-7, -2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(825, 119)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Orange
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 9)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(791, 94)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 23)
        Label3.TabIndex = 7
        Label3.Text = "ID Transaksi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(456, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 23)
        Label1.TabIndex = 8
        Label1.Text = "Status Kendaraan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 23)
        Label2.TabIndex = 9
        Label2.Text = "ID Kendaraan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(456, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 23)
        Label4.TabIndex = 10
        Label4.Text = "Tanggal Sewa"
        ' 
        ' txtIdTransaksi
        ' 
        txtIdTransaksi.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdTransaksi.Location = New Point(167, 135)
        txtIdTransaksi.Margin = New Padding(3, 2, 3, 2)
        txtIdTransaksi.Name = "txtIdTransaksi"
        txtIdTransaksi.Size = New Size(283, 31)
        txtIdTransaksi.TabIndex = 11
        ' 
        ' cbStatus
        ' 
        cbStatus.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Disewa", "Kosong"})
        cbStatus.Location = New Point(651, 135)
        cbStatus.Margin = New Padding(3, 2, 3, 2)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(153, 31)
        cbStatus.TabIndex = 12
        ' 
        ' txtIdKendaraan
        ' 
        txtIdKendaraan.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdKendaraan.Location = New Point(167, 171)
        txtIdKendaraan.Margin = New Padding(3, 2, 3, 2)
        txtIdKendaraan.Name = "txtIdKendaraan"
        txtIdKendaraan.Size = New Size(283, 31)
        txtIdKendaraan.TabIndex = 13
        ' 
        ' dtpSewa
        ' 
        dtpSewa.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpSewa.Format = DateTimePickerFormat.Short
        dtpSewa.Location = New Point(651, 171)
        dtpSewa.Name = "dtpSewa"
        dtpSewa.Size = New Size(153, 31)
        dtpSewa.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(456, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 23)
        Label5.TabIndex = 15
        Label5.Text = "Tanggal Kembali"
        ' 
        ' dtpKembali
        ' 
        dtpKembali.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpKembali.Format = DateTimePickerFormat.Short
        dtpKembali.Location = New Point(651, 208)
        dtpKembali.Name = "dtpKembali"
        dtpKembali.Size = New Size(153, 31)
        dtpKembali.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 23)
        Label6.TabIndex = 17
        Label6.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(167, 206)
        txtNama.Margin = New Padding(3, 2, 3, 2)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(283, 31)
        txtNama.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 244)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 23)
        Label7.TabIndex = 19
        Label7.Text = "No HP"
        ' 
        ' txtNomorHp
        ' 
        txtNomorHp.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNomorHp.Location = New Point(167, 241)
        txtNomorHp.Margin = New Padding(3, 2, 3, 2)
        txtNomorHp.Name = "txtNomorHp"
        txtNomorHp.Size = New Size(283, 31)
        txtNomorHp.TabIndex = 20
        ' 
        ' btnBuat
        ' 
        btnBuat.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuat.Location = New Point(12, 301)
        btnBuat.Name = "btnBuat"
        btnBuat.Size = New Size(165, 34)
        btnBuat.TabIndex = 21
        btnBuat.Text = "Buat"
        btnBuat.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(224, 301)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(165, 34)
        btnEdit.TabIndex = 22
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(425, 301)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(165, 34)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(638, 301)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(165, 34)
        btnBatal.TabIndex = 24
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.BackgroundColor = SystemColors.ControlLightLight
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaksi.GridColor = Color.White
        dgvTransaksi.Location = New Point(13, 341)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.RowHeadersWidth = 62
        dgvTransaksi.Size = New Size(790, 257)
        dgvTransaksi.TabIndex = 25
        ' 
        ' btnPindahForm
        ' 
        btnPindahForm.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPindahForm.Location = New Point(13, 606)
        btnPindahForm.Name = "btnPindahForm"
        btnPindahForm.Size = New Size(165, 34)
        btnPindahForm.TabIndex = 26
        btnPindahForm.Text = "Form 1"
        btnPindahForm.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(456, 247)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 23)
        Label8.TabIndex = 27
        Label8.Text = "Lama Sewa"
        ' 
        ' txtLamaSewa
        ' 
        txtLamaSewa.Font = New Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLamaSewa.Location = New Point(651, 244)
        txtLamaSewa.Margin = New Padding(3, 2, 3, 2)
        txtLamaSewa.Name = "txtLamaSewa"
        txtLamaSewa.Size = New Size(153, 31)
        txtLamaSewa.TabIndex = 28
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(815, 652)
        Controls.Add(txtLamaSewa)
        Controls.Add(Label8)
        Controls.Add(btnPindahForm)
        Controls.Add(dgvTransaksi)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnBuat)
        Controls.Add(txtNomorHp)
        Controls.Add(Label7)
        Controls.Add(txtNama)
        Controls.Add(Label6)
        Controls.Add(dtpKembali)
        Controls.Add(Label5)
        Controls.Add(dtpSewa)
        Controls.Add(txtIdKendaraan)
        Controls.Add(cbStatus)
        Controls.Add(txtIdTransaksi)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdTransaksi As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtIdKendaraan As TextBox
    Friend WithEvents dtpSewa As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNomorHp As TextBox
    Friend WithEvents btnBuat As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents btnPindahForm As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLamaSewa As TextBox
End Class
