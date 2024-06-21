<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSubmissionsForm))
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BorderStyle = BorderStyle.FixedSingle
        lblName.Font = New Font("Century Gothic", 9F)
        lblName.Location = New Point(130, 131)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(63, 22)
        lblName.TabIndex = 0
        lblName.Text = "Name: "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BorderStyle = BorderStyle.FixedSingle
        lblEmail.Font = New Font("Century Gothic", 9F)
        lblEmail.Location = New Point(130, 170)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(56, 22)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email: "
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BorderStyle = BorderStyle.FixedSingle
        lblPhone.Font = New Font("Century Gothic", 9F)
        lblPhone.Location = New Point(130, 206)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(66, 22)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone: "
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.BorderStyle = BorderStyle.FixedSingle
        lblGithubLink.Font = New Font("Century Gothic", 9F)
        lblGithubLink.Location = New Point(130, 242)
        lblGithubLink.Margin = New Padding(4, 0, 4, 0)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(99, 22)
        lblGithubLink.TabIndex = 3
        lblGithubLink.Text = "Github Link: "
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Font = New Font("Century Gothic", 9F)
        lblStopwatchTime.Location = New Point(130, 282)
        lblStopwatchTime.Margin = New Padding(4, 0, 4, 0)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(134, 22)
        lblStopwatchTime.TabIndex = 4
        lblStopwatchTime.Text = "Stopwatch Time: "
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.SlateBlue
        btnPrevious.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        btnPrevious.ForeColor = SystemColors.ButtonHighlight
        btnPrevious.Location = New Point(11, 385)
        btnPrevious.Margin = New Padding(4, 5, 4, 5)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(100, 35)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DarkSlateBlue
        btnNext.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        btnNext.ForeColor = SystemColors.ButtonHighlight
        btnNext.Location = New Point(119, 385)
        btnNext.Margin = New Padding(4, 5, 4, 5)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(100, 35)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(227, 385)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 35)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 8
        Label1.Text = "Existing data "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(11, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(8, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 10
        Label2.Text = "NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(8, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 11
        Label3.Text = "EMAIL:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 12
        Label4.Text = "PHONE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(8, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 13
        Label5.Text = "GITHUB:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 20)
        Label6.TabIndex = 14
        Label6.Text = "TIME:"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 434)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewSubmissionsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Submissions"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()



    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
