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
            ' Use a covert integer CiInt()is applied in case is 69.79
            Select Case (CInt(dblAverage))
                Case Is < 60
                    strGrade = "F"
                Case 60 To 69
                    strGrade = "D"
                Case 70 To 79
                    strGrade = "C"
                Case 80 To 89
                    strGrade = "B"
                Case Else
                    strGrade = "A"
            End Select

            ' Step 3 - Ouput
            lblAverage.Text = dblAverage.ToString("N")
            lblStrMessage.Text = strGrade
        Catch ex As Exception
            MessageBox.Show("Numbers Only")
        End Try
    End Sub
End Class
