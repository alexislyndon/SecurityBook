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
        Me.vehicleall = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vehicletoday = New System.Windows.Forms.Label()
        Me.vehiclein = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.vistotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vistoday = New System.Windows.Forms.Label()
        Me.visin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.backguard = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.mainguard = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VisitorsTableAdapter1 = New SecurityBook.db1DSTableAdapters.VisitorsTableAdapter()
        Me.Db1DS1 = New SecurityBook.db1DS()
        Me.VehiclesTableAdapter1 = New SecurityBook.db1DSTableAdapters.VehiclesTableAdapter()
        Me.MainbackTableAdapter1 = New SecurityBook.db1DSTableAdapters.mainbackTableAdapter()
        Me.UsersTableAdapter1 = New SecurityBook.db1DSTableAdapters.usersTableAdapter()
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
        Me.Panel3.Controls.Add(Me.vehicleall)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.vehicletoday)
        Me.Panel3.Controls.Add(Me.vehiclein)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(35, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(273, 150)
        Me.Panel3.TabIndex = 8
        '
        'vehicleall
        '
        Me.vehicleall.AutoSize = True
        Me.vehicleall.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic)
        Me.vehicleall.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vehicleall.Location = New System.Drawing.Point(203, 83)
        Me.vehicleall.Name = "vehicleall"
        Me.vehicleall.Size = New System.Drawing.Size(28, 39)
        Me.vehicleall.TabIndex = 9
        Me.vehicleall.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(174, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 29)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "All Time"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(5, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 33)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Vehicles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(91, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Today"
        '
        'vehicletoday
        '
        Me.vehicletoday.AutoSize = True
        Me.vehicletoday.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicletoday.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vehicletoday.Location = New System.Drawing.Point(113, 83)
        Me.vehicletoday.Name = "vehicletoday"
        Me.vehicletoday.Size = New System.Drawing.Size(28, 39)
        Me.vehicletoday.TabIndex = 4
        Me.vehicletoday.Text = "1"
        Me.vehicletoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vehiclein
        '
        Me.vehiclein.AutoSize = True
        Me.vehiclein.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehiclein.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vehiclein.Location = New System.Drawing.Point(23, 83)
        Me.vehiclein.Name = "vehiclein"
        Me.vehiclein.Size = New System.Drawing.Size(45, 39)
        Me.vehiclein.TabIndex = 5
        Me.vehiclein.Text = "10"
        Me.vehiclein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(25, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 29)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "In"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel2.Controls.Add(Me.vistotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.vistoday)
        Me.Panel2.Controls.Add(Me.visin)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(35, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 166)
        Me.Panel2.TabIndex = 9
        '
        'vistotal
        '
        Me.vistotal.AutoSize = True
        Me.vistotal.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic)
        Me.vistotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vistotal.Location = New System.Drawing.Point(203, 95)
        Me.vistotal.Name = "vistotal"
        Me.vistotal.Size = New System.Drawing.Size(28, 39)
        Me.vistotal.TabIndex = 2
        Me.vistotal.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(174, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "All Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(91, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Today"
        '
        'vistoday
        '
        Me.vistoday.AutoSize = True
        Me.vistoday.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vistoday.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vistoday.Location = New System.Drawing.Point(113, 95)
        Me.vistoday.Name = "vistoday"
        Me.vistoday.Size = New System.Drawing.Size(28, 39)
        Me.vistoday.TabIndex = 1
        Me.vistoday.Text = "1"
        Me.vistoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'visin
        '
        Me.visin.AutoSize = True
        Me.visin.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.visin.Location = New System.Drawing.Point(23, 95)
        Me.visin.Name = "visin"
        Me.visin.Size = New System.Drawing.Size(45, 39)
        Me.visin.TabIndex = 1
        Me.visin.Text = "10"
        Me.visin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(29, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "In"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VISITORS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Controls.Add(Me.backguard)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(568, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 338)
        Me.Panel4.TabIndex = 10
        '
        'backguard
        '
        Me.backguard.AutoSize = True
        Me.backguard.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backguard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.backguard.Location = New System.Drawing.Point(3, 95)
        Me.backguard.Name = "backguard"
        Me.backguard.Size = New System.Drawing.Size(156, 23)
        Me.backguard.TabIndex = 4
        Me.backguard.Text = "Guard on Duty"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(3, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Guard on Duty"
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
        Me.Panel5.Controls.Add(Me.mainguard)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Location = New System.Drawing.Point(351, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(201, 338)
        Me.Panel5.TabIndex = 11
        '
        'mainguard
        '
        Me.mainguard.AutoSize = True
        Me.mainguard.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainguard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.mainguard.Location = New System.Drawing.Point(3, 95)
        Me.mainguard.Name = "mainguard"
        Me.mainguard.Size = New System.Drawing.Size(156, 23)
        Me.mainguard.TabIndex = 3
        Me.mainguard.Text = "Guard on Duty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Guard on Duty"
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
        'VehiclesTableAdapter1
        '
        Me.VehiclesTableAdapter1.ClearBeforeFill = True
        '
        'MainbackTableAdapter1
        '
        Me.MainbackTableAdapter1.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'adminDASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
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
    Friend WithEvents Label6 As Label
    Friend WithEvents vistoday As Label
    Friend WithEvents visin As Label
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
    Friend WithEvents vehicletoday As Label
    Friend WithEvents vehiclein As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents vehicleall As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents vistotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents VehiclesTableAdapter1 As db1DSTableAdapters.VehiclesTableAdapter
    Friend WithEvents MainbackTableAdapter1 As db1DSTableAdapters.mainbackTableAdapter
    Friend WithEvents UsersTableAdapter1 As db1DSTableAdapters.usersTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents mainguard As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents backguard As Label
End Class
