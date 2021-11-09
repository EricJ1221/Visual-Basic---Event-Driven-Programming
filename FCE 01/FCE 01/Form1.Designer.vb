<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFCE
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
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.txtExchangeValue = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblExchangeValue = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblExchangeRate = New System.Windows.Forms.Label()
        Me.nudExchangeRate = New System.Windows.Forms.NumericUpDown()
        Me.grpCurrencyStability = New System.Windows.Forms.GroupBox()
        Me.radPoor = New System.Windows.Forms.RadioButton()
        Me.radModerate = New System.Windows.Forms.RadioButton()
        Me.radGood = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.nudExchangeRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCurrencyStability.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(148, 26)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(119, 20)
        Me.txtDollars.TabIndex = 1
        '
        'txtExchangeValue
        '
        Me.txtExchangeValue.Location = New System.Drawing.Point(14, 305)
        Me.txtExchangeValue.Name = "txtExchangeValue"
        Me.txtExchangeValue.ReadOnly = True
        Me.txtExchangeValue.Size = New System.Drawing.Size(119, 20)
        Me.txtExchangeValue.TabIndex = 6
        '
        'txtCommission
        '
        Me.txtCommission.Location = New System.Drawing.Point(235, 305)
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.ReadOnly = True
        Me.txtCommission.Size = New System.Drawing.Size(119, 20)
        Me.txtCommission.TabIndex = 8
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(84, 29)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(39, 13)
        Me.lblDollars.TabIndex = 0
        Me.lblDollars.Text = "&Dollars"
        '
        'lblExchangeValue
        '
        Me.lblExchangeValue.AutoSize = True
        Me.lblExchangeValue.Location = New System.Drawing.Point(27, 273)
        Me.lblExchangeValue.Name = "lblExchangeValue"
        Me.lblExchangeValue.Size = New System.Drawing.Size(85, 13)
        Me.lblExchangeValue.TabIndex = 5
        Me.lblExchangeValue.Text = "Exchange &Value"
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(267, 273)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(62, 13)
        Me.lblCommission.TabIndex = 7
        Me.lblCommission.Text = "&Commission"
        '
        'lblExchangeRate
        '
        Me.lblExchangeRate.AutoSize = True
        Me.lblExchangeRate.Location = New System.Drawing.Point(52, 121)
        Me.lblExchangeRate.Name = "lblExchangeRate"
        Me.lblExchangeRate.Size = New System.Drawing.Size(81, 13)
        Me.lblExchangeRate.TabIndex = 2
        Me.lblExchangeRate.Text = "&Exchange Rate"
        '
        'nudExchangeRate
        '
        Me.nudExchangeRate.Location = New System.Drawing.Point(45, 147)
        Me.nudExchangeRate.Name = "nudExchangeRate"
        Me.nudExchangeRate.Size = New System.Drawing.Size(88, 20)
        Me.nudExchangeRate.TabIndex = 3
        '
        'grpCurrencyStability
        '
        Me.grpCurrencyStability.Controls.Add(Me.radPoor)
        Me.grpCurrencyStability.Controls.Add(Me.radModerate)
        Me.grpCurrencyStability.Controls.Add(Me.radGood)
        Me.grpCurrencyStability.Location = New System.Drawing.Point(196, 106)
        Me.grpCurrencyStability.Name = "grpCurrencyStability"
        Me.grpCurrencyStability.Size = New System.Drawing.Size(121, 144)
        Me.grpCurrencyStability.TabIndex = 4
        Me.grpCurrencyStability.TabStop = False
        Me.grpCurrencyStability.Text = "Currency Stability"
        '
        'radPoor
        '
        Me.radPoor.AutoSize = True
        Me.radPoor.Location = New System.Drawing.Point(19, 111)
        Me.radPoor.Name = "radPoor"
        Me.radPoor.Size = New System.Drawing.Size(47, 17)
        Me.radPoor.TabIndex = 2
        Me.radPoor.TabStop = True
        Me.radPoor.Text = "&Poor"
        Me.radPoor.UseVisualStyleBackColor = True
        '
        'radModerate
        '
        Me.radModerate.AutoSize = True
        Me.radModerate.Location = New System.Drawing.Point(19, 65)
        Me.radModerate.Name = "radModerate"
        Me.radModerate.Size = New System.Drawing.Size(70, 17)
        Me.radModerate.TabIndex = 1
        Me.radModerate.TabStop = True
        Me.radModerate.Text = "&Moderate"
        Me.radModerate.UseVisualStyleBackColor = True
        '
        'radGood
        '
        Me.radGood.AutoSize = True
        Me.radGood.Location = New System.Drawing.Point(19, 20)
        Me.radGood.Name = "radGood"
        Me.radGood.Size = New System.Drawing.Size(51, 17)
        Me.radGood.TabIndex = 0
        Me.radGood.TabStop = True
        Me.radGood.Text = "&Good"
        Me.radGood.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(139, 363)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmFCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 413)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpCurrencyStability)
        Me.Controls.Add(Me.nudExchangeRate)
        Me.Controls.Add(Me.lblExchangeRate)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.lblExchangeValue)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.txtCommission)
        Me.Controls.Add(Me.txtExchangeValue)
        Me.Controls.Add(Me.txtDollars)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFCE"
        Me.ShowIcon = False
        Me.Text = "Foreign Currency Exchange"
        CType(Me.nudExchangeRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCurrencyStability.ResumeLayout(False)
        Me.grpCurrencyStability.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDollars As TextBox
    Friend WithEvents txtExchangeValue As TextBox
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents lblDollars As Label
    Friend WithEvents lblExchangeValue As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents lblExchangeRate As Label
    Friend WithEvents nudExchangeRate As NumericUpDown
    Friend WithEvents grpCurrencyStability As GroupBox
    Friend WithEvents radPoor As RadioButton
    Friend WithEvents radModerate As RadioButton
    Friend WithEvents radGood As RadioButton
    Friend WithEvents btnReset As Button
End Class
