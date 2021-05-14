'**********************************************************************************************************
' Name: Jose R. Martinez Perez
' Purpose: To calculate the average temperatur of five-week period which will display in lblAvergaTemp label.
' Input: Users Enter Weekly temperatures reading over a five-week periods.
' Processing: Calculate weekly temperature by adding week one through week five then divide by five.
'             The result is the Average Weekly temperature.
' Output: Displays a message in the lblAverageTemp which is the average temperature of a five-week Period.
'*********************************************************************************************************
Public Class Form1
    Const intFIVE_WEEK_PERIOD As Integer = 5    ' Five-week period

    Private Sub btnCalculateAve_Click(sender As Object, e As EventArgs) Handles btnCalculateAve.Click
        ' Step 0 - declare Variables.
        Dim dblWeekOneTemp As Double    ' Week One
        Dim dblWeekTwoTemp As Double    ' Week Two
        Dim dblWeekThreeTemp As Double  ' Week Three
        Dim dblWeekFourTemp As Double   ' Week Four
        Dim dblWeekFiveTemp As Double   ' Week Five
        Dim dblAverageTemp As Double    ' Weekly Average Temperature.

        Try
            ' Step 1 - Input
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            ' Get Week's temperature, Convert TxtWeek to intWeek. 
            dblWeekOneTemp = CDbl(txtWeekOneTemp.Text)
            dblWeekTwoTemp = CDbl(txtWeekTwoTemp.Text)
            dblWeekThreeTemp = CDbl(txtWeekThreeTemp.Text)
            dblWeekFourTemp = CDbl(txtWeekFourTemp.Text)
            dblWeekFiveTemp = CDbl(txtWeekFiveTemp.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate weekly temperature average.
            dblAverageTemp = (dblWeekOneTemp + dblWeekTwoTemp +
                dblWeekThreeTemp + dblWeekOneTemp + dblWeekFiveTemp) / intFIVE_WEEK_PERIOD

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room fields TextBoxes.
        txtWeekOneTemp.Clear()
        txtWeekTwoTemp.Clear()
        txtWeekThreeTemp.Clear()
        txtWeekFourTemp.Clear()
        txtWeekFiveTemp.Clear()

        ' Clear the average Label.
        lblAverageTemp.Text = String.Empty

        ' Reset the focus to the first Field
        txtWeekOneTemp.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
