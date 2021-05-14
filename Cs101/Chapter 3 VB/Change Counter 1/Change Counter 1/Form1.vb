Public Class Form1
    'Class-Level constants for the coin values
    Dim decFIVE_CENTS_VALUE As Decimal = 0.05D
    Dim decTEN_CENTS_VALUE As Decimal = 0.1D
    Dim decTWENTY_FIVE_CENTS_VALUE As Decimal = 0.25D
    Dim decFIFTY_CENTS_VALUE As Decimal = 0.5D

    ' Class-level variable to hold the total
    ' initialized with 0.
    Dim decTotal As Decimal = 0.0D
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picTenCents.Click
        ' Step 0 - Declare Variable
        ' Class level variable declared


        ' Step 1 - Input
        ' Syntax:
        '       intVairbale = CInt(txtControl.Text)
        '       dblVAriable = CDbl(txtControl.Text)
        '       decVariable = CDec(txtControl.Text)
        ' None

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Add the value of 5 cents to the total.
        decTotal = decTotal + decTEN_CENTS_VALUE

        ' Step 3 - Output
        ' Syntax:
        '       lblControl.Text = numericVariable.ToString()
        ' Display the total, formatted as currency.
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picFIftyCents.Click
        ' Step 1 - Input
        ' Syntax:
        '       intVairbale = CInt(txtControl.Text)
        '       dblVAriable = CDbl(txtControl.Text)
        '       decVariable = CDec(txtControl.Text)
        ' None

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Add the value of 5 cents to the total.
        decTotal = decTotal + decFIFTY_CENTS_VALUE

        ' Step 3 - Output
        ' Syntax:
        '       lblControl.Text = numericVariable.ToString()
        ' Display the total, formatted as currency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picFiveCents_Click(sender As Object, e As EventArgs) Handles picFiveCents.Click
        ' Step 0 - Declare Variable
        ' Class level variable declared

        'Step 1 - Input
        'Syntax:
        '       intVairbale = CInt(txtControl.Text)
        '       dblVAriable = CDbl(txtControl.Text)
        '       decVariable = CDec(txtControl.Text)
        'None

        'Step 2 - Processing
        'Syntax:
        '       variable = expression
        ' Add the values of 5 Cents to the total.
        decTotal = decTotal + decFIVE_CENTS_VALUE

        'Step 3 - Output
        'Syntax:
        '       lblControl.Text = numericVariable.ToString()
        '       lblControl.Text = numericVariable.ToString("n or n3") for number format.
        '       lblControl.Text = numericVariable.ToString("f") for Fixed-point Scientic format.
        '       lblControl.Text = numericVariable.ToString("e") "" exponetials S.F
        '        " "= "".ToString("C") "" Currency.
        '       "" ="".ToString("P") "" percent format.
        ' Display the total, Formatted as currency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub picTwentyFIveCents_Click(sender As Object, e As EventArgs) Handles picTwentyFIveCents.Click
        ' Step 1 - Input
        ' Syntax:
        '       intVairbale = CInt(txtControl.Text)
        '       dblVAriable = CDbl(txtControl.Text)
        '       decVariable = CDec(txtControl.Text)
        ' None

        ' Step 2 - Processing
        ' Syntax:
        '       variable = expression
        ' Add the value of 5 cents to the total.
        decTotal = decTotal + decTWENTY_FIVE_CENTS_VALUE


        ' Step 3 - Output
        ' Syntax:
        '       lblControl.Text = numericVariable.ToString()
        ' Display the total, formatted as currency.
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
