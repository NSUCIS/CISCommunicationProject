<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lstAddresses = New System.Windows.Forms.ListBox()
        Me.rtbBody = New System.Windows.Forms.RichTextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(60, 85)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(500, 20)
        Me.txtSubject.TabIndex = 2
        '
        'lstAddresses
        '
        Me.lstAddresses.FormattingEnabled = True
        Me.lstAddresses.Location = New System.Drawing.Point(60, 12)
        Me.lstAddresses.Name = "lstAddresses"
        Me.lstAddresses.Size = New System.Drawing.Size(499, 56)
        Me.lstAddresses.TabIndex = 3
        '
        'rtbBody
        '
        Me.rtbBody.Location = New System.Drawing.Point(60, 127)
        Me.rtbBody.Name = "rtbBody"
        Me.rtbBody.Size = New System.Drawing.Size(499, 193)
        Me.rtbBody.TabIndex = 4
        Me.rtbBody.Text = ""
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(484, 342)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(382, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmEmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 377)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.rtbBody)
        Me.Controls.Add(Me.lstAddresses)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmailForm"
        Me.Text = "New E-mail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lstAddresses As ListBox
    Friend WithEvents rtbBody As RichTextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCancel As Button
End Class
