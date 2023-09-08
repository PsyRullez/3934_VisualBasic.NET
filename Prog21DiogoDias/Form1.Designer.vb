<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassw = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblSignin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(190, 236)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(456, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Field for Password"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(190, 153)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Field for Username"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblLogin
        '
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblLogin.Location = New System.Drawing.Point(336, 9)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(145, 37)
        Me.LblLogin.TabIndex = 3
        Me.LblLogin.Text = "Login"
        Me.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblUsername.Location = New System.Drawing.Point(22, 158)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(73, 17)
        Me.LblUsername.TabIndex = 4
        Me.LblUsername.Text = "Username"
        '
        'LblPassw
        '
        Me.LblPassw.AutoSize = True
        Me.LblPassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPassw.Location = New System.Drawing.Point(22, 236)
        Me.LblPassw.Name = "LblPassw"
        Me.LblPassw.Size = New System.Drawing.Size(69, 17)
        Me.LblPassw.TabIndex = 5
        Me.LblPassw.Text = "Password"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Lime
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin.Location = New System.Drawing.Point(204, 304)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(430, 39)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Log-in"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LblSignin
        '
        Me.LblSignin.BackColor = System.Drawing.Color.Chartreuse
        Me.LblSignin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblSignin.Location = New System.Drawing.Point(204, 430)
        Me.LblSignin.Name = "LblSignin"
        Me.LblSignin.Size = New System.Drawing.Size(430, 39)
        Me.LblSignin.TabIndex = 7
        Me.LblSignin.Text = "Sign-in"
        Me.LblSignin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.LblSignin)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblPassw)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "Login"
        Me.Text = "Log-In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblLogin As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassw As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblSignin As Button
End Class
