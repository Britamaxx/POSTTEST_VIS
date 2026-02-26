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
        TB_2 = New TextBox()
        BT_1 = New Button()
        BT_2 = New Button()
        LB_3 = New Label()
        SuspendLayout()
        ' 
        ' LB_1
        ' 
        LB_1.AutoSize = True
        LB_1.Location = New Point(129, 161)
        LB_1.Name = "LB_1"
        LB_1.Size = New Size(105, 25)
        LB_1.TabIndex = 0
        LB_1.Text = "IP Semester"
        ' 
        ' LB_2
        ' 
        LB_2.AutoSize = True
        LB_2.Location = New Point(129, 238)
        LB_2.Name = "LB_2"
        LB_2.Size = New Size(107, 25)
        LB_2.TabIndex = 1
        LB_2.Text = "IP Kumulatif"
        ' 
        ' TB_1
        ' 
        TB_1.Location = New Point(299, 161)
        TB_1.Name = "TB_1"
        TB_1.Size = New Size(172, 31)
        TB_1.TabIndex = 2
        ' 
        ' TB_2
        ' 
        TB_2.Location = New Point(299, 238)
        TB_2.Name = "TB_2"
        TB_2.ReadOnly = True
        TB_2.Size = New Size(172, 31)
        TB_2.TabIndex = 3
        ' 
        ' BT_1
        ' 
        BT_1.BackColor = SystemColors.ControlDark
        BT_1.Location = New Point(299, 198)
        BT_1.Name = "BT_1"
        BT_1.Size = New Size(83, 34)
        BT_1.TabIndex = 4
        BT_1.Text = "Tambah"
        BT_1.UseVisualStyleBackColor = False
        ' 
        ' BT_2
        ' 
        BT_2.BackColor = SystemColors.ControlDark
        BT_2.Location = New Point(388, 198)
        BT_2.Name = "BT_2"
        BT_2.Size = New Size(83, 34)
        BT_2.TabIndex = 5
        BT_2.Text = "Reset"
        BT_2.UseVisualStyleBackColor = False
        ' 
        ' LB_3
        ' 
        LB_3.AutoSize = True
        LB_3.Location = New Point(299, 289)
        LB_3.Name = "LB_3"
        LB_3.Size = New Size(63, 25)
        LB_3.TabIndex = 6
        LB_3.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LB_3)
        Controls.Add(BT_2)
        Controls.Add(BT_1)
        Controls.Add(TB_2)
        Controls.Add(TB_1)
        Controls.Add(LB_2)
        Controls.Add(LB_1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LB_1 As Label
    Friend WithEvents LB_2 As Label
    Friend WithEvents TB_1 As TextBox
    Friend WithEvents TB_2 As TextBox
    Friend WithEvents BT_1 As Button
    Friend WithEvents BT_2 As Button
    Friend WithEvents LB_3 As Label

End Class
