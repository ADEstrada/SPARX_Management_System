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
        LblSalesReport = New Label()
        SuspendLayout()
        ' 
        ' LblSalesReport
        ' 
        LblSalesReport.AutoSize = True
        LblSalesReport.Font = New Font("Verdana", 12F)
        LblSalesReport.Location = New Point(23, 24)
        LblSalesReport.Name = "LblSalesReport"
        LblSalesReport.Size = New Size(140, 25)
        LblSalesReport.TabIndex = 5
        LblSalesReport.Text = "Sales Report"
        ' 
        ' SalesSuperAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1246, 808)
        Controls.Add(LblSalesReport)
        Name = "SalesSuperAdmin"
        Text = "SalesSuperAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblSalesReport As Label
End Class
