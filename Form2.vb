Public Class Form2

    Private Sub cbotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocourse.SelectedIndexChanged

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase() 'establish connection
        LoadCourse()
        LoadAllData()
        With dgvdata
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.LightCoral
        End With
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        If cbocourse.SelectedIndex = 0 Then
            DisplayData("bsit")
        ElseIf cbocourse.SelectedIndex = 1 Then
            DisplayData("coa")
        ElseIf cbocourse.SelectedIndex = 2 Then
            DisplayData("cba")
        ElseIf cbocourse.SelectedIndex = 3 Then
            DisplayData("bscs")
        Else
            MsgBox("no record found!")

        End If
    End Sub
End Class