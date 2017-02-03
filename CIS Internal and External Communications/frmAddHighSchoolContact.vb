Imports System.Data.OleDb
Public Class frmAddHighSchoolContact
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection = New OleDbConnection
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\CIS Internal and External Communications\CIS Internal and External Communications\CIS Communications Contacts.accdb"

        Dim InsertQuery As String
        InsertQuery = "INSERT INTO [High Schools] ([School Name], [Person of Contact], [Phone Number]) VALUES (@name,@contact,@phone)"
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, myConnection)
        cmd.Parameters.AddWithValue("@name", txtSchoolName.Text)
        cmd.Parameters.AddWithValue("@contact", txtPersonofContact.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
        cmd.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("Your entry has been recorded.")

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
        frmCISCommunications.dgvHighSchool.DataSource = view

        Me.Close()
    End Sub
End Class