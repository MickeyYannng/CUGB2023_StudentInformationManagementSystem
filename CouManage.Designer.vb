<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouManage
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CouManage))
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSetTableAdapters.StudentTableAdapter()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet = New _1004226104杨美琪_学生管理系统.SMSDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet1 = New _1004226104杨美琪_学生管理系统.SMSDataSet1()
        Me.CourseTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet1TableAdapters.CourseTableAdapter()
        Me.SelCoButton = New System.Windows.Forms.Button()
        Me.AlSolCoButton = New System.Windows.Forms.Button()
        Me.SeeplanButton = New System.Windows.Forms.Button()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.UpdateButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(845, 42)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(124, 60)
        Me.UpdateButton.TabIndex = 19
        Me.UpdateButton.Text = "更新"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(558, 42)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 17
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "当前课程："
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.Location = New System.Drawing.Point(700, 42)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(124, 60)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "删除"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1295, 42)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 16
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(241, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 35)
        Me.TextBox1.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(43, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 32)
        Me.ComboBox1.TabIndex = 13
        '
        'QueryButton
        '
        Me.QueryButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.QueryButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QueryButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.QueryButton.Location = New System.Drawing.Point(414, 42)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(124, 60)
        Me.QueryButton.TabIndex = 12
        Me.QueryButton.Text = "查询"
        Me.QueryButton.UseVisualStyleBackColor = False
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.TeacherDataGridViewTextBoxColumn, Me.StaDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.AssessMethodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CourseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1488, 694)
        Me.DataGridView1.TabIndex = 10
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.Width = 200
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.Width = 200
        '
        'TeacherDataGridViewTextBoxColumn
        '
        Me.TeacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher"
        Me.TeacherDataGridViewTextBoxColumn.HeaderText = "Teacher"
        Me.TeacherDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.TeacherDataGridViewTextBoxColumn.Name = "TeacherDataGridViewTextBoxColumn"
        Me.TeacherDataGridViewTextBoxColumn.Width = 200
        '
        'StaDateDataGridViewTextBoxColumn
        '
        Me.StaDateDataGridViewTextBoxColumn.DataPropertyName = "StaDate"
        Me.StaDateDataGridViewTextBoxColumn.HeaderText = "StaDate"
        Me.StaDateDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.StaDateDataGridViewTextBoxColumn.Name = "StaDateDataGridViewTextBoxColumn"
        Me.StaDateDataGridViewTextBoxColumn.Width = 200
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "EndDate"
        Me.EndDateDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.Width = 200
        '
        'AssessMethodDataGridViewTextBoxColumn
        '
        Me.AssessMethodDataGridViewTextBoxColumn.DataPropertyName = "AssessMethod"
        Me.AssessMethodDataGridViewTextBoxColumn.HeaderText = "AssessMethod"
        Me.AssessMethodDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.AssessMethodDataGridViewTextBoxColumn.Name = "AssessMethodDataGridViewTextBoxColumn"
        Me.AssessMethodDataGridViewTextBoxColumn.Width = 200
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.SMSDataSet1
        '
        'SMSDataSet1
        '
        Me.SMSDataSet1.DataSetName = "SMSDataSet1"
        Me.SMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'SelCoButton
        '
        Me.SelCoButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SelCoButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SelCoButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SelCoButton.Location = New System.Drawing.Point(987, 41)
        Me.SelCoButton.Name = "SelCoButton"
        Me.SelCoButton.Size = New System.Drawing.Size(124, 61)
        Me.SelCoButton.TabIndex = 20
        Me.SelCoButton.Text = "选课"
        Me.SelCoButton.UseVisualStyleBackColor = False
        '
        'AlSolCoButton
        '
        Me.AlSolCoButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.AlSolCoButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AlSolCoButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AlSolCoButton.Location = New System.Drawing.Point(1117, 39)
        Me.AlSolCoButton.Name = "AlSolCoButton"
        Me.AlSolCoButton.Size = New System.Drawing.Size(172, 65)
        Me.AlSolCoButton.TabIndex = 21
        Me.AlSolCoButton.Text = "已选课程"
        Me.AlSolCoButton.UseVisualStyleBackColor = False
        '
        'SeeplanButton
        '
        Me.SeeplanButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SeeplanButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SeeplanButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SeeplanButton.Location = New System.Drawing.Point(998, 43)
        Me.SeeplanButton.Name = "SeeplanButton"
        Me.SeeplanButton.Size = New System.Drawing.Size(276, 61)
        Me.SeeplanButton.TabIndex = 22
        Me.SeeplanButton.Text = "查看教学任务"
        Me.SeeplanButton.UseVisualStyleBackColor = False
        '
        'CouManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.SeeplanButton)
        Me.Controls.Add(Me.AlSolCoButton)
        Me.Controls.Add(Me.SelCoButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.QueryButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CouManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生课程管理"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentTableAdapter As SMSDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents QueryButton As Button
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents SMSDataSet As SMSDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMSDataSet1 As SMSDataSet1
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As SMSDataSet1TableAdapters.CourseTableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssessMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SelCoButton As Button
    Friend WithEvents AlSolCoButton As Button
    Friend WithEvents SeeplanButton As Button
End Class
