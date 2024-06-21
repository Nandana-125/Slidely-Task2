Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private forms As List(Of FormModel)
    Private httpClient As New HttpClient()

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Enable KeyPreview for the form to capture key events
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadForms()
        DisplayForm()
    End Sub

    Private Async Function LoadForms() As Task
        Dim response = Await httpClient.GetStringAsync("http://localhost:5000/forms")
        forms = JsonConvert.DeserializeObject(Of List(Of FormModel))(response)
    End Function

    Private Sub DisplayForm()
        If forms IsNot Nothing AndAlso forms.Count > 0 Then
            Dim form = forms(currentIndex)
            lblName.Text = form.name
            lblEmail.Text = form.email
            lblPhone.Text = form.phone
            lblGithubLink.Text = form.githubLink
            lblStopwatchTime.Text = form.stopwatchTime
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If forms IsNot Nothing AndAlso forms.Count > 0 Then
            Dim formToDelete = forms(currentIndex)
            Dim confirmation = MessageBox.Show($"Are you sure you want to delete the form entry for {formToDelete.name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                Await DeleteFormFromServer(currentIndex)
                forms.RemoveAt(currentIndex)
                If forms.Count > 0 Then
                    If currentIndex >= forms.Count Then
                        currentIndex = forms.Count - 1
                    End If
                    DisplayForm()
                Else
                    ClearForm()
                End If
            End If
        End If
    End Sub

    Private Async Function DeleteFormFromServer(index As Integer) As Task
        Dim response = Await httpClient.DeleteAsync("http://localhost:5000/form/" & index)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Data Deleted Successfully.")
        Else
            MessageBox.Show("Error deleting form entry from the server.")
        End If
    End Function

    Private Sub ClearForm()
        lblName.Text = ""
        lblEmail.Text = ""
        lblPhone.Text = ""
        lblGithubLink.Text = ""
        lblStopwatchTime.Text = ""
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NavigateNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NavigatePrevious()
    End Sub

    Private Sub NavigateNext()
        If currentIndex < forms.Count - 1 Then
            currentIndex += 1
            DisplayForm()
        End If
    End Sub

    Private Sub NavigatePrevious()
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayForm()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N: Next form
            NavigateNext()
            e.SuppressKeyPress = True ' Prevent the key event from being processed further
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            ' Ctrl + P: Previous form
            NavigatePrevious()
            e.SuppressKeyPress = True ' Prevent the key event from being processed further
        End If
    End Sub


    Public Sub btnUpdateForm_Click(sender As Object, e As EventArgs)



    End Sub
End Class

Public Class FormModel
    Public Property id As Integer ' Assuming each form entry has an ID for identification
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property githubLink As String
    Public Property stopwatchTime As String
End Class
