Public Class Form1
    'Declare Class-Level Variables. Used by all procedures (class Level Variables) it is not recommended
    Dim dblTotal As Double = 0.0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub pc5Cent_Click(sender As Object, e As EventArgs) Handles pc5Cent.Click
        'Here is local Class Variable
        'Dim dblTotal As Double(if you declare a local level is going to overshadow the global level variable)
        'As a rule we do not recommend global level, Funcation are good instead of Global Variables

        'Input
        '   None

        'Processing
        dblTotal = dblTotal + 0.05

        'Output
        lblTotal.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub pc10Cent_Click(sender As Object, e As EventArgs) Handles pc10Cent.Click
        'Input
        '   None

        'Processing
        dblTotal = dblTotal + 0.1

        'Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub pc25Cent_Click(sender As Object, e As EventArgs) Handles pc25Cent.Click
        'Input
        '   None

        'Processing
        dblTotal = dblTotal + 0.25
        'Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub pic50Cent_Click(sender As Object, e As EventArgs) Handles pic50Cent.Click
        'Input
        '   None

        'Processing
        dblTotal = dblTotal + 0.5
        'Output
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
