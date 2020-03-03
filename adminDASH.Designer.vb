<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDASH
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VisitorsTableAdapter1 = New SecurityBook.db1DSTableAdapters.VisitorsTableAdapter()
        Me.Db1DS1 = New SecurityBook.db1DS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AdminBadges1 = New SecurityBook.adminBadges()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Db1DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(66, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 150)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel2.Controls.Add(Me.AdminBadges1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(66, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 150)
        Me.Panel2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(108, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Today"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(130, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 39)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "1"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(31, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 39)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(37, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "In"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VISITORS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(534, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 322)
        Me.Panel4.TabIndex = 10
        Me.Panel4.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Beige
        Me.Label7.Location = New System.Drawing.Point(27, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 36)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "BACK GATE"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(299, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 322)
        Me.Panel5.TabIndex = 11
        Me.Panel5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Beige
        Me.Label8.Location = New System.Drawing.Point(23, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 36)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "MAIN GATE"
        '
        'VisitorsTableAdapter1
        '
        Me.VisitorsTableAdapter1.ClearBeforeFill = True
        '
        'Db1DS1
        '
        Me.Db1DS1.DataSetName = "db1DS"
        Me.Db1DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(108, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(130, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(31, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 39)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "10"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(37, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 29)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "In"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(5, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 26)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Vehicles"
        '
        'AdminBadges1
        '
        Me.AdminBadges1.Location = New System.Drawing.Point(200, 0)
        Me.AdminBadges1.Name = "AdminBadges1"
        Me.AdminBadges1.Size = New System.Drawing.Size(800, 500)
        Me.AdminBadges1.TabIndex = 8
        Me.AdminBadges1.Visible = False
        '
        'adminDASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "adminDASH"
        Me.Size = New System.Drawing.Size(800, 500)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Db1DS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdminBadges1 As adminBadges
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents VisitorsTableAdapter1 As db1DSTableAdapters.VisitorsTableAdapter
    Friend WithEvents Db1DS1 As db1DS
    Friend WithEvents Label14 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
