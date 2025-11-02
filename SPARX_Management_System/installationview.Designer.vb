<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installationview
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderInstallationReport = New Label()
        PanelRound1 = New PanelRound()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        LabelStatus = New Label()
        LabelTechnician = New Label()
        LabelDateRange = New Label()
        LabelFilters = New Label()
        IconFilter = New PictureBox()
        PanelTotalInstallations = New PanelRound()
        IconTotalInstallations = New PictureBox()
        NumTotalInstallations = New Label()
        LabelTotalInstallations = New Label()
        PanelCompleted = New PanelRound()
        IconComplete = New PictureBox()
        NumCompleted = New Label()
        LabelCompleted = New Label()
        PanelInProgress = New PanelRound()
        IconInProgress = New PictureBox()
        NumInProgress = New Label()
        LabelInProgress = New Label()
        PanelPending = New PanelRound()
        IconPending = New PictureBox()
        NumPending = New Label()
        LabelPending = New Label()
        PanelSubscribersPlan = New PanelRound()
        LabelInstallationStatusDistribution = New Label()
        PnlCancelled = New PanelRound()
        PercentCancelled = New Label()
        Cancelled = New Label()
        PictureBox1 = New PictureBox()
        PnlPending = New PanelRound()
        Pending = New Label()
        PercentPending = New Label()
        PictureBox5 = New PictureBox()
        PnlInProgress = New PanelRound()
        InProgress = New Label()
        PictureBox4 = New PictureBox()
        PercentInProgress = New Label()
        PnlCompleted = New PanelRound()
        Completed = New Label()
        PictureBox6 = New PictureBox()
        PercentComplete = New Label()
        DataGridInstallationDetails = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        Customer = New DataGridViewTextBoxColumn()
        ContactNo = New DataGridViewTextBoxColumn()
        DateRequested = New DataGridViewTextBoxColumn()
        Technician = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        EditDelete = New DataGridViewTextBoxColumn()
        PanelInstallationDetails = New PanelRound()
        LabelInstallationDetails = New Label()
        PanelRound1.SuspendLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalInstallations.SuspendLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).BeginInit()
        PanelCompleted.SuspendLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).BeginInit()
        PanelInProgress.SuspendLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).BeginInit()
        PanelPending.SuspendLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).BeginInit()
        PanelSubscribersPlan.SuspendLayout()
        PnlCancelled.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlPending.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PnlInProgress.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PnlCompleted.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).BeginInit()
        PanelInstallationDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' HeaderInstallationReport
        ' 
        HeaderInstallationReport.AutoSize = True
        HeaderInstallationReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderInstallationReport.Location = New Point(43, 18)
        HeaderInstallationReport.Name = "HeaderInstallationReport"
        HeaderInstallationReport.Size = New Size(179, 28)
        HeaderInstallationReport.TabIndex = 0
        HeaderInstallationReport.Text = "Installation Report"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Anchor = AnchorStyles.Top
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(ComboBox3)
        PanelRound1.Controls.Add(ComboBox2)
        PanelRound1.Controls.Add(ComboBox1)
        PanelRound1.Controls.Add(LabelStatus)
        PanelRound1.Controls.Add(LabelTechnician)
        PanelRound1.Controls.Add(LabelDateRange)
        PanelRound1.Controls.Add(LabelFilters)
        PanelRound1.Controls.Add(IconFilter)
        PanelRound1.CornerRadius = 12
        PanelRound1.Location = New Point(200, 60)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 165)
        PanelRound1.TabIndex = 1
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = SystemColors.ButtonFace
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Segoe UI", 14F)
        ComboBox3.ForeColor = SystemColors.WindowText
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(444, 104)
        ComboBox3.MinimumSize = New Size(193, 0)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(193, 33)
        ComboBox3.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ButtonFace
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 14F)
        ComboBox2.ForeColor = SystemColors.WindowText
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(234, 104)
        ComboBox2.MinimumSize = New Size(193, 0)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(193, 33)
        ComboBox2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ButtonFace
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 14F)
        ComboBox1.ForeColor = SystemColors.WindowText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(24, 104)
        ComboBox1.MinimumSize = New Size(193, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(193, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatus.Location = New Point(444, 80)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(55, 21)
        LabelStatus.TabIndex = 4
        LabelStatus.Text = "Status"
        ' 
        ' LabelTechnician
        ' 
        LabelTechnician.AutoSize = True
        LabelTechnician.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelTechnician.Location = New Point(234, 80)
        LabelTechnician.Name = "LabelTechnician"
        LabelTechnician.Size = New Size(85, 21)
        LabelTechnician.TabIndex = 3
        LabelTechnician.Text = "Technician"
        ' 
        ' LabelDateRange
        ' 
        LabelDateRange.AutoSize = True
        LabelDateRange.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelDateRange.Location = New Point(22, 80)
        LabelDateRange.Name = "LabelDateRange"
        LabelDateRange.Size = New Size(94, 21)
        LabelDateRange.TabIndex = 2
        LabelDateRange.Text = "Date Range"
        ' 
        ' LabelFilters
        ' 
        LabelFilters.AutoSize = True
        LabelFilters.Font = New Font("Verdana", 12F)
        LabelFilters.Location = New Point(51, 23)
        LabelFilters.Name = "LabelFilters"
        LabelFilters.Size = New Size(59, 18)
        LabelFilters.TabIndex = 1
        LabelFilters.Text = "Filters"
        ' 
        ' IconFilter
        ' 
        IconFilter.Image = My.Resources.Resources.filter
        IconFilter.Location = New Point(22, 19)
        IconFilter.Name = "IconFilter"
        IconFilter.Size = New Size(24, 24)
        IconFilter.SizeMode = PictureBoxSizeMode.Zoom
        IconFilter.TabIndex = 0
        IconFilter.TabStop = False
        ' 
        ' PanelTotalInstallations
        ' 
        PanelTotalInstallations.BackColor = Color.White
        PanelTotalInstallations.Controls.Add(IconTotalInstallations)
        PanelTotalInstallations.Controls.Add(NumTotalInstallations)
        PanelTotalInstallations.Controls.Add(LabelTotalInstallations)
        PanelTotalInstallations.CornerRadius = 12
        PanelTotalInstallations.Location = New Point(43, 256)
        PanelTotalInstallations.Name = "PanelTotalInstallations"
        PanelTotalInstallations.Size = New Size(367, 115)
        PanelTotalInstallations.TabIndex = 13
        ' 
        ' IconTotalInstallations
        ' 
        IconTotalInstallations.Image = My.Resources.Resources.BLueWrench
        IconTotalInstallations.Location = New Point(286, 36)
        IconTotalInstallations.Name = "IconTotalInstallations"
        IconTotalInstallations.Size = New Size(48, 50)
        IconTotalInstallations.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalInstallations.TabIndex = 9
        IconTotalInstallations.TabStop = False
        ' 
        ' NumTotalInstallations
        ' 
        NumTotalInstallations.AutoSize = True
        NumTotalInstallations.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumTotalInstallations.Location = New Point(24, 66)
        NumTotalInstallations.Name = "NumTotalInstallations"
        NumTotalInstallations.Size = New Size(37, 30)
        NumTotalInstallations.TabIndex = 8
        NumTotalInstallations.Text = "00"
        ' 
        ' LabelTotalInstallations
        ' 
        LabelTotalInstallations.AutoSize = True
        LabelTotalInstallations.Font = New Font("Verdana", 12F)
        LabelTotalInstallations.ForeColor = SystemColors.ControlDarkDark
        LabelTotalInstallations.Location = New Point(24, 25)
        LabelTotalInstallations.Name = "LabelTotalInstallations"
        LabelTotalInstallations.Size = New Size(158, 18)
        LabelTotalInstallations.TabIndex = 8
        LabelTotalInstallations.Text = "Total Installations"
        ' 
        ' PanelCompleted
        ' 
        PanelCompleted.BackColor = Color.White
        PanelCompleted.Controls.Add(IconComplete)
        PanelCompleted.Controls.Add(NumCompleted)
        PanelCompleted.Controls.Add(LabelCompleted)
        PanelCompleted.CornerRadius = 12
        PanelCompleted.Location = New Point(455, 256)
        PanelCompleted.Name = "PanelCompleted"
        PanelCompleted.Size = New Size(367, 115)
        PanelCompleted.TabIndex = 14
        ' 
        ' IconComplete
        ' 
        IconComplete.Image = My.Resources.Resources.greenCompleted
        IconComplete.Location = New Point(286, 36)
        IconComplete.Name = "IconComplete"
        IconComplete.Size = New Size(48, 50)
        IconComplete.SizeMode = PictureBoxSizeMode.Zoom
        IconComplete.TabIndex = 10
        IconComplete.TabStop = False
        ' 
        ' NumCompleted
        ' 
        NumCompleted.AutoSize = True
        NumCompleted.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumCompleted.Location = New Point(24, 66)
        NumCompleted.Name = "NumCompleted"
        NumCompleted.Size = New Size(37, 30)
        NumCompleted.TabIndex = 9
        NumCompleted.Text = "00"
        ' 
        ' LabelCompleted
        ' 
        LabelCompleted.AutoSize = True
        LabelCompleted.Font = New Font("Verdana", 12F)
        LabelCompleted.ForeColor = SystemColors.ControlDarkDark
        LabelCompleted.Location = New Point(24, 25)
        LabelCompleted.Name = "LabelCompleted"
        LabelCompleted.Size = New Size(96, 18)
        LabelCompleted.TabIndex = 8
        LabelCompleted.Text = "Completed"
        ' 
        ' PanelInProgress
        ' 
        PanelInProgress.BackColor = Color.White
        PanelInProgress.Controls.Add(IconInProgress)
        PanelInProgress.Controls.Add(NumInProgress)
        PanelInProgress.Controls.Add(LabelInProgress)
        PanelInProgress.CornerRadius = 12
        PanelInProgress.Location = New Point(863, 256)
        PanelInProgress.Name = "PanelInProgress"
        PanelInProgress.Size = New Size(367, 115)
        PanelInProgress.TabIndex = 15
        ' 
        ' IconInProgress
        ' 
        IconInProgress.Image = My.Resources.Resources.redInProgress
        IconInProgress.Location = New Point(286, 36)
        IconInProgress.Name = "IconInProgress"
        IconInProgress.Size = New Size(48, 50)
        IconInProgress.SizeMode = PictureBoxSizeMode.Zoom
        IconInProgress.TabIndex = 11
        IconInProgress.TabStop = False
        ' 
        ' NumInProgress
        ' 
        NumInProgress.AutoSize = True
        NumInProgress.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumInProgress.Location = New Point(24, 66)
        NumInProgress.Name = "NumInProgress"
        NumInProgress.Size = New Size(37, 30)
        NumInProgress.TabIndex = 10
        NumInProgress.Text = "00"
        ' 
        ' LabelInProgress
        ' 
        LabelInProgress.AutoSize = True
        LabelInProgress.Font = New Font("Verdana", 12F)
        LabelInProgress.ForeColor = SystemColors.ControlDarkDark
        LabelInProgress.Location = New Point(24, 25)
        LabelInProgress.Name = "LabelInProgress"
        LabelInProgress.Size = New Size(101, 18)
        LabelInProgress.TabIndex = 8
        LabelInProgress.Text = "In Progress"
        ' 
        ' PanelPending
        ' 
        PanelPending.BackColor = Color.White
        PanelPending.Controls.Add(IconPending)
        PanelPending.Controls.Add(NumPending)
        PanelPending.Controls.Add(LabelPending)
        PanelPending.CornerRadius = 12
        PanelPending.Location = New Point(1274, 256)
        PanelPending.Name = "PanelPending"
        PanelPending.Size = New Size(367, 115)
        PanelPending.TabIndex = 16
        ' 
        ' IconPending
        ' 
        IconPending.Image = My.Resources.Resources.orangePending
        IconPending.Location = New Point(286, 36)
        IconPending.Name = "IconPending"
        IconPending.Size = New Size(48, 50)
        IconPending.SizeMode = PictureBoxSizeMode.Zoom
        IconPending.TabIndex = 12
        IconPending.TabStop = False
        ' 
        ' NumPending
        ' 
        NumPending.AutoSize = True
        NumPending.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumPending.Location = New Point(24, 66)
        NumPending.Name = "NumPending"
        NumPending.Size = New Size(37, 30)
        NumPending.TabIndex = 11
        NumPending.Text = "00"
        ' 
        ' LabelPending
        ' 
        LabelPending.AutoSize = True
        LabelPending.Font = New Font("Verdana", 12F)
        LabelPending.ForeColor = SystemColors.ControlDarkDark
        LabelPending.Location = New Point(24, 25)
        LabelPending.Name = "LabelPending"
        LabelPending.Size = New Size(73, 18)
        LabelPending.TabIndex = 8
        LabelPending.Text = "Pending"
        ' 
        ' PanelSubscribersPlan
        ' 
        PanelSubscribersPlan.Anchor = AnchorStyles.Top
        PanelSubscribersPlan.BackColor = Color.White
        PanelSubscribersPlan.Controls.Add(LabelInstallationStatusDistribution)
        PanelSubscribersPlan.Controls.Add(PnlCancelled)
        PanelSubscribersPlan.Controls.Add(PnlPending)
        PanelSubscribersPlan.Controls.Add(PnlInProgress)
        PanelSubscribersPlan.Controls.Add(PnlCompleted)
        PanelSubscribersPlan.CornerRadius = 12
        PanelSubscribersPlan.Location = New Point(200, 407)
        PanelSubscribersPlan.Name = "PanelSubscribersPlan"
        PanelSubscribersPlan.Size = New Size(1595, 504)
        PanelSubscribersPlan.TabIndex = 10
        ' 
        ' LabelInstallationStatusDistribution
        ' 
        LabelInstallationStatusDistribution.AutoSize = True
        LabelInstallationStatusDistribution.Font = New Font("Verdana", 12F)
        LabelInstallationStatusDistribution.ForeColor = SystemColors.ControlDarkDark
        LabelInstallationStatusDistribution.Location = New Point(24, 25)
        LabelInstallationStatusDistribution.Name = "LabelInstallationStatusDistribution"
        LabelInstallationStatusDistribution.Size = New Size(264, 18)
        LabelInstallationStatusDistribution.TabIndex = 10
        LabelInstallationStatusDistribution.Text = "Installation Status Distribution"
        ' 
        ' PnlCancelled
        ' 
        PnlCancelled.Anchor = AnchorStyles.Top
        PnlCancelled.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PnlCancelled.Controls.Add(PercentCancelled)
        PnlCancelled.Controls.Add(Cancelled)
        PnlCancelled.Controls.Add(PictureBox1)
        PnlCancelled.CornerRadius = 12
        PnlCancelled.ForeColor = SystemColors.ControlText
        PnlCancelled.Location = New Point(695, 365)
        PnlCancelled.Name = "PnlCancelled"
        PnlCancelled.Size = New Size(861, 74)
        PnlCancelled.TabIndex = 22
        ' 
        ' PercentCancelled
        ' 
        PercentCancelled.Anchor = AnchorStyles.Top
        PercentCancelled.AutoSize = True
        PercentCancelled.Font = New Font("Segoe UI Semibold", 12F)
        PercentCancelled.ForeColor = Color.Black
        PercentCancelled.Location = New Point(789, 27)
        PercentCancelled.Name = "PercentCancelled"
        PercentCancelled.Size = New Size(41, 21)
        PercentCancelled.TabIndex = 27
        PercentCancelled.Text = "00%"
        ' 
        ' Cancelled
        ' 
        Cancelled.Anchor = AnchorStyles.Top
        Cancelled.AutoSize = True
        Cancelled.Font = New Font("Segoe UI", 11F)
        Cancelled.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Cancelled.Location = New Point(46, 28)
        Cancelled.Name = "Cancelled"
        Cancelled.Size = New Size(74, 20)
        Cancelled.TabIndex = 20
        Cancelled.Text = "Cancelled"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = My.Resources.Resources.redDot
        PictureBox1.Location = New Point(28, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 12)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' PnlPending
        ' 
        PnlPending.Anchor = AnchorStyles.Top
        PnlPending.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PnlPending.Controls.Add(Pending)
        PnlPending.Controls.Add(PercentPending)
        PnlPending.Controls.Add(PictureBox5)
        PnlPending.CornerRadius = 12
        PnlPending.ForeColor = SystemColors.ControlText
        PnlPending.Location = New Point(695, 268)
        PnlPending.Name = "PnlPending"
        PnlPending.Size = New Size(861, 74)
        PnlPending.TabIndex = 14
        ' 
        ' Pending
        ' 
        Pending.Anchor = AnchorStyles.Top
        Pending.AutoSize = True
        Pending.Font = New Font("Segoe UI", 11F)
        Pending.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Pending.Location = New Point(46, 28)
        Pending.Name = "Pending"
        Pending.Size = New Size(62, 20)
        Pending.TabIndex = 21
        Pending.Text = "Pending"
        ' 
        ' PercentPending
        ' 
        PercentPending.Anchor = AnchorStyles.Top
        PercentPending.AutoSize = True
        PercentPending.Font = New Font("Segoe UI Semibold", 12F)
        PercentPending.ForeColor = Color.Black
        PercentPending.Location = New Point(789, 27)
        PercentPending.Name = "PercentPending"
        PercentPending.Size = New Size(41, 21)
        PercentPending.TabIndex = 26
        PercentPending.Text = "00%"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.Image = My.Resources.Resources.EcstacyDot
        PictureBox5.Location = New Point(28, 32)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(12, 12)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' PnlInProgress
        ' 
        PnlInProgress.Anchor = AnchorStyles.Top
        PnlInProgress.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PnlInProgress.Controls.Add(InProgress)
        PnlInProgress.Controls.Add(PictureBox4)
        PnlInProgress.Controls.Add(PercentInProgress)
        PnlInProgress.CornerRadius = 12
        PnlInProgress.ForeColor = SystemColors.ControlText
        PnlInProgress.Location = New Point(695, 172)
        PnlInProgress.Name = "PnlInProgress"
        PnlInProgress.Size = New Size(861, 74)
        PnlInProgress.TabIndex = 13
        ' 
        ' InProgress
        ' 
        InProgress.Anchor = AnchorStyles.Top
        InProgress.AutoSize = True
        InProgress.Font = New Font("Segoe UI", 11F)
        InProgress.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        InProgress.Location = New Point(46, 28)
        InProgress.Name = "InProgress"
        InProgress.Size = New Size(81, 20)
        InProgress.TabIndex = 22
        InProgress.Text = "In Progress"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = My.Resources.Resources.ButtercupDot
        PictureBox4.Location = New Point(28, 32)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 12)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' PercentInProgress
        ' 
        PercentInProgress.Anchor = AnchorStyles.Top
        PercentInProgress.AutoSize = True
        PercentInProgress.Font = New Font("Segoe UI Semibold", 12F)
        PercentInProgress.ForeColor = Color.Black
        PercentInProgress.Location = New Point(789, 27)
        PercentInProgress.Name = "PercentInProgress"
        PercentInProgress.Size = New Size(41, 21)
        PercentInProgress.TabIndex = 26
        PercentInProgress.Text = "00%"
        ' 
        ' PnlCompleted
        ' 
        PnlCompleted.Anchor = AnchorStyles.Top
        PnlCompleted.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PnlCompleted.Controls.Add(Completed)
        PnlCompleted.Controls.Add(PictureBox6)
        PnlCompleted.Controls.Add(PercentComplete)
        PnlCompleted.CornerRadius = 12
        PnlCompleted.ForeColor = SystemColors.ControlText
        PnlCompleted.Location = New Point(695, 75)
        PnlCompleted.Name = "PnlCompleted"
        PnlCompleted.Size = New Size(861, 74)
        PnlCompleted.TabIndex = 12
        ' 
        ' Completed
        ' 
        Completed.Anchor = AnchorStyles.Top
        Completed.AutoSize = True
        Completed.Font = New Font("Segoe UI", 11F)
        Completed.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Completed.Location = New Point(46, 28)
        Completed.Name = "Completed"
        Completed.Size = New Size(83, 20)
        Completed.TabIndex = 20
        Completed.Text = "Completed"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top
        PictureBox6.Image = My.Resources.Resources.greenDot
        PictureBox6.Location = New Point(28, 32)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 12)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 21
        PictureBox6.TabStop = False
        ' 
        ' PercentComplete
        ' 
        PercentComplete.Anchor = AnchorStyles.Top
        PercentComplete.AutoSize = True
        PercentComplete.Font = New Font("Segoe UI Semibold", 12F)
        PercentComplete.ForeColor = Color.Black
        PercentComplete.Location = New Point(789, 27)
        PercentComplete.Name = "PercentComplete"
        PercentComplete.Size = New Size(41, 21)
        PercentComplete.TabIndex = 22
        PercentComplete.Text = "00%"
        ' 
        ' DataGridInstallationDetails
        ' 
        DataGridInstallationDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridInstallationDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridInstallationDetails.BackgroundColor = Color.White
        DataGridInstallationDetails.BorderStyle = BorderStyle.None
        DataGridInstallationDetails.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridInstallationDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 10F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridInstallationDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridInstallationDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridInstallationDetails.Columns.AddRange(New DataGridViewColumn() {ServiceID, Customer, ContactNo, DateRequested, Technician, Address, Status, EditDelete})
        DataGridInstallationDetails.GridColor = Color.Silver
        DataGridInstallationDetails.Location = New Point(24, 74)
        DataGridInstallationDetails.Name = "DataGridInstallationDetails"
        DataGridInstallationDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridInstallationDetails.RowHeadersVisible = False
        DataGridInstallationDetails.RowTemplate.Height = 40
        DataGridInstallationDetails.ScrollBars = ScrollBars.Vertical
        DataGridInstallationDetails.Size = New Size(1543, 393)
        DataGridInstallationDetails.TabIndex = 23
        ' 
        ' ServiceID
        ' 
        ServiceID.Frozen = True
        ServiceID.HeaderText = "ServiceID"
        ServiceID.Name = "ServiceID"
        ServiceID.ReadOnly = True
        ServiceID.Width = 150
        ' 
        ' Customer
        ' 
        Customer.HeaderText = "Customer"
        Customer.Name = "Customer"
        Customer.ReadOnly = True
        Customer.Width = 150
        ' 
        ' ContactNo
        ' 
        ContactNo.HeaderText = "Contact No."
        ContactNo.Name = "ContactNo"
        ContactNo.ReadOnly = True
        ContactNo.Width = 150
        ' 
        ' DateRequested
        ' 
        DateRequested.HeaderText = "Date Requested"
        DateRequested.Name = "DateRequested"
        DateRequested.ReadOnly = True
        DateRequested.Width = 200
        ' 
        ' Technician
        ' 
        Technician.HeaderText = "Technician"
        Technician.Name = "Technician"
        Technician.ReadOnly = True
        Technician.Width = 200
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.Name = "Address"
        Address.ReadOnly = True
        Address.Width = 350
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' EditDelete
        ' 
        EditDelete.HeaderText = ""
        EditDelete.Name = "EditDelete"
        EditDelete.ReadOnly = True
        EditDelete.Width = 50
        ' 
        ' PanelInstallationDetails
        ' 
        PanelInstallationDetails.BackColor = Color.White
        PanelInstallationDetails.Controls.Add(LabelInstallationDetails)
        PanelInstallationDetails.Controls.Add(DataGridInstallationDetails)
        PanelInstallationDetails.CornerRadius = 12
        PanelInstallationDetails.Location = New Point(43, 953)
        PanelInstallationDetails.Name = "PanelInstallationDetails"
        PanelInstallationDetails.Size = New Size(1595, 504)
        PanelInstallationDetails.TabIndex = 17
        ' 
        ' LabelInstallationDetails
        ' 
        LabelInstallationDetails.AutoSize = True
        LabelInstallationDetails.Font = New Font("Verdana", 12F)
        LabelInstallationDetails.ForeColor = SystemColors.ControlDarkDark
        LabelInstallationDetails.Location = New Point(24, 25)
        LabelInstallationDetails.Name = "LabelInstallationDetails"
        LabelInstallationDetails.Size = New Size(167, 18)
        LabelInstallationDetails.TabIndex = 24
        LabelInstallationDetails.Text = "Installation Details"
        ' 
        ' installationview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonFace
        Controls.Add(PanelInstallationDetails)
        Controls.Add(PanelSubscribersPlan)
        Controls.Add(PanelPending)
        Controls.Add(PanelInProgress)
        Controls.Add(PanelCompleted)
        Controls.Add(PanelTotalInstallations)
        Controls.Add(PanelRound1)
        Controls.Add(HeaderInstallationReport)
        Name = "installationview"
        Size = New Size(1980, 1576)
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalInstallations.ResumeLayout(False)
        PanelTotalInstallations.PerformLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).EndInit()
        PanelCompleted.ResumeLayout(False)
        PanelCompleted.PerformLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).EndInit()
        PanelInProgress.ResumeLayout(False)
        PanelInProgress.PerformLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).EndInit()
        PanelPending.ResumeLayout(False)
        PanelPending.PerformLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).EndInit()
        PanelSubscribersPlan.ResumeLayout(False)
        PanelSubscribersPlan.PerformLayout()
        PnlCancelled.ResumeLayout(False)
        PnlCancelled.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlPending.ResumeLayout(False)
        PnlPending.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PnlInProgress.ResumeLayout(False)
        PnlInProgress.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PnlCompleted.ResumeLayout(False)
        PnlCompleted.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).EndInit()
        PanelInstallationDetails.ResumeLayout(False)
        PanelInstallationDetails.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderInstallationReport As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents LabelDateRange As Label
    Friend WithEvents LabelFilters As Label
    Friend WithEvents IconFilter As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelTechnician As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PanelTotalInstallations As PanelRound
    Friend WithEvents LabelTotalInstallations As Label
    Friend WithEvents PanelCompleted As PanelRound
    Friend WithEvents LabelCompleted As Label
    Friend WithEvents PanelInProgress As PanelRound
    Friend WithEvents LabelInProgress As Label
    Friend WithEvents PanelPending As PanelRound
    Friend WithEvents LabelPending As Label
    Friend WithEvents NumTotalInstallations As Label
    Friend WithEvents NumCompleted As Label
    Friend WithEvents NumInProgress As Label
    Friend WithEvents NumPending As Label
    Friend WithEvents IconTotalInstallations As PictureBox
    Friend WithEvents IconComplete As PictureBox
    Friend WithEvents IconInProgress As PictureBox
    Friend WithEvents IconPending As PictureBox
    Friend WithEvents PanelSubscribersPlan As PanelRound
    Friend WithEvents PnlPending As PanelRound
    Friend WithEvents PercentPending As Label
    Friend WithEvents Pending As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PnlInProgress As PanelRound
    Friend WithEvents InProgress As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PercentInProgress As Label
    Friend WithEvents PnlCompleted As PanelRound
    Friend WithEvents PercentComplete As Label
    Friend WithEvents Completed As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PnlCancelled As PanelRound
    Friend WithEvents PercentCancelled As Label
    Friend WithEvents Cancelled As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelInstallationStatusDistribution As Label
    Friend WithEvents DataGridInstallationDetails As DataGridView
    Friend WithEvents PanelInstallationDetails As PanelRound
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents ContactNo As DataGridViewTextBoxColumn
    Friend WithEvents DateRequested As DataGridViewTextBoxColumn
    Friend WithEvents Technician As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents EditDelete As DataGridViewTextBoxColumn
    Friend WithEvents LabelInstallationDetails As Label

End Class
