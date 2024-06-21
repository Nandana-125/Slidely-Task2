Imports System.Net.Http
Imports Newtonsoft.Json

Public Class SearchEmailForm
    Private httpClient As New HttpClient()

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtEmail.Text

        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        Try
            Dim response = Await httpClient.GetAsync($"http://localhost:5000/form/email/{email}")

            If response.IsSuccessStatusCode Then
                Dim jsonResponse = Await response.Content.ReadAsStringAsync()
                Dim form = JsonConvert.DeserializeObject(Of FormModel)(jsonResponse)

                If form IsNot Nothing Then
                    ' Pass the form data and index (assuming it's retrieved from the response) to the UpdateForm
                    Dim updateForm As New UpdateForm(form.id, form)
                    updateForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("No form entry found for the provided email address.")
                End If
            Else
                Dim errorMessage = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Error fetching form entry: {errorMessage}")
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub SearchEmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class
