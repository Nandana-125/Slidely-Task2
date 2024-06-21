Public Class LoginForm
    Private Sub rbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdmin.CheckedChanged
        If rbAdmin.Checked Then
            txtUsername.Text = "admin"
            txtPassword.Text = "admin"
        End If
    End Sub

    Private Sub rbUser_CheckedChanged(sender As Object, e As EventArgs) Handles rbUser.CheckedChanged
        If rbUser.Checked Then
            txtUsername.Text = "user"
            txtPassword.Text = "user"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        If rbAdmin.Checked AndAlso username = "admin" AndAlso password = "admin" Then
            Dim mainForm As New MainForm(True) ' Passing False for isAdmin
            mainForm.Show()
            Hide()
        ElseIf rbUser.Checked AndAlso username = "user" AndAlso password = "user" Then
            Dim mainForm As New MainForm(False) ' Passing True for isAdmin
            mainForm.Show()
            Hide()
        Else
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show InstructionForm as popup
        Dim instructionForm As New InstructionsForm()
        instructionForm.StartPosition = FormStartPosition.CenterParent
        instructionForm.ShowDialog(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
End Class
