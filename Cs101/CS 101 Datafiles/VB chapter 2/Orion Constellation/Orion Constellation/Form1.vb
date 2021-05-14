'********************************************************************************************************************************************************************************
'Name:Jose Martinez Perez
'Date:10/29/2020
'Purpose: To Show/Hide the star names.
'Input:  None
'Process: Change the Visible Property of Label Controls to False to hide star names at the beginning. Assign True for visible or False for invisible to each lblStarName, Label.
'Output: Star Names are shown or hiden on the Orion Image in a PictureBox.
'********************************************************************************************************************************************************************************
Public Class Form1
    Private Sub btnShowStar_Click(sender As Object, e As EventArgs) Handles btnShowStar.Click
        ' True Makes stars Visible
        lblBetelgeuse.Visible = True
        lblMeissa.Visible = True
        lblAlnitak.Visible = True
        lblAlnilam.Visible = True
        lblMintaka.Visible = True
        lblSaiph.Visible = True
        lblRigel.Visible = True
    End Sub

    Private Sub btnHideStar_Click(sender As Object, e As EventArgs) Handles btnHideStar.Click
        'False Makes Stars Invisible
        lblBetelgeuse.Visible = False
        lblMeissa.Visible = False
        lblAlnitak.Visible = False
        lblAlnilam.Visible = False
        lblMintaka.Visible = False
        lblSaiph.Visible = False
        lblRigel.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Closes the Application when Exit Button is clicked.
        Me.Close()
    End Sub
End Class
