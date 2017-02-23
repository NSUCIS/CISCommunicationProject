Imports System.Data.OleDb
Public Class frmAddAlumniContact
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InsertQuery As String = "INSERT INTO [Alumni] ([Last Name], [First Name], [City], [State], [Email], [Major], [Degree], [Graduation Year]) VALUES (@lname,@fname,@city,@state,@email,@major,@degree,@gradyr)"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
        cmd.Parameters.AddWithValue("@lname", txtLName.Text)
        cmd.Parameters.AddWithValue("@fname", txtFName.Text)
        cmd.Parameters.AddWithValue("@city", txtCity.Text)
        cmd.Parameters.AddWithValue("@state", txtState.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@major", txtMajor.Text)
        cmd.Parameters.AddWithValue("@degree", txtDegree.Text)
        cmd.Parameters.AddWithValue("@gradyr", txtGraduationYear.Text)
        frmCISCommunications.db.Add(cmd)
        Dim name As String = "Alumni"
        MessageBox.Show("Your entry has been recorded.")
        frmCISCommunications.dgvDict(name).DataSource = frmCISCommunications.db.FillTable(name)
        Me.Close()
    End Sub
End Class