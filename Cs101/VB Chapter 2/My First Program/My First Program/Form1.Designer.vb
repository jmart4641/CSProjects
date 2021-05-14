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
        Me.btnDisplayMessage = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDisplayMessage
        '
        Me.btnDisplayMessage.Location = New System.Drawing.Point(124, 102)
        Me.btnDisplayMessage.Name = "btnDisplayMessage"
        Me.btnDisplayMessage.Size = New System.Drawing.Size(124, 74)
        Me.btnDisplayMessage.TabIndex = 0
        Me.btnDisplayMessage.Text = "Display Message"
        Me.btnDisplayMessage.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(129, 43)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(119, 20)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Click the button"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 199)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnDisplayMessage)
        Me.Name = "Form1"
        Me.Text = "My First Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayMessage As Button
    Friend WithEvents lblMessage As Label
End Class
