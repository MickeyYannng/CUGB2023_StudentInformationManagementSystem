Imports System.Data.SqlClient

Public Class NoticeStu
    Private Sub NoticeStu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
        LoadNotifications()
    End Sub

    Private Sub LoadNotifications()
        Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
        Dim query As String = "SELECT Title, Content, CreatedBy,CreatedAt FROM Notifications ORDER BY CreatedAt DESC"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim title As String = reader("Title")
                    Dim content As String = reader("Content")
                    Dim CreatedBy As String = reader("CreatedBy")
                    Dim createdAt As DateTime = reader("CreatedAt")
                    NotificationsListBox.Items.Add($"{createdAt}: {title}")
                End While
            End Using
        End Using
    End Sub

    Private Sub NotificationsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NotificationsListBox.SelectedIndexChanged
        Dim selectedIndex As Integer = NotificationsListBox.SelectedIndex
        If selectedIndex <> -1 Then
            Dim connectionString As String = "Data Source=LAPTOP-DRV4UE0I;Initial Catalog=SMS;Integrated Security=True"
            Dim query As String = "SELECT Title, Content, CreatedBy,CreatedAt FROM Notifications ORDER BY CreatedAt DESC"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    For i As Integer = 0 To selectedIndex
                        reader.Read()
                    Next
                    Dim title As String = reader("Title")
                    Dim content As String = reader("Content")
                    Dim createdAt As DateTime = reader("CreatedAt")
                    Dim createdBy As String = reader("CreatedBy") ' 获取发送人信息
                    MessageBox.Show($"{createdAt}: {title}{Environment.NewLine}{Environment.NewLine}{content}{Environment.NewLine}{Environment.NewLine}Sent by: {createdBy}", "Notification Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        End If
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        SMSForm.Show()
        Me.Close()
    End Sub
End Class


