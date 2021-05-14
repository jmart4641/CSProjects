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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumbeOne = New System.Windows.Forms.TextBox()
        Me.txtNumberTwo = New System.Windows.Forms.TextBox()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "+"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(298, 86)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(18, 20)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "="
        '
        'txtNumbeOne
        '
        Me.txtNumbeOne.Location = New System.Drawing.Point(38, 83)
        Me.txtNumbeOne.Name = "txtNumbeOne"
        Me.txtNumbeOne.Size = New System.Drawing.Size(100, 26)
        Me.txtNumbeOne.TabIndex = 5
        '
        'txtNumberTwo
        '
        Me.txtNumberTwo.Location = New System.Drawing.Point(168, 83)
        Me.txtNumberTwo.Name = "txtNumberTwo"
        Me.txtNumberTwo.Size = New System.Drawing.Size(100, 26)
        Me.txtNumberTwo.TabIndex = 6
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(38, 146)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(100, 59)
        Me.btnShowAnswer.TabIndex = 7
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 217)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.txtNumberTwo)
        Me.Controls.Add(Me.txtNumbeOne)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Math Tutor Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumbeOne As TextBox
    Friend WithEvents txtNumberTwo As TextBox
    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents Button2 As Button
End Class
