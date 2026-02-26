Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        Dim ipSemester As Double

        If Double.TryParse(TB_1.Text, ipSemester) Then

            If ipSemester < 0 Or ipSemester > 4 Then
                MessageBox.Show("IP Semester harus antara 0 - 4!")
                TB_1.Clear()
                TB_1.Focus()
                Exit Sub
            End If

            totalIP += ipSemester
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester

            If ipk > 4 Then
                ipk = 4
            End If

            TB_2.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                LB_3.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                LB_3.Text = "Memuaskan"
            ElseIf ipk >= 3.01 And ipk <= 4.0 Then
                LB_3.Text = "Sangat Memuaskan"
            Else
                LB_3.Text = "Mending Turu"
            End If

            TB_1.Clear()
            TB_1.Focus()

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If
    End Sub

    Private Sub BT_2_Click(sender As Object, e As EventArgs) Handles BT_2.Click
        totalIP = 0
        jumlahSemester = 0
        TB_1.Clear()
        TB_2.Clear()
        LB_3.Text = "-"
        TB_1.Focus()
    End Sub

End Class