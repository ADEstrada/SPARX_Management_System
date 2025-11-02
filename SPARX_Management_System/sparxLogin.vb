Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Configuration
Imports System.Data
Imports System.Net.Http
Imports System.Threading.Tasks

Imports MySqlConnector
Imports BCrypt.Net

Public Class sparxLogin
    Private Const ROLE_SUPER_ADMIN As String = "Super Admin"
    Private Const ROLE_ADMIN As String = "Admin"
    Private Const ROLE_SUBSCRIBER As String = "Subscriber"
    Private Const ROLE_CUSTOMER_SERVICE As String = "Customer Service"

    Private selectedRole As String = ROLE_SUBSCRIBER

    Private Shared ReadOnly http As New HttpClient()
    Private Const API_URL As String = "http://127.0.0.1/sparx-api/login.php"

    Private ReadOnly CONNECTION_STRING As String =
        ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString

    Private Sub sparxLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        http.Timeout = TimeSpan.FromSeconds(10)
        Dim ok = TestConnection()
    End Sub

    Private Function TestConnection() As Boolean
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()
                Return conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            MessageBox.Show("DB connection failed: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub picShowHide_Click(sender As Object, e As EventArgs) Handles picShowHide.Click
        If txtPassword.PasswordChar = "●" Then
            txtPassword.PasswordChar = Chr(0)
            picShowHide.Image = My.Resources.eye_open
        Else
            txtPassword.PasswordChar = "●"
            picShowHide.Image = My.Resources.eye_slashed
        End If
    End Sub

    Private Sub pnlPassword_Paint(sender As Object, e As PaintEventArgs) Handles pnlPassword.Paint
    End Sub

    Private Sub btnSuperAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        selectedRole = ROLE_SUPER_ADMIN
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        selectedRole = ROLE_ADMIN
    End Sub

    Private Sub btnSubscriber_Click(sender As Object, e As EventArgs) Handles btnSubscriber.Click
        selectedRole = ROLE_SUBSCRIBER
    End Sub

    Private Sub UserRole_Click(sender As Object, e As EventArgs) Handles btnSubscriber.Click, btnAdmin.Click, btnSuperAdmin.Click
        btnSuperAdmin.Font = New Font(btnSuperAdmin.Font, FontStyle.Regular)
        btnAdmin.Font = New Font(btnAdmin.Font, FontStyle.Regular)
        btnSubscriber.Font = New Font(btnSubscriber.Font, FontStyle.Regular)

        Dim clickedLabel = CType(sender, Label)
        clickedLabel.Font = New Font(clickedLabel.Font, FontStyle.Bold)

        lblWelcome.Text = "Welcome Back!"
        btnSignup.Text = "Sign In"
        lblUserLevel.Text = clickedLabel.Text & " Login"

        LblHAA.Visible = False
        LinkBtnLogin.Visible = False

        If clickedLabel Is btnSubscriber Then
            LblDHA.Visible = True
            LinkBtnSignup.Visible = True
            lblAccess.Visible = False
            lnkAdminContact.Visible = False
            selectedRole = ROLE_SUBSCRIBER
        ElseIf clickedLabel Is btnAdmin Then
            LblDHA.Visible = False
            LinkBtnSignup.Visible = False
            lblAccess.Visible = True
            lnkAdminContact.Visible = True
            selectedRole = ROLE_ADMIN
        Else
            LblDHA.Visible = False
            LinkBtnSignup.Visible = False
            lblAccess.Visible = True
            lnkAdminContact.Visible = True
            selectedRole = ROLE_SUPER_ADMIN
        End If
    End Sub

    Private Sub LinkBtnSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBtnSignup.LinkClicked
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

    Private Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Async Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(email) AndAlso String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both an email and a password to sign up.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your email.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter your password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If btnSignup.Text = "Sign Up" Then
            Dim form As New Dictionary(Of String, String) From {
                {"action", "signup"},
                {"email", email},
                {"username", email},
                {"password", password},
                {"role", selectedRole}
            }
            Dim content = New FormUrlEncodedContent(form)

            Try
                Dim resp = Await http.PostAsync(API_URL, content)
                Dim responseString = Await resp.Content.ReadAsStringAsync()

                If Not resp.IsSuccessStatusCode Then
                    MessageBox.Show("Server returned " & CInt(resp.StatusCode) & ": " & resp.ReasonPhrase, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If responseString.Contains("""status"":""success""") OrElse responseString.Contains("""success"":true") Then
                    MessageBox.Show("Sign up successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LinkBtnLogin_LinkClicked(LinkBtnLogin, Nothing)
                    txtEmail.Text = ""
                    txtPassword.Text = ""
                Else
                    Dim messageMatch As Match = Regex.Match(responseString, """message"":""([^""]+)""")
                    Dim errorMessage As String = If(messageMatch.Success, messageMatch.Groups(1).Value, "Sign up failed.")
                    MessageBox.Show(errorMessage, "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error connecting to server: " & ex.Message & " (Check XAMPP and URL: " & API_URL & ")", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Dim form As New Dictionary(Of String, String) From {
                {"action", "login"},
                {"email", email},
                {"username", email},
                {"password", password},
                {"role", selectedRole}
            }
            Dim content = New FormUrlEncodedContent(form)

            Try
                Dim resp = Await http.PostAsync(API_URL, content)
                Dim responseString = Await resp.Content.ReadAsStringAsync()

                If Not resp.IsSuccessStatusCode Then
                    MessageBox.Show("Server returned " & CInt(resp.StatusCode) & ": " & resp.ReasonPhrase, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If responseString.Contains("""status"":""success""") OrElse responseString.Contains("""success"":true") Then
                    Dim roleMatch As Match = Regex.Match(responseString, """user_role"":""([^""]+)""")
                    Dim userRole As String = If(roleMatch.Success, roleMatch.Groups(1).Value, "User")

                    Select Case userRole
                        Case ROLE_SUPER_ADMIN
                            Dim dash As New dashboardSuperAdmin()
                            ' dash.CurrentUserName = email   ' if you add this property
                            ' dash.CurrentUserRole = userRole
                            Me.Hide()
                            dash.Show()
                            AddHandler dash.FormClosed, Sub() Me.Close()

                        Case ROLE_ADMIN
            ' Dim f As New AdminDashboard() : Me.Hide() : f.Show()
            ' AddHandler f.FormClosed, Sub() Me.Close()

                        Case ROLE_CUSTOMER_SERVICE
                            ' Dim f As New CustomerServiceDashboard() : Me.Hide() : f.Show()
                            ' AddHandler f.FormClosed, Sub() Me.Close()

                        Case Else
                            ' Dim f As New SubscriberHome() : Me.Hide() : f.Show()
                            ' AddHandler f.FormClosed, Sub() Me.Close()
                    End Select
                Else
                    Dim messageMatch As Match = Regex.Match(responseString, """message"":""([^""]+)""")
                    Dim errorMessage As String = If(messageMatch.Success, messageMatch.Groups(1).Value, "Login failed.")
                    MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error connecting to server: " & ex.Message & " (Check XAMPP is running and URL is correct: " & API_URL & ")", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint
    End Sub
End Class