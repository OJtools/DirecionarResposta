Imports System.Environment
Imports System.IO
Imports System.Windows.Forms

Public Class Form3

    Public Property SelectedReplyToAddress As String
    Private DefaultEmail As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Define the directory path
            Dim dirPath As String = Path.Combine(GetFolderPath(SpecialFolder.MyDocuments), "OJTools", "config")

            ' Create the directory if it does not exist
            If Not Directory.Exists(dirPath) Then
                Directory.CreateDirectory(dirPath)
            End If

            ' Define the file path
            Dim filePath As String = Path.Combine(dirPath, "email_replyto.txt")

            ' Load the email addresses from the file into the ListBox
            If IO.File.Exists(filePath) Then
                Dim emails As String() = IO.File.ReadAllLines(filePath)
                ListBoxEmails.Items.AddRange(emails)
            End If

            ' Set the default email as the SMTP address of the first account
            Dim outlookApp As Outlook.Application = Globals.ThisAddIn.Application
            If outlookApp.Session.Accounts.Count > 0 Then
                DefaultEmail = outlookApp.Session.Accounts.Item(1).SmtpAddress
            End If

            ' Set the default email as the selected item
            ListBoxEmails.SelectedItem = DefaultEmail
        Catch ex As Exception
            ' Handle any errors that occur during loading
            MessageBox.Show("Erro ao carregar o suplemento DirecionarRespostas " & ex.Message)
        End Try
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' Get the selected email address from the list box
        If ListBoxEmails.SelectedItem IsNot Nothing Then
            SelectedReplyToAddress = ListBoxEmails.SelectedItem.ToString()
        Else
            SelectedReplyToAddress = DefaultEmail
        End If

        ' Set the dialog result to OK to indicate a successful selection
        Me.DialogResult = DialogResult.OK

        ' Close the form
        Me.Close()
    End Sub

    Private Sub AddEmailButton_Click(sender As Object, e As EventArgs) Handles AddEmailButton.Click
        Try
            ' Define the directory path
            Dim dirPath As String = Path.Combine(GetFolderPath(SpecialFolder.MyDocuments), "OJTools", "config")

            ' Create the directory if it does not exist
            If Not Directory.Exists(dirPath) Then
                Directory.CreateDirectory(dirPath)
            End If

            ' Define the file path
            Dim filePath As String = Path.Combine(dirPath, "email_replyto.txt")

            ' Get the new email address from a TextBox
            Dim newEmail As String = TextBoxNewEmail.Text

            ' Add the new email to the ListBox and the file
            If Not String.IsNullOrWhiteSpace(newEmail) AndAlso Not ListBoxEmails.Items.Contains(newEmail) Then
                ListBoxEmails.Items.Add(newEmail)
                IO.File.AppendAllText(filePath, Environment.NewLine & newEmail)
                MessageBox.Show("Email adicionado com sucesso.")
                TextBoxNewEmail.Clear()  ' Clear the TextBox
            Else
                MessageBox.Show("Erro: endereço email invalido ou ja adicionado na lista")
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the addition of the new email
            MessageBox.Show("Ocorreu um erro ao adicionar o email" & ex.Message)
        End Try
    End Sub

End Class

