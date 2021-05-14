Public Class Form1
    Private ReadOnly txtNumberA As Object

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        'Declare Variables we will use in the Calculations.
        Dim dblNumberOne As Double
        Dim dblNumberTwo As Double
        Dim dblAnswer As Double

        'Get any number from the TextBox A Control
        dblNumberOne = CDbl(txtNumberOne.Text)

        'Egt any number from the TextBox B control
        dblNumberTwo = CDbl(txtNumberTwo.Text)

        'Calculate the sume of both A and B
        dblAnswer = dblNumberTwo + dblNumberOne



    End Sub
End Class
