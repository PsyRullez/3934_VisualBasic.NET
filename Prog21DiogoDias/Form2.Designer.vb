<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Me.LblPassw = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblSignin = New System.Windows.Forms.Label()
        Me.TxtRUser = New System.Windows.Forms.TextBox()
        Me.TxtRPW = New System.Windows.Forms.TextBox()
        Me.LblPNumber = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtREmail = New System.Windows.Forms.TextBox()
        Me.TxtRPNumber = New System.Windows.Forms.TextBox()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPassw
        '
        Me.LblPassw.AutoSize = True
        Me.LblPassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPassw.Location = New System.Drawing.Point(25, 236)
        Me.LblPassw.Name = "LblPassw"
        Me.LblPassw.Size = New System.Drawing.Size(69, 17)
        Me.LblPassw.TabIndex = 10
        Me.LblPassw.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblUsername.Location = New System.Drawing.Point(25, 153)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(73, 17)
        Me.LblUsername.TabIndex = 9
        Me.LblUsername.Text = "Username"
        '
        'LblSignin
        '
        Me.LblSignin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSignin.Location = New System.Drawing.Point(298, 9)
        Me.LblSignin.Name = "LblSignin"
        Me.LblSignin.Size = New System.Drawing.Size(145, 37)
        Me.LblSignin.TabIndex = 8
        Me.LblSignin.Text = "Sign-In"
        Me.LblSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtRUser
        '
        Me.TxtRUser.Location = New System.Drawing.Point(147, 153)
        Me.TxtRUser.Multiline = True
        Me.TxtRUser.Name = "TxtRUser"
        Me.TxtRUser.Size = New System.Drawing.Size(456, 20)
        Me.TxtRUser.TabIndex = 7
        Me.TxtRUser.Text = "Field for Username"
        Me.TxtRUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPW
        '
        Me.TxtRPW.Location = New System.Drawing.Point(147, 233)
        Me.TxtRPW.Multiline = True
        Me.TxtRPW.Name = "TxtRPW"
        Me.TxtRPW.Size = New System.Drawing.Size(456, 20)
        Me.TxtRPW.TabIndex = 6
        Me.TxtRPW.Text = "Field for Password"
        Me.TxtRPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPNumber
        '
        Me.LblPNumber.AutoSize = True
        Me.LblPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPNumber.Location = New System.Drawing.Point(25, 379)
        Me.LblPNumber.Name = "LblPNumber"
        Me.LblPNumber.Size = New System.Drawing.Size(103, 17)
        Me.LblPNumber.TabIndex = 14
        Me.LblPNumber.Text = "Phone Number"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblEmail.Location = New System.Drawing.Point(25, 296)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(42, 17)
        Me.LblEmail.TabIndex = 13
        Me.LblEmail.Text = "Email"
        '
        'TxtREmail
        '
        Me.TxtREmail.Location = New System.Drawing.Point(147, 296)
        Me.TxtREmail.Multiline = True
        Me.TxtREmail.Name = "TxtREmail"
        Me.TxtREmail.Size = New System.Drawing.Size(456, 20)
        Me.TxtREmail.TabIndex = 12
        Me.TxtREmail.Text = "Field for Email"
        Me.TxtREmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRPNumber
        '
        Me.TxtRPNumber.Location = New System.Drawing.Point(147, 376)
        Me.TxtRPNumber.Multiline = True
        Me.TxtRPNumber.Name = "TxtRPNumber"
        Me.TxtRPNumber.Size = New System.Drawing.Size(456, 20)
        Me.TxtRPNumber.TabIndex = 11
        Me.TxtRPNumber.Text = "Field for Phone Number"
        Me.TxtRPNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSignIn
        '
        Me.BtnSignIn.BackColor = System.Drawing.Color.Chartreuse
        Me.BtnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSignIn.Location = New System.Drawing.Point(147, 439)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(430, 39)
        Me.BtnSignIn.TabIndex = 15
        Me.BtnSignIn.Text = "Sign-in"
        Me.BtnSignIn.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Chartreuse
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin.Location = New System.Drawing.Point(147, 541)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(430, 39)
        Me.BtnLogin.TabIndex = 16
        Me.BtnLogin.Text = "Already a member? Log-in"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 610)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnSignIn)
        Me.Controls.Add(Me.LblPNumber)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtREmail)
        Me.Controls.Add(Me.TxtRPNumber)
        Me.Controls.Add(Me.LblPassw)
        Me.Controls.Add(Me.LblUsername)
        Me.Controls.Add(Me.LblSignin)
        Me.Controls.Add(Me.TxtRUser)
        Me.Controls.Add(Me.TxtRPW)
        Me.Name = "Signin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign-In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPassw As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblSignin As Label
    Friend WithEvents TxtRUser As TextBox
    Friend WithEvents TxtRPW As TextBox
    Friend WithEvents LblPNumber As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtREmail As TextBox
    Friend WithEvents TxtRPNumber As TextBox
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents BtnLogin As Button
End Class
