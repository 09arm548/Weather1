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
        Me.SuspendLayout()
        '
        'btnGetWeather
        '
        Me.btnGetWeather.Location = New System.Drawing.Point(83, 65)
        Me.btnGetWeather.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetWeather.Name = "btnGetWeather"
        Me.btnGetWeather.Size = New System.Drawing.Size(133, 28)
        Me.btnGetWeather.TabIndex = 0
        Me.btnGetWeather.Text = "Get Weather!"
        Me.btnGetWeather.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 177)
        Me.Controls.Add(Me.btnGetWeather)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "What's the Weather?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetWeather As System.Windows.Forms.Button

End Class
