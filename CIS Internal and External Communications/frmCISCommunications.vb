Imports System.Data.OleDb
Public Class frmCISCommunications


    Private Sub frmCISCommunications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()

        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        Dim connString As String
        Dim dataSourceString As String
        dataSourceString = "Data Source=" & My.Application.Info.DirectoryPath & "\CIS Communications Contacts.accdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;" & dataSourceString
        myConnection.ConnectionString = connString
        myConnection.Open()

        myConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [Advisory Board]", myConnection)
        da.Fill(ds, "Advisory Board")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dgvAdvisoryBoard.DataSource = view

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [Faculty]", myConnection)
        da.Fill(ds, "Faculty")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        dgvFaculty.DataSource = view1

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [ISC]", myConnection)
        da.Fill(ds, "ISC")
        Dim view2 As New DataView(tables(0))
        source1.DataSource = view2
        dgvISC.DataSource = view2

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [Majors]", myConnection)
        da.Fill(ds, "Majors")
        Dim view3 As New DataView(tables(0))
        source1.DataSource = view3
        dgvMajors.DataSource = view3

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [Alumni]", myConnection)
        da.Fill(ds, "Alumni")
        Dim view4 As New DataView(tables(0))
        source1.DataSource = view4
        dgvOutputAlumni.DataSource = view4

        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [High Schools]", myConnection)
        da.Fill(ds, "High Schools")
        Dim view5 As New DataView(tables(0))
        source1.DataSource = view5
        dgvHighSchool.DataSource = view5

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
        Dim DeleteQuery As String
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\CIS Internal and External Communications\CIS Internal and External Communications\CIS Communications Contacts.accdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString

        If MessageBox.Show("Are you sure you want to delete this contact?", "Delete Contact", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            If TabControl1.SelectedTab Is tabAdvisoryBoard Then
                DeleteQuery = "delete * from [Advisory Board] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvAdvisoryBoard.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [Advisory Board]", myConnection)
                da.Fill(ds, "Advisory Board")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvAdvisoryBoard.DataSource = view
                myConnection.Close()
            ElseIf TabControl1.SelectedTab Is tabISClub Then
                DeleteQuery = "delete * from [ISC] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvISC.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [ISC]", myConnection)
                da.Fill(ds, "ISC")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvISC.DataSource = view
                myConnection.Close()
            ElseIf TabControl1.SelectedTab Is tabFaculty Then
                DeleteQuery = "delete * from [Faculty] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvFaculty.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [Faculty]", myConnection)
                da.Fill(ds, "Faculty")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvFaculty.DataSource = view
                myConnection.Close()
                'ElseIf TabControl1.SelectedTab Is tabEmployers Then
                '     doesnt exist yet
            ElseIf TabControl1.SelectedTab Is tabAlumni Then
                DeleteQuery = "delete * from [Alumni] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvOutputAlumni.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [Alumni]", myConnection)
                da.Fill(ds, "Alumni")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvOutputAlumni.DataSource = view
                myConnection.Close()
            ElseIf TabControl1.SelectedTab Is tabMajors Then
                DeleteQuery = "delete * from [Majors] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvMajors.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [Majors]", myConnection)
                da.Fill(ds, "Majors")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvAdvisoryBoard.DataSource = view
                myConnection.Close()
            ElseIf TabControl1.SelectedTab Is tabHighschool Then
                DeleteQuery = "delete * from [High Schools] where ID = @ID"
                Dim cmd As OleDbCommand = New OleDbCommand(DeleteQuery, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@ID", dgvHighSchool.CurrentRow.Cells(0).Value.ToString)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim tables As DataTableCollection
                Dim source1 As New BindingSource
                ds = New DataSet
                tables = ds.Tables
                da = New OleDbDataAdapter("Select * from [High Schools]", myConnection)
                da.Fill(ds, "High Schools")
                Dim view As New DataView(tables(0))
                source1.DataSource = view
                Me.dgvHighSchool.DataSource = view
                myConnection.Close()
                'ElseIf TabControl1.SelectedTab Is tabInternships Then
                '   doesnt exist yet
                'ElseIf TabControl1.SelectedTab Is tabNetworkingGroups Then
                '    doesnt exist yet
            End If
            MessageBox.Show("Contact has been deleted.", "Complete!")
        ElseIf MessageBox.Show("Are you sure you want to delete this contact?", "Delete Contact", MessageBoxButtons.YesNo) = MsgBoxResult.No Then
            MessageBox.Show("No changes have been made.")
        End If

    End Sub


End Class