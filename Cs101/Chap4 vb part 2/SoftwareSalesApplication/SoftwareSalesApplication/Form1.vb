Option Strict On
'**************************************************************************************************************************************
' Name: Jose Martinez Perez
' Date:11/25/2020, 11/30/2020
' Puporse: To let users to lease a software yearly or purchase it fora one-time fee. It also offer 
'          customers numerous add-on options such as technical support, training, and cloud backup.
' Input: No imput only constants.
' Processing: Licensing options are detemine if one radio button is selected, it is assinged to the variable
'             dblCostSoftwLi which holds the total cost of the licensing option selected. However, with 
'             checkBoxes, they are optional. To determine if a CheckBox is selected a If.....Then statement 
'             Is used to test. Since, users can select multiple Check boxes, a mathematical calculation 
'             Is needed to get the results of the optional features. In this case, addition is used to get 
'             the total cost of Optional features(yearly).
' Output: Displays total cost of software licensing in the lblCostSoftwLice as currency format and total 
'         cost of additional features is displayed in the label box which has a control nameo as lblCostOptFeat as a currence format.
'****************************************************************************************************************************************
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Step 0 - Declare Variables.
        Dim dblCostSoftwLi As Double       ' TotalCost of software licensing.
        Dim dblTotalCostOptional As Double  ' Total cost of optional features

        ' Each Variable holds a Base Yearly fee for each optional features.
        Dim dblTotalA As Double
        Dim dblTotalB As Double
        Dim dblTotalC As Double

        ' Constants for Licensing options.
        Const dblYEARLY_LICENSE As Double = 5000D
        Const dblONE_TIME_PURCHASE As Double = 20000D

        ' Constants for optional features(Yeary Amount)
        Const dblLEVEL_3_TECH_SUP As Double = 3500D
        Const dblON_SITE_TRAIN As Double = 2000D
        Const dblCLOUD_BACK_UP As Double = 300D

        ' Step 2 - Input(but there are no actual inputs values, only constants)
        ' Determine the Licensing Options, Yearly or One time fee.
        If radYearlyLic.Checked = True Then
            dblCostSoftwLi = dblYEARLY_LICENSE
        ElseIf radOneTimePchse.Checked = True Then
            dblCostSoftwLi = dblONE_TIME_PURCHASE
        Else
            ' Display an error message in a Message box.(Not needed)
            MessageBox.Show("Select a licensing available.")
        End If

        ' Check for Optional features for Level-3 Technical support(Yearly).
        If chkLevel3TechS.Checked = True Then
            dblTotalA = dblLEVEL_3_TECH_SUP
        End If

        ' Check for optional for On-Site Training(Yearly).
        If chkOneSiteTrain.Checked = True Then
            dblTotalB = dblON_SITE_TRAIN
        End If

        ' Check for optional feature for Cloud backup(yearly).
        If chkCloudBackup.Checked = True Then
            dblTotalC = dblCLOUD_BACK_UP
        End If

        ' Step 2 - Processing
        ' Calculate the Total cost of optional features(yearly).
        dblTotalCostOptional = dblTotalA + dblTotalB + dblTotalC

        ' Step 3 -Output
        ' Display values for licensing options and Optional Features(yearly) in
        ' their corresponding label boxes.
        lblCostSoftwLice.Text = dblCostSoftwLi.ToString("c")
        lblCostOptFeat.Text = dblTotalCostOptional.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear label boxes.
        lblCostSoftwLice.Text = String.Empty
        lblCostOptFeat.Text = String.Empty

        ' Reset the to yearly radios
        radYearlyLic.Checked = True

        ' Clear the check boxes.
        chkLevel3TechS.Checked = False
        chkOneSiteTrain.Checked = False
        chkCloudBackup.Checked = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class
