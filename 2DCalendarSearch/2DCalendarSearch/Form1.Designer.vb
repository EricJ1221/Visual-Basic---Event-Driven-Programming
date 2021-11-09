<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2DCalendarSearch
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtNumOfDays = New System.Windows.Forms.TextBox()
        Me.txtStartDay = New System.Windows.Forms.TextBox()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.lblNumDays = New System.Windows.Forms.Label()
        Me.txtSearchFor = New System.Windows.Forms.TextBox()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.txtFound = New System.Windows.Forms.TextBox()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(26, 123)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(133, 123)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtNumOfDays
        '
        Me.txtNumOfDays.Location = New System.Drawing.Point(108, 76)
        Me.txtNumOfDays.Name = "txtNumOfDays"
        Me.txtNumOfDays.Size = New System.Drawing.Size(100, 20)
        Me.txtNumOfDays.TabIndex = 2
        '
        'txtStartDay
        '
        Me.txtStartDay.Location = New System.Drawing.Point(108, 37)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDay.TabIndex = 3
        '
        'lblStartDay
        '
        Me.lblStartDay.AutoSize = True
        Me.lblStartDay.Location = New System.Drawing.Point(28, 40)
        Me.lblStartDay.Name = "lblStartDay"
        Me.lblStartDay.Size = New System.Drawing.Size(48, 13)
        Me.lblStartDay.TabIndex = 4
        Me.lblStartDay.Text = "First Day"
        '
        'lblNumDays
        '
        Me.lblNumDays.AutoSize = True
        Me.lblNumDays.Location = New System.Drawing.Point(23, 79)
        Me.lblNumDays.Name = "lblNumDays"
        Me.lblNumDays.Size = New System.Drawing.Size(53, 13)
        Me.lblNumDays.TabIndex = 5
        Me.lblNumDays.Text = "# of Days"
        '
        'txtSearchFor
        '
        Me.txtSearchFor.Location = New System.Drawing.Point(108, 172)
        Me.txtSearchFor.Name = "txtSearchFor"
        Me.txtSearchFor.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFor.TabIndex = 6
        '
        'lblSearchFor
        '
        Me.lblSearchFor.AutoSize = True
        Me.lblSearchFor.Location = New System.Drawing.Point(28, 175)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(56, 13)
        Me.lblSearchFor.TabIndex = 7
        Me.lblSearchFor.Text = "Search for"
        '
        'txtFound
        '
        Me.txtFound.Location = New System.Drawing.Point(108, 212)
        Me.txtFound.Name = "txtFound"
        Me.txtFound.ReadOnly = True
        Me.txtFound.Size = New System.Drawing.Size(100, 20)
        Me.txtFound.TabIndex = 8
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Location = New System.Drawing.Point(28, 212)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(37, 13)
        Me.lblFound.TabIndex = 9
        Me.lblFound.Text = "Found"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(68, 260)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frm2DCalendarSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 323)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.txtFound)
        Me.Controls.Add(Me.lblSearchFor)
        Me.Controls.Add(Me.txtSearchFor)
        Me.Controls.Add(Me.lblNumDays)
        Me.Controls.Add(Me.lblStartDay)
        Me.Controls.Add(Me.txtStartDay)
        Me.Controls.Add(Me.txtNumOfDays)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frm2DCalendarSearch"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtNumOfDays As TextBox
    Friend WithEvents txtStartDay As TextBox
    Friend WithEvents lblStartDay As Label
    Friend WithEvents lblNumDays As Label
    Friend WithEvents txtSearchFor As TextBox
    Friend WithEvents lblSearchFor As Label
    Friend WithEvents txtFound As TextBox
    Friend WithEvents lblFound As Label
    Friend WithEvents btnSearch As Button
End Class
