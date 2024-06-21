Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private isAdmin As Boolean

    ' Constructor with parameters
    Public Sub New(isAdmin As Boolean)
        ' Initialize components from the designer-generated code
        InitializeComponent()

        ' Set isAdmin field based on parameter
        Me.isAdmin = isAdmin

        ' Configure buttons based on isAdmin
        ConfigureButtons()
    End Sub

    ' Method to configure button visibility and enable/disable based on isAdmin
    Private Sub ConfigureButtons()
        If isAdmin Then
            ' Admin-specific settings
            btnViewSubmissions.Enabled = True
            btnCreateSubmission.Enabled = False
            btnEditSubmission.Enabled = False
        Else
            ' User-specific settings
            btnViewSubmissions.Enabled = False
            btnCreateSubmission.Enabled = True
            btnEditSubmission.Enabled = True
        End If
    End Sub

    ' Event handler for btnViewSubmissions click event
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    ' Event handler for btnCreateSubmission click event
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Event handler for btnEditSubmission click event
    Private Sub btnEditSubmission_Click(sender As Object, e As EventArgs) Handles btnEditSubmission.Click
        Dim searchForm As New SearchEmailForm()
        searchForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can add additional initialization logic here if needed
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginForm As New LoginForm
        loginForm.Show
        Close
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim instructionForm As New InstructionsForm()
        instructionForm.StartPosition = FormStartPosition.CenterParent
        instructionForm.ShowDialog(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
