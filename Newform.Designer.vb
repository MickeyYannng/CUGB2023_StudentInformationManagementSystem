<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Newform))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssessMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet1 = New _1004226104杨美琪_学生管理系统.SMSDataSet1()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.SMSDataSet2 = New _1004226104杨美琪_学生管理系统.SMSDataSet2()
        Me.SMSDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet1TableAdapters.CourseTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.TeacherDataGridViewTextBoxColumn, Me.StaDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.AssessMethodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CourseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 686)
        Me.DataGridView1.TabIndex = 11
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
        Me.CourseBindingSource.DataSource = Me.SMSDataSet1BindingSource
        '
        'SMSDataSet1BindingSource
        '
        Me.SMSDataSet1BindingSource.DataSource = Me.SMSDataSet1
        Me.SMSDataSet1BindingSource.Position = 0
        '
        'SMSDataSet1
        '
        Me.SMSDataSet1.DataSetName = "SMSDataSet1"
        Me.SMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(627, 58)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 18
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1065, 58)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 19
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'SMSDataSet2
        '
        Me.SMSDataSet2.DataSetName = "SMSDataSet2"
        Me.SMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SMSDataSet2BindingSource
        '
        Me.SMSDataSet2BindingSource.DataSource = Me.SMSDataSet2
        Me.SMSDataSet2BindingSource.Position = 0
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'Newform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 864)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Newform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "课程信息管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InsertButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents SMSDataSet2BindingSource As BindingSource
    Friend WithEvents SMSDataSet2 As SMSDataSet2
    Friend WithEvents SMSDataSet1BindingSource As BindingSource
    Friend WithEvents SMSDataSet1 As SMSDataSet1
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As SMSDataSet1TableAdapters.CourseTableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssessMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
