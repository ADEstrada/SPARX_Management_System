Imports System.Collections.Specialized
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Imports SHA256 = System.Security.Cryptography.SHA256
Imports MySql.Data.MySqlClient

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

    Private Sub chkRemember_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Const API_URL As String = "http://10.37.52.111/sparx/api.php"

    Private Function IsValidEmail(ByVal email As String) As Boolean

        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(email, pattern)

    End Function

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(email) And String.IsNullOrEmpty(password) Then
            MsgBox("Please enter both an email and a password to sign up.")
            Exit Sub

        ElseIf String.IsNullOrEmpty(email) Then
            MsgBox("Please enter your email.")
            Exit Sub

        ElseIf String.IsNullOrEmpty(password) Then
            MsgBox("Please enter your password.")
            Exit Sub

        End If

        If Not IsValidEmail(email) Then
            MsgBox("Please enter a valid email address.")
            Exit Sub
        End If

        Try
            Using client As New WebClient()
                Dim data As New NameValueCollection()
                data.Add("action", "signup")
                data.Add("email", email)
                data.Add("password", password)

                Dim responseBytes As Byte() = client.UploadValues(API_URL, "POST", data)
                Dim responseString As String = Encoding.UTF8.GetString(responseBytes)

                If responseString.Contains("""status"":""success""") Then
                    MsgBox("Sign up successful!")
                    txtEmail.Text = ""
                    txtPassword.Text = ""

                Else
                    MsgBox("Sign up failed: " & responseString)

                End If
            End Using

        Catch ex As Exception
            MsgBox("Error connecting to server: " & ex.Message)
        End Try
    End Sub

    Private Sub line_Click(sender As Object, e As EventArgs) Handles line.Click

    End Sub
End Class