Option Strict On
'Eric Oliver

Public Class frmMathGame
    Dim gdecRandOne, gdecRandTwo As New Random
    Dim gintMyRandomOne, gintMyRandomTwo, gintDifficulty, gintWrong, gintCorrect, gintSolution, gintGuess As Integer
    Dim gstrGuess As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub frmMathGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radEasy.Checked = True
    End Sub

    Dim gstrRandOne, gstrRandTwo, gstrtheGuess As String

    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        If radHard.Checked Then
            gintDifficulty = 1001
        End If
    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If radEasy.Checked Then
            gintDifficulty = 101
        End If
    End Sub

    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        If radEasy.Checked Then
            gintDifficulty = 11
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Console.WriteLine("btnPlay_Click")
        'double declaration, dont need
        'gintMyRandomOne = gdecRandOne.Next(1, gintDifficulty)
        'gintMyRandomTwo = gdecRandTwo.Next(1, gintDifficulty)

        'gstrRandOne = CStr(gintMyRandomOne)
        'gstrRandTwo = CStr(gintMyRandomTwo)

        gintSolution = (gintMyRandomOne + gintMyRandomTwo)
        gintCorrect = 0


        Do While gintCorrect < 3 And gintWrong <> 1
            'need to generate two different randoms, not the same number
            gintMyRandomOne = gdecRandOne(1, gintDifficulty)
            gintMyRandomTwo = gdecRandTwo.Next(2, gintDifficulty)

            gstrRandOne = CStr(gintMyRandomOne)
            gstrRandTwo = CStr(gintMyRandomTwo)

            'I do not remember what conversion to use to make this input box accept my variables
            gstrGuess = InputBox(gstrRandOne & " + " & gstrRandTwo, )
            If Val(gintGuess) = gintSolution Then
                gintCorrect += 1
            ElseIf Val(gintGuess) <> gintSolution Then
                gintWrong += 1
            End If
        Loop

        If gintCorrect = 3 Then
            MsgBox("You have won the game!")
        End If


    End Sub
End Class
