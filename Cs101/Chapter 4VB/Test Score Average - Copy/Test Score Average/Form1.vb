Option Strict On

Public Class Form1
    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        '  Step 0  -  Declare variables for the calculation
        ' Variables to hold scores an the average score.
        Dim intScore1 As Integer        ' Score 1
        Dim intScore2 As Integer        ' Score 2
        Dim intScore3 As Integer
        Dim dblAverage As Double        ' Average

        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            ' Step 1  - Input
            ' Calculate and display the additional charges.
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            intScore1 = CInt(txtScore1.Text)
            intScore2 = CInt(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate the average score.
            dblAverage = (intScore1 + intScore2 + dblScore3) / NUM_SCORES

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the average, rounded to 2 decimals places.
            lblAverage.Text = dblAverage.ToString("n2")

            ' If the score is high, compliment the student.
            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulation! Great Job!"

            End If

        Catch
            ' Error message
            lblMessage.Text = "Scores must be numeric."

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()

        ' Clear labels
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty

        ' Reset the focus to the first field.
        txtScore1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()

    End Sub
End Class
