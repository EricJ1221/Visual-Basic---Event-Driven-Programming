<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSBM
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(65, 117)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 40)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(65, 173)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 40)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cmbBox1
        '
        Me.cmbBox1.FormattingEnabled = True
        Me.cmbBox1.Items.AddRange(New Object() {"Sum", "Count"})
        Me.cmbBox1.Location = New System.Drawing.Point(44, 21)
        Me.cmbBox1.Name = "cmbBox1"
        Me.cmbBox1.Size = New System.Drawing.Size(121, 21)
        Me.cmbBox1.TabIndex = 2
        '
        'cmbBox2
        '
        Me.cmbBox2.FormattingEnabled = True
        Me.cmbBox2.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbBox2.Location = New System.Drawing.Point(44, 68)
        Me.cmbBox2.Name = "cmbBox2"
        Me.cmbBox2.Size = New System.Drawing.Size(121, 21)
        Me.cmbBox2.TabIndex = 3
        '
        'frmSBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 235)
        Me.Controls.Add(Me.cmbBox2)
        Me.Controls.Add(Me.cmbBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "frmSBM"
        Me.ShowIcon = False
        Me.Text = "Sales By Month"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbBox1 As ComboBox
    Friend WithEvents cmbBox2 As ComboBox
End Class
