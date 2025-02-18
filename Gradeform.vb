Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Logging

Public Class Gradeform
    Dim searchTerm As String
    Dim selectedOption As String
    Private Sub Gradeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 将数据加载到表“SMSDataSet12.Selected”中。
        Me.SelectedTableAdapter.Fill(Me.SMSDataSet12.Selected)
        Me.Width = 800
        Me.Height = 500
        Label1.Visible = True
        Label2.Visible = True
        ComboBox1.Visible = True
        QueryButton.Visible = True
        TextBox1.Visible = True
        If flag = 0 Then
            Label1.Visible = False
            Label2.Visible = False
            ComboBox1.Visible = False
            QueryButton.Visible = False
            TextBox1.Visible = False
            Me.Text = "我的成绩"
        ElseIf flag = 1 Then
            Label1.Text = "提示：直接在单元格即可录入成绩"
            Me.Text = "录入成绩"
        ElseIf flag = 2 Then
            Label1.Text = "提示：直接在单元格即可修改成绩"
            Me.Text = "成绩管理"
        End If
        For i As Integer = 0 To 4
            DataGridView1.Columns(i).Width = 130    '设置行宽
        Next i
        ComboBox1.Items.AddRange({"学号", "课程号", "课程名", "分数"})
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        If flag = 0 Then
            Dim query As String = "SELECT * FROM Selected WHERE Sno= @currentnumber"   ' 获取用户的输入
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@currentnumber", currentnumber)  ' 添加参数
                    connection.Open()
                    Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
                    dataTable.Load(command.ExecuteReader())
                    DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
                End Using
            End Using
        ElseIf flag = 1 Then
            Dim query As String = "SELECT * FROM Selected WHERE Teacher= @currentUserRName"   ' 获取用户的输入
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@currentUserRName", currentUserRName)  ' 添加参数
                    connection.Open()
                    Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
                    dataTable.Load(command.ExecuteReader())
                    DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
                End Using
            End Using
        End If

    End Sub

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        Dim query As String = ""
        Dim searchTerm As String = TextBox1.Text.Trim()
        If String.IsNullOrEmpty(searchTerm) Then
            MessageBox.Show("请输入有效的搜索条件！")
            Exit Sub
        End If
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        If flag = 1 Then
            query = "SELECT * FROM Selected WHERE " + selectedOption + "= @temp and Teacher= @currentUserRName "   ' 获取用户的输入
        ElseIf flag = 2 Then
            query = "SELECT * FROM Selected WHERE " + selectedOption + "= @temp"   ' 获取用户的输入
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@temp", searchTerm)  ' 添加参数
                command.Parameters.AddWithValue("@currentUserRName", currentUserRName)  ' 添加参数
                connection.Open()
                Dim dataTable As New DataTable() ' 使用 DataTable 存储查询结果
                dataTable.Load(command.ExecuteReader())
                DataGridView1.DataSource = dataTable ' 将 DataTable 设置为 DataGridView 的数据源
            End Using
        End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString()
            Case "学号"
                selectedOption = "Sno"
            Case "课程号"
                selectedOption = "CourseID"
            Case "课程名"
                selectedOption = "CourseName"
            Case "分数"
                selectedOption = "Grade"
        End Select
    End Sub
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If flag = 1 Or flag = 2 Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                If e.ColumnIndex = 4 Then ' 仅处理分数列的修改
                    Dim Grade As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() ' 获取修改后的值
                    Dim Sno As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()  ' 获取学号
                    Dim updateQuery As String = "UPDATE Selected SET Grade = @Grade WHERE Sno = @Sno"  ' 构建 SQL 更新语句
                    Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"  ' 数据库连接字符串
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(updateQuery, connection)
                            command.Parameters.AddWithValue("@Grade", Grade) ' 添加参数
                            command.Parameters.AddWithValue("@Sno", Sno)
                            connection.Open() ' 打开数据库连接并执行更新操作
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("分数更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("分数更新失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                Else
                    ' 显示错误消息，提示用户只能修改分数列
                    MessageBox.Show("只能修改分数列！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then  ' 检查是否有选中的行
            Dim selectedCname As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString() ' 获取选中行的 Sname 列的值
            Label2.Text = "当前学生：" & selectedCname ' 更新 Label 的 Text 属性
        End If
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SMSForm.Show()
        Me.Close()
    End Sub

End Class