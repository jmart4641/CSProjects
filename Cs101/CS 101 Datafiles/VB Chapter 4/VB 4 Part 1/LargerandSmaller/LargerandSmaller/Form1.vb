Option Strict On
'************************************************************************************************************************************
'Name: Jose R. Martinez Perez
' Date: 11/30/2020
' Purpose: To Compare which interger is equal or greater.
' Input: The user enter two integers in the TextBoxes. An error will be display if an integer is not entered.
' Processing: First the the TryParse methos is declare to determine whether a string contains a value that can be successfully 
'             converted to a specific data type, in this case is it converted in an integer data type.
'             Then if all of the TryParse Methods are true the next if statement is executed. If the first if statemt is false.
'             Then next, ElseIf statemet is executed until one of the statemts are true.
' Output: Display whether value A or B is greater or equal to each other.
'*************************************************************************************************************************************
Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        ' Step 0 - Declare variables.
        Dim intA As Integer        ' Integer A
        Dim intB As Integer          ' Integer B

        ' Step 1 - Input
        ' Get the Value for A as integer.
        If Integer.TryParse(txtAInteger.Text, intA) Then
            ' Get the value of B as integer.
            If Integer.TryParse(txtBInteger.Text, intB) Then
                ' Step 2- Processing/Comparing Integers to detemine which one is equal or greater.
                If intA = intB Then
                    lblResults.Text = "The Value of A is equal to B."
                ElseIf intA > intB Then
                    lblResults.Text = "A is Greater than B."
                ElseIf intB > intA Then
                    lblResults.Text = "B is Greater than A."
                End If
            Else
                lblResults.Text = "The value must be an integer."
            End If
        Else
            lblResults.Text = "Please input an Integer value."
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()

    End Sub
End Class
