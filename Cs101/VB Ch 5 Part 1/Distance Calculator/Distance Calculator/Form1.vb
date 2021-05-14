Option Strict On
'*****************************************************************************************************************************************************
' Name: Jose R. Martinez
' Date: 12/5/2020
' Purpose: To create an application that displays the time and speed amount traveled.
'          User clicks the Calculate button, the application should display an input box
'          asking the user for speed of the vehicle in miles-per-hour, followed another input 
'          asking for the amount of time, in hours in which the vehicle has traveled.
' Input: A positive integer Value must enter when the input box is displayed
' Processing: First the string is converted int a integer values then Determine if the values is a positive integer. 
'             If the integer is positive the calculation happens which is displayed first in the Input box. Vehicle Speed,
'             Time traveled, adn the Hours and Distance text will be displayed first. For these string to displayed 
'             I used a input box for each which allows them to be displayed in the input box.
'             A For....Next Looop is used for the times that the user-specified number of hours traveled.
'             An lstInput.items.add was used to allow the string to be displayed and add to the input box.
' Output: The output is diplayed in a in the input box plus the last string that appear in the botton displays the total speed traveled.
'         Also if there invalid inputs are inserted in, there will an error message displays stating that input is invalid.
'*****************************************************************************************************************************************************
Public Class Form1
    Private Sub btnCaculate_Click(sender As Object, e As EventArgs) Handles btnCaculate.Click
        ' Declare Variables
        Dim intTotalDis As Integer = 0              ' Accumulator, initialized to 0
        Dim intAmountOfTImeInput As Integer = 0     ' To hold Time user input
        Dim intMPHSpeedInput As Integer             ' To hold Speer MPH
        Dim intCount As Integer                     ' Counter Variable, Loop count
        Dim strTimeInput As String                  ' To hold User input for Time 
        Dim strSpeedInput As String                 ' To hold user input for Speed
        Dim intVehicleSpeed As Integer              ' To Hold the multiplication of Speed * Time(This is not necesary)

        ' Prompt the user for the speed Vehicle in MPH
        strSpeedInput = InputBox("Enter the speed of the vehicle in Miles-per hour", "Speed")

        ' Determine whether the Input for speed is an integer and values are not less than 0.
        ' Else and error message will be displayed.
        If Integer.TryParse(strSpeedInput, intMPHSpeedInput) Then
            If intMPHSpeedInput > 0 Then
                ' Prompt the for the time in hours traveled
                strTimeInput = InputBox("Enter the amount of time in Hours traveled? ", "Hours")

                'Determine whether the input for time hours is an integer
                ' Else there will be an error message.
                If Integer.TryParse(strTimeInput, intAmountOfTImeInput) Then
                    If intAmountOfTImeInput > 0 Then
                        ' Calculate the speed.
                        intVehicleSpeed = intAmountOfTImeInput * intMPHSpeedInput

                        'Display the Vihicle Speed 
                        strSpeedInput = "Vehicle Speed: " & intMPHSpeedInput.ToString() & " MPH"
                        lstOutput.Items.Add(strSpeedInput)

                        ' Display the Time traveled 
                        strTimeInput = "Time Traveled: " & intAmountOfTImeInput.ToString() & " Hours"
                        lstOutput.Items.Add(strTimeInput)

                        ' Display hours and  Distance Traveled
                        lstOutput.Items.Add("Hour   Distance Traveled")

                        ' Add the Gap in between
                        lstOutput.Items.Add("**********************************")

                        ' Multiple user specified number of times.
                        For intCount = 1 To intAmountOfTImeInput
                            ' Calculate the Speed
                            intTotalDis = intMPHSpeedInput * intCount

                            ' Create strings to display.
                            strTimeInput = intCount.ToString()
                            strSpeedInput = intTotalDis.ToString()

                            ' Add the strings to the listBox.
                            lstOutput.Items.Add(strTimeInput & "   " & "    " & "  " & strSpeedInput)
                        Next

                        lstOutput.Items.Add("Total Distance: " & intTotalDis.ToString())
                        ' Display in a list box the distance the vehicle has traveled for each hour.

                    Else
                        ' Displays an error message if a negative integer value is input.
                        MessageBox.Show("Enter a Positive Integer for time")
                    End If
                Else
                    ' Displays an error message if not an integer value
                    MessageBox.Show("Please enter an integer Value for time")
                End If

            Else
                ' Displays an error message if not an integer value for Speed.
                MessageBox.Show("Enter a positive integer value for Speed.")
            End If
        Else
            ' Displays an error message if not an integer.
            MessageBox.Show("Enter a integer value for Speed.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form.
        Me.Close()

    End Sub
End Class
