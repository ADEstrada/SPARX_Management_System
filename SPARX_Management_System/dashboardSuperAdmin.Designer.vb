<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardSuperAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboardSuperAdmin))
        pnlHeader = New Panel()
        PictureBox1 = New PictureBox()
        pnlSystemOnline = New PanelRound()
        systemOnline = New Label()
        btnNotification = New PictureBox()
        overview = New Label()
        lblDashboardSuperAdmin = New Label()
        pnlMenu = New Panel()
        PlansBtn = New Button()
        HistoryBtn = New Button()
        NetworkMapBtn = New Button()
        BillingBtn = New Button()
        SubscriberBtn = New Button()
        PayrollBtn = New Button()
        InventoryBtn = New Button()
        ServiceBtn = New Button()
        InstallationBtn = New Button()
        SalesBtn = New Button()
        DashboardBtn = New Button()
        line = New Label()
        PictureBox2 = New PictureBox()
        PanelRound2 = New PanelRound()
        LblPendingServices = New Label()
        PanelRound1 = New PanelRound()
        LblActiveInstallation = New Label()
        PanelRound3 = New PanelRound()
        LblMothlyRev = New Label()
        PanelRound4 = New PanelRound()
        LblTotalSubs = New Label()
        Mainexchange = New Panel()
        pnlHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSystemOnline.SuspendLayout()
        CType(btnNotification, ComponentModel.ISupportInitialize).BeginInit()
        pnlMenu.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound2.SuspendLayout()
        PanelRound1.SuspendLayout()
        PanelRound3.SuspendLayout()
        PanelRound4.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(PictureBox1)
        pnlHeader.Controls.Add(pnlSystemOnline)
        pnlHeader.Controls.Add(btnNotification)
        pnlHeader.Controls.Add(overview)
        pnlHeader.Controls.Add(lblDashboardSuperAdmin)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(240, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1222, 67)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.notificationBell
        PictureBox1.Location = New Point(1209, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' pnlSystemOnline
        ' 
        pnlSystemOnline.BackColor = Color.WhiteSmoke
        pnlSystemOnline.Controls.Add(systemOnline)
        pnlSystemOnline.CornerRadius = 8
        pnlSystemOnline.Location = New Point(1063, 16)
        pnlSystemOnline.Name = "pnlSystemOnline"
        pnlSystemOnline.Size = New Size(125, 35)
        pnlSystemOnline.TabIndex = 2
        ' 
        ' systemOnline
        ' 
        systemOnline.AutoSize = True
        systemOnline.Font = New Font("Verdana", 9.0F)
        systemOnline.Location = New Point(26, 10)
        systemOnline.Name = "systemOnline"
        systemOnline.Size = New Size(97, 14)
        systemOnline.TabIndex = 0
        systemOnline.Text = "System Online"
        ' 
        ' btnNotification
        ' 
        btnNotification.Image = CType(resources.GetObject("btnNotification.Image"), Image)
        btnNotification.Location = New Point(1469, 15)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(24, 24)
        btnNotification.TabIndex = 3
        btnNotification.TabStop = False
        ' 
        ' overview
        ' 
        overview.AutoSize = True
        overview.ForeColor = SystemColors.ControlDarkDark
        overview.Location = New Point(26, 36)
        overview.Name = "overview"
        overview.Size = New Size(216, 15)
        overview.TabIndex = 2
        overview.Text = "Overview of Sparx Fiber Internet System"
        ' 
        ' lblDashboardSuperAdmin
        ' 
        lblDashboardSuperAdmin.AutoSize = True
        lblDashboardSuperAdmin.Font = New Font("Verdana", 12.0F)
        lblDashboardSuperAdmin.Location = New Point(26, 16)
        lblDashboardSuperAdmin.Name = "lblDashboardSuperAdmin"
        lblDashboardSuperAdmin.Size = New Size(95, 18)
        lblDashboardSuperAdmin.TabIndex = 0
        lblDashboardSuperAdmin.Text = "Dashboard"
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        pnlMenu.Controls.Add(PlansBtn)
        pnlMenu.Controls.Add(pnlHeader)
        pnlMenu.Controls.Add(HistoryBtn)
        pnlMenu.Controls.Add(NetworkMapBtn)
        pnlMenu.Controls.Add(BillingBtn)
        pnlMenu.Controls.Add(SubscriberBtn)
        pnlMenu.Controls.Add(PayrollBtn)
        pnlMenu.Controls.Add(InventoryBtn)
        pnlMenu.Controls.Add(ServiceBtn)
        pnlMenu.Controls.Add(InstallationBtn)
        pnlMenu.Controls.Add(SalesBtn)
        pnlMenu.Controls.Add(DashboardBtn)
        pnlMenu.Controls.Add(line)
        pnlMenu.Controls.Add(PictureBox2)
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Location = New Point(0, 0)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(240, 603)
        pnlMenu.TabIndex = 1
        ' 
        ' PlansBtn
        ' 
        PlansBtn.AllowDrop = True
        PlansBtn.FlatAppearance.BorderSize = 0
        PlansBtn.FlatStyle = FlatStyle.Flat
        PlansBtn.ForeColor = Color.Transparent
        PlansBtn.Image = My.Resources.Resources.plan
        PlansBtn.ImageAlign = ContentAlignment.MiddleLeft
        PlansBtn.Location = New Point(0, 514)
        PlansBtn.Margin = New Padding(3, 2, 3, 2)
        PlansBtn.Name = "PlansBtn"
        PlansBtn.Padding = New Padding(18, 0, 0, 0)
        PlansBtn.Size = New Size(240, 39)
        PlansBtn.TabIndex = 13
        PlansBtn.Text = "           Plans"
        PlansBtn.TextAlign = ContentAlignment.MiddleLeft
        PlansBtn.UseCompatibleTextRendering = True
        PlansBtn.UseVisualStyleBackColor = True
        ' 
        ' HistoryBtn
        ' 
        HistoryBtn.AllowDrop = True
        HistoryBtn.FlatAppearance.BorderSize = 0
        HistoryBtn.FlatStyle = FlatStyle.Flat
        HistoryBtn.ForeColor = Color.Transparent
        HistoryBtn.Image = My.Resources.Resources.history
        HistoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        HistoryBtn.Location = New Point(-3, 471)
        HistoryBtn.Margin = New Padding(3, 2, 3, 2)
        HistoryBtn.Name = "HistoryBtn"
        HistoryBtn.Padding = New Padding(18, 0, 0, 0)
        HistoryBtn.Size = New Size(240, 39)
        HistoryBtn.TabIndex = 12
        HistoryBtn.Text = "           History"
        HistoryBtn.TextAlign = ContentAlignment.MiddleLeft
        HistoryBtn.UseCompatibleTextRendering = True
        HistoryBtn.UseVisualStyleBackColor = True
        ' 
        ' NetworkMapBtn
        ' 
        NetworkMapBtn.AllowDrop = True
        NetworkMapBtn.FlatAppearance.BorderSize = 0
        NetworkMapBtn.FlatStyle = FlatStyle.Flat
        NetworkMapBtn.ForeColor = Color.Transparent
        NetworkMapBtn.Image = My.Resources.Resources.networkMap
        NetworkMapBtn.ImageAlign = ContentAlignment.MiddleLeft
        NetworkMapBtn.Location = New Point(0, 428)
        NetworkMapBtn.Margin = New Padding(3, 2, 3, 2)
        NetworkMapBtn.Name = "NetworkMapBtn"
        NetworkMapBtn.Padding = New Padding(18, 0, 0, 0)
        NetworkMapBtn.Size = New Size(240, 39)
        NetworkMapBtn.TabIndex = 11
        NetworkMapBtn.Text = "           NetworkMap"
        NetworkMapBtn.TextAlign = ContentAlignment.MiddleLeft
        NetworkMapBtn.UseCompatibleTextRendering = True
        NetworkMapBtn.UseVisualStyleBackColor = True
        ' 
        ' BillingBtn
        ' 
        BillingBtn.AllowDrop = True
        BillingBtn.FlatAppearance.BorderSize = 0
        BillingBtn.FlatStyle = FlatStyle.Flat
        BillingBtn.ForeColor = Color.Transparent
        BillingBtn.Image = My.Resources.Resources.billing
        BillingBtn.ImageAlign = ContentAlignment.MiddleLeft
        BillingBtn.Location = New Point(0, 384)
        BillingBtn.Margin = New Padding(3, 2, 3, 2)
        BillingBtn.Name = "BillingBtn"
        BillingBtn.Padding = New Padding(18, 0, 0, 0)
        BillingBtn.Size = New Size(240, 39)
        BillingBtn.TabIndex = 10
        BillingBtn.Text = "           Billing"
        BillingBtn.TextAlign = ContentAlignment.MiddleLeft
        BillingBtn.UseCompatibleTextRendering = True
        BillingBtn.UseVisualStyleBackColor = True
        ' 
        ' SubscriberBtn
        ' 
        SubscriberBtn.AllowDrop = True
        SubscriberBtn.FlatAppearance.BorderSize = 0
        SubscriberBtn.FlatStyle = FlatStyle.Flat
        SubscriberBtn.ForeColor = Color.Transparent
        SubscriberBtn.Image = My.Resources.Resources.subscriber
        SubscriberBtn.ImageAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.Location = New Point(0, 340)
        SubscriberBtn.Margin = New Padding(3, 2, 3, 2)
        SubscriberBtn.Name = "SubscriberBtn"
        SubscriberBtn.Padding = New Padding(18, 0, 0, 0)
        SubscriberBtn.Size = New Size(240, 39)
        SubscriberBtn.TabIndex = 9
        SubscriberBtn.Text = "           Subscriber"
        SubscriberBtn.TextAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.UseCompatibleTextRendering = True
        SubscriberBtn.UseVisualStyleBackColor = True
        ' 
        ' PayrollBtn
        ' 
        PayrollBtn.AllowDrop = True
        PayrollBtn.FlatAppearance.BorderSize = 0
        PayrollBtn.FlatStyle = FlatStyle.Flat
        PayrollBtn.ForeColor = Color.Transparent
        PayrollBtn.Image = My.Resources.Resources.payroll
        PayrollBtn.ImageAlign = ContentAlignment.MiddleLeft
        PayrollBtn.Location = New Point(0, 290)
        PayrollBtn.Margin = New Padding(3, 2, 3, 2)
        PayrollBtn.Name = "PayrollBtn"
        PayrollBtn.Padding = New Padding(18, 0, 0, 0)
        PayrollBtn.Size = New Size(240, 39)
        PayrollBtn.TabIndex = 8
        PayrollBtn.Text = "           Payroll"
        PayrollBtn.TextAlign = ContentAlignment.MiddleLeft
        PayrollBtn.UseCompatibleTextRendering = True
        PayrollBtn.UseVisualStyleBackColor = True
        ' 
        ' InventoryBtn
        ' 
        InventoryBtn.AllowDrop = True
        InventoryBtn.FlatAppearance.BorderSize = 0
        InventoryBtn.FlatStyle = FlatStyle.Flat
        InventoryBtn.ForeColor = Color.Transparent
        InventoryBtn.Image = My.Resources.Resources.inventory
        InventoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        InventoryBtn.Location = New Point(0, 246)
        InventoryBtn.Margin = New Padding(3, 2, 3, 2)
        InventoryBtn.Name = "InventoryBtn"
        InventoryBtn.Padding = New Padding(18, 0, 0, 0)
        InventoryBtn.Size = New Size(240, 39)
        InventoryBtn.TabIndex = 7
        InventoryBtn.Text = "           Inventory"
        InventoryBtn.TextAlign = ContentAlignment.MiddleLeft
        InventoryBtn.UseCompatibleTextRendering = True
        InventoryBtn.UseVisualStyleBackColor = True
        ' 
        ' ServiceBtn
        ' 
        ServiceBtn.AllowDrop = True
        ServiceBtn.FlatAppearance.BorderSize = 0
        ServiceBtn.FlatStyle = FlatStyle.Flat
        ServiceBtn.ForeColor = Color.Transparent
        ServiceBtn.Image = My.Resources.Resources.service
        ServiceBtn.ImageAlign = ContentAlignment.MiddleLeft
        ServiceBtn.Location = New Point(0, 202)
        ServiceBtn.Margin = New Padding(3, 2, 3, 2)
        ServiceBtn.Name = "ServiceBtn"
        ServiceBtn.Padding = New Padding(18, 0, 0, 0)
        ServiceBtn.Size = New Size(240, 39)
        ServiceBtn.TabIndex = 6
        ServiceBtn.Text = "           Service"
        ServiceBtn.TextAlign = ContentAlignment.MiddleLeft
        ServiceBtn.UseCompatibleTextRendering = True
        ServiceBtn.UseVisualStyleBackColor = True
        ' 
        ' InstallationBtn
        ' 
        InstallationBtn.AllowDrop = True
        InstallationBtn.FlatAppearance.BorderSize = 0
        InstallationBtn.FlatStyle = FlatStyle.Flat
        InstallationBtn.ForeColor = Color.Transparent
        InstallationBtn.Image = My.Resources.Resources.installation
        InstallationBtn.ImageAlign = ContentAlignment.MiddleLeft
        InstallationBtn.Location = New Point(0, 159)
        InstallationBtn.Margin = New Padding(3, 2, 3, 2)
        InstallationBtn.Name = "InstallationBtn"
        InstallationBtn.Padding = New Padding(18, 0, 0, 0)
        InstallationBtn.Size = New Size(240, 39)
        InstallationBtn.TabIndex = 5
        InstallationBtn.Text = "           Installation"
        InstallationBtn.TextAlign = ContentAlignment.MiddleLeft
        InstallationBtn.UseCompatibleTextRendering = True
        InstallationBtn.UseVisualStyleBackColor = True
        ' 
        ' SalesBtn
        ' 
        SalesBtn.FlatAppearance.BorderSize = 0
        SalesBtn.FlatStyle = FlatStyle.Flat
        SalesBtn.ForeColor = Color.Transparent
        SalesBtn.Image = My.Resources.Resources.sales
        SalesBtn.ImageAlign = ContentAlignment.MiddleLeft
        SalesBtn.Location = New Point(0, 116)
        SalesBtn.Margin = New Padding(3, 2, 3, 2)
        SalesBtn.Name = "SalesBtn"
        SalesBtn.Padding = New Padding(18, 0, 0, 0)
        SalesBtn.Size = New Size(240, 39)
        SalesBtn.TabIndex = 4
        SalesBtn.Text = "           Sales"
        SalesBtn.TextAlign = ContentAlignment.MiddleLeft
        SalesBtn.UseVisualStyleBackColor = True
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.ForeColor = Color.Transparent
        DashboardBtn.Image = My.Resources.Resources.dashboard
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(0, 72)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(18, 0, 0, 0)
        DashboardBtn.Size = New Size(240, 39)
        DashboardBtn.TabIndex = 3
        DashboardBtn.Text = "           Dashboard"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' line
        ' 
        line.AutoSize = True
        line.BackColor = Color.Transparent
        line.ForeColor = Color.FromArgb(CByte(42), CByte(53), CByte(72))
        line.Location = New Point(-3, 59)
        line.Name = "line"
        line.Size = New Size(247, 15)
        line.TabIndex = 2
        line.Text = "________________________________________________"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.SparxFiber
        PictureBox2.Location = New Point(41, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 55)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PanelRound2
        ' 
        PanelRound2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PanelRound2.BackColor = Color.White
        PanelRound2.Controls.Add(LblPendingServices)
        PanelRound2.Location = New Point(1162, 92)
        PanelRound2.Margin = New Padding(3, 2, 3, 2)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(267, 130)
        PanelRound2.TabIndex = 5
        ' 
        ' LblPendingServices
        ' 
        LblPendingServices.AutoSize = True
        LblPendingServices.Location = New Point(32, 16)
        LblPendingServices.Name = "LblPendingServices"
        LblPendingServices.Size = New Size(96, 15)
        LblPendingServices.TabIndex = 3
        LblPendingServices.Text = "Pending Services"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(LblActiveInstallation)
        PanelRound1.Location = New Point(865, 92)
        PanelRound1.Margin = New Padding(3, 2, 3, 2)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(267, 130)
        PanelRound1.TabIndex = 6
        ' 
        ' LblActiveInstallation
        ' 
        LblActiveInstallation.AutoSize = True
        LblActiveInstallation.Location = New Point(22, 16)
        LblActiveInstallation.Name = "LblActiveInstallation"
        LblActiveInstallation.Size = New Size(106, 15)
        LblActiveInstallation.TabIndex = 2
        LblActiveInstallation.Text = "Active Installations"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.White
        PanelRound3.Controls.Add(LblMothlyRev)
        PanelRound3.Location = New Point(594, 92)
        PanelRound3.Margin = New Padding(3, 2, 3, 2)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(267, 130)
        PanelRound3.TabIndex = 7
        ' 
        ' LblMothlyRev
        ' 
        LblMothlyRev.AutoSize = True
        LblMothlyRev.Location = New Point(20, 16)
        LblMothlyRev.Name = "LblMothlyRev"
        LblMothlyRev.Size = New Size(100, 15)
        LblMothlyRev.TabIndex = 1
        LblMothlyRev.Text = "Monthly Revenue"
        ' 
        ' PanelRound4
        ' 
        PanelRound4.BackColor = Color.White
        PanelRound4.Controls.Add(LblTotalSubs)
        PanelRound4.Location = New Point(294, 92)
        PanelRound4.Margin = New Padding(3, 2, 3, 2)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(267, 130)
        PanelRound4.TabIndex = 8
        ' 
        ' LblTotalSubs
        ' 
        LblTotalSubs.AutoSize = True
        LblTotalSubs.Location = New Point(23, 16)
        LblTotalSubs.Name = "LblTotalSubs"
        LblTotalSubs.Size = New Size(95, 15)
        LblTotalSubs.TabIndex = 0
        LblTotalSubs.Text = "Total Subscribers"
        ' 
        ' Mainexchange
        ' 
        Mainexchange.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Mainexchange.Location = New Point(240, 67)
        Mainexchange.Name = "Mainexchange"
        Mainexchange.Size = New Size(1219, 536)
        Mainexchange.TabIndex = 9
        ' 
        ' dashboardSuperAdmin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1462, 603)
        Controls.Add(pnlMenu)
        Controls.Add(PanelRound4)
        Controls.Add(PanelRound3)
        Controls.Add(PanelRound1)
        Controls.Add(PanelRound2)
        Controls.Add(Mainexchange)
        Controls.Add(pnlHeader)
        Name = "dashboardSuperAdmin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashbordSuperAdmin"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlSystemOnline.ResumeLayout(False)
        pnlSystemOnline.PerformLayout()
        CType(btnNotification, ComponentModel.ISupportInitialize).EndInit()
        pnlMenu.ResumeLayout(False)
        pnlMenu.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblDashboardSuperAdmin As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents overview As Label
    Friend WithEvents btnNotification As PictureBox
    Friend WithEvents pnlSystemOnline As PanelRound
    Friend WithEvents systemOnline As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents line As Label
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents ServiceBtn As Button
    Friend WithEvents InstallationBtn As Button
    Friend WithEvents PayrollBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents PlansBtn As Button
    Friend WithEvents HistoryBtn As Button
    Friend WithEvents NetworkMapBtn As Button
    Friend WithEvents BillingBtn As Button
    Friend WithEvents SubscriberBtn As Button
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents LblPendingServices As Label
    Friend WithEvents LblActiveInstallation As Label
    Friend WithEvents LblMothlyRev As Label
    Friend WithEvents LblTotalSubs As Label
    Friend WithEvents Mainexchange As Panel
End Class
