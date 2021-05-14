Public Class Form1
    Private Sub tnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Step 0 - Declare Variable
        Dim dblAnualSalary As Double
        Dim intPayPeriod As Integer
        Dim dblSalary As Double

        Try
            'Step 1 - Input
            'Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            dblAnualSalary = CDbl(txtAnualSalary.Text)

            Try
                intPayPeriod = CInt(txtPayPeriod.Text)

                Try
                    'Step 2 - Processing
                    'Syntax:
                    '       variable = expression
                    dblSalary = dblAnualSalary / intPayPeriod

                    'Step 3 - Output
                    'Syntax:
                    '       lblControl.Text = numericVariable.ToString()
                    lblSalary.Text = dblSalary.ToString("C")

                Catch
                    ' Error Message for division-zero
                    MessageBox.Show("Pay periods cannot be zero")
                End Try
            Catch
                ' Error message for invalid pay periods.
                MessageBox.Show("Pay periods must be an Integer.")
            End Try

        Catch
            ' Error message for invalid salary.
            MessageBox.Show("Enter a numeric value for salary.")
        End Try
    End Sub
End Class
