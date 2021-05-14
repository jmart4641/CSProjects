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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatusError = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdvCostPerWeek = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRevenue1 = New System.Windows.Forms.Label()
        Me.lblRevenue2 = New System.Windows.Forms.Label()
        Me.lblRevenue3 = New System.Windows.Forms.Label()
        Me.lblRevenue4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumAdsClick2 = New System.Windows.Forms.TextBox()
        Me.txtNumAdsCLick3 = New System.Windows.Forms.TextBox()
        Me.txtNumAdsClick4 = New System.Windows.Forms.TextBox()
        Me.txtNumAdsClick1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusError})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(595, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatusError
        '
        Me.lblStatusError.Name = "lblStatusError"
        Me.lblStatusError.Size = New System.Drawing.Size(0, 15)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Advertising cost per week:"
        '
        'txtAdvCostPerWeek
        '
        Me.txtAdvCostPerWeek.Location = New System.Drawing.Point(262, 121)
        Me.txtAdvCostPerWeek.Name = "txtAdvCostPerWeek"
        Me.txtAdvCostPerWeek.Size = New System.Drawing.Size(106, 26)
        Me.txtAdvCostPerWeek.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 31)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 31)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(403, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 31)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(49, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 10)
        Me.Label2.TabIndex = 3
        '
        'lblRevenue1
        '
        Me.lblRevenue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue1.Location = New System.Drawing.Point(373, 263)
        Me.lblRevenue1.Name = "lblRevenue1"
        Me.lblRevenue1.Size = New System.Drawing.Size(100, 30)
        Me.lblRevenue1.TabIndex = 14
        Me.lblRevenue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue2
        '
        Me.lblRevenue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue2.Location = New System.Drawing.Point(373, 303)
        Me.lblRevenue2.Name = "lblRevenue2"
        Me.lblRevenue2.Size = New System.Drawing.Size(100, 30)
        Me.lblRevenue2.TabIndex = 15
        Me.lblRevenue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue3
        '
        Me.lblRevenue3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue3.Location = New System.Drawing.Point(373, 350)
        Me.lblRevenue3.Name = "lblRevenue3"
        Me.lblRevenue3.Size = New System.Drawing.Size(100, 30)
        Me.lblRevenue3.TabIndex = 16
        Me.lblRevenue3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue4
        '
        Me.lblRevenue4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue4.Location = New System.Drawing.Point(373, 398)
        Me.lblRevenue4.Name = "lblRevenue4"
        Me.lblRevenue4.Size = New System.Drawing.Size(100, 30)
        Me.lblRevenue4.TabIndex = 17
        Me.lblRevenue4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(45, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 80)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Number of Ad Clicks during the past 4 weekly periods"
        '
        'txtNumAdsClick2
        '
        Me.txtNumAdsClick2.Location = New System.Drawing.Point(251, 307)
        Me.txtNumAdsClick2.Name = "txtNumAdsClick2"
        Me.txtNumAdsClick2.Size = New System.Drawing.Size(100, 26)
        Me.txtNumAdsClick2.TabIndex = 10
        Me.txtNumAdsClick2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumAdsCLick3
        '
        Me.txtNumAdsCLick3.Location = New System.Drawing.Point(251, 354)
        Me.txtNumAdsCLick3.Name = "txtNumAdsCLick3"
        Me.txtNumAdsCLick3.Size = New System.Drawing.Size(100, 26)
        Me.txtNumAdsCLick3.TabIndex = 11
        Me.txtNumAdsCLick3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumAdsClick4
        '
        Me.txtNumAdsClick4.Location = New System.Drawing.Point(251, 402)
        Me.txtNumAdsClick4.Name = "txtNumAdsClick4"
        Me.txtNumAdsClick4.Size = New System.Drawing.Size(100, 26)
        Me.txtNumAdsClick4.TabIndex = 12
        Me.txtNumAdsClick4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumAdsClick1
        '
        Me.txtNumAdsClick1.Location = New System.Drawing.Point(251, 263)
        Me.txtNumAdsClick1.Name = "txtNumAdsClick1"
        Me.txtNumAdsClick1.Size = New System.Drawing.Size(100, 26)
        Me.txtNumAdsClick1.TabIndex = 9
        Me.txtNumAdsClick1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(373, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 29)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Revenue"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(45, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(481, 44)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "This application calculates the amount of advertising revenue paid to a Web site " &
    "that displays links to a selected vendor."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(220, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(220, 405)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 537)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNumAdsClick1)
        Me.Controls.Add(Me.txtNumAdsClick4)
        Me.Controls.Add(Me.txtNumAdsCLick3)
        Me.Controls.Add(Me.txtNumAdsClick2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRevenue4)
        Me.Controls.Add(Me.lblRevenue3)
        Me.Controls.Add(Me.lblRevenue2)
        Me.Controls.Add(Me.lblRevenue1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAdvCostPerWeek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdvCostPerWeek As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRevenue1 As Label
    Friend WithEvents lblRevenue2 As Label
    Friend WithEvents lblRevenue3 As Label
    Friend WithEvents lblRevenue4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumAdsClick2 As TextBox
    Friend WithEvents txtNumAdsCLick3 As TextBox
    Friend WithEvents txtNumAdsClick4 As TextBox
    Friend WithEvents txtNumAdsClick1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblStatusError As ToolStripStatusLabel
End Class
