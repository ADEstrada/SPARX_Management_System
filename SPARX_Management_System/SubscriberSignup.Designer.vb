<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubscriberSignup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlLoginCard = New PanelRound()
        line = New Label()
        LinkBtnLogin = New LinkLabel()
        logo = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        ButtonRounded3 = New ButtonRounded()
        Label3 = New Label()
        PanelRound4 = New PanelRound()
        TextBox4 = New TextBox()
        Label2 = New Label()
        PanelRound3 = New PanelRound()
        TextBox3 = New TextBox()
        Label1 = New Label()
        PanelRound2 = New PanelRound()
        PhoneNumber = New TextBox()
        PanelRound1 = New PanelRound()
        TextBox1 = New TextBox()
        LblHAA = New Label()
        LinkBtnSignup = New LinkLabel()
        LblDHA = New Label()
        lblEmail = New Label()
        ButtonRounded5 = New ButtonRounded()
        lblUserLevel = New Label()
        chkRemember = New CheckBox()
        lblPassword = New Label()
        pnlPassword = New PanelRound()
        txtPassword = New TextBox()
        pnlEmail = New PanelRound()
        txtEmail = New TextBox()
        pnlLoginCard.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound4.SuspendLayout()
        PanelRound3.SuspendLayout()
        PanelRound2.SuspendLayout()
        PanelRound1.SuspendLayout()
        pnlPassword.SuspendLayout()
        pnlEmail.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.AutoScroll = True
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.Controls.Add(line)
        pnlLoginCard.Controls.Add(LinkBtnLogin)
        pnlLoginCard.Controls.Add(logo)
        pnlLoginCard.Controls.Add(Label4)
        pnlLoginCard.Controls.Add(Label5)
        pnlLoginCard.Controls.Add(ButtonRounded3)
        pnlLoginCard.Controls.Add(Label3)
        pnlLoginCard.Controls.Add(PanelRound4)
        pnlLoginCard.Controls.Add(Label2)
        pnlLoginCard.Controls.Add(PanelRound3)
        pnlLoginCard.Controls.Add(Label1)
        pnlLoginCard.Controls.Add(PanelRound2)
        pnlLoginCard.Controls.Add(PanelRound1)
        pnlLoginCard.Controls.Add(LblHAA)
        pnlLoginCard.Controls.Add(LinkBtnSignup)
        pnlLoginCard.Controls.Add(LblDHA)
        pnlLoginCard.Controls.Add(lblEmail)
        pnlLoginCard.Controls.Add(ButtonRounded5)
        pnlLoginCard.Controls.Add(lblUserLevel)
        pnlLoginCard.Controls.Add(chkRemember)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(pnlPassword)
        pnlLoginCard.Controls.Add(pnlEmail)
        pnlLoginCard.Dock = DockStyle.Fill
        pnlLoginCard.Font = New Font("Verdana", 8.25F)
        pnlLoginCard.Location = New Point(0, 0)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(519, 715)
        pnlLoginCard.TabIndex = 26
        ' 
        ' line
        ' 
        line.Anchor = AnchorStyles.Bottom
        line.AutoSize = True
        line.ForeColor = SystemColors.ControlLight
        line.Location = New Point(3, 645)
        line.Name = "line"
        line.Size = New Size(497, 13)
        line.TabIndex = 37
        line.Text = "______________________________________________________________________"
        line.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' LinkBtnLogin
        ' 
        LinkBtnLogin.Anchor = AnchorStyles.Bottom
        LinkBtnLogin.AutoSize = True
        LinkBtnLogin.Font = New Font("Verdana", 11.0F)
        LinkBtnLogin.LinkBehavior = LinkBehavior.NeverUnderline
        LinkBtnLogin.Location = New Point(294, 661)
        LinkBtnLogin.Name = "LinkBtnLogin"
        LinkBtnLogin.Size = New Size(47, 18)
        LinkBtnLogin.TabIndex = 36
        LinkBtnLogin.TabStop = True
        LinkBtnLogin.Text = "Login"
        LinkBtnLogin.Visible = False
        ' 
        ' logo
        ' 
        logo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        logo.Image = My.Resources.Resources.SparxLogo2
        logo.Location = New Point(226, 35)
        logo.Name = "logo"
        logo.Size = New Size(93, 60)
        logo.SizeMode = PictureBoxSizeMode.Zoom
        logo.TabIndex = 34
        logo.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 11.0F)
        Label4.Location = New Point(138, 661)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 18)
        Label4.TabIndex = 32
        Label4.Text = "Have an account?"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 11.0F)
        Label5.Location = New Point(273, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 18)
        Label5.TabIndex = 31
        Label5.Text = "Last Name"
        ' 
        ' ButtonRounded3
        ' 
        ButtonRounded3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ButtonRounded3.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        ButtonRounded3.CornerRadius = 8
        ButtonRounded3.Cursor = Cursors.Hand
        ButtonRounded3.FlatAppearance.BorderSize = 0
        ButtonRounded3.FlatStyle = FlatStyle.Flat
        ButtonRounded3.Font = New Font("Segoe UI", 12.0F)
        ButtonRounded3.ForeColor = Color.White
        ButtonRounded3.Location = New Point(26, 600)
        ButtonRounded3.Name = "ButtonRounded3"
        ButtonRounded3.Size = New Size(472, 45)
        ButtonRounded3.TabIndex = 28
        ButtonRounded3.Text = "Sign Up"
        ButtonRounded3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 11.0F)
        Label3.Location = New Point(25, 480)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 18)
        Label3.TabIndex = 26
        Label3.Text = "Re-enter Password"
        ' 
        ' PanelRound4
        ' 
        PanelRound4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRound4.BackColor = Color.WhiteSmoke
        PanelRound4.Controls.Add(TextBox4)
        PanelRound4.CornerRadius = 8
        PanelRound4.Location = New Point(28, 500)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(471, 41)
        PanelRound4.TabIndex = 27
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Cursor = Cursors.Hand
        TextBox4.Font = New Font("Segoe UI", 12.0F)
        TextBox4.Location = New Point(5, 10)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(461, 22)
        TextBox4.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 11.0F)
        Label2.Location = New Point(25, 405)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 18)
        Label2.TabIndex = 16
        Label2.Text = "Password"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRound3.BackColor = Color.WhiteSmoke
        PanelRound3.Controls.Add(TextBox3)
        PanelRound3.CornerRadius = 8
        PanelRound3.Location = New Point(28, 425)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(471, 41)
        PanelRound3.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Cursor = Cursors.Hand
        TextBox3.Font = New Font("Segoe UI", 12.0F)
        TextBox3.Location = New Point(5, 10)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(461, 22)
        TextBox3.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 11.0F)
        Label1.Location = New Point(23, 330)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 18)
        Label1.TabIndex = 24
        Label1.Text = "Phone Number"
        ' 
        ' PanelRound2
        ' 
        PanelRound2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRound2.BackColor = Color.WhiteSmoke
        PanelRound2.Controls.Add(PhoneNumber)
        PanelRound2.CornerRadius = 8
        PanelRound2.Location = New Point(26, 350)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(471, 41)
        PanelRound2.TabIndex = 25
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PhoneNumber.BackColor = Color.WhiteSmoke
        PhoneNumber.BorderStyle = BorderStyle.None
        PhoneNumber.Cursor = Cursors.Hand
        PhoneNumber.Font = New Font("Segoe UI", 12.0F)
        PhoneNumber.Location = New Point(7, 10)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(461, 22)
        PhoneNumber.TabIndex = 12
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRound1.BackColor = Color.WhiteSmoke
        PanelRound1.Controls.Add(TextBox1)
        PanelRound1.CornerRadius = 8
        PanelRound1.Location = New Point(275, 203)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(224, 41)
        PanelRound1.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.CharacterCasing = CharacterCasing.Lower
        TextBox1.Cursor = Cursors.Hand
        TextBox1.Font = New Font("Segoe UI", 12.0F)
        TextBox1.Location = New Point(9, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 22)
        TextBox1.TabIndex = 11
        ' 
        ' LblHAA
        ' 
        LblHAA.Anchor = AnchorStyles.Bottom
        LblHAA.AutoSize = True
        LblHAA.Font = New Font("Verdana", 11.0F)
        LblHAA.Location = New Point(276, 1166)
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
        LinkBtnSignup.Font = New Font("Verdana", 11.0F)
        LinkBtnSignup.LinkBehavior = LinkBehavior.NeverUnderline
        LinkBtnSignup.Location = New Point(475, 1166)
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
        LblDHA.Font = New Font("Verdana", 11.0F)
        LblDHA.Location = New Point(288, 1166)
        LblDHA.Name = "LblDHA"
        LblDHA.Size = New Size(164, 18)
        LblDHA.TabIndex = 20
        LblDHA.Text = "Don't Have Account?"
        LblDHA.Visible = False
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Verdana", 11.0F)
        lblEmail.Location = New Point(23, 171)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(89, 18)
        lblEmail.TabIndex = 5
        lblEmail.Text = "First Name"
        ' 
        ' ButtonRounded5
        ' 
        ButtonRounded5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ButtonRounded5.BackColor = Color.Transparent
        ButtonRounded5.CornerRadius = 8
        ButtonRounded5.Cursor = Cursors.Hand
        ButtonRounded5.FlatAppearance.BorderSize = 0
        ButtonRounded5.FlatStyle = FlatStyle.Flat
        ButtonRounded5.Font = New Font("Segoe UI", 12.0F)
        ButtonRounded5.ForeColor = Color.MediumBlue
        ButtonRounded5.Location = New Point(274, 645)
        ButtonRounded5.Name = "ButtonRounded5"
        ButtonRounded5.Size = New Size(88, 48)
        ButtonRounded5.TabIndex = 35
        ButtonRounded5.Text = "Login"
        ButtonRounded5.UseVisualStyleBackColor = False
        ' 
        ' lblUserLevel
        ' 
        lblUserLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblUserLevel.Font = New Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        chkRemember.Font = New Font("Verdana", 11.0F)
        chkRemember.Location = New Point(26, 558)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(138, 22)
        chkRemember.TabIndex = 11
        chkRemember.Text = "Remember me"
        chkRemember.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Verdana", 11.0F)
        lblPassword.Location = New Point(23, 260)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(111, 18)
        lblPassword.TabIndex = 8
        lblPassword.Text = "Email Address"
        ' 
        ' pnlPassword
        ' 
        pnlPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPassword.BackColor = Color.WhiteSmoke
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.CornerRadius = 8
        pnlPassword.Location = New Point(26, 280)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(471, 41)
        pnlPassword.TabIndex = 15
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BackColor = Color.WhiteSmoke
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.Hand
        txtPassword.Font = New Font("Segoe UI", 12.0F)
        txtPassword.Location = New Point(7, 10)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(461, 22)
        txtPassword.TabIndex = 12
        ' 
        ' pnlEmail
        ' 
        pnlEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEmail.BackColor = Color.WhiteSmoke
        pnlEmail.Controls.Add(txtEmail)
        pnlEmail.CornerRadius = 8
        pnlEmail.Location = New Point(25, 203)
        pnlEmail.Name = "pnlEmail"
        pnlEmail.Size = New Size(224, 41)
        pnlEmail.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.BackColor = Color.WhiteSmoke
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.CharacterCasing = CharacterCasing.Lower
        txtEmail.Cursor = Cursors.Hand
        txtEmail.Font = New Font("Segoe UI", 12.0F)
        txtEmail.Location = New Point(8, 10)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(213, 22)
        txtEmail.TabIndex = 11
        ' 
        ' SubscriberSignup
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(pnlLoginCard)
        Name = "SubscriberSignup"
        Size = New Size(519, 715)
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        pnlEmail.ResumeLayout(False)
        pnlEmail.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLoginCard As PanelRound
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblHAA As Label
    Friend WithEvents LinkBtnSignup As LinkLabel
    Friend WithEvents LblDHA As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUserLevel As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents pnlPassword As PanelRound
    Friend WithEvents picShowHide As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlEmail As PanelRound
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PhoneNumber As TextBox
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ButtonRounded4 As ButtonRounded
    Friend WithEvents ButtonRounded2 As ButtonRounded
    Friend WithEvents ButtonRounded1 As ButtonRounded
    Friend WithEvents PanelRound5 As PanelRound
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ButtonRounded3 As ButtonRounded
    Friend WithEvents Label4 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents ButtonRounded5 As ButtonRounded
    Friend WithEvents LinkBtnLogin As LinkLabel
    Friend WithEvents line As Label

End Class
