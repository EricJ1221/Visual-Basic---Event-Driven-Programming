﻿Option Strict On
'Eric Oliver
Public Class frmSSTC
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtTaxDue.Text = Format(CDec(txtSales.Text) * nudTaxRate.Value * 0.01, "Currency")
        txtSales.Text = Format(txtSales.Text, "Standard")
        txtSales.Focus()
        txtSales.SelectAll()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSales.Text = "0.00"
        nudTaxRate.Value = CDec(8.25)
        txtTaxDue.Text = "$0.00"
        txtSales.Focus()
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_LostFocus(sender As Object, e As EventArgs) Handles txtSales.LostFocus
        txtSales.Text = Format(txtSales.Text, "Standard")
    End Sub
End Class
