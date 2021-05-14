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
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.lstYears = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMonths
        '
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.ItemHeight = 20
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September ", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(22, 43)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(226, 144)
        Me.lstMonths.TabIndex = 0
        '
        'lstYears
        '
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.ItemHeight = 20
        Me.lstYears.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2022"})
        Me.lstYears.Location = New System.Drawing.Point(269, 43)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(226, 144)
        Me.lstYears.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(134, 226)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(114, 39)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(260, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 39)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 284)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(524, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 306)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lstYears)
        Me.Controls.Add(Me.lstMonths)
        Me.Name = "Form1"
        Me.Text = "String Collection Editor"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMonths As ListBox
    Friend WithEvents lstYears As ListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
