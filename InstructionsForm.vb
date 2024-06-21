Public Class InstructionsForm
    Private Sub InstructionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim instructions As String = "This is the Slidely Project made by Nandana Pradeep. " &
                                     vbCrLf & vbCrLf &
                                     "This is a small set of instructions to use the application:" & vbCrLf &
                                     "                                                                               " & vbCrLf &
                                     "1. You have 3 options: view submissions, create submission, and     edit responses." & vbCrLf &
                                      "                                                                               " & vbCrLf &
                                     "2. Before you can access, you need to login as an admin or user. " &
                                     "   If you are the admin, you can only view different submissions and delete them if you want. " &
                                     "   If you are a user, you can create your submission and edit them  but cannot view responses or delete them." & vbCrLf &
                                      "                                                                               " & vbCrLf &
                                     "3. Shortcut keys are available: " & vbCrLf &
                                     "   - Submit:'Ctrl + Enter" & vbCrLf &
                                     "   - Start timer:'Ctrl + S'" & vbCrLf &
                                     "   - Next:'Ctrl + N'" & vbCrLf &
                                     "   - Previous:'Ctrl + P'" & vbCrLf &
                                     vbCrLf & "Thank you for the opportunity, hope you like it :)"

        txtInstructions.Text = instructions
        txtInstructions.AutoSize = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()



    End Sub

    Private Sub txtInstructions_TextChanged(sender As Object, e As EventArgs) Handles txtInstructions.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
