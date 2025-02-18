<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticeTea
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
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ContentTextBox = New System.Windows.Forms.TextBox()
        Me.PublishButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(166, 53)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(867, 35)
        Me.TitleTextBox.TabIndex = 0
        '
        'ContentTextBox
        '
        Me.ContentTextBox.Location = New System.Drawing.Point(166, 173)
        Me.ContentTextBox.Multiline = True
        Me.ContentTextBox.Name = "ContentTextBox"
        Me.ContentTextBox.Size = New System.Drawing.Size(1138, 546)
        Me.ContentTextBox.TabIndex = 1
        '
        'PublishButton
        '
        Me.PublishButton.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PublishButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PublishButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PublishButton.Location = New System.Drawing.Point(1166, 53)
        Me.PublishButton.Name = "PublishButton"
        Me.PublishButton.Size = New System.Drawing.Size(124, 60)
        Me.PublishButton.TabIndex = 21
        Me.PublishButton.Text = "发送"
        Me.PublishButton.UseVisualStyleBackColor = False
        '
        'NoticeTea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 867)
        Me.Controls.Add(Me.PublishButton)
        Me.Controls.Add(Me.ContentTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Name = "NoticeTea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "发布通知"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents ContentTextBox As TextBox
    Friend WithEvents PublishButton As Button
End Class
