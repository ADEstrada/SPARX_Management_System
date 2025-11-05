<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesview
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        LblSalesReport = New Label()
        PanelRound1 = New PanelRound()
        CBPlanType = New ComboBox()
        LblPlanType = New Label()
        LblDateRange = New Label()
        CBDateRange = New ComboBox()
        LblFilter = New Label()
        PanelRound2 = New PanelRound()
        TotalSales = New Label()
        LblTotalNewSales = New Label()
        PanelRound4 = New PanelRound()
        AvgRev = New Label()
        LblAvgPerSale = New Label()
        PanelRound3 = New PanelRound()
        MonthlyRev = New Label()
        LblTotalMonthRev = New Label()
        pnlMonthlySalesVolume = New PanelRound()
        LblMonthlySalesVolums = New Label()
        GroupBoxSales = New GroupBox()
        dgvRecentSales = New DataGridView()
        colCustomerID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colDateInstalled = New DataGridViewTextBoxColumn()
        colPlanType = New DataGridViewTextBoxColumn()
        colMonthlyRate = New DataGridViewTextBoxColumn()
        btnExport = New ButtonRounded()
        PanelRound1.SuspendLayout()
        PanelRound2.SuspendLayout()
        PanelRound4.SuspendLayout()
        PanelRound3.SuspendLayout()
        pnlMonthlySalesVolume.SuspendLayout()
        GroupBoxSales.SuspendLayout()
        CType(dgvRecentSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblSalesReport
        ' 
        LblSalesReport.AutoSize = True
        LblSalesReport.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSalesReport.Location = New Point(22, 25)
        LblSalesReport.Name = "LblSalesReport"
        LblSalesReport.Size = New Size(125, 28)
        LblSalesReport.TabIndex = 0
        LblSalesReport.Text = "Sales Report"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(CBPlanType)
        PanelRound1.Controls.Add(LblPlanType)
        PanelRound1.Controls.Add(LblDateRange)
        PanelRound1.Controls.Add(CBDateRange)
        PanelRound1.Controls.Add(LblFilter)
        PanelRound1.ForeColor = Color.Black
        PanelRound1.Location = New Point(22, 91)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1575, 173)
        PanelRound1.TabIndex = 1
        ' 
        ' CBPlanType
        ' 
        CBPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        CBPlanType.FormattingEnabled = True
        CBPlanType.Items.AddRange(New Object() {"All Plans", "Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})
        CBPlanType.Location = New Point(249, 97)
        CBPlanType.Name = "CBPlanType"
        CBPlanType.Size = New Size(175, 28)
        CBPlanType.TabIndex = 4
        ' 
        ' LblPlanType
        ' 
        LblPlanType.AutoSize = True
        LblPlanType.Location = New Point(249, 74)
        LblPlanType.Name = "LblPlanType"
        LblPlanType.Size = New Size(72, 20)
        LblPlanType.TabIndex = 3
        LblPlanType.Text = "Plan Type"
        ' 
        ' LblDateRange
        ' 
        LblDateRange.AutoSize = True
        LblDateRange.Location = New Point(22, 74)
        LblDateRange.Name = "LblDateRange"
        LblDateRange.Size = New Size(87, 20)
        LblDateRange.TabIndex = 2
        LblDateRange.Text = "Date Range"
        ' 
        ' CBDateRange
        ' 
        CBDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        CBDateRange.FormattingEnabled = True
        CBDateRange.Items.AddRange(New Object() {"All Time", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        CBDateRange.Location = New Point(22, 97)
        CBDateRange.Name = "CBDateRange"
        CBDateRange.Size = New Size(175, 28)
        CBDateRange.TabIndex = 1
        ' 
        ' LblFilter
        ' 
        LblFilter.AutoSize = True
        LblFilter.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblFilter.Image = My.Resources.Resources.filter
        LblFilter.ImageAlign = ContentAlignment.MiddleLeft
        LblFilter.Location = New Point(22, 22)
        LblFilter.Name = "LblFilter"
        LblFilter.Size = New Size(82, 20)
        LblFilter.TabIndex = 0
        LblFilter.Text = "        Filters"
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = Color.White
        PanelRound2.Controls.Add(TotalSales)
        PanelRound2.Controls.Add(LblTotalNewSales)
        PanelRound2.Location = New Point(24, 303)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(478, 193)
        PanelRound2.TabIndex = 2
        ' 
        ' TotalSales
        ' 
        TotalSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TotalSales.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TotalSales.ForeColor = Color.Blue
        TotalSales.Location = New Point(193, 93)
        TotalSales.Name = "TotalSales"
        TotalSales.Size = New Size(82, 25)
        TotalSales.TabIndex = 1
        TotalSales.Text = "9999999"
        TotalSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalNewSales
        ' 
        LblTotalNewSales.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTotalNewSales.AutoSize = True
        LblTotalNewSales.Location = New Point(176, 26)
        LblTotalNewSales.Name = "LblTotalNewSales"
        LblTotalNewSales.Size = New Size(114, 20)
        LblTotalNewSales.TabIndex = 0
        LblTotalNewSales.Text = "Total New Sales"
        LblTotalNewSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelRound4
        ' 
        PanelRound4.BackColor = Color.White
        PanelRound4.Controls.Add(AvgRev)
        PanelRound4.Controls.Add(LblAvgPerSale)
        PanelRound4.Location = New Point(1117, 303)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(480, 193)
        PanelRound4.TabIndex = 3
        ' 
        ' AvgRev
        ' 
        AvgRev.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AvgRev.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AvgRev.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AvgRev.Location = New Point(203, 93)
        AvgRev.Name = "AvgRev"
        AvgRev.Size = New Size(82, 25)
        AvgRev.TabIndex = 3
        AvgRev.Text = "9999999"
        AvgRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAvgPerSale
        ' 
        LblAvgPerSale.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblAvgPerSale.AutoSize = True
        LblAvgPerSale.Location = New Point(169, 26)
        LblAvgPerSale.Name = "LblAvgPerSale"
        LblAvgPerSale.Size = New Size(151, 20)
        LblAvgPerSale.TabIndex = 2
        LblAvgPerSale.Text = "Avg Revenue Per Sale"
        LblAvgPerSale.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.White
        PanelRound3.Controls.Add(MonthlyRev)
        PanelRound3.Controls.Add(LblTotalMonthRev)
        PanelRound3.Location = New Point(569, 303)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(480, 193)
        PanelRound3.TabIndex = 3
        ' 
        ' MonthlyRev
        ' 
        MonthlyRev.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MonthlyRev.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MonthlyRev.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        MonthlyRev.Location = New Point(206, 93)
        MonthlyRev.Name = "MonthlyRev"
        MonthlyRev.Size = New Size(82, 25)
        MonthlyRev.TabIndex = 2
        MonthlyRev.Text = "9999999"
        MonthlyRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalMonthRev
        ' 
        LblTotalMonthRev.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTotalMonthRev.AutoSize = True
        LblTotalMonthRev.Location = New Point(170, 26)
        LblTotalMonthRev.Name = "LblTotalMonthRev"
        LblTotalMonthRev.Size = New Size(160, 20)
        LblTotalMonthRev.TabIndex = 1
        LblTotalMonthRev.Text = "Total Monthly Revenue"
        LblTotalMonthRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlMonthlySalesVolume
        ' 
        pnlMonthlySalesVolume.BackColor = Color.White
        pnlMonthlySalesVolume.Controls.Add(LblMonthlySalesVolums)
        pnlMonthlySalesVolume.Location = New Point(24, 524)
        pnlMonthlySalesVolume.Name = "pnlMonthlySalesVolume"
        pnlMonthlySalesVolume.Size = New Size(1573, 652)
        pnlMonthlySalesVolume.TabIndex = 4
        ' 
        ' LblMonthlySalesVolums
        ' 
        LblMonthlySalesVolums.AutoSize = True
        LblMonthlySalesVolums.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblMonthlySalesVolums.ImageAlign = ContentAlignment.MiddleLeft
        LblMonthlySalesVolums.Location = New Point(20, 23)
        LblMonthlySalesVolums.Name = "LblMonthlySalesVolums"
        LblMonthlySalesVolums.Size = New Size(161, 20)
        LblMonthlySalesVolums.TabIndex = 5
        LblMonthlySalesVolums.Text = "Monthly Sales Volume"
        ' 
        ' GroupBoxSales
        ' 
        GroupBoxSales.BackColor = Color.White
        GroupBoxSales.BackgroundImageLayout = ImageLayout.None
        GroupBoxSales.Controls.Add(dgvRecentSales)
        GroupBoxSales.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBoxSales.Location = New Point(30, 1211)
        GroupBoxSales.Name = "GroupBoxSales"
        GroupBoxSales.Size = New Size(1567, 773)
        GroupBoxSales.TabIndex = 5
        GroupBoxSales.TabStop = False
        GroupBoxSales.Text = "Recent Sales Details"
        ' 
        ' dgvRecentSales
        ' 
        dgvRecentSales.AllowUserToAddRows = False
        dgvRecentSales.AllowUserToDeleteRows = False
        dgvRecentSales.AllowUserToResizeColumns = False
        dgvRecentSales.AllowUserToResizeRows = False
        dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentSales.BackgroundColor = Color.White
        dgvRecentSales.BorderStyle = BorderStyle.None
        dgvRecentSales.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvRecentSales.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        dgvRecentSales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.Padding = New Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecentSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecentSales.ColumnHeadersHeight = 29
        dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRecentSales.Columns.AddRange(New DataGridViewColumn() {colCustomerID, colName, colDateInstalled, colPlanType, colMonthlyRate})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.White
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvRecentSales.DefaultCellStyle = DataGridViewCellStyle7
        dgvRecentSales.Dock = DockStyle.Fill
        dgvRecentSales.EnableHeadersVisualStyles = False
        dgvRecentSales.GridColor = Color.LightGray
        dgvRecentSales.Location = New Point(3, 26)
        dgvRecentSales.Name = "dgvRecentSales"
        dgvRecentSales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvRecentSales.RowHeadersVisible = False
        dgvRecentSales.RowHeadersWidth = 51
        dgvRecentSales.RowTemplate.Height = 40
        dgvRecentSales.RowTemplate.ReadOnly = True
        dgvRecentSales.Size = New Size(1561, 744)
        dgvRecentSales.TabIndex = 0
        ' 
        ' colCustomerID
        ' 
        colCustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colCustomerID.DataPropertyName = "CustomerID"
        DataGridViewCellStyle2.Padding = New Padding(12, 0, 12, 0)
        colCustomerID.DefaultCellStyle = DataGridViewCellStyle2
        colCustomerID.Frozen = True
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        colCustomerID.Width = 312
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colName.DataPropertyName = "Name"
        DataGridViewCellStyle3.Padding = New Padding(12, 0, 12, 0)
        colName.DefaultCellStyle = DataGridViewCellStyle3
        colName.Frozen = True
        colName.HeaderText = "Name"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Width = 312
        ' 
        ' colDateInstalled
        ' 
        colDateInstalled.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colDateInstalled.DataPropertyName = "DateInstalled"
        DataGridViewCellStyle4.Padding = New Padding(12, 0, 12, 0)
        colDateInstalled.DefaultCellStyle = DataGridViewCellStyle4
        colDateInstalled.Frozen = True
        colDateInstalled.HeaderText = "Date Installed"
        colDateInstalled.MinimumWidth = 6
        colDateInstalled.Name = "colDateInstalled"
        colDateInstalled.ReadOnly = True
        colDateInstalled.Width = 313
        ' 
        ' colPlanType
        ' 
        colPlanType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colPlanType.DataPropertyName = "PlanType"
        DataGridViewCellStyle5.Padding = New Padding(12, 0, 12, 0)
        colPlanType.DefaultCellStyle = DataGridViewCellStyle5
        colPlanType.Frozen = True
        colPlanType.HeaderText = "Plan Type"
        colPlanType.MinimumWidth = 6
        colPlanType.Name = "colPlanType"
        colPlanType.ReadOnly = True
        colPlanType.Width = 312
        ' 
        ' colMonthlyRate
        ' 
        colMonthlyRate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colMonthlyRate.DataPropertyName = "MonthlyRate"
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.Padding = New Padding(12, 0, 12, 0)
        colMonthlyRate.DefaultCellStyle = DataGridViewCellStyle6
        colMonthlyRate.Frozen = True
        colMonthlyRate.HeaderText = "Monthly Rate"
        colMonthlyRate.MinimumWidth = 6
        colMonthlyRate.Name = "colMonthlyRate"
        colMonthlyRate.ReadOnly = True
        colMonthlyRate.Width = 312
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Right
        btnExport.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        btnExport.CornerRadius = 8
        btnExport.Cursor = Cursors.Hand
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.White
        btnExport.Image = My.Resources.Resources.exportReport1
        btnExport.Location = New Point(1398, 44)
        btnExport.Margin = New Padding(3, 4, 3, 4)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(196, 40)
        btnExport.TabIndex = 14
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' salesview
        ' 
        AutoScroll = True
        Controls.Add(btnExport)
        Controls.Add(GroupBoxSales)
        Controls.Add(pnlMonthlySalesVolume)
        Controls.Add(PanelRound3)
        Controls.Add(PanelRound4)
        Controls.Add(PanelRound2)
        Controls.Add(PanelRound1)
        Controls.Add(LblSalesReport)
        Name = "salesview"
        Size = New Size(1630, 2029)
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        pnlMonthlySalesVolume.ResumeLayout(False)
        pnlMonthlySalesVolume.PerformLayout()
        GroupBoxSales.ResumeLayout(False)
        CType(dgvRecentSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSalesReport As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents LblFilter As Label
    Friend WithEvents LblPlanType As Label
    Friend WithEvents LblDateRange As Label
    Friend WithEvents CBDateRange As ComboBox
    Friend WithEvents CBPlanType As ComboBox
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents TotalSales As Label
    Friend WithEvents LblTotalNewSales As Label
    Friend WithEvents LblAvgPerSale As Label
    Friend WithEvents LblTotalMonthRev As Label
    Friend WithEvents MonthlyRev As Label
    Friend WithEvents AvgRev As Label
    Friend WithEvents pnlMonthlySalesVolume As PanelRound
    Friend WithEvents LblMonthlySalesVolums As Label
    Friend WithEvents GroupBoxSales As GroupBox
    Friend WithEvents dgvRecentSales As DataGridView
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colDateInstalled As DataGridViewTextBoxColumn
    Friend WithEvents colPlanType As DataGridViewTextBoxColumn
    Friend WithEvents colMonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents btnExport As ButtonRounded



End Class
