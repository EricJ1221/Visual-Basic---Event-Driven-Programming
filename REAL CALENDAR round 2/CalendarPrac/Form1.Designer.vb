<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
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
        Me.txtStartDay = New System.Windows.Forms.TextBox()
        Me.btnLoadCalendar = New System.Windows.Forms.Button()
        Me.txtNumOfDays = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStartDay
        '
        Me.txtStartDay.Location = New System.Drawing.Point(84, 27)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDay.TabIndex = 0
        Me.txtStartDay.Text = "v"
        '
        'btnLoadCalendar
        '
        Me.btnLoadCalendar.Location = New System.Drawing.Point(150, 112)
        Me.btnLoadCalendar.Name = "btnLoadCalendar"
        Me.btnLoadCalendar.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadCalendar.TabIndex = 1
        Me.btnLoadCalendar.Text = "Load"
        Me.btnLoadCalendar.UseVisualStyleBackColor = True
        '
        'txtNumOfDays
        '
        Me.txtNumOfDays.Location = New System.Drawing.Point(84, 72)
        Me.txtNumOfDays.Name = "txtNumOfDays"
        Me.txtNumOfDays.Size = New System.Drawing.Size(100, 20)
        Me.txtNumOfDays.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(42, 112)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cmbMonth.Location = New System.Drawing.Point(74, 183)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 4
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(84, 240)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(97, 294)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 352)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtNumOfDays)
        Me.Controls.Add(Me.btnLoadCalendar)
        Me.Controls.Add(Me.txtStartDay)
        Me.Name = "frmCalendar"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStartDay As TextBox
    Friend WithEvents btnLoadCalendar As Button
    Friend WithEvents txtNumOfDays As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnGo As Button
End Class
