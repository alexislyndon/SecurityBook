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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAINGATE))
        Me.sidepanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.minimizebtn = New System.Windows.Forms.Button()
        Me.closelbl = New System.Windows.Forms.PictureBox()
        Me.maximizebtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SecurityBooklbl = New System.Windows.Forms.Label()
        Me.AddVisitor1 = New SecurityBook.AddVisitor()
        Me.ViewVisitor1 = New SecurityBook.viewVisitor()
        Me.AddVehicle1 = New SecurityBook.AddVehicle()
        Me.ServiceproviderUC1 = New SecurityBook.serviceproviderUC()
        Me.MainbackTableAdapter1 = New SecurityBook.db1DSTableAdapters.mainbackTableAdapter()
        Me.sidepanel.SuspendLayout()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidepanel
        '
        Me.sidepanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.sidepanel.Controls.Add(Me.Label6)
        Me.sidepanel.Controls.Add(Me.Label5)
        Me.sidepanel.Controls.Add(Me.Panel1)
        Me.sidepanel.Controls.Add(Me.Button5)
        Me.sidepanel.Controls.Add(Me.Button4)
        Me.sidepanel.Controls.Add(Me.Button3)
        Me.sidepanel.Controls.Add(Me.Button2)
        Me.sidepanel.Controls.Add(Me.Button1)
        Me.sidepanel.Controls.Add(Me.Panel2)
        Me.sidepanel.Controls.Add(Me.Label2)
        Me.sidepanel.Controls.Add(Me.Label4)
        Me.sidepanel.Controls.Add(Me.Label3)
        Me.sidepanel.Controls.Add(Me.Label1)
        Me.sidepanel.Location = New System.Drawing.Point(0, 0)
        Me.sidepanel.Name = "sidepanel"
        Me.sidepanel.Size = New System.Drawing.Size(250, 768)
        Me.sidepanel.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label6.Location = New System.Drawing.Point(9, 735)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "someone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 700)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Logged in as:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Location = New System.Drawing.Point(3, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 50)
        Me.Panel1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Beige
        Me.Button5.Location = New System.Drawing.Point(12, 490)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(238, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "VIP"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Beige
        Me.Button4.Location = New System.Drawing.Point(12, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(238, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Vehicles"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Beige
        Me.Button3.Location = New System.Drawing.Point(12, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "View Visitors"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Beige
        Me.Button2.Location = New System.Drawing.Point(12, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(238, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Visitors"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Beige
        Me.Button1.Location = New System.Drawing.Point(12, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Location = New System.Drawing.Point(0, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 1)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MAIN GATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dubai", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Beige
        Me.Label4.Location = New System.Drawing.Point(64, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sunday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dubai", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Beige
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "01 March 2020"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DSEG14 Classic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(35, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 32)
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
        'minimizebtn
        '
        Me.minimizebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizebtn.Font = New System.Drawing.Font("8_bit_1_6", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizebtn.ForeColor = System.Drawing.Color.White
        Me.minimizebtn.Location = New System.Drawing.Point(1299, 1)
        Me.minimizebtn.Name = "minimizebtn"
        Me.minimizebtn.Size = New System.Drawing.Size(30, 30)
        Me.minimizebtn.TabIndex = 4
        Me.minimizebtn.Text = "_"
        Me.minimizebtn.UseVisualStyleBackColor = False
        '
        'closelbl
        '
        Me.closelbl.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closelbl.Location = New System.Drawing.Point(1333, -3)
        Me.closelbl.Name = "closelbl"
        Me.closelbl.Size = New System.Drawing.Size(36, 36)
        Me.closelbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelbl.TabIndex = 0
        Me.closelbl.TabStop = False
        '
        'maximizebtn
        '
        Me.maximizebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maximizebtn.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.maximizebtn.ForeColor = System.Drawing.Color.White
        Me.maximizebtn.Location = New System.Drawing.Point(1300, 1)
        Me.maximizebtn.Name = "maximizebtn"
        Me.maximizebtn.Size = New System.Drawing.Size(30, 30)
        Me.maximizebtn.TabIndex = 8
        Me.maximizebtn.Text = "o"
        Me.maximizebtn.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("8_bit_1_6", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1268, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 30)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "_"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'closebtn
        '
        Me.closebtn.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closebtn.Location = New System.Drawing.Point(1330, -2)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(36, 36)
        Me.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closebtn.TabIndex = 6
        Me.closebtn.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(947, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 3)
        Me.Panel3.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel5.Location = New System.Drawing.Point(0, 42)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(129, 1)
        Me.Panel5.TabIndex = 8
        '
        'SecurityBooklbl
        '
        Me.SecurityBooklbl.AutoSize = True
        Me.SecurityBooklbl.BackColor = System.Drawing.Color.Transparent
        Me.SecurityBooklbl.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityBooklbl.ForeColor = System.Drawing.Color.Black
        Me.SecurityBooklbl.Location = New System.Drawing.Point(948, -2)
        Me.SecurityBooklbl.Name = "SecurityBooklbl"
        Me.SecurityBooklbl.Size = New System.Drawing.Size(142, 27)
        Me.SecurityBooklbl.TabIndex = 11
        Me.SecurityBooklbl.Text = "SecurityBook"
        '
        'AddVisitor1
        '
        Me.AddVisitor1.BackColor = System.Drawing.Color.Snow
        Me.AddVisitor1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AddVisitor1.Location = New System.Drawing.Point(250, 0)
        Me.AddVisitor1.Name = "AddVisitor1"
        Me.AddVisitor1.Size = New System.Drawing.Size(1116, 768)
        Me.AddVisitor1.TabIndex = 0
        Me.AddVisitor1.Visible = False
        '
        'ViewVisitor1
        '
        Me.ViewVisitor1.Location = New System.Drawing.Point(250, 0)
        Me.ViewVisitor1.Name = "ViewVisitor1"
        Me.ViewVisitor1.Size = New System.Drawing.Size(1116, 768)
        Me.ViewVisitor1.TabIndex = 0
        Me.ViewVisitor1.Visible = False
        '
        'AddVehicle1
        '
        Me.AddVehicle1.BackColor = System.Drawing.Color.Snow
        Me.AddVehicle1.Location = New System.Drawing.Point(250, 0)
        Me.AddVehicle1.Name = "AddVehicle1"
        Me.AddVehicle1.Size = New System.Drawing.Size(1116, 768)
        Me.AddVehicle1.TabIndex = 0
        Me.AddVehicle1.Visible = False
        '
        'ServiceproviderUC1
        '
        Me.ServiceproviderUC1.Location = New System.Drawing.Point(250, 0)
        Me.ServiceproviderUC1.Name = "ServiceproviderUC1"
        Me.ServiceproviderUC1.Size = New System.Drawing.Size(1116, 768)
        Me.ServiceproviderUC1.TabIndex = 9
        Me.ServiceproviderUC1.Visible = False
        '
        'MainbackTableAdapter1
        '
        Me.MainbackTableAdapter1.ClearBeforeFill = True
        '
        'MAINGATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SecurityBooklbl)
        Me.Controls.Add(Me.maximizebtn)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.minimizebtn)
        Me.Controls.Add(Me.sidepanel)
        Me.Controls.Add(Me.closelbl)
        Me.Controls.Add(Me.AddVisitor1)
        Me.Controls.Add(Me.ViewVisitor1)
        Me.Controls.Add(Me.AddVehicle1)
        Me.Controls.Add(Me.ServiceproviderUC1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MAINGATE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.sidepanel.ResumeLayout(False)
        Me.sidepanel.PerformLayout()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents minimizebtn As Button
    Friend WithEvents AddVisitor1 As AddVisitor
    Friend WithEvents maximizebtn As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents closebtn As PictureBox
    Friend WithEvents ViewVisitor1 As viewVisitor
    Friend WithEvents AddVehicle1 As AddVehicle
    Friend WithEvents ServiceproviderUC1 As serviceproviderUC
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SecurityBooklbl As Label
    Friend WithEvents MainbackTableAdapter1 As db1DSTableAdapters.mainbackTableAdapter
End Class
