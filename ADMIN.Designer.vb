﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADMIN
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
        Me.components = New System.ComponentModel.Container()
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.usersbtn = New System.Windows.Forms.Button()
        Me.vehiclesbtn = New System.Windows.Forms.Button()
        Me.visitorsbtn = New System.Windows.Forms.Button()
        Me.dashbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.AdminUsers1 = New SecurityBook.adminUsers()
        Me.AdminBadges1 = New SecurityBook.adminBadges()
        Me.AdminVIP1 = New SecurityBook.adminVIP()
        Me.sidepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Label2)
        Me.sidepanel.Controls.Add(Me.Button4)
        Me.sidepanel.Controls.Add(Me.Button3)
        Me.sidepanel.Controls.Add(Me.usersbtn)
        Me.sidepanel.Controls.Add(Me.vehiclesbtn)
        Me.sidepanel.Controls.Add(Me.visitorsbtn)
        Me.sidepanel.Controls.Add(Me.dashbtn)
        Me.sidepanel.Controls.Add(Me.Label1)
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(200, 500)
        Me.sidepanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.Coral
        Me.Panel1.Location = New System.Drawing.Point(10, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 35)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Logged in as"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Silver
        Me.Button4.Location = New System.Drawing.Point(16, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 35)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "VIP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Silver
        Me.Button3.Location = New System.Drawing.Point(16, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 35)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Visitor Pass"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'usersbtn
        '
        Me.usersbtn.FlatAppearance.BorderSize = 0
        Me.usersbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.usersbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usersbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usersbtn.ForeColor = System.Drawing.Color.Silver
        Me.usersbtn.Location = New System.Drawing.Point(16, 260)
        Me.usersbtn.Name = "usersbtn"
        Me.usersbtn.Size = New System.Drawing.Size(184, 35)
        Me.usersbtn.TabIndex = 1
        Me.usersbtn.Text = "Users"
        Me.usersbtn.UseVisualStyleBackColor = True
        '
        'vehiclesbtn
        '
        Me.vehiclesbtn.FlatAppearance.BorderSize = 0
        Me.vehiclesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.vehiclesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.vehiclesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vehiclesbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehiclesbtn.ForeColor = System.Drawing.Color.Silver
        Me.vehiclesbtn.Location = New System.Drawing.Point(16, 220)
        Me.vehiclesbtn.Name = "vehiclesbtn"
        Me.vehiclesbtn.Size = New System.Drawing.Size(184, 35)
        Me.vehiclesbtn.TabIndex = 1
        Me.vehiclesbtn.Text = "Vehicles"
        Me.vehiclesbtn.UseVisualStyleBackColor = True
        '
        'visitorsbtn
        '
        Me.visitorsbtn.FlatAppearance.BorderSize = 0
        Me.visitorsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.visitorsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.visitorsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.visitorsbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitorsbtn.ForeColor = System.Drawing.Color.Silver
        Me.visitorsbtn.Location = New System.Drawing.Point(16, 180)
        Me.visitorsbtn.Name = "visitorsbtn"
        Me.visitorsbtn.Size = New System.Drawing.Size(184, 35)
        Me.visitorsbtn.TabIndex = 1
        Me.visitorsbtn.Text = "Visitors"
        Me.visitorsbtn.UseVisualStyleBackColor = True
        '
        'dashbtn
        '
        Me.dashbtn.FlatAppearance.BorderSize = 0
        Me.dashbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.dashbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbtn.ForeColor = System.Drawing.Color.Silver
        Me.dashbtn.Image = Global.SecurityBook.My.Resources.Resources._2618259
        Me.dashbtn.Location = New System.Drawing.Point(16, 140)
        Me.dashbtn.Name = "dashbtn"
        Me.dashbtn.Size = New System.Drawing.Size(184, 35)
        Me.dashbtn.TabIndex = 1
        Me.dashbtn.Text = "Dashboard"
        Me.dashbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN PANEL"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("8_bit_1_6", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(968, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("8_bit_1_6", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(935, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer5
        '
        Me.Timer5.Interval = 15
        '
        'Timer6
        '
        '
        'AdminUsers1
        '
        Me.AdminUsers1.Location = New System.Drawing.Point(200, 0)
        Me.AdminUsers1.Name = "AdminUsers1"
        Me.AdminUsers1.Size = New System.Drawing.Size(800, 500)
        Me.AdminUsers1.TabIndex = 2
        Me.AdminUsers1.Visible = False
        '
        'AdminBadges1
        '
        Me.AdminBadges1.Location = New System.Drawing.Point(200, 0)
        Me.AdminBadges1.Name = "AdminBadges1"
        Me.AdminBadges1.Size = New System.Drawing.Size(800, 500)
        Me.AdminBadges1.TabIndex = 3
        Me.AdminBadges1.Visible = False
        '
        'AdminVIP1
        '
        Me.AdminVIP1.Location = New System.Drawing.Point(200, 0)
        Me.AdminVIP1.Name = "AdminVIP1"
        Me.AdminVIP1.Size = New System.Drawing.Size(1000, 500)
        Me.AdminVIP1.TabIndex = 4
        Me.AdminVIP1.Visible = False
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.AdminVIP1)
        Me.Controls.Add(Me.AdminUsers1)
        Me.Controls.Add(Me.AdminBadges1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "w"
        Me.sidepanel.ResumeLayout(False)
        Me.sidepanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidepanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dashbtn As Button
    Friend WithEvents usersbtn As Button
    Friend WithEvents vehiclesbtn As Button
    Friend WithEvents visitorsbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer6 As Timer
    Friend WithEvents AdminUsers1 As adminUsers
    Friend WithEvents AdminBadges1 As adminBadges
    Friend WithEvents AdminVIP1 As adminVIP
End Class
