<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstructionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructionsForm))
        txtInstructions = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtInstructions
        ' 
        txtInstructions.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInstructions.HideSelection = False
        txtInstructions.Location = New Point(0, 234)
        txtInstructions.Margin = New Padding(4, 5, 4, 5)
        txtInstructions.Multiline = True
        txtInstructions.Name = "txtInstructions"
        txtInstructions.ReadOnly = True
        txtInstructions.ScrollBars = ScrollBars.Vertical
        txtInstructions.Size = New Size(479, 357)
        txtInstructions.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(130, 626)
        Button1.Name = "Button1"
        Button1.Size = New Size(209, 44)
        Button1.TabIndex = 1
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(157, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 27)
        Label1.TabIndex = 2
        Label1.Text = "INSTRUCTIONS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(157, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' InstructionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 703)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtInstructions)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "InstructionsForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Instructions"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtInstructions As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
