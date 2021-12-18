<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OKE = New System.Windows.Forms.Button()
        Me.Frm = New System.Windows.Forms.TextBox()
        Me.Too = New System.Windows.Forms.TextBox()
        Me.DT1 = New System.Windows.Forms.DateTimePicker()
        Me.DT2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To : "
        '
        'OKE
        '
        Me.OKE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKE.Location = New System.Drawing.Point(3, 71)
        Me.OKE.Name = "OKE"
        Me.OKE.Size = New System.Drawing.Size(205, 23)
        Me.OKE.TabIndex = 2
        Me.OKE.Text = "OKE"
        Me.OKE.UseVisualStyleBackColor = True
        '
        'Frm
        '
        Me.Frm.Location = New System.Drawing.Point(63, 6)
        Me.Frm.Name = "Frm"
        Me.Frm.Size = New System.Drawing.Size(145, 21)
        Me.Frm.TabIndex = 4
        '
        'Too
        '
        Me.Too.Location = New System.Drawing.Point(63, 42)
        Me.Too.Name = "Too"
        Me.Too.Size = New System.Drawing.Size(145, 21)
        Me.Too.TabIndex = 5
        '
        'DT1
        '
        Me.DT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DT1.CustomFormat = "MM/dd/yyyy"
        Me.DT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT1.Location = New System.Drawing.Point(63, 6)
        Me.DT1.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DT1.Name = "DT1"
        Me.DT1.Size = New System.Drawing.Size(144, 21)
        Me.DT1.TabIndex = 6
        '
        'DT2
        '
        Me.DT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DT2.CustomFormat = "MM/dd/yyyy"
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT2.Location = New System.Drawing.Point(63, 42)
        Me.DT2.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DT2.Name = "DT2"
        Me.DT2.Size = New System.Drawing.Size(144, 21)
        Me.DT2.TabIndex = 7
        '
        'Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 97)
        Me.Controls.Add(Me.DT2)
        Me.Controls.Add(Me.DT1)
        Me.Controls.Add(Me.Too)
        Me.Controls.Add(Me.Frm)
        Me.Controls.Add(Me.OKE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Custom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Range [MM/DD/YYYY]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OKE As System.Windows.Forms.Button
    Friend WithEvents Frm As System.Windows.Forms.TextBox
    Friend WithEvents Too As System.Windows.Forms.TextBox
    Friend WithEvents DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT2 As System.Windows.Forms.DateTimePicker
End Class
