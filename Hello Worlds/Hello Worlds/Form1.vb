Option Strict On
'Eric Oliver
'1. button click
'2. textbox text change
'3. checkbox
'4. domain up down
'5. radio buttom
Public Class frmHelloWorlds
    Private Sub buttonClick_Click(sender As Object, e As EventArgs) Handles buttonClick.Click
        Console.WriteLine("Hello_World"
                          )

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged
        Console.WriteLine("Hello_World"
                          )
    End Sub

    Private Sub chkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox1.CheckedChanged
        Console.WriteLine("Hello_World"
                          )
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Console.WriteLine("Hello_World"
                          )
    End Sub

    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton1.CheckedChanged
        Console.WriteLine("Hello_World"
                          )
    End Sub
End Class
