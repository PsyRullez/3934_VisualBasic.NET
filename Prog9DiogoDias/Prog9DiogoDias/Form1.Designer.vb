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
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.BtnMaior = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(40, 38)
        Me.TxtNum1.Multiline = True
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(109, 51)
        Me.TxtNum1.TabIndex = 0
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(238, 38)
        Me.TxtNum2.Multiline = True
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(109, 51)
        Me.TxtNum2.TabIndex = 1
        '
        'LblNum1
        '
        Me.LblNum1.Location = New System.Drawing.Point(49, 12)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(100, 23)
        Me.LblNum1.TabIndex = 2
        Me.LblNum1.Text = "1º Número"
        Me.LblNum1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblNum2
        '
        Me.LblNum2.Location = New System.Drawing.Point(273, 21)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(74, 13)
        Me.LblNum2.TabIndex = 3
        Me.LblNum2.Text = "2º Número"
        '
        'BtnMaior
        '
        Me.BtnMaior.BackColor = System.Drawing.Color.Yellow
        Me.BtnMaior.Location = New System.Drawing.Point(40, 166)
        Me.BtnMaior.Name = "BtnMaior"
        Me.BtnMaior.Size = New System.Drawing.Size(109, 52)
        Me.BtnMaior.TabIndex = 4
        Me.BtnMaior.Text = "Qual é o Maior?"
        Me.BtnMaior.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Yellow
        Me.BtnLimpar.Location = New System.Drawing.Point(238, 166)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(109, 52)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'LblResultado
        '
        Me.LblResultado.BackColor = System.Drawing.Color.White
        Me.LblResultado.Location = New System.Drawing.Point(37, 256)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(310, 35)
        Me.LblResultado.TabIndex = 6
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Red
        Me.BtnSair.Location = New System.Drawing.Point(255, 303)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(92, 44)
        Me.BtnSair.TabIndex = 7
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.Location = New System.Drawing.Point(37, 334)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(59, 13)
        Me.LblAutor.TabIndex = 8
        Me.LblAutor.Text = "Diogo Dias"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(374, 356)
        Me.Controls.Add(Me.LblAutor)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnMaior)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.LblNum1)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Name = "Form1"
        Me.Text = "Programa 9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents LblNum1 As Label
    Friend WithEvents LblNum2 As Label
    Friend WithEvents BtnMaior As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblResultado As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblAutor As Label
End Class
