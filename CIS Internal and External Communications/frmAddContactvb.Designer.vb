<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddContactvb
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ISCTableAdapter = New CIS_Internal_and_External_Communications.CIS_Communications_ContactsDataSetTableAdapters.ISCTableAdapter()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Title:"
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtFName.Location = New System.Drawing.Point(121, 31)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(162, 26)
        Me.txtFName.TabIndex = 1
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtLName.Location = New System.Drawing.Point(121, 67)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(162, 26)
        Me.txtLName.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTitle.Location = New System.Drawing.Point(86, 34)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(238, 26)
        Me.txtTitle.TabIndex = 5
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmailAddress.Location = New System.Drawing.Point(121, 141)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(209, 26)
        Me.txtEmailAddress.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ISCTableAdapter
        '
        Me.ISCTableAdapter.ClearBeforeFill = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPhoneNumber.Location = New System.Drawing.Point(121, 103)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(136, 26)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Phone Number:"
        '
        'txtBusiness
        '
        Me.txtBusiness.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtBusiness.Location = New System.Drawing.Point(86, 74)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(238, 26)
        Me.txtBusiness.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Company:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddress)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 190)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtBusiness)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 120)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Information"
        '
        'frmAddContactvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(374, 476)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddContactvb"
        Me.Text = "New Advisory Board Member"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ISCTableAdapter As CIS_Internal_and_External_Communications.CIS_Communications_ContactsDataSetTableAdapters.ISCTableAdapter
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBusiness As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
