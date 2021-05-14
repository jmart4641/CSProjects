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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNIghtlyCharge = New System.Windows.Forms.TextBox()
        Me.txtNight = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomSerive = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculateCharges = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(217, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDateToday
        '
        Me.lblDateToday.Location = New System.Drawing.Point(276, 64)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(145, 20)
        Me.lblDateToday.TabIndex = 3
        Me.lblDateToday.Text = "November 8, 2020"
        Me.lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Location = New System.Drawing.Point(276, 104)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(100, 20)
        Me.lblTimeToday.TabIndex = 4
        Me.lblTimeToday.Text = "10:00 PM"
        Me.lblTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNIghtlyCharge)
        Me.GroupBox1.Controls.Add(Me.txtNight)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 148)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'txtNIghtlyCharge
        '
        Me.txtNIghtlyCharge.Location = New System.Drawing.Point(141, 63)
        Me.txtNIghtlyCharge.Name = "txtNIghtlyCharge"
        Me.txtNIghtlyCharge.Size = New System.Drawing.Size(100, 26)
        Me.txtNIghtlyCharge.TabIndex = 3
        '
        'txtNight
        '
        Me.txtNight.Location = New System.Drawing.Point(141, 31)
        Me.txtNight.Name = "txtNight"
        Me.txtNight.Size = New System.Drawing.Size(100, 26)
        Me.txtNight.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(14, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nightly Charge:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(77, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Night:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomSerive)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 148)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Misc:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(141, 96)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 26)
        Me.txtMisc.TabIndex = 4
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(141, 64)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 26)
        Me.txtTelephone.TabIndex = 3
        '
        'txtRoomSerive
        '
        Me.txtRoomSerive.Location = New System.Drawing.Point(141, 31)
        Me.txtRoomSerive.Name = "txtRoomSerive"
        Me.txtRoomSerive.Size = New System.Drawing.Size(100, 26)
        Me.txtRoomSerive.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(17, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Telephone:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Room Service:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblAddCharges)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(66, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 231)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCharges.Location = New System.Drawing.Point(275, 188)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(177, 27)
        Me.lblTotalCharges.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(275, 145)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(177, 27)
        Me.lblTax.TabIndex = 8
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(275, 107)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(177, 27)
        Me.lblSubtotal.TabIndex = 7
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharges.Location = New System.Drawing.Point(275, 66)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(177, 27)
        Me.lblAddCharges.TabIndex = 6
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCharges.Location = New System.Drawing.Point(275, 27)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(177, 27)
        Me.lblRoomCharges.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label14.Location = New System.Drawing.Point(143, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Total Charges:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label13.Location = New System.Drawing.Point(210, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Tax:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label12.Location = New System.Drawing.Point(181, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Subtotal:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label10.Location = New System.Drawing.Point(111, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Additional Charges:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label11.Location = New System.Drawing.Point(137, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Room Charges:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(90, 563)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(155, 29)
        Me.btnCalculateCharges.TabIndex = 8
        Me.btnCalculateCharges.Text = "C&alculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(263, 563)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 29)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 563)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 29)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(144, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Today' Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 629)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTimeToday As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNIghtlyCharge As TextBox
    Friend WithEvents txtNight As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomSerive As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblRoomCharges As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotalCharges As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblAddCharges As Label
    Friend WithEvents btnCalculateCharges As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMisc As TextBox
End Class
