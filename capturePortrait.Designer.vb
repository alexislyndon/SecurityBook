<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturePortrait
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Freeze = New System.Windows.Forms.Button()
        Me.Unfreeze = New System.Windows.Forms.Button()
        Me.closelbl = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(24, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.GreenYellow
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.Black
        Me.Save.Location = New System.Drawing.Point(269, 286)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 33)
        Me.Save.TabIndex = 1
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Freeze
        '
        Me.Freeze.BackColor = System.Drawing.Color.Aqua
        Me.Freeze.FlatAppearance.BorderSize = 0
        Me.Freeze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Freeze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Freeze.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Freeze.ForeColor = System.Drawing.Color.Black
        Me.Freeze.Location = New System.Drawing.Point(24, 5)
        Me.Freeze.Name = "Freeze"
        Me.Freeze.Size = New System.Drawing.Size(63, 29)
        Me.Freeze.TabIndex = 1
        Me.Freeze.Text = "Freeze"
        Me.Freeze.UseVisualStyleBackColor = False
        '
        'Unfreeze
        '
        Me.Unfreeze.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Unfreeze.FlatAppearance.BorderSize = 0
        Me.Unfreeze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Unfreeze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Unfreeze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Unfreeze.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unfreeze.ForeColor = System.Drawing.Color.Black
        Me.Unfreeze.Location = New System.Drawing.Point(93, 5)
        Me.Unfreeze.Name = "Unfreeze"
        Me.Unfreeze.Size = New System.Drawing.Size(69, 29)
        Me.Unfreeze.TabIndex = 1
        Me.Unfreeze.Text = "Unfreeze"
        Me.Unfreeze.UseVisualStyleBackColor = False
        '
        'closelbl
        '
        Me.closelbl.Image = Global.SecurityBook.My.Resources.Resources.Contols___Add_On_36_512
        Me.closelbl.Location = New System.Drawing.Point(335, -2)
        Me.closelbl.Name = "closelbl"
        Me.closelbl.Size = New System.Drawing.Size(36, 36)
        Me.closelbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelbl.TabIndex = 2
        Me.closelbl.TabStop = False
        '
        'capturePortrait
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.closelbl)
        Me.Controls.Add(Me.Unfreeze)
        Me.Controls.Add(Me.Freeze)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "capturePortrait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closelbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Save As Button
    Friend WithEvents Freeze As Button
    Friend WithEvents Unfreeze As Button
    Friend WithEvents closelbl As PictureBox
End Class
