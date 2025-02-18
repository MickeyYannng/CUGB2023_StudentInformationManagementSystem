Imports System.Data.SqlClient

Public Class Selected
    Private Sub Selected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 500)
        Me.SelectedTableAdapter.Fill(Me.SMSDataSet2.Selected)
        For i As Integer = 0 To 4
            DataGridView1.Columns(i).Width = 110    '设置行宽
        Next i
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
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
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        CouManage.Show()
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If DataGridView1.SelectedRows.Count > 0 Then ' 检查是否有选中的行
            Dim selectedCourseID As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            Dim del As String = "DELETE FROM Selected WHERE CourseID = @courseID AND Sno = @sno"
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(del, connection)
                    command.Parameters.AddWithValue("@courseID", selectedCourseID) ' 添加参数
                    command.Parameters.AddWithValue("@sno", currentnumber) ' 添加学号参数
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class