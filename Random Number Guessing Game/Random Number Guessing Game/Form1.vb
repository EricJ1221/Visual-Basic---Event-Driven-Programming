Option Strict On
'Eric Oliver

Public Class RNGGfrm
    Dim gdecMyRand As New Random
    Dim gintMyRandom, gintCount, gintDifficulty, gintAttemptsAt As Integer
    Dim gdecCorrect As Boolean
    Dim gdecGuess As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Form1_Load")
        radEasy.Checked = True

    End Sub

    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        Console.WriteLine("radEasy_CheckedChanged")
        If radEasy.Checked Then
            gintDifficulty = 11
            gintAttemptsAt = 7
        End If
    End Sub

    Private Sub radIntermediate_CheckedChanged(sender As Object, e As EventArgs) Handles radIntermediate.CheckedChanged
        Console.WriteLine("radIntermediate_CheckedChanged")
        If radIntermediate.Checked Then
            gintDifficulty = 21
            gintAttemptsAt = 6
        End If
    End Sub
    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        Console.WriteLine("radHard_CheckedChanged")
        If radHard.Checked Then
            gintDifficulty = 51
            gintAttemptsAt = 5
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Console.WriteLine("btnExit_Click")
        End
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("btnPlay_Click")
        gintMyRandom = gdecMyRand.Next(1, gintDifficulty)
        Console.WriteLine(gintMyRandom)
        gdecCorrect = False
        gintCount = 0

        Do While gintCount < gintAttemptsAt And gdecCorrect = False
            gdecGuess = InputBox("Enter your guess", "Attempt " & (gintCount + 1))
            If Val(gdecGuess) = gintMyRandom Then
                gdecCorrect = True
                MsgBox("Would you like to play again?", , "YOU WIN!!!!")
            Else
                MsgBox("WRONG , you're bad at this.", , "Attempt " & (gintCount + 1))
                gintCount = gintCount + 1

            End If
        Loop
        Console.WriteLine("You stink, you're bad at guessing random numbers.")
        MsgBox("You Lose! The number was " & gintMyRandom & ".") '& Format(gdecMyRand, "String"))
    End Sub
End Class
