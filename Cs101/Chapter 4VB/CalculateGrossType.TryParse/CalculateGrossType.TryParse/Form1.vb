Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Step 0 - Declare variables
        ' Declare Variables
        Dim intHoursWorked As Integer       ' Hours Worked
        Dim decPayRate As Decimal          ' Hourly Pay Rate
        Dim decGrossPay As Decimal          ' Gross pay

        ' Clear any previously displayed message.
        lblStatus.Text = String.Empty

        'Step 1 - Input
        ' Get the hours worked.
        If Integer.TryParse(txtHoursWorked.Text, intHoursWorked) Then
            ' Get the hourly pay rate.
            If Decimal.TryParse(txtPayRate.Text, decPayRate) Then
                ' Step 2- Processing
                ' Calculate the gross pay.
                decGrossPay = intHoursWorked * decPayRate

                ' Stept 3 - Output
                ' Display the Gross Pay.
                lblGrossPay.Text = decGrossPay.ToString("c")
            Else
                ' Display pay rate error message.
                lblStatus.Text = "Enter a valid value for hourly for hours worked."
            End If
        Else
            ' Display hours worked error message.
            lblStatus.Text = "Enter a valid integer for hours worked."
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' closes the form.
        Me.Close()

    End Sub
End Class
