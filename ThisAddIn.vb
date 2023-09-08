Imports System.Windows.Forms

Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        AddHandler Application.ItemSend, AddressOf Application_ItemSend
    End Sub

    Private Sub Application_ItemSend(Item As Object, ByRef Cancel As Boolean)
        If TypeOf Item Is Outlook.MailItem Then
            Dim mailItem As Outlook.MailItem = CType(Item, Outlook.MailItem)

            ' Show your custom form to get the reply-to address
            Dim form As New Form3()
            If form.ShowDialog() = DialogResult.OK Then
                ' Set the reply-to address on the mail item
                Dim replyToAddress As String = form.SelectedReplyToAddress
                mailItem.ReplyRecipients.Add(replyToAddress)
                mailItem.ReplyRecipients.ResolveAll()
            Else
                ' Optionally cancel the send if the user cancels the form
                Cancel = True
            End If
        End If
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
    End Sub

End Class
