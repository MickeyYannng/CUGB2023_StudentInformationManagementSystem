Imports System.Data.SqlClient

Public Class NoticeTea

    Private Sub PublishButton_Click(sender As Object, e As EventArgs) Handles PublishButton.Click
        Dim title As String = TitleTextBox.Text
        Dim content As String = ContentTextBox.Text

        If String.IsNullOrWhiteSpace(title) OrElse String.IsNullOrWhiteSpace(content) Then
            MessageBox.Show("标题和内容不能为空!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "INSERT INTO Notifications (Title, Content, CreatedBy) VALUES (@Title, @Content, @CreatedBy)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Title", title)
                command.Parameters.AddWithValue("@Content", content)
                command.Parameters.AddWithValue("@CreatedBy", currentUserRName)
                connection.Open()
                If command.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("发送成功！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SMSForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("发送失败!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub NoticeTea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
    End Sub
End Class
