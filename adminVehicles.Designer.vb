<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminVehicles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VehiclesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1DS = New SecurityBook.db1DS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.typecbx = New System.Windows.Forms.ComboBox()
        Me.colorbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.platebx = New System.Windows.Forms.TextBox()
        Me.Filterbtn = New System.Windows.Forms.Button()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.idbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.driverbx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.makebx = New System.Windows.Forms.TextBox()
        Me.modelbx = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.VehiclesTableAdapter = New SecurityBook.db1DSTableAdapters.VehiclesTableAdapter()
        Me.TableAdapterManager = New SecurityBook.db1DSTableAdapters.TableAdapterManager()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 5)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 27)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Vehicles"
        '
        'VehiclesDataGridView
        '
        Me.VehiclesDataGridView.AutoGenerateColumns = False
        Me.VehiclesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.VehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiclesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.VehiclesDataGridView.Cursor = System.Windows.Forms.Cursors.Cross
        Me.VehiclesDataGridView.DataSource = Me.VehiclesBindingSource
        Me.VehiclesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.VehiclesDataGridView.GridColor = System.Drawing.Color.WhiteSmoke
        Me.VehiclesDataGridView.Location = New System.Drawing.Point(3, 236)
        Me.VehiclesDataGridView.MultiSelect = False
        Me.VehiclesDataGridView.Name = "VehiclesDataGridView"
        Me.VehiclesDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VehiclesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VehiclesDataGridView.RowHeadersWidth = 4
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VehiclesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.VehiclesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VehiclesDataGridView.Size = New System.Drawing.Size(794, 261)
        Me.VehiclesDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "plate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Plate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "make"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Make"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "driver"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Driver Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "color"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time_in"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time In"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "time_out"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time Out"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'VehiclesBindingSource
        '
        Me.VehiclesBindingSource.DataMember = "Vehicles"
        Me.VehiclesBindingSource.DataSource = Me.Db1DS
        '
        'Db1DS
        '
        Me.Db1DS.DataSetName = "db1DS"
        Me.Db1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.typecbx)
        Me.GroupBox1.Controls.Add(Me.colorbx)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.platebx)
        Me.GroupBox1.Controls.Add(Me.Filterbtn)
        Me.GroupBox1.Controls.Add(Me.Resetbtn)
        Me.GroupBox1.Controls.Add(Me.idbx)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.driverbx)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.makebx)
        Me.GroupBox1.Controls.Add(Me.modelbx)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 169)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Type"
        '
        'typecbx
        '
        Me.typecbx.Font = New System.Drawing.Font("Microsoft New Tai Lue", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typecbx.FormattingEnabled = True
        Me.typecbx.Items.AddRange(New Object() {"4-Wheeler Private", "3-Wheeler Private", "Single MC Private", "Emergency Vehicle", "Truck Private", "PUJ", "PUV", "Delivery"})
        Me.typecbx.Location = New System.Drawing.Point(93, 73)
        Me.typecbx.Name = "typecbx"
        Me.typecbx.Size = New System.Drawing.Size(121, 21)
        Me.typecbx.TabIndex = 37
        '
        'colorbx
        '
        Me.colorbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorbx.Location = New System.Drawing.Point(6, 74)
        Me.colorbx.Name = "colorbx"
        Me.colorbx.Size = New System.Drawing.Size(81, 20)
        Me.colorbx.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Color"
        '
        'platebx
        '
        Me.platebx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.platebx.Location = New System.Drawing.Point(6, 33)
        Me.platebx.Name = "platebx"
        Me.platebx.Size = New System.Drawing.Size(81, 20)
        Me.platebx.TabIndex = 26
        '
        'Filterbtn
        '
        Me.Filterbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Filterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Filterbtn.FlatAppearance.BorderSize = 0
        Me.Filterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Filterbtn.ForeColor = System.Drawing.Color.White
        Me.Filterbtn.Location = New System.Drawing.Point(240, 127)
        Me.Filterbtn.Name = "Filterbtn"
        Me.Filterbtn.Size = New System.Drawing.Size(81, 35)
        Me.Filterbtn.TabIndex = 33
        Me.Filterbtn.Text = "Filter"
        Me.Filterbtn.UseVisualStyleBackColor = False
        '
        'Resetbtn
        '
        Me.Resetbtn.BackColor = System.Drawing.Color.Gainsboro
        Me.Resetbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Resetbtn.ForeColor = System.Drawing.Color.DimGray
        Me.Resetbtn.Location = New System.Drawing.Point(240, 96)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(81, 25)
        Me.Resetbtn.TabIndex = 34
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = False
        '
        'idbx
        '
        Me.idbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idbx.Location = New System.Drawing.Point(275, 33)
        Me.idbx.Name = "idbx"
        Me.idbx.Size = New System.Drawing.Size(39, 20)
        Me.idbx.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Plate Number"
        '
        'driverbx
        '
        Me.driverbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.driverbx.Location = New System.Drawing.Point(220, 74)
        Me.driverbx.Name = "driverbx"
        Me.driverbx.Size = New System.Drawing.Size(81, 20)
        Me.driverbx.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(90, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Make"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(217, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Driver Name"
        '
        'makebx
        '
        Me.makebx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makebx.Location = New System.Drawing.Point(93, 33)
        Me.makebx.Name = "makebx"
        Me.makebx.Size = New System.Drawing.Size(81, 20)
        Me.makebx.TabIndex = 28
        '
        'modelbx
        '
        Me.modelbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelbx.Location = New System.Drawing.Point(180, 33)
        Me.modelbx.Name = "modelbx"
        Me.modelbx.Size = New System.Drawing.Size(81, 20)
        Me.modelbx.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(177, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Model"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(123, 143)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 21
        Me.DateTimePicker1.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Filter by date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(120, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "to"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "from"
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
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
        'adminVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VehiclesDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminVehicles"
        Me.Size = New System.Drawing.Size(800, 500)
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Db1DS As db1DS
    Friend WithEvents VehiclesBindingSource As BindingSource
    Friend WithEvents VehiclesTableAdapter As db1DSTableAdapters.VehiclesTableAdapter
    Friend WithEvents TableAdapterManager As db1DSTableAdapters.TableAdapterManager
    Friend WithEvents VehiclesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents platebx As TextBox
    Friend WithEvents Filterbtn As Button
    Friend WithEvents Resetbtn As Button
    Friend WithEvents idbx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents driverbx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents makebx As TextBox
    Friend WithEvents modelbx As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents typecbx As ComboBox
    Friend WithEvents colorbx As TextBox
    Friend WithEvents Label2 As Label
End Class
