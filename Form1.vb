
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtfirst.Enabled = False
        txtlast.Enabled = False
        txtstudcourse.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        SaveRecord()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchData()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            UpdateRecord(txtuserid.Text, txtfirst.Text, txtlast.Text, txtcourse.Text)
            MsgBox("Update successfull!")
        Else
            MsgBox("Update Cancel!")
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to delete the record?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            DeleteRecord(txtuserid.Text)
            MsgBox("Deletion successfull!")
        Else
            MsgBox("Deletion Cancelled!")
        End If
    End Sub
End Class
