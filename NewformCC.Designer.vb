<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewformCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewformCC))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet11 = New _1004226104杨美琪_学生管理系统.SMSDataSet11()
        Me.ClassCourseTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet11TableAdapters.ClassCourseTableAdapter()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassIDDataGridViewTextBoxColumn, Me.ClassNameDataGridViewTextBoxColumn, Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassCourseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 694)
        Me.DataGridView1.TabIndex = 29
        '
        'ClassIDDataGridViewTextBoxColumn
        '
        Me.ClassIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID"
        Me.ClassIDDataGridViewTextBoxColumn.HeaderText = "ClassID"
        Me.ClassIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClassIDDataGridViewTextBoxColumn.Name = "ClassIDDataGridViewTextBoxColumn"
        Me.ClassIDDataGridViewTextBoxColumn.Width = 200
        '
        'ClassNameDataGridViewTextBoxColumn
        '
        Me.ClassNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName"
        Me.ClassNameDataGridViewTextBoxColumn.HeaderText = "ClassName"
        Me.ClassNameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClassNameDataGridViewTextBoxColumn.Name = "ClassNameDataGridViewTextBoxColumn"
        Me.ClassNameDataGridViewTextBoxColumn.Width = 200
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
        'ClassCourseBindingSource
        '
        Me.ClassCourseBindingSource.DataMember = "ClassCourse"
        Me.ClassCourseBindingSource.DataSource = Me.SMSDataSet11
        '
        'SMSDataSet11
        '
        Me.SMSDataSet11.DataSetName = "SMSDataSet11"
        Me.SMSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassCourseTableAdapter
        '
        Me.ClassCourseTableAdapter.ClearBeforeFill = True
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1090, 51)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 31
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(652, 51)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 30
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'NewformCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 864)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NewformCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "班级课程管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMSDataSet11 As SMSDataSet11
    Friend WithEvents ClassCourseBindingSource As BindingSource
    Friend WithEvents ClassCourseTableAdapter As SMSDataSet11TableAdapters.ClassCourseTableAdapter
    Friend WithEvents ClassIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnButton As Button
    Friend WithEvents InsertButton As Button
End Class
