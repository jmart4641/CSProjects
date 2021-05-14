Option Strict On
' One way structure

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Step 0 -  Declare variables
        Dim IntScore1 As Integer
        Dim intScore As Integer
        Dim dblAvergae As Double
        Dim strMessage As String = ""

        Try
            ' step 1 iput
            IntScore1 = CInt(txtScore1.Text)
            intScore2 = CInt(txtScore2.Text)

            ' Step- processing
            dblAverage = (IntScore1 + intScore2) / 2

            If (dblAverage >= 90) Then
                strMessage = "Good Work!"
            End If

            'Step 3- Output
            lblAverage.Text = dblAverage.ToString("N")
            lblMessage.Text = strMessage
        Catch ex As Exception

        End Try
    End Sub
End Class
