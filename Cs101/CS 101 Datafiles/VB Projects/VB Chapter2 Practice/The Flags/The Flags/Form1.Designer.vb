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
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.picGermany = New System.Windows.Forms.PictureBox()
        Me.picFrance = New System.Windows.Forms.PictureBox()
        Me.picFinland = New System.Windows.Forms.PictureBox()
        CType(Me.picGermany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFinland, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a flag to see the name of the country"
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(70, 128)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(266, 31)
        Me.lblCountry.TabIndex = 4
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picGermany
        '
        Me.picGermany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGermany.Image = Global.The_Flags.My.Resources.Resources.Germany
        Me.picGermany.Location = New System.Drawing.Point(289, 41)
        Me.picGermany.Name = "picGermany"
        Me.picGermany.Size = New System.Drawing.Size(120, 70)
        Me.picGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGermany.TabIndex = 3
        Me.picGermany.TabStop = False
        '
        'picFrance
        '
        Me.picFrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFrance.Image = Global.The_Flags.My.Resources.Resources.France
        Me.picFrance.Location = New System.Drawing.Point(149, 41)
        Me.picFrance.Name = "picFrance"
        Me.picFrance.Size = New System.Drawing.Size(120, 70)
        Me.picFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFrance.TabIndex = 2
        Me.picFrance.TabStop = False
        '
        'picFinland
        '
        Me.picFinland.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFinland.Image = Global.The_Flags.My.Resources.Resources.Finland
        Me.picFinland.Location = New System.Drawing.Point(12, 41)
        Me.picFinland.Name = "picFinland"
        Me.picFinland.Size = New System.Drawing.Size(120, 70)
        Me.picFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFinland.TabIndex = 1
        Me.picFinland.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 168)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.picGermany)
        Me.Controls.Add(Me.picFrance)
        Me.Controls.Add(Me.picFinland)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Flags"
        CType(Me.picGermany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFinland, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picFinland As PictureBox
    Friend WithEvents picFrance As PictureBox
    Friend WithEvents picGermany As PictureBox
    Friend WithEvents lblCountry As Label
End Class
