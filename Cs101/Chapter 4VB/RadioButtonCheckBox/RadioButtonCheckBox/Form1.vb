Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Dim srtOutput As String  can be declare.

        'Clears status bar.
        lblResult.Text = ""

        ' Determine which radio button is selected.
        ' Process radio buttons. Mutually exclusive.
        If radCoffee.Checked = True Then                ' No need to say True, you could write it as If (radCoffee.Checked) Then
            lblResult.Text = "You have selected coffee"  ' strOuput="Tea" coould be used too
        ElseIf radTea.Checked = True Then
            lblResult.Text = "You have selected Tea"
        ElseIf radSoftDrink.Checked = True Then
            lblResult.Text = "You have selected Soft Drink"
        End If

        ' Determine which Check boxes are selected.
        ' Process checkboxes
        ' Check boxes are not mutually exclusive.
        If chkWhippedCream.Checked = True Then
            lblResult.Text &= ", and Whipped Cream"     ' Here a concatenation happens using ampersAnd and str could used instead lblResult.
        End If

        If chkMocha.Checked = True Then
            lblResult.Text &= ", and Mocha"
        End If

        If chkAmarreto.Checked = True Then
            lblResult.Text &= ", and Amarretto"
        End If

        ' Display Output
        ' if Dim str is used you can have the output here.
        ' lblResult.Text =strOutput
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()

    End Sub
End Class
