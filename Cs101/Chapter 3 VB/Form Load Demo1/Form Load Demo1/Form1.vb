Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current date from the system.
        Dim dtmSytemDate As Date = Today

        ' Display the date.
        lblDate.Text = dtmSytemDate.ToString("d")
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub
End Class
