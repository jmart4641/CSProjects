Public Class Form1
    Const intFIVE_WEEK_PERIOD As Integer = 5
    Private Sub btnCalculateAve_Click(sender As Object, e As EventArgs) Handles btnCalculateAve.Click
        ' Step 0 - declare Variables.
        Dim dblWeekOneTemp As Double
        Dim dblWeekTwoTemp As Double
        Dim dblWeekThreeTemp As Double
        Dim dblWeekFourTemp As Double
        Dim dblWeekFiveTemp As Double
        Dim dblAverageTemp As Double

        Try
            ' Step 1 - Input
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            ' Get Week's temperature, Convert TxtWeek to intWeek. 
            'dblWeekOneTemp = CDbl(txtWeekOneTemp.Text)
            ' dblWeekTwoTemp = CDbl(txtWeekTwoTemp.Text)
            'dblWeekThreeTemp = CDbl(txtWeekThreeTemp.Text)
            'dblWeekFourTemp = CDbl(txtWeekFourTemp.Text)
            'dblWeekFiveTemp = CDbl(txtWeekFiveTemp.Text)
            dblAverageTemp = CDbl(txtWeekOneTemp.Text) +
                CDbl(txtWeekTwoTemp.Text) + CDbl(txtWeekThreeTemp.Text) +
                CDbl(txtWeekFourTemp.Text) + CDbl(txtWeekFiveTemp.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate weekly temperature average.
            'dblAverageTemp = (dblWeekOneTemp + dblWeekTwoTemp + dblWeekThreeTemp + dblWeekOneTemp + dblWeekFiveTemp) / intFIVE_WEEK_PERIOD
            dblAverageTemp = dblAverageTemp / intFIVE_WEEK_PERIOD

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the total in each class in the corresponding label.
            lblAverageTemp.Text = dblAverageTemp.ToString("")

        Catch
            ' Error Message displays
            MessageBox.Show("Error: Please enter numeric values only!")
        End Try




    End Sub
End Class
