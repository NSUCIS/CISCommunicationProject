Imports System.Net.Mail

Public Class frmEmailForm
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim elements(lstAddresses.Items.Count - 1) As String
        lstAddresses.Items.CopyTo(elements, 0)
        Dim stringNames As String = String.Join(",", elements)
        Dim mailMsg As MailMessage = New MailMessage("cyoung8@its.nicholls.edu", stringNames)
        mailMsg.Subject = txtSubject.Text
        mailMsg.Body = rtbBody.Text

        Dim mailSmtp As SmtpClient = New SmtpClient("smtp.gmail.com", 587)
        mailSmtp.Credentials = New System.Net.NetworkCredential("cyoung8@its.nicholls.edu", "N00078068")
        mailSmtp.EnableSsl = True
        mailSmtp.DeliveryMethod = SmtpDeliveryMethod.Network
        mailSmtp.Send(mailMsg)
        mailMsg.Dispose()
        MsgBox("Mail Successfully Sent!", vbOKOnly)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lstAddresses.Items.Clear()
        Me.Close()
    End Sub
End Class
