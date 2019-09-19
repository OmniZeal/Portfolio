Public Class highscore

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        highscoreList.Items.Add(nameBox.Text)
        highscoreBox.Visible = False
        highscoreBox.Enabled = False

        main.score = 0
    End Sub

    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Hide()
    End Sub
End Class