'*****************************************************************************************************************************************
' Name: Jose Martinez Perez
' Date:11/10/2020
' Puporse: To Calculate and display Gross Revenue for adult and child tickets sold, Net Revenue for adult and child tickets sold
'          which are ticket sales left over after the payment to the movie company has been deducted(20%). The total Gross renevue is 
'          calculate and displayed in the lbl lblTotalGrossRevenue label and the Net revenue is calculated and displayed in the 
'          lblTotalNetRevenue label.
' Input: Price per ticket for adult and child in two different TextBoxes and Tickets sold in two different TextBoxes and groupBoxes.
' Processing: Multiply the amount of tickets sold by the price per ticket then add the price of tickets sold for adult and child to get
'             the total Gross Revenue. Then to get the Net revenue after a deduction 20%(theater keeps) for adult and child, Gross revenue for 
'             each(GroupBox,Gross Revenue) is multiply by 0.2 to get the 20% that the theather keep. The final result will be the 
'             total Net Revenue which Is calculated by adding both Net revenues for adult and child tickets sales(GroupBox, Net Revenue)
' Output: Display a message indicating the adividual  tickets sales for adult and childand total Gross Revenue(Gross Ticket Revenue)
'         and individual adult and child tickets after a deduction of 20% and the total Net revenue after the deductions of 20%.
'*********************************************************************************************************************************************
Public Class Form1
    ' Constant Represents 20% that the theater keeps.
    Const decTHEATER_KEEPS_PERCENTAGE As Decimal = 0.2D

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateTicketR.Click
        ' Step 0 - Declare variables.
        ' Local Level variable to hold Adult and Child Tickets Sold.
        Dim dblPriceTicketAdult As Double
        Dim intTicketSoldAdult As Integer
        Dim dblPriceTicketChild As Double
        Dim intTicketSoldChild As Integer

        ' Variables declare as doubles to hold the expression
        ' Gross Ticket Revenue for adult ad child.
        Dim dblAdTicketSalesG As Double
        Dim dblChildTicketSaleG As Double
        Dim dblTotaGrossRevenue As Double

        ' Variables declare as doubles to hold the expression
        ' Net Ticket Revenue for adult and child.
        Dim dblAdTicketSalesN As Double
        Dim dblChildTicketSalesN As Double
        Dim dblTotalNetRevenue As Double

        Try
            ' Step 1 - Input
            ' Syntax:
            '       intVairbale = CInt(txtControl.Text)
            '       dblVAriable = CDbl(txtControl.Text)
            '       decVariable = CDec(txtControl.Text)
            ' Get the Tickets' amount and
            ' Converts txtClass to Integer.
            dblPriceTicketAdult = CDbl(txtPriceTicketAdult.Text)
            intTicketSoldAdult = CInt(txtTicketSoldAdult.Text)
            dblPriceTicketChild = CDbl(txtPriceTicketChild.Text)
            intTicketSoldChild = CInt(txtTicketSoldChild.Text)

            ' Step 2 - Processing
            ' Syntax:
            '       variable = expression
            ' Calculate(Multiply) the Amount of tickets sold by the Price.
            dblAdTicketSalesG = intTicketSoldAdult * dblPriceTicketAdult
            dblChildTicketSaleG = intTicketSoldChild * dblPriceTicketChild

            ' Add the price of child tickets sold and adult tickets sold to get the Total Gross Revenue.
            ' Total Gross number assiged to dblTotaGrossRevenue.
            dblTotaGrossRevenue = dblAdTicketSalesG + dblChildTicketSaleG

            ' Multiply Adults ticket sold Gross revenue by 20%, 
            ' Child ticket sold Gross revenue by 20 %. The result is the amount that the theater keeps.
            dblAdTicketSalesN = dblAdTicketSalesG * decTHEATER_KEEPS_PERCENTAGE
            dblChildTicketSalesN = dblChildTicketSaleG * decTHEATER_KEEPS_PERCENTAGE
            dblTotalNetRevenue = dblAdTicketSalesN + dblChildTicketSalesN

            ' Step 3 - Output
            ' Syntax:
            '       lblControl.Text = numericVariable.ToString()
            ' Display the total of Adult's Gross Ticket revenue, Child Gross Ticket Revenue
            ' and the total gross revenue in their assigneated labels.
            lblAdTicketSaleG.Text = dblAdTicketSalesG.ToString("C")
            lblChildTicketSaleG.Text = dblChildTicketSaleG.ToString("C")
            lblTotalGrossRevenue.Text = dblTotaGrossRevenue.ToString("C")

            ' Display the total of Adult's Net Ticket revenue, Child Net Ticket Revenue
            ' and the total Net revenue in their assigneated labels.
            lblAdultTicketSaleN.Text = dblAdTicketSalesN.ToString("C")
            lblChildTicketSaleN.Text = dblChildTicketSalesN.ToString("C")
            lblTotalNetRevenue.Text = dblTotalNetRevenue.ToString("C")

        Catch
            ' Display an Error Message.
            MessageBox.Show("Error: Be sure to enter Valid Numeric Values")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info field
        txtPriceTicketAdult.Clear()
        txtTicketSoldAdult.Clear()
        txtPriceTicketChild.Clear()
        txtTicketSoldChild.Clear()

        ' Clear the Gross Revenue fields
        lblAdTicketSaleG.Text = String.Empty
        lblChildTicketSaleG.Text = String.Empty
        lblTotalGrossRevenue.Text = String.Empty

        ' Clear the Net Revenue fields.
        lblAdultTicketSaleN.Text = String.Empty
        lblChildTicketSaleN.Text = String.Empty
        lblTotalNetRevenue.Text = String.Empty

        ' Reset the focus to the first fields.
        txtPriceTicketAdult.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' closes the form.
        Me.Close()
    End Sub
End Class
