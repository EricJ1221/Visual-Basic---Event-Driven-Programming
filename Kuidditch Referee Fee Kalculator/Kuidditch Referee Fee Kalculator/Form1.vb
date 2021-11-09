Option Strict On
'Eric Oliver
Public Class frmKuidditchRefereeFeeKalculator
    Dim gdecNumOfGames, gdecCostPerGame, gdecCertified, gdecRadButton As Decimal

    Private Sub chkBoxCertified_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxCertified.CheckedChanged
        Console.WriteLine("chkBoxCertified_CheckedChanged")
        If chkBoxCertified.Checked Then
            gdecCertified = 10
        Else
            gdecCertified = 0
        End If
        subCalcTotalDue()
    End Sub
    Private Sub radBtnRecreational_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnRecreational.CheckedChanged
        Console.WriteLine("radBtnRecreational_CheckedChanged")
        If radbtnRecreational.Checked Then
            gdecRadButton = 1
        End If
        subCalcTotalDue()
    End Sub

    Private Sub radbtnCompetitive_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnCompetitive.CheckedChanged
        Console.WriteLine("radbtnCompetitive_CheckedChanged")
        If radbtnCompetitive.Checked Then
            gdecRadButton = 2
        End If
        subCalcTotalDue()
    End Sub

    Private Sub radbtnInternational_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnInternational.CheckedChanged
        Console.WriteLine("radbtnInternational_CheckedChanged")
        If radbtnInternational.Checked Then
            gdecRadButton = 3
        End If
        subCalcTotalDue()
    End Sub

    Private Sub txtBoxNumOfGames_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNumOfGames.TextChanged
        If txtBoxNumOfGames.Focused Then
            gdecNumOfGames = CDec("0" & Format(txtBoxNumOfGames.Text, "Standard"))
            subCalcTotalDue()
        End If
    End Sub

    Private Sub frmKuidditchRefereeFeeKalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmKuidditchRefereeFeeKalculator_Load")
        txtBoxCostPerGame.Text = "$0.00"
        txtBoxNumOfGames.Text = "0"
        txtBoxTotalDue.Text = "$0.00"
        subReset()
    End Sub

    Private Sub txtBoxCostPerGame_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCostPerGame.TextChanged
        Console.WriteLine("txtBoxCostPerGame_TextChanged NOT FOCUSED")
        If txtBoxCostPerGame.Focused Then
            Console.WriteLine("txtBoxCostPerGame_TextChanged FOCUSED")
            gdecCostPerGame = CDec("0" & Format(txtBoxCostPerGame.Text, "Standard"))
            subCalcTotalDue()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Console.WriteLine("btnReset_Click")
        subReset()
    End Sub

    Private Sub subCalcTotalDue()
        Console.WriteLine("subCalcTotalDue")
        txtBoxTotalDue.Text = Format((gdecNumOfGames * (gdecCostPerGame + gdecRadButton)) + gdecCertified, "Currency")
    End Sub

    Private Sub subReset()
        Console.WriteLine("subReset")
        txtBoxNumOfGames.Focus()
        txtBoxNumOfGames.Text = "0"
        txtBoxCostPerGame.Text = "$0.00"
        gdecRadButton = 0
        txtBoxNumOfGames.SelectAll()
        chkBoxCertified.Checked = False

        radbtnRecreational.Checked = False
        radbtnRecreational.TabStop = True

        radbtnInternational.Checked = False
        radbtnInternational.TabStop = True

        radbtnCompetitive.Checked = False
        radbtnCompetitive.TabStop = True
    End Sub

    Private Sub txtBoxNumOfGames_LostFocus(sender As Object, e As EventArgs) Handles txtBoxNumOfGames.LostFocus
        Console.WriteLine("txtBoxNumOfGames_LostFocus")
        txtBoxNumOfGames.Text = Format(txtBoxNumOfGames.Text, "Standard")
    End Sub

    Private Sub txtBoxCostPerGame_LostFocus(sender As Object, e As EventArgs) Handles txtBoxCostPerGame.LostFocus
        Console.WriteLine("txtBoxCostPerGame_LostFocus")
        txtBoxCostPerGame.Text = Format(txtBoxCostPerGame.Text, "Currency")
    End Sub
End Class
