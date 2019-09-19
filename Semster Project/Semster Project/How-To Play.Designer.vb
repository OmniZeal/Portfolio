<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class How_To_Play
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(How_To_Play))
        Me.questionNum = New System.Windows.Forms.Label()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.answerD = New System.Windows.Forms.Button()
        Me.AnswerB = New System.Windows.Forms.Button()
        Me.AnswerC = New System.Windows.Forms.Button()
        Me.answerA = New System.Windows.Forms.Button()
        Me.questionLabel = New System.Windows.Forms.Label()
        Me.rightAnswerSelect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'questionNum
        '
        Me.questionNum.AutoSize = True
        Me.questionNum.Location = New System.Drawing.Point(98, 139)
        Me.questionNum.Name = "questionNum"
        Me.questionNum.Size = New System.Drawing.Size(337, 13)
        Me.questionNum.TabIndex = 17
        Me.questionNum.Text = "The Question Counter will display the question you are on. Question: 0"
        '
        'continueButton
        '
        Me.continueButton.Enabled = False
        Me.continueButton.Location = New System.Drawing.Point(205, 33)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(118, 23)
        Me.continueButton.TabIndex = 15
        Me.continueButton.Text = "Return to Menu"
        Me.continueButton.UseVisualStyleBackColor = True
        Me.continueButton.Visible = False
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(214, 17)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(0, 13)
        Me.answerLabel.TabIndex = 14
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'answerD
        '
        Me.answerD.Location = New System.Drawing.Point(306, 316)
        Me.answerD.Name = "answerD"
        Me.answerD.Size = New System.Drawing.Size(231, 36)
        Me.answerD.TabIndex = 13
        Me.answerD.Text = "D: The Wrong Answer"
        Me.answerD.UseVisualStyleBackColor = True
        '
        'AnswerB
        '
        Me.AnswerB.Location = New System.Drawing.Point(306, 261)
        Me.AnswerB.Name = "AnswerB"
        Me.AnswerB.Size = New System.Drawing.Size(231, 37)
        Me.AnswerB.TabIndex = 12
        Me.AnswerB.Text = "B: The Wrong Answer"
        Me.AnswerB.UseVisualStyleBackColor = True
        '
        'AnswerC
        '
        Me.AnswerC.Location = New System.Drawing.Point(12, 316)
        Me.AnswerC.Name = "AnswerC"
        Me.AnswerC.Size = New System.Drawing.Size(231, 36)
        Me.AnswerC.TabIndex = 11
        Me.AnswerC.Text = "C: The Right Answer"
        Me.AnswerC.UseVisualStyleBackColor = True
        '
        'answerA
        '
        Me.answerA.Location = New System.Drawing.Point(12, 261)
        Me.answerA.Name = "answerA"
        Me.answerA.Size = New System.Drawing.Size(231, 37)
        Me.answerA.TabIndex = 10
        Me.answerA.Text = "A: The Wrong Answer"
        Me.answerA.UseVisualStyleBackColor = True
        '
        'questionLabel
        '
        Me.questionLabel.AutoSize = True
        Me.questionLabel.Location = New System.Drawing.Point(133, 191)
        Me.questionLabel.Name = "questionLabel"
        Me.questionLabel.Size = New System.Drawing.Size(258, 13)
        Me.questionLabel.TabIndex = 9
        Me.questionLabel.Text = "A Question will display here! Choose the right answer!"
        '
        'rightAnswerSelect
        '
        Me.rightAnswerSelect.AutoSize = True
        Me.rightAnswerSelect.Location = New System.Drawing.Point(68, 88)
        Me.rightAnswerSelect.Name = "rightAnswerSelect"
        Me.rightAnswerSelect.Size = New System.Drawing.Size(410, 39)
        Me.rightAnswerSelect.TabIndex = 18
        Me.rightAnswerSelect.Text = resources.GetString("rightAnswerSelect.Text")
        Me.rightAnswerSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rightAnswerSelect.Visible = False
        '
        'How_To_Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 369)
        Me.Controls.Add(Me.rightAnswerSelect)
        Me.Controls.Add(Me.questionNum)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.answerD)
        Me.Controls.Add(Me.AnswerB)
        Me.Controls.Add(Me.AnswerC)
        Me.Controls.Add(Me.answerA)
        Me.Controls.Add(Me.questionLabel)
        Me.Name = "How_To_Play"
        Me.Text = "How-To Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents questionNum As System.Windows.Forms.Label
    Friend WithEvents continueButton As System.Windows.Forms.Button
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents answerD As System.Windows.Forms.Button
    Friend WithEvents AnswerB As System.Windows.Forms.Button
    Friend WithEvents AnswerC As System.Windows.Forms.Button
    Friend WithEvents answerA As System.Windows.Forms.Button
    Friend WithEvents questionLabel As System.Windows.Forms.Label
    Friend WithEvents rightAnswerSelect As System.Windows.Forms.Label
End Class
