<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblNumeros = New System.Windows.Forms.Label()
        Me.LblEstrelas = New System.Windows.Forms.Label()
        Me.LstNumeros = New System.Windows.Forms.ListBox()
        Me.LstEstrelas = New System.Windows.Forms.ListBox()
        Me.BtnSortear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumeros
        '
        Me.LblNumeros.AutoSize = True
        Me.LblNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblNumeros.Location = New System.Drawing.Point(87, 113)
        Me.LblNumeros.Name = "LblNumeros"
        Me.LblNumeros.Size = New System.Drawing.Size(72, 17)
        Me.LblNumeros.TabIndex = 0
        Me.LblNumeros.Text = "Números"
        '
        'LblEstrelas
        '
        Me.LblEstrelas.AutoSize = True
        Me.LblEstrelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblEstrelas.Location = New System.Drawing.Point(423, 113)
        Me.LblEstrelas.Name = "LblEstrelas"
        Me.LblEstrelas.Size = New System.Drawing.Size(67, 17)
        Me.LblEstrelas.TabIndex = 1
        Me.LblEstrelas.Text = "Estrelas"
        Me.LblEstrelas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LstNumeros
        '
        Me.LstNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LstNumeros.FormattingEnabled = True
        Me.LstNumeros.ItemHeight = 16
        Me.LstNumeros.Location = New System.Drawing.Point(90, 169)
        Me.LstNumeros.Name = "LstNumeros"
        Me.LstNumeros.Size = New System.Drawing.Size(138, 228)
        Me.LstNumeros.TabIndex = 2
        '
        'LstEstrelas
        '
        Me.LstEstrelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LstEstrelas.FormattingEnabled = True
        Me.LstEstrelas.ItemHeight = 16
        Me.LstEstrelas.Location = New System.Drawing.Point(352, 169)
        Me.LstEstrelas.Name = "LstEstrelas"
        Me.LstEstrelas.Size = New System.Drawing.Size(138, 116)
        Me.LstEstrelas.TabIndex = 3
        '
        'BtnSortear
        '
        Me.BtnSortear.BackColor = System.Drawing.Color.Green
        Me.BtnSortear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSortear.Location = New System.Drawing.Point(369, 302)
        Me.BtnSortear.Name = "BtnSortear"
        Me.BtnSortear.Size = New System.Drawing.Size(121, 40)
        Me.BtnSortear.TabIndex = 4
        Me.BtnSortear.Text = "Sortear"
        Me.BtnSortear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(369, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Diogo Dias"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Blue
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpar.Location = New System.Drawing.Point(369, 420)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(121, 40)
        Me.BtnLimpar.TabIndex = 8
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 482)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSortear)
        Me.Controls.Add(Me.LstEstrelas)
        Me.Controls.Add(Me.LstNumeros)
        Me.Controls.Add(Me.LblEstrelas)
        Me.Controls.Add(Me.LblNumeros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumeros As Label
    Friend WithEvents LblEstrelas As Label
    Friend WithEvents LstNumeros As ListBox
    Friend WithEvents LstEstrelas As ListBox
    Friend WithEvents BtnSortear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLimpar As Button
End Class
