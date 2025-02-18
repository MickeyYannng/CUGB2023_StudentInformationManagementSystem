Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class ClassCourse
    Dim searchTerm As String
    Dim selectedOption As String
    Private Sub ClassCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“SMSDataSet10.ClassCourse”中。您可以根据需要移动或移除它。
        Me.ClassCourseTableAdapter.Fill(Me.SMSDataSet10.ClassCourse)
        Me.Width = 800
        Me.Height = 500
        For i As Integer = 0 To 3
            DataGridView1.Columns(i).Width = 120    '设置行宽
        Next i
        ComboBox1.Items.AddRange({"班级号", "班级名", "课程号", "课程名"})
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        ClassManage.Show()
        Me.Close()
    End Sub
    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Dim searchTerm As String = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("请输入有效的搜索条件！")
            Exit Sub
        End If
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM ClassCourse WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
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
        NewformCC.Show()
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT * FROM ClassCourse "
        Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
        Using adapter As New SqlDataAdapter(query, connectionString)
            adapter.Fill(dataTable) ' 使用 DataAdapter 填充 DataTable
        End Using
        DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
            Dim selectedClassID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString() ' 获取DataGridView中第一列的数据作为班级号
            Dim selectedCourseID As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString() ' 获取DataGridView中第三列的数据作为课程号
            Dim studentIDsToDelete As New List(Of String)()
            ' 查询Student表中班级号为selectedClassID的所有学生的学号
            Dim getStudentIDsQuery As String = "SELECT Sno FROM Student WHERE Cno = @ClassID"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(getStudentIDsQuery, connection)
                    command.Parameters.AddWithValue("@ClassID", selectedClassID)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        studentIDsToDelete.Add(reader.GetString(0))
                    End While
                End Using
            End Using
            If studentIDsToDelete.Count > 0 Then ' 如果找到了学生学号
                Dim successCount As Integer = 0
                ' 遍历学生学号数组，在Selected表中检查是否存在课程号为selectedCourseID的行，如果存在，则删除
                For Each studentID As String In studentIDsToDelete
                    Dim deleteQuery As String = "DELETE FROM Selected WHERE Sno = @Sno AND CourseID = @CourseID"
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(deleteQuery, connection)
                            command.Parameters.AddWithValue("@Sno", studentID)
                            command.Parameters.AddWithValue("@CourseID", selectedCourseID)
                            connection.Open()
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                successCount += 1
                            End If
                        End Using
                    End Using
                Next
                MessageBox.Show($"班号：{selectedClassID}，课程号：{selectedCourseID}", "调试", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' 删除ClassCourse表中选中的行数据
                Dim deleteClassCourseQuery As String = "DELETE FROM ClassCourse WHERE ClassID = @ClassID AND CourseID = @CourseID"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(deleteClassCourseQuery, connection)
                        command.Parameters.AddWithValue("@ClassID", selectedClassID)
                        command.Parameters.AddWithValue("@CourseID", selectedCourseID)
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    End Using
                End Using
                If successCount > 0 Then
                    MessageBox.Show($"{successCount} 条班课记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("班课记录删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("未找到符合条件的学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("请选择要删除的班课记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "班级号"
                selectedOption = "ClassID"
            Case "班级名"
                selectedOption = "ClassName"
            Case "课程号"
                selectedOption = "CourseID"
            Case "课程名"
                selectedOption = "CourseName"
        End Select
    End Sub


End Class