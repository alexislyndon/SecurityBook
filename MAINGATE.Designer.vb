<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAINGATE
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
        Me.components = New System.ComponentModel.Container()
        Me.closelbl = New System.Windows.Forms.PictureBox()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'closelbl
        '
        Me.closelbl.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closelbl.Location = New System.Drawing.Point(1332, -1)
        Me.closelbl.Name = "closelbl"
        Me.closelbl.Size = New System.Drawing.Size(35, 35)
        Me.closelbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelbl.TabIndex = 0
        Me.closelbl.TabStop = False
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Button5)
        Me.sidepanel.Controls.Add(Me.Button4)
        Me.sidepanel.Controls.Add(Me.Button3)
        Me.sidepanel.Controls.Add(Me.Button2)
        Me.sidepanel.Controls.Add(Me.Button1)
        Me.sidepanel.Controls.Add(Me.Panel2)
        Me.sidepanel.Controls.Add(Me.Label2)
        Me.sidepanel.Controls.Add(Me.Label1)
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(250, 768)
        Me.sidepanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Location = New System.Drawing.Point(3, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 50)
        Me.Panel1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 490)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(238, 50)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "View Vehicles"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(238, 50)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Vehicles"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View Visitors"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(238, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Visitors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Location = New System.Drawing.Point(0, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 1)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MAIN GATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Seven Segment", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(28, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Timer3
        '
        Me.Timer3.Interval = 15
        '
        'Timer4
        '
        Me.Timer4.Interval = 15
        '
        'Timer5
        '
        Me.Timer5.Interval = 15
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'MAINGATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.closelbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MAINGATE"
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepanel.ResumeLayout(False)
        Me.sidepanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closelbl As PictureBox
    Friend WithEvents sidepanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
End Class
