Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer
        Dim intNumTest As Integer
        Dim dblTestScore As Double
        Dim dblTotal As Double
        Dim dblAverage As Double

        ' Prompt for number of tests to average.
        intNumTest = CInt(InputBox("How many test?"))

        ' Initialize Counte and Accumulator
        ' Need to be setted to Zero.
        intCount = 0
        dblTotal = 0.0
        Do While (intCount < intNumTest)
            dblTestScore = CDbl(InputBox("Enter Test Score:  "))
            ' List the numbers that the user input. Test Number and test scores.
            lstOutput.Items.Add("Test Score:  " & (intCount + 1).ToString() & "  " & dblTestScore.ToString("N"))
            dblTotal += dblTestScore
            intCount += 1
        Loop
        dblAverage = dblTotal / intNumTest
        lstOutput.Items.Add(" ")
        ' Display the average
        lstOutput.Items.Add("Average is:  " & dblAverage.ToString("N"))
    End Sub
End Class
