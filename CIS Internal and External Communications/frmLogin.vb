Public Class frmLogin

    Public username As String
    Dim numTries As Integer
    Dim idVerified As Boolean = True

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "") Or (txtPassword.Text = "") Then
            MessageBox.Show("You must enter both a user name and a password.")
        Else
            If Confirm(txtUsername.Text, txtPassword.Text) Then
                idVerified = True
                username = txtUsername.Text
                Me.Close()
            Else
                MessageBox.Show("Improper user name or password.")
                txtPassword.Clear()
                txtUsername.Clear()
            End If
        End If
        numTries += 1
        If (numTries = 3) And (Not idVerified) Then
            MessageBox.Show("This program is being terminated.")
            frmCISCommunications.Close()
            Me.Close()
        End If
    End Sub

    Function Confirm(ByVal userName As String, ByVal password As String) As Boolean
        Dim query = From line In IO.File.ReadAllLines("MasterFile.txt")
                    Where line = userName & "_" & password
                    Select line
        If query.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmLogin_FormClosing() Handles Me.FormClosing
        If Not idVerified Then
            MessageBox.Show("This program is being terminated.")
            frmCISCommunications.Close()
        End If
    End Sub
End Class
