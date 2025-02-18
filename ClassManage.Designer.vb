<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassManage))
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeadTeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfStudentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet8 = New _1004226104杨美琪_学生管理系统.SMSDataSet8()
        Me.ClassTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet8TableAdapters.ClassTableAdapter()
        Me.CCButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.UpdateButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(921, 38)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(124, 60)
        Me.UpdateButton.TabIndex = 27
        Me.UpdateButton.Text = "更新"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(606, 38)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 25
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "当前班级："
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.DeleteButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteButton.Location = New System.Drawing.Point(763, 38)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(124, 60)
        Me.DeleteButton.TabIndex = 26
        Me.DeleteButton.Text = "删除"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1270, 36)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 24
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(257, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 35)
        Me.TextBox1.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(59, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 32)
        Me.ComboBox1.TabIndex = 21
        '
        'QueryButton
        '
        Me.QueryButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.QueryButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.QueryButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.QueryButton.Location = New System.Drawing.Point(457, 38)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(124, 60)
        Me.QueryButton.TabIndex = 20
        Me.QueryButton.Text = "查询"
        Me.QueryButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassIDDataGridViewTextBoxColumn, Me.ClassNameDataGridViewTextBoxColumn, Me.HeadTeacherDataGridViewTextBoxColumn, Me.NumOfStudentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1488, 694)
        Me.DataGridView1.TabIndex = 28
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
        Me.ClassBindingSource.DataSource = Me.SMSDataSet8
        '
        'SMSDataSet8
        '
        Me.SMSDataSet8.DataSetName = "SMSDataSet8"
        Me.SMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'CCButton
        '
        Me.CCButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.CCButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CCButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CCButton.Location = New System.Drawing.Point(1079, 36)
        Me.CCButton.Name = "CCButton"
        Me.CCButton.Size = New System.Drawing.Size(150, 62)
        Me.CCButton.TabIndex = 29
        Me.CCButton.Text = "班课管理"
        Me.CCButton.UseVisualStyleBackColor = False
        '
        'ClassManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.CCButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.QueryButton)
        Me.Name = "ClassManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生班级管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents QueryButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMSDataSet8 As SMSDataSet8
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As SMSDataSet8TableAdapters.ClassTableAdapter
    Friend WithEvents ClassIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeadTeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumOfStudentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CCButton As Button
End Class
