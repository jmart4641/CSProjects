'*************************************************************************************************************************************
'Name:Jose Martinez Perez
'Date 10/29/2020
'Purpose: To Display the name of each card in LblCardAwnswer, a Label Control.
'Input: None
'Process: Assign "Eigh of Diamonds","Two of Clubs","King Spades","Ace Spades", or "Joker Black" to the text property of lblCardAnswer.
'Output: The name of each card is displayed in the lblCardAnswer, Label control. For the Exit Button, it will close the application.
'*************************************************************************************************************************************
Public Class Form1
    Private Sub picDiamonds_Click(sender As Object, e As EventArgs) Handles picDiamonds.Click
        'Name of Card assigned, it will be display in the Label control when PictureBox Label is clicked.
        lblCardAnswer.Text = "Eight of Diamonds"

    End Sub

    Private Sub picClub_Click(sender As Object, e As EventArgs) Handles picClub.Click
        'Name Two of Clubs will be displayed in the label control when the grapical Image is clicked.
        lblCardAnswer.Text = "Two of Clubs"
    End Sub

    Private Sub picKingSpades_Click(sender As Object, e As EventArgs) Handles picKingSpades.Click
        'Name King Spades is Assigned to lblCardAnswer, it will be displayed in the label when the graphical Image is clicked.
        lblCardAnswer.Text = "King Spades"
    End Sub

    Private Sub picAceSpades_Click(sender As Object, e As EventArgs) Handles picAceSpades.Click
        'Name Ace Spades is Assigned to lblCardAnswer
        lblCardAnswer.Text = "Ace Spades"
    End Sub

    Private Sub picJokerBlack_Click(sender As Object, e As EventArgs) Handles picJokerBlack.Click
        'Name Joker Black is Assigned to lblCardAnswer
        lblCardAnswer.Text = "Joker Black"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
