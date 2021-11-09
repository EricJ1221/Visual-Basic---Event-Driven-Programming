<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.txtPlayer1Wins = New System.Windows.Forms.TextBox()
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtPlayer2Wins = New System.Windows.Forms.TextBox()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.txtRoundCount = New System.Windows.Forms.TextBox()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(24, 86)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(45, 13)
        Me.lblPlayer1.TabIndex = 0
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(24, 124)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(45, 13)
        Me.lblPlayer2.TabIndex = 1
        Me.lblPlayer2.Text = "Player 2"
        '
        'txtPlayer1Wins
        '
        Me.txtPlayer1Wins.Location = New System.Drawing.Point(242, 55)
        Me.txtPlayer1Wins.Name = "txtPlayer1Wins"
        Me.txtPlayer1Wins.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer1Wins.TabIndex = 2
        Me.txtPlayer1Wins.Text = "0"
        Me.txtPlayer1Wins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(80, 86)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer1.TabIndex = 3
        Me.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(80, 124)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer2.TabIndex = 4
        Me.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlayer2Wins
        '
        Me.txtPlayer2Wins.Location = New System.Drawing.Point(242, 81)
        Me.txtPlayer2Wins.Name = "txtPlayer2Wins"
        Me.txtPlayer2Wins.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer2Wins.TabIndex = 5
        Me.txtPlayer2Wins.Text = "0"
        Me.txtPlayer2Wins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(270, 29)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(31, 13)
        Me.lblWins.TabIndex = 6
        Me.lblWins.Text = "Wins"
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Location = New System.Drawing.Point(12, 29)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(39, 13)
        Me.lblRound.TabIndex = 7
        Me.lblRound.Text = "Round"
        '
        'txtRoundCount
        '
        Me.txtRoundCount.Enabled = False
        Me.txtRoundCount.Location = New System.Drawing.Point(80, 26)
        Me.txtRoundCount.Name = "txtRoundCount"
        Me.txtRoundCount.Size = New System.Drawing.Size(100, 20)
        Me.txtRoundCount.TabIndex = 8
        Me.txtRoundCount.Text = "0"
        Me.txtRoundCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(94, 161)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(75, 23)
        Me.btnFight.TabIndex = 9
        Me.btnFight.Text = "Fight"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Location = New System.Drawing.Point(349, 58)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(20, 13)
        Me.lblP1.TabIndex = 10
        Me.lblP1.Text = "P1"
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Location = New System.Drawing.Point(349, 86)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(20, 13)
        Me.lblP2.TabIndex = 11
        Me.lblP2.Text = "P2"
        '
        'frmRPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 224)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.txtRoundCount)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.txtPlayer2Wins)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.txtPlayer1Wins)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Name = "frmRPS"
        Me.ShowIcon = False
        Me.Text = " RPS Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents txtPlayer1Wins As TextBox
    Friend WithEvents txtPlayer1 As TextBox
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents txtPlayer2Wins As TextBox
    Friend WithEvents lblWins As Label
    Friend WithEvents lblRound As Label
    Friend WithEvents txtRoundCount As TextBox
    Friend WithEvents btnFight As Button
    Friend WithEvents lblP1 As Label
    Friend WithEvents lblP2 As Label
End Class
