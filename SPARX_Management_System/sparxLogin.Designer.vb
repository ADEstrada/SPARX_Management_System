﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sparxLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sparxLogin))
        SplitContainer1 = New SplitContainer()
        pnlWelcome = New PanelRound()
        lblWelcome = New Label()
        btnAdmin = New Label()
        btnSuperAdmin = New Label()
        btnSubscriber = New Label()
        sparxLogo = New PictureBox()
        pnlLoginCard = New PanelRound()
        LinkBtnLogin = New LinkLabel()
        LblHAA = New Label()
        LinkBtnSignup = New LinkLabel()
        LblDHA = New Label()
        logo = New PictureBox()
        lnkForgot = New LinkLabel()
        lblEmail = New Label()
        lblUserLevel = New Label()
        chkRemember = New CheckBox()
        btnSignup = New ButtonRounded()
        lblPassword = New Label()
        pnlPassword = New PanelRound()
        picShowHide = New PictureBox()
        txtPassword = New TextBox()
        line = New Label()
        lnkAdminContact = New LinkLabel()
        lblAccess = New Label()
        pnlEmail = New PanelRound()
        txtEmail = New TextBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        pnlWelcome.SuspendLayout()
        CType(sparxLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoginCard.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        pnlPassword.SuspendLayout()
        CType(picShowHide, ComponentModel.ISupportInitialize).BeginInit()
        pnlEmail.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackgroundImage = My.Resources.Resources.SparxBackground
        SplitContainer1.Panel1.Controls.Add(pnlWelcome)
        SplitContainer1.Panel1.ForeColor = Color.FromArgb(29, 41, 61)
        SplitContainer1.Panel1.RightToLeft = RightToLeft.No
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(btnAdmin)
        SplitContainer1.Panel2.Controls.Add(btnSuperAdmin)
        SplitContainer1.Panel2.Controls.Add(btnSubscriber)
        SplitContainer1.Panel2.Controls.Add(sparxLogo)
        SplitContainer1.Panel2.Controls.Add(pnlLoginCard)
        SplitContainer1.Size = New Size(1481, 796)
        SplitContainer1.SplitterDistance = 733
        SplitContainer1.TabIndex = 0
        ' 
        ' pnlWelcome
        ' 
        pnlWelcome.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWelcome.BackColor = Color.FromArgb(50, 128, 128, 128)
        pnlWelcome.Controls.Add(lblWelcome)
        pnlWelcome.Location = New Point(107, 211)
        pnlWelcome.Name = "pnlWelcome"
        pnlWelcome.Size = New Size(467, 322)
        pnlWelcome.TabIndex = 23
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Cursor = Cursors.Hand
        lblWelcome.Font = New Font("Verdana", 24F)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(85, 134)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(293, 38)
        lblWelcome.TabIndex = 31
        lblWelcome.Text = "WELCOME BACK!"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Anchor = AnchorStyles.Top
        btnAdmin.AutoSize = True
        btnAdmin.BackColor = Color.Transparent
        btnAdmin.Cursor = Cursors.Hand
        btnAdmin.Font = New Font("Verdana", 13F)
        btnAdmin.Location = New Point(308, 46)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(67, 22)
        btnAdmin.TabIndex = 29
        btnAdmin.Text = "Admin"
        ' 
        ' btnSuperAdmin
        ' 
        btnSuperAdmin.Anchor = AnchorStyles.Top
        btnSuperAdmin.AutoSize = True
        btnSuperAdmin.BackColor = Color.Transparent
        btnSuperAdmin.Cursor = Cursors.Hand
        btnSuperAdmin.Font = New Font("Verdana", 13F)
        btnSuperAdmin.Location = New Point(118, 46)
        btnSuperAdmin.Name = "btnSuperAdmin"
        btnSuperAdmin.Size = New Size(126, 22)
        btnSuperAdmin.TabIndex = 28
        btnSuperAdmin.Text = "Super Admin"
        ' 
        ' btnSubscriber
        ' 
        btnSubscriber.Anchor = AnchorStyles.Top
        btnSubscriber.AutoSize = True
        btnSubscriber.BackColor = Color.Transparent
        btnSubscriber.Cursor = Cursors.Hand
        btnSubscriber.Font = New Font("Verdana", 13F)
        btnSubscriber.Location = New Point(434, 46)
        btnSubscriber.Name = "btnSubscriber"
        btnSubscriber.Size = New Size(105, 22)
        btnSubscriber.TabIndex = 26
        btnSubscriber.Text = "Subscriber"
        ' 
        ' sparxLogo
        ' 
        sparxLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        sparxLogo.Image = CType(resources.GetObject("sparxLogo.Image"), Image)
        sparxLogo.Location = New Point(146, -389)
        sparxLogo.Name = "sparxLogo"
        sparxLogo.Size = New Size(216, 41)
        sparxLogo.SizeMode = PictureBoxSizeMode.Zoom
        sparxLogo.TabIndex = 0
        sparxLogo.TabStop = False
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.Controls.Add(LinkBtnLogin)
        pnlLoginCard.Controls.Add(LblHAA)
        pnlLoginCard.Controls.Add(LinkBtnSignup)
        pnlLoginCard.Controls.Add(LblDHA)
        pnlLoginCard.Controls.Add(logo)
        pnlLoginCard.Controls.Add(lnkForgot)
        pnlLoginCard.Controls.Add(lblEmail)
        pnlLoginCard.Controls.Add(lblUserLevel)
        pnlLoginCard.Controls.Add(chkRemember)
        pnlLoginCard.Controls.Add(btnSignup)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(pnlPassword)
        pnlLoginCard.Controls.Add(line)
        pnlLoginCard.Controls.Add(lnkAdminContact)
        pnlLoginCard.Controls.Add(lblAccess)
        pnlLoginCard.Controls.Add(pnlEmail)
        pnlLoginCard.Font = New Font("Verdana", 8.25F)
        pnlLoginCard.Location = New Point(95, 123)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(519, 588)
        pnlLoginCard.TabIndex = 25
        ' 
        ' LinkBtnLogin
        ' 
        LinkBtnLogin.Anchor = AnchorStyles.Bottom
        LinkBtnLogin.AutoSize = True
        LinkBtnLogin.Font = New Font("Verdana", 11F)
        LinkBtnLogin.LinkBehavior = LinkBehavior.NeverUnderline
        LinkBtnLogin.Location = New Point(316, 551)
        LinkBtnLogin.Name = "LinkBtnLogin"
        LinkBtnLogin.Size = New Size(47, 18)
        LinkBtnLogin.TabIndex = 23
        LinkBtnLogin.TabStop = True
        LinkBtnLogin.Text = "Login"
        LinkBtnLogin.Visible = False
        ' 
        ' LblHAA
        ' 
        LblHAA.Anchor = AnchorStyles.Bottom
        LblHAA.AutoSize = True
        LblHAA.Font = New Font("Verdana", 11F)
        LblHAA.Location = New Point(117, 551)
        LblHAA.Name = "LblHAA"
        LblHAA.Size = New Size(143, 18)
        LblHAA.TabIndex = 22
        LblHAA.Text = "Have An Account?"
        LblHAA.Visible = False
        ' 
        ' LinkBtnSignup
        ' 
        LinkBtnSignup.Anchor = AnchorStyles.Bottom
        LinkBtnSignup.AutoSize = True
        LinkBtnSignup.Font = New Font("Verdana", 11F)
        LinkBtnSignup.LinkBehavior = LinkBehavior.NeverUnderline
        LinkBtnSignup.Location = New Point(316, 551)
        LinkBtnSignup.Name = "LinkBtnSignup"
        LinkBtnSignup.Size = New Size(62, 18)
        LinkBtnSignup.TabIndex = 21
        LinkBtnSignup.TabStop = True
        LinkBtnSignup.Text = "Sign up"
        LinkBtnSignup.Visible = False
        ' 
        ' LblDHA
        ' 
        LblDHA.Anchor = AnchorStyles.Bottom
        LblDHA.AutoSize = True
        LblDHA.Font = New Font("Verdana", 11F)
        LblDHA.Location = New Point(129, 551)
        LblDHA.Name = "LblDHA"
        LblDHA.Size = New Size(164, 18)
        LblDHA.TabIndex = 20
        LblDHA.Text = "Don't Have Account?"
        LblDHA.Visible = False
        ' 
        ' logo
        ' 
        logo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        logo.Image = My.Resources.Resources.SparxLogo2
        logo.Location = New Point(226, 35)
        logo.Name = "logo"
        logo.Size = New Size(73, 50)
        logo.SizeMode = PictureBoxSizeMode.Zoom
        logo.TabIndex = 19
        logo.TabStop = False
        ' 
        ' lnkForgot
        ' 
        lnkForgot.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lnkForgot.AutoSize = True
        lnkForgot.Font = New Font("Verdana", 11F)
        lnkForgot.LinkBehavior = LinkBehavior.NeverUnderline
        lnkForgot.Location = New Point(355, 389)
        lnkForgot.Name = "lnkForgot"
        lnkForgot.Size = New Size(143, 18)
        lnkForgot.TabIndex = 12
        lnkForgot.TabStop = True
        lnkForgot.Text = "Forgot Password?"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Verdana", 11F)
        lblEmail.Location = New Point(23, 198)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(111, 18)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email Address"
        ' 
        ' lblUserLevel
        ' 
        lblUserLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblUserLevel.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        lblUserLevel.Location = New Point(3, 108)
        lblUserLevel.Name = "lblUserLevel"
        lblUserLevel.Size = New Size(513, 25)
        lblUserLevel.TabIndex = 1
        lblUserLevel.Text = "Super Admin Login"
        lblUserLevel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' chkRemember
        ' 
        chkRemember.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        chkRemember.AutoSize = True
        chkRemember.Font = New Font("Verdana", 11F)
        chkRemember.Location = New Point(26, 388)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(138, 22)
        chkRemember.TabIndex = 11
        chkRemember.Text = "Remember me"
        chkRemember.UseVisualStyleBackColor = True
        ' 
        ' btnSignup
        ' 
        btnSignup.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnSignup.BackColor = Color.FromArgb(70, 130, 255)
        btnSignup.CornerRadius = 8
        btnSignup.Cursor = Cursors.Hand
        btnSignup.FlatAppearance.BorderSize = 0
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Segoe UI", 12F)
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(26, 468)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(472, 45)
        btnSignup.TabIndex = 13
        btnSignup.Text = "Sign in"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Verdana", 11F)
        lblPassword.Location = New Point(23, 296)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(80, 18)
        lblPassword.TabIndex = 8
        lblPassword.Text = "Password"
        ' 
        ' pnlPassword
        ' 
        pnlPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPassword.BackColor = Color.WhiteSmoke
        pnlPassword.Controls.Add(picShowHide)
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.CornerRadius = 8
        pnlPassword.Location = New Point(26, 316)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(472, 41)
        pnlPassword.TabIndex = 15
        ' 
        ' picShowHide
        ' 
        picShowHide.Anchor = AnchorStyles.Right
        picShowHide.Cursor = Cursors.Hand
        picShowHide.Image = My.Resources.Resources.eye_slashed
        picShowHide.Location = New Point(440, 7)
        picShowHide.Name = "picShowHide"
        picShowHide.Size = New Size(25, 25)
        picShowHide.SizeMode = PictureBoxSizeMode.Zoom
        picShowHide.TabIndex = 19
        picShowHide.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BackColor = Color.WhiteSmoke
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.Hand
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.Location = New Point(5, 10)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(429, 22)
        txtPassword.TabIndex = 12
        ' 
        ' line
        ' 
        line.Anchor = AnchorStyles.Bottom
        line.AutoSize = True
        line.ForeColor = SystemColors.ControlLight
        line.Location = New Point(11, 519)
        line.Name = "line"
        line.Size = New Size(497, 13)
        line.TabIndex = 16
        line.Text = "______________________________________________________________________"
        line.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lnkAdminContact
        ' 
        lnkAdminContact.Anchor = AnchorStyles.Bottom
        lnkAdminContact.AutoSize = True
        lnkAdminContact.Font = New Font("Verdana", 11F)
        lnkAdminContact.LinkBehavior = LinkBehavior.NeverUnderline
        lnkAdminContact.Location = New Point(235, 551)
        lnkAdminContact.Name = "lnkAdminContact"
        lnkAdminContact.Size = New Size(172, 18)
        lnkAdminContact.TabIndex = 18
        lnkAdminContact.TabStop = True
        lnkAdminContact.Text = "Contact Administrator"
        ' 
        ' lblAccess
        ' 
        lblAccess.Anchor = AnchorStyles.Bottom
        lblAccess.AutoSize = True
        lblAccess.Font = New Font("Verdana", 11F)
        lblAccess.Location = New Point(117, 551)
        lblAccess.Name = "lblAccess"
        lblAccess.Size = New Size(110, 18)
        lblAccess.TabIndex = 17
        lblAccess.Text = "Need Access?"
        ' 
        ' pnlEmail
        ' 
        pnlEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEmail.BackColor = Color.WhiteSmoke
        pnlEmail.Controls.Add(txtEmail)
        pnlEmail.CornerRadius = 8
        pnlEmail.Location = New Point(23, 219)
        pnlEmail.Name = "pnlEmail"
        pnlEmail.Size = New Size(475, 41)
        pnlEmail.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.BackColor = Color.WhiteSmoke
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.CharacterCasing = CharacterCasing.Lower
        txtEmail.Cursor = Cursors.Hand
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(8, 10)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(460, 22)
        txtEmail.TabIndex = 11
        ' 
        ' sparxLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1481, 796)
        Controls.Add(SplitContainer1)
        Name = "sparxLogin"
        StartPosition = FormStartPosition.CenterScreen
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        pnlWelcome.ResumeLayout(False)
        pnlWelcome.PerformLayout()
        CType(sparxLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        CType(picShowHide, ComponentModel.ISupportInitialize).EndInit()
        pnlEmail.ResumeLayout(False)
        pnlEmail.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlWelcomeCard As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnSubscriber As Label
    Friend WithEvents pnlWelcome As PanelRound
    Friend WithEvents pnlLoginCard As PanelRound
    Friend WithEvents lnkAdminContact As LinkLabel
    Friend WithEvents lblAccess As Label
    Friend WithEvents pnlPassword As PanelRound
    Friend WithEvents picShowHide As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlEmail As PanelRound
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSignup As ButtonRounded
    Friend WithEvents lnkForgot As LinkLabel
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents lblUserLevel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents sparxLogo As PictureBox
    Friend WithEvents btnAdmin As Label
    Friend WithEvents btnSuperAdmin As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents line As Label
    Friend WithEvents LinkBtnSignup As LinkLabel
    Friend WithEvents LblDHA As Label
    Friend WithEvents LblHAA As Label
    Friend WithEvents LinkBtnLogin As LinkLabel

End Class
