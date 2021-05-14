Public Class Form1
    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        '  Step 0  -  Declare variables for the calculation
        ' Variables to hold scores an the average score.
        Dim dblScore1 As Double         ' Score 1
        Dim dblScore2 As Double         ' Score 2
        Dim dblScore3 As Double         ' Score 3
        Dim dblAverage As Double        ' Average

        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            ' Step 1  - Assign the TextBox scores to the variables.
            ' Calculate and display the additional charges.
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate the average score.
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the average, rounded to 2 decimals places.
            lblAverage.Text = dblAverage.ToString("n2")

            ' Display the letter grade.
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invalid Score"

            End If

            ' If the score is high, give the student praise.
            ' Otherwise, give some encouragement.
            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulation! Great Job!"
            Else
                lblMessage.Text = "Keep trying"
            End If
            \
        Catch
            ' Error message
            lblMessage.Text = "Scores must be numeric!"

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
        lblGrade.Text = String.Empty

        ' Reset the focus to the first field.
        txtScore1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()

    End Sub
End Class
