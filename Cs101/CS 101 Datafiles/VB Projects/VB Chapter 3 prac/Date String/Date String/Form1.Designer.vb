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
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Day of the Week"
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Location = New System.Drawing.Point(412, 44)
        Me.txtDayOfWeek.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.Size = New System.Drawing.Size(153, 35)
        Me.txtDayOfWeek.TabIndex = 1
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(78, 348)
        Me.btnShowDate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(142, 51)
        Me.btnShowDate.TabIndex = 2
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter the month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter the day of the month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter the year"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(412, 104)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(153, 35)
        Me.txtMonth.TabIndex = 6
        '
        'txtDayOfMonth
        '
        Me.txtDayOfMonth.Location = New System.Drawing.Point(412, 162)
        Me.txtDayOfMonth.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtDayOfMonth.Name = "txtDayOfMonth"
        Me.txtDayOfMonth.Size = New System.Drawing.Size(153, 35)
        Me.txtDayOfMonth.TabIndex = 7
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(412, 215)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(153, 35)
        Me.txtYear.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(258, 348)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 51)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(439, 348)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 51)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Location = New System.Drawing.Point(81, 274)
        Me.lblDateString.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(487, 33)
        Me.lblDateString.TabIndex = 11
        Me.lblDateString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 455)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayOfMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDayOfWeek As TextBox
    Friend WithEvents btnShowDate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDayOfMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateString As Label
End Class
