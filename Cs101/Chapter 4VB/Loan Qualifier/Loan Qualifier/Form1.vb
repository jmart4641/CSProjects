Public Class Form1

    Private Sub btnCheckQualifications_Click(sender As Object, e As EventArgs) Handles btnCheckQualifications.Click
        '  Step 0  -  Declare variables for the calculation
        ' Variables to hold input data.
        Dim dblSalary As Double         ' Salary
        Dim intYearOnJob As Double      ' Year on Job

        Try
            ' Step 1  - Assign the TextBox scores to the variables.
            ' Calculate and display the additional charges.
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            ' Get the user's input.
            dblSalary = CDbl(txtAnnualSalary.Text)
            intYearOnJob = CInt(txtYearOnJob.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate the average score.

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()

            ' Determine whether the applicant qualifies
            ' for the special loan.
            If dblSalary > 30000 Then
                If intYearOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does Not qualify."
                End If
            Else
                If intYearOnJob > 5 Then
                    lblMessage.Text = "The applicant Qualify."
                Else
                    lblMessage.Text = "The applicant does Not qualify."
                End If
            End If
        Catch ex As Exception
            ' Displats an Error message
            lblMessage.Text = "Please entes numeric values."

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form
        txtAnnualSalary.Clear()
        txtYearOnJob.Clear()

        ' Clear labels
        lblMessage.Text = String.Empty

        ' Reset the focus to TextBox Annual Salary.
        txtAnnualSalary.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()

    End Sub
End Class
