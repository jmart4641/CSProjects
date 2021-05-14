Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateSalePrice_Click(sender As Object, e As EventArgs) Handles btnCalculateSalePrice.Click
        'Step 0 - Declare Variables
        Dim dblOrginalPrice As Double
        Dim dblDiscountPercentage As Double
        Dim dblSalePrice As Double

        'Step 1 - Get Input
        'Syntax:
        '       dblVariable =CDbl(txtControlName.Text)
        dblOrginalPrice = CDbl(txtOriginalPrice.Text)
        dblDiscountPercentage = CDbl(txtDiscountPercentage.Text)

        'Step 2 - Processing
        dblSalePrice = (1 - dblDiscountPercentage) * dblOrginalPrice

        'Step 3 - Display Output
        'Syntax:
        '   lblVontrolName.Text = numVariable.ToString("C2)
        lblSalePrice.Text = dblSalePrice.ToString("C2")
    End Sub
End Class
