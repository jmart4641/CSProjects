' **************************************************************************************
' Author: Solution (Sale Price Calculator with Validation)
' Date: 10/31/2019
' Purpose:Calculate Discount and Sale Price amounts.
' Input: Original Price and Discount Percentage.
' Processing: Multiply Original Price by Discount Percentage to get the Discount.
'             Subtract the computed Discount from the Original Price to get Sale Price.
' Output: Display the Discount and Sale Price amounts.
' **************************************************************************************
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Step 0 - Declare Variables
        Dim dblOriginalPrice As Double
        Dim dblDiscountPercentage As Double
        Dim dblDiscount As Double
        Dim dblSalePrice As Double

        Try
            ' Step 1 - Input
            ' Syntax:
            '        strVariable = txtControl.Text
            '        intVariable = CInt(txtControl.Text)
            '        dblVariable = CDbl(txtControl.Text)
            '        decVariable = CDec(txtControl.Text)
            dblOriginalPrice = CDbl(txtOriginalPrice.Text)
            dblDiscountPercentage = CDbl(txtDiscountPercentage.Text) / 100

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            dblDiscount = dblDiscountPercentage * dblOriginalPrice
            dblSalePrice = dblOriginalPrice - dblDiscount

            ' Step 3 - Output
            ' Syntax:
            '    lblControl.Text = strVariable
            '    lblControl.Text = numVariable.ToString()  
            '    lblControl.Text = numVariable.ToString("C0")  
            '    lblControl.Text = numVariable.ToString("P0")
            ' Refer to tables 3-14 & 3-15 for more format specifiers
            lblDiscount.Text = dblDiscount.ToString("C2")
            lblSalePrice.Text = dblSalePrice.ToString("C2")
        Catch ex As Exception
            MessageBox.Show("Enter numbers only!")
        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
