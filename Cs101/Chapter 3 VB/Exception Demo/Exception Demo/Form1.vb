Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        '   Declare a variable to hold the user's a salary.
        Dim decSalary As Decimal

        Try
            ' Get the user's input and conver it to a Decimal.
            decSalary = CDec(txtSalary.Text)

            ' Display the user's salary.
            lblResult.Text = "Your salary is " & decSalary.ToString("c")
        Catch
            ' Display an error message.
            lblResult.Text = "Please try again and enter a number."
        End Try
    End Sub
End Class
