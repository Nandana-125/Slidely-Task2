Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class UpdateForm
    Private httpClient As New HttpClient()
    Private formIndex As Integer
    Private currentForm As FormModel

    Public Sub New(index As Integer, form As FormModel)
        InitializeComponent()
        formIndex = index
        currentForm = form
    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = currentForm.name
        txtEmail.Text = currentForm.email
        txtPhone.Text = currentForm.phone
        txtGithubLink.Text = currentForm.githubLink
        txtStopwatchTime.Text = currentForm.stopwatchTime
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        currentForm.name = txtName.Text
        currentForm.email = txtEmail.Text
        currentForm.phone = txtPhone.Text
        currentForm.githubLink = txtGithubLink.Text
        currentForm.stopwatchTime = txtStopwatchTime.Text

        Dim json = JsonConvert.SerializeObject(currentForm)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        ' Ensure the URL uses the email to target the correct form entry
        Dim response = Await httpClient.PutAsync($"http://localhost:5000/form/email/{currentForm.email}", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show(" updated successfully.")
            Me.Close()
        Else
            Dim errorMessage = Await response.Content.ReadAsStringAsync()
            MessageBox.Show($"Error updating form entry: {errorMessage}")
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
