Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class ForgotVerification
    Private Sub pnlEmail_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub ButtonRounded3_Click(sender As Object, e As EventArgs) Handles ButtonRounded3.Click
        ' Assume verification is successful. After you validate the code, navigate to NewPassword view.
        Dim parentContainer = TryCast(Me.Parent, Control)
        If parentContainer Is Nothing Then
            Return
        End If

        Dim newPasswordView As New NewPassword()
        newPasswordView.Dock = DockStyle.Fill
        parentContainer.Controls.Add(newPasswordView)
        newPasswordView.BringToFront()
    End Sub

    Private Sub ButtonRounded5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblUserLevel_Click(sender As Object, e As EventArgs) Handles lblUserLevel.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonRounded5_Click_1(sender As Object, e As EventArgs) Handles ButtonRounded5.Click
        Dim parentContainer = Me.Parent
        If parentContainer Is Nothing Then Return

        ' Remove this verification view
        parentContainer.Controls.Remove(Me)

        ' Show ForgotPassword (or forgotPasswordView) in the same panel
        Dim fp = parentContainer.Controls.OfType(Of ForgotPassword).FirstOrDefault
        If fp Is Nothing Then
            fp = New ForgotPassword ' or New forgotPasswordView()
            fp.Dock = DockStyle.Fill
            parentContainer.Controls.Add(fp)
        End If
        fp.BringToFront()
    End Sub

    Private Sub ButtonRounded4_Click(sender As Object, e As EventArgs) Handles ButtonRounded4.Click

    End Sub

    Private Sub pnlEmail_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlEmail.Paint

    End Sub

    Private Sub ForgotVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Wire events dynamically to avoid Handles/WithEvents requirement
        Try
            If Verifycode IsNot Nothing Then
                AddHandler Verifycode.KeyPress, AddressOf Verifycode_KeyPress
                AddHandler Verifycode.TextChanged, AddressOf Verifycode_TextChanged
            End If
        Catch
        End Try

        ' Make rounded buttons not change to dark gray on hover/click
        ApplyFlatNoHover(ButtonRounded3)
        ApplyFlatNoHover(ButtonRounded4)
        ApplyFlatNoHover(ButtonRounded5)
    End Sub

    Private Sub ApplyFlatNoHover(btn As Button)
        If btn Is Nothing Then Return
        btn.FlatStyle = FlatStyle.Flat
        btn.UseVisualStyleBackColor = False
        Dim baseColor As Color = btn.BackColor
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = baseColor
        btn.FlatAppearance.MouseDownBackColor = baseColor

    End Sub

    ' Numeric-only for the 6-digit verification code
    Private Sub Verifycode_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Verifycode_TextChanged(sender As Object, e As EventArgs)
        Const maxLen As Integer = 6
        If Verifycode.TextLength > maxLen Then
            Verifycode.Text = Verifycode.Text.Substring(0, maxLen)
            Verifycode.SelectionStart = Verifycode.TextLength
        End If
    End Sub
End Class
