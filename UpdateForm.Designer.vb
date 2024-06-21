<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        btnSave = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Century Gothic", 9F)
        txtName.Location = New Point(276, 166)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(223, 26)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Enabled = False
        txtEmail.Font = New Font("Century Gothic", 9F)
        txtEmail.Location = New Point(276, 206)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(223, 26)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Century Gothic", 9F)
        txtPhone.Location = New Point(276, 246)
        txtPhone.Margin = New Padding(4, 5, 4, 5)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(223, 26)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Century Gothic", 9F)
        txtGithubLink.Location = New Point(276, 286)
        txtGithubLink.Margin = New Padding(4, 5, 4, 5)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(223, 26)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        txtStopwatchTime.Font = New Font("Century Gothic", 9F)
        txtStopwatchTime.Location = New Point(276, 326)
        txtStopwatchTime.Margin = New Padding(4, 5, 4, 5)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(223, 26)
        txtStopwatchTime.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Century Gothic", 9F)
        lblName.Location = New Point(145, 172)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(57, 20)
        lblName.TabIndex = 5
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 9F)
        lblEmail.Location = New Point(145, 212)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(50, 20)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Century Gothic", 9F)
        lblPhone.Location = New Point(145, 252)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(60, 20)
        lblPhone.TabIndex = 7
        lblPhone.Text = "Phone:"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Font = New Font("Century Gothic", 9F)
        lblGithubLink.Location = New Point(144, 291)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(93, 20)
        lblGithubLink.TabIndex = 8
        lblGithubLink.Text = "Github Link:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Font = New Font("Century Gothic", 9F)
        lblStopwatchTime.Location = New Point(145, 331)
        lblStopwatchTime.Margin = New Padding(4, 0, 4, 0)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(128, 20)
        lblStopwatchTime.TabIndex = 9
        lblStopwatchTime.Text = "Stopwatch Time:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.ForestGreen
        btnSave.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(325, 381)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 35)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.Location = New Point(239, 115)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 20)
        Label1.TabIndex = 11
        Label1.Text = "Update you data then click save"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(294, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(131, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' UpdateForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 448)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UpdateForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
