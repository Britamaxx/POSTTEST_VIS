Imports System.IO

Public Class Form1
    Dim rng As New Random()

    Private Sub TB_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Numeric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTB_1.KeyPress, TB_2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PB_2.Image = Image.FromFile(OpenFileDialog1.FileName)
            G_Photo = PB_2.Image
        End If
    End Sub

    Private Sub TSM_PrintCard_Click(sender As Object, e As EventArgs) Handles TSM_PrintCard.Click, BT_2.Click
        If ValidateInputs() Then
            Dim res = MessageBox.Show("AUTHORIZATION IMPLIES ABSOLUTE ACCOUNTABILITY" & vbCrLf & "PROCEED?", "CAUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If res = DialogResult.Yes Then
                SaveToModule()
                Form2.Show()
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isChecked As Boolean = CB_1.Checked Or CB_2.Checked Or CB_3.Checked Or CB_4.Checked Or
                                   CB_5.Checked Or CB_6.Checked Or CB_7.Checked Or CB_8.Checked

        If TB_1.Text = "" Or TB_2.Text = "" Or TB_3.Text = "" Or TB_4.Text = "" Or
           CBO_1.SelectedIndex = -1 Or Not isChecked Or PB_2.Image Is Nothing Then
            MessageBox.Show("INCOMPLETE DATA DETECTED. ALL FIELDS ARE MANDATORY", "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub SaveToModule()
        G_Nama = TB_1.Text
        G_ID = TB_2.Text
        G_DOB = DTP_1.Value.ToString("dd MMMM yyyy")
        G_Gender = If(RB_1.Checked, "Male", "Female")
        G_Division = CBO_1.SelectedItem.ToString()
        G_Phone = MTB_1.Text
        G_Email = TB_3.Text
        G_Address = TB_4.Text

        If RB_3.Checked Then G_Role = "Containment Specialist"
        If RB_4.Checked Then G_Role = "Researcher"
        If RB_5.Checked Then G_Role = "Security Officer"
        If RB_6.Checked Then G_Role = "Tactical Response Officer"
        If RB_7.Checked Then G_Role = "Field Agent"
        If RB_8.Checked Then G_Role = "Mobile Task Force Operator"
        If RB_9.Checked Then G_Role = "Site Director"
        If RB_10.Checked Then G_Role = "O5 Council"

        If RB_10.Checked Then
            G_AccessLevel = "LEVEL 5"
        Else
            G_AccessLevel = "LEVEL " & rng.Next(1, 5).ToString()
        End If

        Dim specs As New List(Of String)
        If CB_1.Checked Then specs.Add("Object Database")
        If CB_2.Checked Then specs.Add("Report Generator")
        If CB_3.Checked Then specs.Add("Clearance System")
        If CB_4.Checked Then specs.Add("Redaction Tool")
        If CB_5.Checked Then specs.Add("GOI Directory")
        If CB_6.Checked Then specs.Add("Terminal CLI")
        If CB_7.Checked Then specs.Add("Breach Protocols")
        If CB_8.Checked Then specs.Add("Site Mapping")
        G_Specialization = String.Join(", ", specs)
    End Sub

    Private Sub TSM_SaveData_Click(sender As Object, e As EventArgs) Handles TSM_SaveData.Click
        SaveFileDialog1.Filter = "Foundation Data|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveToModule()

            Using sw As New StreamWriter(SaveFileDialog1.FileName)
                sw.WriteLine(G_Nama)
                sw.WriteLine(G_ID)
                sw.WriteLine(G_DOB)
                sw.WriteLine(G_Gender)
                sw.WriteLine(G_Division)
                sw.WriteLine(G_Phone)
                sw.WriteLine(G_Email)
                sw.WriteLine(G_Address)
                sw.WriteLine(G_Role)
                sw.WriteLine(G_Specialization.Replace(vbCrLf, "|"))
                sw.WriteLine(G_AccessLevel)
            End Using

            MessageBox.Show("DATA SUCCESSFULLY ARCHIVED TO SITE-19", "SECURE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TSM_NewData_Click(sender As Object, e As EventArgs) Handles TSM_NewData.Click
        TB_1.Clear() : TB_2.Clear() : TB_3.Clear() : TB_4.Clear()
        MTB_1.Clear()

        CBO_1.SelectedIndex = -1
        DTP_1.Value = DateTime.Now

        PB_2.Image = Nothing

        Dim rbs = {RB_1, RB_2, RB_3, RB_4, RB_5, RB_6, RB_7, RB_8, RB_9, RB_10}
        For Each rb In rbs
            rb.Checked = False
        Next

        Dim cbs = {CB_1, CB_2, CB_3, CB_4, CB_5, CB_6, CB_7, CB_8}
        For Each cb In cbs
            cb.Checked = False
        Next

        MessageBox.Show("NEW DATA TERMINAL INITIALIZED", "SYSTEM RESET", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TSM_OpenData_Click(sender As Object, e As EventArgs) Handles TSM_OpenData.Click
        OpenFileDialog1.Filter = "Foundation Data|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = File.ReadAllLines(OpenFileDialog1.FileName)
                If lines.Length >= 11 Then
                    TB_1.Text = lines(0)
                    TB_2.Text = lines(1)
                    DTP_1.Value = DateTime.Parse(lines(2))
                    If lines(3) = "Male" Then RB_1.Checked = True Else RB_2.Checked = True
                    CBO_1.SelectedItem = lines(4)
                    MTB_1.Text = lines(5)
                    TB_3.Text = lines(6)
                    TB_4.Text = lines(7)

                    Dim roleFromFile As String = lines(8)
                    Dim roleButtons = {RB_3, RB_4, RB_5, RB_6, RB_7, RB_8, RB_9, RB_10}
                    Dim roleNames = {"Containment Specialist", "Researcher", "Security Officer",
                                "Tactical Response Officer", "Field Agent",
                                "Mobile Task Force Operator", "Site Director", "O5 Council"}

                    For i As Integer = 0 To roleButtons.Length - 1
                        If roleNames(i) = roleFromFile Then roleButtons(i).Checked = True
                    Next

                    Dim specsFromFile As String = lines(9)
                    Dim checkBoxes = {CB_1, CB_2, CB_3, CB_4, CB_5, CB_6, CB_7, CB_8}
                    Dim specNames = {"Object Database", "Report Generator", "Clearance System",
                                 "Redaction Tool", "GOI Directory", "Terminal CLI",
                                 "Breach Protocols", "Site Mapping"}

                    For i As Integer = 0 To checkBoxes.Length - 1
                        checkBoxes(i).Checked = specsFromFile.Contains(specNames(i))
                    Next

                    MessageBox.Show("ENCRYPTED DATA RETRIEVED", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR: Corrupted or unauthorized file format.", "BREACH DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub

    Private Sub TSM_Exit_Click(sender As Object, e As EventArgs) Handles TSM_Exit.Click
        Dim confirm = MessageBox.Show("TERMINATE SESSION? UNGUARDED DATA WILL BE LOST.", "EXIT CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class