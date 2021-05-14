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
        Me.cboCountries = New System.Windows.Forms.ComboBox()
        Me.CboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtists = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCountries
        '
        Me.cboCountries.FormattingEnabled = True
        Me.cboCountries.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountries.Location = New System.Drawing.Point(152, 43)
        Me.cboCountries.Name = "cboCountries"
        Me.cboCountries.Size = New System.Drawing.Size(121, 28)
        Me.cboCountries.Sorted = True
        Me.cboCountries.TabIndex = 0
        '
        'CboPlays
        '
        Me.CboPlays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboPlays.FormattingEnabled = True
        Me.CboPlays.Items.AddRange(New Object() {"A Comedy of Errors", "Hamlet", "Much Ado about Nothing", "Romeo and Juliet", "The Merchant of Venice"})
        Me.CboPlays.Location = New System.Drawing.Point(152, 95)
        Me.CboPlays.Name = "CboPlays"
        Me.CboPlays.Size = New System.Drawing.Size(121, 150)
        Me.CboPlays.Sorted = True
        Me.CboPlays.TabIndex = 1
        '
        'cboArtists
        '
        Me.cboArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtists.FormattingEnabled = True
        Me.cboArtists.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtists.Location = New System.Drawing.Point(152, 239)
        Me.cboArtists.Name = "cboArtists"
        Me.cboArtists.Size = New System.Drawing.Size(121, 28)
        Me.cboArtists.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a Country:"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(96, 329)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(121, 53)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "&Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Choose a Play:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Choose an Artist:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(237, 329)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(121, 53)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(375, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 53)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(16, 147)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(198, 27)
        Me.lblArtist.TabIndex = 9
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(16, 85)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(198, 27)
        Me.lblPlay.TabIndex = 10
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(16, 30)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(198, 27)
        Me.lblCountry.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Controls.Add(Me.lblPlay)
        Me.GroupBox1.Location = New System.Drawing.Point(293, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 224)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboArtists)
        Me.Controls.Add(Me.CboPlays)
        Me.Controls.Add(Me.cboCountries)
        Me.Name = "Form1"
        Me.Text = "Combo Boxes Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCountries As ComboBox
    Friend WithEvents CboPlays As ComboBox
    Friend WithEvents cboArtists As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblPlay As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
