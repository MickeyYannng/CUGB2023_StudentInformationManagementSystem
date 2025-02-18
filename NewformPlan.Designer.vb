<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewformPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewformPlan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursePropertyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeePlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet7 = New _1004226104杨美琪_学生管理系统.SMSDataSet7()
        Me.SeePlanTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet7TableAdapters.SeePlanTableAdapter()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeePlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.TeacherDataGridViewTextBoxColumn, Me.CreditsDataGridViewTextBoxColumn, Me.AssessMethodDataGridViewTextBoxColumn, Me.CoursePropertyDataGridViewTextBoxColumn, Me.ClassTimeDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SeePlanBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 686)
        Me.DataGridView1.TabIndex = 14
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
        'CreditsDataGridViewTextBoxColumn
        '
        Me.CreditsDataGridViewTextBoxColumn.DataPropertyName = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.HeaderText = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CreditsDataGridViewTextBoxColumn.Name = "CreditsDataGridViewTextBoxColumn"
        Me.CreditsDataGridViewTextBoxColumn.Width = 200
        '
        'AssessMethodDataGridViewTextBoxColumn
        '
        Me.AssessMethodDataGridViewTextBoxColumn.DataPropertyName = "AssessMethod"
        Me.AssessMethodDataGridViewTextBoxColumn.HeaderText = "AssessMethod"
        Me.AssessMethodDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.AssessMethodDataGridViewTextBoxColumn.Name = "AssessMethodDataGridViewTextBoxColumn"
        Me.AssessMethodDataGridViewTextBoxColumn.Width = 200
        '
        'CoursePropertyDataGridViewTextBoxColumn
        '
        Me.CoursePropertyDataGridViewTextBoxColumn.DataPropertyName = "CourseProperty"
        Me.CoursePropertyDataGridViewTextBoxColumn.HeaderText = "CourseProperty"
        Me.CoursePropertyDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CoursePropertyDataGridViewTextBoxColumn.Name = "CoursePropertyDataGridViewTextBoxColumn"
        Me.CoursePropertyDataGridViewTextBoxColumn.Width = 200
        '
        'ClassTimeDataGridViewTextBoxColumn
        '
        Me.ClassTimeDataGridViewTextBoxColumn.DataPropertyName = "ClassTime"
        Me.ClassTimeDataGridViewTextBoxColumn.HeaderText = "ClassTime"
        Me.ClassTimeDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ClassTimeDataGridViewTextBoxColumn.Name = "ClassTimeDataGridViewTextBoxColumn"
        Me.ClassTimeDataGridViewTextBoxColumn.Width = 200
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 200
        '
        'SeePlanBindingSource
        '
        Me.SeePlanBindingSource.DataMember = "SeePlan"
        Me.SeePlanBindingSource.DataSource = Me.SMSDataSet7
        '
        'SMSDataSet7
        '
        Me.SMSDataSet7.DataSetName = "SMSDataSet7"
        Me.SMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeePlanTableAdapter
        '
        Me.SeePlanTableAdapter.ClearBeforeFill = True
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1062, 65)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 23
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(624, 65)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 22
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'NewformPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 864)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NewformPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "教学任务管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeePlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMSDataSet7 As SMSDataSet7
    Friend WithEvents SeePlanBindingSource As BindingSource
    Friend WithEvents SeePlanTableAdapter As SMSDataSet7TableAdapters.SeePlanTableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssessMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoursePropertyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnButton As Button
    Friend WithEvents InsertButton As Button
End Class
