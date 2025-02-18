Imports System.Data.SqlClient

Public Class SMSForm
    Private Sub SMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen ' 在Form_Load事件中设置窗体初始位置为屏幕中央
        Me.Width = 800
        Me.Height = 500
        Label1.Text = "欢迎您！" + currentUserRName + "(" + currentUserRole + ")"
        Button2.Text = "课程管理" ' 根据当前用户身份设置按钮文本和功能
        Button3.Text = "班级管理"
        Button7.Text = "发布通知"
        Select Case currentUserRole
            Case "学生"
                flag = 0
                Button1.Text = "个人信息"
                Button4.Text = "查询成绩"
                Button7.Text = "查看通知"
                GetSno()
            Case "老师"
                flag = 1
                Button1.Text = "个人信息"
                Button4.Text = "成绩录入"   '教哪门课,起始、截止日期
            Case "管理员"
                flag = 2
                Button3.Text = "班级管理"
                Button1.Text = "信息管理"
                Button4.Text = "成绩管理"

        End Select
    End Sub
    Public Sub New()

        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub
    Private Sub GetSno()
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT Sno FROM Student WHERE Sname = @sname"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@sname", currentUserRName)
                connection.Open()
                Dim sno As String = Convert.ToString(command.ExecuteScalar())
                currentnumber = sno  ' 将查询到的学号赋值给当前学生的学号（currentnumber）
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case currentUserRole
            Case "学生"
                flag = 0
                PersonInfo.Show() ' 打开个人信息窗体
                Me.Close()
            Case "老师"
                flag = 1
                PersonInfo.Show() ' 打开个人信息窗体
                Me.Hide()
            Case "管理员"
                flag = 2
                InfoManage.Show() ' 打开信息管理窗体
                Me.Close()
        End Select
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CouManage.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClassManage.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Gradeform.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ChPassW.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case currentUserRole
            Case "学生"
                NoticeStu.Show()
                Me.Close()
            Case "老师"
                NoticeTea.Show() ' 打开个人信息窗体
                Me.Hide()
            Case "管理员"
                NoticeTea.Show() ' 打开个人信息窗体
                Me.Hide()
        End Select
    End Sub
End Class
