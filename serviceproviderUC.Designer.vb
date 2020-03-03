<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serviceproviderUC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CompanyloginsTableAdapter1 = New SecurityBook.db1DSTableAdapters.companyloginsTableAdapter()
        Me.CompanyTableAdapter1 = New SecurityBook.db1DSTableAdapters.CompanyTableAdapter()
        Me.Company_MembersTableAdapter1 = New SecurityBook.db1DSTableAdapters.Company_MembersTableAdapter()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(414, 418)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 89)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SERVICE PROVIDERS' LOGIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter entry Code"
        '
        'CompanyloginsTableAdapter1
        '
        Me.CompanyloginsTableAdapter1.ClearBeforeFill = True
        '
        'CompanyTableAdapter1
        '
        Me.CompanyTableAdapter1.ClearBeforeFill = True
        '
        'Company_MembersTableAdapter1
        '
        Me.Company_MembersTableAdapter1.ClearBeforeFill = True
        '
        'serviceproviderUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "serviceproviderUC"
        Me.Size = New System.Drawing.Size(1116, 768)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CompanyloginsTableAdapter1 As db1DSTableAdapters.companyloginsTableAdapter
    Friend WithEvents CompanyTableAdapter1 As db1DSTableAdapters.CompanyTableAdapter
    Friend WithEvents Company_MembersTableAdapter1 As db1DSTableAdapters.Company_MembersTableAdapter
End Class
