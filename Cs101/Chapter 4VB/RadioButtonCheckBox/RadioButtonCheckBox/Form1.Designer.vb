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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSoftDrink = New System.Windows.Forms.RadioButton()
        Me.radTea = New System.Windows.Forms.RadioButton()
        Me.radCoffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMocha = New System.Windows.Forms.CheckBox()
        Me.chkAmarreto = New System.Windows.Forms.CheckBox()
        Me.chkWhippedCream = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblResult = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSoftDrink)
        Me.GroupBox1.Controls.Add(Me.radTea)
        Me.GroupBox1.Controls.Add(Me.radCoffee)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 169)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Drink"
        '
        'radSoftDrink
        '
        Me.radSoftDrink.AutoSize = True
        Me.radSoftDrink.Location = New System.Drawing.Point(16, 118)
        Me.radSoftDrink.Name = "radSoftDrink"
        Me.radSoftDrink.Size = New System.Drawing.Size(105, 24)
        Me.radSoftDrink.TabIndex = 2
        Me.radSoftDrink.Text = "Soft Drink"
        Me.radSoftDrink.UseVisualStyleBackColor = True
        '
        'radTea
        '
        Me.radTea.AutoSize = True
        Me.radTea.Location = New System.Drawing.Point(16, 69)
        Me.radTea.Name = "radTea"
        Me.radTea.Size = New System.Drawing.Size(61, 24)
        Me.radTea.TabIndex = 1
        Me.radTea.Text = "Tea"
        Me.radTea.UseVisualStyleBackColor = True
        '
        'radCoffee
        '
        Me.radCoffee.AutoSize = True
        Me.radCoffee.Checked = True
        Me.radCoffee.Location = New System.Drawing.Point(16, 25)
        Me.radCoffee.Name = "radCoffee"
        Me.radCoffee.Size = New System.Drawing.Size(82, 24)
        Me.radCoffee.TabIndex = 0
        Me.radCoffee.TabStop = True
        Me.radCoffee.Text = "Coffee"
        Me.radCoffee.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkMocha)
        Me.GroupBox2.Controls.Add(Me.chkAmarreto)
        Me.GroupBox2.Controls.Add(Me.chkWhippedCream)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 169)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Extras"
        '
        'chkMocha
        '
        Me.chkMocha.AutoSize = True
        Me.chkMocha.Location = New System.Drawing.Point(17, 69)
        Me.chkMocha.Name = "chkMocha"
        Me.chkMocha.Size = New System.Drawing.Size(83, 24)
        Me.chkMocha.TabIndex = 6
        Me.chkMocha.Text = "Mocha"
        Me.chkMocha.UseVisualStyleBackColor = True
        '
        'chkAmarreto
        '
        Me.chkAmarreto.AutoSize = True
        Me.chkAmarreto.Location = New System.Drawing.Point(17, 118)
        Me.chkAmarreto.Name = "chkAmarreto"
        Me.chkAmarreto.Size = New System.Drawing.Size(101, 24)
        Me.chkAmarreto.TabIndex = 5
        Me.chkAmarreto.Text = "Amarreto"
        Me.chkAmarreto.UseVisualStyleBackColor = True
        '
        'chkWhippedCream
        '
        Me.chkWhippedCream.AutoSize = True
        Me.chkWhippedCream.Location = New System.Drawing.Point(17, 25)
        Me.chkWhippedCream.Name = "chkWhippedCream"
        Me.chkWhippedCream.Size = New System.Drawing.Size(149, 24)
        Me.chkWhippedCream.TabIndex = 4
        Me.chkWhippedCream.Text = "Whipped Cream"
        Me.chkWhippedCream.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(197, 227)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(99, 36)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(368, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblResult})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 289)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(675, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblResult
        '
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 15)
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 311)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Radio Buttons and Check Boxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radSoftDrink As RadioButton
    Friend WithEvents radTea As RadioButton
    Friend WithEvents radCoffee As RadioButton
    Friend WithEvents chkMocha As CheckBox
    Friend WithEvents chkAmarreto As CheckBox
    Friend WithEvents chkWhippedCream As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblResult As ToolStripStatusLabel
End Class
