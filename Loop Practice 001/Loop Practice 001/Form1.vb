Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intIndex As Integer = 1 To 5 Step 1
            For countIndex As Integer = 1 To intIndex Step 1
                Console.WriteLine("CountIndex {1}", countIndex)
            Next intIndex

            For intIndex = 1 To 10
            Console.WriteLine("hi")
        Next

        'min-of-0 (pre-test)
        Dim intCounter As Integer = 5
        Do While intCounter < 10
            intCounter += 4
        Loop

    End Sub
End Class
