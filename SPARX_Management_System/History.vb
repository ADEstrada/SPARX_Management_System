Imports System.Configuration
Imports MySqlConnector
Imports System.Linq

Public Class History

    Public CurrentCustomerId As Integer

    Private ReadOnly CONNECTION_STRING As String =
        ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString

    Private allHistoryData As New List(Of HistoryRecord)()

    Private Class HistoryRecord
        Public Property TransactionDate As DateTime
        Public Property TransactionType As String
        Public Property ServiceID As String
        Public Property StartDate As DateTime
        Public Property EndDate As DateTime
        Public Property MonthlyRate As Decimal
        Public Property PaymentMethod As String
        Public Property Status As String
    End Class

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize combo boxes
        InitializeFilters()
        ' Load history data for the current user
        LoadHistoryData()
    End Sub

    Private Sub InitializeFilters()
        ' Populate Date Range ComboBox
        DateComboBox.Items.Clear()
        DateComboBox.Items.Add("All")
        DateComboBox.Items.Add("Last 7 Days")
        DateComboBox.Items.Add("Last 30 Days")
        DateComboBox.Items.Add("Last 3 Months")
        DateComboBox.Items.Add("Last 6 Months")
        DateComboBox.Items.Add("Last Year")
        DateComboBox.SelectedIndex = 0 ' Default to "All"

        ' Populate Service ComboBox
        ServiceComboBox.Items.Clear()
        ServiceComboBox.Items.Add("All")
        ServiceComboBox.Items.Add("Installation")
        ServiceComboBox.Items.Add("Billing")
        ServiceComboBox.Items.Add("Service Request")
        ServiceComboBox.Items.Add("Maintenance")
        ServiceComboBox.SelectedIndex = 0 ' Default to "All"

        ' Populate Status ComboBox
        StatusComboBox.Items.Clear()
        StatusComboBox.Items.Add("All")
        StatusComboBox.Items.Add("Completed")
        StatusComboBox.Items.Add("Pending")
        StatusComboBox.Items.Add("Paid")
        StatusComboBox.Items.Add("Unpaid")
        StatusComboBox.Items.Add("In Progress")
        StatusComboBox.Items.Add("Cancelled")
        StatusComboBox.SelectedIndex = 0 ' Default to "All"

        ' Add event handlers for filtering
        AddHandler DateComboBox.SelectedIndexChanged, AddressOf FilterChanged
        AddHandler ServiceComboBox.SelectedIndexChanged, AddressOf FilterChanged
        AddHandler StatusComboBox.SelectedIndexChanged, AddressOf FilterChanged
    End Sub

    Private Sub FilterChanged(sender As Object, e As EventArgs)
        ' Reload data with current filters
        LoadHistoryData()
    End Sub

    Private Sub LoadHistoryData()
        ' Clear existing data
        HistoryTable.Rows.Clear()
        allHistoryData.Clear()

        If CurrentCustomerId <= 0 Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' Build query based on available tables
                ' This query combines billing and service_request/installation data
                ' Adjust table names and columns based on your actual database schema
                Dim query As String = BuildHistoryQuery()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@customerId", CurrentCustomerId)

                    ' Add date range filter
                    Dim dateFilter As String = GetDateRangeFilter()
                    If Not String.IsNullOrEmpty(dateFilter) Then
                        cmd.Parameters.AddWithValue("@startDate", dateFilter)
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim record As New HistoryRecord()
                            record.TransactionDate = If(reader("transaction_date") IsNot DBNull.Value, Convert.ToDateTime(reader("transaction_date")), DateTime.Now)
                            record.TransactionType = If(reader("transaction_type") IsNot DBNull.Value, reader("transaction_type").ToString(), "")
                            record.ServiceID = If(reader("service_id") IsNot DBNull.Value, reader("service_id").ToString(), "")
                            record.StartDate = If(reader("start_date") IsNot DBNull.Value, Convert.ToDateTime(reader("start_date")), DateTime.Now)
                            record.EndDate = If(reader("end_date") IsNot DBNull.Value, Convert.ToDateTime(reader("end_date")), DateTime.Now)
                            record.MonthlyRate = If(reader("monthly_rate") IsNot DBNull.Value, Convert.ToDecimal(reader("monthly_rate")), 0)
                            record.PaymentMethod = If(reader("payment_method") IsNot DBNull.Value, reader("payment_method").ToString(), "")
                            record.Status = If(reader("status") IsNot DBNull.Value, reader("status").ToString(), "")

                            allHistoryData.Add(record)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' If database query fails, try alternative approach or show error
            MessageBox.Show("Error loading history data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Fallback: Load dummy data for testing
            LoadDummyData()
            Return
        End Try

        ' Apply filters and display
        ApplyFiltersAndDisplay()
    End Sub

    Private Function BuildHistoryQuery() As String
        ' This builds a query that combines payment and service data
        ' Adjust based on your actual database schema
        ' Assuming tables: payment, service_request, installation

        Dim query As String = "
            SELECT 
                COALESCE(p.date_of_payment, sr.request_date, i.installation_date) AS transaction_date,
                CASE 
                    WHEN p.Payment_id IS NOT NULL THEN 'Billing'
                    WHEN sr.service_request_id IS NOT NULL THEN 'Service Request'
                    WHEN i.installation_id IS NOT NULL THEN 'Installation'
                    ELSE 'Other'
                END AS transaction_type,
                COALESCE(p.Payment_id, sr.service_request_id, i.installation_id) AS service_id,
                COALESCE(p.billing_start_date, sr.start_date, i.installation_date) AS start_date,
                COALESCE(p.billing_end_date, sr.end_date, i.completion_date) AS end_date,
                COALESCE(p.amount_paid, c.monthly_rate, 0) AS monthly_rate,
                COALESCE(p.payment_method, 'N/A') AS payment_method,
                COALESCE(p.payment_status, sr.status, i.status, 'Unknown') AS status
            FROM customer c
            LEFT JOIN payment p ON c.customer_id = p.customer_id
            LEFT JOIN `Service.Request` sr ON c.customer_id = sr.customer_id
            LEFT JOIN installation i ON c.customer_id = i.customer_id
            WHERE c.customer_id = @customerId
            AND (
                p.Payment_id IS NOT NULL OR 
                sr.service_request_id IS NOT NULL OR 
                i.installation_id IS NOT NULL
            )"

        ' Add date range filter if selected
        Dim dateFilter As String = GetDateRangeFilter()
        If Not String.IsNullOrEmpty(dateFilter) Then
            query &= " AND COALESCE(p.date_of_payment, sr.request_date, i.installation_date) >= @startDate"
        End If

        ' Add service filter if selected
        Dim serviceFilter As String = GetServiceFilter()
        If Not String.IsNullOrEmpty(serviceFilter) Then
            query &= " AND " & serviceFilter
        End If

        ' Add status filter if selected
        Dim statusFilter As String = GetStatusFilter()
        If Not String.IsNullOrEmpty(statusFilter) Then
            query &= " AND " & statusFilter
        End If

        query &= " ORDER BY transaction_date DESC"

        ' Alternative simpler query if tables don't exist - adjust as needed
        ' This is a fallback structure - modify based on your actual schema
        Return query
    End Function

    Private Function GetDateRangeFilter() As String
        Dim selectedRange As String = If(DateComboBox.SelectedItem IsNot Nothing, DateComboBox.SelectedItem.ToString(), "All")

        If selectedRange = "All" Then
            Return Nothing
        End If

        Dim startDate As DateTime = DateTime.Now

        Select Case selectedRange
            Case "Last 7 Days"
                startDate = DateTime.Now.AddDays(-7)
            Case "Last 30 Days"
                startDate = DateTime.Now.AddDays(-30)
            Case "Last 3 Months"
                startDate = DateTime.Now.AddMonths(-3)
            Case "Last 6 Months"
                startDate = DateTime.Now.AddMonths(-6)
            Case "Last Year"
                startDate = DateTime.Now.AddYears(-1)
        End Select

        Return startDate.ToString("yyyy-MM-dd")
    End Function

    Private Function GetServiceFilter() As String
        Dim selectedService As String = If(ServiceComboBox.SelectedItem IsNot Nothing, ServiceComboBox.SelectedItem.ToString(), "All")

        If selectedService = "All" Then
            Return Nothing
        End If

        ' Map service type to database condition
        Select Case selectedService
            Case "Installation"
                Return "i.installation_id IS NOT NULL"
            Case "Billing"
                Return "p.Payment_id IS NOT NULL"
            Case "Service Request"
                Return "sr.service_request_id IS NOT NULL"
            Case "Maintenance"
                Return "sr.service_request_id IS NOT NULL AND sr.service_type = 'Maintenance'"
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetStatusFilter() As String
        Dim selectedStatus As String = If(StatusComboBox.SelectedItem IsNot Nothing, StatusComboBox.SelectedItem.ToString(), "All")

        If selectedStatus = "All" Then
            Return Nothing
        End If

        ' Map status to database condition
        Dim statusCondition As String = "COALESCE(p.payment_status, sr.status, i.status, '') = '" & selectedStatus & "'"
        Return statusCondition
    End Function

    Private Sub ApplyFiltersAndDisplay()
        ' Filter the data based on combo box selections
        Dim filteredData As List(Of HistoryRecord) = allHistoryData.ToList()

        ' Apply date range filter
        Dim selectedDateRange As String = If(DateComboBox.SelectedItem IsNot Nothing, DateComboBox.SelectedItem.ToString(), "All")
        If selectedDateRange <> "All" Then
            Dim startDate As DateTime = GetStartDateForRange(selectedDateRange)
            filteredData = filteredData.Where(Function(r) r.TransactionDate >= startDate).ToList()
        End If

        ' Apply service filter
        Dim selectedService As String = If(ServiceComboBox.SelectedItem IsNot Nothing, ServiceComboBox.SelectedItem.ToString(), "All")
        If selectedService <> "All" Then
            filteredData = filteredData.Where(Function(r) r.TransactionType = selectedService).ToList()
        End If

        ' Apply status filter
        Dim selectedStatus As String = If(StatusComboBox.SelectedItem IsNot Nothing, StatusComboBox.SelectedItem.ToString(), "All")
        If selectedStatus <> "All" Then
            filteredData = filteredData.Where(Function(r) r.Status = selectedStatus).ToList()
        End If

        ' Display filtered data
        For Each record In filteredData
            HistoryTable.Rows.Add(
                record.TransactionDate.ToString("yyyy-MM-dd"),
                record.TransactionType,
                record.ServiceID,
                record.StartDate.ToString("yyyy-MM-dd"),
                record.EndDate.ToString("yyyy-MM-dd"),
                record.MonthlyRate.ToString("N2"),
                record.PaymentMethod,
                record.Status
            )
        Next
    End Sub

    Private Function GetStartDateForRange(range As String) As DateTime
        Select Case range
            Case "Last 7 Days"
                Return DateTime.Now.AddDays(-7)
            Case "Last 30 Days"
                Return DateTime.Now.AddDays(-30)
            Case "Last 3 Months"
                Return DateTime.Now.AddMonths(-3)
            Case "Last 6 Months"
                Return DateTime.Now.AddMonths(-6)
            Case "Last Year"
                Return DateTime.Now.AddYears(-1)
            Case Else
                Return DateTime.MinValue
        End Select
    End Function

    Private Sub LoadDummyData()
        ' Fallback dummy data for testing
        allHistoryData.Add(New HistoryRecord With {
            .TransactionDate = DateTime.Now.AddDays(-5),
            .TransactionType = "Installation",
            .ServiceID = "SVC001",
            .StartDate = DateTime.Now.AddDays(-5),
            .EndDate = DateTime.Now.AddDays(25),
            .MonthlyRate = 1500,
            .PaymentMethod = "Cash",
            .Status = "Completed"
        })
        allHistoryData.Add(New HistoryRecord With {
            .TransactionDate = DateTime.Now.AddDays(-30),
            .TransactionType = "Billing",
            .ServiceID = "SVC002",
            .StartDate = DateTime.Now.AddDays(-30),
            .EndDate = DateTime.Now,
            .MonthlyRate = 1500,
            .PaymentMethod = "Online",
            .Status = "Paid"
        })
        allHistoryData.Add(New HistoryRecord With {
            .TransactionDate = DateTime.Now.AddDays(-60),
            .TransactionType = "Service Request",
            .ServiceID = "SVC003",
            .StartDate = DateTime.Now.AddDays(-60),
            .EndDate = DateTime.Now.AddDays(-30),
            .MonthlyRate = 0,
            .PaymentMethod = "N/A",
            .Status = "Completed"
        })

        ApplyFiltersAndDisplay()
    End Sub

End Class
