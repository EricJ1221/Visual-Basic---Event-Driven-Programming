Option Strict On
'Eric Oliver

Public Class frmSSTC
    Dim gdecGrossSales, gdecNetSales, gdecMembership, gdecTaxRate As Decimal

    Private Sub txtGrossSales_TextChanged(sender As Object, e As EventArgs) Handles txtGrossSales.TextChanged
        Console.WriteLine("txtGrossSales_TextChanged NOT FOCUSED")
        If txtGrossSales.Focused Then
            Console.WriteLine("txtGrossSales_TextChanged FOCUSED")
            gdecGrossSales = CDec("0" & Format(txtGrossSales.Text, "Standard"))
            subCalcNetSales()
        End If

    End Sub

    Private Sub frmSSTC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("frmSSTC_Load")
        txtNetSales.Text = "$0.00"
        subReset()
    End Sub

    Private Sub chkClubMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkClubMember.CheckedChanged
        Console.WriteLine("chkClubMember_CheckedChanged")
        If chkClubMember.Checked Then
            gdecMembership = 0.95D
        Else
            gdecMembership = 1
        End If
        subCalcNetSales()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Console.WriteLine("btnReset_Click")
        subReset()
    End Sub

    Private Sub radNacogdoches_CheckedChanged(sender As Object, e As EventArgs) Handles radNacogdoches.CheckedChanged
        Console.WriteLine("radNacogdoches_CheckedChanged")
        If radNacogdoches.Checked Then
            gdecTaxRate = 0.0825D
        End If
        subCalcSalesTax()
    End Sub

    Private Sub radDouglass_CheckedChanged(sender As Object, e As EventArgs) Handles radDouglass.CheckedChanged
        Console.WriteLine("radDouglass_CheckedChanged")
        If radDouglass.Checked Then
            gdecTaxRate = 0.0725D
        End If
        subCalcSalesTax()
    End Sub

    Private Sub subCalcNetSales()
        Console.WriteLine("subCalcNetSales")
        gdecNetSales = gdecGrossSales * gdecMembership
        txtNetSales.Text = Format(gdecNetSales, "Currency")
        subCalcSalesTax()
    End Sub

    Private Sub grpbxCity_Enter(sender As Object, e As EventArgs) Handles grpbxCity.Enter

    End Sub

    Private Sub subReset()
        Console.WriteLine("subReset")
        txtGrossSales.Focus()
        txtGrossSales.Text = "$0.00"
        chkClubMember.Checked = False
        radNacogdoches.Checked = True
        txtGrossSales.SelectAll()
        gdecMembership = 1

    End Sub

    Private Sub subCalcSalesTax()
        Console.WriteLine("subCalcSalesTax")
        txtSalesTax.Text = Format(gdecNetSales * gdecTaxRate, "Currency")
    End Sub

    Private Sub txtGrossSales_LostFocus(sender As Object, e As EventArgs) Handles txtGrossSales.LostFocus
        Console.WriteLine("txtGrossSales_LostFocus")
        txtGrossSales.Text = Format(txtGrossSales.Text, "Currency")
    End Sub
End Class
