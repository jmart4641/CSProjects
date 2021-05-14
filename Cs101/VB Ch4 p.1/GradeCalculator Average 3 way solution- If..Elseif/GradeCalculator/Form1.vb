Option Strict On
Public Class lblGrade
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Step 0 - Declare Varibale
        ' We need three variables.
        Dim intScore1 As Integer
        Dim intScore2 As Integer
        Dim dblAverage As Double
        Dim strGrade As String = ""

        Try
            ' Step 1 - Input
            intScore1 = CInt(txtScore1.Text)
            intScore2 = CInt(txtScore2.Text)

            ' Step 2 - Processing
            dblAverage = (intScore1 + intScore2) / 2

            ' Determine Letter Grade.
            ' Multiway Selection
            If (dblAverage < 60) Then
                strGrade = "F"
            ElseIf (dblAverage < 70) Then
                strGrade = "D"
            ElseIf (dblAverage < 80) Then
                strGrade = "C"
            ElseIf (dblAverage < 90) Then
                strGrade = "B"
            Else
                strGrade = "A"

            End If
            ' Step 3 - Ouput
            lblAverage.Text = dblAverage.ToString("N")
            lblStrMessage.Text = strGrade
        Catch ex As Exception
            MessageBox.Show("Numbers Only")
        End Try
    End Sub
End Class
