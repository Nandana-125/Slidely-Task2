<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchEmailForm
    Inherits System.Windows.Forms.Form

    ' Required designer variable
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchEmailForm))
        txtEmail = New TextBox()
        lblEmail = New Label()
        btnSearch = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Century Gothic", 9F)
        txtEmail.Location = New Point(115, 159)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(360, 26)
        txtEmail.TabIndex = 0
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 9F)
        lblEmail.Location = New Point(57, 161)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(50, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.DarkSlateGray
        btnSearch.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(213, 206)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(140, 45)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.Location = New Point(150, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 20)
        Label1.TabIndex = 3
        Label1.Text = "Search  your email to update data"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(246, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 154)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' SearchEmailForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 275)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnSearch)
        Controls.Add(lblEmail)
        Controls.Add(txtEmail)
        Margin = New Padding(4, 5, 4, 5)
        Name = "SearchEmailForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search by Email"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
