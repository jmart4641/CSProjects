<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCardAnswer = New System.Windows.Forms.Label()
        Me.picAceSpades = New System.Windows.Forms.PictureBox()
        Me.picJokerBlack = New System.Windows.Forms.PictureBox()
        Me.picKingSpades = New System.Windows.Forms.PictureBox()
        Me.picClub = New System.Windows.Forms.PictureBox()
        Me.picDiamonds = New System.Windows.Forms.PictureBox()
        CType(Me.picAceSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJokerBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiamonds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Click A Card to See Its Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCardAnswer
        '
        Me.lblCardAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCardAnswer.Location = New System.Drawing.Point(13, 270)
        Me.lblCardAnswer.Name = "lblCardAnswer"
        Me.lblCardAnswer.Size = New System.Drawing.Size(594, 29)
        Me.lblCardAnswer.TabIndex = 7
        Me.lblCardAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picAceSpades
        '
        Me.picAceSpades.Image = Global.Card_Identifier.My.Resources.Resources.Ace_Spades
        Me.picAceSpades.Location = New System.Drawing.Point(382, 101)
        Me.picAceSpades.Name = "picAceSpades"
        Me.picAceSpades.Size = New System.Drawing.Size(100, 140)
        Me.picAceSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAceSpades.TabIndex = 8
        Me.picAceSpades.TabStop = False
        '
        'picJokerBlack
        '
        Me.picJokerBlack.Image = Global.Card_Identifier.My.Resources.Resources.Joker_Black
        Me.picJokerBlack.Location = New System.Drawing.Point(507, 100)
        Me.picJokerBlack.Name = "picJokerBlack"
        Me.picJokerBlack.Size = New System.Drawing.Size(100, 140)
        Me.picJokerBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJokerBlack.TabIndex = 4
        Me.picJokerBlack.TabStop = False
        '
        'picKingSpades
        '
        Me.picKingSpades.Image = Global.Card_Identifier.My.Resources.Resources.King_Spades
        Me.picKingSpades.Location = New System.Drawing.Point(263, 100)
        Me.picKingSpades.Name = "picKingSpades"
        Me.picKingSpades.Size = New System.Drawing.Size(100, 140)
        Me.picKingSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKingSpades.TabIndex = 3
        Me.picKingSpades.TabStop = False
        '
        'picClub
        '
        Me.picClub.Image = Global.Card_Identifier.My.Resources.Resources._2_Clubs
        Me.picClub.Location = New System.Drawing.Point(142, 101)
        Me.picClub.Name = "picClub"
        Me.picClub.Size = New System.Drawing.Size(100, 140)
        Me.picClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClub.TabIndex = 1
        Me.picClub.TabStop = False
        '
        'picDiamonds
        '
        Me.picDiamonds.Image = Global.Card_Identifier.My.Resources.Resources._8_Diamonds
        Me.picDiamonds.Location = New System.Drawing.Point(13, 100)
        Me.picDiamonds.Name = "picDiamonds"
        Me.picDiamonds.Size = New System.Drawing.Size(100, 140)
        Me.picDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDiamonds.TabIndex = 0
        Me.picDiamonds.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 352)
        Me.Controls.Add(Me.picAceSpades)
        Me.Controls.Add(Me.lblCardAnswer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picJokerBlack)
        Me.Controls.Add(Me.picKingSpades)
        Me.Controls.Add(Me.picClub)
        Me.Controls.Add(Me.picDiamonds)
        Me.Name = "Form1"
        Me.Text = "Card Identifier"
        CType(Me.picAceSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJokerBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiamonds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDiamonds As PictureBox
    Friend WithEvents picClub As PictureBox
    Friend WithEvents picKingSpades As PictureBox
    Friend WithEvents picJokerBlack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCardAnswer As Label
    Friend WithEvents picAceSpades As PictureBox
End Class
