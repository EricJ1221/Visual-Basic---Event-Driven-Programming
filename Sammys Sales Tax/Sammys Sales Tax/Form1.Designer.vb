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
        Me.lblGrossSales = New System.Windows.Forms.Label()
        Me.lblNetSales = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtGrossSales = New System.Windows.Forms.TextBox()
        Me.txtNetSales = New System.Windows.Forms.TextBox()
        Me.chkClubMember = New System.Windows.Forms.CheckBox()
        Me.grpbxCity = New System.Windows.Forms.GroupBox()
        Me.radNacogdoches = New System.Windows.Forms.RadioButton()
        Me.radDouglass = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpbxCity.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(57, 87)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(36, 13)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "&Sales:"
        '
        'lblGrossSales
        '
        Me.lblGrossSales.AutoSize = True
        Me.lblGrossSales.Location = New System.Drawing.Point(135, 50)
        Me.lblGrossSales.Name = "lblGrossSales"
        Me.lblGrossSales.Size = New System.Drawing.Size(34, 13)
        Me.lblGrossSales.TabIndex = 5
        Me.lblGrossSales.Text = "Gross"
        '
        'lblNetSales
        '
        Me.lblNetSales.AutoSize = True
        Me.lblNetSales.Location = New System.Drawing.Point(274, 50)
        Me.lblNetSales.Name = "lblNetSales"
        Me.lblNetSales.Size = New System.Drawing.Size(24, 13)
        Me.lblNetSales.TabIndex = 2
        Me.lblNetSales.Text = "Net"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(101, 335)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 4
        Me.lblSalesTax.Text = "Sales &Tax:"
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(164, 332)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTax.TabIndex = 5
        Me.txtSalesTax.TabStop = False
        Me.txtSalesTax.Text = "0.00"
        Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrossSales
        '
        Me.txtGrossSales.Location = New System.Drawing.Point(99, 84)
        Me.txtGrossSales.Name = "txtGrossSales"
        Me.txtGrossSales.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossSales.TabIndex = 1
        Me.txtGrossSales.Text = "0.00"
        Me.txtGrossSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetSales
        '
        Me.txtNetSales.Location = New System.Drawing.Point(233, 84)
        Me.txtNetSales.Name = "txtNetSales"
        Me.txtNetSales.ReadOnly = True
        Me.txtNetSales.Size = New System.Drawing.Size(100, 20)
        Me.txtNetSales.TabIndex = 7
        Me.txtNetSales.TabStop = False
        Me.txtNetSales.Text = "0.00"
        Me.txtNetSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkClubMember
        '
        Me.chkClubMember.AutoSize = True
        Me.chkClubMember.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkClubMember.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkClubMember.Location = New System.Drawing.Point(161, 142)
        Me.chkClubMember.Name = "chkClubMember"
        Me.chkClubMember.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkClubMember.Size = New System.Drawing.Size(88, 17)
        Me.chkClubMember.TabIndex = 2
        Me.chkClubMember.Text = "&Club Member"
        Me.chkClubMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkClubMember.UseVisualStyleBackColor = True
        '
        'grpbxCity
        '
        Me.grpbxCity.Controls.Add(Me.radNacogdoches)
        Me.grpbxCity.Controls.Add(Me.radDouglass)
        Me.grpbxCity.Location = New System.Drawing.Point(124, 183)
        Me.grpbxCity.Name = "grpbxCity"
        Me.grpbxCity.Size = New System.Drawing.Size(140, 99)
        Me.grpbxCity.TabIndex = 3
        Me.grpbxCity.TabStop = False
        Me.grpbxCity.Text = "City"
        '
        'radNacogdoches
        '
        Me.radNacogdoches.AutoSize = True
        Me.radNacogdoches.Location = New System.Drawing.Point(21, 34)
        Me.radNacogdoches.Name = "radNacogdoches"
        Me.radNacogdoches.Size = New System.Drawing.Size(92, 17)
        Me.radNacogdoches.TabIndex = 0
        Me.radNacogdoches.TabStop = True
        Me.radNacogdoches.Text = "&Nacogdoches"
        Me.radNacogdoches.UseVisualStyleBackColor = True
        '
        'radDouglass
        '
        Me.radDouglass.AutoSize = True
        Me.radDouglass.Location = New System.Drawing.Point(21, 57)
        Me.radDouglass.Name = "radDouglass"
        Me.radDouglass.Size = New System.Drawing.Size(69, 17)
        Me.radDouglass.TabIndex = 1
        Me.radDouglass.TabStop = True
        Me.radDouglass.Text = "&Douglass"
        Me.radDouglass.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(165, 377)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmSSTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(390, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpbxCity)
        Me.Controls.Add(Me.chkClubMember)
        Me.Controls.Add(Me.txtNetSales)
        Me.Controls.Add(Me.txtGrossSales)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblNetSales)
        Me.Controls.Add(Me.lblGrossSales)
        Me.Controls.Add(Me.lblSales)
        Me.Name = "frmSSTC"
        Me.ShowIcon = False
        Me.Text = "Sammy's Sales Tax Calculator"
        Me.grpbxCity.ResumeLayout(False)
        Me.grpbxCity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSales As Label
    Friend WithEvents lblGrossSales As Label
    Friend WithEvents lblNetSales As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents txtSalesTax As TextBox
    Friend WithEvents txtGrossSales As TextBox
    Friend WithEvents txtNetSales As TextBox
    Friend WithEvents chkClubMember As CheckBox
    Friend WithEvents grpbxCity As GroupBox
    Friend WithEvents radNacogdoches As RadioButton
    Friend WithEvents radDouglass As RadioButton
    Friend WithEvents btnReset As Button
End Class
