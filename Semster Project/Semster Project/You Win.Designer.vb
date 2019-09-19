<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class You_Win
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
        Me.millionaireLabel = New System.Windows.Forms.Label()
        Me.youWinLabel = New System.Windows.Forms.Label()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'millionaireLabel
        '
        Me.millionaireLabel.AutoSize = True
        Me.millionaireLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.millionaireLabel.Location = New System.Drawing.Point(83, 76)
        Me.millionaireLabel.Name = "millionaireLabel"
        Me.millionaireLabel.Size = New System.Drawing.Size(114, 18)
        Me.millionaireLabel.TabIndex = 0
        Me.millionaireLabel.Text = "MILLIONAIRE!"
        '
        'youWinLabel
        '
        Me.youWinLabel.AutoSize = True
        Me.youWinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.youWinLabel.Location = New System.Drawing.Point(101, 134)
        Me.youWinLabel.Name = "youWinLabel"
        Me.youWinLabel.Size = New System.Drawing.Size(75, 18)
        Me.youWinLabel.TabIndex = 1
        Me.youWinLabel.Text = "You Win!"
        '
        'continueButton
        '
        Me.continueButton.Location = New System.Drawing.Point(101, 176)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(75, 23)
        Me.continueButton.TabIndex = 2
        Me.continueButton.Text = "Continue..."
        Me.continueButton.UseVisualStyleBackColor = True
        '
        'You_Win
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.youWinLabel)
        Me.Controls.Add(Me.millionaireLabel)
        Me.Name = "You_Win"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You Win!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents millionaireLabel As System.Windows.Forms.Label
    Friend WithEvents youWinLabel As System.Windows.Forms.Label
    Friend WithEvents continueButton As System.Windows.Forms.Button
End Class
