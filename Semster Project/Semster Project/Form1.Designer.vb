<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.title = New System.Windows.Forms.Label()
        Me.play = New System.Windows.Forms.Button()
        Me.howToPlay = New System.Windows.Forms.Button()
        Me.highScores = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.Silver
        Me.title.Location = New System.Drawing.Point(25, 66)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(740, 33)
        Me.title.TabIndex = 0
        Me.title.Text = "Who Wants to be a Millionaire: Programming Edition"
        '
        'play
        '
        Me.play.Location = New System.Drawing.Point(304, 170)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(210, 77)
        Me.play.TabIndex = 1
        Me.play.Text = "Play!"
        Me.play.UseVisualStyleBackColor = True
        '
        'howToPlay
        '
        Me.howToPlay.Location = New System.Drawing.Point(348, 336)
        Me.howToPlay.Name = "howToPlay"
        Me.howToPlay.Size = New System.Drawing.Size(119, 50)
        Me.howToPlay.TabIndex = 3
        Me.howToPlay.Text = "How-To Play"
        Me.howToPlay.UseVisualStyleBackColor = True
        '
        'highScores
        '
        Me.highScores.Location = New System.Drawing.Point(348, 392)
        Me.highScores.Name = "highScores"
        Me.highScores.Size = New System.Drawing.Size(119, 49)
        Me.highScores.TabIndex = 4
        Me.highScores.Text = "Millionaire Winners"
        Me.highScores.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(369, 447)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 40)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 529)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.highScores)
        Me.Controls.Add(Me.howToPlay)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.title)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Who Wants to be a Millionaire?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents play As System.Windows.Forms.Button
    Friend WithEvents howToPlay As System.Windows.Forms.Button
    Friend WithEvents highScores As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
