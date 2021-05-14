Option Strict On
' Three way structure

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

            If (dblAverage < 60) Then
                strMessage = "F"
            ElseIf If(dblAverage < 70) Then
                strGrade = "D"
            ElseIf If(dblAverage < 80) Then
                strGrade = "C"
            ElseIf If(dblAverage < 90) Then
                strGrade = "B"
            Else
                strGrade = "A"
            End If

            'Step 3- Output
            lblAverage.Text = dblAverage.ToString("N")
            lblGrade.Text = strGrade
        Catch ex As Exception

        End Try
    End Sub
End Class
