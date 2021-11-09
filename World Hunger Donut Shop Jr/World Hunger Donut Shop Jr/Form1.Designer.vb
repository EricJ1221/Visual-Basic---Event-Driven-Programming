<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWHDSJ
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
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.lblTendered = New System.Windows.Forms.Label()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.radCake = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.radSprinkles = New System.Windows.Forms.RadioButton()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.chkCoffee = New System.Windows.Forms.CheckBox()
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtChangeDue = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpFood.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(69, 51)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(59, 296)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.Location = New System.Drawing.Point(71, 353)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(67, 13)
        Me.lblChangeDue.TabIndex = 3
        Me.lblChangeDue.Text = "Change Due"
        '
        'lblTendered
        '
        Me.lblTendered.AutoSize = True
        Me.lblTendered.Location = New System.Drawing.Point(274, 296)
        Me.lblTendered.Name = "lblTendered"
        Me.lblTendered.Size = New System.Drawing.Size(53, 13)
        Me.lblTendered.TabIndex = 4
        Me.lblTendered.Text = "Tendered"
        '
        'grpFood
        '
        Me.grpFood.Controls.Add(Me.radCake)
        Me.grpFood.Controls.Add(Me.radGlazed)
        Me.grpFood.Controls.Add(Me.radSprinkles)
        Me.grpFood.Location = New System.Drawing.Point(198, 51)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(115, 141)
        Me.grpFood.TabIndex = 5
        Me.grpFood.TabStop = False
        Me.grpFood.Text = "Food"
        '
        'radCake
        '
        Me.radCake.AutoSize = True
        Me.radCake.Location = New System.Drawing.Point(6, 107)
        Me.radCake.Name = "radCake"
        Me.radCake.Size = New System.Drawing.Size(50, 17)
        Me.radCake.TabIndex = 14
        Me.radCake.TabStop = True
        Me.radCake.Text = "Cake"
        Me.radCake.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(6, 30)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(58, 17)
        Me.radGlazed.TabIndex = 12
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "Glazed"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'radSprinkles
        '
        Me.radSprinkles.AutoSize = True
        Me.radSprinkles.Location = New System.Drawing.Point(6, 68)
        Me.radSprinkles.Name = "radSprinkles"
        Me.radSprinkles.Size = New System.Drawing.Size(68, 17)
        Me.radSprinkles.TabIndex = 13
        Me.radSprinkles.TabStop = True
        Me.radSprinkles.Text = "Sprinkles"
        Me.radSprinkles.UseVisualStyleBackColor = True
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(35, 67)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 0
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCoffee
        '
        Me.chkCoffee.AutoSize = True
        Me.chkCoffee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCoffee.Location = New System.Drawing.Point(72, 130)
        Me.chkCoffee.Name = "chkCoffee"
        Me.chkCoffee.Size = New System.Drawing.Size(57, 17)
        Me.chkCoffee.TabIndex = 6
        Me.chkCoffee.Text = "Coffee"
        Me.chkCoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCoffee.UseVisualStyleBackColor = True
        '
        'txtTendered
        '
        Me.txtTendered.Location = New System.Drawing.Point(234, 312)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Size = New System.Drawing.Size(100, 20)
        Me.txtTendered.TabIndex = 7
        Me.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(26, 312)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChangeDue
        '
        Me.txtChangeDue.Location = New System.Drawing.Point(144, 350)
        Me.txtChangeDue.Name = "txtChangeDue"
        Me.txtChangeDue.ReadOnly = True
        Me.txtChangeDue.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeDue.TabIndex = 9
        Me.txtChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(238, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(51, 400)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmWHDSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(369, 446)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtChangeDue)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTendered)
        Me.Controls.Add(Me.chkCoffee)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.lblTendered)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblQuantity)
        Me.Name = "frmWHDSJ"
        Me.ShowIcon = False
        Me.Text = "World Hunger Donut Shop Jr"
        Me.grpFood.ResumeLayout(False)
        Me.grpFood.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents lblTendered As Label
    Friend WithEvents grpFood As GroupBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents chkCoffee As CheckBox
    Friend WithEvents txtTendered As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtChangeDue As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents radCake As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radSprinkles As RadioButton
End Class
