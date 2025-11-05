Public Class dashboardSuperAdmin
    Public Property CurrentUserName As String
    Public Property CurrentUserRole As String

    Private Sub SetHeader(title As String, subtitle As String)
        lblDashboardSuperAdmin.Text = title
        overview.Text = subtitle
    End Sub


    Private Sub LoadIntoMain(form As Form)
        Mainexchange.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        Mainexchange.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub ShowInMain(ctrl As Control, title As String, subtitle As String)
        ' Hide dashboard cards and show Main host
        Mainexchange.Visible = True

        Mainexchange.SuspendLayout()
        Mainexchange.Controls.Clear()

        If TypeOf ctrl Is Form Then
            Dim frm = DirectCast(ctrl, Form)
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            Mainexchange.Controls.Add(frm)
            frm.Show()
        Else
            ctrl.Dock = DockStyle.Fill
            Mainexchange.Controls.Add(ctrl)
            ctrl.BringToFront()
        End If

        Mainexchange.ResumeLayout()

        ' Always keep header visible and on top
        pnlHeader.Visible = True
        pnlHeader.BringToFront()

        lblDashboardSuperAdmin.Text = title
        overview.Text = subtitle
    End Sub

    Private Sub ShowDashboardCards()
        Mainexchange.Controls.Clear()
        Mainexchange.Visible = True

        ' Always keep header visible and on top
        pnlHeader.Visible = True
        pnlHeader.BringToFront()
    End Sub


    Private Sub MenuButtons_Click(sender As Object, e As EventArgs) _
    Handles DashboardBtn.Click, SalesBtn.Click, InstallationBtn.Click, ServiceBtn.Click, InventoryBtn.Click, PayrollBtn.Click, SubscriberBtn.Click, BillingBtn.Click, NetworkMapBtn.Click, HistoryBtn.Click, PlansBtn.Click

        If sender Is DashboardBtn Then
            ShowInMain(New dashboardview, "Dashboard", "Overview of Sparx Fiber Internet System")

        ElseIf sender Is DashboardBtn Then
            ShowInMain(New dashboardview, "Dashboard", "Overview of Sparx Fiber Internet System")

        ElseIf sender Is NetworkMapBtn Then
            ShowInMain(New netwrokmapview, "Network Map", "Topology, nodes, and link status")

        ElseIf sender Is SalesBtn Then
            ShowInMain(New salesview, "Sales", "Manage sales data and analytics")

        ElseIf sender Is InstallationBtn Then
            ShowInMain(New installationview, "Installation", "Manage installation data and analyti")

        ElseIf sender Is ServiceBtn Then
            ShowInMain(New service, "Service", "Manage service data and analytics")

        ElseIf sender Is InventoryBtn Then
            ShowInMain(New inventoryview, "Inventory", "Manage inventory data and analytics")

        ElseIf sender Is PayrollBtn Then
            ShowInMain(New payrollview, "Payroll", "Employee payroll and compensation")

        ElseIf sender Is SubscriberBtn Then
            ShowInMain(New subscriberview, "Subscriber", "Manage subsriber dets and analytics")

        ElseIf sender Is BillingBtn Then
            ShowInMain(New billingview, "Billing", "Manage billing data and analytics")

        ElseIf sender Is HistoryBtn Then
            ShowInMain(New historyview, "History", "Manage history data and analytics")

        ElseIf sender Is PlansBtn Then
            ShowInMain(New plansview, "Plans", "Manage plans data and analytics")
        End If
    End Sub
    Private Sub dashboardSuperAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the dashboardview UserControl on startup
        ShowInMain(New dashboardview(), "Dashboard", "Overview of Sparx Fiber Internet System")
    End Sub

    Private Sub Mainexchange_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PanelRound1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Mainexchange_Paint_1(sender As Object, e As PaintEventArgs) Handles Mainexchange.Paint

    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New sparxLogin()
        Me.Hide()
        login.Show()
        AddHandler login.FormClosed, Sub() Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Duplicate handler safeguard
        Button1_Click(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
