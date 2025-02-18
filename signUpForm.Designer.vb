<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signUpForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RealNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.PermissionComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AuthorizationBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户名："
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.Location = New System.Drawing.Point(194, 92)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(262, 35)
        Me.UsernameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "密码："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "确认密码："
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(194, 177)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(262, 35)
        Me.PasswordTextBox.TabIndex = 4
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(194, 256)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(262, 35)
        Me.ConfirmPasswordTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "权限："
        '
        'RealNameTextBox
        '
        Me.RealNameTextBox.Location = New System.Drawing.Point(194, 430)
        Me.RealNameTextBox.Name = "RealNameTextBox"
        Me.RealNameTextBox.Size = New System.Drawing.Size(262, 35)
        Me.RealNameTextBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "实名信息："
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(185, 614)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(163, 58)
        Me.RegisterButton.TabIndex = 9
        Me.RegisterButton.Text = "注册"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'PermissionComboBox
        '
        Me.PermissionComboBox.FormattingEnabled = True
        Me.PermissionComboBox.Location = New System.Drawing.Point(194, 344)
        Me.PermissionComboBox.Name = "PermissionComboBox"
        Me.PermissionComboBox.Size = New System.Drawing.Size(233, 32)
        Me.PermissionComboBox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 28)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "授权码："
        '
        'AuthorizationBox
        '
        Me.AuthorizationBox.Location = New System.Drawing.Point(188, 520)
        Me.AuthorizationBox.Name = "AuthorizationBox"
        Me.AuthorizationBox.Size = New System.Drawing.Size(262, 35)
        Me.AuthorizationBox.TabIndex = 12
        '
        'signUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(530, 732)
        Me.Controls.Add(Me.AuthorizationBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PermissionComboBox)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RealNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "signUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RealNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents PermissionComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AuthorizationBox As TextBox
End Class
