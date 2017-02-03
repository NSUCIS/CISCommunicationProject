Imports System.Data.OleDb
Public Class frmAddFacultyContact
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myConnection = New OleDbConnection
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\CIS Internal and External Communications\CIS Internal and External Communications\CIS Communications Contacts.accdb"

        Dim InsertQuery As String
        InsertQuery = "INSERT INTO [Faculty] ([Last Name], [First Name], [Position], [E-mail Address], [Business Phone]) VALUES (@lname,@fname,@position,@email,@phone)"
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, myConnection)
        cmd.Parameters.AddWithValue("@lname", txtLName.Text)
        cmd.Parameters.AddWithValue("@fname", txtFName.Text)
        cmd.Parameters.AddWithValue("@position", txtPosition.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
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
        da = New OleDbDataAdapter("Select * from [Faculty]", myConnection)
        da.Fill(ds, "Faculty")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        frmCISCommunications.dgvFaculty.DataSource = view

        Me.Close()

    End Sub
End Class