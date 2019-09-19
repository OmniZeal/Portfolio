<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question_10
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
        Me.questionNum = New System.Windows.Forms.Label()
        Me.mainMenuButton = New System.Windows.Forms.Button()
        Me.continueButton = New System.Windows.Forms.Button()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.answerD = New System.Windows.Forms.Button()
        Me.AnswerB = New System.Windows.Forms.Button()
        Me.AnswerC = New System.Windows.Forms.Button()
        Me.answerA = New System.Windows.Forms.Button()
        Me.questionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'questionNum
        '
        Me.questionNum.AutoSize = True
        Me.questionNum.Location = New System.Drawing.Point(198, 134)
        Me.questionNum.Name = "questionNum"
        Me.questionNum.Size = New System.Drawing.Size(140, 13)
        Me.questionNum.TabIndex = 80
        Me.questionNum.Text = "Final Question, Question: 10"
        '
        'mainMenuButton
        '
        Me.mainMenuButton.Location = New System.Drawing.Point(210, 63)
        Me.mainMenuButton.Name = "mainMenuButton"
        Me.mainMenuButton.Size = New System.Drawing.Size(118, 23)
        Me.mainMenuButton.TabIndex = 79
        Me.mainMenuButton.Text = "Main Menu"
        Me.mainMenuButton.UseVisualStyleBackColor = True
        Me.mainMenuButton.Visible = False
        '
        'continueButton
        '
        Me.continueButton.Enabled = False
        Me.continueButton.Location = New System.Drawing.Point(210, 34)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(118, 23)
        Me.continueButton.TabIndex = 78
        Me.continueButton.Text = "Continue..."
        Me.continueButton.UseVisualStyleBackColor = True
        Me.continueButton.Visible = False
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(217, 10)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(0, 13)
        Me.answerLabel.TabIndex = 77
        '
        'answerD
        '
        Me.answerD.Location = New System.Drawing.Point(306, 316)
        Me.answerD.Name = "answerD"
        Me.answerD.Size = New System.Drawing.Size(231, 36)
        Me.answerD.TabIndex = 76
        Me.answerD.Text = "D: A bug found eating a Hard-Disk Drive."
        Me.answerD.UseVisualStyleBackColor = True
        '
        'AnswerB
        '
        Me.AnswerB.Location = New System.Drawing.Point(306, 261)
        Me.AnswerB.Name = "AnswerB"
        Me.AnswerB.Size = New System.Drawing.Size(231, 37)
        Me.AnswerB.TabIndex = 75
        Me.AnswerB.Text = "B: A bug found in a vacuum tube."
        Me.AnswerB.UseVisualStyleBackColor = True
        '
        'AnswerC
        '
        Me.AnswerC.Location = New System.Drawing.Point(12, 316)
        Me.AnswerC.Name = "AnswerC"
        Me.AnswerC.Size = New System.Drawing.Size(231, 36)
        Me.AnswerC.TabIndex = 74
        Me.AnswerC.Text = "C: A slang term created by a programmer."
        Me.AnswerC.UseVisualStyleBackColor = True
        '
        'answerA
        '
        Me.answerA.Location = New System.Drawing.Point(12, 261)
        Me.answerA.Name = "answerA"
        Me.answerA.Size = New System.Drawing.Size(231, 37)
        Me.answerA.TabIndex = 73
        Me.answerA.Text = "A: A bug found in a fan of a computer case."
        Me.answerA.UseVisualStyleBackColor = True
        '
        'questionLabel
        '
        Me.questionLabel.AutoSize = True
        Me.questionLabel.Location = New System.Drawing.Point(184, 205)
        Me.questionLabel.Name = "questionLabel"
        Me.questionLabel.Size = New System.Drawing.Size(180, 13)
        Me.questionLabel.TabIndex = 72
        Me.questionLabel.Text = "Where did the term 'bug' come from?"
        '
        'Question_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 369)
        Me.Controls.Add(Me.questionNum)
        Me.Controls.Add(Me.mainMenuButton)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.answerD)
        Me.Controls.Add(Me.AnswerB)
        Me.Controls.Add(Me.AnswerC)
        Me.Controls.Add(Me.answerA)
        Me.Controls.Add(Me.questionLabel)
        Me.Name = "Question_10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question_10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents questionNum As System.Windows.Forms.Label
    Friend WithEvents mainMenuButton As System.Windows.Forms.Button
    Friend WithEvents continueButton As System.Windows.Forms.Button
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents answerD As System.Windows.Forms.Button
    Friend WithEvents AnswerB As System.Windows.Forms.Button
    Friend WithEvents AnswerC As System.Windows.Forms.Button
    Friend WithEvents answerA As System.Windows.Forms.Button
    Friend WithEvents questionLabel As System.Windows.Forms.Label
End Class
