Option Strict On
'********************************************************************************************************************************************
' Name: Jose R. Martinez
' Date: 12/4/2020
' Purpose: To create an application that displays the input box which asks the user to enter a positive intege value.
'          The Default values Is 10. When the OK button is clicked, the application displas a message box with the
'          sum of all the integers from 1 trough the value entered by the user. 
' Input: A positive integer Value must enter when the input box is displayed.
' Processing: First the string is converted int a integer values then Determine if the values is a positive integer. 
'             If the integer is positive the calculation happens which the sume of all integer from 1 throught to 10 using 
'             a For....Next Looop. The final result will display in the message as " The sum of number 1 through the positive 
'             Integer value which a user enter in the Inpox." A Try catch method was used to determine whether the input is a numeric value.
' Output: The output is diplayed in a messagebox which contains the sum of all integer from 1 trhought the specific value that
'          a use enter in the inputbox.
'********************************************************************************************************************************************
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        ' Declare variables
        Dim strInput As String
        Dim intNumber As Integer
        Dim intCount As Integer = 1
        Dim intSum As Integer = 0

        Try
            ' Get the number to sum.
            strInput = InputBox("Enter a positive integer Value.", "Input Needed", "10")
            intNumber = CInt(strInput)

            '  Determine if the value enteres is a positive integer.
            If intNumber > 0 Then
                ' Add the number 1 throught a user-specific numbers.
                For intCount = 1 To intNumber
                    intSum += intCount
                Next

                ' Display the sum of the numbers.
                MessageBox.Show("The sum of numbers 1 throught " & intNumber.ToString() & " is " & intSum.ToString())
            Else

                ' Display an error message if a negative value is entered.
                MessageBox.Show("Enter a Positive integer value.")
            End If
        Catch
            ' Displays an error message to input an integer.
            MessageBox.Show("Please enter a numeric value only.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form.
        Me.Close()
    End Sub
End Class
