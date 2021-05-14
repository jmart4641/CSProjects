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
        Me.btnShowBack = New System.Windows.Forms.Button()
        Me.btnShowFace = New System.Windows.Forms.Button()
        Me.picCardFace = New System.Windows.Forms.PictureBox()
        Me.picCardBack = New System.Windows.Forms.PictureBox()
        CType(Me.picCardFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowBack
        '
        Me.btnShowBack.Location = New System.Drawing.Point(54, 199)
        Me.btnShowBack.Name = "btnShowBack"
        Me.btnShowBack.Size = New System.Drawing.Size(93, 60)
        Me.btnShowBack.TabIndex = 0
        Me.btnShowBack.Text = "Show the Card Back"
        Me.btnShowBack.UseVisualStyleBackColor = True
        '
        'btnShowFace
        '
        Me.btnShowFace.Location = New System.Drawing.Point(175, 199)
        Me.btnShowFace.Name = "btnShowFace"
        Me.btnShowFace.Size = New System.Drawing.Size(100, 60)
        Me.btnShowFace.TabIndex = 1
        Me.btnShowFace.Text = "Show the Card Face"
        Me.btnShowFace.UseVisualStyleBackColor = True
        '
        'picCardFace
        '
        Me.picCardFace.Image = Global.Card_Flip.My.Resources.Resources.Ace_Spades
        Me.picCardFace.Location = New System.Drawing.Point(175, 35)
        Me.picCardFace.Name = "picCardFace"
        Me.picCardFace.Size = New System.Drawing.Size(100, 140)
        Me.picCardFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCardFace.TabIndex = 3
        Me.picCardFace.TabStop = False
        Me.picCardFace.Visible = False
        '
        'picCardBack
        '
        Me.picCardBack.Image = Global.Card_Flip.My.Resources.Resources.Backface_Blue
        Me.picCardBack.Location = New System.Drawing.Point(47, 35)
        Me.picCardBack.Name = "picCardBack"
        Me.picCardBack.Size = New System.Drawing.Size(100, 140)
        Me.picCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCardBack.TabIndex = 2
        Me.picCardBack.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 271)
        Me.Controls.Add(Me.picCardFace)
        Me.Controls.Add(Me.picCardBack)
        Me.Controls.Add(Me.btnShowFace)
        Me.Controls.Add(Me.btnShowBack)
        Me.Name = "Form1"
        Me.Text = "Card Flip"
        CType(Me.picCardFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowBack As Button
    Friend WithEvents btnShowFace As Button
    Friend WithEvents picCardBack As PictureBox
    Friend WithEvents picCardFace As PictureBox
End Class
