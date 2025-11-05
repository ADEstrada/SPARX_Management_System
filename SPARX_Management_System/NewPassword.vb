Public Class NewPassword
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonRounded4_Click(sender As Object, e As EventArgs) Handles ButtonRounded4.Click
        Dim parentContainer = TryCast(Me.Parent, Control)
        If parentContainer Is Nothing Then
            Return
        End If
        parentContainer.Controls.Remove(Me)

        Dim parentForm = TryCast(Me.FindForm(), sparxLogin)
        If parentForm IsNot Nothing Then
            Dim restore = parentForm.GetType().GetMethod("RestoreLoginView", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Public)
            If restore IsNot Nothing Then
                restore.Invoke(parentForm, Nothing)
            End If
        End If
    End Sub

    Private Sub ButtonRounded1_Click(sender As Object, e As EventArgs) Handles ButtonRounded1.Click
        Dim newPw As String = If(txtEmail IsNot Nothing, txtEmail.Text.Trim(), String.Empty)
        Dim confirm As String = If(TextBox1 IsNot Nothing, TextBox1.Text.Trim(), String.Empty)

        If String.IsNullOrEmpty(newPw) OrElse String.IsNullOrEmpty(confirm) Then
            MessageBox.Show("Please fill in both password fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPw <> confirm Then
            MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Call your API to actually change the password here.
        MessageBox.Show("Password updated successfully. Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Navigate back to the role-specific login view
        ButtonRounded4_Click(sender, e)
    End Sub
End Class
