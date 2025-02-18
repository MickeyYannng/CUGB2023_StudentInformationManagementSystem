Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class signUpForm
    Private Sub signUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 添加三种身份选项到 ComboBox
        PermissionComboBox.Items.Add("学生")
        PermissionComboBox.Items.Add("老师")
        PermissionComboBox.Items.Add("管理员")
        ' 设置默认选中项
        PermissionComboBox.SelectedIndex = 0
    End Sub
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' 检查用户名和密码是否符合要求
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Or ConfirmPasswordTextBox.Text = "" Then
            MessageBox.Show("请填写所有必要的信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' 检查密码和确认密码是否匹配
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MessageBox.Show("确认密码与密码不匹配！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If AuthorizationBox.Text <> "shouquanma" Then
            MessageBox.Show("授权码不正确！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' 将用户名、密码、权限和实名信息存储到数据库中
        Dim UserName As String = UsernameTextBox.Text
        Dim UserPassword As String = PasswordTextBox.Text
        Dim Permission As String = PermissionComboBox.SelectedItem.ToString()
        Dim RealName As String = RealNameTextBox.Text
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO Users (UserName, UserPassword,Permission,RealName) VALUES (@Name, @Password,@Permission,@RName); select scope_identity()"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                command.Parameters.AddWithValue("@Name", getName())
                command.Parameters.AddWithValue("@Password", getPassword())
                command.Parameters.AddWithValue("@Permission", getPermission())
                command.Parameters.AddWithValue("@RName", getRName())
                ' 获取插入的自增值（UserID）
                Dim userID As Integer = Convert.ToInt32(command.ExecuteScalar())
                ' 使用生成的UserID进行其他操作，或将其返回给调用者
            End Using
        End Using
        MessageBox.Show("注册成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Public Function getName() As String
        Return UsernameTextBox.Text
    End Function
    Public Function getPermission() As String
        Return PermissionComboBox.SelectedItem.ToString()
    End Function
    Public Function getPassword() As String
        Return PasswordTextBox.Text
    End Function
    Public Function getRName() As String
        Return RealNameTextBox.Text
    End Function
End Class
