Imports System.Data.OleDb
Public Class frmAddFacultyContact
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InsertQuery As String = "INSERT INTO [Faculty] ([Last Name], [First Name], [Position], [E-mail Address], [Business Phone]) VALUES (@lname,@fname,@position,@email,@phone)"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
        cmd.Parameters.AddWithValue("@lname", txtLName.Text)
        cmd.Parameters.AddWithValue("@fname", txtFName.Text)
        cmd.Parameters.AddWithValue("@position", txtPosition.Text)
        cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
        frmCISCommunications.db.Add(cmd)
        Dim name As String = "Faculty"
        MessageBox.Show("Your entry has been recorded.")
        frmCISCommunications.dgvDict(name).DataSource = frmCISCommunications.db.FillTable(name)
        Me.Close()
    End Sub
End Class