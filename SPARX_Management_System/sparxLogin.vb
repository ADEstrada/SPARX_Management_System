Public Class sparxLogin
    Private Sub sparxLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        ' Tip: You might want to set the default bold label here, for example:
        ' UserRole_Click(btnSuperAdmin, Nothing)
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sparxLogo_Click(sender As Object, e As EventArgs) Handles sparxLogo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub


    Private Sub lnkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub pnlEmail_Paint(sender As Object, e As PaintEventArgs) Handles pnlEmail.Paint

    End Sub

    Private Sub picShowHide_Click(sender As Object, e As EventArgs) Handles picShowHide.Click
        ' Check if the password is currently hidden
        If txtPassword.PasswordChar = "●" Then
            ' --- SHOW THE PASSWORD ---

            ' 1. Set the PasswordChar to a null character (which shows the text)
            txtPassword.PasswordChar = Chr(0)

            ' 2. Change the image to the "open eye"
            picShowHide.Image = My.Resources.eye_open
        Else
            ' --- HIDE THE PASSWORD ---

            ' 1. Set the PasswordChar back to an asterisk
            txtPassword.PasswordChar = "●"

            ' 2. Change the image back to the "slashed eye"
            picShowHide.Image = My.Resources.eye_slashed
        End If
    End Sub

    Private Sub pnlPassword_Paint(sender As Object, e As PaintEventArgs) Handles pnlPassword.Paint

    End Sub

    ' --- This single method handles all three labels ---
    Private Sub UserRole_Click(sender As Object, e As EventArgs) Handles btnSubscriber.Click, btnAdmin.Click, btnSuperAdmin.Click

        ' 1. Reset all three labels to the regular font style
        '    (This keeps their original font and size)
        btnSuperAdmin.Font = New Font(btnSuperAdmin.Font, FontStyle.Regular)
        btnAdmin.Font = New Font(btnAdmin.Font, FontStyle.Regular)
        btnSubscriber.Font = New Font(btnSubscriber.Font, FontStyle.Regular)

        ' 2. Get the specific label that was just clicked
        Dim clickedLabel = CType(sender, Label)

        ' 3. Set ONLY the clicked label to bold
        clickedLabel.Font = New Font(clickedLabel.Font, FontStyle.Bold)

        ' 4. Set lblUserLevel's text to match the text of the label that was clicked
        lblUserLevel.Text = clickedLabel.Text & " Login"

    End Sub

    Private Sub lblUserLevel_Click(sender As Object, e As EventArgs) Handles lblUserLevel.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub pnlLoginCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlLoginCard.Paint

    End Sub

    Private Sub ButtonRounded1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

    End Sub

    Private Sub line_Click(sender As Object, e As EventArgs) Handles line.Click

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub
End Class