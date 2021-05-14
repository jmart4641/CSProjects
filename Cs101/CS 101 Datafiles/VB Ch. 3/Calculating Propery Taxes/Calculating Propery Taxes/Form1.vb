Option Strict On

'****************************************************************************************************
' Name: Jose R. Martinez Perez
' Date: 11/12/2020
' Purpose: To calculate the assessment value and property tax.
' Input: the user input the actual value of a property. It must be a numerica value.
' Processing: Calculate the assessment value by multiplying the property value by 60%, the result will be displayed in the lblAssessmentValue.
'             For the property tax, multiply the assessment Value times property tax rate ($0.64)then divided by 100. The result will be displayed
'              in the label lblAssessmentValue and lblPropertyTax.
' Output: Displays tge assessment value and property tax.
'**********************************************************************************************************
Public Class Form1
    ' Class- Level Constants for Property tax Assessment, Propert Tax Rate
    ' and Each $100 of of the assessments value. 
    Const decPROPERTY_TAX_ASSESSMENT As Decimal = 0.6D
    Const decPROPERTY_TAX_RATE As Decimal = 0.64D
    Const dblEACH_HUNDRED_OF_THE_ASSESS As Double = 100

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Step 0 - Declare Variable
        Dim dblPropertyValue As Double
        Dim dblAssessmentValue As Double
        Dim dblPropertyTax As Double

        Try
            'Step 1 - Input
            'Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            dblPropertyValue = CDbl(txtPropertyValue.Text)

            'Step 2 - Processing
            'Syntax:
            '       variable = expression
            dblAssessmentValue = dblPropertyValue * decPROPERTY_TAX_ASSESSMENT
            dblPropertyTax = dblAssessmentValue * decPROPERTY_TAX_RATE / dblEACH_HUNDRED_OF_THE_ASSESS

            'Step 3 - Output
            'Syntax:
            '       lblControl.Text = numericVariable.ToString()
            lblAssessmentValue.Text = dblAssessmentValue.ToString("C")
            lblPropertyTax.Text = dblPropertyTax.ToString("C")

        Catch
            ' Error message box display to insert a numeric value.
            MessageBox.Show("Enter Numbers Only!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the Actual Property Value.
        txtPropertyValue.Clear()

        ' Clear the DecTotal Fields.
        lblAssessmentValue.Text = String.Empty
        lblPropertyTax.Text = String.Empty

        ' Reset the focus to the first field.
        txtPropertyValue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes the form
        Me.Close()
    End Sub
End Class
