<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newformStu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newformStu))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet5 = New _1004226104杨美琪_学生管理系统.SMSDataSet5()
        Me.StudentTableAdapter = New _1004226104杨美琪_学生管理系统.SMSDataSet5TableAdapters.StudentTableAdapter()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SnoDataGridViewTextBoxColumn, Me.CnoDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.EnrollYearDataGridViewTextBoxColumn, Me.BirthYearDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 686)
        Me.DataGridView1.TabIndex = 12
        '
        'SnoDataGridViewTextBoxColumn
        '
        Me.SnoDataGridViewTextBoxColumn.DataPropertyName = "Sno"
        Me.SnoDataGridViewTextBoxColumn.HeaderText = "Sno"
        Me.SnoDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SnoDataGridViewTextBoxColumn.Name = "SnoDataGridViewTextBoxColumn"
        Me.SnoDataGridViewTextBoxColumn.Width = 200
        '
        'CnoDataGridViewTextBoxColumn
        '
        Me.CnoDataGridViewTextBoxColumn.DataPropertyName = "Cno"
        Me.CnoDataGridViewTextBoxColumn.HeaderText = "Cno"
        Me.CnoDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CnoDataGridViewTextBoxColumn.Name = "CnoDataGridViewTextBoxColumn"
        Me.CnoDataGridViewTextBoxColumn.Width = 200
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "Sname"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "Sname"
        Me.SnameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        Me.SnameDataGridViewTextBoxColumn.Width = 200
        '
        'EnrollYearDataGridViewTextBoxColumn
        '
        Me.EnrollYearDataGridViewTextBoxColumn.DataPropertyName = "EnrollYear"
        Me.EnrollYearDataGridViewTextBoxColumn.HeaderText = "EnrollYear"
        Me.EnrollYearDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.EnrollYearDataGridViewTextBoxColumn.Name = "EnrollYearDataGridViewTextBoxColumn"
        Me.EnrollYearDataGridViewTextBoxColumn.Width = 200
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
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.SMSDataSet5
        '
        'SMSDataSet5
        '
        Me.SMSDataSet5.DataSetName = "SMSDataSet5"
        Me.SMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1049, 64)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(122, 62)
        Me.ReturnButton.TabIndex = 21
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InsertButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.InsertButton.Location = New System.Drawing.Point(611, 64)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(124, 60)
        Me.InsertButton.TabIndex = 20
        Me.InsertButton.Text = "插入"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'newformStu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 864)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "newformStu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "学生信息管理"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMSDataSet5 As SMSDataSet5
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As SMSDataSet5TableAdapters.StudentTableAdapter
    Friend WithEvents SnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnrollYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnButton As Button
    Friend WithEvents InsertButton As Button
End Class
