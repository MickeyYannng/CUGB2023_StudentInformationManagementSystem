<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewformClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewformClass))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeadTeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfStudentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet9 = New _1004226104杨美琪_学生管理系统.SMSDataSet9()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.SMSDataSet8 = New _1004226104杨美琪_学生管理系统.SMSDataSet8()
        Me.SMSDataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet9TableAdapters.ClassTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassIDDataGridViewTextBoxColumn, Me.ClassNameDataGridViewTextBoxColumn, Me.HeadTeacherDataGridViewTextBoxColumn, Me.NumOfStudentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 686)
        Me.DataGridView1.TabIndex = 15
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
        'HeadTeacherDataGridViewTextBoxColumn
        '
        Me.HeadTeacherDataGridViewTextBoxColumn.DataPropertyName = "HeadTeacher"
        Me.HeadTeacherDataGridViewTextBoxColumn.HeaderText = "HeadTeacher"
        Me.HeadTeacherDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.HeadTeacherDataGridViewTextBoxColumn.Name = "HeadTeacherDataGridViewTextBoxColumn"
        Me.HeadTeacherDataGridViewTextBoxColumn.Width = 200
        '
        'NumOfStudentsDataGridViewTextBoxColumn
        '
        Me.NumOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NumOfStudents"
        Me.NumOfStudentsDataGridViewTextBoxColumn.HeaderText = "NumOfStudents"
        Me.NumOfStudentsDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.NumOfStudentsDataGridViewTextBoxColumn.Name = "NumOfStudentsDataGridViewTextBoxColumn"
        Me.NumOfStudentsDataGridViewTextBoxColumn.Width = 200
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "Class"
        Me.ClassBindingSource.DataSource = Me.SMSDataSet9
        '
        'SMSDataSet9
        '
        Me.SMSDataSet9.DataSetName = "SMSDataSet9"
        Me.SMSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1039, 56)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 25
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(601, 56)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 24
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'SMSDataSet8
        '
        Me.SMSDataSet8.DataSetName = "SMSDataSet8"
        Me.SMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SMSDataSet8BindingSource
        '
        Me.SMSDataSet8BindingSource.DataSource = Me.SMSDataSet8
        Me.SMSDataSet8BindingSource.Position = 0
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'NewformClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 864)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "NewformClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "班级信息管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReturnButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents SMSDataSet8 As SMSDataSet8
    Friend WithEvents SMSDataSet8BindingSource As BindingSource
    Friend WithEvents SMSDataSet9 As SMSDataSet9
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As SMSDataSet9TableAdapters.ClassTableAdapter
    Friend WithEvents ClassIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeadTeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumOfStudentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
