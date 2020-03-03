<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.UsersTableAdapter1 = New SecurityBook.db1DSTableAdapters.usersTableAdapter()
        Me.Db1DS1 = New SecurityBook.db1DS()
        Me.closelbl = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.Db1DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(116, 283)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(89, 40)
        Me.loginbtn.TabIndex = 3
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(110, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Username"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox2.Location = New System.Drawing.Point(110, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 18)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Password"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'Db1DS1
        '
        Me.Db1DS1.DataSetName = "db1DS"
        Me.Db1DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'closelbl
        '
        Me.closelbl.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closelbl.Location = New System.Drawing.Point(287, -3)
        Me.closelbl.Name = "closelbl"
        Me.closelbl.Size = New System.Drawing.Size(36, 36)
        Me.closelbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelbl.TabIndex = 4
        Me.closelbl.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(96, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 1)
        Me.Panel1.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(129, 1)
        Me.Panel4.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 85)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(96, 234)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 1)
        Me.Panel2.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel6.Location = New System.Drawing.Point(0, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(129, 1)
        Me.Panel6.TabIndex = 8
        '
        'Login
        '
        Me.AcceptButton = Me.loginbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.closelbl)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.loginbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Db1DS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents UsersTableAdapter1 As db1DSTableAdapters.usersTableAdapter
    Friend WithEvents Db1DS1 As db1DS
    Friend WithEvents closelbl As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
End Class
