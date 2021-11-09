Option Strict On
'Eric Oliver

Public Class frmWHDSJ
    Dim gdecQuantity, gdecTotal, gdecTendered, gdecChangeDue, gdecFood, gdecCoffee As Decimal

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        Console.WriteLine("txtTendered_TextChanged_TextChanged NOT FOCUSED")
        If txtTendered.Focused Then
            Console.WriteLine("txtTendered_TextChanged_TextChanged FOCUSED")
            gdecTendered = CDec("0" & Format(txtTendered.Text, "Standard"))
            subCalcChangeDue()
            subCalcTotal()
        End If
    End Sub

    Private Sub chkCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoffee.CheckedChanged
        Console.WriteLine("chkCoffee_CheckedChanged")
        If chkCoffee.Checked Then
            gdecCoffee = 4
            subCalcTotal()
            subCalcChangeDue()
        Else
            gdecCoffee = 0
            subCalcTotal()
            subCalcChangeDue()
        End If
    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        Console.WriteLine("nudQuantity_ValueChanged")
        subCalcTotal()
        subCalcChangeDue()
    End Sub

    Private Sub frmWHDSJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmWHDSJ_Load")
        txtTotal.Text = "$0.00"
        txtTendered.Text = "$0.00"
        txtChangeDue.Text = "$0.00"
        chkCoffee.Checked = False
        radGlazed.Checked = True
        nudQuantity.Value = 0
        nudQuantity.Select()
        subReset()
    End Sub

    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged
        Console.WriteLine("radGlazed_CheckedChanged")
        If radGlazed.Checked Then
            gdecFood = 1
            subCalcTotal()
            subCalcChangeDue()
        End If
    End Sub

    Private Sub radSprinkles_CheckedChanged(sender As Object, e As EventArgs) Handles radSprinkles.CheckedChanged
        Console.WriteLine("radSprinkles_CheckedChanged")
        If radSprinkles.Checked Then
            gdecFood = 2
            subCalcTotal()
            subCalcChangeDue()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub radCake_CheckedChanged(sender As Object, e As EventArgs) Handles radCake.CheckedChanged
        Console.WriteLine("radCake_CheckedChanged")
        If radCake.Checked Then
            gdecFood = 3
            subCalcTotal()
            subCalcChangeDue()
        End If
    End Sub

    Private Sub subReset()
        Console.WriteLine("subReset")
        nudQuantity.Focus()
        txtTotal.Text = "$0.00"
        txtTendered.Text = "$0.00"
        txtChangeDue.Text = "$0.00"
        chkCoffee.Checked = False
        radGlazed.Checked = True
        nudQuantity.Value = 0
        nudQuantity.Select()
    End Sub
    Private Sub subCalcTotal()
        Console.WriteLine("subCalcTotal")
        gdecTotal = ((nudQuantity.Value * (gdecFood + gdecCoffee)))
        txtTotal.Text = Format(gdecTotal, "Currency")
    End Sub

    Private Sub subCalcChangeDue()
        Console.WriteLine("subCalcChangeDue")
        txtChangeDue.Text = FormatCurrency(gdecTendered - gdecTotal)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Console.WriteLine("btnReset_Click")
        subReset()
    End Sub

    Private Sub txtTendered_LostFocus(sender As Object, e As EventArgs) Handles txtTendered.LostFocus
        Console.WriteLine("txtTendered_LostFocus")
        txtTendered.Text = Format(txtTendered.Text, "Currency")
    End Sub
End Class
