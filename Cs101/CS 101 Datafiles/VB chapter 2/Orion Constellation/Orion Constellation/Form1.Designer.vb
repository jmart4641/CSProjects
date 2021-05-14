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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnShowStar = New System.Windows.Forms.Button()
        Me.btnHideStar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblBetelgeuse = New System.Windows.Forms.Label()
        Me.lblAlnitak = New System.Windows.Forms.Label()
        Me.lblSaiph = New System.Windows.Forms.Label()
        Me.lblAlnilam = New System.Windows.Forms.Label()
        Me.lblMintaka = New System.Windows.Forms.Label()
        Me.lblMeissa = New System.Windows.Forms.Label()
        Me.lblRigel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Orion_Constellation.My.Resources.Resources.Orion
        Me.PictureBox1.Location = New System.Drawing.Point(-12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 497)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnShowStar
        '
        Me.btnShowStar.Location = New System.Drawing.Point(34, 512)
        Me.btnShowStar.Name = "btnShowStar"
        Me.btnShowStar.Size = New System.Drawing.Size(94, 55)
        Me.btnShowStar.TabIndex = 1
        Me.btnShowStar.Text = "Show Star Names"
        Me.btnShowStar.UseVisualStyleBackColor = True
        '
        'btnHideStar
        '
        Me.btnHideStar.Location = New System.Drawing.Point(165, 512)
        Me.btnHideStar.Name = "btnHideStar"
        Me.btnHideStar.Size = New System.Drawing.Size(94, 55)
        Me.btnHideStar.TabIndex = 2
        Me.btnHideStar.Text = "Hide Star Names"
        Me.btnHideStar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(297, 523)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblBetelgeuse
        '
        Me.lblBetelgeuse.AutoSize = True
        Me.lblBetelgeuse.Location = New System.Drawing.Point(30, 26)
        Me.lblBetelgeuse.Name = "lblBetelgeuse"
        Me.lblBetelgeuse.Size = New System.Drawing.Size(90, 20)
        Me.lblBetelgeuse.TabIndex = 4
        Me.lblBetelgeuse.Text = "Betelgeuse"
        Me.lblBetelgeuse.Visible = False
        '
        'lblAlnitak
        '
        Me.lblAlnitak.AutoSize = True
        Me.lblAlnitak.Location = New System.Drawing.Point(56, 242)
        Me.lblAlnitak.Name = "lblAlnitak"
        Me.lblAlnitak.Size = New System.Drawing.Size(57, 20)
        Me.lblAlnitak.TabIndex = 5
        Me.lblAlnitak.Text = "Alnitak"
        Me.lblAlnitak.Visible = False
        '
        'lblSaiph
        '
        Me.lblSaiph.AutoSize = True
        Me.lblSaiph.Location = New System.Drawing.Point(56, 387)
        Me.lblSaiph.Name = "lblSaiph"
        Me.lblSaiph.Size = New System.Drawing.Size(50, 20)
        Me.lblSaiph.TabIndex = 6
        Me.lblSaiph.Text = "Saiph"
        Me.lblSaiph.Visible = False
        '
        'lblAlnilam
        '
        Me.lblAlnilam.AutoSize = True
        Me.lblAlnilam.Location = New System.Drawing.Point(150, 254)
        Me.lblAlnilam.Name = "lblAlnilam"
        Me.lblAlnilam.Size = New System.Drawing.Size(60, 20)
        Me.lblAlnilam.TabIndex = 7
        Me.lblAlnilam.Text = "Alnilam"
        Me.lblAlnilam.Visible = False
        '
        'lblMintaka
        '
        Me.lblMintaka.AutoSize = True
        Me.lblMintaka.Location = New System.Drawing.Point(242, 207)
        Me.lblMintaka.Name = "lblMintaka"
        Me.lblMintaka.Size = New System.Drawing.Size(65, 20)
        Me.lblMintaka.TabIndex = 8
        Me.lblMintaka.Text = "Mintaka"
        Me.lblMintaka.Visible = False
        '
        'lblMeissa
        '
        Me.lblMeissa.AutoSize = True
        Me.lblMeissa.Location = New System.Drawing.Point(268, 54)
        Me.lblMeissa.Name = "lblMeissa"
        Me.lblMeissa.Size = New System.Drawing.Size(59, 20)
        Me.lblMeissa.TabIndex = 9
        Me.lblMeissa.Text = "Meissa"
        Me.lblMeissa.Visible = False
        '
        'lblRigel
        '
        Me.lblRigel.AutoSize = True
        Me.lblRigel.Location = New System.Drawing.Point(271, 387)
        Me.lblRigel.Name = "lblRigel"
        Me.lblRigel.Size = New System.Drawing.Size(45, 20)
        Me.lblRigel.TabIndex = 10
        Me.lblRigel.Text = "Rigel"
        Me.lblRigel.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 578)
        Me.Controls.Add(Me.lblRigel)
        Me.Controls.Add(Me.lblMeissa)
        Me.Controls.Add(Me.lblMintaka)
        Me.Controls.Add(Me.lblAlnilam)
        Me.Controls.Add(Me.lblSaiph)
        Me.Controls.Add(Me.lblAlnitak)
        Me.Controls.Add(Me.lblBetelgeuse)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnHideStar)
        Me.Controls.Add(Me.btnShowStar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Orion Constellation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowStar As Button
    Friend WithEvents btnHideStar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblBetelgeuse As Label
    Friend WithEvents lblAlnitak As Label
    Friend WithEvents lblSaiph As Label
    Friend WithEvents lblAlnilam As Label
    Friend WithEvents lblMintaka As Label
    Friend WithEvents lblMeissa As Label
    Friend WithEvents lblRigel As Label
End Class
