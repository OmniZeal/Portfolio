Public Class You_Win

    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        main.Show()
        highscore.Show()
        highscore.highscoreBox.Visible = True

        Me.Close()
    End Sub
End Class