﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCISCommunications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCISCommunications))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.tabAlumni = New System.Windows.Forms.TabPage()
        Me.dgvOutputAlumni = New System.Windows.Forms.DataGridView()
        Me.tabFaculty = New System.Windows.Forms.TabPage()
        Me.dgvFaculty = New System.Windows.Forms.DataGridView()
        Me.tabISClub = New System.Windows.Forms.TabPage()
        Me.dgvISC = New System.Windows.Forms.DataGridView()
        Me.tabAdvisoryBoard = New System.Windows.Forms.TabPage()
        Me.dgvAdvisoryBoard = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabEmployers = New System.Windows.Forms.TabPage()
        Me.dgvEmployers = New System.Windows.Forms.DataGridView()
        Me.tabMajors = New System.Windows.Forms.TabPage()
        Me.dgvMajors = New System.Windows.Forms.DataGridView()
        Me.tabHighschool = New System.Windows.Forms.TabPage()
        Me.dgvHighSchool = New System.Windows.Forms.DataGridView()
        Me.tabInternships = New System.Windows.Forms.TabPage()
        Me.dgvInternships = New System.Windows.Forms.DataGridView()
        Me.tabNetworkingGroups = New System.Windows.Forms.TabPage()
        Me.dgvNetworkingGroups = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeleteContact = New System.Windows.Forms.Button()
        Me.tabAlumni.SuspendLayout()
        CType(Me.dgvOutputAlumni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFaculty.SuspendLayout()
        CType(Me.dgvFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabISClub.SuspendLayout()
        CType(Me.dgvISC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdvisoryBoard.SuspendLayout()
        CType(Me.dgvAdvisoryBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabEmployers.SuspendLayout()
        CType(Me.dgvEmployers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMajors.SuspendLayout()
        CType(Me.dgvMajors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHighschool.SuspendLayout()
        CType(Me.dgvHighSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInternships.SuspendLayout()
        CType(Me.dgvInternships, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNetworkingGroups.SuspendLayout()
        CType(Me.dgvNetworkingGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(30, 318)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 27)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add a Contact"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(470, 318)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 27)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print Contact List"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.Location = New System.Drawing.Point(690, 318)
        Me.btnEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(120, 27)
        Me.btnEmail.TabIndex = 4
        Me.btnEmail.Text = "Email Contact"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'tabAlumni
        '
        Me.tabAlumni.Controls.Add(Me.dgvOutputAlumni)
        Me.tabAlumni.Location = New System.Drawing.Point(4, 23)
        Me.tabAlumni.Margin = New System.Windows.Forms.Padding(2)
        Me.tabAlumni.Name = "tabAlumni"
        Me.tabAlumni.Padding = New System.Windows.Forms.Padding(2)
        Me.tabAlumni.Size = New System.Drawing.Size(784, 224)
        Me.tabAlumni.TabIndex = 3
        Me.tabAlumni.Text = "Alumni"
        Me.tabAlumni.UseVisualStyleBackColor = True
        '
        'dgvOutputAlumni
        '
        Me.dgvOutputAlumni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOutputAlumni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutputAlumni.Location = New System.Drawing.Point(-3, 0)
        Me.dgvOutputAlumni.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOutputAlumni.Name = "dgvOutputAlumni"
        Me.dgvOutputAlumni.RowHeadersVisible = False
        Me.dgvOutputAlumni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOutputAlumni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOutputAlumni.Size = New System.Drawing.Size(787, 226)
        Me.dgvOutputAlumni.TabIndex = 0
        '
        'tabFaculty
        '
        Me.tabFaculty.Controls.Add(Me.dgvFaculty)
        Me.tabFaculty.Location = New System.Drawing.Point(4, 23)
        Me.tabFaculty.Margin = New System.Windows.Forms.Padding(2)
        Me.tabFaculty.Name = "tabFaculty"
        Me.tabFaculty.Padding = New System.Windows.Forms.Padding(2)
        Me.tabFaculty.Size = New System.Drawing.Size(784, 224)
        Me.tabFaculty.TabIndex = 2
        Me.tabFaculty.Text = "Faculty"
        Me.tabFaculty.UseVisualStyleBackColor = True
        '
        'dgvFaculty
        '
        Me.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFaculty.Location = New System.Drawing.Point(-3, 3)
        Me.dgvFaculty.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvFaculty.Name = "dgvFaculty"
        Me.dgvFaculty.RowHeadersVisible = False
        Me.dgvFaculty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFaculty.Size = New System.Drawing.Size(787, 221)
        Me.dgvFaculty.TabIndex = 0
        '
        'tabISClub
        '
        Me.tabISClub.Controls.Add(Me.dgvISC)
        Me.tabISClub.Location = New System.Drawing.Point(4, 23)
        Me.tabISClub.Margin = New System.Windows.Forms.Padding(2)
        Me.tabISClub.Name = "tabISClub"
        Me.tabISClub.Padding = New System.Windows.Forms.Padding(2)
        Me.tabISClub.Size = New System.Drawing.Size(784, 224)
        Me.tabISClub.TabIndex = 1
        Me.tabISClub.Text = "IS Club"
        Me.tabISClub.UseVisualStyleBackColor = True
        '
        'dgvISC
        '
        Me.dgvISC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvISC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvISC.Location = New System.Drawing.Point(-3, 2)
        Me.dgvISC.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvISC.Name = "dgvISC"
        Me.dgvISC.RowHeadersVisible = False
        Me.dgvISC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvISC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvISC.Size = New System.Drawing.Size(785, 226)
        Me.dgvISC.TabIndex = 0
        '
        'tabAdvisoryBoard
        '
        Me.tabAdvisoryBoard.Controls.Add(Me.dgvAdvisoryBoard)
        Me.tabAdvisoryBoard.Location = New System.Drawing.Point(4, 23)
        Me.tabAdvisoryBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.tabAdvisoryBoard.Name = "tabAdvisoryBoard"
        Me.tabAdvisoryBoard.Padding = New System.Windows.Forms.Padding(2)
        Me.tabAdvisoryBoard.Size = New System.Drawing.Size(784, 224)
        Me.tabAdvisoryBoard.TabIndex = 0
        Me.tabAdvisoryBoard.Text = "Advisory Board"
        Me.tabAdvisoryBoard.UseVisualStyleBackColor = True
        '
        'dgvAdvisoryBoard
        '
        Me.dgvAdvisoryBoard.AllowUserToAddRows = False
        Me.dgvAdvisoryBoard.AllowUserToDeleteRows = False
        Me.dgvAdvisoryBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAdvisoryBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdvisoryBoard.Location = New System.Drawing.Point(0, 44)
        Me.dgvAdvisoryBoard.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAdvisoryBoard.Name = "dgvAdvisoryBoard"
        Me.dgvAdvisoryBoard.RowHeadersVisible = False
        Me.dgvAdvisoryBoard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAdvisoryBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdvisoryBoard.Size = New System.Drawing.Size(782, 184)
        Me.dgvAdvisoryBoard.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAdvisoryBoard)
        Me.TabControl1.Controls.Add(Me.tabISClub)
        Me.TabControl1.Controls.Add(Me.tabFaculty)
        Me.TabControl1.Controls.Add(Me.tabAlumni)
        Me.TabControl1.Controls.Add(Me.tabEmployers)
        Me.TabControl1.Controls.Add(Me.tabMajors)
        Me.TabControl1.Controls.Add(Me.tabHighschool)
        Me.TabControl1.Controls.Add(Me.tabInternships)
        Me.TabControl1.Controls.Add(Me.tabNetworkingGroups)
        Me.TabControl1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(26, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 251)
        Me.TabControl1.TabIndex = 1
        '
        'tabEmployers
        '
        Me.tabEmployers.Controls.Add(Me.dgvEmployers)
        Me.tabEmployers.Location = New System.Drawing.Point(4, 23)
        Me.tabEmployers.Margin = New System.Windows.Forms.Padding(2)
        Me.tabEmployers.Name = "tabEmployers"
        Me.tabEmployers.Size = New System.Drawing.Size(784, 224)
        Me.tabEmployers.TabIndex = 4
        Me.tabEmployers.Text = "Employers"
        Me.tabEmployers.UseVisualStyleBackColor = True
        '
        'dgvEmployers
        '
        Me.dgvEmployers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmployers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployers.Location = New System.Drawing.Point(-1, -2)
        Me.dgvEmployers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEmployers.Name = "dgvEmployers"
        Me.dgvEmployers.RowHeadersVisible = False
        Me.dgvEmployers.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvEmployers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployers.Size = New System.Drawing.Size(783, 224)
        Me.dgvEmployers.TabIndex = 1
        '
        'tabMajors
        '
        Me.tabMajors.Controls.Add(Me.dgvMajors)
        Me.tabMajors.Location = New System.Drawing.Point(4, 23)
        Me.tabMajors.Margin = New System.Windows.Forms.Padding(2)
        Me.tabMajors.Name = "tabMajors"
        Me.tabMajors.Size = New System.Drawing.Size(784, 224)
        Me.tabMajors.TabIndex = 5
        Me.tabMajors.Text = "CIS Majors"
        Me.tabMajors.UseVisualStyleBackColor = True
        '
        'dgvMajors
        '
        Me.dgvMajors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMajors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMajors.Location = New System.Drawing.Point(-1, -2)
        Me.dgvMajors.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMajors.Name = "dgvMajors"
        Me.dgvMajors.RowHeadersVisible = False
        Me.dgvMajors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMajors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMajors.Size = New System.Drawing.Size(783, 230)
        Me.dgvMajors.TabIndex = 1
        '
        'tabHighschool
        '
        Me.tabHighschool.Controls.Add(Me.dgvHighSchool)
        Me.tabHighschool.Location = New System.Drawing.Point(4, 23)
        Me.tabHighschool.Margin = New System.Windows.Forms.Padding(2)
        Me.tabHighschool.Name = "tabHighschool"
        Me.tabHighschool.Size = New System.Drawing.Size(784, 224)
        Me.tabHighschool.TabIndex = 6
        Me.tabHighschool.Text = "High School"
        Me.tabHighschool.UseVisualStyleBackColor = True
        '
        'dgvHighSchool
        '
        Me.dgvHighSchool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHighSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHighSchool.Location = New System.Drawing.Point(-1, -2)
        Me.dgvHighSchool.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvHighSchool.Name = "dgvHighSchool"
        Me.dgvHighSchool.RowHeadersVisible = False
        Me.dgvHighSchool.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvHighSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHighSchool.Size = New System.Drawing.Size(783, 226)
        Me.dgvHighSchool.TabIndex = 1
        '
        'tabInternships
        '
        Me.tabInternships.Controls.Add(Me.dgvInternships)
        Me.tabInternships.Location = New System.Drawing.Point(4, 23)
        Me.tabInternships.Margin = New System.Windows.Forms.Padding(2)
        Me.tabInternships.Name = "tabInternships"
        Me.tabInternships.Size = New System.Drawing.Size(784, 224)
        Me.tabInternships.TabIndex = 7
        Me.tabInternships.Text = "Internships"
        Me.tabInternships.UseVisualStyleBackColor = True
        '
        'dgvInternships
        '
        Me.dgvInternships.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInternships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInternships.Location = New System.Drawing.Point(-1, -2)
        Me.dgvInternships.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInternships.Name = "dgvInternships"
        Me.dgvInternships.RowHeadersVisible = False
        Me.dgvInternships.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvInternships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInternships.Size = New System.Drawing.Size(783, 226)
        Me.dgvInternships.TabIndex = 1
        '
        'tabNetworkingGroups
        '
        Me.tabNetworkingGroups.Controls.Add(Me.dgvNetworkingGroups)
        Me.tabNetworkingGroups.Location = New System.Drawing.Point(4, 23)
        Me.tabNetworkingGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.tabNetworkingGroups.Name = "tabNetworkingGroups"
        Me.tabNetworkingGroups.Size = New System.Drawing.Size(784, 224)
        Me.tabNetworkingGroups.TabIndex = 8
        Me.tabNetworkingGroups.Text = "Networking Groups"
        Me.tabNetworkingGroups.UseVisualStyleBackColor = True
        '
        'dgvNetworkingGroups
        '
        Me.dgvNetworkingGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNetworkingGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNetworkingGroups.Location = New System.Drawing.Point(1, -2)
        Me.dgvNetworkingGroups.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNetworkingGroups.Name = "dgvNetworkingGroups"
        Me.dgvNetworkingGroups.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvNetworkingGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNetworkingGroups.Size = New System.Drawing.Size(781, 226)
        Me.dgvNetworkingGroups.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Pristina", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(354, 391)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Generated by:"
        '
        'btnDeleteContact
        '
        Me.btnDeleteContact.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteContact.Location = New System.Drawing.Point(250, 318)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(120, 27)
        Me.btnDeleteContact.TabIndex = 7
        Me.btnDeleteContact.Text = "Delete Contact"
        Me.btnDeleteContact.UseVisualStyleBackColor = True
        '
        'frmCISCommunications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(841, 500)
        Me.Controls.Add(Me.btnDeleteContact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCISCommunications"
        Me.Text = "CIS Communications"
        Me.tabAlumni.ResumeLayout(False)
        CType(Me.dgvOutputAlumni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFaculty.ResumeLayout(False)
        CType(Me.dgvFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabISClub.ResumeLayout(False)
        CType(Me.dgvISC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdvisoryBoard.ResumeLayout(False)
        CType(Me.dgvAdvisoryBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabEmployers.ResumeLayout(False)
        CType(Me.dgvEmployers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMajors.ResumeLayout(False)
        CType(Me.dgvMajors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHighschool.ResumeLayout(False)
        CType(Me.dgvHighSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInternships.ResumeLayout(False)
        CType(Me.dgvInternships, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNetworkingGroups.ResumeLayout(False)
        CType(Me.dgvNetworkingGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents tabAlumni As System.Windows.Forms.TabPage
    Friend WithEvents dgvOutputAlumni As System.Windows.Forms.DataGridView
    Friend WithEvents tabFaculty As System.Windows.Forms.TabPage
    Friend WithEvents dgvFaculty As System.Windows.Forms.DataGridView
    Friend WithEvents tabISClub As System.Windows.Forms.TabPage
    Friend WithEvents dgvISC As System.Windows.Forms.DataGridView
    Friend WithEvents tabAdvisoryBoard As System.Windows.Forms.TabPage
    Friend WithEvents dgvAdvisoryBoard As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabEmployers As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabMajors As System.Windows.Forms.TabPage
    Friend WithEvents tabHighschool As System.Windows.Forms.TabPage
    Friend WithEvents tabInternships As System.Windows.Forms.TabPage
    Friend WithEvents dgvEmployers As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMajors As System.Windows.Forms.DataGridView
    Friend WithEvents dgvHighSchool As System.Windows.Forms.DataGridView
    Friend WithEvents dgvInternships As System.Windows.Forms.DataGridView
    Friend WithEvents tabNetworkingGroups As System.Windows.Forms.TabPage
    Friend WithEvents dgvNetworkingGroups As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteContact As System.Windows.Forms.Button
End Class
