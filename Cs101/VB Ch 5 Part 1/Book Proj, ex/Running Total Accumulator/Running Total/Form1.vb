Public Class Form1

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSales.Click
        ' Declare Variables and contants
        Const intNUM_DAYS As Integer = 5    ' The number of days
        Dim intCount As Integer = 1         ' Loop counter
        Dim decSales As Decimal = 0         ' To hold daily sales
        Dim decTotal As Decimal = 0         ' To hold the total sales (ACcumulator) Important to initialize with a value of 0.
        Dim strInput As String              ' To hold the string input

        ' Get the sales for each day
        Do While intCount <= intNUM_DAYS
            ' Get a daily sales amount from the user.
            strInput = InputBox("Enter the sales for day " &
                              intCount.ToString())

            ' Convert the input to decimal.
            If Decimal.TryParse(strInput, decSales) Then
                ' Add the daily sales to the total sales.
                decTotal += decSales

                ' Add 1 to the loop counter.
                intCount += 1
            Else
                ' Display an erro message for valid input.
                MessageBox.Show("Enter a numerica value.")
            End If
        Loop

        ' Display the total sales.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
