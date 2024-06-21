Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private httpClient As New HttpClient()

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Enable KeyPreview for the form to capture key events
        Timer1.Interval = 1 ' Set Timer interval to 1 millisecond
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartStop.Text = "&Start"
        Else
            stopwatch.Start()
            btnStartStop.Text = "&Stop"
            Timer1.Start() ' Start the Timer1 component
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim formData = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .githubLink = txtGithubLink.Text,
            .stopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff")
        }

        ' Check if all fields are filled
        If String.IsNullOrWhiteSpace(formData.name) OrElse
           String.IsNullOrWhiteSpace(formData.email) OrElse
           String.IsNullOrWhiteSpace(formData.phone) OrElse
           String.IsNullOrWhiteSpace(formData.githubLink) Then
            MessageBox.Show("All fields must be filled", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim json = JsonConvert.SerializeObject(formData)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response = Await httpClient.PostAsync("http://localhost:5000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error submitting the form. " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting the form: " & ex.Message)
        End Try

        ' Reset form fields and stopwatch after submission
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGithubLink.Text = ""
        lblStopwatch.Text = "00:00:00.000"
        stopwatch.Reset()
        btnStartStop.Text = "&Start"
        Timer1.Stop()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ctrl + S: Start/Stop Stopwatch
            btnStartStop.PerformClick()
            e.SuppressKeyPress = True ' Prevent the key event from being processed further
        ElseIf e.Control AndAlso e.KeyCode = Keys.Enter Then
            ' Ctrl + Enter: Submit Form
            btnSubmit.PerformClick()
            e.SuppressKeyPress = True ' Prevent the key event from being processed further
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
