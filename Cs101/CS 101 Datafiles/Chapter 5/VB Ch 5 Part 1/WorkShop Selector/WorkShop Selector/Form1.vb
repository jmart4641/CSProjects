Option Strict On
'********************************************************************************************************************************************
' Name: Jose R. Martinez
' Date: 12/7/2020
' Purpose: To create an application that allow the user to select a worshop from one list box and a location from another list box.
'          When the user clicks the Add workshop button, the application adds the total cost for the selected location in the third list box. 
'          For the Calculate Total button, the total cost of workshop and the location is calculated and displayed in the label box.
' Input: No input only some values are assign to the corresponding workshop and location using if... elseif .. else statement.
' Processing: First the Add workshop button is programmed, the variables are declared to hold days, registration cost, Lodging fees and
'             strOutput to hold strings. If... elseif statements are used to determine whether an index is equal to -1. The first items
'              in the list boxes they have an index of 0 value and the second item has has an index value of 1 and so on.
'              In the Else Clause, registration fees is converted into a string to be displayed in the lstCost. 
'              The if .... elseif statement that are located inside the else clause, determines whether an in index is equals to 0,1,2,3,4.
'              If one is true the corresponding registration fee is assign to dblRegistration and days are assign to IntNumDay.(If..ElseIf)
'              Else, there will be an error message displayed in a messagebox. For the location list box, if.... elseIf stament was used to
'              determine whether a location was selected used the SelectedIndex method. 
'              Lastly, the Calculte Total button, an if statement is used to determine whether items are in the  lstCost listBox. Then,
'              items are selcted and coverted into integers. Finally the total calculation is executed then displayed in the label box for total.
' Output: The output is diplayed in a label which has a side label of Total Cost. Labe contains the sum of all cost of the workshop.
'********************************************************************************************************************************************
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        ' Declare variables
        Dim strOutput As String
        Dim dblRegistrationCost As Double
        Dim intNumDay As Integer            ' Holds selected days
        Dim dblLodgFees As Double

        ' Test whether an item is selected from the list for Workshops.
        ' If False there will be an error message displayed.
        If lstPWorkshop.SelectedIndex = -1 Then
            MessageBox.Show("Select a Workshop")
        ElseIf lstPLocation.SelectedIndex = -1 Then
            MessageBox.Show("Select a Location")
        Else
            ' Select item will be displayed in the lstCost for registration fee.
            strOutput = lstPWorkshop.SelectedItem.ToString() & " " & "Registration Fee:"
            lstListCosts.Items.Add(strOutput)

            ' Determines whether one index is slected in order to assign values to them.
            ' if one is true, the registration fee is displayed in the cost list box.
            If lstPWorkshop.SelectedIndex = 0 Then
                dblRegistrationCost = 595
                strOutput = dblRegistrationCost.ToString("C")
                intNumDay = 3
                lstListCosts.Items.Add(strOutput)
            ElseIf lstPWorkshop.SelectedIndex = 1 Then
                dblRegistrationCost = 695
                strOutput = dblRegistrationCost.ToString("C")
                lstListCosts.Items.Add(strOutput)
                intNumDay = 3
            ElseIf lstPWorkshop.SelectedIndex = 2 Then
                dblRegistrationCost = 995
                strOutput = dblRegistrationCost.ToString("C")
                lstListCosts.Items.Add(strOutput)
                intNumDay = 3
            ElseIf lstPWorkshop.SelectedIndex = 3 Then
                dblRegistrationCost = 1295
                strOutput = dblRegistrationCost.ToString("C")
                lstListCosts.Items.Add(strOutput)
                intNumDay = 5

            ElseIf lstPWorkshop.SelectedIndex = 4 Then
                dblRegistrationCost = 395
                strOutput = dblRegistrationCost.ToString("C")
                lstListCosts.Items.Add(strOutput)
                intNumDay = 1
            End If

            ' Displays Lodging Fees in the lstCost
            strOutput = "Lodging Fees:  "
            lstListCosts.Items.Add(strOutput)

            ' Determines whether a location is selected by using the SelectedIndex
            ' and If statement.
            If lstPLocation.SelectedIndex = 0 Then
                dblLodgFees = 95 * intNumDay
                strOutput = dblLodgFees.ToString("C")
                lstListCosts.Items.Add(strOutput)
            ElseIf lstPLocation.SelectedIndex = 1 Then
                dblLodgFees = 125 * intNumDay
                lstListCosts.Items.Add(dblLodgFees.ToString("C"))
            ElseIf lstPLocation.SelectedIndex = 2 Then
                dblLodgFees = 110 * intNumDay
                lstListCosts.Items.Add(dblLodgFees.ToString("C"))
            ElseIf lstPLocation.SelectedIndex = 3 Then
                dblLodgFees = 100 * intNumDay
                lstListCosts.Items.Add(dblLodgFees.ToString("C"))
            ElseIf lstPLocation.SelectedIndex = 4 Then
                dblLodgFees = 92 * intNumDay
                lstListCosts.Items.Add(dblLodgFees.ToString("C"))
            ElseIf lstPLocation.SelectedIndex = 5 Then
                dblLodgFees = 90 * intNumDay
                lstListCosts.Items.Add(dblLodgFees.ToString("C"))
            End If
        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables
        Dim dblTotalCost As Double      'Accumulator
        Dim intCount As Integer
        Dim strNum As String
        Dim strOutput As String
        Dim intNum As Integer
        Dim intCost As Integer

        ' Determines whether items are in the lstCost box.
        If lstListCosts.Items.Count = 0 Then
            MessageBox.Show("There are no items in the list")
        Else
            ' Items are selected and are converted into string then into integers.
            strNum = lstListCosts.Items(1).ToString()
            intNum = CInt(strNum)
            strNum = lstListCosts.Items(3).ToString()
            intCost = CInt(strNum)

            For intCount = 0 To intNum          ' Count is Declared and tested
                ' To calculate total cost
                dblTotalCost = intCost + intCount
                strOutput = dblTotalCost.ToString("C")

                ' Displays the total in the label box.
                lblTotal.Text = strOutput
            Next
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Unselects items 
        lstPWorkshop.SelectedIndex = -1
        lstPLocation.SelectedIndex = -1

        ' Clears List Box for Cost list.
        lstListCosts.Items.Clear()

        ' Clear label box for total Cost.
        lblTotal.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
