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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Name"
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.Location = New System.Drawing.Point(12, 171)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(329, 27)
        Me.lblGreeting.TabIndex = 1
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Location = New System.Drawing.Point(58, 234)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(89, 62)
        Me.btnShowGreeting.TabIndex = 2
        Me.btnShowGreeting.Text = "Show Greeting"
        Me.btnShowGreeting.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(201, 234)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 62)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(33, 117)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(285, 26)
        Me.txtUserName.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 347)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowGreeting)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnShowGreeting As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUserName As TextBox
End Class
