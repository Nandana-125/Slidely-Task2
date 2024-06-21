<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSubmissionForm))
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        lblStopwatch = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Century Gothic", 9.0F)
        lblName.Location = New Point(89, 269)
        lblName.Name = "lblName"
        lblName.Size = New Size(53, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 9.0F)
        lblEmail.Location = New Point(89, 322)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Century Gothic", 9.0F)
        lblPhone.Location = New Point(89, 375)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(56, 20)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Font = New Font("Century Gothic", 9.0F)
        lblGithubLink.Location = New Point(89, 429)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(90, 20)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "GitHub Link"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Century Gothic", 9.0F)
        txtName.Location = New Point(203, 269)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(228, 26)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Century Gothic", 9.0F)
        txtEmail.Location = New Point(203, 322)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(228, 26)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Century Gothic", 9.0F)
        txtPhone.Location = New Point(203, 375)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(228, 26)
        txtPhone.TabIndex = 6
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Century Gothic", 9.0F)
        txtGithubLink.Location = New Point(203, 429)
        txtGithubLink.Margin = New Padding(3, 4, 3, 4)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(228, 26)
        txtGithubLink.TabIndex = 7
        ' 
        ' btnStartStop
        ' 
        btnStartStop.BackColor = Color.Brown
        btnStartStop.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStartStop.ForeColor = SystemColors.ButtonHighlight
        btnStartStop.Location = New Point(237, 159)
        btnStartStop.Margin = New Padding(3, 4, 3, 4)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(114, 40)
        btnStartStop.TabIndex = 8
        btnStartStop.Text = "&Start"
        btnStartStop.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DeepSkyBlue
        btnSubmit.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ButtonHighlight
        btnSubmit.Location = New Point(89, 486)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(365, 40)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStopwatch.Location = New Point(237, 220)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(127, 23)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00.000"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 69)
        Label1.TabIndex = 11
        Label1.Text = "      Enter Your Details" & vbCrLf & vbCrLf & "  Click start to start the timer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(44, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.0F)
        Label2.Location = New Point(92, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 13
        Label2.Text = "Timer"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 575)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(lblStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateSubmissionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create New Submission"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
