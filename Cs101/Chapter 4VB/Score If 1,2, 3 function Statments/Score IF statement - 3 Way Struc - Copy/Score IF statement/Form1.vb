Option Strict On
' Three way structure(other way to use Select case)

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Step 0 -  Declare variables
        Dim IntScore1 As Integer
        Dim intScore As Integer
        Dim dblAvergae As Double
        Dim strGrade As String = ""

        Try
            ' step 1 iput
            IntScore1 = CInt(txtScore1.Text)
            intScore2 = CInt(txtScore2.Text)

            ' Step- processing
            dblAverage = (IntScore1 + intScore2) / 2

            ' Determine Letter Grade
            Select Case (CInt(dblAvergae))
                Case Is < 60
                    strGrade = "F"
                Case 60 < 69
                    strGrade = "D"
                Case 70 < 79
                    strGrade = "C"
                Case 80 < 89
                    strGrade = "B"
                Case Else
                    strGrade = "A"

            End Select

            'Step 3- Output
            lblAverage.Text = dblAverage.ToString("N")
            lblGrade.Text = strGrade
        Catch ex As Exception

        End Try
    End Sub
End Class
