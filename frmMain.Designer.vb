<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGetWeather = New System.Windows.Forms.Button()
        Me.txtWOEID = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGetWeather
        '
        Me.btnGetWeather.Location = New System.Drawing.Point(115, 281)
        Me.btnGetWeather.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetWeather.Name = "btnGetWeather"
        Me.btnGetWeather.Size = New System.Drawing.Size(133, 28)
        Me.btnGetWeather.TabIndex = 0
        Me.btnGetWeather.Text = "Get Weather!"
        Me.btnGetWeather.UseVisualStyleBackColor = True
        '
        'txtWOEID
        '
        Me.txtWOEID.Location = New System.Drawing.Point(41, 13)
        Me.txtWOEID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWOEID.Name = "txtWOEID"
        Me.txtWOEID.Size = New System.Drawing.Size(304, 22)
        Me.txtWOEID.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(24, 60)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(320, 209)
        Me.WebBrowser1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(518, 111)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(320, 180)
        Me.ListBox1.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 322)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtWOEID)
        Me.Controls.Add(Me.btnGetWeather)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "What's the Weather?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetWeather As System.Windows.Forms.Button
    Friend WithEvents txtWOEID As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
