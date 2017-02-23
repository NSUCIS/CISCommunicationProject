Imports System.Data.OleDb
Public Class frmCISCommunications

    Public db As DBManager
    Public dgvDict As Dictionary(Of String, DataGridView) = New Dictionary(Of String, DataGridView)

    Private Sub frmCISCommunications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        db = New DBManager
        'Variables to make filling tables easier in control loops
        Dim tableNames = New String() {"Advisory Board", "Faculty", "ISC", "Majors", "Alumni", "High Schools", "Internships", "Networking Groups"}
        Dim dgvArray = New DataGridView() {dgvAdvisoryBoard, dgvFaculty, dgvISC, dgvMajors, dgvAlumni, dgvHighSchool, dgvInternships, dgvNetworkingGroups}

        For i As Integer = 0 To tableNames.Count - 1 'For all the names of tables...
            dgvDict.Add(tableNames(i), dgvArray(i))  '  Add the entry to the dictionary
        Next
        'Use the dictionary to loop through all the DataGridViews and fill their tables
        For Each name As String In dgvDict.Keys
            dgvDict(name).DataSource = db.FillTable(name)
        Next

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If TabControl1.SelectedTab Is tabAdvisoryBoard Then
            frmAddContactvb.Show()
        ElseIf TabControl1.SelectedTab Is tabISClub Then
            frmAddISCContact.Show()
        ElseIf TabControl1.SelectedTab Is tabFaculty Then
            frmAddFacultyContact.Show()
        ElseIf TabControl1.SelectedTab Is tabEmployers Then
            frmAddEmployersContact.Show()
        ElseIf TabControl1.SelectedTab Is tabAlumni Then
            frmAddAlumniContact.Show()
        ElseIf TabControl1.SelectedTab Is tabMajors Then
            frmAddMajorContact.Show()
        ElseIf TabControl1.SelectedTab Is tabHighschool Then
            frmAddHighSchoolContact.Show()
        ElseIf TabControl1.SelectedTab Is tabInternships Then
            frmAddInternshipContact.Show()
        ElseIf TabControl1.SelectedTab Is tabNetworkingGroups Then
            frmAddNetworkingGroupContact.Show()
        End If
    End Sub

    Private Sub btnDeleteContact_Click(sender As Object, e As EventArgs) Handles btnDeleteContact.Click
        If MessageBox.Show("Are you sure you want to delete this contact?", "Delete Contact", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim name As String = ""
            If TabControl1.SelectedTab Is tabAdvisoryBoard Then
                name = "Advisory Board"
            ElseIf TabControl1.SelectedTab Is tabFaculty Then
                name = "Faculty"
            ElseIf TabControl1.SelectedTab Is tabISClub Then
                name = "ISC"
            ElseIf TabControl1.SelectedTab Is tabMajors Then
                name = "Majors"
            ElseIf TabControl1.SelectedTab Is tabAlumni Then
                name = "Alumni"
            ElseIf TabControl1.SelectedTab Is tabHighschool Then
                name = "High Schools"
            ElseIf TabControl1.SelectedTab Is tabInternships Then
                name = "Internships"
            ElseIf TabControl1.SelectedTab Is tabNetworkingGroups Then
                name = "Networking Groups"
            End If
            If dgvDict.ContainsKey(name) Then 'Make sure name exists as a dgv
                db.Delete(name, dgvDict(name).CurrentRow.Cells(0).Value.ToString)
                dgvAdvisoryBoard.DataSource = db.FillTable(name)
                MessageBox.Show("Contact has been deleted.", "Complete!")
            End If
        ElseIf MessageBox.Show("Are you sure you want to delete this contact?", "Delete Contact", MessageBoxButtons.YesNo) = MsgBoxResult.No Then
            MessageBox.Show("No changes have been made.")
        End If
    End Sub

End Class