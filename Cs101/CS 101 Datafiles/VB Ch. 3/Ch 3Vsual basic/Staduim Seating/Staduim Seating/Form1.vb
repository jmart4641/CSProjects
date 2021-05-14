'************************************************************************************************************************************************
' Name: Jose Martinez Perez
' Date:11/7/2020
' Puporse: To display/Calculate the amount of income generated 
'          from each class of ticket sales and the total revenue generated.
' Input: Number of ticket sold for each class (class A,B and C).
' Processing: Multiply the number of tickets sold for each class(A,B,C) 
'             by the corresponding Class(A,B Or C) Seats Cost.
'             The results will display in the corresponding label for each class 
'             then Add all Classes to get the results for the total Revenue Label.
' Output: Display a message indicating the total cost for each class 
'         and the Total Revenue in the label Total Revenue in revenue generated(GroupBox).
'***********************************************************************************************************************************************
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        ' Step 0 - Declare variables.
        ' Local-Level constants for the ticket Prices.
        Dim decCLASS_A_PRICE As Decimal = 15D
        Dim deCLASS_B_PRICE As Decimal = 12D
        Dim decCLASS_C_PRICE As Decimal = 9D

        ' Local Level variable to hold Tickets Sold.
        Dim intClassATickets As Integer
        Dim intClassBTickets As Integer
        Dim intClassCTickets As Integer

        ' Variables declare as doubles to hold the expression
        ' or cost of each ticket class.
        Dim dblClassARevenue As Double
        Dim dblClassBRevenue As Double
        Dim dblClassCRevenue As Double

        ' Total Revenue
        Dim dblTotalRevenue As Double

        ' Step 1 - Input
        ' Syntax:
        '       intVairbale = CInt(txtControl.Text)
        '       dblVAriable = CDbl(txtControl.Text)
        '       decVariable = CDec(txtControl.Text)
        Try
            ' Get the Tickets' amount and
            ' Converts txtClass to Integer.
            intClassATickets = CInt(txtClassA.Text)
            intClassBTickets = CInt(txtClassB.Text)
            intClassCTickets = CInt(txtClassC.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate(Multiply) the Amount of tickets sold by Each Class Price.
            dblClassARevenue = intClassATickets * decCLASS_A_PRICE
            dblClassBRevenue = intClassBTickets * deCLASS_B_PRICE
            dblClassCRevenue = intClassCTickets * decCLASS_C_PRICE

            ' Add all revenues of all three classes A+B+C
            dblTotalRevenue = dblClassARevenue + dblClassBRevenue + dblClassCRevenue

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the total in each class in the corresponding label.
            lblClassA.Text = dblClassARevenue.ToString("C")
            lblClassB.Text = dblClassBRevenue.ToString("C")
            lblClassC.Text = dblClassCRevenue.ToString("C")

            ' Total Revenue in lblTotatRevenue.
            ' Converts dbl to string with Currency format.
            lblTotalRevenue.Text = dblTotalRevenue.ToString("C")

        Catch
            ' Display an Error Message.
            MessageBox.Show("Error: Be sure to enter Valid Numeric Values")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the textbox forms.
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        ' Clear the labels forms.
        lblClassA.Text = ""
        lblClassB.Text = ""
        lblClassC.Text = ""
        lblTotalRevenue.Text = String.Empty

        ' Rest the focus to the first field.
        txtClassA.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
