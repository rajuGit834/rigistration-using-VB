<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        firstName = New TextBox()
        middleName = New TextBox()
        lastName = New TextBox()
        gender = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        address = New TextBox()
        save = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 1
        Label2.Text = "Middle Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 2
        Label3.Text = "Last Name :"
        ' 
        ' firstName
        ' 
        firstName.Location = New Point(159, 67)
        firstName.Name = "firstName"
        firstName.Size = New Size(191, 23)
        firstName.TabIndex = 3
        ' 
        ' middleName
        ' 
        middleName.Location = New Point(159, 114)
        middleName.Name = "middleName"
        middleName.Size = New Size(191, 23)
        middleName.TabIndex = 4
        ' 
        ' lastName
        ' 
        lastName.Location = New Point(159, 161)
        lastName.Name = "lastName"
        lastName.Size = New Size(191, 23)
        lastName.TabIndex = 5
        ' 
        ' gender
        ' 
        gender.FormattingEnabled = True
        gender.Items.AddRange(New Object() {"Male", "Female", "Transgender"})
        gender.Location = New Point(159, 207)
        gender.Name = "gender"
        gender.Size = New Size(191, 23)
        gender.TabIndex = 6
        gender.Text = "Select"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 7
        Label4.Text = "Gender :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 8
        Label5.Text = "Address :"
        ' 
        ' address
        ' 
        address.Location = New Point(161, 254)
        address.Multiline = True
        address.Name = "address"
        address.PlaceholderText = ". . . . . . "
        address.Size = New Size(189, 70)
        address.TabIndex = 9
        ' 
        ' save
        ' 
        save.ForeColor = SystemColors.HotTrack
        save.Location = New Point(163, 348)
        save.Name = "save"
        save.Size = New Size(75, 23)
        save.TabIndex = 10
        save.Text = "Save"
        save.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Menu
        Button1.ForeColor = SystemColors.MenuHighlight
        Button1.Location = New Point(273, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 23)
        Button1.TabIndex = 11
        Button1.Text = "Show Data"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(save)
        Controls.Add(address)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(gender)
        Controls.Add(lastName)
        Controls.Add(middleName)
        Controls.Add(firstName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents middleName As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents save As Button
    Friend WithEvents Button1 As Button
End Class
