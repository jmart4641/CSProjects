Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBillAmount.TextChanged

    End Sub

    Private Sub btnFifteen_Click(sender As Object, e As EventArgs) Handles btnFifteen.Click
        ' Step 0 - Declare Variable
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Step 1 - Input
        ' Syntax:
        '     dblVariable = CDbl(txtControl.Text)
        ' Get the amount of the bill
        ' Convert String txtBillAmount to Double 
        dblBill = CDbl(txtBillAmount.Text)

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Calculate a 15 percent tip 
        dblTip = dblBill * 0.15

        ' Step 3 - Output
        ' Syntax:
        '   lblControl.Text = numeriVariable.ToString()
        ' Convert Double dblTip to String
        ' Display the tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwenty_Click(sender As Object, e As EventArgs) Handles btnTwenty.Click
        'Step 0 - Declare Variable
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Step 1 - Input
        ' Syntax:
        '     dblVariable = CDbl(txtControl.Text)
        ' Get the amount of the bill
        ' Convert String txtBillAmount to Double 
        dblBill = CDbl(txtBillAmount.Text)

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Calculate a 20 percent tip 
        dblTip = dblBill * 0.2

        ' Step 3 - Output
        ' Syntax:
        '   lblControl.Text = numeriVariable.ToString()
        ' Convert Double dblTip to String
        ' Display the tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwentyFive_Click(sender As Object, e As EventArgs) Handles btnTwentyFive.Click
        ' Step 0 - Declare Variable
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        ' Step 1 - Input
        ' Syntax:
        '     dblVariable = CDbl(txtControl.Text)
        ' Get the amount of the bill
        ' Convert String txtBillAmount to Double 
        dblBill = CDbl(txtBillAmount.Text)

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Calculate a 25 percent tip 
        dblTip = dblBill * 0.25

        ' Step 3 - Output
        ' Syntax:
        '   lblControl.Text = numeriVariable.ToString()
        ' Convert Double dblTip to String
        ' Display the tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Form
        Me.Close()
    End Sub
End Class
