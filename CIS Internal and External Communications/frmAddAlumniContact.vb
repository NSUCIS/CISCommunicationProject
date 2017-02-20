Imports System.Data.OleDb
Public Class frmAddAlumniContact
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myConnection = New OleDbConnection
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\CIS Internal and External Communications\CIS Internal and External Communications\CIS Communications Contacts.accdb"

        Dim InsertQuery As String
        InsertQuery = "INSERT INTO [Alumni] ([Last Name], [First Name], [City], [State], [Email], [Major], [Degree], [Graduation Year]) VALUES (@lname,@fname,@city,@state,@email,@major,@degree,@gradyr)"
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, myConnection)
        cmd.Parameters.AddWithValue("@lname", txtLName.Text)
        cmd.Parameters.AddWithValue("@fname", txtFName.Text)
        cmd.Parameters.AddWithValue("@city", txtCity.Text)
        cmd.Parameters.AddWithValue("@state", txtState.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@major", txtMajor.Text)
        cmd.Parameters.AddWithValue("@degree", txtDegree.Text)
        cmd.Parameters.AddWithValue("@gradyr", txtGraduationYear.Text)

        cmd.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("Your entry has been recorded.")

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
        frmCISCommunications.dgvAlumni.DataSource = view

        Me.Close()
    End Sub
End Class