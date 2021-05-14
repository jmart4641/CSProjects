' Name: Jose R. Martinez Perez
' Date: 11/12/2020
' Purpose: To calculate (add)the total points for each boat. The result will be displayed in the designated lblBoatTotal label. 
' Input: Scores of each boat for four races. Users input the finishing position for each of three boats for 4 races. 
'        Input Race 1, 2, 3, And 4  For boat # 1,2,3.
' Processing: Add Race 1 throught Race 4 to get the the total scoring for each Boat.
'             The results will be displayed in the lblBoat#Total label assigned For Each boat.
' Output: Display the total Scoring points for each boat. Results are displayed in the in the total column.
Public Class Form1
    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        ' Declared the variables
        Dim intBt1R1 As Integer
        Dim intBt1R2 As Integer
        Dim intBt1R3 As Integer
        Dim intBt1R4 As Integer
        Dim intB1Total As Integer

        Dim intBt2R1 As Integer
        Dim intBt2R2 As Integer
        Dim intBt2R3 As Integer
        Dim intBt2R4 As Integer
        Dim intB2Total As Integer

        Dim intBt3R1 As Integer
        Dim intBt3R2 As Integer
        Dim intBt3R3 As Integer
        Dim intBt3R4 As Integer
        Dim IntB3Total As Integer
        Dim blnInputOkay As Boolean = False


        Try

            lblStatusError.Text = String.Empty

            ' Convert Values into integers
            intBt1R1 = CInt(txtBoat1R1.Text)
            intBt1R2 = CInt(txtBoat1R2.Text)
            intBt1R3 = CInt(txtBoat1R3.Text)
            intBt1R4 = CInt(txtBoat1R4.Text)

            intBt2R1 = CInt(txtBoat2R1.Text)
            intBt2R2 = CInt(txtBoat2R2.Text)
            intBt2R3 = CInt(txtBoat2R3.Text)
            intBt2R4 = CInt(txtBoat2R4.Text)

            intBt3R1 = CInt(txtBoat3R1.Text)
            intBt3R2 = CInt(txtBoat3R2.Text)
            intBt3R3 = CInt(txtBoat3R3.Text)
            intBt3R4 = CInt(txtBoat3R4.Text)





            If intBt1R1 + intBt2R1 + intBt3R1 <> 6 Then
                lblStatusError.Text = "Enter 1, 2, And 3 only for Race 1."
                blnInputOkay = False
            End If

            If intBt1R2 + intBt2R2 + intBt3R2 <> 6 Then
                lblStatusError.Text = "Enter 1, 2 and 3 only for Race 2"
                blnInputOkay = False
            End If

            If intBt1R3 + intBt2R3 + intBt3R3 <> 6 Then
                lblStatusError.Text = "Enter 1, 2 and 3 only for Race 3."
                blnInputOkay = False
            End If

            If intBt1R4 + intBt2R4 + intBt3R4 <> 6 Then
                lblStatusError.Text = "Enter 1, 2, and 3 only for Race 2"
                blnInputOkay = False
            End If

            If blnInputOkay = True Then
                intB1Total = intBt1R1 + intBt1R2 + intBt1R3 + intBt1R4
                intB2Total = intBt2R1 + intBt2R2 + intBt2R3 + intBt2R4
                IntB3Total = intBt3R1 + intBt3R2 + intBt3R3 + intBt3R4
            End If

            'Determine the ranking
            If intB1Total > intB2Total Then
                'Here B1 is less than B2.
                If intB2Total < IntB3Total Then
                    ' Now B1 is less than B2 is less than B3.
                    lblRank1.Text = "1"
                    lblRank2.Text = "2"
                    lblRank3.Text = "3"

                Else
                    If intB1Total > IntB3Total Then
                        If IntB3Total > intB2Total Then

                            lblRank1.Text = "1"
                            lblRank2.Text = "3"
                            lblRank3.Text = "2"

                        End If
                    End If
                End If
            End If


            If intB2Total > intB1Total Then
                If intB1Total > IntB3Total Then
                    'If B2 is greater than B1 and B1 is greater than B3 then
                    lblRank1.Text = "2"
                    lblRank2.Text = "1"
                    lblRank3.Text = "3"

                Else
                    lblRank1.Text = "3"
                    lblRank2.Text = "2"
                    lblRank3.Text = "1"
                End If
            End If

            If intB2Total > IntB3Total Then
                If IntB3Total > intB1Total Then

                    lblRank1.Text = "3"
                    lblRank2.Text = "1"
                    lblRank3.Text = "2"
                Else
                    lblRank1.Text = "3"
                    lblRank2.Text = "2"
                    lblRank3.Text = "1"
                End If


            End If

            lblStatusError.Text = "TIE"
                    lblRank1.BackColor = Color.Red
                    lblRank2.BackColor = Color.Red
                    lblRank3.BackColor = Color.Red



            lblBoat1Total.Text = intB1Total.ToString("")
                lblBoat2Total.Text = intB2Total.ToString()
                lblBoat3Total.Text = IntB3Total.ToString()



        Catch
            MessageBox.Show("Input Integers")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes
        txtBoat1R1.Clear()
        txtBoat1R2.Clear()
        txtBoat1R3.Clear()
        txtBoat1R4.Clear()

        'clear textBoxes for boat 2.
        txtBoat2R1.Clear()
        txtBoat2R2.Clear()
        txtBoat2R3.Clear()
        txtBoat2R4.Clear()

        ' Clear textboxes for boat 3
        txtBoat3R1.Clear()
        txtBoat3R2.Clear()
        txtBoat3R3.Clear()
        txtBoat3R4.Clear()

        ' Clear labels for total Boat 1, 2, and 3.
        lblBoat1Total.Text = String.Empty
        lblBoat2Total.Text = String.Empty
        lblBoat3Total.Text = String.Empty

        ' Clear Ranks
        lblRank1.Text = String.Empty
        lblRank2.Text = String.Empty
        lblRank3.Text = String.Empty

        ' Clear background
        lblRank1.BackColor = Color.Empty
        lblRank2.BackColor = Color.Empty
        lblRank3.BackColor = Color.Empty


    End Sub
End Class