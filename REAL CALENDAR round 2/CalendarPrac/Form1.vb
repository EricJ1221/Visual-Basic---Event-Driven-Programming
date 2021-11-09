Option Strict On
'Eric Oliver

Public Class frmCalendar
    Dim gintMonth(5, 6) As Integer 'intStartDay is 0-6
    Dim gstrWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'print the calendar
        For intIndex = 0 To gstrWeek.GetUpperBound(0)
            Console.Write("{0,4}", gstrWeek(intIndex))
        Next
        Console.WriteLine()

        For intRow = 0 To gintMonth.GetUpperBound(0)
            For intCol = 0 To gintMonth.GetUpperBound(1)
                '3:# modifier will not print out non zeros
                Console.Write("{0,4:#}", gintMonth(intRow, intCol))
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim strWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intCounter As Integer = 1
        Dim strStartDay As String = txtStartDay.Text
        Dim intDay As Integer = 0
        'Dim intNumOfDays As Integer = CInt(txtNumOfDays.Text)
        Dim intYear As Integer = CInt(txtYear.Text)
        Dim intBeginningOfMonth As Integer = 0
        Dim intDayCount As Integer = 0

        If intYear Mod 4 = 0 Then
            intDaysInMonth(1) = 29
        Else
            intDaysInMonth(1) = 28
        End If

        Dim intMax As Integer = intDaysInMonth(cmbMonth.SelectedIndex)
        'add up number of days leading to (not including) the month they want to print
        For intIndex = 0 To cmbMonth.SelectedIndex - 1
            intDayCount += intDaysInMonth(intIndex)
        Next

        'This will determine what day of the week the year starts on
        'intDayCount is the sum of all the days in the months leading up to the month they are looking for
        intBeginningOfMonth = CInt(Int((intYear - 1901) * 365.25 + 2.0) + intDayCount) Mod 7

        For intRow = 0 To gintMonth.GetUpperBound(0)
            For intCol = 0 To gintMonth.GetUpperBound(1)
                'intMonth(intRow, intCol) = intCounter
                'intCounter += 1
                If intRow = 0 Then 'month always starts on first row
                    If intCol = intBeginningOfMonth Then 'StartDay is int  equivalent to the week day
                        intDay = 1
                    End If
                End If
                'put the day value into the array
                gintMonth(intRow, intCol) = intDay
                'only increment the day after the month has started
                If intDay > 0 Then
                    intDay += 1
                End If
                'reset the day when past number of days in month
                If intDay > intMax Then
                    intDay = 0
                End If
            Next
        Next
        'print the calendar
        For intIndex = 0 To gstrWeek.GetUpperBound(0)
            Console.Write("{0,4}", gstrWeek(intIndex))
        Next
        Console.WriteLine()

        For intRow = 0 To gintMonth.GetUpperBound(0)
            For intCol = 0 To gintMonth.GetUpperBound(1)
                '3:# modifier will not print out non zeros
                Console.Write("{0,4:#}", gintMonth(intRow, intCol))
            Next
            Console.WriteLine()
        Next


    End Sub
End Class
