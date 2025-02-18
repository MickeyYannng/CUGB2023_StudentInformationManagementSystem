<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticeStu
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NotificationsListBox = New System.Windows.Forms.ListBox()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NotificationsListBox
        '
        Me.NotificationsListBox.FormattingEnabled = True
        Me.NotificationsListBox.ItemHeight = 24
        Me.NotificationsListBox.Location = New System.Drawing.Point(119, 122)
        Me.NotificationsListBox.Name = "NotificationsListBox"
        Me.NotificationsListBox.Size = New System.Drawing.Size(1278, 700)
        Me.NotificationsListBox.TabIndex = 0
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ReturnButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReturnButton.Location = New System.Drawing.Point(1273, 37)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(124, 60)
        Me.ReturnButton.TabIndex = 22
        Me.ReturnButton.Text = "返回"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'NoticeStu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.NotificationsListBox)
        Me.Name = "NoticeStu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查看通知"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotificationsListBox As ListBox
    Friend WithEvents ReturnButton As Button
End Class
