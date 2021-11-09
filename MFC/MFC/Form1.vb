Option Strict On
'Eric Oliver

Public Class frmMFC
    Dim gdecMembership, gdecYoga, gdecKarate, gdecTrainer, gdecMonthlyFee As Decimal
    Dim gintMonths As Integer
    Private Sub radStandardAdult_CheckedChanged(sender As Object, e As EventArgs) Handles radStandardAdult.CheckedChanged
        Console.WriteLine("radStandardAdult_CheckedChanged")
        If radStandardAdult.Checked Then
            gdecMembership = 40
        End If
    End Sub

    Private Sub radChild_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged
        Console.WriteLine("radChild_CheckedChanged")
        If radChild.Checked Then
            gdecMembership = 20
        End If
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        Console.WriteLine("radStudent_CheckedChanged")
        If radStudent.Checked Then
            gdecMembership = 25
        End If
    End Sub

    Private Sub radSeniorCitizen_CheckedChanged(sender As Object, e As EventArgs) Handles radSeniorCitizen.CheckedChanged
        Console.WriteLine("radSeniorCitizen_CheckedChanged")
        If radSeniorCitizen.Checked Then
            gdecMembership = 30
        End If
    End Sub

    Private Sub txtNumberOfMonths_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfMonths.TextChanged
        Console.WriteLine("txtNumberOfMonths_TextChanged")
        If Integer.TryParse(txtNumberOfMonths.Text, gintMonths) = False Then
            'not an integer
            lblStatus.Text = "Months must be an interger."
            btnCalculate.Enabled = False
        ElseIf gintMonths < 1 OrElse gintMonths > 24 Then
            'is an integer but no in range
            lblStatus.Text = "Months must be in the range of 1-24."
            btnCalculate.Enabled = False
        Else
            'is an integer and in range
            lblStatus.Text = String.Empty
            btnCalculate.Enabled = True

        End If

    End Sub

    Private Sub chkYoga_CheckedChanged(sender As Object, e As EventArgs) Handles chkYoga.CheckedChanged
        Console.WriteLine("chkYoga_CheckedChanged")
        If chkYoga.Checked Then
            gdecYoga = 10
        Else
            gdecYoga = 0
        End If
    End Sub

    Private Sub chkKarate_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged
        Console.WriteLine("chkKarate_CheckedChanged")
        If chkKarate.Checked Then
            gdecKarate = 30
        Else
            gdecKarate = 0
        End If
    End Sub

    Private Sub chkPersonalTrainer_CheckedChanged(sender As Object, e As EventArgs) Handles chkPersonalTrainer.CheckedChanged
        Console.WriteLine("chkPersonalTrainer_CheckedChanged")
        If chkPersonalTrainer.Checked Then
            gdecTrainer = 50
        Else
            gdecTrainer = 0
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Console.WriteLine("btnExit_Click")
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Console.WriteLine("btnCalculate_Click")
        gdecMonthlyFee = gdecMembership + gdecYoga + gdecKarate + gdecTrainer
        txtMonthlyFee.Text = Format(gdecMonthlyFee, "Currency")
        txtTotal.Text = Format(gdecMonthlyFee * gintMonths, "Currency")
    End Sub

    Private Sub subReset()
        Console.WriteLine("subReset")
        radStandardAdult.Checked = True
        chkKarate.Checked = False
        chkPersonalTrainer.Checked = False
        chkYoga.Checked = False
        txtNumberOfMonths.Focus()
        btnCalculate.Enabled = False
        lblStatus.Text = "Months must be an integer in the range 1-24."
        txtMonthlyFee.Text = String.Empty
        txtTotal.Text = String.Empty

    End Sub

    Private Sub frmMFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmMFC_Load")
        subReset()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Console.WriteLine("btnClear_Click")
        subReset()
    End Sub

End Class
