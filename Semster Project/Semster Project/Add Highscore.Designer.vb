<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class highscore
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
        Me.highscoreList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.highscoreBox = New System.Windows.Forms.GroupBox()
        Me.yourNameID = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.highscoreBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'highscoreList
        '
        Me.highscoreList.FormattingEnabled = True
        Me.highscoreList.Location = New System.Drawing.Point(68, 28)
        Me.highscoreList.Name = "highscoreList"
        Me.highscoreList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.highscoreList.Size = New System.Drawing.Size(140, 69)
        Me.highscoreList.Sorted = True
        Me.highscoreList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Millionaire List"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(10, 45)
        Me.nameBox.MaxLength = 3
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 2
        '
        'highscoreBox
        '
        Me.highscoreBox.Controls.Add(Me.yourNameID)
        Me.highscoreBox.Controls.Add(Me.addButton)
        Me.highscoreBox.Controls.Add(Me.nameBox)
        Me.highscoreBox.Location = New System.Drawing.Point(7, 158)
        Me.highscoreBox.Name = "highscoreBox"
        Me.highscoreBox.Size = New System.Drawing.Size(273, 100)
        Me.highscoreBox.TabIndex = 4
        Me.highscoreBox.TabStop = False
        Me.highscoreBox.Text = "Add a Millionaire:"
        Me.highscoreBox.Visible = False
        '
        'yourNameID
        '
        Me.yourNameID.AutoSize = True
        Me.yourNameID.Location = New System.Drawing.Point(7, 26)
        Me.yourNameID.Name = "yourNameID"
        Me.yourNameID.Size = New System.Drawing.Size(132, 13)
        Me.yourNameID.TabIndex = 5
        Me.yourNameID.Text = "Enter Your 3 Character ID:"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(171, 36)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 36)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "Add Your ID!"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'returnButton
        '
        Me.returnButton.Location = New System.Drawing.Point(84, 129)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(111, 23)
        Me.returnButton.TabIndex = 5
        Me.returnButton.Text = "Return to Menu"
        Me.returnButton.UseVisualStyleBackColor = True
        '
        'highscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.highscoreBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.highscoreList)
        Me.Name = "highscore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Millionaires!"
        Me.highscoreBox.ResumeLayout(False)
        Me.highscoreBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents highscoreList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameBox As System.Windows.Forms.TextBox
    Friend WithEvents highscoreBox As System.Windows.Forms.GroupBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents yourNameID As System.Windows.Forms.Label
    Friend WithEvents returnButton As System.Windows.Forms.Button
End Class
