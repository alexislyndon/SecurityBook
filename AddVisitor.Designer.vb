<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddVisitor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVisitor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.capportrait = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.capid = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.purp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idsurr = New System.Windows.Forms.ComboBox()
        Me.badge = New System.Windows.Forms.ComboBox()
        Me.BadgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1DS = New SecurityBook.db1DS()
        Me.dest = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.checkinbtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.uclabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VisitorsTableAdapter = New SecurityBook.db1DSTableAdapters.VisitorsTableAdapter()
        Me.BadgesTableAdapter = New SecurityBook.db1DSTableAdapters.BadgesTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BadgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.capportrait)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.sex)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lname)
        Me.GroupBox1.Controls.Add(Me.mname)
        Me.GroupBox1.Controls.Add(Me.phone)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'capportrait
        '
        Me.capportrait.Cursor = System.Windows.Forms.Cursors.Hand
        Me.capportrait.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.capportrait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capportrait.Location = New System.Drawing.Point(614, 190)
        Me.capportrait.Name = "capportrait"
        Me.capportrait.Size = New System.Drawing.Size(96, 42)
        Me.capportrait.TabIndex = 11
        Me.capportrait.Text = "Capture Portrait"
        Me.capportrait.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex"
        '
        'sex
        '
        Me.sex.BackColor = System.Drawing.Color.White
        Me.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sex.FormattingEnabled = True
        Me.sex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.sex.Location = New System.Drawing.Point(230, 126)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(88, 29)
        Me.sex.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Middle Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Snow
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Phone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'lname
        '
        Me.lname.BackColor = System.Drawing.Color.White
        Me.lname.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(439, 46)
        Me.lname.MaxLength = 30
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(175, 34)
        Me.lname.TabIndex = 3
        '
        'mname
        '
        Me.mname.BackColor = System.Drawing.Color.White
        Me.mname.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.Location = New System.Drawing.Point(230, 46)
        Me.mname.MaxLength = 30
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(175, 34)
        Me.mname.TabIndex = 2
        '
        'phone
        '
        Me.phone.BackColor = System.Drawing.Color.White
        Me.phone.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone.Location = New System.Drawing.Point(21, 121)
        Me.phone.MaxLength = 35
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(175, 34)
        Me.phone.TabIndex = 4
        '
        'fname
        '
        Me.fname.BackColor = System.Drawing.Color.White
        Me.fname.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(21, 46)
        Me.fname.MaxLength = 35
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(175, 34)
        Me.fname.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.capid)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.purp)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.idsurr)
        Me.GroupBox2.Controls.Add(Me.badge)
        Me.GroupBox2.Controls.Add(Me.dest)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 252)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security Information"
        '
        'capid
        '
        Me.capid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.capid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.capid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capid.Location = New System.Drawing.Point(614, 14)
        Me.capid.Name = "capid"
        Me.capid.Size = New System.Drawing.Size(96, 42)
        Me.capid.TabIndex = 11
        Me.capid.Text = "Capture ID"
        Me.capid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Snow
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 25)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Purpose"
        '
        'purp
        '
        Me.purp.BackColor = System.Drawing.Color.White
        Me.purp.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purp.Location = New System.Drawing.Point(21, 126)
        Me.purp.MaxLength = 35
        Me.purp.Name = "purp"
        Me.purp.Size = New System.Drawing.Size(196, 34)
        Me.purp.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Snow
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(293, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ID Surrendered"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Snow
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(293, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Visitor Pass Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Snow
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Destination"
        '
        'idsurr
        '
        Me.idsurr.FormattingEnabled = True
        Me.idsurr.Items.AddRange(New Object() {"School ID", "Company ID", "Driver's License", "UMID", "Postal ID"})
        Me.idsurr.Location = New System.Drawing.Point(290, 131)
        Me.idsurr.Name = "idsurr"
        Me.idsurr.Size = New System.Drawing.Size(214, 29)
        Me.idsurr.TabIndex = 9
        '
        'badge
        '
        Me.badge.DataSource = Me.BadgesBindingSource
        Me.badge.DisplayMember = "badge"
        Me.badge.FormattingEnabled = True
        Me.badge.Location = New System.Drawing.Point(290, 56)
        Me.badge.Name = "badge"
        Me.badge.Size = New System.Drawing.Size(214, 29)
        Me.badge.TabIndex = 8
        Me.badge.ValueMember = "badge"
        '
        'BadgesBindingSource
        '
        Me.BadgesBindingSource.DataMember = "Badges"
        Me.BadgesBindingSource.DataSource = Me.Db1DS
        '
        'Db1DS
        '
        Me.Db1DS.DataSetName = "db1DS"
        Me.Db1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dest
        '
        Me.dest.FormattingEnabled = True
        Me.dest.Items.AddRange(New Object() {"Registrar", "Finance"})
        Me.dest.Location = New System.Drawing.Point(21, 56)
        Me.dest.Name = "dest"
        Me.dest.Size = New System.Drawing.Size(196, 29)
        Me.dest.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(772, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(772, 356)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(777, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 21)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Visitor Portrait"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(776, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ID Card"
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(772, 356)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(862, 599)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Click on image toggle between front/back view"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'checkinbtn
        '
        Me.checkinbtn.BackColor = System.Drawing.Color.GreenYellow
        Me.checkinbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkinbtn.FlatAppearance.BorderSize = 0
        Me.checkinbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.checkinbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.checkinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkinbtn.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkinbtn.ForeColor = System.Drawing.Color.Black
        Me.checkinbtn.Location = New System.Drawing.Point(905, 683)
        Me.checkinbtn.Name = "checkinbtn"
        Me.checkinbtn.Size = New System.Drawing.Size(158, 58)
        Me.checkinbtn.TabIndex = 6
        Me.checkinbtn.Text = "Check In"
        Me.checkinbtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.Location = New System.Drawing.Point(21, 683)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 58)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'uclabel
        '
        Me.uclabel.AutoSize = True
        Me.uclabel.Font = New System.Drawing.Font("Microsoft JhengHei", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uclabel.Location = New System.Drawing.Point(62, 17)
        Me.uclabel.Name = "uclabel"
        Me.uclabel.Size = New System.Drawing.Size(138, 30)
        Me.uclabel.TabIndex = 7
        Me.uclabel.Text = "Add Visitor"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(183, -61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 5)
        Me.Panel2.TabIndex = 9
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 50
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'VisitorsTableAdapter
        '
        Me.VisitorsTableAdapter.ClearBeforeFill = True
        '
        'BadgesTableAdapter
        '
        Me.BadgesTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'AddVisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.uclabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.checkinbtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "AddVisitor"
        Me.Size = New System.Drawing.Size(1116, 768)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BadgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents mname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents purp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents idsurr As ComboBox
    Friend WithEvents badge As ComboBox
    Friend WithEvents dest As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents capportrait As Button
    Friend WithEvents capid As Button
    Friend WithEvents checkinbtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents uclabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents VisitorsTableAdapter As db1DSTableAdapters.VisitorsTableAdapter
    Friend WithEvents BadgesTableAdapter As db1DSTableAdapters.BadgesTableAdapter
    Friend WithEvents Db1DS As db1DS
    Friend WithEvents BadgesBindingSource As BindingSource
    Friend WithEvents Timer1 As Timer
End Class
