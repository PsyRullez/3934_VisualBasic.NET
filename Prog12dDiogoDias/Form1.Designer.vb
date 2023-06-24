<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSortear = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.TxtNumeros = New System.Windows.Forms.TextBox()
        Me.TxtEstrelas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(235, 20)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(108, 20)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "EuroMilhões"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(434, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estrelas"
        '
        'BtnSortear
        '
        Me.BtnSortear.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnSortear.Location = New System.Drawing.Point(252, 210)
        Me.BtnSortear.Name = "BtnSortear"
        Me.BtnSortear.Size = New System.Drawing.Size(75, 23)
        Me.BtnSortear.TabIndex = 3
        Me.BtnSortear.Text = "Sortear"
        Me.BtnSortear.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Red
        Me.BtnSair.Location = New System.Drawing.Point(438, 252)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'TxtNumeros
        '
        Me.TxtNumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeros.Location = New System.Drawing.Point(54, 85)
        Me.TxtNumeros.Multiline = True
        Me.TxtNumeros.Name = "TxtNumeros"
        Me.TxtNumeros.Size = New System.Drawing.Size(82, 131)
        Me.TxtNumeros.TabIndex = 5
        Me.TxtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEstrelas
        '
        Me.TxtEstrelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TxtEstrelas.Location = New System.Drawing.Point(438, 85)
        Me.TxtEstrelas.Multiline = True
        Me.TxtEstrelas.Name = "TxtEstrelas"
        Me.TxtEstrelas.Size = New System.Drawing.Size(82, 71)
        Me.TxtEstrelas.TabIndex = 6
        Me.TxtEstrelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 301)
        Me.Controls.Add(Me.TxtEstrelas)
        Me.Controls.Add(Me.TxtNumeros)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnSortear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSortear As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents TxtNumeros As TextBox
    Friend WithEvents TxtEstrelas As TextBox
End Class
