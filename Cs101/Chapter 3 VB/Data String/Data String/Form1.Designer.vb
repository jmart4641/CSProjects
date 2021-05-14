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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFullDate = New System.Windows.Forms.Label()
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Day of the week"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Day of the Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'lblFullDate
        '
        Me.lblFullDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblFullDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullDate.Location = New System.Drawing.Point(57, 221)
        Me.lblFullDate.Name = "lblFullDate"
        Me.lblFullDate.Size = New System.Drawing.Size(303, 29)
        Me.lblFullDate.TabIndex = 4
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Location = New System.Drawing.Point(260, 51)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.Size = New System.Drawing.Size(100, 26)
        Me.txtDayOfWeek.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(260, 83)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 26)
        Me.txtMonth.TabIndex = 1
        '
        'txtDayOfMonth
        '
        Me.txtDayOfMonth.Location = New System.Drawing.Point(260, 125)
        Me.txtDayOfMonth.Name = "txtDayOfMonth"
        Me.txtDayOfMonth.Size = New System.Drawing.Size(100, 26)
        Me.txtDayOfMonth.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(260, 173)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 26)
        Me.txtYear.TabIndex = 3
        '
        'btnShowDate
        '
        Me.btnShowDate.AccessibleDescription = "btnShowDate"
        Me.btnShowDate.Location = New System.Drawing.Point(56, 279)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(74, 51)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show &Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(165, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 51)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 51)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 346)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayOfMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Controls.Add(Me.lblFullDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFullDate As Label
    Friend WithEvents txtDayOfWeek As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDayOfMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
