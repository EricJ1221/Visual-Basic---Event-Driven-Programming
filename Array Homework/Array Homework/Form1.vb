Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strMonth() As String = {"months"}
        Dim intMonthCount(11)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intTemp As Integer
        Dim intIndex As Integer
        Dim intPass As Integer
        Dim intTemperatures() As Integer = {100, 86, 77, 74, 77, 90, 99, 99, 32, 101, 56, 67, 77}
        For intIndex = 0 To intTemperatures.GetUpperBound(0)
            Console.WriteLine(intTemperatures(intIndex))
        Next

        Console.WriteLine("                             ")
        'sorting temps from lowest to highest

        'Console.WriteLine(IntTemperatures.Min)
        For intPass = 0 To intTemperatures.Length - 1
            For intIndex = 0 To intTemperatures.Length - 2
                If intTemperatures(intIndex) > intTemperatures(intIndex + 1) Then
                    intTemp = intTemperatures(intIndex)
                    intTemperatures(intIndex) = intTemperatures(intIndex + 1)
                    intTemperatures(intIndex + 1) = intTemp
                End If
            Next intIndex
        Next intPass

        For intIndex = 0 To intTemperatures.GetUpperBound(0)
                Console.WriteLine(intTemperatures(intIndex))
            Next
        Console.WriteLine("                             ")

        Dim intTemperatures2() As Integer = {100, 86, 77, 74, 77, 90, 99, 99, 32, 101, 56, 67, 77}
        'For intIndex = 0 To intTemperatures.GetUpperBound(0)
        '   Console.WriteLine(intTemperatures(intIndex))
        'Next

        Console.WriteLine("                             ")

        'Same thing as above, different index
        'sorting temps from lowest to highest
        Console.WriteLine(" with 1 instead of 0")
        For intPass = 1 To intTemperatures2.Length - 1
            For intIndex = 0 To intTemperatures2.Length - 2
                If intTemperatures2(intIndex) > intTemperatures2(intIndex + 1) Then
                    intTemp = intTemperatures2(intIndex)
                    intTemperatures2(intIndex) = intTemperatures2(intIndex + 1)
                    intTemperatures2(intIndex + 1) = intTemp
                End If
            Next intIndex
        Next intPass

        For intIndex = 0 To intTemperatures.GetUpperBound(0)
            Console.WriteLine(intTemperatures(intIndex))
        Next
    End Sub
End Class
