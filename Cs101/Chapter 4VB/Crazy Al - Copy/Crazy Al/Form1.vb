Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes and labels.
        txtAdvancePayAmount.Clear()
        txtSalesAmount.Clear()
        lblCommissionAmount.Text = String.Empty
        lblCommissionRate.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Set the focus to txtSalesAmount.
        txtSalesAmount.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Step 0 - Variable declarations.
        Dim decSalesAmount As Decimal           '   Montly sales amount
        Dim decAdvancePayAmount As Decimal      '   Advance pay taken
        Dim decCommissionRate As Decimal        '   Commission rate
        Dim decCOmmissionAmount As Decimal      '   Commision
        Dim decNetPay As Decimal                '   Net Pay

        Try
            ' Clear any previous erros messages.
            lblStatus.Text = String.Empty

            ' Step 1  - Input
            ' Calculate and display
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            ' Get the amount of sales.
            decSalesAmount = CDec(txtSalesAmount.Text)

            ' Get the amount of Advance pay.
            decAdvancePayAmount = CDec(txtAdvancePayAmount.Text)

            ' Determine the commision rate.
            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.05D

                Case 10000 To 14999
                    decCommissionRate = 0.1D
                Case 15000 To 17999
                    decCommissionRate = 0.12D
                Case 18000 To 21999
                    decCommissionRate = 0.14D

                Case Is >= 22000
                    decCommissionRate = 0.15D
            End Select

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate the average score.
            ' Calculate the commission and net pay amounts.
            decCOmmissionAmount = decSalesAmount * decCommissionRate
            decNetPay = decCOmmissionAmount - decAdvancePayAmount

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the average, rounded to 2 decimals places.
            lblCommissionRate.Text = decCommissionRate.ToString("p")
            lblCommissionAmount.Text = decCOmmissionAmount.ToString("c")
            lblNetPay.Text = decNetPay.ToString("c")
        Catch
            ' Display an error message alerting user to invalid input.
            lblStatus.Text = "Please enter numeric values."
        End Try
    End Sub
End Class
