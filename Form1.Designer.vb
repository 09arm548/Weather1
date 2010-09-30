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
        Me.btnGetWeather = New System.Windows.Forms.Button()
        Me.txtWOEID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGetWeather
        '
        Me.btnGetWeather.Location = New System.Drawing.Point(86, 151)
        Me.btnGetWeather.Name = "btnGetWeather"
        Me.btnGetWeather.Size = New System.Drawing.Size(100, 23)
        Me.btnGetWeather.TabIndex = 0
        Me.btnGetWeather.Text = "Get Weather!"
        Me.btnGetWeather.UseVisualStyleBackColor = True
        '
        'txtWOEID
        '
        Me.txtWOEID.Location = New System.Drawing.Point(86, 60)
        Me.txtWOEID.Name = "txtWOEID"
        Me.txtWOEID.Size = New System.Drawing.Size(100, 20)
        Me.txtWOEID.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtWOEID)
        Me.Controls.Add(Me.btnGetWeather)
        Me.Name = "Form1"
        Me.Text = "What's the Weather?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetWeather As System.Windows.Forms.Button
    Friend WithEvents txtWOEID As System.Windows.Forms.TextBox

End Class
