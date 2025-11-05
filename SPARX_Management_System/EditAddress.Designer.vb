<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAddress
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
        Panel1 = New Panel()
        LMTxtBox = New TextBox()
        UpdateAddressBtn = New ButtonRounded()
        CancelAddressBtn = New ButtonRounded()
        BrgyTxtBox = New TextBox()
        MunTxtBox = New TextBox()
        ProvinceTxtBox = New TextBox()
        CountryTxtBox = New TextBox()
        EditLMLbl = New Label()
        EditBrgyLbl = New Label()
        EditMunLbl = New Label()
        EditProvineLbl = New Label()
        EditCountryLbl = New Label()
        EditAddressPnl = New Panel()
        Line3 = New Label()
        EditLbl = New Label()
        Panel1.SuspendLayout()
        EditAddressPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LMTxtBox)
        Panel1.Controls.Add(UpdateAddressBtn)
        Panel1.Controls.Add(CancelAddressBtn)
        Panel1.Controls.Add(BrgyTxtBox)
        Panel1.Controls.Add(MunTxtBox)
        Panel1.Controls.Add(ProvinceTxtBox)
        Panel1.Controls.Add(CountryTxtBox)
        Panel1.Controls.Add(EditLMLbl)
        Panel1.Controls.Add(EditBrgyLbl)
        Panel1.Controls.Add(EditMunLbl)
        Panel1.Controls.Add(EditProvineLbl)
        Panel1.Controls.Add(EditCountryLbl)
        Panel1.Controls.Add(EditAddressPnl)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 267)
        Panel1.TabIndex = 0
        ' 
        ' LMTxtBox
        ' 
        LMTxtBox.Location = New Point(128, 193)
        LMTxtBox.Name = "LMTxtBox"
        LMTxtBox.Size = New Size(214, 23)
        LMTxtBox.TabIndex = 44
        ' 
        ' UpdateAddressBtn
        ' 
        UpdateAddressBtn.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        UpdateAddressBtn.DialogResult = DialogResult.OK
        UpdateAddressBtn.FlatAppearance.BorderSize = 0
        UpdateAddressBtn.FlatStyle = FlatStyle.Flat
        UpdateAddressBtn.ForeColor = Color.White
        UpdateAddressBtn.Location = New Point(254, 222)
        UpdateAddressBtn.Name = "UpdateAddressBtn"
        UpdateAddressBtn.Size = New Size(88, 31)
        UpdateAddressBtn.TabIndex = 43
        UpdateAddressBtn.Text = "Update"
        UpdateAddressBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelAddressBtn
        ' 
        CancelAddressBtn.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        CancelAddressBtn.DialogResult = DialogResult.Cancel
        CancelAddressBtn.FlatAppearance.BorderSize = 0
        CancelAddressBtn.FlatStyle = FlatStyle.Flat
        CancelAddressBtn.ForeColor = Color.White
        CancelAddressBtn.Location = New Point(160, 222)
        CancelAddressBtn.Name = "CancelAddressBtn"
        CancelAddressBtn.Size = New Size(88, 31)
        CancelAddressBtn.TabIndex = 42
        CancelAddressBtn.Text = "Cancel"
        CancelAddressBtn.UseVisualStyleBackColor = False
        ' 
        ' BrgyTxtBox
        ' 
        BrgyTxtBox.Location = New Point(128, 159)
        BrgyTxtBox.Name = "BrgyTxtBox"
        BrgyTxtBox.Size = New Size(214, 23)
        BrgyTxtBox.TabIndex = 41
        ' 
        ' MunTxtBox
        ' 
        MunTxtBox.Location = New Point(128, 125)
        MunTxtBox.Name = "MunTxtBox"
        MunTxtBox.Size = New Size(214, 23)
        MunTxtBox.TabIndex = 40
        ' 
        ' ProvinceTxtBox
        ' 
        ProvinceTxtBox.Location = New Point(128, 90)
        ProvinceTxtBox.Name = "ProvinceTxtBox"
        ProvinceTxtBox.Size = New Size(214, 23)
        ProvinceTxtBox.TabIndex = 39
        ' 
        ' CountryTxtBox
        ' 
        CountryTxtBox.Location = New Point(128, 53)
        CountryTxtBox.Name = "CountryTxtBox"
        CountryTxtBox.Size = New Size(214, 23)
        CountryTxtBox.TabIndex = 38
        ' 
        ' EditLMLbl
        ' 
        EditLMLbl.AutoSize = True
        EditLMLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditLMLbl.Location = New Point(15, 194)
        EditLMLbl.Name = "EditLMLbl"
        EditLMLbl.Size = New Size(69, 17)
        EditLMLbl.TabIndex = 37
        EditLMLbl.Text = "Landmark"
        EditLMLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditBrgyLbl
        ' 
        EditBrgyLbl.AutoSize = True
        EditBrgyLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditBrgyLbl.Location = New Point(15, 159)
        EditBrgyLbl.Name = "EditBrgyLbl"
        EditBrgyLbl.Size = New Size(65, 17)
        EditBrgyLbl.TabIndex = 36
        EditBrgyLbl.Text = "Barangay"
        EditBrgyLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditMunLbl
        ' 
        EditMunLbl.AutoSize = True
        EditMunLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditMunLbl.Location = New Point(15, 126)
        EditMunLbl.Name = "EditMunLbl"
        EditMunLbl.Size = New Size(85, 17)
        EditMunLbl.TabIndex = 35
        EditMunLbl.Text = "Municipality"
        EditMunLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditProvineLbl
        ' 
        EditProvineLbl.AutoSize = True
        EditProvineLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditProvineLbl.Location = New Point(15, 91)
        EditProvineLbl.Name = "EditProvineLbl"
        EditProvineLbl.Size = New Size(61, 17)
        EditProvineLbl.TabIndex = 34
        EditProvineLbl.Text = "Province"
        EditProvineLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditCountryLbl
        ' 
        EditCountryLbl.AutoSize = True
        EditCountryLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditCountryLbl.Location = New Point(15, 57)
        EditCountryLbl.Name = "EditCountryLbl"
        EditCountryLbl.Size = New Size(58, 17)
        EditCountryLbl.TabIndex = 33
        EditCountryLbl.Text = "Country"
        EditCountryLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditAddressPnl
        ' 
        EditAddressPnl.Controls.Add(Line3)
        EditAddressPnl.Controls.Add(EditLbl)
        EditAddressPnl.Location = New Point(3, 2)
        EditAddressPnl.Name = "EditAddressPnl"
        EditAddressPnl.Size = New Size(509, 43)
        EditAddressPnl.TabIndex = 32
        ' 
        ' Line3
        ' 
        Line3.AutoSize = True
        Line3.Location = New Point(-3, 28)
        Line3.Name = "Line3"
        Line3.Size = New Size(517, 15)
        Line3.TabIndex = 4
        Line3.Text = "______________________________________________________________________________________________________"
        ' 
        ' EditLbl
        ' 
        EditLbl.AutoSize = True
        EditLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditLbl.Location = New Point(12, 9)
        EditLbl.Name = "EditLbl"
        EditLbl.Size = New Size(104, 21)
        EditLbl.TabIndex = 2
        EditLbl.Text = "Edit Address"
        EditLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditAddress
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(373, 263)
        Controls.Add(Panel1)
        Name = "EditAddress"
        Text = "EditAddress"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        EditAddressPnl.ResumeLayout(False)
        EditAddressPnl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ChangePassBtn As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LMTxtBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UpdateAddressBtn As ButtonRounded
    Friend WithEvents CancelAddressBtn As ButtonRounded
    Friend WithEvents BrgyTxtBox As TextBox
    Friend WithEvents MunTxtBox As TextBox
    Friend WithEvents ProvinceTxtBox As TextBox
    Friend WithEvents CountryTxtBox As TextBox
    Friend WithEvents EditLMLbl As Label
    Friend WithEvents EditBrgyLbl As Label
    Friend WithEvents EditMunLbl As Label
    Friend WithEvents EditProvineLbl As Label
    Friend WithEvents EditCountryLbl As Label
    Friend WithEvents EditAddressPnl As Panel
    Friend WithEvents Line3 As Label
    Friend WithEvents EditLbl As Label
End Class
