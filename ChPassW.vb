Imports System.Data.SqlClient

Public Class ChPassW


    Private Sub ChPassW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim originalPassword As String = TextBox1.Text.Trim()
        Dim newPassword As String = TextBox2.Text.Trim()
        Dim confirmPassword As String = TextBox3.Text.Trim()
        ' 检查输入是否为空
        If String.IsNullOrWhiteSpace(originalPassword) OrElse String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("请输入完整的密码信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 检查新密码和确认密码是否匹配
        If newPassword <> confirmPassword Then
            MessageBox.Show("新密码和确认密码不匹配，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 查询原始密码是否正确
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE RealName = @RealName AND UserPassword = @UserPassword"
        Using connection As New SqlConnection("Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@RealName", currentUserRName)
                command.Parameters.AddWithValue("@UserPassword", originalPassword)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count = 0 Then
                    MessageBox.Show("原始密码不正确，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using
        End Using
        ' 更新密码
        Dim updateQuery As String = "UPDATE Users SET UserPassword = @NewPassword WHERE RealName = @RealName"
        Using connection As New SqlConnection("Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True")
            Using command As New SqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@RealName", currentUserRName)
                command.Parameters.AddWithValue("@NewPassword", newPassword)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("密码修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("密码修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
        LoginForm.Show()
        Me.Close()
    End Sub
End Class