Imports System.Data.SqlClient

Public Class ClassManage
    Dim searchTerm As String
    Dim selectedOption As String
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SMSForm.Show()
        Me.Close()
    End Sub

    Private Sub ClassManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“SMSDataSet8._Class”中。您可以根据需要移动或移除它。
        Me.ClassTableAdapter.Fill(Me.SMSDataSet8._Class)
        Me.Width = 800
        Me.Height = 500
        Label2.Visible = False
        CCButton.Visible = False
        ComboBox1.Visible = False
        QueryButton.Visible = False
        TextBox1.Visible = False
        InsertButton.Visible = False
        DeleteButton.Visible = False
        UpdateButton.Visible = False
        For i As Integer = 0 To 3
            DataGridView1.Columns(i).Width = 120    '设置行宽
        Next i
        ComboBox1.Items.AddRange({"班号", "班级名", "班主任", "班级人数"})
        If flag = 0 Then '学生
            ComboBox1.Visible = True
            TextBox1.Visible = True
            Label2.Visible = True
            QueryButton.Visible = True
        ElseIf flag = 1 Then '教师
            Label2.Visible = True
            ComboBox1.Visible = True
            QueryButton.Visible = True
            TextBox1.Visible = True
        Else '管理员
            CCButton.Visible = True
            Label2.Visible = True
            ComboBox1.Visible = True
            QueryButton.Visible = True
            TextBox1.Visible = True
            InsertButton.Visible = True
            DeleteButton.Visible = True
            UpdateButton.Visible = True
        End If
    End Sub

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Dim searchTerm As String = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("请输入有效的搜索条件！")
            Exit Sub
        End If
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM Class WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
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
            Label2.Text = "当前班级：" & selectedCname ' 更新 Label 的 Text 属性
        End If
    End Sub
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        NewformClass.Show()
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM Class "
        Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
        Using adapter As New SqlDataAdapter(query, connectionString)
            adapter.Fill(dataTable) ' 使用 DataAdapter 填充 DataTable
        End Using
        DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
            Dim selectedClassID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Dim numOfStudents As Integer = GetNumOfStudents(selectedClassID) ' 获取班级人数
            If numOfStudents = 0 Then ' 只有当班级人数为0时才可执行删除操作
                Dim del As String = "DELETE FROM Class WHERE ClassID = @ClassID"
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(del, connection)
                        command.Parameters.AddWithValue("@ClassID", selectedClassID) ' 添加参数
                        connection.Open()   ' 打开数据库连接并执行删除操作
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("班级记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("班级记录删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("班级人数不为0，无法删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("请选择要删除的班级记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function GetNumOfStudents(classID As String) As Integer
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT NumOfStudents FROM Class WHERE ClassID = @ClassID"
        Dim numOfStudents As Integer = 0
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", classID)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    numOfStudents = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return numOfStudents
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "班号"
                selectedOption = "ClassID"
            Case "班级名"
                selectedOption = "ClassName"
            Case "班主任"
                selectedOption = "HeadTeacher"
            Case "班级人数"
                selectedOption = "NumOfStudents"
        End Select
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If flag = 2 Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim newValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
                Dim classID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取班级编号
                Dim updateQuery As String = ""  ' 构建 SQL 更新语句
                Select Case e.ColumnIndex
                    Case 1 ' 修改班级名称
                        updateQuery = "UPDATE Class SET ClassName = @newValue WHERE ClassID = @classID"
                    Case 2 ' 修改班主任
                        updateQuery = "UPDATE Class SET HeadTeacher = @newValue WHERE ClassID = @classID"
                    Case 3 ' 修改班级人数
                        updateQuery = "UPDATE Class SET NumOfStudents = @newValue WHERE ClassID = @classID"
                End Select
                Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(updateQuery, connection)
                        command.Parameters.AddWithValue("@newValue", newValue) ' 添加参数
                        command.Parameters.AddWithValue("@classID", classID)
                        connection.Open() ' 打开数据库连接并执行更新操作
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("班级记录更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("班级记录更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub

    Private Sub CCButton_Click(sender As Object, e As EventArgs) Handles CCButton.Click
        ClassCourse.Show()
        Me.Close()
    End Sub
End Class