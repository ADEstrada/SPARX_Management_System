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
        ServiceBtn = New Button()
        InventoryBtn = New Button()
        InstallationBtn = New Button()
        SalesBtn = New Button()
        DashboardBtn = New Button()
        line = New Label()
        PictureBox2 = New PictureBox()
        pnlHeader.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSystemOnline.SuspendLayout()
        CType(btnNotification, ComponentModel.ISupportInitialize).BeginInit()
        pnlMenu.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Location = New Point(271, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1454, 89)
        pnlHeader.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.notificationBell
        PictureBox1.Location = New Point(1382, 29)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 32)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' pnlSystemOnline
        ' 
        pnlSystemOnline.BackColor = Color.WhiteSmoke
        pnlSystemOnline.Controls.Add(systemOnline)
        pnlSystemOnline.CornerRadius = 8
        pnlSystemOnline.Location = New Point(1215, 21)
        pnlSystemOnline.Margin = New Padding(3, 4, 3, 4)
        pnlSystemOnline.Name = "pnlSystemOnline"
        pnlSystemOnline.Size = New Size(143, 47)
        pnlSystemOnline.TabIndex = 2
        ' 
        ' systemOnline
        ' 
        systemOnline.AutoSize = True
        systemOnline.Font = New Font("Verdana", 9.0F)
        systemOnline.Location = New Point(30, 13)
        systemOnline.Name = "systemOnline"
        systemOnline.Size = New Size(115, 18)
        systemOnline.TabIndex = 0
        systemOnline.Text = "System Online"
        ' 
        ' btnNotification
        ' 
        btnNotification.Image = CType(resources.GetObject("btnNotification.Image"), Image)
        btnNotification.Location = New Point(1679, 20)
        btnNotification.Margin = New Padding(3, 4, 3, 4)
        btnNotification.Name = "btnNotification"
        btnNotification.Size = New Size(27, 32)
        btnNotification.TabIndex = 3
        btnNotification.TabStop = False
        ' 
        ' overview
        ' 
        overview.AutoSize = True
        overview.ForeColor = SystemColors.ControlDarkDark
        overview.Location = New Point(30, 48)
        overview.Name = "overview"
        overview.Size = New Size(272, 20)
        overview.TabIndex = 2
        overview.Text = "Overview of Sparx Fiber Internet System"
        ' 
        ' lblDashboardSuperAdmin
        ' 
        lblDashboardSuperAdmin.AutoSize = True
        lblDashboardSuperAdmin.Font = New Font("Verdana", 12.0F)
        lblDashboardSuperAdmin.Location = New Point(30, 21)
        lblDashboardSuperAdmin.Name = "lblDashboardSuperAdmin"
        lblDashboardSuperAdmin.Size = New Size(119, 25)
        lblDashboardSuperAdmin.TabIndex = 0
        lblDashboardSuperAdmin.Text = "Dashboard"
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        pnlMenu.Controls.Add(PlansBtn)
        pnlMenu.Controls.Add(HistoryBtn)
        pnlMenu.Controls.Add(NetworkMapBtn)
        pnlMenu.Controls.Add(BillingBtn)
        pnlMenu.Controls.Add(SubscriberBtn)
        pnlMenu.Controls.Add(PayrollBtn)
        pnlMenu.Controls.Add(ServiceBtn)
        pnlMenu.Controls.Add(InventoryBtn)
        pnlMenu.Controls.Add(InstallationBtn)
        pnlMenu.Controls.Add(SalesBtn)
        pnlMenu.Controls.Add(DashboardBtn)
        pnlMenu.Controls.Add(line)
        pnlMenu.Controls.Add(PictureBox2)
        pnlMenu.Location = New Point(0, 0)
        pnlMenu.Margin = New Padding(3, 4, 3, 4)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(274, 961)
        pnlMenu.TabIndex = 1
        ' 
        ' PlansBtn
        ' 
        PlansBtn.FlatAppearance.BorderSize = 0
        PlansBtn.FlatStyle = FlatStyle.Flat
        PlansBtn.ForeColor = Color.Transparent
        PlansBtn.ImageAlign = ContentAlignment.MiddleLeft
        PlansBtn.Location = New Point(0, 648)
        PlansBtn.Name = "PlansBtn"
        PlansBtn.Size = New Size(271, 49)
        PlansBtn.TabIndex = 13
        PlansBtn.Text = "          Plans"
        PlansBtn.TextAlign = ContentAlignment.MiddleLeft
        PlansBtn.UseVisualStyleBackColor = True
        ' 
        ' HistoryBtn
        ' 
        HistoryBtn.FlatAppearance.BorderSize = 0
        HistoryBtn.FlatStyle = FlatStyle.Flat
        HistoryBtn.ForeColor = Color.Transparent
        HistoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        HistoryBtn.Location = New Point(0, 593)
        HistoryBtn.Name = "HistoryBtn"
        HistoryBtn.Size = New Size(271, 49)
        HistoryBtn.TabIndex = 12
        HistoryBtn.Text = "          History "
        HistoryBtn.TextAlign = ContentAlignment.MiddleLeft
        HistoryBtn.UseVisualStyleBackColor = True
        ' 
        ' NetworkMapBtn
        ' 
        NetworkMapBtn.FlatAppearance.BorderSize = 0
        NetworkMapBtn.FlatStyle = FlatStyle.Flat
        NetworkMapBtn.ForeColor = Color.Transparent
        NetworkMapBtn.ImageAlign = ContentAlignment.MiddleLeft
        NetworkMapBtn.Location = New Point(0, 550)
        NetworkMapBtn.Name = "NetworkMapBtn"
        NetworkMapBtn.Size = New Size(271, 49)
        NetworkMapBtn.TabIndex = 11
        NetworkMapBtn.Text = "          Network Map"
        NetworkMapBtn.TextAlign = ContentAlignment.MiddleLeft
        NetworkMapBtn.UseVisualStyleBackColor = True
        ' 
        ' BillingBtn
        ' 
        BillingBtn.FlatAppearance.BorderSize = 0
        BillingBtn.FlatStyle = FlatStyle.Flat
        BillingBtn.ForeColor = Color.Transparent
        BillingBtn.ImageAlign = ContentAlignment.MiddleLeft
        BillingBtn.Location = New Point(0, 440)
        BillingBtn.Name = "BillingBtn"
        BillingBtn.Size = New Size(271, 49)
        BillingBtn.TabIndex = 10
        BillingBtn.Text = "          Billing"
        BillingBtn.TextAlign = ContentAlignment.MiddleLeft
        BillingBtn.UseVisualStyleBackColor = True
        ' 
        ' SubscriberBtn
        ' 
        SubscriberBtn.FlatAppearance.BorderSize = 0
        SubscriberBtn.FlatStyle = FlatStyle.Flat
        SubscriberBtn.ForeColor = Color.Transparent
        SubscriberBtn.ImageAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.Location = New Point(0, 495)
        SubscriberBtn.Name = "SubscriberBtn"
        SubscriberBtn.Size = New Size(271, 49)
        SubscriberBtn.TabIndex = 9
        SubscriberBtn.Text = "          Subscriber"
        SubscriberBtn.TextAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.UseVisualStyleBackColor = True
        ' 
        ' PayrollBtn
        ' 
        PayrollBtn.FlatAppearance.BorderSize = 0
        PayrollBtn.FlatStyle = FlatStyle.Flat
        PayrollBtn.ForeColor = Color.Transparent
        PayrollBtn.ImageAlign = ContentAlignment.MiddleLeft
        PayrollBtn.Location = New Point(0, 373)
        PayrollBtn.Name = "PayrollBtn"
        PayrollBtn.Size = New Size(274, 49)
        PayrollBtn.TabIndex = 8
        PayrollBtn.Text = "          Payroll"
        PayrollBtn.TextAlign = ContentAlignment.MiddleLeft
        PayrollBtn.UseVisualStyleBackColor = True
        ' 
        ' ServiceBtn
        ' 
        ServiceBtn.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        ServiceBtn.FlatAppearance.BorderSize = 0
        ServiceBtn.FlatStyle = FlatStyle.Flat
        ServiceBtn.ForeColor = Color.Transparent
        ServiceBtn.ImageAlign = ContentAlignment.MiddleLeft
        ServiceBtn.Location = New Point(0, 263)
        ServiceBtn.Name = "ServiceBtn"
        ServiceBtn.Size = New Size(274, 49)
        ServiceBtn.TabIndex = 7
        ServiceBtn.Text = "           Service"
        ServiceBtn.TextAlign = ContentAlignment.MiddleLeft
        ServiceBtn.UseVisualStyleBackColor = False
        ' 
        ' InventoryBtn
        ' 
        InventoryBtn.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        InventoryBtn.FlatAppearance.BorderSize = 0
        InventoryBtn.FlatStyle = FlatStyle.Flat
        InventoryBtn.ForeColor = Color.Transparent
        InventoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        InventoryBtn.Location = New Point(0, 318)
        InventoryBtn.Name = "InventoryBtn"
        InventoryBtn.Size = New Size(274, 49)
        InventoryBtn.TabIndex = 6
        InventoryBtn.Text = "          Inventory"
        InventoryBtn.TextAlign = ContentAlignment.MiddleLeft
        InventoryBtn.UseVisualStyleBackColor = False
        ' 
        ' InstallationBtn
        ' 
        InstallationBtn.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        InstallationBtn.FlatAppearance.BorderSize = 0
        InstallationBtn.FlatStyle = FlatStyle.Flat
        InstallationBtn.Font = New Font("Segoe UI", 9.0F)
        InstallationBtn.ForeColor = Color.Transparent
        InstallationBtn.ImageAlign = ContentAlignment.MiddleLeft
        InstallationBtn.Location = New Point(0, 208)
        InstallationBtn.Name = "InstallationBtn"
        InstallationBtn.Padding = New Padding(20, 0, 0, 0)
        InstallationBtn.Size = New Size(274, 49)
        InstallationBtn.TabIndex = 5
        InstallationBtn.Text = "          Installation"
        InstallationBtn.TextAlign = ContentAlignment.MiddleLeft
        InstallationBtn.UseVisualStyleBackColor = False
        ' 
        ' SalesBtn
        ' 
        SalesBtn.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        SalesBtn.FlatAppearance.BorderSize = 0
        SalesBtn.FlatStyle = FlatStyle.Flat
        SalesBtn.Font = New Font("Segoe UI", 9.0F)
        SalesBtn.ForeColor = Color.Transparent
        SalesBtn.ImageAlign = ContentAlignment.MiddleLeft
        SalesBtn.Location = New Point(0, 153)
        SalesBtn.Name = "SalesBtn"
        SalesBtn.Size = New Size(274, 49)
        SalesBtn.TabIndex = 4
        SalesBtn.Text = "          Sales"
        SalesBtn.TextAlign = ContentAlignment.MiddleLeft
        SalesBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Segoe UI", 9.0F)
        DashboardBtn.ForeColor = Color.Transparent
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(0, 98)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(274, 49)
        DashboardBtn.TabIndex = 3
        DashboardBtn.Text = "          Dashboard"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' line
        ' 
        line.AutoSize = True
        line.BackColor = Color.Transparent
        line.ForeColor = Color.FromArgb(CByte(42), CByte(53), CByte(72))
        line.Location = New Point(-3, 79)
        line.Name = "line"
        line.Size = New Size(297, 20)
        line.TabIndex = 2
        line.Text = "________________________________________________"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.SparxFiber
        PictureBox2.Location = New Point(14, 16)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(134, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' dashboardSuperAdmin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1725, 961)
        Controls.Add(pnlMenu)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents ServiceBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents InstallationBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents SubscriberBtn As Button
    Friend WithEvents PayrollBtn As Button
    Friend WithEvents NetworkMapBtn As Button
    Friend WithEvents BillingBtn As Button
    Friend WithEvents HistoryBtn As Button
    Friend WithEvents PlansBtn As Button
End Class
