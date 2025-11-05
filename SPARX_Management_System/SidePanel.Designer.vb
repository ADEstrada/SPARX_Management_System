<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SidePanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SidePanel))
        MenuPanel = New Panel()
        Line2 = New Label()
        HistoryButton = New Button()
        ProfileButton = New Button()
        Line = New Label()
        SparxLogo = New PictureBox()
        MainPanel = New Panel()
        HeaderPanel = New Panel()
        ContentPanel = New Panel()
        Button1 = New Button()
        Line3 = New Label()
        PanelRound1 = New PanelRound()
        SystemOnlineLbl = New Label()
        HeaderLbl = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        MenuPanel.SuspendLayout()
        CType(SparxLogo, ComponentModel.ISupportInitialize).BeginInit()
        HeaderPanel.SuspendLayout()
        PanelRound1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuPanel
        ' 
        MenuPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MenuPanel.BackColor = Color.FromArgb(29, 41, 61)
        MenuPanel.Controls.Add(Panel1)
        MenuPanel.Controls.Add(Line2)
        MenuPanel.Controls.Add(HistoryButton)
        MenuPanel.Controls.Add(ProfileButton)
        MenuPanel.Controls.Add(Line)
        MenuPanel.Controls.Add(SparxLogo)
        MenuPanel.Location = New Point(0, 0)
        MenuPanel.Name = "MenuPanel"
        MenuPanel.Size = New Size(240, 751)
        MenuPanel.TabIndex = 1
        ' 
        ' Line2
        ' 
        Line2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Line2.AutoSize = True
        Line2.ForeColor = Color.FromArgb(42, 53, 72)
        Line2.Location = New Point(-3, 665)
        Line2.Name = "Line2"
        Line2.Size = New Size(247, 15)
        Line2.TabIndex = 5
        Line2.Text = "________________________________________________"
        ' 
        ' HistoryButton
        ' 
        HistoryButton.FlatAppearance.BorderSize = 0
        HistoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 41, 61)
        HistoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 93, 252)
        HistoryButton.FlatStyle = FlatStyle.Flat
        HistoryButton.ForeColor = Color.Transparent
        HistoryButton.Image = CType(resources.GetObject("HistoryButton.Image"), Image)
        HistoryButton.ImageAlign = ContentAlignment.MiddleLeft
        HistoryButton.Location = New Point(0, 122)
        HistoryButton.Name = "HistoryButton"
        HistoryButton.Padding = New Padding(18, 0, 0, 0)
        HistoryButton.Size = New Size(240, 39)
        HistoryButton.TabIndex = 4
        HistoryButton.Text = "           History"
        HistoryButton.TextAlign = ContentAlignment.MiddleLeft
        HistoryButton.UseVisualStyleBackColor = True
        ' 
        ' ProfileButton
        ' 
        ProfileButton.FlatAppearance.BorderSize = 0
        ProfileButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 41, 61)
        ProfileButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 93, 252)
        ProfileButton.FlatStyle = FlatStyle.Flat
        ProfileButton.ForeColor = Color.Transparent
        ProfileButton.Image = My.Resources.Resources.subscriber
        ProfileButton.ImageAlign = ContentAlignment.MiddleLeft
        ProfileButton.Location = New Point(0, 77)
        ProfileButton.Name = "ProfileButton"
        ProfileButton.Padding = New Padding(18, 0, 0, 0)
        ProfileButton.Size = New Size(240, 39)
        ProfileButton.TabIndex = 3
        ProfileButton.Text = "           Profile"
        ProfileButton.TextAlign = ContentAlignment.MiddleLeft
        ProfileButton.UseVisualStyleBackColor = True
        ' 
        ' Line
        ' 
        Line.AutoSize = True
        Line.ForeColor = Color.FromArgb(42, 53, 72)
        Line.Location = New Point(-3, 59)
        Line.Name = "Line"
        Line.Size = New Size(247, 15)
        Line.TabIndex = 2
        Line.Text = "________________________________________________"
        ' 
        ' SparxLogo
        ' 
        SparxLogo.Image = My.Resources.Resources.SparxLogo2
        SparxLogo.Location = New Point(41, 12)
        SparxLogo.Name = "SparxLogo"
        SparxLogo.Size = New Size(117, 55)
        SparxLogo.SizeMode = PictureBoxSizeMode.Zoom
        SparxLogo.TabIndex = 2
        SparxLogo.TabStop = False
        ' 
        ' MainPanel
        ' 
        MainPanel.Location = New Point(0, 67)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1130, 681)
        MainPanel.TabIndex = 2
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.BackColor = Color.White
        HeaderPanel.Controls.Add(Button1)
        HeaderPanel.Controls.Add(MainPanel)
        HeaderPanel.Controls.Add(Line3)
        HeaderPanel.Controls.Add(PanelRound1)
        HeaderPanel.Controls.Add(HeaderLbl)
        HeaderPanel.ForeColor = Color.Black
        HeaderPanel.Location = New Point(240, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Size = New Size(1219, 67)
        HeaderPanel.TabIndex = 2
        ' 
        ' ContentPanel
        ' 
        ContentPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ContentPanel.AutoScroll = True
        ContentPanel.Location = New Point(240, 67)
        ContentPanel.Name = "ContentPanel"
        ContentPanel.Size = New Size(1130, 681)
        ContentPanel.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.notificationBell
        Button1.Location = New Point(1058, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(43, 36)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Line3
        ' 
        Line3.AutoSize = True
        Line3.Location = New Point(-8, 53)
        Line3.Name = "Line3"
        Line3.Size = New Size(1152, 15)
        Line3.TabIndex = 3
        Line3.Text = resources.GetString("Line3.Text")
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.WhiteSmoke
        PanelRound1.Controls.Add(SystemOnlineLbl)
        PanelRound1.Location = New Point(927, 10)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(125, 35)
        PanelRound1.TabIndex = 2
        ' 
        ' SystemOnlineLbl
        ' 
        SystemOnlineLbl.AutoSize = True
        SystemOnlineLbl.Location = New Point(26, 10)
        SystemOnlineLbl.Name = "SystemOnlineLbl"
        SystemOnlineLbl.Size = New Size(83, 15)
        SystemOnlineLbl.TabIndex = 0
        SystemOnlineLbl.Text = "System Online"
        ' 
        ' HeaderLbl
        ' 
        HeaderLbl.AutoSize = True
        HeaderLbl.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        HeaderLbl.Location = New Point(26, 16)
        HeaderLbl.Name = "HeaderLbl"
        HeaderLbl.Size = New Size(88, 18)
        HeaderLbl.TabIndex = 0
        HeaderLbl.Text = "My Profile"
        HeaderLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(4, 683)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(230, 65)
        Panel1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(161, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 15
        Label1.Text = "         "
        ' 
        ' Button2
        ' 
        Button2.AllowDrop = True
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(-9, 19)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(18, 0, 0, 0)
        Button2.Size = New Size(231, 39)
        Button2.TabIndex = 14
        Button2.Text = "           admin@gmail.com"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseCompatibleTextRendering = True
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SidePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(ContentPanel)
        Controls.Add(HeaderPanel)
        Controls.Add(MenuPanel)
        Name = "SidePanel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        MenuPanel.ResumeLayout(False)
        MenuPanel.PerformLayout()
        CType(SparxLogo, ComponentModel.ISupportInitialize).EndInit()
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents SparxLogo As PictureBox
    Friend WithEvents Line As Label
    Friend WithEvents HistoryButton As Button
    Friend WithEvents ProfileButton As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents Line2 As Label
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Line3 As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents SystemOnlineLbl As Label
    Friend WithEvents HeaderLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button

End Class
