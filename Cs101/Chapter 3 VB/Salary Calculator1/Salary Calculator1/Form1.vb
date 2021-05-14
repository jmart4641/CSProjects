Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculateSalary.Click
        ' Step 0 - Declare Variable
        Dim dblAnualSalary As Double ' Annual Salary
        Dim intPayPeriod As Integer  ' Number of pay periods
        Dim dblSalary As Double      ' Salary per pay periods

        Try
            ' Step 1 - Input
            ' Syntax:
            '   intVairbale = CInt(txtControl.Text)
            '   dblVAriable = CDbl(txtControl.Text)
            '   decVariable = CDec(txtControl.Text)
            'Get the annual salary.
            dblAnualSalary = CDbl(txtAnnualSalary.Text)

            Try
                ' Get the numer of pay Periods.
                intPayPeriod = CInt(txtPayPeriods.Text)

                Try
                    ' Step 2 - Processing
                    ' Syntax:
                    '       variable = expression
                    ' Calculate the salary per period.
                    dblSalary = dblAnualSalary / intPayPeriod

                    ' Step 3 - Output
                    ' Syntax:
                    '       lblControl.Text = numericVariable.ToString()
                    ' Calculate the salary per pay period.
                    lblSalary.Text = dblSalary.ToString("C")
                Catch
                    ' Error message for division one-by-zero.
                    MessageBox.Show("Pay periods cannot be zero")
                End Try

            Catch
                ' Error message for invalid pay periods.
                MessageBox.Show("Pay periods must be an integer.")
            End Try

        Catch
            ' Error message for invalid Salary.
            MessageBox.Show("Enter a numeric value for salary")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
