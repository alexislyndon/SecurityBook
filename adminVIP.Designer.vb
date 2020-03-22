<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminVIP
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addCompany = New System.Windows.Forms.Button()
        Me.addMembers = New System.Windows.Forms.Button()
        Me.CompanyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1DS = New SecurityBook.db1DS()
        Me.Company_MembersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyloginsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyloginsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SecurityBook.db1DSTableAdapters.TableAdapterManager()
        Me.CompanyTableAdapter = New SecurityBook.db1DSTableAdapters.CompanyTableAdapter()
        Me.Company_MembersTableAdapter = New SecurityBook.db1DSTableAdapters.Company_MembersTableAdapter()
        Me.CompanyloginsTableAdapter = New SecurityBook.db1DSTableAdapters.companyloginsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyloginsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyloginsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(543, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGINS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MEMBERS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "COMPANY"
        '
        'addCompany
        '
        Me.addCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.addCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addCompany.FlatAppearance.BorderSize = 0
        Me.addCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addCompany.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCompany.ForeColor = System.Drawing.Color.White
        Me.addCompany.Location = New System.Drawing.Point(114, 77)
        Me.addCompany.Name = "addCompany"
        Me.addCompany.Size = New System.Drawing.Size(106, 23)
        Me.addCompany.TabIndex = 5
        Me.addCompany.Text = "Add company"
        Me.addCompany.UseVisualStyleBackColor = False
        '
        'addMembers
        '
        Me.addMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.addMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addMembers.FlatAppearance.BorderSize = 0
        Me.addMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addMembers.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMembers.ForeColor = System.Drawing.Color.White
        Me.addMembers.Location = New System.Drawing.Point(395, 74)
        Me.addMembers.Name = "addMembers"
        Me.addMembers.Size = New System.Drawing.Size(102, 23)
        Me.addMembers.TabIndex = 5
        Me.addMembers.Text = "Add members"
        Me.addMembers.UseVisualStyleBackColor = False
        '
        'CompanyDataGridView
        '
        Me.CompanyDataGridView.AutoGenerateColumns = False
        Me.CompanyDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CompanyDataGridView.DataSource = Me.CompanyBindingSource
        Me.CompanyDataGridView.Location = New System.Drawing.Point(20, 103)
        Me.CompanyDataGridView.Name = "CompanyDataGridView"
        Me.CompanyDataGridView.ReadOnly = True
        Me.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompanyDataGridView.Size = New System.Drawing.Size(200, 380)
        Me.CompanyDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "supervisor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "supervisor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "superphone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "superphone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.Db1DS
        '
        'Db1DS
        '
        Me.Db1DS.DataSetName = "db1DS"
        Me.Db1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_MembersDataGridView
        '
        Me.Company_MembersDataGridView.AutoGenerateColumns = False
        Me.Company_MembersDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Company_MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Company_MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Company_MembersDataGridView.DataSource = Me.Company_MembersBindingSource
        Me.Company_MembersDataGridView.Location = New System.Drawing.Point(273, 103)
        Me.Company_MembersDataGridView.Name = "Company_MembersDataGridView"
        Me.Company_MembersDataGridView.ReadOnly = True
        Me.Company_MembersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Company_MembersDataGridView.Size = New System.Drawing.Size(224, 380)
        Me.Company_MembersDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "companyid"
        Me.DataGridViewTextBoxColumn7.HeaderText = "companyid"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "designation"
        Me.DataGridViewTextBoxColumn9.HeaderText = "designation"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "entrycode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "entrycode"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "expiry"
        Me.DataGridViewTextBoxColumn11.HeaderText = "expiry"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Company_MembersBindingSource
        '
        Me.Company_MembersBindingSource.DataMember = "Company_Members"
        Me.Company_MembersBindingSource.DataSource = Me.Db1DS
        '
        'CompanyloginsDataGridView
        '
        Me.CompanyloginsDataGridView.AutoGenerateColumns = False
        Me.CompanyloginsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.CompanyloginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyloginsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.CompanyloginsDataGridView.DataSource = Me.CompanyloginsBindingSource
        Me.CompanyloginsDataGridView.Location = New System.Drawing.Point(546, 103)
        Me.CompanyloginsDataGridView.Name = "CompanyloginsDataGridView"
        Me.CompanyloginsDataGridView.ReadOnly = True
        Me.CompanyloginsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompanyloginsDataGridView.Size = New System.Drawing.Size(225, 380)
        Me.CompanyloginsDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "code"
        Me.DataGridViewTextBoxColumn13.HeaderText = "code"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "timein"
        Me.DataGridViewTextBoxColumn14.HeaderText = "timein"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "timeout"
        Me.DataGridViewTextBoxColumn15.HeaderText = "timeout"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "gatein"
        Me.DataGridViewTextBoxColumn16.HeaderText = "gatein"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "gateout"
        Me.DataGridViewTextBoxColumn17.HeaderText = "gateout"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'CompanyloginsBindingSource
        '
        Me.CompanyloginsBindingSource.DataMember = "companylogins"
        Me.CompanyloginsBindingSource.DataSource = Me.Db1DS
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BadgesTableAdapter = Nothing
        Me.TableAdapterManager.Company_MembersTableAdapter = Nothing
        Me.TableAdapterManager.companyloginsTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.mainbackTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SecurityBook.db1DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager.VIPTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'Company_MembersTableAdapter
        '
        Me.Company_MembersTableAdapter.ClearBeforeFill = True
        '
        'CompanyloginsTableAdapter
        '
        Me.CompanyloginsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 5)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 27)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Verified Incoming Persons(VIP)"
        '
        'adminVIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CompanyloginsDataGridView)
        Me.Controls.Add(Me.Company_MembersDataGridView)
        Me.Controls.Add(Me.CompanyDataGridView)
        Me.Controls.Add(Me.addMembers)
        Me.Controls.Add(Me.addCompany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminVIP"
        Me.Size = New System.Drawing.Size(800, 500)
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyloginsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyloginsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db1DS As db1DS
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As db1DSTableAdapters.TableAdapterManager
    Friend WithEvents Company_MembersBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CompanyloginsBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addCompany As Button
    Friend WithEvents addMembers As Button
    Friend WithEvents CompanyTableAdapter As db1DSTableAdapters.CompanyTableAdapter
    Friend WithEvents CompanyDataGridView As DataGridView
    Friend WithEvents Company_MembersTableAdapter As db1DSTableAdapters.Company_MembersTableAdapter
    Friend WithEvents Company_MembersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents CompanyloginsTableAdapter As db1DSTableAdapters.companyloginsTableAdapter
    Friend WithEvents CompanyloginsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
