Option Strict On

'****************************************************************************************************
' Name: Jose R. Martinez Perez
' Date: 11/12/2020
' Purpose: To calculate the number of slices a pizza of any size can be divided into.
' Input: Diamater of the pizza, in inches.
' Processing: Calculate the number of slices that can be cut from a pizza size. First, the radius is calculated
'             by diving the diameter of the pizza by 2. Then to get the Area Pi*(Radius^2) then finally, 
'             the Area Is divided by Area of a slice(14.125). The result will be the number of Slices.
' Output:  Display a message that indicates the number of slices in th lblNumberOfSlices label.
'**********************************************************************************************************
Public Class Form1
    'Constants for Each slice Area, Pi, Exponent and number 2 to which is divided to get the radius.
    Const dblONE_SLICE_AREA As Double = 14.125D
    Const dblPI As Double = 3.1459
    Const dblEXPONENT_NUMBER As Double = 2
    Const dblDIVIDED_BY_TWO As Double = 2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateSlices.Click
        'Step 0 - Declare Variable
        Dim dblDiameterOfPizza As Double
        Dim intNumberOfSlices As Integer

        ' To assign Radus, and Area values
        Dim dblRadus As Double
        Dim dblArea As Double

        Try
            'Step 1 - Input
            'Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            dblDiameterOfPizza = CInt(txtDiameterPizza.Text)

            'Step 2 - Processing
            'Syntax:
            '       variable = expression
            ' Calculate the radus, Area and lastly divide the area by 14.125

            dblRadus = dblDiameterOfPizza / dblDIVIDED_BY_TWO
            dblArea = dblPI * (dblRadus ^ dblEXPONENT_NUMBER)
            intNumberOfSlices = CInt(dblArea / dblONE_SLICE_AREA)

            'Step 3 - Output
            'Syntax:
            '       lblControl.Text = numericVariable.ToString()
            lblNumberOfSlices.Text = intNumberOfSlices.ToString("n0")
        Catch
            ' Error message box display to insert a numeric value.
            MessageBox.Show("Enter Numbers Only!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the Actual Property Value.
        txtDiameterPizza.Clear()

        ' Clear the lbl for number of slices
        lblNumberOfSlices.Text = String.Empty

        ' Reset the focus to the first field.
        txtDiameterPizza.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class
