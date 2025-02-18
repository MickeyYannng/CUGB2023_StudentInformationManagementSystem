<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonInfo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonInfo))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollYearDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthYearDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet = New _1004226104杨美琪_学生管理系统.SMSDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.StudentTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSetTableAdapters.StudentTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SMSDataSet3 = New _1004226104杨美琪_学生管理系统.SMSDataSet3()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet3TableAdapters.TeacherTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnoDataGridViewTextBoxColumn1, Me.CnoDataGridViewTextBoxColumn1, Me.SnameDataGridViewTextBoxColumn1, Me.EnrollYearDataGridViewTextBoxColumn1, Me.BirthYearDataGridViewTextBoxColumn1, Me.MajorDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1488, 687)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'SnoDataGridViewTextBoxColumn1
        '
        Me.SnoDataGridViewTextBoxColumn1.DataPropertyName = "Sno"
        Me.SnoDataGridViewTextBoxColumn1.HeaderText = "Sno"
        Me.SnoDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.SnoDataGridViewTextBoxColumn1.Name = "SnoDataGridViewTextBoxColumn1"
        Me.SnoDataGridViewTextBoxColumn1.Width = 200
        '
        'CnoDataGridViewTextBoxColumn1
        '
        Me.CnoDataGridViewTextBoxColumn1.DataPropertyName = "Cno"
        Me.CnoDataGridViewTextBoxColumn1.HeaderText = "Cno"
        Me.CnoDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.CnoDataGridViewTextBoxColumn1.Name = "CnoDataGridViewTextBoxColumn1"
        Me.CnoDataGridViewTextBoxColumn1.Width = 200
        '
        'SnameDataGridViewTextBoxColumn1
        '
        Me.SnameDataGridViewTextBoxColumn1.DataPropertyName = "Sname"
        Me.SnameDataGridViewTextBoxColumn1.HeaderText = "Sname"
        Me.SnameDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.SnameDataGridViewTextBoxColumn1.Name = "SnameDataGridViewTextBoxColumn1"
        Me.SnameDataGridViewTextBoxColumn1.Width = 200
        '
        'EnrollYearDataGridViewTextBoxColumn1
        '
        Me.EnrollYearDataGridViewTextBoxColumn1.DataPropertyName = "EnrollYear"
        Me.EnrollYearDataGridViewTextBoxColumn1.HeaderText = "EnrollYear"
        Me.EnrollYearDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.EnrollYearDataGridViewTextBoxColumn1.Name = "EnrollYearDataGridViewTextBoxColumn1"
        Me.EnrollYearDataGridViewTextBoxColumn1.Width = 200
        '
        'BirthYearDataGridViewTextBoxColumn1
        '
        Me.BirthYearDataGridViewTextBoxColumn1.DataPropertyName = "BirthYear"
        Me.BirthYearDataGridViewTextBoxColumn1.HeaderText = "BirthYear"
        Me.BirthYearDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.BirthYearDataGridViewTextBoxColumn1.Name = "BirthYearDataGridViewTextBoxColumn1"
        Me.BirthYearDataGridViewTextBoxColumn1.Width = 200
        '
        'MajorDataGridViewTextBoxColumn1
        '
        Me.MajorDataGridViewTextBoxColumn1.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn1.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.MajorDataGridViewTextBoxColumn1.Name = "MajorDataGridViewTextBoxColumn1"
        Me.MajorDataGridViewTextBoxColumn1.Width = 200
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.SMSDataSet
        '
        'SMSDataSet
        '
        Me.SMSDataSet.DataSetName = "SMSDataSet"
        Me.SMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("楷体", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "我的信息:"
        '
        'QueryButton
        '
        Me.QueryButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.QueryButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QueryButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.QueryButton.Location = New System.Drawing.Point(524, 39)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(124, 60)
        Me.QueryButton.TabIndex = 2
        Me.QueryButton.Text = "查询"
        Me.QueryButton.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 32)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(297, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 35)
        Me.TextBox1.TabIndex = 4
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1315, 39)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 6
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "当前学生："
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(686, 40)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 7
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.Location = New System.Drawing.Point(852, 41)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(124, 60)
        Me.DeleteButton.TabIndex = 8
        Me.DeleteButton.Text = "删除"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.UpdateButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(1011, 40)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(124, 60)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "更新"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'SMSDataSet3
        '
        Me.SMSDataSet3.DataSetName = "SMSDataSet3"
        Me.SMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "Teacher"
        Me.TeacherBindingSource.DataSource = Me.SMSDataSet3
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TnoDataGridViewTextBoxColumn, Me.TnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.BirthYearDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TeacherBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(0, -467)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 82
        Me.DataGridView2.RowTemplate.Height = 37
        Me.DataGridView2.Size = New System.Drawing.Size(1488, 647)
        Me.DataGridView2.TabIndex = 10
        '
        'TnoDataGridViewTextBoxColumn
        '
        Me.TnoDataGridViewTextBoxColumn.DataPropertyName = "Tno"
        Me.TnoDataGridViewTextBoxColumn.HeaderText = "Tno"
        Me.TnoDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.TnoDataGridViewTextBoxColumn.Name = "TnoDataGridViewTextBoxColumn"
        Me.TnoDataGridViewTextBoxColumn.Width = 200
        '
        'TnameDataGridViewTextBoxColumn
        '
        Me.TnameDataGridViewTextBoxColumn.DataPropertyName = "Tname"
        Me.TnameDataGridViewTextBoxColumn.HeaderText = "Tname"
        Me.TnameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.TnameDataGridViewTextBoxColumn.Name = "TnameDataGridViewTextBoxColumn"
        Me.TnameDataGridViewTextBoxColumn.Width = 200
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 200
        '
        'BirthYearDataGridViewTextBoxColumn
        '
        Me.BirthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear"
        Me.BirthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear"
        Me.BirthYearDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.BirthYearDataGridViewTextBoxColumn.Name = "BirthYearDataGridViewTextBoxColumn"
        Me.BirthYearDataGridViewTextBoxColumn.Width = 200
        '
        'MajorDataGridViewTextBoxColumn
        '
        Me.MajorDataGridViewTextBoxColumn.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.MajorDataGridViewTextBoxColumn.Name = "MajorDataGridViewTextBoxColumn"
        Me.MajorDataGridViewTextBoxColumn.Width = 200
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 200
        '
        'PersonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.QueryButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PersonInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "信息管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents QueryButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ReturnButton As Button
    Friend WithEvents SMSDataSet As SMSDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As SMSDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents InsertButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents SMSDataSet3 As SMSDataSet3
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As SMSDataSet3TableAdapters.TeacherTableAdapter
    Friend WithEvents SnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CnoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EnrollYearDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BirthYearDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
