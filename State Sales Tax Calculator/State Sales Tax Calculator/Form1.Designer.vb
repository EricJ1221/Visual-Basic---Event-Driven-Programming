<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSSTC
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
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblTaxDue = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtTaxDue = New System.Windows.Forms.TextBox()
        Me.nudTaxRate = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(74, 65)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(36, 13)
        Me.lblSales.TabIndex = 7
        Me.lblSales.Text = "Sales:"
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(56, 144)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(54, 13)
        Me.lblTaxRate.TabIndex = 7
        Me.lblTaxRate.Text = "Tax Rate:"
        '
        'lblTaxDue
        '
        Me.lblTaxDue.AutoSize = True
        Me.lblTaxDue.Location = New System.Drawing.Point(59, 228)
        Me.lblTaxDue.Name = "lblTaxDue"
        Me.lblTaxDue.Size = New System.Drawing.Size(51, 13)
        Me.lblTaxDue.TabIndex = 5
        Me.lblTaxDue.Text = "Tax Due:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(145, 65)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(113, 20)
        Me.txtSales.TabIndex = 0
        Me.txtSales.Text = "0.00"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxDue
        '
        Me.txtTaxDue.Location = New System.Drawing.Point(145, 228)
        Me.txtTaxDue.Name = "txtTaxDue"
        Me.txtTaxDue.ReadOnly = True
        Me.txtTaxDue.Size = New System.Drawing.Size(113, 20)
        Me.txtTaxDue.TabIndex = 2
        Me.txtTaxDue.Text = "$0.00"
        Me.txtTaxDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudTaxRate
        '
        Me.nudTaxRate.DecimalPlaces = 2
        Me.nudTaxRate.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudTaxRate.Location = New System.Drawing.Point(145, 144)
        Me.nudTaxRate.Name = "nudTaxRate"
        Me.nudTaxRate.ReadOnly = True
        Me.nudTaxRate.Size = New System.Drawing.Size(113, 20)
        Me.nudTaxRate.TabIndex = 1
        Me.nudTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTaxRate.Value = New Decimal(New Integer() {825, 0, 0, 131072})
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 272)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 37)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(175, 272)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 37)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmSSTC
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(315, 321)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.nudTaxRate)
        Me.Controls.Add(Me.txtTaxDue)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblTaxDue)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.lblSales)
        Me.Name = "frmSSTC"
        Me.ShowIcon = False
        Me.Text = "State Sales Tax Calulator"
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSales As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents lblTaxDue As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtTaxDue As TextBox
    Friend WithEvents nudTaxRate As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
End Class
