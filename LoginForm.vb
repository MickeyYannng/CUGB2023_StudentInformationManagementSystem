Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
    End Sub
    Private Sub SignButton_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        Dim registerForm As New signUpForm()
        ClearTextBoxes()
        registerForm.ShowDialog()
    End Sub
    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles logInButton.Click
        Dim userName As String = TextBox1.Text ' 获取用户名输入框中的文本
        Dim password As String = TextBox2.Text ' 获取密码输入框中的文本
        If ValidateUser(userName, password) Then
            MessageBox.Show("登录成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBoxes()
            SMSForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("用户名或密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function ValidateUser(userName As String, password As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT Permission,RealName FROM Users WHERE UserName = @UserName AND UserPassword = @Password "
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserName", userName)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    currentUserRole = reader(0).ToString()
                    currentUserRName = reader(1).ToString()
                    Return True ' 如果找到匹配的用户名和密码，则返回 True，否则返回 False
                End If
            End Using
        End Using
        Return False ' 如果没有找到匹配的用户名和密码，则返回 False
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

