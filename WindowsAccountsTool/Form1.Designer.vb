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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.radioAdmin = New System.Windows.Forms.RadioButton()
        Me.radioRegular = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowUsers = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 54)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        '
        'radioAdmin
        '
        Me.radioAdmin.AutoSize = True
        Me.radioAdmin.Location = New System.Drawing.Point(239, 7)
        Me.radioAdmin.Name = "radioAdmin"
        Me.radioAdmin.Size = New System.Drawing.Size(71, 22)
        Me.radioAdmin.TabIndex = 2
        Me.radioAdmin.TabStop = True
        Me.radioAdmin.Text = "Admin"
        Me.radioAdmin.UseVisualStyleBackColor = True
        '
        'radioRegular
        '
        Me.radioRegular.AutoSize = True
        Me.radioRegular.Location = New System.Drawing.Point(316, 6)
        Me.radioRegular.Name = "radioRegular"
        Me.radioRegular.Size = New System.Drawing.Size(80, 22)
        Me.radioRegular.TabIndex = 2
        Me.radioRegular.TabStop = True
        Me.radioRegular.Text = "Regular"
        Me.radioRegular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'btnShowUsers
        '
        Me.btnShowUsers.Location = New System.Drawing.Point(15, 88)
        Me.btnShowUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowUsers.Name = "btnShowUsers"
        Me.btnShowUsers.Size = New System.Drawing.Size(112, 32)
        Me.btnShowUsers.TabIndex = 0
        Me.btnShowUsers.Text = "Show Users"
        Me.btnShowUsers.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Lucida Console", 12.0!)
        Me.RichTextBox1.Location = New System.Drawing.Point(134, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(474, 270)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 321)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radioRegular)
        Me.Controls.Add(Me.radioAdmin)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnShowUsers)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "WindowsAccountsTool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents radioAdmin As RadioButton
    Friend WithEvents radioRegular As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowUsers As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
