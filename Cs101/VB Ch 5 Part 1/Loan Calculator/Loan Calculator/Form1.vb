Public Class Form1
    ' Class - Level Constants
    Const dblMONTHS_YEAR As Double = 12      ' Months per year
    Const dblNEW_RATE As Double = 0.05       ' Interest rate, new cars.
    Const dblUSED_RATE As Double = 0.08      ' Interest rate, Used cars.

    ' Class-Level Variable to hold the annual interest rate.
    Dim dblAnnualRate As Double = dblNEW_RATE
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double        ' Vehicle cost
        Dim dblDownPayment As Double        ' Down Payment
        Dim intMonth As Integer             ' Number of months for the loan
        Dim dblLoan As Double               ' Amount of the loan
        Dim dblMontlyPayment As Double      ' Monthly payment
        Dim dblInterestRate As Double       ' Interest rate for the period
        Dim dblPrincipal As Double          ' Principal paid for the period
        Dim intCount As Integer             ' Counter for the loop
        Dim strOut As String                ' Used to hold a line of output
        Dim blnInputOk As Boolean = True    ' A flag

        ' Get the vehicle cost, validating at the same time.
        If Not Double.TryParse(txtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number!"
            blnInputOk = False
        End If

        ' Get the dowm Payment. validating at the same time.
        If Not Double.TryParse(txtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Down Payment must be a number!"
            blnInputOk = False
        End If

        ' Get the number of months, validating at the same time.
        If Not Integer.TryParse(txtMonths.Text, intMonth) Then
            lblMessage.Text = "Months must be an integer."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            'Calculate the loan amount and montly payment.
            dblLoan = dblVehicleCost - dblDownPayment
            dblMontlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR,
                                   intMonth, -dblLoan)

            ' Clear the list box and message label.
            lstOutput.Items.Clear()
            lblMessage.Text = String.Empty

            For intCount = 1 To intMonth
                ' Calculate the interest for this period
                dblInterestRate = IPmt(dblAnnualRate / dblMONTHS_YEAR,
                                       intCount, intMonth, -dblLoan)

                ' Start building the output string with the month.
                strOut = "Month " & intCount.ToString("d2")

                ' Add the payment amount to the output string
                strOut &= ": payment = " & dblMontlyPayment.ToString("n2")

                ' Add the interest amount to the output string.
                strOut &= ", interes = " & dblInterestRate.ToString("n2")

                ' Add the principal for the period.
                strOut &= ", principal = " & dblPrincipal.ToString("n2")

                ' Add the output string to the list box.
                lstOutput.Items.Add(strOut)
            Next
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the interest rate
        dblAnnualRate = dblNEW_RATE

        ' Clear the text boxes
        txtCost.Clear()
        txtDownPayment.Clear()
        txtMonths.Clear()

        ' Clear the list box,
        lstOutput.Items.Clear()

        ' Set default interest rate for new car loans.
        lblAnnualRate.Text = String.Empty
        radUsed.Checked = True

        ' Clear any error messages.
        lblMessage.Text = String.Empty

        ' Reset the focus to txtCost.
        txtCost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radUsed.CheckedChanged
        ' If the New radio button is checked, then 
        ' then user has to select a New car loan.
        If radNew.Checked = True Then
            dblAnnualRate = dblUSED_RATE
            lblAnnualRate.Text = dblUSED_RATE.ToString("P")
            lstOutput.Items.Clear()
        End If
    End Sub

    Private Sub radNew_CheckedChanged_1(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        ' If the Used radio button is checked, 
        ' then user has to select a Used car loan.
        If radUsed.Checked = True Then
            dblAnnualRate = dblNEW_RATE
            lblAnnualRate.Text = dblNEW_RATE.ToString("P")
            lstOutput.Items.Clear()
        End If
    End Sub
End Class
