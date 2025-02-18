Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SeePlan
    Private Sub SeePlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
        InsertButton.Visible = True
        DeleteButton.Visible = True
        UpdateButton.Visible = True
        'TODO: 这行代码将数据加载到表“SMSDataSet6.SeePlan”中。您可以根据需要移动或移除它。
        Me.SeePlanTableAdapter.Fill(Me.SMSDataSet6.SeePlan)
        DataGridView1.Columns(0).Width = 80    '设置行宽
        DataGridView1.Columns(1).Width = 120    '设置行宽
        For i As Integer = 2 To 5
            DataGridView1.Columns(i).Width = 80    '设置行宽
        Next i
        DataGridView1.Columns(6).Width = 150    '设置行宽
        DataGridView1.Columns(7).Width = 150    '设置行宽
        If flag = 1 Then
            InsertButton.Visible = False
            DeleteButton.Visible = False
            UpdateButton.Visible = False
            Me.SeePlanTableAdapter.Fill(Me.SMSDataSet6.SeePlan)
            Dim filteredRows = From row As SMSDataSet6.SeePlanRow In Me.SMSDataSet6.SeePlan
                               Where row.Teacher = currentUserRName
                               Select row   '查询自己的教学任务
            DataGridView1.DataSource = filteredRows.ToList()
        End If
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        CouManage.Show()
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM SeePlan "
        Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
        Using adapter As New SqlDataAdapter(query, connectionString)
            adapter.Fill(dataTable) ' 使用 DataAdapter 填充 DataTable
        End Using
        DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
            Dim selectedCourseID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Dim del As String = "DELETE FROM SeePlan WHERE CourseID = @courseID"
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(del, connection)
                    command.Parameters.AddWithValue("@courseID", selectedCourseID) ' 添加参数
                    connection.Open()   ' 打开数据库连接并执行删除操作
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("请选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
            Dim courseID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取课程号
            Dim updateQuery As String = ""  ' 构建 SQL 更新语句
            Select Case e.ColumnIndex
                Case 1 ' 修改课程名
                    updateQuery = "UPDATE SeePlan SET CourseName = @newValue WHERE CourseID = @courseID"
                Case 2 ' 修改任课老师
                    updateQuery = "UPDATE SeePlan SET Teacher = @newValue WHERE CourseID = @courseID"
                Case 3 ' 修改学分
                    updateQuery = "UPDATE SeePlan SET Credits = @newValue WHERE CourseID = @courseID"
                Case 4 ' 修改考察方式
                    updateQuery = "UPDATE SeePlan SET AssessMethod = @newValue WHERE CourseID = @courseID"
                Case 5 ' 修改选课属性
                    updateQuery = "UPDATE SeePlan SET CourseProperty = @newValue WHERE CourseID = @courseID"
                Case 6 ' 修改上课时间
                    updateQuery = "UPDATE SeePlan SET ClassTime = @newValue WHERE CourseID = @courseID"
                Case 7 ' 修改地点
                    updateQuery = "UPDATE SeePlan SET Location = @newValue WHERE CourseID = @courseID"
            End Select
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                    command.Parameters.AddWithValue("@courseID", courseID)
                    connection.Open() ' 打开数据库连接并执行更新操作
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End If
    End Sub
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        NewformPlan.Show()
        Me.Close()
    End Sub
End Class