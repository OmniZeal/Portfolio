Public Class How_To_Play

    Private Sub answerA_Click(sender As Object, e As EventArgs) Handles answerA.Click
        answerA.Enabled = False

        answerLabel.Text = "That is incorrect! Select the RIGHT answer!"
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

        rightAnswerSelect.Visible = True
        questionNum.Visible = False
    End Sub

    Private Sub AnswerB_Click(sender As Object, e As EventArgs) Handles AnswerB.Click
        AnswerB.Enabled = False

        answerLabel.Text = "That is incorrect! Select the RIGHT answer!"
    End Sub

    Private Sub answerD_Click(sender As Object, e As EventArgs) Handles answerD.Click
        answerD.Enabled = False

        answerLabel.Text = "That is incorrect! Select the RIGHT answer!"
    End Sub

    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        main.Show()
        Me.Close()
    End Sub
End Class