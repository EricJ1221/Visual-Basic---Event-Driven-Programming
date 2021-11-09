<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKuidditchRefereeFeeKalculator
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
        Me.chkBoxCertified = New System.Windows.Forms.CheckBox()
        Me.radbtnRecreational = New System.Windows.Forms.RadioButton()
        Me.radbtnCompetitive = New System.Windows.Forms.RadioButton()
        Me.radbtnInternational = New System.Windows.Forms.RadioButton()
        Me.txtBoxNumOfGames = New System.Windows.Forms.TextBox()
        Me.txtBoxCostPerGame = New System.Windows.Forms.TextBox()
        Me.txtBoxTotalDue = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblNumOfGames = New System.Windows.Forms.Label()
        Me.lblCostPerGame = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBoxCertified
        '
        Me.chkBoxCertified.AutoSize = True
        Me.chkBoxCertified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBoxCertified.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBoxCertified.Location = New System.Drawing.Point(222, 108)
        Me.chkBoxCertified.Name = "chkBoxCertified"
        Me.chkBoxCertified.Size = New System.Drawing.Size(64, 17)
        Me.chkBoxCertified.TabIndex = 2
        Me.chkBoxCertified.Text = "Certified"
        Me.chkBoxCertified.UseVisualStyleBackColor = True
        '
        'radbtnRecreational
        '
        Me.radbtnRecreational.AutoSize = True
        Me.radbtnRecreational.Location = New System.Drawing.Point(54, 27)
        Me.radbtnRecreational.Name = "radbtnRecreational"
        Me.radbtnRecreational.Size = New System.Drawing.Size(100, 17)
        Me.radbtnRecreational.TabIndex = 1
        Me.radbtnRecreational.TabStop = True
        Me.radbtnRecreational.Text = "8 (Recreational)"
        Me.radbtnRecreational.UseVisualStyleBackColor = True
        '
        'radbtnCompetitive
        '
        Me.radbtnCompetitive.AutoSize = True
        Me.radbtnCompetitive.Location = New System.Drawing.Point(54, 66)
        Me.radbtnCompetitive.Name = "radbtnCompetitive"
        Me.radbtnCompetitive.Size = New System.Drawing.Size(95, 17)
        Me.radbtnCompetitive.TabIndex = 2
        Me.radbtnCompetitive.TabStop = True
        Me.radbtnCompetitive.Text = "7 (Competitive)"
        Me.radbtnCompetitive.UseVisualStyleBackColor = True
        '
        'radbtnInternational
        '
        Me.radbtnInternational.AutoSize = True
        Me.radbtnInternational.Location = New System.Drawing.Point(54, 105)
        Me.radbtnInternational.Name = "radbtnInternational"
        Me.radbtnInternational.Size = New System.Drawing.Size(98, 17)
        Me.radbtnInternational.TabIndex = 3
        Me.radbtnInternational.TabStop = True
        Me.radbtnInternational.Text = "6 (International)"
        Me.radbtnInternational.UseVisualStyleBackColor = True
        '
        'txtBoxNumOfGames
        '
        Me.txtBoxNumOfGames.Location = New System.Drawing.Point(159, 55)
        Me.txtBoxNumOfGames.Name = "txtBoxNumOfGames"
        Me.txtBoxNumOfGames.Size = New System.Drawing.Size(72, 20)
        Me.txtBoxNumOfGames.TabIndex = 0
        Me.txtBoxNumOfGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxCostPerGame
        '
        Me.txtBoxCostPerGame.Location = New System.Drawing.Point(348, 55)
        Me.txtBoxCostPerGame.Name = "txtBoxCostPerGame"
        Me.txtBoxCostPerGame.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCostPerGame.TabIndex = 1
        Me.txtBoxCostPerGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxTotalDue
        '
        Me.txtBoxTotalDue.Location = New System.Drawing.Point(281, 324)
        Me.txtBoxTotalDue.Name = "txtBoxTotalDue"
        Me.txtBoxTotalDue.ReadOnly = True
        Me.txtBoxTotalDue.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotalDue.TabIndex = 6
        Me.txtBoxTotalDue.TabStop = False
        Me.txtBoxTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(213, 394)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblNumOfGames
        '
        Me.lblNumOfGames.AutoSize = True
        Me.lblNumOfGames.Location = New System.Drawing.Point(88, 55)
        Me.lblNumOfGames.Name = "lblNumOfGames"
        Me.lblNumOfGames.Size = New System.Drawing.Size(65, 13)
        Me.lblNumOfGames.TabIndex = 8
        Me.lblNumOfGames.Text = "# of &Games:"
        '
        'lblCostPerGame
        '
        Me.lblCostPerGame.AutoSize = True
        Me.lblCostPerGame.Location = New System.Drawing.Point(264, 55)
        Me.lblCostPerGame.Name = "lblCostPerGame"
        Me.lblCostPerGame.Size = New System.Drawing.Size(81, 13)
        Me.lblCostPerGame.TabIndex = 9
        Me.lblCostPerGame.Text = "&Cost Per Game:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(135, 327)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDue.TabIndex = 10
        Me.lblTotalDue.Text = "Total Due:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbtnCompetitive)
        Me.GroupBox1.Controls.Add(Me.radbtnRecreational)
        Me.GroupBox1.Controls.Add(Me.radbtnInternational)
        Me.GroupBox1.Location = New System.Drawing.Point(159, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 144)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade"
        '
        'frmKuidditchRefereeFeeKalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(507, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblCostPerGame)
        Me.Controls.Add(Me.lblNumOfGames)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtBoxTotalDue)
        Me.Controls.Add(Me.txtBoxCostPerGame)
        Me.Controls.Add(Me.txtBoxNumOfGames)
        Me.Controls.Add(Me.chkBoxCertified)
        Me.Name = "frmKuidditchRefereeFeeKalculator"
        Me.ShowIcon = False
        Me.Text = "Eric Oliver"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBoxCertified As CheckBox
    Friend WithEvents radbtnRecreational As RadioButton
    Friend WithEvents radbtnCompetitive As RadioButton
    Friend WithEvents radbtnInternational As RadioButton
    Friend WithEvents txtBoxNumOfGames As TextBox
    Friend WithEvents txtBoxCostPerGame As TextBox
    Friend WithEvents txtBoxTotalDue As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblNumOfGames As Label
    Friend WithEvents lblCostPerGame As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
