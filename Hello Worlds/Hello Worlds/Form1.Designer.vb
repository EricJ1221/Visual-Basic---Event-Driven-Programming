<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorlds
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
        Me.buttonClick = New System.Windows.Forms.Button()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.chkBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'buttonClick
        '
        Me.buttonClick.Location = New System.Drawing.Point(45, 110)
        Me.buttonClick.Name = "buttonClick"
        Me.buttonClick.Size = New System.Drawing.Size(75, 23)
        Me.buttonClick.TabIndex = 0
        Me.buttonClick.Text = "Click Me"
        Me.buttonClick.UseVisualStyleBackColor = True
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(145, 216)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 20)
        Me.txtBox1.TabIndex = 1
        Me.txtBox1.Text = "Eric"
        '
        'chkBox1
        '
        Me.chkBox1.AutoSize = True
        Me.chkBox1.Location = New System.Drawing.Point(305, 156)
        Me.chkBox1.Name = "chkBox1"
        Me.chkBox1.Size = New System.Drawing.Size(81, 17)
        Me.chkBox1.TabIndex = 2
        Me.chkBox1.Text = "CheckBox1"
        Me.chkBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(12, 43)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 4
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(316, 79)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(90, 17)
        Me.radioButton1.TabIndex = 5
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "RadioButton1"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'frmHelloWorlds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 450)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.chkBox1)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.buttonClick)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHelloWorlds"
        Me.ShowIcon = False
        Me.Text = "Eric's Hello Worlds"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonClick As Button
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents chkBox1 As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents radioButton1 As RadioButton
End Class
