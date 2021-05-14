Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
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
            intPayPeriod = CInt(txtPayPeriod.Text)



            'Step 2 - Processing
            'Syntax:
            '       variable = expression
            dblSalary = dblAnualSalary / intPayPeriod

            'Step 3 - Output
            'Syntax:
            '       lblControl.Text = numericVariable.ToString()
            lblSalary.Text = dblSalary.ToString("C")

        Catch ex As Exception
            MessageBox.Show("Enter Numbers Only!")
        End Try

    End Sub
End Class
