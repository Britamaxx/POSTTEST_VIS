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
        MS_1 = New MenuStrip()
        TSM_Data = New ToolStripMenuItem()
        TSM_NewData = New ToolStripMenuItem()
        TSM_SaveData = New ToolStripMenuItem()
        TSM_OpenData = New ToolStripMenuItem()
        TSM_PrintCard = New ToolStripMenuItem()
        PB_1 = New PictureBox()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        TP_3 = New TabPage()
        Label1 = New Label()
        BT_2 = New Button()
        GB_2 = New GroupBox()
        CB_8 = New CheckBox()
        CB_7 = New CheckBox()
        CB_6 = New CheckBox()
        CB_5 = New CheckBox()
        CB_4 = New CheckBox()
        CB_3 = New CheckBox()
        CB_2 = New CheckBox()
        CB_1 = New CheckBox()
        GB_1 = New GroupBox()
        RB_10 = New RadioButton()
        RB_9 = New RadioButton()
        RB_8 = New RadioButton()
        RB_7 = New RadioButton()
        RB_6 = New RadioButton()
        RB_5 = New RadioButton()
        RB_4 = New RadioButton()
        RB_3 = New RadioButton()
        BT_1 = New Button()
        PB_2 = New PictureBox()
        TP_2 = New TabPage()
        LBL_4 = New Label()
        LBL_3 = New Label()
        MTB_1 = New MaskedTextBox()
        TB_4 = New TextBox()
        TB_3 = New TextBox()
        LB_8 = New Label()
        LB_7 = New Label()
        LB_6 = New Label()
        TP_1 = New TabPage()
        LBL_2 = New Label()
        LBL_1 = New Label()
        CBO_1 = New ComboBox()
        RB_2 = New RadioButton()
        RB_1 = New RadioButton()
        DTP_1 = New DateTimePicker()
        TB_2 = New TextBox()
        TB_1 = New TextBox()
        LB_5 = New Label()
        LB_4 = New Label()
        LB_3 = New Label()
        LB_2 = New Label()
        LB_1 = New Label()
        TC_1 = New TabControl()
        TSM_Exit = New ToolStripMenuItem()
        MS_1.SuspendLayout()
        CType(PB_1, ComponentModel.ISupportInitialize).BeginInit()
        TP_3.SuspendLayout()
        GB_2.SuspendLayout()
        GB_1.SuspendLayout()
        CType(PB_2, ComponentModel.ISupportInitialize).BeginInit()
        TP_2.SuspendLayout()
        TP_1.SuspendLayout()
        TC_1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MS_1
        ' 
        MS_1.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MS_1.ImageScalingSize = New Size(24, 24)
        MS_1.Items.AddRange(New ToolStripItem() {TSM_Data, TSM_PrintCard, TSM_Exit})
        MS_1.Location = New Point(0, 0)
        MS_1.Name = "MS_1"
        MS_1.Size = New Size(1000, 32)
        MS_1.TabIndex = 0
        MS_1.Text = "MENU"
        ' 
        ' TSM_Data
        ' 
        TSM_Data.DropDownItems.AddRange(New ToolStripItem() {TSM_NewData, TSM_SaveData, TSM_OpenData})
        TSM_Data.Name = "TSM_Data"
        TSM_Data.Size = New Size(74, 28)
        TSM_Data.Text = "Data"
        ' 
        ' TSM_NewData
        ' 
        TSM_NewData.Name = "TSM_NewData"
        TSM_NewData.Size = New Size(270, 34)
        TSM_NewData.Text = "New"
        ' 
        ' TSM_SaveData
        ' 
        TSM_SaveData.Name = "TSM_SaveData"
        TSM_SaveData.Size = New Size(270, 34)
        TSM_SaveData.Text = "Save"
        ' 
        ' TSM_OpenData
        ' 
        TSM_OpenData.Name = "TSM_OpenData"
        TSM_OpenData.Size = New Size(270, 34)
        TSM_OpenData.Text = "Open"
        ' 
        ' TSM_PrintCard
        ' 
        TSM_PrintCard.Name = "TSM_PrintCard"
        TSM_PrintCard.Size = New Size(146, 28)
        TSM_PrintCard.Text = "Print Card"
        ' 
        ' PB_1
        ' 
        PB_1.Image = CType(resources.GetObject("PB_1.Image"), Image)
        PB_1.Location = New Point(0, 36)
        PB_1.Name = "PB_1"
        PB_1.Size = New Size(667, 173)
        PB_1.SizeMode = PictureBoxSizeMode.StretchImage
        PB_1.TabIndex = 1
        PB_1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TP_3
        ' 
        TP_3.BackColor = Color.Black
        TP_3.Controls.Add(Label1)
        TP_3.Controls.Add(BT_2)
        TP_3.Controls.Add(GB_2)
        TP_3.Controls.Add(GB_1)
        TP_3.Controls.Add(BT_1)
        TP_3.Controls.Add(PB_2)
        TP_3.Location = New Point(4, 31)
        TP_3.Name = "TP_3"
        TP_3.Padding = New Padding(3)
        TP_3.Size = New Size(967, 413)
        TP_3.TabIndex = 2
        TP_3.Text = "Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(8, 366)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 20)
        Label1.TabIndex = 6
        Label1.Text = "[CAUTION: AUTHORIZATION IMPLIES ABSOLUTE ACCOUNTABILITY]"
        ' 
        ' BT_2
        ' 
        BT_2.BackColor = Color.DarkRed
        BT_2.Font = New Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BT_2.ForeColor = SystemColors.ButtonHighlight
        BT_2.Location = New Point(639, 358)
        BT_2.Name = "BT_2"
        BT_2.Size = New Size(315, 34)
        BT_2.TabIndex = 4
        BT_2.Text = "Print Card"
        BT_2.UseVisualStyleBackColor = False
        ' 
        ' GB_2
        ' 
        GB_2.Controls.Add(CB_8)
        GB_2.Controls.Add(CB_7)
        GB_2.Controls.Add(CB_6)
        GB_2.Controls.Add(CB_5)
        GB_2.Controls.Add(CB_4)
        GB_2.Controls.Add(CB_3)
        GB_2.Controls.Add(CB_2)
        GB_2.Controls.Add(CB_1)
        GB_2.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GB_2.ForeColor = Color.White
        GB_2.Location = New Point(639, 6)
        GB_2.Name = "GB_2"
        GB_2.Size = New Size(315, 337)
        GB_2.TabIndex = 3
        GB_2.TabStop = False
        GB_2.Text = "Specialization"
        ' 
        ' CB_8
        ' 
        CB_8.AutoSize = True
        CB_8.Location = New Point(6, 294)
        CB_8.Name = "CB_8"
        CB_8.Size = New Size(206, 31)
        CB_8.TabIndex = 7
        CB_8.Text = "Site Mapping"
        CB_8.UseVisualStyleBackColor = True
        ' 
        ' CB_7
        ' 
        CB_7.AutoSize = True
        CB_7.Location = New Point(6, 257)
        CB_7.Name = "CB_7"
        CB_7.Size = New Size(262, 31)
        CB_7.TabIndex = 6
        CB_7.Text = "Breach Protocols"
        CB_7.UseVisualStyleBackColor = True
        ' 
        ' CB_6
        ' 
        CB_6.AutoSize = True
        CB_6.Location = New Point(6, 220)
        CB_6.Name = "CB_6"
        CB_6.Size = New Size(206, 31)
        CB_6.TabIndex = 5
        CB_6.Text = "Terminal CLI"
        CB_6.UseVisualStyleBackColor = True
        ' 
        ' CB_5
        ' 
        CB_5.AutoSize = True
        CB_5.Location = New Point(6, 183)
        CB_5.Name = "CB_5"
        CB_5.Size = New Size(220, 31)
        CB_5.TabIndex = 4
        CB_5.Text = "GOI Directory"
        CB_5.UseVisualStyleBackColor = True
        ' 
        ' CB_4
        ' 
        CB_4.AutoSize = True
        CB_4.Location = New Point(6, 146)
        CB_4.Name = "CB_4"
        CB_4.Size = New Size(234, 31)
        CB_4.TabIndex = 3
        CB_4.Text = "Redaction Tool"
        CB_4.UseVisualStyleBackColor = True
        ' 
        ' CB_3
        ' 
        CB_3.AutoSize = True
        CB_3.Location = New Point(6, 109)
        CB_3.Name = "CB_3"
        CB_3.Size = New Size(262, 31)
        CB_3.TabIndex = 2
        CB_3.Text = "Clearance System"
        CB_3.UseVisualStyleBackColor = True
        ' 
        ' CB_2
        ' 
        CB_2.AutoSize = True
        CB_2.Location = New Point(6, 72)
        CB_2.Name = "CB_2"
        CB_2.Size = New Size(262, 31)
        CB_2.TabIndex = 1
        CB_2.Text = "Report Generator"
        CB_2.UseVisualStyleBackColor = True
        ' 
        ' CB_1
        ' 
        CB_1.AutoSize = True
        CB_1.Location = New Point(6, 34)
        CB_1.Name = "CB_1"
        CB_1.Size = New Size(248, 31)
        CB_1.TabIndex = 0
        CB_1.Text = "Object Database"
        CB_1.UseVisualStyleBackColor = True
        ' 
        ' GB_1
        ' 
        GB_1.Controls.Add(RB_10)
        GB_1.Controls.Add(RB_9)
        GB_1.Controls.Add(RB_8)
        GB_1.Controls.Add(RB_7)
        GB_1.Controls.Add(RB_6)
        GB_1.Controls.Add(RB_5)
        GB_1.Controls.Add(RB_4)
        GB_1.Controls.Add(RB_3)
        GB_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GB_1.ForeColor = Color.White
        GB_1.Location = New Point(222, 6)
        GB_1.Name = "GB_1"
        GB_1.Size = New Size(411, 337)
        GB_1.TabIndex = 2
        GB_1.TabStop = False
        GB_1.Text = "Role"
        ' 
        ' RB_10
        ' 
        RB_10.AutoSize = True
        RB_10.Location = New Point(6, 293)
        RB_10.Name = "RB_10"
        RB_10.Size = New Size(177, 31)
        RB_10.TabIndex = 7
        RB_10.TabStop = True
        RB_10.Text = "O5 Council"
        RB_10.UseVisualStyleBackColor = True
        ' 
        ' RB_9
        ' 
        RB_9.AutoSize = True
        RB_9.Location = New Point(6, 256)
        RB_9.Name = "RB_9"
        RB_9.Size = New Size(219, 31)
        RB_9.TabIndex = 6
        RB_9.TabStop = True
        RB_9.Text = "Site Director"
        RB_9.UseVisualStyleBackColor = True
        ' 
        ' RB_8
        ' 
        RB_8.AutoSize = True
        RB_8.Location = New Point(6, 219)
        RB_8.Name = "RB_8"
        RB_8.Size = New Size(401, 31)
        RB_8.TabIndex = 5
        RB_8.TabStop = True
        RB_8.Text = "Mobile Task Force Operator"
        RB_8.UseVisualStyleBackColor = True
        ' 
        ' RB_7
        ' 
        RB_7.AutoSize = True
        RB_7.Location = New Point(6, 182)
        RB_7.Name = "RB_7"
        RB_7.Size = New Size(191, 31)
        RB_7.TabIndex = 4
        RB_7.TabStop = True
        RB_7.Text = "Field Agent"
        RB_7.UseVisualStyleBackColor = True
        ' 
        ' RB_6
        ' 
        RB_6.AutoSize = True
        RB_6.Location = New Point(6, 145)
        RB_6.Name = "RB_6"
        RB_6.Size = New Size(387, 31)
        RB_6.TabIndex = 3
        RB_6.TabStop = True
        RB_6.Text = "Tactical Response Officer"
        RB_6.UseVisualStyleBackColor = True
        ' 
        ' RB_5
        ' 
        RB_5.AutoSize = True
        RB_5.Location = New Point(6, 108)
        RB_5.Name = "RB_5"
        RB_5.Size = New Size(261, 31)
        RB_5.TabIndex = 2
        RB_5.TabStop = True
        RB_5.Text = "Security Officer"
        RB_5.UseVisualStyleBackColor = True
        ' 
        ' RB_4
        ' 
        RB_4.AutoSize = True
        RB_4.Location = New Point(6, 71)
        RB_4.Name = "RB_4"
        RB_4.Size = New Size(177, 31)
        RB_4.TabIndex = 1
        RB_4.TabStop = True
        RB_4.Text = "Researcher"
        RB_4.UseVisualStyleBackColor = True
        ' 
        ' RB_3
        ' 
        RB_3.AutoSize = True
        RB_3.Location = New Point(6, 34)
        RB_3.Name = "RB_3"
        RB_3.Size = New Size(345, 31)
        RB_3.TabIndex = 0
        RB_3.TabStop = True
        RB_3.Text = "Containment Specialist"
        RB_3.UseVisualStyleBackColor = True
        ' 
        ' BT_1
        ' 
        BT_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BT_1.Location = New Point(58, 309)
        BT_1.Name = "BT_1"
        BT_1.Size = New Size(112, 34)
        BT_1.TabIndex = 1
        BT_1.Text = "Browse"
        BT_1.UseVisualStyleBackColor = True
        ' 
        ' PB_2
        ' 
        PB_2.BackColor = Color.Gainsboro
        PB_2.Location = New Point(6, 17)
        PB_2.Name = "PB_2"
        PB_2.Size = New Size(210, 286)
        PB_2.SizeMode = PictureBoxSizeMode.StretchImage
        PB_2.TabIndex = 0
        PB_2.TabStop = False
        ' 
        ' TP_2
        ' 
        TP_2.BackColor = Color.Black
        TP_2.Controls.Add(LBL_4)
        TP_2.Controls.Add(LBL_3)
        TP_2.Controls.Add(MTB_1)
        TP_2.Controls.Add(TB_4)
        TP_2.Controls.Add(TB_3)
        TP_2.Controls.Add(LB_8)
        TP_2.Controls.Add(LB_7)
        TP_2.Controls.Add(LB_6)
        TP_2.Location = New Point(4, 31)
        TP_2.Name = "TP_2"
        TP_2.Padding = New Padding(3)
        TP_2.Size = New Size(967, 413)
        TP_2.TabIndex = 1
        TP_2.Text = "Contact Information"
        ' 
        ' LBL_4
        ' 
        LBL_4.AutoSize = True
        LBL_4.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBL_4.ForeColor = Color.White
        LBL_4.Location = New Point(6, 383)
        LBL_4.Name = "LBL_4"
        LBL_4.Size = New Size(698, 27)
        LBL_4.TabIndex = 13
        LBL_4.Text = "[PROPERTY OF THE FOUNDATION - CLASSIFIED LEVEL 4]"
        ' 
        ' LBL_3
        ' 
        LBL_3.AutoSize = True
        LBL_3.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBL_3.ForeColor = Color.Red
        LBL_3.Location = New Point(6, 356)
        LBL_3.Name = "LBL_3"
        LBL_3.Size = New Size(936, 27)
        LBL_3.TabIndex = 12
        LBL_3.Text = "[WARNING: ACCESS BY UNAUTHORIZED PERSONNEL IS STRICTLY PROHIBITED]"
        ' 
        ' MTB_1
        ' 
        MTB_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MTB_1.Location = New Point(215, 6)
        MTB_1.Mask = "0000-0000-0000"
        MTB_1.Name = "MTB_1"
        MTB_1.Size = New Size(379, 35)
        MTB_1.TabIndex = 8
        ' 
        ' TB_4
        ' 
        TB_4.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TB_4.ImeMode = ImeMode.Hiragana
        TB_4.Location = New Point(215, 88)
        TB_4.Multiline = True
        TB_4.Name = "TB_4"
        TB_4.Size = New Size(379, 31)
        TB_4.TabIndex = 7
        ' 
        ' TB_3
        ' 
        TB_3.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TB_3.Location = New Point(215, 47)
        TB_3.Name = "TB_3"
        TB_3.Size = New Size(379, 35)
        TB_3.TabIndex = 6
        ' 
        ' LB_8
        ' 
        LB_8.AutoSize = True
        LB_8.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_8.ForeColor = Color.White
        LB_8.Location = New Point(6, 91)
        LB_8.Name = "LB_8"
        LB_8.Size = New Size(110, 27)
        LB_8.TabIndex = 3
        LB_8.Text = "Address"
        ' 
        ' LB_7
        ' 
        LB_7.AutoSize = True
        LB_7.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_7.ForeColor = Color.White
        LB_7.Location = New Point(6, 50)
        LB_7.Name = "LB_7"
        LB_7.Size = New Size(82, 27)
        LB_7.TabIndex = 2
        LB_7.Text = "Email"
        ' 
        ' LB_6
        ' 
        LB_6.AutoSize = True
        LB_6.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_6.ForeColor = Color.White
        LB_6.Location = New Point(6, 9)
        LB_6.Name = "LB_6"
        LB_6.Size = New Size(180, 27)
        LB_6.TabIndex = 1
        LB_6.Text = "Phone Number"
        ' 
        ' TP_1
        ' 
        TP_1.BackColor = Color.Black
        TP_1.Controls.Add(LBL_2)
        TP_1.Controls.Add(LBL_1)
        TP_1.Controls.Add(CBO_1)
        TP_1.Controls.Add(RB_2)
        TP_1.Controls.Add(RB_1)
        TP_1.Controls.Add(DTP_1)
        TP_1.Controls.Add(TB_2)
        TP_1.Controls.Add(TB_1)
        TP_1.Controls.Add(LB_5)
        TP_1.Controls.Add(LB_4)
        TP_1.Controls.Add(LB_3)
        TP_1.Controls.Add(LB_2)
        TP_1.Controls.Add(LB_1)
        TP_1.Location = New Point(4, 31)
        TP_1.Name = "TP_1"
        TP_1.Padding = New Padding(3)
        TP_1.Size = New Size(967, 413)
        TP_1.TabIndex = 0
        TP_1.Text = "Personal Information"
        ' 
        ' LBL_2
        ' 
        LBL_2.AutoSize = True
        LBL_2.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBL_2.ForeColor = Color.White
        LBL_2.Location = New Point(6, 383)
        LBL_2.Name = "LBL_2"
        LBL_2.Size = New Size(698, 27)
        LBL_2.TabIndex = 12
        LBL_2.Text = "[PROPERTY OF THE FOUNDATION - CLASSIFIED LEVEL 4]"
        ' 
        ' LBL_1
        ' 
        LBL_1.AutoSize = True
        LBL_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBL_1.ForeColor = Color.Red
        LBL_1.Location = New Point(6, 356)
        LBL_1.Name = "LBL_1"
        LBL_1.Size = New Size(936, 27)
        LBL_1.TabIndex = 11
        LBL_1.Text = "[WARNING: ACCESS BY UNAUTHORIZED PERSONNEL IS STRICTLY PROHIBITED]"
        ' 
        ' CBO_1
        ' 
        CBO_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBO_1.FormattingEnabled = True
        CBO_1.Items.AddRange(New Object() {"Site Staff", "Field Personnel", "Administration"})
        CBO_1.Location = New Point(216, 161)
        CBO_1.Name = "CBO_1"
        CBO_1.Size = New Size(379, 35)
        CBO_1.TabIndex = 10
        ' 
        ' RB_2
        ' 
        RB_2.AutoSize = True
        RB_2.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RB_2.ForeColor = Color.White
        RB_2.Location = New Point(315, 124)
        RB_2.Name = "RB_2"
        RB_2.Size = New Size(121, 31)
        RB_2.TabIndex = 9
        RB_2.TabStop = True
        RB_2.Text = "Female"
        RB_2.UseVisualStyleBackColor = True
        ' 
        ' RB_1
        ' 
        RB_1.AutoSize = True
        RB_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RB_1.ForeColor = Color.White
        RB_1.Location = New Point(216, 124)
        RB_1.Name = "RB_1"
        RB_1.Size = New Size(93, 31)
        RB_1.TabIndex = 8
        RB_1.TabStop = True
        RB_1.Text = "Male"
        RB_1.UseVisualStyleBackColor = True
        ' 
        ' DTP_1
        ' 
        DTP_1.CalendarFont = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DTP_1.Format = DateTimePickerFormat.Short
        DTP_1.Location = New Point(216, 88)
        DTP_1.Name = "DTP_1"
        DTP_1.Size = New Size(379, 30)
        DTP_1.TabIndex = 7
        ' 
        ' TB_2
        ' 
        TB_2.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TB_2.Location = New Point(216, 47)
        TB_2.Name = "TB_2"
        TB_2.Size = New Size(379, 35)
        TB_2.TabIndex = 6
        ' 
        ' TB_1
        ' 
        TB_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TB_1.Location = New Point(216, 6)
        TB_1.Name = "TB_1"
        TB_1.Size = New Size(379, 35)
        TB_1.TabIndex = 5
        ' 
        ' LB_5
        ' 
        LB_5.AutoSize = True
        LB_5.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_5.ForeColor = Color.White
        LB_5.Location = New Point(6, 164)
        LB_5.Name = "LB_5"
        LB_5.Size = New Size(124, 27)
        LB_5.TabIndex = 4
        LB_5.Text = "Division"
        ' 
        ' LB_4
        ' 
        LB_4.AutoSize = True
        LB_4.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_4.ForeColor = Color.White
        LB_4.Location = New Point(6, 126)
        LB_4.Name = "LB_4"
        LB_4.Size = New Size(96, 27)
        LB_4.TabIndex = 3
        LB_4.Text = "Gender"
        ' 
        ' LB_3
        ' 
        LB_3.AutoSize = True
        LB_3.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_3.ForeColor = Color.White
        LB_3.Location = New Point(6, 91)
        LB_3.Name = "LB_3"
        LB_3.Size = New Size(194, 27)
        LB_3.TabIndex = 2
        LB_3.Text = "Date of Birth"
        ' 
        ' LB_2
        ' 
        LB_2.AutoSize = True
        LB_2.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_2.ForeColor = Color.White
        LB_2.Location = New Point(6, 50)
        LB_2.Name = "LB_2"
        LB_2.Size = New Size(138, 27)
        LB_2.TabIndex = 1
        LB_2.Text = "Member ID"
        ' 
        ' LB_1
        ' 
        LB_1.AutoSize = True
        LB_1.Font = New Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LB_1.ForeColor = Color.White
        LB_1.Location = New Point(6, 9)
        LB_1.Name = "LB_1"
        LB_1.Size = New Size(68, 27)
        LB_1.TabIndex = 0
        LB_1.Text = "Name"
        ' 
        ' TC_1
        ' 
        TC_1.Controls.Add(TP_1)
        TC_1.Controls.Add(TP_2)
        TC_1.Controls.Add(TP_3)
        TC_1.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TC_1.Location = New Point(12, 215)
        TC_1.Name = "TC_1"
        TC_1.SelectedIndex = 0
        TC_1.Size = New Size(975, 448)
        TC_1.TabIndex = 2
        ' 
        ' TSM_Exit
        ' 
        TSM_Exit.Name = "TSM_Exit"
        TSM_Exit.Size = New Size(74, 28)
        TSM_Exit.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1000, 685)
        Controls.Add(TC_1)
        Controls.Add(PB_1)
        Controls.Add(MS_1)
        MainMenuStrip = MS_1
        Name = "Form1"
        Text = "Form1"
        MS_1.ResumeLayout(False)
        MS_1.PerformLayout()
        CType(PB_1, ComponentModel.ISupportInitialize).EndInit()
        TP_3.ResumeLayout(False)
        TP_3.PerformLayout()
        GB_2.ResumeLayout(False)
        GB_2.PerformLayout()
        GB_1.ResumeLayout(False)
        GB_1.PerformLayout()
        CType(PB_2, ComponentModel.ISupportInitialize).EndInit()
        TP_2.ResumeLayout(False)
        TP_2.PerformLayout()
        TP_1.ResumeLayout(False)
        TP_1.PerformLayout()
        TC_1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MS_1 As MenuStrip
    Friend WithEvents TSM_Data As ToolStripMenuItem
    Friend WithEvents TSM_PrintCard As ToolStripMenuItem
    Friend WithEvents TP_3 As TabPage
    Friend WithEvents BT_2 As Button
    Friend WithEvents GB_2 As GroupBox
    Friend WithEvents CB_8 As CheckBox
    Friend WithEvents CB_7 As CheckBox
    Friend WithEvents CB_6 As CheckBox
    Friend WithEvents CB_5 As CheckBox
    Friend WithEvents CB_4 As CheckBox
    Friend WithEvents CB_3 As CheckBox
    Friend WithEvents CB_2 As CheckBox
    Friend WithEvents CB_1 As CheckBox
    Friend WithEvents GB_1 As GroupBox
    Friend WithEvents RB_10 As RadioButton
    Friend WithEvents RB_9 As RadioButton
    Friend WithEvents RB_8 As RadioButton
    Friend WithEvents RB_7 As RadioButton
    Friend WithEvents RB_6 As RadioButton
    Friend WithEvents RB_5 As RadioButton
    Friend WithEvents RB_4 As RadioButton
    Friend WithEvents RB_3 As RadioButton
    Friend WithEvents BT_1 As Button
    Friend WithEvents PB_2 As PictureBox
    Friend WithEvents TP_2 As TabPage
    Friend WithEvents LBL_4 As Label
    Friend WithEvents LBL_3 As Label
    Friend WithEvents MTB_1 As MaskedTextBox
    Friend WithEvents TB_4 As TextBox
    Friend WithEvents TB_3 As TextBox
    Friend WithEvents LB_8 As Label
    Friend WithEvents LB_7 As Label
    Friend WithEvents LB_6 As Label
    Friend WithEvents TP_1 As TabPage
    Friend WithEvents LBL_2 As Label
    Friend WithEvents LBL_1 As Label
    Friend WithEvents CBO_1 As ComboBox
    Friend WithEvents RB_2 As RadioButton
    Friend WithEvents RB_1 As RadioButton
    Friend WithEvents DTP_1 As DateTimePicker
    Friend WithEvents TB_2 As TextBox
    Friend WithEvents TB_1 As TextBox
    Friend WithEvents LB_5 As Label
    Friend WithEvents LB_4 As Label
    Friend WithEvents LB_3 As Label
    Friend WithEvents LB_2 As Label
    Friend WithEvents LB_1 As Label
    Friend WithEvents TC_1 As TabControl
    Friend WithEvents TSM_NewData As ToolStripMenuItem
    Friend WithEvents TSM_SaveData As ToolStripMenuItem
    Friend WithEvents TSM_OpenData As ToolStripMenuItem
    Friend WithEvents PB_1 As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TSM_Exit As ToolStripMenuItem

End Class
