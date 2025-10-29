Imports System.Collections.Specialized
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Imports MySql.Data.MySqlClient

Public Class sparxLogin

    Private selectedRole As String = "Subscriber"

    Private Sub sparxLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        ' Tip: You might want to set the default bold label here, for example:
        ' UserRole_Click(btnSuperAdmin, Nothing)
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

        lblWelcome.Text = "Welcome Back!"
        btnSignup.Text = "Sign In"

        ' 4. Set lblUserLevel's text to match the text of the label that was clicked
        lblUserLevel.Text = clickedLabel.Text & " Login"

        ' Ensure Log In prompt controls are hidden when role is first selected
        LblHAA.Visible = False
        LinkBtnLogin.Visible = False

        If clickedLabel Is btnSubscriber Then

            ' SUBSCRIBER MODE
            LblDHA.Visible = True
            LinkBtnSignup.Visible = True

            lblAccess.Visible = False
            lnkAdminContact.Visible = False

        Else

            ' ADMIN/SUPERADMIN MODE: 
            LblDHA.Visible = False
            LinkBtnSignup.Visible = False

            lblAccess.Visible = True
            lnkAdminContact.Visible = True
        End If

    End Sub

    Private Sub LinkBtnSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBtnSignup.LinkClicked

        lblWelcome.Text = "Hello, Welcome!"
        lblUserLevel.Text = "Subscriber Sign Up"
        btnSignup.Text = "Sign Up"

        LblDHA.Visible = False
        LinkBtnSignup.Visible = False

        LblHAA.Text = "Already Have Account?"
        LinkBtnLogin.Text = "Log In"

        LblHAA.Visible = True
        LinkBtnLogin.Visible = True

    End Sub

    Private Sub LinkBtnLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBtnLogin.LinkClicked

        UserRole_Click(btnSubscriber, Nothing)

        lblWelcome.Text = "Welcome Back!"
        btnSignup.Text = "Sign In"

        LblHAA.Visible = False
        LinkBtnLogin.Visible = False


    End Sub
    Private Sub lblUserLevel_Click(sender As Object, e As EventArgs) Handles lblUserLevel.Click

    End Sub


    Private Const API_URL As String = "http://192.168.2.109/sparx/api.php"

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

        If btnSignup.Text = "Sign Up" Then

            Try
                Using client As New WebClient()
                    Dim data As New NameValueCollection()
                    data.Add("action", "signup")
                    data.Add("email", email)
                    data.Add("password", password)

                    Dim responseBytes As Byte() = client.UploadValues(API_URL, "POST", data)
                    Dim responseString As String = Encoding.UTF8.GetString(responseBytes)

                    If responseString.Contains("""status"":""success""") Then
                        MsgBox("Sign up successful! Please log in.")

                        LinkBtnLogin_LinkClicked(LinkBtnLogin, Nothing)
                        txtEmail.Text = ""
                        txtPassword.Text = ""
                    Else
                        MsgBox("Sign up failed: " & responseString)
                    End If
                End Using

            Catch ex As Exception
                MsgBox("Error connecting to server: " & ex.Message)
            End Try

        Else

            ' Log In Logic
            Try
                Using client As New WebClient()
                    Dim data As New NameValueCollection()
                    data.Add("action", "login")
                    data.Add("email", email)
                    data.Add("password", password)

                    Dim responseBytes As Byte() = client.UploadValues(API_URL, "POST", data)
                    Dim responseString As String = Encoding.UTF8.GetString(responseBytes)

                    If responseString.Contains("""status"":""success""") Then

                        Dim roleMatch As Match = Regex.Match(responseString, """user_role"":""([^""]+)""")
                        Dim userRole As String = If(roleMatch.Success, roleMatch.Groups(1).Value, "Subscriber")

                        MsgBox("Login Successful! Welcome, " & userRole & ".")

                    Else
                        ' FAILURE
                        Dim messageMatch As Match = Regex.Match(responseString, """message"":""([^""]+)""")
                        Dim errorMessage As String = If(messageMatch.Success, messageMatch.Groups(1).Value, "Unknown login error.")
                        MsgBox("Login Failed: " & errorMessage)
                    End If
                End Using

            Catch ex As Exception
                MsgBox("Error connecting to server: " & ex.Message & " (Check XAMPP is running and IP is correct: " & API_URL & ")")
            End Try

        End If


    End Sub

End Class