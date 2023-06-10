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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblPergunta = New System.Windows.Forms.Label()
        Me.RadSim = New System.Windows.Forms.RadioButton()
        Me.RadNao = New System.Windows.Forms.RadioButton()
        Me.BtnResponder = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.LblResposta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.Blue
        Me.LblTitulo.Location = New System.Drawing.Point(72, 26)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(297, 23)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Programar é Divertido?"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPergunta
        '
        Me.LblPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPergunta.Location = New System.Drawing.Point(75, 79)
        Me.LblPergunta.Name = "LblPergunta"
        Me.LblPergunta.Size = New System.Drawing.Size(194, 23)
        Me.LblPergunta.TabIndex = 1
        Me.LblPergunta.Text = "Qual a Resposta?"
        '
        'RadSim
        '
        Me.RadSim.AutoSize = True
        Me.RadSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadSim.Location = New System.Drawing.Point(229, 118)
        Me.RadSim.Name = "RadSim"
        Me.RadSim.Size = New System.Drawing.Size(57, 24)
        Me.RadSim.TabIndex = 2
        Me.RadSim.TabStop = True
        Me.RadSim.Text = "Sim"
        Me.RadSim.UseVisualStyleBackColor = True
        '
        'RadNao
        '
        Me.RadNao.AutoSize = True
        Me.RadNao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNao.Location = New System.Drawing.Point(229, 167)
        Me.RadNao.Name = "RadNao"
        Me.RadNao.Size = New System.Drawing.Size(56, 24)
        Me.RadNao.TabIndex = 3
        Me.RadNao.TabStop = True
        Me.RadNao.Text = "Não"
        Me.RadNao.UseVisualStyleBackColor = True
        '
        'BtnResponder
        '
        Me.BtnResponder.BackColor = System.Drawing.Color.Orange
        Me.BtnResponder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BtnResponder.ForeColor = System.Drawing.Color.Black
        Me.BtnResponder.Location = New System.Drawing.Point(155, 222)
        Me.BtnResponder.Name = "BtnResponder"
        Me.BtnResponder.Size = New System.Drawing.Size(99, 46)
        Me.BtnResponder.TabIndex = 4
        Me.BtnResponder.Text = "Responder"
        Me.BtnResponder.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Lime
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BtnSair.Location = New System.Drawing.Point(362, 314)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 31)
        Me.BtnSair.TabIndex = 5
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LblAutor.Location = New System.Drawing.Point(12, 331)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(77, 17)
        Me.LblAutor.TabIndex = 6
        Me.LblAutor.Text = "Diogo Dias"
        '
        'LblResposta
        '
        Me.LblResposta.BackColor = System.Drawing.Color.White
        Me.LblResposta.Location = New System.Drawing.Point(49, 291)
        Me.LblResposta.Name = "LblResposta"
        Me.LblResposta.Size = New System.Drawing.Size(275, 31)
        Me.LblResposta.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(462, 357)
        Me.Controls.Add(Me.LblResposta)
        Me.Controls.Add(Me.LblAutor)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnResponder)
        Me.Controls.Add(Me.RadNao)
        Me.Controls.Add(Me.RadSim)
        Me.Controls.Add(Me.LblPergunta)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Form1"
        Me.Text = "Programa 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblPergunta As Label
    Friend WithEvents RadSim As RadioButton
    Friend WithEvents RadNao As RadioButton
    Friend WithEvents BtnResponder As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblAutor As Label
    Friend WithEvents LblResposta As Label
End Class
