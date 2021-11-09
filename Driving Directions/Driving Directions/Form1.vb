Option Strict On
'Eric Oliver
Public Class drivingDirections
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles hiddenDrivingDirections.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        ''''hiddenDrivingDirections.Visible = True
        ''''btnShowHide.Text = "Hide Directions"
        '''
        If hiddenDrivingDirections.Visible = True Then
            hiddenDrivingDirections.Visible = False
            btnShowHide.Text = "Show directions"
        Else
            hiddenDrivingDirections.Visible = True
            btnShowHide.Text = "Hide Directions"
        End If

    End Sub
End Class
