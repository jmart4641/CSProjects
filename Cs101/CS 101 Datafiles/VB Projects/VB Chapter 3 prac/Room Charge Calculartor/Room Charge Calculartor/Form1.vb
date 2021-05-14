Option Strict Off

'************************************************************************************************
' Name: Jose Martinez Perez.
' Purpose: Calculate room Charges, Taxes and total charges.
' Input: Night stayed, nightly charge, room sevice charges, telephone charges, and Misc charges.
' Processing: Multipy nights by nightly charge to get the rooom charges.
'             Add the room service, telephone, and Misc charges to get the Additional Charges.
'             Add the Room Charges to the Additional Charges to get the Subtotal.
'             Multiply the subtotal by the TAx-Rate to get the Tax.
'             Add the Tax to the Subtotal to get the Total Charges
' Output: Display the charges, additional charges, subtotl, tax , and total charges.
'************************************************************************************************


Public Class Form1
    'Global Constant
    Const dblTAX_RATE As Double = 0.08D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTodayDate.Text = Now.ToString("D")
        lblTodayTime.Text = Now.ToString("t")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Step 0 - Declare Variables(WE have ten variables)
        ' Syntax:
        '       Dim variableName as DataType.
        Dim intNights As Integer
        Dim dblNightlyCharge As Double
        Dim dblRoomSerice As Double
        Dim dblTelephone As Double
        Dim dblMisc As Double
        Dim dblRoomCharges As Double
        Dim dblAdditionalCharges As Double
        Dim dblSubtotal As Double
        Dim dblTax As Double
        Dim dblTotalCharges As Double

        Try 'For txtNigths
            txtNight.Clear()
        Catch ex As Exception

        End Try
        Try 'for txtNightly Charge

                Try ' for txtRoomService

                    Try 'txtTelephone
                        Try 'Misc

                        Catch ex As Exception
                            ' Step 1
                            ' Step 2
                            ' Step 3
                        End Try
                    End Try

                    'Step 1,2,3 must be in the try.
                    Try
            ' Step 1 - Get Input
            ' Syntax:
            '       InVariable = CInt(txtControl.Text)
            '       dblVAriable=CDbl(txtControl.Text)
            ' intNights = txtNight.Text                   ' Incorrect
            ' dblNightlyCharge = txtNightlyCharges.Text   ' Incorrect
            lblTodayDate.Text = CInt(txtNights.Text)
            lblNightlyCharge = CDbl(txtNightlyCharges.Text)
            dblRoomSerice = CDbl(txtRoomServise.Text)
            dblTelephone = CDbl(txtTelephone.Text)
            dblMisc = CDbl(txtMisc.Text)


            ' Step 2 - Processing
            ' Syntax:
            '     Variables=expression


            dblRoomCharges = dblNigths * dblNightlyCharge
            dblAdditionalCharges = dblRoomSerice + dblTelephone = dblMisc
            dblSubtotal = dblRoomCharges + dblAdditionalCharges
            dblTax = dblSubtotal * dblTAX_RATE
            dblTotalCharges = dblSubtotal + dblTax

            ' Step 3 - Display Output
            ' Syntax:
            '       lblControl.Text=numVariable.ToString()
            '       lblContro.Text= numVariable.ToString("C")
            '         lblControl.Text=numVariable.ToString("N")
            '   lblControl.Text = numVariable.ToString("N")
            '   lblControl.Text = numVariable.ToString("p")
            '   lblControl.Text = numVariable.ToString("F")
            '   lblControl.Text = numVariable.ToString()
            'lblControl.Text = numVariable.ToString()
            'lblControl.Text = numVariable.ToString()
            lblRoomCharges.Text = dblRoomCharges.ToString("C")
            lblAdditionaCharges.Text = dblAdditionalCharges.ToString("C")
            lblSubtotal.Text = dblSubtotal.ToString("C")
            lblTax.Text = dblTax.ToString("C")
            lblTotalCharges = dblTotalCharges.ToString("C")

        Catch ex As Exception
            Message.Show("numeber only!")
        End Try
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear TextBoxes
        txtNights.Clear()
        txtNightlyCharge.Clear
        txtRoomService.clear()
        txtTelephone
        '  Clear labels
        lblRoomCharges.Text = ""
        lblAdditionalCharges = ""
        lblSubtotal.Text = ""
        lblTax
        lblTotalCharges.Text = CByte

        'Update Date  & Time
        lblTodayDate.Text = Now.ToString("D")
        lblTodayTime.Text = Now.ToString("t")
    End Sub
End Class

End Class
