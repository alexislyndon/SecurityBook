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
        Me.CompanyDataGridView = New System.Windows.Forms.DataGridView()
        Me.Company_MembersDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompanyloginsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyloginsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1DS = New SecurityBook.db1DS()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Company_MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New SecurityBook.db1DSTableAdapters.CompanyTableAdapter()
        Me.TableAdapterManager = New SecurityBook.db1DSTableAdapters.TableAdapterManager()
        Me.Company_MembersTableAdapter = New SecurityBook.db1DSTableAdapters.Company_MembersTableAdapter()
        Me.CompanyloginsTableAdapter = New SecurityBook.db1DSTableAdapters.companyloginsTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyloginsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyloginsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyDataGridView
        '
        Me.CompanyDataGridView.AutoGenerateColumns = False
        Me.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CompanyDataGridView.DataSource = Me.CompanyBindingSource
        Me.CompanyDataGridView.Location = New System.Drawing.Point(3, 44)
        Me.CompanyDataGridView.Name = "CompanyDataGridView"
        Me.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompanyDataGridView.Size = New System.Drawing.Size(280, 408)
        Me.CompanyDataGridView.TabIndex = 1
        '
        'Company_MembersDataGridView
        '
        Me.Company_MembersDataGridView.AutoGenerateColumns = False
        Me.Company_MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Company_MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Company_MembersDataGridView.DataSource = Me.Company_MembersBindingSource
        Me.Company_MembersDataGridView.Location = New System.Drawing.Point(348, 44)
        Me.Company_MembersDataGridView.Name = "Company_MembersDataGridView"
        Me.Company_MembersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Company_MembersDataGridView.Size = New System.Drawing.Size(258, 408)
        Me.Company_MembersDataGridView.TabIndex = 1
        '
        'CompanyloginsDataGridView
        '
        Me.CompanyloginsDataGridView.AutoGenerateColumns = False
        Me.CompanyloginsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompanyloginsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CompanyloginsDataGridView.DataSource = Me.CompanyloginsBindingSource
        Me.CompanyloginsDataGridView.Location = New System.Drawing.Point(689, 44)
        Me.CompanyloginsDataGridView.Name = "CompanyloginsDataGridView"
        Me.CompanyloginsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CompanyloginsDataGridView.Size = New System.Drawing.Size(274, 408)
        Me.CompanyloginsDataGridView.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(813, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGINS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MEMBERS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "COMPANY"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(295, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 86)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "code"
        Me.DataGridViewTextBoxColumn12.HeaderText = "code"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "timein"
        Me.DataGridViewTextBoxColumn13.HeaderText = "timein"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "timeout"
        Me.DataGridViewTextBoxColumn14.HeaderText = "timeout"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "gatein"
        Me.DataGridViewTextBoxColumn15.HeaderText = "gatein"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "gateout"
        Me.DataGridViewTextBoxColumn16.HeaderText = "gateout"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'CompanyloginsBindingSource
        '
        Me.CompanyloginsBindingSource.DataMember = "companylogins"
        Me.CompanyloginsBindingSource.DataSource = Me.Db1DS
        '
        'Db1DS
        '
        Me.Db1DS.DataSetName = "db1DS"
        Me.Db1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "designation"
        Me.DataGridViewTextBoxColumn8.HeaderText = "designation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "entrycode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "entrycode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "expiry"
        Me.DataGridViewTextBoxColumn10.HeaderText = "expiry"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Company_MembersBindingSource
        '
        Me.Company_MembersBindingSource.DataMember = "Company_Members"
        Me.Company_MembersBindingSource.DataSource = Me.Db1DS
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "supervisor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "supervisor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "superphone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "superphone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.Db1DS
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BadgesTableAdapter = Nothing
        Me.TableAdapterManager.Company_MembersTableAdapter = Me.Company_MembersTableAdapter
        Me.TableAdapterManager.companyloginsTableAdapter = Me.CompanyloginsTableAdapter
        Me.TableAdapterManager.CompanyTableAdapter = Me.CompanyTableAdapter
        Me.TableAdapterManager.UpdateOrder = SecurityBook.db1DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager.VIPTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'Company_MembersTableAdapter
        '
        Me.Company_MembersTableAdapter.ClearBeforeFill = True
        '
        'CompanyloginsTableAdapter
        '
        Me.CompanyloginsTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Add company"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(504, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Add members"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'adminVIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyloginsDataGridView)
        Me.Controls.Add(Me.Company_MembersDataGridView)
        Me.Controls.Add(Me.CompanyDataGridView)
        Me.Name = "adminVIP"
        Me.Size = New System.Drawing.Size(1039, 500)
        CType(Me.CompanyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyloginsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyloginsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db1DS As db1DS
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As db1DSTableAdapters.CompanyTableAdapter
    Friend WithEvents TableAdapterManager As db1DSTableAdapters.TableAdapterManager
    Friend WithEvents Company_MembersTableAdapter As db1DSTableAdapters.Company_MembersTableAdapter
    Friend WithEvents CompanyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Company_MembersBindingSource As BindingSource
    Friend WithEvents Company_MembersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents CompanyloginsTableAdapter As db1DSTableAdapters.companyloginsTableAdapter
    Friend WithEvents CompanyloginsBindingSource As BindingSource
    Friend WithEvents CompanyloginsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
