Public Class InfoManage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        qufen = "ls"
        PersonInfo.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        qufen = "xs"
        PersonInfo.Show()
        Me.Close()
    End Sub

    Private Sub InfoManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 500
    End Sub
End Class