Public Class salesview

    Private Sub dgvRecentSales_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRecentSales.CellFormatting

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgvRecentSales.Columns(e.ColumnIndex).DataPropertyName = "PlanType" Then

                Select Case e.Value.ToString

                    Case "Basic 25Mbps"
                        e.CellStyle.BackColor = Color.FromArgb(240, 240, 240) ' Light Gray
                        e.CellStyle.ForeColor = Color.Black

                    Case "Standard 50Mbps"
                        e.CellStyle.BackColor = Color.FromArgb(204, 229, 255) ' Light Blue
                        e.CellStyle.ForeColor = Color.MidnightBlue

                    Case "Premium 100Mbps"
                        e.CellStyle.BackColor = Color.FromArgb(204, 255, 204) ' Light Green
                        e.CellStyle.ForeColor = Color.DarkGreen

                    Case Else
                        e.CellStyle.BackColor = Color.White

                End Select

                e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
                e.FormattingApplied = True

            End If
        End If

    End Sub

    Private Sub PopulateDropdowns()

        Me.CBPlanType.Items.Clear()
        Me.CBPlanType.Items.Add("All Plans")
        Me.CBPlanType.Items.AddRange(New String() {"Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})

        Me.CBDateRange.Items.Clear()
        Me.CBDateRange.Items.Add("All Time")
        Me.CBDateRange.Items.AddRange(New String() {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
        })

    End Sub

    ' Mock Functions - For Testing Only - Replace with Actual Data Retrieval Logic

    Private Function GetTotalSales_MOCK() As Decimal

        Return 10.99

    End Function

    Private Function GetMonthlyRevenue_MOCK() As Decimal

        Return 45873.5D

    End Function

    Private Function GetAvgRevenue_MOCK() As Decimal

        Return 145.75D

    End Function

    Private Sub UpdateSalesLabel()

        Dim salesValue As Decimal = GetTotalSales_MOCK()

        TotalSales.Text = salesValue.ToString("C2")
        Dim monthlyRevenue As Decimal = GetMonthlyRevenue_MOCK()

        MonthlyRev.Text = monthlyRevenue.ToString("C2")
        Dim avgRevenue As Decimal = GetAvgRevenue_MOCK()

        AvgRev.Text = avgRevenue.ToString("C2")

    End Sub


    Private Sub LoadRecentSales_MOCK()

        Dim mockRecords As New List(Of SalesRecord)


        Dim record1 As New SalesRecord()
        record1.CustomerID = "C001"
        record1.Name = "Ann Dominique C. Estrada"
        record1.DateInstalled = #2025-01-15#
        record1.PlanType = "Basic 25Mbps"
        record1.MonthlyRate = 700D
        mockRecords.Add(record1)

        Dim record2 As New SalesRecord()
        record2.CustomerID = "C002"
        record2.Name = "Jamaica Ramores"
        record2.DateInstalled = #2025-02-23#
        record2.PlanType = "Standard 50Mbps"
        record2.MonthlyRate = 1000D
        mockRecords.Add(record2)


        dgvRecentSales.DataSource = mockRecords
        dgvRecentSales.ClearSelection()

    End Sub

    Private Sub salesview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateDropdowns()

        Me.CBPlanType.SelectedIndex = 0 ' Defaults to "All Plans"
        Me.CBDateRange.SelectedIndex = 0

        UpdateSalesLabel()

        LoadRecentSales_MOCK()

    End Sub

End Class
Public Class SalesRecord

    Public Property CustomerID As String

    Public Property Name As String

    Public Property DateInstalled As Date

    Public Property PlanType As String

    Public Property MonthlyRate As Decimal

End Class
