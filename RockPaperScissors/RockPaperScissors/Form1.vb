Option Strict On
'Eric Oliver

Public Class frmRPS
    Dim roundCount As Object
    Dim gdecRoundNumber, gdecPlayer1Wins, gdecPlayer2Wins As Integer
    Private Sub frmRPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to the RPS Game! ..... Make your selection either R, P, or S. ")
        Dim gdecRoundNumber = 1
    End Sub

    Private Sub btnFight_Click(sender As Object, e As EventArgs) Handles btnFight.Click
        If txtPlayer1.Text = "" Then
            MsgBox("Player 1 needs to make a selection.")
        End If
        If txtPlayer2.Text = "" Then
            MsgBox("Player 2 needs to make a selection.")
        End If

        Select Case txtPlayer1.Text
            Case "R"
                If txtPlayer2.Text = "R" Then
                    MsgBox("The round was a tie")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "P" Then
                    MsgBox("Paper beats rock, Player 2 wins!")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer2Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "S" Then
                    MsgBox("Rock beats scissors, Player 1 wins!")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer1Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                End If
            Case "P"
                If txtPlayer2.Text = "R" Then
                    MsgBox("Paper beats rock, Player 1 wins")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer1Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "P" Then
                    MsgBox("The round was a tie")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "S" Then
                    MsgBox("Scissors beats Paper, Player 2 wins!")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer2Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                End If
            Case "S"
                If txtPlayer2.Text = "R" Then
                    MsgBox("Rock beats scissors, Player 2 wins")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer2Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "S" Then
                    MsgBox("The round was a tie")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                ElseIf txtPlayer2.Text = "P" Then
                    MsgBox("Scissors beats Paper, Player 1 wins!")
                    txtRoundCount.Text = CStr(gdecRoundNumber + 1)
                    txtPlayer2Wins.Text = CStr(gdecPlayer1Wins + 1)
                    txtPlayer1.Text = ""
                    txtPlayer2.Text = ""
                    txtPlayer1.Focus()
                End If
        End Select

        If gdecRoundNumber > 4 Then
            If txtPlayer1Wins.Text < txtPlayer2Wins.Text Then
                MsgBox("The overall winner is Player 2")
            ElseIf txtPlayer1Wins.Text > txtPlayer2Wins.Text Then
                MsgBox("The overall winner is Player 1")
            Else
                MsgBox("The game was a tie!")
            End If
            Close()

        End If
    End Sub
End Class
