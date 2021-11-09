Option Strict On
'Eric Oliver

Public Class frmCalendar
    Dim gintMonth(5, 6), intStartDay As Integer 'intStartDay is 0-6
    Dim gstrWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
    Private Sub btnLoadCalendar_Click(sender As Object, e As EventArgs) Handles btnLoadCalendar.Click

        Dim strWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        Dim intCounter As Integer = 1
        Dim strStartDay As String = txtStartDay.Text
        Dim intDay As Integer = 0
        Dim intNumOfDays As Integer = CInt(txtNumOfDays.Text)

        'convert 3 letter abbreviation for weekday to integer equivalent
        'intStartDay will hold an integer between 0-6 ... 1 is monday, 2 is tuesday
        For intIndex = 0 To strWeek.GetUpperBound(0)
            If strStartDay = strWeek(intIndex) Then
                intStartDay = intIndex
                Exit For
            End If
        Next

        'build the month
        For intRow = 0 To gintMonth.GetUpperBound(0)
            For intCol = 0 To gintMonth.GetUpperBound(1)
                If intRow = 0 Then 'month always starts on first row
                    If intCol = intStartDay Then 'StartDay is int  equivalent to the week day
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
                If intDay > intNumOfDays Then
                    intDay = 0
                End If
            Next
        Next
    End Sub

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
End Class
