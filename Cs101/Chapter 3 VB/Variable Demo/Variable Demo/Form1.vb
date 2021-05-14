Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        'Step 0 - Declare Variables
        'Declare a string variable to hold the full name.
        Dim strFullName As String
        Dim strLastName As String
        Dim strFirstName As String


        'Step 1 - Get the Input
        'Syntax:
        '      strVariable = txtControlName.Text
        '      intVariable = CInt(txtControlName.Text)

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text

        'Step 2 - Proccessing
        'Syntax:
        '      variable = expression
        'Combine the first and last names and assign the
        'result to strFullName.
        strFullName = txtFirstName.Text & " " & txtLastName.Text

        'Step 3 - Output
        '      Syntax:
        '       lblControlName.Text = numericVariable.ToString()
        '       lblControlName.Text = numericVariable.ToString("Cn")
        '       lblControlName.Text = nUmericVariable.ToString("Pn")
        'Display the full name in the lblFullTime label.

        lblFullName.Text = strFullName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBox controlsand the label
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Form
        Me.Close()
    End Sub
End Class
