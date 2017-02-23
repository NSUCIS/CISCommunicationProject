Imports System.Data.OleDb
Public Class frmAddHighSchoolContact
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InsertQuery As String = "INSERT INTO [High Schools] ([School Name], [Person of Contact], [Phone Number]) VALUES (@name,@contact,@phone)"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery)
        cmd.Parameters.AddWithValue("@name", txtSchoolName.Text)
        cmd.Parameters.AddWithValue("@contact", txtPersonofContact.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
        frmCISCommunications.db.Add(cmd)
        Dim name As String = "High Schools"
        MessageBox.Show("Your entry has been recorded.")
        frmCISCommunications.dgvDict(name).DataSource = frmCISCommunications.db.FillTable(name)
        Me.Close()
    End Sub
End Class