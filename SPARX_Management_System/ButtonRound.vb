Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class ButtonRounded
    Inherits Button

    ' This new property will show up in the designer
    <Description("The radius for the button's rounded corners.")>
    <Category("Appearance")>
    <DefaultValue(20)>
    Public Property CornerRadius As Integer = 20

    ' This is the magic function that creates the rounded shape
    Private Function GetRoundedRect(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim r As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, r, r, 180, 90) ' Top-left
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90) ' Top-right
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90) ' Bottom-right
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90) ' Bottom-left
        path.CloseFigure()
        Return path
    End Function

    ' This overrides the default button constructor
    Public Sub New()
        MyBase.New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.BackColor = Color.FromArgb(70, 130, 255) ' Set a default blue color
        Me.ForeColor = Color.White ' Set a default text color
    End Sub

    ' This is where we override the button's drawing behavior
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        ' Do NOT call MyBase.OnPaint(pevent), we are drawing everything ourselves

        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Clear the background with the parent's color
        g.Clear(Me.Parent.BackColor)

        ' Get the rectangle for the button's area
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Create the rounded shape
        Using path As GraphicsPath = GetRoundedRect(rect, CornerRadius)

            ' --- Fill the button background ---
            ' We check the state to give a "click" effect
            Dim fillColor As Color
            If Me.Enabled = False Then
                fillColor = Color.Gray
            ElseIf Me.Capture AndAlso Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
                ' Use MouseDownBackColor if defined, otherwise darken the BackColor
                fillColor = If(Me.FlatAppearance.MouseDownBackColor = Color.Empty,
                               ControlPaint.Dark(Me.BackColor, 0.1),
                               Me.FlatAppearance.MouseDownBackColor)
            ElseIf Me.ClientRectangle.Contains(Me.PointToClient(MousePosition)) Then
                ' Use MouseOverBackColor if defined, otherwise lighten the BackColor
                fillColor = If(Me.FlatAppearance.MouseOverBackColor = Color.Empty,
                               ControlPaint.Light(Me.BackColor, 0.1),
                               Me.FlatAppearance.MouseOverBackColor)
            Else
                fillColor = Me.BackColor
            End If

            Using brush As New SolidBrush(fillColor)
                g.FillPath(brush, path)
            End Using

            ' --- Draw the border ---
            ' Use FlatAppearance.BorderColor and BorderSize
            If Me.FlatAppearance.BorderSize > 0 Then
                Using pen As New Pen(Me.FlatAppearance.BorderColor, Me.FlatAppearance.BorderSize)
                    ' Adjust rect for border size
                    Dim borderRect As New Rectangle(rect.X + CInt(Math.Floor(Me.FlatAppearance.BorderSize / 2.0)),
                                                   rect.Y + CInt(Math.Floor(Me.FlatAppearance.BorderSize / 2.0)),
                                                   rect.Width - Me.FlatAppearance.BorderSize,
                                                   rect.Height - Me.FlatAppearance.BorderSize)
                    Using borderPath As GraphicsPath = GetRoundedRect(borderRect, CornerRadius)
                        g.DrawPath(pen, borderPath)
                    End Using
                End Using
            End If

            ' --- Draw the text ---
            TextRenderer.DrawText(g, Me.Text, Me.Font, rect, Me.ForeColor,
                                  TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End Using
    End Sub

    ' This override sets the region to make the corners transparent
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Using path As GraphicsPath = GetRoundedRect(New Rectangle(0, 0, Me.Width, Me.Height), CornerRadius)
            Me.Region = New Region(path)
        End Using
    End Sub
End Class