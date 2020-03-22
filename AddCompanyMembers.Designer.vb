<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompanyMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCompanyMembers))
        Me.companyid = New System.Windows.Forms.TextBox()
        Me.membername = New System.Windows.Forms.TextBox()
        Me.designation = New System.Windows.Forms.TextBox()
        Me.entrycode = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addmember = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'companyid
        '
        Me.companyid.Location = New System.Drawing.Point(23, 39)
        Me.companyid.Name = "companyid"
        Me.companyid.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(53, 20)
        Me.companyid.TabIndex = 1
        '
        'membername
        '
        Me.membername.Location = New System.Drawing.Point(23, 78)
        Me.membername.MaxLength = 50
        Me.membername.Name = "membername"
        Me.membername.Size = New System.Drawing.Size(136, 20)
        Me.membername.TabIndex = 1
        '
        'designation
        '
        Me.designation.Location = New System.Drawing.Point(169, 78)
        Me.designation.MaxLength = 50
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(136, 20)
        Me.designation.TabIndex = 1
        '
        'entrycode
        '
        Me.entrycode.Location = New System.Drawing.Point(23, 125)
        Me.entrycode.MaxLength = 4
        Me.entrycode.Name = "entrycode"
        Me.entrycode.Size = New System.Drawing.Size(76, 20)
        Me.entrycode.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(105, 125)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entry Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Company ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Entry Code Expiry"
        '
        'addmember
        '
        Me.addmember.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.addmember.FlatAppearance.BorderSize = 0
        Me.addmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addmember.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmember.ForeColor = System.Drawing.Color.White
        Me.addmember.Location = New System.Drawing.Point(187, 151)
        Me.addmember.Name = "addmember"
        Me.addmember.Size = New System.Drawing.Size(118, 33)
        Me.addmember.TabIndex = 4
        Me.addmember.Text = "Add Member"
        Me.addmember.UseVisualStyleBackColor = False
        '
        'AddCompanyMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 203)
        Me.Controls.Add(Me.addmember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.entrycode)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.membername)
        Me.Controls.Add(Me.companyid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddCompanyMembers"
        Me.Text = "Add Company Members - SecurityBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents companyid As TextBox
    Friend WithEvents membername As TextBox
    Friend WithEvents designation As TextBox
    Friend WithEvents entrycode As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addmember As Button
End Class
