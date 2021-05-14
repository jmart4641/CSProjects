Option Strict On
'******************************************************************************************************************************************
' Name: Jose Martinez Perez
' Date:11/24/2020
' Puporse: To display/Calculate the percentage of calories that come from fat.
' Input: Number of calories and fat grams in a food.
' Processing: Multiply Fat Grams to 9 which means one gram of fat gas 9 calories. Then the percentage
'             of calories from fat is calculated Calories from fat(dblFatCal) by Total calories(dblTotalNumCal).
'             The results will display in the corresponding label. Before the calculations get executed, If statements were used to
'             test each condition. The only time that a complete calculation gets executed to get the Percentage of calories
'             Is when all are met.
' Output: Display the percentage of calories from fat and if the number of calories and fat grams are not numeric or less than 0,
'         there will be an error message displayed. Since calories from fat cannot be greater than the total number of calories,
'         if the user attempt to do it, there will an error message in a message box. 
'******************************************************************************************************************************************
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Step 0 - Declare variables.
        Dim dblTotalNumCal As Double        ' Number of Calories in the food.
        Dim dblNumberFat As Double          ' Number of fat grams in the food.
        Dim dblFatCal As Double             ' Calories from fat
        Dim dblPercentageCal As Double      ' Percentage of calories that come from fat.

        ' Constants for One gram of fat has 9 calories, and a constant if Calories from fat are less than 30%.
        Const dblCALORIES_9 As Double = 9D
        Const dblIF_CAL_LESS As Double = 0.3D

        ' Clears the status bar after you input a new set of numbers in the text boxes without using the botton clear.
        lblStatus.Text = String.Empty

        Try
            ' Step 1 - Input
            ' Validate and convert the number of calories in the food and Num. of fat grams in the food.

            ' Get the number of calories
            dblTotalNumCal = CDbl(txtNumberOfCalories.Text)
            dblNumberFat = CDbl(txtNumberFatGrams.Text)

            ' Determines whether number of calories and fat grams are numeric and are not less than 0.
            ' Detemines whether the number of calories from fat cannot be greater than the total number of calories.
            If dblTotalNumCal <= 0 Then
                ' Display an error message that input cannot be less than 0.
                MessageBox.Show("Number of calories cannot be less than 0.")
            ElseIf dblNumberFat < 0 Then
                ' Displays an error message.
                MessageBox.Show("Number of fat grams cannot be less than 0")

            ElseIf dblNumberFat > dblTotalNumCal Then
                ' Display an Error message.
                MessageBox.Show("Calories from fat cannot be greater than the total number of calories.")
            Else
                ' Step 2 - Processing
                ' One gram of fas has 9 calories(multiply)
                dblFatCal = dblNumberFat * dblCALORIES_9
                ' Calculates the percentage of calories from fat.
                dblPercentageCal = dblFatCal / dblTotalNumCal

                ' Detemines whether the colories from fat are less than 30% of the total calories's food.
                If dblPercentageCal < dblIF_CAL_LESS Then
                    lblStatus.Text = "Food is low in Fat."
                    lblPctFatCalories.Text = dblPercentageCal.ToString("p")
                Else
                    ' Display the total percentage of calories from fat.
                    lblPctFatCalories.Text = dblPercentageCal.ToString("p")
                End If
            End If
        Catch
            ' Displays a message box with an error message.
            MessageBox.Show("Please enter a numeric value")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear textBoxes
        txtNumberOfCalories.Clear()
        txtNumberFatGrams.Clear()

        ' Clear Labels
        lblPctFatCalories.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Rest the focus to Number of calories textbox.
        txtNumberOfCalories.Focus()
        txtNumberOfCalories.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
