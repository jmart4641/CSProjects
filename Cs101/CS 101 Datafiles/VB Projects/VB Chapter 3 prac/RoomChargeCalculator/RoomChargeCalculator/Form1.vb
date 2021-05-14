Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("t")
    End Sub
    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        '  Step 0  -  Declare variables for the calculation
        Dim decRoomCharges As Decimal           ' Room charges total
        Dim decAddCharges As Decimal            ' Additional Charges
        Dim decSubtotal As Decimal              ' Subtotal
        Dim decTax As Decimal                   ' Tax
        Dim decTotal As Decimal                 ' Total of all charges
        Const decTAX_RATE As Decimal = 0.08D    ' Tax Rate

        Try
            ' Step 1  - Convert Text to Decimal, Calculate and Display the room charges.
            decRoomCharges = CDec(txtNight.Text) *
                CDec(txtNIghtlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomSerive.Text) +
                CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'Calculate and display the tax
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            ' Calculate and display the total charge.
            decTotal = decSubtotal + decTax
            lblTotalCharges.Text = decTotal.ToString("c")

            ' Change the color for the total Charges.
            lblTotalCharges.BackColor = Color.Blue
            lblTotalCharges.ForeColor = Color.White
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the room info sales
        txtNight.Clear()
        txtNIghtlyCharge.Clear()

        ' Clear the additional Charges fields
        txtRoomSerive.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the DecTotal Fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty

        ' Get today's date from the operating system and display it.
        lblDateToday.Text = Now.ToString("D")

        ' Get the current time from the operating system and display.
        lblTimeToday.Text = Now.ToString("T")

        ' Reset the lblTotalCharges control's colors.
        lblTotalCharges.BackColor = SystemColors.Control
        lblTotalCharges.ForeColor = SystemColors.ControlText

        ' Reset the focus to the first field.
        txtNight.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class