Imports System.Data.SqlClient

Public Class NewformCC
    Private Sub NewformCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“SMSDataSet11.ClassCourse”中。您可以根据需要移动或移除它。
        Me.ClassCourseTableAdapter.Fill(Me.SMSDataSet11.ClassCourse)
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
                    Dim ClassID As String = Convert.ToString(row.Cells(0).Value) ' 第一列是班级号
                    Dim ClassName As String = Convert.ToString(row.Cells(1).Value) ' 第二列是班级名
                    Dim CouID As String = Convert.ToString(row.Cells(2).Value) ' 第三列是课程号
                    Dim CouName As String = Convert.ToString(row.Cells(3).Value) ' 第四列是课程名
                    ' 查询班级号为ClassID的所有学生学号
                    Dim studentIDs As List(Of String) = GetStudentIDs(ClassID)
                    Dim Teacher As String = GetTeacherName(CouID)
                    For Each Sno As String In studentIDs
                        If Sno <> "" AndAlso Teacher <> "" Then
                            If InsertIntoSelected(Sno, CouID, CouName, Teacher) Then
                                successCount += 1
                            End If
                        End If
                    Next
                    InsertIntoClassCourse(ClassID, ClassName, CouID, CouName) ' 同时插入到ClassCourse表
                End If
            End If
        Next
        If successCount > 0 Then
            MessageBox.Show($"成功插入 {successCount} 条班课的选课记录！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("请填写所有必要的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ClassCourse.Show()
        Me.Close()

    End Sub
    Private Function GetStudentIDs(ClassID As String) As List(Of String)
        Dim studentIDs As New List(Of String)()
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT Sno FROM Student WHERE Cno = @ClassID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", ClassID)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim studentID As String = reader.GetString(0)
                    studentIDs.Add(studentID)
                End While
            End Using
        End Using
        Return studentIDs
    End Function
    Private Function InsertIntoClassCourse(ClassID As String, ClassName As String, CouID As String, CouName As String) As Integer
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO ClassCourse (ClassID, ClassName, CourseID, CourseName) VALUES (@ClassID, @ClassName, @CouID, @CouName)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClassID", ClassID)
                command.Parameters.AddWithValue("@ClassName", ClassName)
                command.Parameters.AddWithValue("@CouID", CouID)
                command.Parameters.AddWithValue("@CouName", CouName)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery()
            End Using
        End Using
        Return rowsAffected
    End Function
    Private Function GetTeacherName(CouID As String) As String
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT Teacher FROM Course WHERE CourseID = @CouID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CouID", CouID)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return ""
                End If
            End Using
        End Using
    End Function
    Private Function InsertIntoSelected(Sno As String, CouID As String, CouName As String, Teacher As String) As Integer
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO Selected (Sno, CourseID, CourseName, Teacher, Grade) VALUES (@Sno, @CouID, @CouName, @Teacher, NULL)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Sno", Sno)
                command.Parameters.AddWithValue("@CouID", CouID)
                command.Parameters.AddWithValue("@CouName", CouName)
                command.Parameters.AddWithValue("@Teacher", Teacher)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery()
            End Using
        End Using
        Return rowsAffected
    End Function

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        ClassCourse.Show()
        Me.Close()
    End Sub
End Class