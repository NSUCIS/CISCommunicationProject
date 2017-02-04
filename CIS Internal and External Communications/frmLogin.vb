Public Class frmLogin

    Public username As String
    Dim numTries As Integer = 3
    Dim idVerified As Boolean = False

    Private Sub Login()
        'If number of login attempts not exceeded then check username and password
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
        'Check login attempts and close if no tries remain
        If (numTries <= 1) And (Not idVerified) Then
            MessageBox.Show("This program is being terminated.")
            frmCISCommunications.Close()
            Me.Close()
        End If
        numTries -= 1
    End Sub

    Function Confirm(ByVal userName As String, ByVal password As String) As Boolean
        Dim query = From line In IO.File.ReadAllLines("MasterFile.txt")
                    Where line = userName & "_" & password
                    Select line
        If query.Count >= 1 Then 'More forgiving here if username and pass is duplicated in Masterfile
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Sub login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Login()
        End If
    End Sub

    Private Sub frmLogin_FormClosing() Handles Me.FormClosing
        If Not idVerified Then
            MessageBox.Show("This program is being terminated.")
            frmCISCommunications.Close()
        End If
    End Sub
End Class
