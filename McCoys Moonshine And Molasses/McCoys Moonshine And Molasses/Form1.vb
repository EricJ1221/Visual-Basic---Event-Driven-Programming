Option Strict On
'Eric Oliver

Public Class frmMMAM
    Dim gdecHatfield, gdecPints, gdecMoonnshinePint, gdecMolly, gdecUntaxableIncome As Decimal
    Private Sub frmMcCoysMoonshineAndMolasses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmMcCoysMoonshineAndMolasses_Load")
        txtBoxPints.Text = "0"
        txtBoxMoonshinePint.Text = "0.00"
        txtBoxUntaxableIncome.Text = "$0.00"
        subReset()
    End Sub

    Private Sub txtBoxPints_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPints.TextChanged
        If txtBoxPints.Focused Then
            gdecPints = CDec("0" & Format(txtBoxPints.Text, "Standard"))
            subCalcUntaxableIncome()
        End If
    End Sub

    Private Sub txtBoxMoonshinePint_TextChanged(sender As Object, e As EventArgs) Handles txtBoxMoonshinePint.TextChanged
        If txtBoxMoonshinePint.Focused Then
            gdecMoonnshinePint = CDec("0" & Format(txtBoxMoonshinePint.Text, "Currency"))
            subCalcUntaxableIncome()
        End If
    End Sub

    Private Sub radButtonLight_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonLight.CheckedChanged
        Console.WriteLine("radButtonLight_CheckedChanged")
        If radButtonLight.Checked Then
            gdecMolly = 1
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub radButtonMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonMedium.CheckedChanged
        Console.WriteLine("radButtonMedium_CheckedChanged")
        If radButtonMedium.Checked Then
            gdecMolly = 2
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub radButtonDark_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonDark.CheckedChanged
        Console.WriteLine("radButtonDark_CheckedChanged")
        If radButtonDark.Checked Then
            gdecMolly = 3
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub chkBoxHatfield_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxHatfield.CheckedChanged
        Console.WriteLine("chkBoxHatfield_CheckedChanged")
        If chkBoxHatfield.Checked Then
            gdecHatfield = 100
        Else
            gdecHatfield = 1
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub txtBoxUntaxableIncome_TextChanged(sender As Object, e As EventArgs) Handles txtBoxUntaxableIncome.TextChanged
        Console.WriteLine("txtBoxUntaxableIncome_TextChanged")
        gdecUntaxableIncome = CDec("0" & Format(txtBoxUntaxableIncome.Text, "Standard"))
        subCalcUntaxableIncome()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Console.WriteLine("btnReset_Click")
        subReset()
    End Sub

    Private Sub subCalcUntaxableIncome()
        Console.WriteLine("subCalcUntaxableIncome")
        txtBoxUntaxableIncome.Text = Format((gdecPints * (gdecMoonnshinePint + gdecMolly) * gdecHatfield), "Currency")
    End Sub

    Private Sub subReset()
        Console.WriteLine("subReset")
        txtBoxPints.Focus()
        txtBoxPints.Text = "0"
        txtBoxMoonshinePint.Text = "$0.00"
        gdecHatfield = 1
        txtBoxPints.SelectAll()


        radButtonLight.Checked = False
        radButtonLight.TabStop = True

        radButtonMedium.Checked = False
        radButtonMedium.TabStop = True

        radButtonDark.Checked = False
        radButtonDark.TabStop = True



    End Sub

    Private Sub txtBoxPints_LostFocus(sender As Object, e As EventArgs) Handles txtBoxPints.LostFocus
        Console.WriteLine("txtBoxpints_LostFocus")
        txtBoxPints.Text = Format(txtBoxPints.Text, "Standard")
    End Sub

    Private Sub txtBoxMoonshinePint_LostFocus(sender As Object, e As EventArgs) Handles txtBoxMoonshinePint.LostFocus
        Console.WriteLine("txtBoxMoonshinePint_LostFocus")
        txtBoxMoonshinePint.Text = Format(txtBoxMoonshinePint.Text, "Currency")
    End Sub
End Class
