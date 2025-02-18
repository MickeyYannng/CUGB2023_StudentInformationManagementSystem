Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class CouManage
    Dim searchTerm As String
    Dim selectedOption As String
    Private isNewData As Boolean = False
    Private Sub CouManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CourseTableAdapter.Fill(Me.SMSDataSet1.Course)
        Me.Width = 800
        Me.Height = 500
        Label2.Visible = False
        SeeplanButton.Visible = False
        ComboBox1.Visible = False
        QueryButton.Visible = False
        TextBox1.Visible = False
        InsertButton.Visible = False
        DeleteButton.Visible = False
        UpdateButton.Visible = False
        SelCoButton.Visible = False
        AlSolCoButton.Visible = False
        For i As Integer = 0 To 4
            DataGridView1.Columns(i).Width = 110    '设置行宽
        Next i
        ComboBox1.Items.AddRange({"课程号", "课程名", "任课老师", "开课日期", "结课日期", "考察方式"})
        If flag = 0 Then '学生
            SelCoButton.Visible = True
            ComboBox1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = True
            AlSolCoButton.Visible = True
            QueryButton.Visible = True
            LoadDataToDataGridView()
        ElseIf flag = 1 Then '教师
            SeeplanButton.Text = "查看教学任务"
            Label2.Visible = True
            SeeplanButton.Visible = True
            ComboBox1.Visible = True
            QueryButton.Visible = True
            TextBox1.Visible = True
        Else '管理员
            SeeplanButton.Text = "课程分配"
            Label2.Visible = True
            ComboBox1.Visible = True
            QueryButton.Visible = True
            TextBox1.Visible = True
            InsertButton.Visible = True
            DeleteButton.Visible = True
            UpdateButton.Visible = True
            SeeplanButton.Visible = True
        End If
    End Sub
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SMSForm.Show()
        Me.Close()
    End Sub
    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Dim searchTerm As String = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("请输入有效的搜索条件！")
            Exit Sub
        End If
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM Course WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@temp", searchTerm)  ' 添加参数
                connection.Open()
                Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
                dataTable.Load(command.ExecuteReader())
                DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
            End Using
        End Using
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then  ' 检查是否有选中的行
            Dim selectedCname As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString() ' 获取选中行的 Sname 列的值
            Label2.Text = "当前课程：" & selectedCname ' 更新 Label 的 Text 属性
        End If
    End Sub
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        Newform.Show()
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM Course "
        Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
        Using adapter As New SqlDataAdapter(query, connectionString)
            adapter.Fill(dataTable) ' 使用 DataAdapter 填充 DataTable
        End Using
        DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
            Dim selectedCourseID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Dim del As String = "DELETE FROM Course WHERE CourseID = @courseID"
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(del, connection)
                    command.Parameters.AddWithValue("@courseID", selectedCourseID) ' 添加参数
                    connection.Open()   ' 打开数据库连接并执行删除操作
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("课程记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("课程记录删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("请选择要删除的课程记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "课程号"
                selectedOption = "CourseID"
            Case "课程名"
                selectedOption = "CourseName"
            Case "任课老师"
                selectedOption = "Teacher"
            Case "开课日期"
                selectedOption = "StaDate"
            Case "结课日期"
                selectedOption = "EndDate"
            Case "考察方式"
                selectedOption = "AssessMethod"
        End Select
    End Sub
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If flag = 1 Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
                Dim courseID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取课程号
                Dim updateQuery As String = ""  ' 构建 SQL 更新语句
                If DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString() = currentUserRName Then
                    Select Case e.ColumnIndex
                        Case 1 ' 修改课程名
                            updateQuery = "UPDATE Course SET CourseName = @newValue WHERE CourseID = @courseID"
                        Case 2 ' 修改任课老师
                            updateQuery = "UPDATE Course SET Teacher = @newValue WHERE CourseID = @courseID"
                        Case 3 ' 修改开课日期
                            updateQuery = "UPDATE Course SET Star = @newValue WHERE CourseID = @courseID"
                        Case 4 ' 修改结课日期
                            updateQuery = "UPDATE Course SET EndDate = @newValue WHERE CourseID = @courseID"
                        Case 5 ' 修改考察方式
                            updateQuery = "UPDATE Course SET AssessMethod = @newValue WHERE CourseID = @courseID"
                    End Select
                    Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(updateQuery, connection)
                            command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                            command.Parameters.AddWithValue("@courseID", courseID)
                            connection.Open() ' 打开数据库连接并执行更新操作
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("课程记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("课程记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End If
            End If
        ElseIf flag = 2 Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
                Dim courseID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取课程号
                Dim updateQuery As String = ""  ' 构建 SQL 更新语句
                Select Case e.ColumnIndex
                    Case 1 ' 修改课程名
                        updateQuery = "UPDATE Course SET CourseName = @newValue WHERE CourseID = @courseID"
                    Case 2 ' 修改任课老师
                        updateQuery = "UPDATE Course SET Teacher = @newValue WHERE CourseID = @courseID"
                    Case 3 ' 修改开课日期
                        updateQuery = "UPDATE Course SET Star = @newValue WHERE CourseID = @courseID"
                    Case 4 ' 修改结课日期
                        updateQuery = "UPDATE Course SET EndDate = @newValue WHERE CourseID = @courseID"
                    Case 5 ' 修改考察方式
                        updateQuery = "UPDATE Course SET AssessMethod = @newValue WHERE CourseID = @courseID"
                End Select
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                        command.Parameters.AddWithValue("@courseID", courseID)
                        connection.Open() ' 打开数据库连接并执行更新操作
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("课程记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("课程记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub
    Private Sub LoadDataToDataGridView()
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM Course"
        Using connection As New SqlConnection(connectionString) ' 创建连接对象和适配器对象
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable   ' 将数据绑定到 DataGridView
                For Each row As DataGridViewRow In DataGridView1.Rows  ' 循环每一行，根据学生是否已选课程来设置背景颜色
                    If row.Cells.Count > 0 AndAlso row.Cells(0) IsNot Nothing AndAlso row.Cells(0).Value IsNot Nothing Then
                        Dim CourseID As String = row.Cells(0).Value.ToString()
                        Dim Sno As String = currentnumber ' 当前学生的学号
                        If CourseIsSelected(Sno, CourseID) Then
                            row.DefaultCellStyle.BackColor = Color.Gray ' 已选课程设置为灰色背景
                        End If
                    End If
                Next
            End Using
        End Using
    End Sub
    Private Function CourseIsSelected(Sno As String, CourseID As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM Selected WHERE Sno = @Sno AND CourseID = @CourseID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Sno", Sno)
                command.Parameters.AddWithValue("@CourseID", CourseID)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    Return True ' 已选过
                Else
                    Return False ' 未选过
                End If
            End Using
        End Using
    End Function
    Private Sub AlSolCoButton_Click(sender As Object, e As EventArgs) Handles AlSolCoButton.Click
        Selected.Show()
        Me.Close()
    End Sub
    Private Sub SelCoButton_Click(sender As Object, e As EventArgs) Handles SelCoButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then  ' 获取选中行的索引
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(rowIndex)
            If selectedRow.DefaultCellStyle.BackColor <> Color.Gray Then
                Dim Sno As String = currentnumber
                Dim CourseID As String = DataGridView1.Rows(rowIndex).Cells(0).Value.ToString() '当前选中的课程号
                If InsertSelectedCourse(Sno, CourseID) Then

                    selectedRow.DefaultCellStyle.BackColor = Color.Gray
                    MessageBox.Show("选课成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("选课失败！已选课程无法再次选课。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("请选择要选课的课程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function InsertSelectedCourse(sno As String, CourseID As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim insertQuery As String = "INSERT INTO Selected (Sno, CourseID, CourseName, Teacher) VALUES (@sno, @CourseID, @CourseName, @Teacher)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@sno", sno)
                command.Parameters.AddWithValue("@CourseID", CourseID)
                command.Parameters.AddWithValue("@CourseName", DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString())
                command.Parameters.AddWithValue("@Teacher", DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value.ToString())
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    Return True ' 插入成功
                Else
                    Return False ' 插入失败
                End If
            End Using
        End Using
    End Function

    Private Sub SeeplanButton_Click(sender As Object, e As EventArgs) Handles SeeplanButton.Click
        SeePlan.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class