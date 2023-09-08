<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.AddEmailButton = New System.Windows.Forms.Button()
        Me.TextBoxNewEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxEmails = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.Black
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.OKButton.Location = New System.Drawing.Point(407, 37)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(111, 54)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "Enviar"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'AddEmailButton
        '
        Me.AddEmailButton.BackColor = System.Drawing.Color.Black
        Me.AddEmailButton.FlatAppearance.BorderSize = 0
        Me.AddEmailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.AddEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddEmailButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmailButton.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.AddEmailButton.Location = New System.Drawing.Point(407, 274)
        Me.AddEmailButton.Name = "AddEmailButton"
        Me.AddEmailButton.Size = New System.Drawing.Size(111, 49)
        Me.AddEmailButton.TabIndex = 2
        Me.AddEmailButton.Text = "Adicionar Email"
        Me.AddEmailButton.UseVisualStyleBackColor = False
        '
        'TextBoxNewEmail
        '
        Me.TextBoxNewEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxNewEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewEmail.Location = New System.Drawing.Point(12, 274)
        Me.TextBoxNewEmail.Multiline = True
        Me.TextBoxNewEmail.Name = "TextBoxNewEmail"
        Me.TextBoxNewEmail.Size = New System.Drawing.Size(376, 49)
        Me.TextBoxNewEmail.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selecione o email para onde sera enviada a resposta"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Adicionar um novo email á lista"
        '
        'ListBoxEmails
        '
        Me.ListBoxEmails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxEmails.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEmails.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ListBoxEmails.FormattingEnabled = True
        Me.ListBoxEmails.ItemHeight = 16
        Me.ListBoxEmails.Location = New System.Drawing.Point(12, 37)
        Me.ListBoxEmails.Name = "ListBoxEmails"
        Me.ListBoxEmails.Size = New System.Drawing.Size(376, 178)
        Me.ListBoxEmails.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(12, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(503, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "© OJTools 2023 "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(527, 363)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxEmails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNewEmail)
        Me.Controls.Add(Me.AddEmailButton)
        Me.Controls.Add(Me.OKButton)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Direcionar Resposta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As Windows.Forms.Button
    Friend WithEvents AddEmailButton As Windows.Forms.Button
    Friend WithEvents TextBoxNewEmail As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents ListBoxEmails As Windows.Forms.ListBox
    Friend WithEvents Label3 As Windows.Forms.Label
End Class
