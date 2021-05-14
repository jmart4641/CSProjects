<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.lblMathResult = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShowAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(68, 120)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(122, 31)
        Me.btnShowAnswer.TabIndex = 0
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'lblMathResult
        '
        Me.lblMathResult.AutoSize = True
        Me.lblMathResult.Location = New System.Drawing.Point(170, 97)
        Me.lblMathResult.Name = "lblMathResult"
        Me.lblMathResult.Size = New System.Drawing.Size(0, 20)
        Me.lblMathResult.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "18 + 64 ="
        '
        'lblShowAnswer
        '
        Me.lblShowAnswer.AutoSize = True
        Me.lblShowAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowAnswer.Location = New System.Drawing.Point(227, 68)
        Me.lblShowAnswer.Name = "lblShowAnswer"
        Me.lblShowAnswer.Size = New System.Drawing.Size(41, 29)
        Me.lblShowAnswer.TabIndex = 5
        Me.lblShowAnswer.Text = "82"
        Me.lblShowAnswer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 189)
        Me.Controls.Add(Me.lblShowAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblMathResult)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Name = "Form1"
        Me.Text = "Math Turtor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowAnswer As Button
    Friend WithEvents lblMathResult As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShowAnswer As Label
End Class
