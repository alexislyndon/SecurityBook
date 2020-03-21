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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.closelbl = New System.Windows.Forms.PictureBox()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD COMPANY MEMBERS"
        '
        'companyid
        '
        Me.companyid.Location = New System.Drawing.Point(46, 94)
        Me.companyid.Name = "companyid"
        Me.companyid.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(53, 20)
        Me.companyid.TabIndex = 1
        '
        'name
        '
        Me.membername.Location = New System.Drawing.Point(46, 133)
        Me.membername.MaxLength = 50
        Me.membername.Name = "name"
        Me.membername.Size = New System.Drawing.Size(136, 20)
        Me.membername.TabIndex = 1
        '
        'designation
        '
        Me.designation.Location = New System.Drawing.Point(205, 133)
        Me.designation.MaxLength = 50
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(136, 20)
        Me.designation.TabIndex = 1
        '
        'entrycode
        '
        Me.entrycode.Location = New System.Drawing.Point(46, 180)
        Me.entrycode.MaxLength = 4
        Me.entrycode.Name = "entrycode"
        Me.entrycode.Size = New System.Drawing.Size(76, 20)
        Me.entrycode.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entry Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Company ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Entry Code Expiry"
        '
        'addmember
        '
        Me.addmember.Location = New System.Drawing.Point(330, 223)
        Me.addmember.Name = "addmember"
        Me.addmember.Size = New System.Drawing.Size(75, 23)
        Me.addmember.TabIndex = 4
        Me.addmember.Text = "Add Member"
        Me.addmember.UseVisualStyleBackColor = True
        '
        'closelbl
        '
        Me.closelbl.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closelbl.Location = New System.Drawing.Point(388, -3)
        Me.closelbl.Name = "closelbl"
        Me.closelbl.Size = New System.Drawing.Size(36, 36)
        Me.closelbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelbl.TabIndex = 5
        Me.closelbl.TabStop = False
        '
        'AddCompanyMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.closelbl)
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
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "AddCompanyMembers"
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents closelbl As PictureBox
End Class
