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
        LB_1 = New Label()
        LB_2 = New Label()
        TB_1 = New TextBox()
        CB_1 = New ComboBox()
        GB_1 = New GroupBox()
        BT_1 = New Button()
        GB_2 = New GroupBox()
        TB_2 = New TextBox()
        LB_3 = New Label()
        BT_2 = New Button()
        RTB_1 = New RichTextBox()
        GB_1.SuspendLayout()
        GB_2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LB_1
        ' 
        LB_1.AutoSize = True
        LB_1.Location = New Point(19, 67)
        LB_1.Name = "LB_1"
        LB_1.Size = New Size(97, 25)
        LB_1.TabIndex = 1
        LB_1.Text = "Judul Buku"
        ' 
        ' LB_2
        ' 
        LB_2.AutoSize = True
        LB_2.Location = New Point(19, 102)
        LB_2.Name = "LB_2"
        LB_2.Size = New Size(58, 25)
        LB_2.TabIndex = 2
        LB_2.Text = "Genre"
        ' 
        ' TB_1
        ' 
        TB_1.Location = New Point(122, 64)
        TB_1.MaxLength = 100
        TB_1.Name = "TB_1"
        TB_1.Size = New Size(182, 31)
        TB_1.TabIndex = 3
        ' 
        ' CB_1
        ' 
        CB_1.FormattingEnabled = True
        CB_1.Items.AddRange(New Object() {"Action", "Adventure", "Biography", "Children", "Classic", "Comedy", "Crime", "Drama", "Dystopian", "Education", "Essay", "Fantasy", "Fiction", "Graphic Novel", "Historical", "Horror", "Mystery", "Motivatiion", "Non-Fiction", "Philosophy", "Poetry", "Psychology", "Romance", "Religion", "Science", "Science Fiction", "Self-Help", "Slice of Life", "Technology", "Thriller", "Travel"})
        CB_1.Location = New Point(122, 102)
        CB_1.Name = "CB_1"
        CB_1.Size = New Size(182, 33)
        CB_1.TabIndex = 4
        ' 
        ' GB_1
        ' 
        GB_1.Controls.Add(BT_1)
        GB_1.Location = New Point(12, 12)
        GB_1.Name = "GB_1"
        GB_1.Size = New Size(307, 190)
        GB_1.TabIndex = 5
        GB_1.TabStop = False
        GB_1.Text = "Tambah Buku"
        ' 
        ' BT_1
        ' 
        BT_1.Location = New Point(180, 140)
        BT_1.Name = "BT_1"
        BT_1.Size = New Size(112, 34)
        BT_1.TabIndex = 0
        BT_1.Text = "Tambah"
        BT_1.UseVisualStyleBackColor = True
        ' 
        ' GB_2
        ' 
        GB_2.Controls.Add(BT_2)
        GB_2.Controls.Add(LB_3)
        GB_2.Controls.Add(TB_2)
        GB_2.Location = New Point(481, 12)
        GB_2.Name = "GB_2"
        GB_2.Size = New Size(307, 190)
        GB_2.TabIndex = 6
        GB_2.TabStop = False
        GB_2.Text = "Hapus Buku"
        ' 
        ' TB_2
        ' 
        TB_2.Location = New Point(109, 52)
        TB_2.MaxLength = 100
        TB_2.Name = "TB_2"
        TB_2.Size = New Size(182, 31)
        TB_2.TabIndex = 0
        ' 
        ' LB_3
        ' 
        LB_3.AutoSize = True
        LB_3.Location = New Point(6, 55)
        LB_3.Name = "LB_3"
        LB_3.Size = New Size(97, 25)
        LB_3.TabIndex = 2
        LB_3.Text = "Judul Buku"
        ' 
        ' BT_2
        ' 
        BT_2.Location = New Point(179, 140)
        BT_2.Name = "BT_2"
        BT_2.Size = New Size(112, 34)
        BT_2.TabIndex = 3
        BT_2.Text = "Hapus"
        BT_2.UseVisualStyleBackColor = True
        ' 
        ' RTB_1
        ' 
        RTB_1.Location = New Point(12, 255)
        RTB_1.Name = "RTB_1"
        RTB_1.Size = New Size(776, 183)
        RTB_1.TabIndex = 7
        RTB_1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RTB_1)
        Controls.Add(GB_2)
        Controls.Add(CB_1)
        Controls.Add(TB_1)
        Controls.Add(LB_2)
        Controls.Add(LB_1)
        Controls.Add(GB_1)
        Name = "Form1"
        Text = "Form1"
        GB_1.ResumeLayout(False)
        GB_2.ResumeLayout(False)
        GB_2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LB_1 As Label
    Friend WithEvents LB_2 As Label
    Friend WithEvents TB_1 As TextBox
    Friend WithEvents CB_1 As ComboBox
    Friend WithEvents GB_1 As GroupBox
    Friend WithEvents BT_1 As Button
    Friend WithEvents GB_2 As GroupBox
    Friend WithEvents TB_2 As TextBox
    Friend WithEvents LB_3 As Label
    Friend WithEvents BT_2 As Button
    Friend WithEvents RTB_1 As RichTextBox

End Class
