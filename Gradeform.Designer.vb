<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gradeform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gradeform))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet12 = New _1004226104杨美琪_学生管理系统.SMSDataSet12()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.SelectedTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet12TableAdapters.SelectedTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1515, 659)
        Me.DataGridView1.TabIndex = 2
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
        Me.SelectedBindingSource.DataSource = Me.SMSDataSet12
        '
        'SMSDataSet12
        '
        Me.SMSDataSet12.DataSetName = "SMSDataSet12"
        Me.SMSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QueryButton
        '
        Me.QueryButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.QueryButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QueryButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.QueryButton.Location = New System.Drawing.Point(495, 49)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(124, 60)
        Me.QueryButton.TabIndex = 31
        Me.QueryButton.Text = "查询"
        Me.QueryButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(288, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 35)
        Me.TextBox1.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(90, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 32)
        Me.ComboBox1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(84, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "当前学生："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(688, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 33)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "提示：直接在单元格即可修改成绩"
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1269, 47)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 34
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'SelectedTableAdapter
        '
        Me.SelectedTableAdapter.ClearBeforeFill = True
        '
        'Gradeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1515, 819)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QueryButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Gradeform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "录入成绩"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QueryButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReturnButton As Button
    Friend WithEvents SMSDataSet12 As SMSDataSet12
    Friend WithEvents SelectedBindingSource As BindingSource
    Friend WithEvents SelectedTableAdapter As SMSDataSet12TableAdapters.SelectedTableAdapter
    Friend WithEvents SnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
