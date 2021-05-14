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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTicketSoldAdult = New System.Windows.Forms.TextBox()
        Me.txtPriceTicketAdult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTicketSoldChild = New System.Windows.Forms.TextBox()
        Me.txtPriceTicketChild = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblAdultTicketSaleN = New System.Windows.Forms.Label()
        Me.lblChildTicketSaleN = New System.Windows.Forms.Label()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalGrossRevenue = New System.Windows.Forms.Label()
        Me.lblChildTicketSaleG = New System.Windows.Forms.Label()
        Me.lblAdTicketSaleG = New System.Windows.Forms.Label()
        Me.btnCalculateTicketR = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTicketSoldAdult)
        Me.GroupBox1.Controls.Add(Me.txtPriceTicketAdult)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tickets Sold:"
        '
        'txtTicketSoldAdult
        '
        Me.txtTicketSoldAdult.Location = New System.Drawing.Point(214, 81)
        Me.txtTicketSoldAdult.Name = "txtTicketSoldAdult"
        Me.txtTicketSoldAdult.Size = New System.Drawing.Size(118, 26)
        Me.txtTicketSoldAdult.TabIndex = 3
        '
        'txtPriceTicketAdult
        '
        Me.txtPriceTicketAdult.Location = New System.Drawing.Point(214, 35)
        Me.txtPriceTicketAdult.Name = "txtPriceTicketAdult"
        Me.txtPriceTicketAdult.Size = New System.Drawing.Size(118, 26)
        Me.txtPriceTicketAdult.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price per Ticket:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTicketSoldChild)
        Me.GroupBox2.Controls.Add(Me.txtPriceTicketChild)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tickets Sold:"
        '
        'txtTicketSoldChild
        '
        Me.txtTicketSoldChild.Location = New System.Drawing.Point(204, 81)
        Me.txtTicketSoldChild.Name = "txtTicketSoldChild"
        Me.txtTicketSoldChild.Size = New System.Drawing.Size(118, 26)
        Me.txtTicketSoldChild.TabIndex = 3
        '
        'txtPriceTicketChild
        '
        Me.txtPriceTicketChild.Location = New System.Drawing.Point(204, 35)
        Me.txtPriceTicketChild.Name = "txtPriceTicketChild"
        Me.txtPriceTicketChild.Size = New System.Drawing.Size(118, 26)
        Me.txtPriceTicketChild.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price per Ticket:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblAdultTicketSaleN)
        Me.GroupBox4.Controls.Add(Me.lblChildTicketSaleN)
        Me.GroupBox4.Controls.Add(Me.lblTotalNetRevenue)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(379, 206)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 192)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblAdultTicketSaleN
        '
        Me.lblAdultTicketSaleN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultTicketSaleN.Location = New System.Drawing.Point(204, 40)
        Me.lblAdultTicketSaleN.Name = "lblAdultTicketSaleN"
        Me.lblAdultTicketSaleN.Size = New System.Drawing.Size(118, 29)
        Me.lblAdultTicketSaleN.TabIndex = 3
        '
        'lblChildTicketSaleN
        '
        Me.lblChildTicketSaleN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildTicketSaleN.Location = New System.Drawing.Point(204, 86)
        Me.lblChildTicketSaleN.Name = "lblChildTicketSaleN"
        Me.lblChildTicketSaleN.Size = New System.Drawing.Size(118, 29)
        Me.lblChildTicketSaleN.TabIndex = 4
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(204, 134)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(118, 29)
        Me.lblTotalNetRevenue.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(34, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 42)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Net Revenue for Ticket Sales:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Child Ticket Sales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Adult Ticket Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Adult Ticket Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Child Ticket Sales:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblChildTicketSaleG)
        Me.GroupBox3.Controls.Add(Me.lblAdTicketSaleG)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 192)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(46, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 40)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Total Gross Revenue for Ticket Sales:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalGrossRevenue
        '
        Me.lblTotalGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossRevenue.Location = New System.Drawing.Point(214, 134)
        Me.lblTotalGrossRevenue.Name = "lblTotalGrossRevenue"
        Me.lblTotalGrossRevenue.Size = New System.Drawing.Size(118, 29)
        Me.lblTotalGrossRevenue.TabIndex = 5
        '
        'lblChildTicketSaleG
        '
        Me.lblChildTicketSaleG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildTicketSaleG.Location = New System.Drawing.Point(214, 87)
        Me.lblChildTicketSaleG.Name = "lblChildTicketSaleG"
        Me.lblChildTicketSaleG.Size = New System.Drawing.Size(118, 29)
        Me.lblChildTicketSaleG.TabIndex = 4
        '
        'lblAdTicketSaleG
        '
        Me.lblAdTicketSaleG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdTicketSaleG.Location = New System.Drawing.Point(214, 40)
        Me.lblAdTicketSaleG.Name = "lblAdTicketSaleG"
        Me.lblAdTicketSaleG.Size = New System.Drawing.Size(118, 29)
        Me.lblAdTicketSaleG.TabIndex = 3
        '
        'btnCalculateTicketR
        '
        Me.btnCalculateTicketR.Location = New System.Drawing.Point(114, 411)
        Me.btnCalculateTicketR.Name = "btnCalculateTicketR"
        Me.btnCalculateTicketR.Size = New System.Drawing.Size(215, 36)
        Me.btnCalculateTicketR.TabIndex = 4
        Me.btnCalculateTicketR.Text = "Calculate Ticket Revenue"
        Me.btnCalculateTicketR.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(361, 411)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(503, 411)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 36)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 466)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTicketR)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTicketSoldAdult As TextBox
    Friend WithEvents txtPriceTicketAdult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTicketSoldChild As TextBox
    Friend WithEvents txtPriceTicketChild As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblAdultTicketSaleN As Label
    Friend WithEvents lblChildTicketSaleN As Label
    Friend WithEvents lblTotalNetRevenue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTotalGrossRevenue As Label
    Friend WithEvents lblChildTicketSaleG As Label
    Friend WithEvents lblAdTicketSaleG As Label
    Friend WithEvents btnCalculateTicketR As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
End Class
