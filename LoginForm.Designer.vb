<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        rbAdmin = New RadioButton()
        rbUser = New RadioButton()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblUsername = New Label()
        lblPassword = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.BackColor = Color.Transparent
        rbAdmin.Font = New Font("Century Gothic", 10.2F)
        rbAdmin.Location = New Point(177, 136)
        rbAdmin.Margin = New Padding(4, 5, 4, 5)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(84, 25)
        rbAdmin.TabIndex = 0
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = False
        ' 
        ' rbUser
        ' 
        rbUser.AutoSize = True
        rbUser.BackColor = Color.Transparent
        rbUser.Font = New Font("Century Gothic", 10.2F)
        rbUser.Location = New Point(276, 136)
        rbUser.Margin = New Padding(4, 5, 4, 5)
        rbUser.Name = "rbUser"
        rbUser.Size = New Size(66, 25)
        rbUser.TabIndex = 1
        rbUser.TabStop = True
        rbUser.Text = "User"
        rbUser.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Century Gothic", 10.2F)
        txtUsername.Location = New Point(276, 173)
        txtUsername.Margin = New Padding(4, 5, 4, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(199, 28)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Century Gothic", 10.2F)
        txtPassword.Location = New Point(276, 227)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(199, 28)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LimeGreen
        btnLogin.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Location = New Point(177, 282)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(298, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Century Gothic", 10.2F)
        lblUsername.Location = New Point(176, 178)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(93, 21)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Century Gothic", 10.2F)
        lblPassword.Location = New Point(176, 232)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(88, 21)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(276, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(112, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Crimson
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(276, 327)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 39)
        Button1.TabIndex = 8
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(620, 380)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(rbUser)
        Controls.Add(rbAdmin)
        Margin = New Padding(4, 5, 4, 5)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbUser As RadioButton
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
