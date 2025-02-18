<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selected
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Selected))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet2 = New _1004226104杨美琪_学生管理系统.SMSDataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectedTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet2TableAdapters.SelectedTableAdapter()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnoDataGridViewTextBoxColumn, Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.TeacherDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SelectedBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1488, 691)
        Me.DataGridView1.TabIndex = 0
        '
        'SnoDataGridViewTextBoxColumn
        '
        Me.SnoDataGridViewTextBoxColumn.DataPropertyName = "Sno"
        Me.SnoDataGridViewTextBoxColumn.HeaderText = "Sno"
        Me.SnoDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SnoDataGridViewTextBoxColumn.Name = "SnoDataGridViewTextBoxColumn"
        Me.SnoDataGridViewTextBoxColumn.Width = 200
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
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.Width = 200
        '
        'SelectedBindingSource
        '
        Me.SelectedBindingSource.DataMember = "Selected"
        Me.SelectedBindingSource.DataSource = Me.SMSDataSet2
        '
        'SMSDataSet2
        '
        Me.SMSDataSet2.DataSetName = "SMSDataSet2"
        Me.SMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(72, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 33)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "我的已选课程："
        '
        'SelectedTableAdapter
        '
        Me.SelectedTableAdapter.ClearBeforeFill = True
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.Location = New System.Drawing.Point(1070, 58)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(124, 60)
        Me.DeleteButton.TabIndex = 20
        Me.DeleteButton.Text = "删除"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1274, 58)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 19
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'Selected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Selected"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生选课管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents SMSDataSet2 As SMSDataSet2
    Friend WithEvents SelectedBindingSource As BindingSource
    Friend WithEvents SelectedTableAdapter As SMSDataSet2TableAdapters.SelectedTableAdapter
    Friend WithEvents SnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ReturnButton As Button
End Class
