<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search_Engine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Engine))
        Me.CY = New System.Windows.Forms.CheckBox()
        Me.CG = New System.Windows.Forms.CheckBox()
        Me.CP = New System.Windows.Forms.CheckBox()
        Me.CB = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RND = New System.Windows.Forms.CheckBox()
        Me.NotFound = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.text_proxyType = New System.Windows.Forms.ComboBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.loadProxy = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReqMethode = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CY
        '
        Me.CY.AutoSize = True
        Me.CY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CY.Location = New System.Drawing.Point(170, 65)
        Me.CY.Name = "CY"
        Me.CY.Size = New System.Drawing.Size(59, 19)
        Me.CY.TabIndex = 0
        Me.CY.Text = "Yahoo"
        Me.CY.UseVisualStyleBackColor = True
        '
        'CG
        '
        Me.CG.AutoSize = True
        Me.CG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CG.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CG.Location = New System.Drawing.Point(54, 17)
        Me.CG.Name = "CG"
        Me.CG.Size = New System.Drawing.Size(64, 19)
        Me.CG.TabIndex = 1
        Me.CG.Text = "Google"
        Me.CG.UseVisualStyleBackColor = True
        '
        'CP
        '
        Me.CP.AutoSize = True
        Me.CP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP.Location = New System.Drawing.Point(170, 16)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(73, 19)
        Me.CP.TabIndex = 2
        Me.CP.Text = "Pastebin"
        Me.CP.UseVisualStyleBackColor = True
        '
        'CB
        '
        Me.CB.AutoSize = True
        Me.CB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB.Location = New System.Drawing.Point(56, 64)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(49, 19)
        Me.CB.TabIndex = 3
        Me.CB.Text = "Bing"
        Me.CB.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(134, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(18, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(134, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save And Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RND
        '
        Me.RND.AutoSize = True
        Me.RND.Checked = True
        Me.RND.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RND.Location = New System.Drawing.Point(54, 109)
        Me.RND.Name = "RND"
        Me.RND.Size = New System.Drawing.Size(152, 18)
        Me.RND.TabIndex = 9
        Me.RND.Text = "Use Random User Agents"
        Me.RND.UseVisualStyleBackColor = True
        '
        'NotFound
        '
        Me.NotFound.AutoSize = True
        Me.NotFound.ForeColor = System.Drawing.Color.Red
        Me.NotFound.Location = New System.Drawing.Point(15, 122)
        Me.NotFound.Name = "NotFound"
        Me.NotFound.Size = New System.Drawing.Size(10, 14)
        Me.NotFound.TabIndex = 10
        Me.NotFound.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.text_proxyType)
        Me.GroupBox1.Controls.Add(Me.Label112)
        Me.GroupBox1.Location = New System.Drawing.Point(271, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 90)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'text_proxyType
        '
        Me.text_proxyType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.text_proxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.text_proxyType.FormattingEnabled = True
        Me.text_proxyType.Items.AddRange(New Object() {"HTTP/HTTPS", "SOCKS4", "SOCKS5", "PROXYLESS"})
        Me.text_proxyType.Location = New System.Drawing.Point(83, 13)
        Me.text_proxyType.Name = "text_proxyType"
        Me.text_proxyType.Size = New System.Drawing.Size(135, 22)
        Me.text_proxyType.TabIndex = 7
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(6, 16)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(71, 14)
        Me.Label112.TabIndex = 8
        Me.Label112.Text = "Proxy Type : "
        '
        'loadProxy
        '
        Me.loadProxy.AllowDrop = True
        Me.loadProxy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadProxy.Location = New System.Drawing.Point(271, 5)
        Me.loadProxy.Name = "loadProxy"
        Me.loadProxy.Size = New System.Drawing.Size(236, 30)
        Me.loadProxy.TabIndex = 20
        Me.loadProxy.Text = "Load Proxy"
        Me.loadProxy.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(258, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 233)
        Me.Panel1.TabIndex = 22
        '
        'ReqMethode
        '
        Me.ReqMethode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReqMethode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReqMethode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ReqMethode.FormattingEnabled = True
        Me.ReqMethode.Items.AddRange(New Object() {"GET", "POST"})
        Me.ReqMethode.Location = New System.Drawing.Point(18, 155)
        Me.ReqMethode.Name = "ReqMethode"
        Me.ReqMethode.Size = New System.Drawing.Size(211, 22)
        Me.ReqMethode.TabIndex = 23
        '
        'Search_Engine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 237)
        Me.Controls.Add(Me.ReqMethode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.loadProxy)
        Me.Controls.Add(Me.NotFound)
        Me.Controls.Add(Me.RND)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CB)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.CG)
        Me.Controls.Add(Me.CY)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search_Engine"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Engine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CY As System.Windows.Forms.CheckBox
    Friend WithEvents CG As System.Windows.Forms.CheckBox
    Friend WithEvents CP As System.Windows.Forms.CheckBox
    Friend WithEvents CB As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RND As System.Windows.Forms.CheckBox
    Friend WithEvents NotFound As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents text_proxyType As System.Windows.Forms.ComboBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents loadProxy As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReqMethode As ComboBox
End Class
