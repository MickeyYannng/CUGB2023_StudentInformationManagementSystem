Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Newform
    Private Sub Newform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CourseTableAdapter.Fill(Me.SMSDataSet1.Course)
        Me.Width = 800
        Me.Height = 500
        DataGridView1.DataSource = New DataTable() ' 设置 DataGridView 的数据源为空表格
        For i As Integer = 0 To 4
            DataGridView1.Columns(i).Width = 110    '设置行宽
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
                    Dim CouID As String = Convert.ToString(row.Cells(0).Value)
                    Dim CouName As String = Convert.ToString(row.Cells(1).Value)
                    Dim Teacher As String = Convert.ToString(row.Cells(2).Value)
                    Dim StaDate As DateTime = Convert.ToDateTime(row.Cells(3).Value)
                    Dim EndDate As DateTime = Convert.ToDateTime(row.Cells(4).Value)
                    Dim AssMeth As String = Convert.ToString(row.Cells(5).Value)
                    If InsertCourse(CouID, CouName, Teacher, StaDate, EndDate, AssMeth) Then
                        successCount += 1
                    End If
                End If
            End If
        Next
        If successCount > 0 Then
            MessageBox.Show($"成功插入 {successCount} 条课程记录！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("请填写所有必要的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        CouManage.Show()
        Me.Close()

    End Sub
    Private Function InsertCourse(CouID As String, CouName As String, Teacher As String, StaDate As DateTime, EndDate As DateTime, AssMeth As String) As Integer
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO Course (CourseID, CourseName, Teacher, StaDate, EndDate, AssessMethod) VALUES (@CouID, @CouName, @Teacher, @StaDate, @EndDate, @AssMeth)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CouID", CouID)
                command.Parameters.AddWithValue("@CouName", CouName)
                command.Parameters.AddWithValue("@Teacher", Teacher)
                command.Parameters.AddWithValue("@StaDate", StaDate)
                command.Parameters.AddWithValue("@EndDate", EndDate)
                command.Parameters.AddWithValue("@AssMeth", AssMeth)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery()
            End Using
        End Using
        Return rowsAffected
    End Function
    Private Function Insertinto(c1 As String, c2 As String, c3 As String, c4 As String, c5 As String, c6 As String)
        Dim rowsAffected As Integer = 0
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = ""
        If qufen = "xs" Then
            query = "INSERT INTO Student(Sno,Cno,Sname,EnrollYear, BirthYear,Major) VALUES (@c1, @c2, @c3, @c4, @c5,@c6)"
        ElseIf qufen = "ls" Then
            query = "INSERT INTO Teacher(Tno,Tname,Gender,BirthYear,Major,Department) VALUES (@c1, @c2, @c3, @c4, @c5,@c6)"
        End If
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)   ' 添加参数
                command.Parameters.AddWithValue("@c1", c1)
                command.Parameters.AddWithValue("@c2", c2)
                command.Parameters.AddWithValue("@c3", c3)
                command.Parameters.AddWithValue("@c4", c4)
                command.Parameters.AddWithValue("@c5", c5)
                command.Parameters.AddWithValue("@c6", c6)
                connection.Open()
                rowsAffected = command.ExecuteNonQuery() ' 执行插入操作
            End Using
        End Using
        Return rowsAffected
    End Function

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        CouManage.Show()
        Me.Close()
    End Sub
End Class