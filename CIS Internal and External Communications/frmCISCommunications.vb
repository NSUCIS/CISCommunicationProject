﻿Imports System.Data.OleDb
Public Class frmCISCommunications

    Public db As DBManager
    Public dgvDict As Dictionary(Of String, DataGridView) = New Dictionary(Of String, DataGridView)
    Private nRows As Integer = 0
    Private newpage As Boolean = True

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
            dgvDict(name).ClearSelection()
        Next

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dgv As DataGridView = determineCurrentDGV()
        If dgv.SelectedRows IsNot Nothing Then
            Dim selView As DataGridView = New DataGridView()
            Dim selColms As DataGridViewColumnCollection = selView.Columns
            For Each col As DataGridViewColumn In dgv.Columns
                selColms.Add(col.Name, col.HeaderText)
            Next
            For Each dr As DataGridViewRow In dgv.SelectedRows
                Dim r As DataGridViewRow = CType(dr.Clone(), DataGridViewRow)
                For i As Int32 = 0 To dr.Cells.Count - 1
                    r.Cells(i).Value = dr.Cells(i).Value
                Next
                selView.Rows.Add(r)
            Next
            dgv = selView
            dgv.Sort(dgv.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End If
        Dim prtRows As DataGridViewRowCollection = dgv.Rows
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            'row = dgv.Rows(nRows)
            row = prtRows(nRows)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgv.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgv.Columns(cell.ColumnIndex).HeaderText,
                                            dgv.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = nRows To dgv.RowCount - 1
            ' no need to try to print the new row
            If prtRows(thisNDX).IsNewRow Then Exit For

            row = prtRows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgv.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      dgv.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            nRows = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Return
            End If
        Next


    End Sub

    Private Sub tabChangeClearSelection() Handles TabControl1.SelectedIndexChanged
        Dim dgv As DataGridView = determineCurrentDGV()
        dgv.ClearSelection()
    End Sub

    Private Function determineCurrentDGV() As DataGridView
        Dim dgv As DataGridView = Nothing
        If TabControl1.SelectedTab Is tabAdvisoryBoard Then
            dgv = dgvAdvisoryBoard
        ElseIf TabControl1.SelectedTab Is tabISClub Then
            dgv = dgvISC
        ElseIf TabControl1.SelectedTab Is tabFaculty Then
            dgv = dgvFaculty
        ElseIf TabControl1.SelectedTab Is tabEmployers Then
            dgv = dgvEmployers
        ElseIf TabControl1.SelectedTab Is tabAlumni Then
            dgv = dgvAlumni
        ElseIf TabControl1.SelectedTab Is tabMajors Then
            dgv = dgvMajors
        ElseIf TabControl1.SelectedTab Is tabHighschool Then
            dgv = dgvHighSchool
        ElseIf TabControl1.SelectedTab Is tabInternships Then
            dgv = dgvInternships
        ElseIf TabControl1.SelectedTab Is tabNetworkingGroups Then
            dgv = dgvNetworkingGroups
        End If
        Return dgv
    End Function

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