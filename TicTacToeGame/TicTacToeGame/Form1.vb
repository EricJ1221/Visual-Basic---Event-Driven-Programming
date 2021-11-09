Option Strict On
'Eric Oliver
Public Class frmTTTG
    Public ply1, ply2 As String
    Dim gdecScore1, gdecScore2 As Integer

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lblPlayer1.Visible = True Then
            btn1.Text = "0"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn1.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn1.Enabled = False


    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblPlayer1.Visible = True Then
            btn2.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn2.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblPlayer1.Visible = True Then
            btn3.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn3.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblPlayer1.Visible = True Then
            btn4.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn4.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblPlayer1.Visible = True Then
            btn5.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn5.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblPlayer1.Visible = True Then
            btn6.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn6.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblPlayer1.Visible = True Then
            btn7.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn7.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblPlayer1.Visible = True Then
            btn8.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn8.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblPlayer1.Visible = True Then
            btn9.Text = "O"
            txt_chk()
            lblPlayer1.Visible = False
            lblPlayer2.Visible = True
            GoTo 50000
        End If
        If lblPlayer2.Visible = True Then
            btn9.Text = "X"
            txt_chk()
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
            GoTo 50000
        End If

50000:  btn9.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        btn1.Text = ""
        btn1.Enabled = True
        btn2.Text = ""
        btn2.Enabled = True
        btn3.Text = ""
        btn3.Enabled = True
        btn4.Text = ""
        btn4.Enabled = True
        btn5.Text = ""
        btn5.Enabled = True
        btn6.Text = ""
        btn6.Enabled = True
        btn7.Text = ""
        btn7.Enabled = True
        btn8.Text = ""
        btn8.Enabled = True
        btn9.Text = ""
        btn9.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Tic Tac Toe Game by Eric")
        ply1 = InputBox("Enter name of Player 1 ", "Name of Player 1")
        ply2 = InputBox("Enter name of Player 2 ", "Name of Player 2")
        If ply1 = "" Then
            ply1 = "Player 1"
            ply2 = "Player 2"
        End If
        lblPlayer1.Text = ply1 + lblPlayer1.Text
        lblPlayer2.Text = ply2 + lblPlayer2.Text
        lblPlayer1Score.Text = ply1 + lblPlayer1Score.Text
        lblPlayer2Score.Text = ply2 + lblPlayer2Score.Text
        lblPlayer2.Visible = False
        'gdecScore1 = 0
        'gdecScore2 = 0
    End Sub
    Private Sub txt_chk()
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            MsgBox("Congratulations " & ply2 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore2 += 1
            lblScore2.Text = CStr(gdecScore2)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            MsgBox("Congratulations " & ply1 & ", you win!", MsgBoxStyle.Information, "Win")
            gdecScore1 += 1
            lblScore1.Text = CStr(gdecScore1)
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        End If
    End Sub



End Class
