Imports System.Data.OleDb
Public Class frmAddMajorContact
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InsertQuery As String = "INSERT INTO [Majors] ([Last Name], [First Name], [E-mail Address]) VALUES (@lname,@fname,@email)"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
        cmd.Parameters.AddWithValue("@lname", txtLName.Text)
        cmd.Parameters.AddWithValue("@fname", txtFName.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        frmCISCommunications.db.Add(cmd)
        Dim name As String = "Majors"
        MessageBox.Show("Your entry has been recorded.")
        frmCISCommunications.dgvDict(name).DataSource = frmCISCommunications.db.FillTable(name)
        Me.Close()
    End Sub
End Class