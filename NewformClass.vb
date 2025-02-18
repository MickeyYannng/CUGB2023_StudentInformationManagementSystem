Imports System.Data.SqlClient

Public Class NewformClass
    Private Sub NewformClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“SMSDataSet9._Class”中。您可以根据需要移动或移除它。
        Me.ClassTableAdapter.Fill(Me.SMSDataSet9._Class)
        Me.Width = 800
        Me.Height = 500
        DataGridView1.DataSource = New DataTable() ' 设置 DataGridView 的数据源为空表格
        For i As Integer = 0 To 3
            DataGridView1.Columns(i).Width = 120    '设置行宽
        Next i
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
                    Dim ClassID As String = Convert.ToString(row.Cells(0).Value) ' 获取 DataGridView 中当前行的单元格值
                    Dim ClassName As String = Convert.ToString(row.Cells(1).Value)
                    Dim HeadTeacher As String = Convert.ToString(row.Cells(2).Value)
                    Dim NumOfStudents As Integer = Convert.ToInt32(row.Cells(3).Value)
                    If InsertIntoClass(ClassID, ClassName, HeadTeacher, NumOfStudents) Then ' 调用插入班级记录的方法，并传入班级信息
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
        ClassManage.Show()
        Me.Close()
    End Sub
    Private Function InsertIntoClass(c1 As String, c2 As String, c3 As String, c4 As Integer) As Integer
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO Class(ClassID, ClassName, HeadTeacher, NumOfStudents) VALUES (@c1, @c2, @c3, @c4)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)   ' 添加参数
                command.Parameters.AddWithValue("@c1", c1)
                command.Parameters.AddWithValue("@c2", c2)
                command.Parameters.AddWithValue("@c3", c3)
                command.Parameters.AddWithValue("@c4", c4)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery() ' 执行插入操作
            End Using
        End Using
        Return rowsAffected
    End Function
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        ClassManage.Show()
        Me.Close()
    End Sub
End Class