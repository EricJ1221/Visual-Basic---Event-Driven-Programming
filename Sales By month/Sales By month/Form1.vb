Option Strict On
'Eric Oliver
Imports System.IO
Public Class frmSBM
    Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
    Dim intMonthCount(11) As Integer
    Dim decMonthSum(11) As Decimal
    Dim fsrFile As StreamReader = New StreamReader("SalesByMonth.csv")
    Dim strLine, strSplitLine(0) As String

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Do
            strLine = fsrFile.ReadLine()
            strSplitLine = Split(strLine, ",")


            For intIndex = 0 To strMonth.GetUpperBound(0)
                If strSplitLine(0) = strMonth(intIndex) Then
                    intMonthCount(intIndex) += 1
                    decMonthSum(intIndex) += CDec(strSplitLine(1))
                    Exit For
                End If
            Next

        Loop Until fsrFile.EndOfStream


        If cmbBox1.SelectedIndex = 0 Then


            For intIndex = cmbBox2.SelectedIndex To strMonth.GetUpperBound(0)
                Console.WriteLine("{0}: {1}", strMonth(intIndex), decMonthSum(intIndex))
            Next
            For intIndex = 0 To cmbBox2.SelectedIndex - 1
                Console.WriteLine("{0}: {1}", strMonth(intIndex), decMonthSum(intIndex))
            Next
        End If
        Console.WriteLine(" ")


        If cmbBox1.SelectedIndex = 1 Then


            For intIndex = cmbBox2.SelectedIndex To strMonth.GetUpperBound(0)
                Console.WriteLine("{0}: {1}", strMonth(intIndex), intMonthCount(intIndex))
            Next
            For intIndex = 0 To cmbBox2.SelectedIndex - 1
                Console.WriteLine("{0}: {1}", strMonth(intIndex), intMonthCount(intIndex))
            Next
            Console.WriteLine(" ")
        End If
        Console.WriteLine(" ")

        If cmbBox1.SelectedIndex = -1 Then
            cmbBox1.SelectedIndex = 0
            cmbBox2.SelectedIndex = 0

            For intIndex = cmbBox2.SelectedIndex To strMonth.GetUpperBound(0)
                Console.WriteLine("{0}: {1}", strMonth(intIndex), decMonthSum(intIndex))
            Next
            For intIndex = 0 To cmbBox2.SelectedIndex - 1
                Console.WriteLine("{0}: {1}", strMonth(intIndex), decMonthSum(intIndex))
            Next
        End If
        Console.WriteLine(" ")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbBox1.SelectedIndex = -1
        cmbBox2.SelectedIndex = -1
        Dim intMonthCountReset(11) As Integer

        If cmbBox1.SelectedIndex = -1 Then
            cmbBox2.SelectedIndex = 0
            For intIndex = cmbBox2.SelectedIndex To strMonth.GetUpperBound(0)
                Console.WriteLine("{0}: {1}", strMonth(intIndex), intMonthCountReset(intIndex))
            Next
        End If
        cmbBox1.SelectedIndex = -1
        Console.WriteLine(" ")
    End Sub
End Class
