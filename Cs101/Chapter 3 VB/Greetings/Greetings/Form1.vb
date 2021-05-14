Public Class Form1
    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        'Display a customized greeting to the user
        'in the lblGreeting control
        lblGreeting.Text = "Hello " & txtUserName.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Form
        Me.Close()
    End Sub
End Class
