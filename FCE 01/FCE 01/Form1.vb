Option Strict On
'Eric Oliver
Public Class frmFCE
    Dim gdecDollars, gdecExchangeValue, gdecStability As Decimal

    Private Sub subReset()
        txtDollars.Focus()
        txtDollars.Text = "$0.00"
        txtExchangeValue.Text = "$0.00"
        txtCommission.Text = "$0.00"
        radGood.Checked = True
        nudExchangeRate.Value = 1
        txtDollars.SelectAll()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub

    Private Sub frmFCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDollars.TextAlign = HorizontalAlignment.Right
        txtCommission.TextAlign = HorizontalAlignment.Right
        txtExchangeValue.TextAlign = HorizontalAlignment.Right
        nudExchangeRate.TextAlign = HorizontalAlignment.Right
        nudExchangeRate.DecimalPlaces = 2
        nudExchangeRate.Minimum = 0.5D
        nudExchangeRate.Maximum = 1.5D
        nudExchangeRate.Increment = 0.01D
        Me.CancelButton = btnReset
        subReset()
    End Sub

    Private Sub nudExchangeRate_ValueChanged(sender As Object, e As EventArgs) Handles nudExchangeRate.ValueChanged
        subCalcExchangeValue()
    End Sub

    Private Sub radGood_CheckedChanged(sender As Object, e As EventArgs) Handles radGood.CheckedChanged
        If radGood.Checked Then
            gdecStability = 0.01D
            subCalcCommission()
        End If
    End Sub

    Private Sub radModerate_CheckedChanged(sender As Object, e As EventArgs) Handles radModerate.CheckedChanged
        If radModerate.Checked Then
            gdecStability = 0.02D
            subCalcCommission()
        End If
    End Sub

    Private Sub radPoor_CheckedChanged(sender As Object, e As EventArgs) Handles radPoor.CheckedChanged
        If radPoor.Checked Then
            gdecStability = 0.03D
            subCalcCommission()
        End If
    End Sub

    Private Sub txtDollars_TextChanged(sender As Object, e As EventArgs) Handles txtDollars.TextChanged
        If txtDollars.Focused Then
            gdecDollars = CDec("0" & Format(txtDollars.Text, "Standard"))
            subCalcExchangeValue()
        End If
    End Sub

    Private Sub subCalcExchangeValue()
        gdecExchangeValue = Math.Round(gdecDollars * nudExchangeRate.Value, 2, MidpointRounding.AwayFromZero)
        txtExchangeValue.Text = Format(gdecExchangeValue, "Currency")
        txtCommission.Text = FormatCurrency(gdecExchangeValue * gdecStability)
    End Sub

    Private Sub subCalcCommission()
        txtCommission.Text = FormatCurrency(gdecExchangeValue * gdecStability)
    End Sub
End Class
