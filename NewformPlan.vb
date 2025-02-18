Imports System.Data.SqlClient

Public Class NewformPlan
    Private Sub NewformPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“SMSDataSet7.SeePlan”中。您可以根据需要移动或移除它。
        Me.SeePlanTableAdapter.Fill(Me.SMSDataSet7.SeePlan)
        Me.Width = 800
        Me.Height = 500
        DataGridView1.DataSource = New DataTable() ' 设置 DataGridView 的数据源为空表格
        DataGridView1.Columns(0).Width = 80    '设置行宽
        DataGridView1.Columns(1).Width = 120    '设置行宽
        For i As Integer = 2 To 5
            DataGridView1.Columns(i).Width = 80    '设置行宽
        Next i
        DataGridView1.Columns(6).Width = 150    '设置行宽
        DataGridView1.Columns(7).Width = 150    '设置行宽
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SeePlan.Show()
        Me.Close()
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        Dim successCount As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow AndAlso Not String.IsNullOrWhiteSpace(Convert.ToString(row.Cells(0).Value)) Then ' 检查每行的第一个单元格是否为空
                Dim hasEmptyCell As Boolean = False
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value Is Nothing OrElse cell.Value.Equals(DBNull.Value) Then ' 检查单元格是否为空
                        hasEmptyCell = True
                        Exit For
                    End If
                Next
                If Not hasEmptyCell Then
                    Dim CourseID As String = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value) ' 获取 DataGridView 中当前选中行的单元格值
                    Dim CourseName As String = Convert.ToString(DataGridView1.CurrentRow.Cells(1).Value)
                    Dim Teacher As String = Convert.ToString(DataGridView1.CurrentRow.Cells(2).Value)
                    Dim Credits As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(3).Value)
                    Dim AssessMethod As String = Convert.ToString(DataGridView1.CurrentRow.Cells(4).Value)
                    Dim CourseProperty As String = Convert.ToString(DataGridView1.CurrentRow.Cells(5).Value)
                    Dim ClassTime As String = Convert.ToString(DataGridView1.CurrentRow.Cells(6).Value)
                    Dim Location As String = Convert.ToString(DataGridView1.CurrentRow.Cells(7).Value)
                    If Insertinto(CourseID, CourseName, Teacher, Credits, AssessMethod, CourseProperty, ClassTime, Location) Then ' 调用插入课程记录的方法，并传入课程信息
                        successCount += 1
                    End If
                End If

            End If
        Next
        If successCount > 0 Then
            MessageBox.Show($"成功插入 {successCount} 条记录！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("请填写所有必要的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        SeePlan.Show()
        Me.Close()
    End Sub
    Private Function Insertinto(c1 As String, c2 As String, c3 As String, c4 As String, c5 As String, c6 As String, c7 As String, c8 As String) As Integer
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO SeePlan(CourseID, CourseName, Teacher, Credits, AssessMethod, CourseProperty, ClassTime, Location) VALUES (@c1, @c2, @c3, @c4, @c5, @c6, @c7, @c8)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)   ' 添加参数
                command.Parameters.AddWithValue("@c1", c1)
                command.Parameters.AddWithValue("@c2", c2)
                command.Parameters.AddWithValue("@c3", c3)
                command.Parameters.AddWithValue("@c4", c4)
                command.Parameters.AddWithValue("@c5", c5)
                command.Parameters.AddWithValue("@c6", c6)
                command.Parameters.AddWithValue("@c7", c7)
                command.Parameters.AddWithValue("@c8", c8)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery() ' 执行插入操作
            End Using
        End Using
        Return rowsAffected
    End Function
End Class