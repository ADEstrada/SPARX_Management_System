<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesSuperAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesSuperAdmin))
        PlansBtn = New Button()
        HistoryBtn = New Button()
        NetworkMapBtn = New Button()
        BillingBtn = New Button()
        SubscriberBtn = New Button()
        btnNotification = New PictureBox()
        overview = New Label()
        lblSalesSuperAdmin = New Label()
        systemOnline = New Label()
        PayrollBtn = New Button()
        InventoryBtn = New Button()
        ServiceBtn = New Button()
        InstallationBtn = New Button()
        SalesBtn = New Button()
        DashboardBtn = New Button()
        line = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        pnlSystemOnline = New PanelRound()
        pnlMenu = New Panel()
        pnlHeader = New Panel()
        LblSalesReport = New Label()
        CType(btnNotification, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSystemOnline.SuspendLayout()
        pnlMenu.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' PlansBtn
        ' 
        PlansBtn.AllowDrop = True
        PlansBtn.FlatAppearance.BorderSize = 0
        PlansBtn.FlatStyle = FlatStyle.Flat
        PlansBtn.ForeColor = Color.Transparent
        PlansBtn.Image = My.Resources.Resources.plan
        PlansBtn.ImageAlign = ContentAlignment.MiddleLeft
        PlansBtn.Location = New Point(0, 686)
        PlansBtn.Name = "PlansBtn"
        PlansBtn.Padding = New Padding(20, 0, 0, 0)
        PlansBtn.Size = New Size(274, 52)
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
        HistoryBtn.Location = New Point(-3, 628)
        HistoryBtn.Name = "HistoryBtn"
        HistoryBtn.Padding = New Padding(20, 0, 0, 0)
        HistoryBtn.Size = New Size(274, 52)
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
        NetworkMapBtn.Location = New Point(0, 570)
        NetworkMapBtn.Name = "NetworkMapBtn"
        NetworkMapBtn.Padding = New Padding(20, 0, 0, 0)
        NetworkMapBtn.Size = New Size(274, 52)
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
        BillingBtn.Location = New Point(0, 512)
        BillingBtn.Name = "BillingBtn"
        BillingBtn.Padding = New Padding(20, 0, 0, 0)
        BillingBtn.Size = New Size(274, 52)
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
        SubscriberBtn.Location = New Point(0, 454)
        SubscriberBtn.Name = "SubscriberBtn"
        SubscriberBtn.Padding = New Padding(20, 0, 0, 0)
        SubscriberBtn.Size = New Size(274, 52)
        SubscriberBtn.TabIndex = 9
        SubscriberBtn.Text = "           Subscriber"
        SubscriberBtn.TextAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.UseCompatibleTextRendering = True
        SubscriberBtn.UseVisualStyleBackColor = True
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
        overview.Size = New Size(223, 20)
        overview.TabIndex = 2
        overview.Text = "Manage sales data and analytics"
        ' 
        ' lblSalesSuperAdmin
        ' 
        lblSalesSuperAdmin.AutoSize = True
        lblSalesSuperAdmin.Font = New Font("Verdana", 12F)
        lblSalesSuperAdmin.Location = New Point(30, 21)
        lblSalesSuperAdmin.Name = "lblSalesSuperAdmin"
        lblSalesSuperAdmin.Size = New Size(66, 25)
        lblSalesSuperAdmin.TabIndex = 0
        lblSalesSuperAdmin.Text = "Sales"
        ' 
        ' systemOnline
        ' 
        systemOnline.AutoSize = True
        systemOnline.Font = New Font("Verdana", 9F)
        systemOnline.Location = New Point(30, 13)
        systemOnline.Name = "systemOnline"
        systemOnline.Size = New Size(115, 18)
        systemOnline.TabIndex = 0
        systemOnline.Text = "System Online"
        ' 
        ' PayrollBtn
        ' 
        PayrollBtn.AllowDrop = True
        PayrollBtn.FlatAppearance.BorderSize = 0
        PayrollBtn.FlatStyle = FlatStyle.Flat
        PayrollBtn.ForeColor = Color.Transparent
        PayrollBtn.Image = My.Resources.Resources.payroll
        PayrollBtn.ImageAlign = ContentAlignment.MiddleLeft
        PayrollBtn.Location = New Point(0, 386)
        PayrollBtn.Name = "PayrollBtn"
        PayrollBtn.Padding = New Padding(20, 0, 0, 0)
        PayrollBtn.Size = New Size(274, 52)
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
        InventoryBtn.Location = New Point(0, 328)
        InventoryBtn.Name = "InventoryBtn"
        InventoryBtn.Padding = New Padding(20, 0, 0, 0)
        InventoryBtn.Size = New Size(274, 52)
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
        ServiceBtn.Location = New Point(0, 270)
        ServiceBtn.Name = "ServiceBtn"
        ServiceBtn.Padding = New Padding(20, 0, 0, 0)
        ServiceBtn.Size = New Size(274, 52)
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
        InstallationBtn.Location = New Point(0, 212)
        InstallationBtn.Name = "InstallationBtn"
        InstallationBtn.Padding = New Padding(20, 0, 0, 0)
        InstallationBtn.Size = New Size(274, 52)
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
        SalesBtn.Location = New Point(0, 154)
        SalesBtn.Name = "SalesBtn"
        SalesBtn.Padding = New Padding(20, 0, 0, 0)
        SalesBtn.Size = New Size(274, 52)
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
        DashboardBtn.Location = New Point(0, 96)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(20, 0, 0, 0)
        DashboardBtn.Size = New Size(274, 52)
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
        ' pnlMenu
        ' 
        pnlMenu.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        pnlMenu.Controls.Add(PlansBtn)
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
        pnlMenu.Location = New Point(1, 0)
        pnlMenu.Margin = New Padding(3, 4, 3, 4)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(274, 961)
        pnlMenu.TabIndex = 10
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(PictureBox1)
        pnlHeader.Controls.Add(pnlSystemOnline)
        pnlHeader.Controls.Add(btnNotification)
        pnlHeader.Controls.Add(overview)
        pnlHeader.Controls.Add(lblSalesSuperAdmin)
        pnlHeader.Location = New Point(272, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1454, 89)
        pnlHeader.TabIndex = 9
        ' 
        ' LblSalesReport
        ' 
        LblSalesReport.AutoSize = True
        LblSalesReport.Font = New Font("Verdana", 12F)
        LblSalesReport.Location = New Point(302, 123)
        LblSalesReport.Name = "LblSalesReport"
        LblSalesReport.Size = New Size(140, 25)
        LblSalesReport.TabIndex = 5
        LblSalesReport.Text = "Sales Report"
        ' 
        ' SalesSuperAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1816, 1095)
        Controls.Add(LblSalesReport)
        Controls.Add(pnlMenu)
        Controls.Add(pnlHeader)
        Name = "SalesSuperAdmin"
        Text = "SalesSuperAdmin"
        CType(btnNotification, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlSystemOnline.ResumeLayout(False)
        pnlSystemOnline.PerformLayout()
        pnlMenu.ResumeLayout(False)
        pnlMenu.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PlansBtn As Button
    Friend WithEvents HistoryBtn As Button
    Friend WithEvents NetworkMapBtn As Button
    Friend WithEvents BillingBtn As Button
    Friend WithEvents SubscriberBtn As Button
    Friend WithEvents btnNotification As PictureBox
    Friend WithEvents overview As Label
    Friend WithEvents lblSalesSuperAdmin As Label
    Friend WithEvents systemOnline As Label
    Friend WithEvents PayrollBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents ServiceBtn As Button
    Friend WithEvents InstallationBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents line As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlSystemOnline As PanelRound
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents LblSalesReport As Label
End Class
