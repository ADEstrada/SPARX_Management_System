Imports System.Configuration
Imports MySqlConnector

Public Class Profile

    Public CurrentCustomerId As Integer
    Public CurrentFirstName As String
    Public CurrentLastName As String
    Public CurrentEmail As String

    Private ReadOnly CONNECTION_STRING As String =
        ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all subscriber data from database
        LoadSubscriberData()
    End Sub

    Private Sub LoadSubscriberData()
        ' If we have basic info, use it, otherwise load from DB
        If CurrentCustomerId > 0 Then
            Try
                Using conn As New MySqlConnection(CONNECTION_STRING)
                    conn.Open()

                    ' Query all customer information
                    Dim query As String = "SELECT first_name, last_name, email_address, contact_number, " &
                                          "billing_address, installation_address, plan_type, monthly_rate, account_status " &
                                          "FROM customer WHERE customer_id = @customerId"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@customerId", CurrentCustomerId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Personal Information
                                Dim firstName As String = If(reader("first_name") IsNot DBNull.Value, reader("first_name").ToString(), "")
                                Dim lastName As String = If(reader("last_name") IsNot DBNull.Value, reader("last_name").ToString(), "")
                                Dim email As String = If(reader("email_address") IsNot DBNull.Value, reader("email_address").ToString(), "")
                                Dim phone As String = If(reader("contact_number") IsNot DBNull.Value, reader("contact_number").ToString(), "")

                                ' Header info
                                HelloLbl.Text = "Hello, " & firstName & "!"
                                UserFNLbl.Text = firstName
                                UserLNLbl.Text = lastName
                                UserEmailLbl.Text = email
                                UserPhoneLbl.Text = phone

                                ' Address Information - Parse installation_address
                                Dim installationAddress As String = If(reader("installation_address") IsNot DBNull.Value, reader("installation_address").ToString(), "")
                                ParseAndDisplayAddress(installationAddress)

                                ' Update CurrentFirstName, CurrentLastName, CurrentEmail if they were empty
                                If String.IsNullOrEmpty(CurrentFirstName) Then CurrentFirstName = firstName
                                If String.IsNullOrEmpty(CurrentLastName) Then CurrentLastName = lastName
                                If String.IsNullOrEmpty(CurrentEmail) Then CurrentEmail = email
                            Else
                                ' Fallback to stored values if DB query fails
                                HelloLbl.Text = "Hello, " & CurrentFirstName & "!"
                                UserFNLbl.Text = CurrentFirstName
                                UserLNLbl.Text = CurrentLastName
                                UserEmailLbl.Text = CurrentEmail
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading subscriber data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Fallback to stored values
                HelloLbl.Text = "Hello, " & CurrentFirstName & "!"
                UserFNLbl.Text = CurrentFirstName
                UserLNLbl.Text = CurrentLastName
                UserEmailLbl.Text = CurrentEmail
            End Try
        Else
            ' Fallback to stored values if no customer ID
            HelloLbl.Text = "Hello, " & CurrentFirstName & "!"
            UserFNLbl.Text = CurrentFirstName
            UserLNLbl.Text = CurrentLastName
            UserEmailLbl.Text = CurrentEmail
        End If
    End Sub

    Private Sub ParseAndDisplayAddress(addressString As String)
        ' Parse address string and populate address fields
        ' Address format may vary, so we'll try to parse common formats
        ' For now, we'll split by common delimiters or store as-is
        
        If String.IsNullOrEmpty(addressString) OrElse addressString = "Default Installation Address" Then
            ' Set default/empty values
            UserCountryLbl.Text = ""
            UserProvinceLbl.Text = ""
            UserMunLbl.Text = ""
            UserBrgyLbl.Text = ""
            UserLandmarkLbl.Text = ""
        Else
            ' Try to parse address - common format might be: "Street, Barangay, Municipality, Province, Country"
            ' Or it might be stored as full text. For now, display the full address in landmark
            ' If you have a specific format, you can parse it here
            
            ' Split by comma if it's comma-separated
            Dim addressParts As String() = addressString.Split(","c)
            
            If addressParts.Length >= 5 Then
                ' Assume format: Street, Barangay, Municipality, Province, Country
                UserLandmarkLbl.Text = addressParts(0).Trim()
                UserBrgyLbl.Text = addressParts(1).Trim()
                UserMunLbl.Text = addressParts(2).Trim()
                UserProvinceLbl.Text = addressParts(3).Trim()
                UserCountryLbl.Text = addressParts(4).Trim()
            ElseIf addressParts.Length >= 4 Then
                ' Assume format: Barangay, Municipality, Province, Country
                UserBrgyLbl.Text = addressParts(0).Trim()
                UserMunLbl.Text = addressParts(1).Trim()
                UserProvinceLbl.Text = addressParts(2).Trim()
                UserCountryLbl.Text = addressParts(3).Trim()
                UserLandmarkLbl.Text = ""
            Else
                ' Store entire address as landmark if format is unknown
                UserLandmarkLbl.Text = addressString
                UserCountryLbl.Text = ""
                UserProvinceLbl.Text = ""
                UserMunLbl.Text = ""
                UserBrgyLbl.Text = ""
            End If
        End If
    End Sub
    Private Sub PanelRound3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub EditInfoBtn_Click(sender As Object, e As EventArgs) Handles EditInfoBtn.Click
        Dim editInfoForm As New EditInfo()
        Dim result As DialogResult = editInfoForm.ShowDialog()
        editInfoForm.Dispose()
    End Sub

    Private Sub EditAddressBtn_Click(sender As Object, e As EventArgs) Handles EditAddressBtn.Click
        Dim editAddressForm As New EditAddress()
        Dim result As DialogResult = editAddressForm.ShowDialog()
        editAddressForm.Dispose()
    End Sub
End Class
