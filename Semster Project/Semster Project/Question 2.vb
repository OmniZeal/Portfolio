Public Class Question_2

    Private Sub Question_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Question_1.Close()
    End Sub

    Private Sub AnswerC_Click(sender As Object, e As EventArgs) Handles AnswerC.Click
        answerLabel.Text = "That is CORRECT!"

        continueButton.Visible = True
        continueButton.Enabled = True

        main.score = main.score + 1

        answerA.Enabled = False
        AnswerB.Enabled = False
        AnswerC.Enabled = False
        answerD.Enabled = False
    End Sub

    Private Sub answerA_Click(sender As Object, e As EventArgs) Handles answerA.Click
        answerLabel.Text = "I'm sorry, that is incorrect."

        mainMenuButton.Visible = True
        mainMenuButton.Enabled = True

        answerA.Enabled = False
        AnswerB.Enabled = False
        AnswerC.Enabled = False
        answerD.Enabled = False
    End Sub

    Private Sub AnswerB_Click(sender As Object, e As EventArgs) Handles AnswerB.Click
        answerLabel.Text = "I'm sorry, that is incorrect."

        mainMenuButton.Visible = True
        mainMenuButton.Enabled = True

        answerA.Enabled = False
        AnswerB.Enabled = False
        AnswerC.Enabled = False
        answerD.Enabled = False
    End Sub

    Private Sub answerD_Click(sender As Object, e As EventArgs) Handles answerD.Click
        answerLabel.Text = "I'm sorry, that is incorrect."

        mainMenuButton.Visible = True
        mainMenuButton.Enabled = True

        answerA.Enabled = False
        AnswerB.Enabled = False
        AnswerC.Enabled = False
        answerD.Enabled = False
    End Sub

    Private Sub mainMenuButton_Click(sender As Object, e As EventArgs) Handles mainMenuButton.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        Question_3.Show()
    End Sub
End Class