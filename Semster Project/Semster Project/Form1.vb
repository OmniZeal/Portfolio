Public Class main

    Public score As Integer = 0

    Private Sub playFullGame_Click(sender As Object, e As EventArgs) Handles play.Click
        Question_1.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        highscore.Close()
    End Sub

    Private Sub highScores_Click(sender As Object, e As EventArgs) Handles highScores.Click
        highscore.Show()
    End Sub

    Private Sub howToPlay_Click(sender As Object, e As EventArgs) Handles howToPlay.Click
        How_To_Play.Show()
    End Sub
End Class
