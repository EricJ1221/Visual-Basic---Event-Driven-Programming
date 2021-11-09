<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMAM
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
        Me.txtBoxPints = New System.Windows.Forms.TextBox()
        Me.txtBoxMoonshinePint = New System.Windows.Forms.TextBox()
        Me.grpMolasses = New System.Windows.Forms.GroupBox()
        Me.radButtonDark = New System.Windows.Forms.RadioButton()
        Me.radButtonMedium = New System.Windows.Forms.RadioButton()
        Me.radButtonLight = New System.Windows.Forms.RadioButton()
        Me.chkBoxHatfield = New System.Windows.Forms.CheckBox()
        Me.txtBoxUntaxableIncome = New System.Windows.Forms.TextBox()
        Me.lblPints = New System.Windows.Forms.Label()
        Me.lblMoonshinePint = New System.Windows.Forms.Label()
        Me.lblUntaxableIncome = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpMolasses.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBoxPints
        '
        Me.txtBoxPints.Location = New System.Drawing.Point(124, 15)
        Me.txtBoxPints.Name = "txtBoxPints"
        Me.txtBoxPints.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPints.TabIndex = 0
        Me.txtBoxPints.Text = "0"
        Me.txtBoxPints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxMoonshinePint
        '
        Me.txtBoxMoonshinePint.Location = New System.Drawing.Point(124, 59)
        Me.txtBoxMoonshinePint.Name = "txtBoxMoonshinePint"
        Me.txtBoxMoonshinePint.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxMoonshinePint.TabIndex = 1
        Me.txtBoxMoonshinePint.Text = "0.00"
        Me.txtBoxMoonshinePint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpMolasses
        '
        Me.grpMolasses.Controls.Add(Me.radButtonDark)
        Me.grpMolasses.Controls.Add(Me.radButtonMedium)
        Me.grpMolasses.Controls.Add(Me.radButtonLight)
        Me.grpMolasses.Location = New System.Drawing.Point(103, 99)
        Me.grpMolasses.Name = "grpMolasses"
        Me.grpMolasses.Size = New System.Drawing.Size(127, 121)
        Me.grpMolasses.TabIndex = 3
        Me.grpMolasses.TabStop = False
        Me.grpMolasses.Text = "Molasses"
        '
        'radButtonDark
        '
        Me.radButtonDark.AutoSize = True
        Me.radButtonDark.Location = New System.Drawing.Point(32, 88)
        Me.radButtonDark.Name = "radButtonDark"
        Me.radButtonDark.Size = New System.Drawing.Size(48, 17)
        Me.radButtonDark.TabIndex = 2
        Me.radButtonDark.TabStop = True
        Me.radButtonDark.Text = "Dark"
        Me.radButtonDark.UseVisualStyleBackColor = True
        '
        'radButtonMedium
        '
        Me.radButtonMedium.AutoSize = True
        Me.radButtonMedium.Location = New System.Drawing.Point(32, 53)
        Me.radButtonMedium.Name = "radButtonMedium"
        Me.radButtonMedium.Size = New System.Drawing.Size(62, 17)
        Me.radButtonMedium.TabIndex = 1
        Me.radButtonMedium.TabStop = True
        Me.radButtonMedium.Text = "Medium"
        Me.radButtonMedium.UseVisualStyleBackColor = True
        '
        'radButtonLight
        '
        Me.radButtonLight.AutoSize = True
        Me.radButtonLight.Location = New System.Drawing.Point(32, 16)
        Me.radButtonLight.Name = "radButtonLight"
        Me.radButtonLight.Size = New System.Drawing.Size(48, 17)
        Me.radButtonLight.TabIndex = 0
        Me.radButtonLight.TabStop = True
        Me.radButtonLight.Text = "Light"
        Me.radButtonLight.UseVisualStyleBackColor = True
        '
        'chkBoxHatfield
        '
        Me.chkBoxHatfield.AutoSize = True
        Me.chkBoxHatfield.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBoxHatfield.Location = New System.Drawing.Point(32, 146)
        Me.chkBoxHatfield.Name = "chkBoxHatfield"
        Me.chkBoxHatfield.Size = New System.Drawing.Size(65, 17)
        Me.chkBoxHatfield.TabIndex = 2
        Me.chkBoxHatfield.Text = "Hatfield:"
        Me.chkBoxHatfield.UseVisualStyleBackColor = True
        '
        'txtBoxUntaxableIncome
        '
        Me.txtBoxUntaxableIncome.Location = New System.Drawing.Point(121, 237)
        Me.txtBoxUntaxableIncome.Name = "txtBoxUntaxableIncome"
        Me.txtBoxUntaxableIncome.ReadOnly = True
        Me.txtBoxUntaxableIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxUntaxableIncome.TabIndex = 4
        Me.txtBoxUntaxableIncome.TabStop = False
        Me.txtBoxUntaxableIncome.Text = "$0.00"
        Me.txtBoxUntaxableIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPints
        '
        Me.lblPints.AutoSize = True
        Me.lblPints.Location = New System.Drawing.Point(85, 18)
        Me.lblPints.Name = "lblPints"
        Me.lblPints.Size = New System.Drawing.Size(33, 13)
        Me.lblPints.TabIndex = 5
        Me.lblPints.Text = "Pints:"
        '
        'lblMoonshinePint
        '
        Me.lblMoonshinePint.AutoSize = True
        Me.lblMoonshinePint.Location = New System.Drawing.Point(29, 59)
        Me.lblMoonshinePint.Name = "lblMoonshinePint"
        Me.lblMoonshinePint.Size = New System.Drawing.Size(89, 13)
        Me.lblMoonshinePint.TabIndex = 6
        Me.lblMoonshinePint.Text = "Moonshine Pint $"
        '
        'lblUntaxableIncome
        '
        Me.lblUntaxableIncome.AutoSize = True
        Me.lblUntaxableIncome.Location = New System.Drawing.Point(19, 240)
        Me.lblUntaxableIncome.Name = "lblUntaxableIncome"
        Me.lblUntaxableIncome.Size = New System.Drawing.Size(96, 13)
        Me.lblUntaxableIncome.TabIndex = 7
        Me.lblUntaxableIncome.Text = "Untaxable Income:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(87, 276)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMMAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 315)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblUntaxableIncome)
        Me.Controls.Add(Me.lblMoonshinePint)
        Me.Controls.Add(Me.lblPints)
        Me.Controls.Add(Me.txtBoxUntaxableIncome)
        Me.Controls.Add(Me.chkBoxHatfield)
        Me.Controls.Add(Me.grpMolasses)
        Me.Controls.Add(Me.txtBoxMoonshinePint)
        Me.Controls.Add(Me.txtBoxPints)
        Me.Name = "frmMMAM"
        Me.ShowIcon = False
        Me.Text = "McCoys Moonshine And Molasses"
        Me.grpMolasses.ResumeLayout(False)
        Me.grpMolasses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxPints As TextBox
    Friend WithEvents txtBoxMoonshinePint As TextBox
    Friend WithEvents grpMolasses As GroupBox
    Friend WithEvents radButtonDark As RadioButton
    Friend WithEvents radButtonMedium As RadioButton
    Friend WithEvents radButtonLight As RadioButton
    Friend WithEvents chkBoxHatfield As CheckBox
    Friend WithEvents txtBoxUntaxableIncome As TextBox
    Friend WithEvents lblPints As Label
    Friend WithEvents lblMoonshinePint As Label
    Friend WithEvents lblUntaxableIncome As Label
    Friend WithEvents btnReset As Button
End Class
