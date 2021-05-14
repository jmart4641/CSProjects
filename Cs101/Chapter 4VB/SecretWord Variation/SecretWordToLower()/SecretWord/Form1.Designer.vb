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
        Me.btnDisplayString = New System.Windows.Forms.Button()
        Me.txtInputSecretWord = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the secret word:"
        '
        'btnDisplayString
        '
        Me.btnDisplayString.Location = New System.Drawing.Point(102, 135)
        Me.btnDisplayString.Name = "btnDisplayString"
        Me.btnDisplayString.Size = New System.Drawing.Size(92, 31)
        Me.btnDisplayString.TabIndex = 1
        Me.btnDisplayString.Text = "Ok"
        Me.btnDisplayString.UseVisualStyleBackColor = True
        '
        'txtInputSecretWord
        '
        Me.txtInputSecretWord.Location = New System.Drawing.Point(210, 40)
        Me.txtInputSecretWord.Name = "txtInputSecretWord"
        Me.txtInputSecretWord.Size = New System.Drawing.Size(132, 26)
        Me.txtInputSecretWord.TabIndex = 2
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(44, 84)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(298, 35)
        Me.lblMessage.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 187)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtInputSecretWord)
        Me.Controls.Add(Me.btnDisplayString)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Secret Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplayString As Button
    Friend WithEvents txtInputSecretWord As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnExit As Button
End Class
