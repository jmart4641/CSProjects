Option Strict On
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Step 0 - Declare Varibale
        ' We need three variables.
        Dim intScore1 As Integer
        Dim intScore2 As Integer
        Dim dblAverage As Double
        Dim strMessage As String = ""

        Try
            ' Step 1 - Input
            intScore1 = CInt(txtScore1.Text)
            intScore2 = CInt(txtScore2.Text)

            ' Step 2 - Processing
            dblAverage = (intScore1 + intScore2) / 2

            ' One way selection
            If (dblAverage >= 90) Then
                strMessage = "Good Work"
            End If

            ' Step 3 - Ouput
            lblAverage.Text = dblAverage.ToString("N")

        Catch ex As Exception
            MessageBox.Show("Numbers Only")
        End Try
    End Sub
End Class
