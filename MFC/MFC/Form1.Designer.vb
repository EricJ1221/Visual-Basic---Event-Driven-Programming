<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMFC
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
        Me.gbTypeOfMembership = New System.Windows.Forms.GroupBox()
        Me.radSeniorCitizen = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radStandardAdult = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.chkPersonalTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.gbMembershipLength = New System.Windows.Forms.GroupBox()
        Me.lblEnterTheNumberOfMonths = New System.Windows.Forms.Label()
        Me.txtNumberOfMonths = New System.Windows.Forms.TextBox()
        Me.gbMembershipFees = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.txtMonthlyFee = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbTypeOfMembership.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.gbMembershipLength.SuspendLayout()
        Me.gbMembershipFees.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTypeOfMembership
        '
        Me.gbTypeOfMembership.Controls.Add(Me.radSeniorCitizen)
        Me.gbTypeOfMembership.Controls.Add(Me.radStudent)
        Me.gbTypeOfMembership.Controls.Add(Me.radStandardAdult)
        Me.gbTypeOfMembership.Controls.Add(Me.radChild)
        Me.gbTypeOfMembership.Location = New System.Drawing.Point(29, 30)
        Me.gbTypeOfMembership.Name = "gbTypeOfMembership"
        Me.gbTypeOfMembership.Size = New System.Drawing.Size(208, 157)
        Me.gbTypeOfMembership.TabIndex = 3
        Me.gbTypeOfMembership.TabStop = False
        Me.gbTypeOfMembership.Text = "Type of Membership"
        '
        'radSeniorCitizen
        '
        Me.radSeniorCitizen.AutoSize = True
        Me.radSeniorCitizen.Location = New System.Drawing.Point(18, 118)
        Me.radSeniorCitizen.Name = "radSeniorCitizen"
        Me.radSeniorCitizen.Size = New System.Drawing.Size(89, 17)
        Me.radSeniorCitizen.TabIndex = 3
        Me.radSeniorCitizen.TabStop = True
        Me.radSeniorCitizen.Text = "S&enior Citizen"
        Me.radSeniorCitizen.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(18, 87)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 2
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radStandardAdult
        '
        Me.radStandardAdult.AutoSize = True
        Me.radStandardAdult.Location = New System.Drawing.Point(18, 25)
        Me.radStandardAdult.Name = "radStandardAdult"
        Me.radStandardAdult.Size = New System.Drawing.Size(95, 17)
        Me.radStandardAdult.TabIndex = 0
        Me.radStandardAdult.TabStop = True
        Me.radStandardAdult.Text = "Standard &Adult"
        Me.radStandardAdult.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(18, 56)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(108, 17)
        Me.radChild.TabIndex = 1
        Me.radChild.TabStop = True
        Me.radChild.Text = "Chil&d (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.chkPersonalTrainer)
        Me.gbOptions.Controls.Add(Me.chkKarate)
        Me.gbOptions.Controls.Add(Me.chkYoga)
        Me.gbOptions.Location = New System.Drawing.Point(291, 30)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(208, 157)
        Me.gbOptions.TabIndex = 4
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'chkPersonalTrainer
        '
        Me.chkPersonalTrainer.AutoSize = True
        Me.chkPersonalTrainer.Location = New System.Drawing.Point(15, 108)
        Me.chkPersonalTrainer.Name = "chkPersonalTrainer"
        Me.chkPersonalTrainer.Size = New System.Drawing.Size(103, 17)
        Me.chkPersonalTrainer.TabIndex = 2
        Me.chkPersonalTrainer.Text = "&Personal Trainer"
        Me.chkPersonalTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(15, 71)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(57, 17)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(15, 34)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(51, 17)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'gbMembershipLength
        '
        Me.gbMembershipLength.Controls.Add(Me.lblEnterTheNumberOfMonths)
        Me.gbMembershipLength.Controls.Add(Me.txtNumberOfMonths)
        Me.gbMembershipLength.Location = New System.Drawing.Point(29, 236)
        Me.gbMembershipLength.Name = "gbMembershipLength"
        Me.gbMembershipLength.Size = New System.Drawing.Size(208, 124)
        Me.gbMembershipLength.TabIndex = 0
        Me.gbMembershipLength.TabStop = False
        Me.gbMembershipLength.Text = "Membership Length"
        '
        'lblEnterTheNumberOfMonths
        '
        Me.lblEnterTheNumberOfMonths.AutoSize = True
        Me.lblEnterTheNumberOfMonths.Location = New System.Drawing.Point(8, 42)
        Me.lblEnterTheNumberOfMonths.Name = "lblEnterTheNumberOfMonths"
        Me.lblEnterTheNumberOfMonths.Size = New System.Drawing.Size(143, 13)
        Me.lblEnterTheNumberOfMonths.TabIndex = 6
        Me.lblEnterTheNumberOfMonths.Text = "Enter the Number of Months:"
        '
        'txtNumberOfMonths
        '
        Me.txtNumberOfMonths.Location = New System.Drawing.Point(18, 77)
        Me.txtNumberOfMonths.Name = "txtNumberOfMonths"
        Me.txtNumberOfMonths.Size = New System.Drawing.Size(133, 20)
        Me.txtNumberOfMonths.TabIndex = 0
        '
        'gbMembershipFees
        '
        Me.gbMembershipFees.Controls.Add(Me.lblTotal)
        Me.gbMembershipFees.Controls.Add(Me.lblMonthlyFee)
        Me.gbMembershipFees.Controls.Add(Me.txtMonthlyFee)
        Me.gbMembershipFees.Controls.Add(Me.txtTotal)
        Me.gbMembershipFees.Location = New System.Drawing.Point(281, 236)
        Me.gbMembershipFees.Name = "gbMembershipFees"
        Me.gbMembershipFees.Size = New System.Drawing.Size(208, 124)
        Me.gbMembershipFees.TabIndex = 0
        Me.gbMembershipFees.TabStop = False
        Me.gbMembershipFees.Text = "Membership Fees"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(38, 84)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.AutoSize = True
        Me.lblMonthlyFee.Location = New System.Drawing.Point(4, 58)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(68, 13)
        Me.lblMonthlyFee.TabIndex = 9
        Me.lblMonthlyFee.Text = "Monthly Fee:"
        '
        'txtMonthlyFee
        '
        Me.txtMonthlyFee.Location = New System.Drawing.Point(78, 55)
        Me.txtMonthlyFee.Name = "txtMonthlyFee"
        Me.txtMonthlyFee.ReadOnly = True
        Me.txtMonthlyFee.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyFee.TabIndex = 7
        Me.txtMonthlyFee.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(78, 81)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(88, 388)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(221, 388)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(357, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(520, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'frmMFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 465)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbMembershipLength)
        Me.Controls.Add(Me.gbMembershipFees)
        Me.Controls.Add(Me.gbTypeOfMembership)
        Me.Name = "frmMFC"
        Me.Text = "Membership Fee Calculator"
        Me.gbTypeOfMembership.ResumeLayout(False)
        Me.gbTypeOfMembership.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbMembershipLength.ResumeLayout(False)
        Me.gbMembershipLength.PerformLayout()
        Me.gbMembershipFees.ResumeLayout(False)
        Me.gbMembershipFees.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTypeOfMembership As GroupBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents gbMembershipLength As GroupBox
    Friend WithEvents gbMembershipFees As GroupBox
    Friend WithEvents radSeniorCitizen As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radStandardAdult As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents chkPersonalTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents lblEnterTheNumberOfMonths As Label
    Friend WithEvents txtNumberOfMonths As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents txtMonthlyFee As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
