<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RNGGfrm
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
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.radIntermediate = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpboxDifficulty = New System.Windows.Forms.GroupBox()
        Me.lblGuessTheNumber = New System.Windows.Forms.Label()
        Me.grpboxDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(49, 46)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 17)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'radIntermediate
        '
        Me.radIntermediate.AutoSize = True
        Me.radIntermediate.Location = New System.Drawing.Point(49, 98)
        Me.radIntermediate.Name = "radIntermediate"
        Me.radIntermediate.Size = New System.Drawing.Size(83, 17)
        Me.radIntermediate.TabIndex = 1
        Me.radIntermediate.TabStop = True
        Me.radIntermediate.Text = "Intermediate"
        Me.radIntermediate.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(49, 150)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(48, 17)
        Me.radHard.TabIndex = 2
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(47, 400)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpboxDifficulty
        '
        Me.grpboxDifficulty.Controls.Add(Me.radIntermediate)
        Me.grpboxDifficulty.Controls.Add(Me.radEasy)
        Me.grpboxDifficulty.Controls.Add(Me.radHard)
        Me.grpboxDifficulty.Location = New System.Drawing.Point(71, 158)
        Me.grpboxDifficulty.Name = "grpboxDifficulty"
        Me.grpboxDifficulty.Size = New System.Drawing.Size(158, 210)
        Me.grpboxDifficulty.TabIndex = 6
        Me.grpboxDifficulty.TabStop = False
        Me.grpboxDifficulty.Text = "Choose Your Difficulty"
        '
        'lblGuessTheNumber
        '
        Me.lblGuessTheNumber.AutoSize = True
        Me.lblGuessTheNumber.Location = New System.Drawing.Point(99, 78)
        Me.lblGuessTheNumber.Name = "lblGuessTheNumber"
        Me.lblGuessTheNumber.Size = New System.Drawing.Size(95, 13)
        Me.lblGuessTheNumber.TabIndex = 3
        Me.lblGuessTheNumber.Text = "Guess the Number"
        '
        'RNGGfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 450)
        Me.Controls.Add(Me.lblGuessTheNumber)
        Me.Controls.Add(Me.grpboxDifficulty)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "RNGGfrm"
        Me.Text = "Random Number Guessing Game"
        Me.grpboxDifficulty.ResumeLayout(False)
        Me.grpboxDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radEasy As RadioButton
    Friend WithEvents radIntermediate As RadioButton
    Friend WithEvents radHard As RadioButton
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpboxDifficulty As GroupBox
    Friend WithEvents lblGuessTheNumber As Label
End Class
