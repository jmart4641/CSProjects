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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStartIndex = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtToFind = New System.Windows.Forms.TextBox()
        Me.lblString = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 48)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Index Numbers:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(662, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 25)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "30"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(512, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "20"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "10"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Start searching at index"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStartIndex
        '
        Me.txtStartIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartIndex.Location = New System.Drawing.Point(327, 182)
        Me.txtStartIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStartIndex.Name = "txtStartIndex"
        Me.txtStartIndex.Size = New System.Drawing.Size(50, 30)
        Me.txtStartIndex.TabIndex = 42
        Me.txtStartIndex.Text = "0"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(324, 309)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 35)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Close"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(218, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(504, 28)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "012345678901234567890123456789012"
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(62, 243)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(616, 34)
        Me.lblResults.TabIndex = 48
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(388, 177)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(93, 42)
        Me.btnGo.TabIndex = 43
        Me.btnGo.Text = "Go"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Substring to find:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtToFind
        '
        Me.txtToFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToFind.Location = New System.Drawing.Point(327, 134)
        Me.txtToFind.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtToFind.Name = "txtToFind"
        Me.txtToFind.Size = New System.Drawing.Size(151, 30)
        Me.txtToFind.TabIndex = 41
        '
        'lblString
        '
        Me.lblString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblString.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblString.ForeColor = System.Drawing.Color.Blue
        Me.lblString.Location = New System.Drawing.Point(216, 17)
        Me.lblString.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(506, 31)
        Me.lblString.TabIndex = 46
        Me.lblString.Text = "abcABC00123573@ 123 ABC 98ABC123"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Search this String:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 360)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStartIndex)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtToFind)
        Me.Controls.Add(Me.lblString)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "String Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStartIndex As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtToFind As System.Windows.Forms.TextBox
    Friend WithEvents lblString As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
