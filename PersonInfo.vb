Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class PersonInfo
    Dim searchTerm As String
    Dim selectedOption As String
    Private Sub PersonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
        Label1.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = False
        QueryButton.Visible = False
        TextBox1.Visible = False
        InsertButton.Visible = False
        DeleteButton.Visible = False
        UpdateButton.Visible = False
        If flag = 0 Then '学生
            qufen = "xs"
            Label1.Visible = True
            DataGridView1.Visible = True
            DataGridView2.Visible = False
            Me.StudentTableAdapter.Fill(Me.SMSDataSet.Student)
            Dim filteredRows = From row As SMSDataSet.StudentRow In Me.SMSDataSet.Student
                               Where row.Sname = currentUserRName
                               Select row   '查询学生自己的信息
            DataGridView1.DataSource = filteredRows.ToList()
        ElseIf flag = 1 Then '教师
            qufen = "ls"
            DataGridView2.Visible = True
            DataGridView1.Visible = False
            Label1.Visible = True
            Me.TeacherTableAdapter.Fill(Me.SMSDataSet3.Teacher)
            Dim filteredRows = From row As SMSDataSet3.TeacherRow In Me.SMSDataSet3.Teacher
                               Where row.Tname = currentUserRName
                               Select row   '查询老师自己的信息
            DataGridView2.DataSource = filteredRows.ToList()
        ElseIf flag = 2 Then '管理员
            Label2.Visible = True
            ComboBox1.Visible = True
            QueryButton.Visible = True
            TextBox1.Visible = True
            InsertButton.Visible = True
            DeleteButton.Visible = True
            UpdateButton.Visible = True
            If qufen = "xs" Then
                DataGridView1.Visible = True
                DataGridView2.Visible = False
                Me.StudentTableAdapter.Fill(Me.SMSDataSet.Student)
                ComboBox1.Items.AddRange({"学号", "班号", "姓名", "入学年份", "出生年份", "专业"})
            ElseIf qufen = "ls" Then
                DataGridView1.Visible = False
                DataGridView2.Visible = True
                Me.TeacherTableAdapter.Fill(Me.SMSDataSet3.Teacher)
                ComboBox1.Items.AddRange({"工号", "姓名", "性别", "出生年份", "研究方向", "部门"})
            End If
        End If
        For i As Integer = 0 To 4
            DataGridView1.Columns(i).Width = 110    '设置行宽
        Next i
        For i As Integer = 0 To 4
            DataGridView2.Columns(i).Width = 110    '设置行宽
        Next i
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SMSForm.Show()
        Me.Close()
    End Sub
    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        searchTerm = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("请输入有效的搜索条件！")
            Exit Sub
        End If
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = ""
        If qufen = "xs" Then
            query = "SELECT * FROM Student WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
        ElseIf qufen = "ls" Then
            query = "SELECT * FROM Teacher WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
        End If
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("temp", searchTerm)  ' 添加参数
                connection.Open()
                Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
                dataTable.Load(command.ExecuteReader())
                If qufen = "xs" Then
                    DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
                ElseIf qufen = "ls" Then
                    DataGridView2.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
                End If
            End Using
        End Using
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then  ' 检查是否有选中的行
            Dim selectedSname As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString() ' 获取选中行的 Sname 列的值
            Label2.Text = "当前学生：" & selectedSname ' 更新 Label 的 Text 属性
        End If
    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        If DataGridView2.SelectedRows.Count > 0 Then  ' 检查是否有选中的行
            Dim selectedTname As String = DataGridView2.SelectedRows(0).Cells(1).Value.ToString() ' 获取选中行的 Sname 列的值
            Label2.Text = "当前老师：" & selectedTname ' 更新 Label 的 Text 属性
        End If
    End Sub
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        If qufen = "xs" Then
            newformStu.Show()
            Me.Close()
        ElseIf qufen = "ls" Then
            newformTea.Show()
            Me.Close()
        End If


    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = ""
        If qufen = "xs" Then
            query = "SELECT * FROM Student "
        ElseIf qufen = "ls" Then
            query = "SELECT * FROM Teacher "
        End If
        Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
        Using adapter As New SqlDataAdapter(query, connectionString)
            adapter.Fill(dataTable) ' 使用 DataAdapter 填充 DataTable
        End Using
        If qufen = "xs" Then
            DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
        ElseIf qufen = "ls" Then
            DataGridView2.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
        End If
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If qufen = "xs" Then
            If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
                Dim selectedno As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
                Dim del As String = ""
                del = "DELETE FROM Student WHERE Sno = @c1"
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(del, connection)
                        command.Parameters.AddWithValue("@c1", selectedno) ' 添加参数
                        connection.Open()   ' 打开数据库连接并执行删除操作
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("学生记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("学生记录删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("请选择要删除的学生记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        ElseIf qufen = "ls" Then
            If DataGridView2.SelectedRows.Count > 0 Then ' 检查是否有选中的行
                Dim selectedno As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()
                Dim del As String = ""
                del = "DELETE FROM Teacher WHERE Tno = @c1"
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(del, connection)
                        command.Parameters.AddWithValue("@c1", selectedno) ' 添加参数
                        connection.Open()   ' 打开数据库连接并执行删除操作
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("老师记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("老师记录删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("请选择要删除的老师记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If qufen = "xs" Then
            Select Case ComboBox1.SelectedItem.ToString() ' 获取指定列的值
                Case "学号"
                    selectedOption = "Sno"
                Case "班号"
                    selectedOption = "Cno"
                Case "姓名"
                    selectedOption = "Sname"
                Case "入学年份"
                    selectedOption = "EnrollYear"
                Case "出生年份"
                    selectedOption = "BirthYear"
                Case "专业"
                    selectedOption = "Major"
            End Select
        ElseIf qufen = "ls" Then
            Select Case ComboBox1.SelectedItem.ToString() ' 获取指定列的值
                Case "工号"
                    selectedOption = "Tno"
                Case "姓名"
                    selectedOption = "Tname"
                Case "性别"
                    selectedOption = "Gender"
                Case "出生年份"
                    selectedOption = "BirthYear"
                Case "研究方向"
                    selectedOption = "Major"
                Case "部门"
                    selectedOption = "Department"
            End Select
        End If
    End Sub
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
            Dim updateQuery As String = ""  ' 构建 SQL 更新语句
            Dim no As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取学号
            Select Case e.ColumnIndex
                    Case 1 ' 修改班号
                        updateQuery = "UPDATE Student SET Cno = @newValue WHERE Sno = @no"
                    Case 2 ' 修改姓名
                        updateQuery = "UPDATE Student SET Sname = @newValue WHERE Sno = @no"
                    Case 3 ' 修改入学年份
                        updateQuery = "UPDATE Student SET EnrollYear = @newValue WHERE Sno = @no"
                    Case 4 ' 修改出生年份
                        updateQuery = "UPDATE Student SET BirthYear = @newValue WHERE Sno = @no"
                    Case 5 ' 修改专业
                        updateQuery = "UPDATE Student SET Major = @newValue WHERE Sno = @no"
                End Select
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                    command.Parameters.AddWithValue("@no", no)
                    connection.Open() ' 打开数据库连接并执行更新操作
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("学生记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("学生记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub
    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim newValue As String = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
            Dim updateQuery As String = ""  ' 构建 SQL 更新语句
            Dim no As String = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取工号
            Select Case e.ColumnIndex
                Case 1
                    updateQuery = "UPDATE Teacher SET Tname = @newValue WHERE Tno = @no"
                Case 2
                    updateQuery = "UPDATE Teacher SET Gender = @newValue WHERE Tno = @no"
                Case 3
                    updateQuery = "UPDATE Teacher SET BirthYear = @newValue WHERE Tno = @no"
                Case 4
                    updateQuery = "UPDATE Teacher SET Major = @newValue WHERE Tno = @no"
                Case 5
                    updateQuery = "UPDATE Teacher SET Department = @newValue WHERE Tno = @no"
            End Select
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                    command.Parameters.AddWithValue("@no", no)
                    connection.Open() ' 打开数据库连接并执行更新操作
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("老师记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("老师记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub

    Public Sub New()

        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub
End Class