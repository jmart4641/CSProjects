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
        Me.lstPWorkshop = New System.Windows.Forms.ListBox()
        Me.lstPLocation = New System.Windows.Forms.ListBox()
        Me.lstListCosts = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPWorkshop
        '
        Me.lstPWorkshop.FormattingEnabled = True
        Me.lstPWorkshop.ItemHeight = 20
        Me.lstPWorkshop.Items.AddRange(New Object() {"Handling Stress", "TIme Management", "Supervision Skills", "Negotiation", "How to Inteview"})
        Me.lstPWorkshop.Location = New System.Drawing.Point(6, 25)
        Me.lstPWorkshop.Name = "lstPWorkshop"
        Me.lstPWorkshop.Size = New System.Drawing.Size(254, 184)
        Me.lstPWorkshop.TabIndex = 0
        '
        'lstPLocation
        '
        Me.lstPLocation.FormattingEnabled = True
        Me.lstPLocation.ItemHeight = 20
        Me.lstPLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstPLocation.Location = New System.Drawing.Point(6, 25)
        Me.lstPLocation.Name = "lstPLocation"
        Me.lstPLocation.Size = New System.Drawing.Size(254, 184)
        Me.lstPLocation.TabIndex = 1
        '
        'lstListCosts
        '
        Me.lstListCosts.FormattingEnabled = True
        Me.lstListCosts.ItemHeight = 20
        Me.lstListCosts.Location = New System.Drawing.Point(6, 25)
        Me.lstListCosts.Name = "lstListCosts"
        Me.lstListCosts.Size = New System.Drawing.Size(254, 184)
        Me.lstListCosts.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstPWorkshop)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 218)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Workshop"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstPLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 218)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick a Location"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstListCosts)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 218)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Costs"
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(62, 314)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(144, 47)
        Me.btnAddWorkshop.TabIndex = 3
        Me.btnAddWorkshop.Text = "Add Worskshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(238, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 47)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(416, 314)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(144, 47)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(591, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 47)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(386, 250)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(145, 32)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(280, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 35)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total Cost:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 385)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPWorkshop As ListBox
    Friend WithEvents lstPLocation As ListBox
    Friend WithEvents lstListCosts As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAddWorkshop As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
End Class
