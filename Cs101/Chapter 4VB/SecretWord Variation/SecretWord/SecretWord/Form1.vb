Public Class Form1
    Private Sub btnDisplayString_Click(sender As Object, e As EventArgs) Handles btnDisplayString.Click
        ' Commpare the input entered with the secret word.
        If txtInputSecretWord.Text = "PROSPERO" Then
            lblMessage.Text = "Congratulation! That is the secret word!"
        Else
            lblMessage.Text = "Wrong! That is NOT the secret word!"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the Form
        Me.Close()

    End Sub
End Class
