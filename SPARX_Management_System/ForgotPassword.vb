Public Class ForgotPassword
    Public Event SendCodeRequested()
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonRounded2_Click(sender As Object, e As EventArgs) Handles ButtonRounded2.Click
        Dim parentContainer = TryCast(Me.Parent, Control)
        If parentContainer IsNot Nothing Then
            parentContainer.Controls.Remove(Me)
        End If
    End Sub

    Private Sub ButtonRounded1_Click(sender As Object, e As EventArgs) Handles ButtonRounded1.Click
        RaiseEvent SendCodeRequested()
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        Try
            Me.Dock = DockStyle.Fill
            If pnlLoginCard IsNot Nothing Then
                pnlLoginCard.Dock = DockStyle.Fill
                pnlLoginCard.AutoScroll = True
                pnlLoginCard.Margin = Padding.Empty
                pnlLoginCard.Padding = Padding.Empty
            End If
        Catch
        End Try
    End Sub
End Class
