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
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.RadSoma = New System.Windows.Forms.RadioButton()
        Me.RadSubtração = New System.Windows.Forms.RadioButton()
        Me.RadMultiplicação = New System.Windows.Forms.RadioButton()
        Me.RadDivisão = New System.Windows.Forms.RadioButton()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.GrpOperação = New System.Windows.Forms.GroupBox()
        Me.GrpOperação.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(152, 25)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(174, 22)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Máquina de Calcular"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNum1
        '
        Me.LblNum1.AutoSize = True
        Me.LblNum1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum1.Location = New System.Drawing.Point(3, 108)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(100, 22)
        Me.LblNum1.TabIndex = 1
        Me.LblNum1.Text = "1º Número"
        Me.LblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNum2
        '
        Me.LblNum2.AutoSize = True
        Me.LblNum2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum2.Location = New System.Drawing.Point(3, 177)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(100, 22)
        Me.LblNum2.TabIndex = 2
        Me.LblNum2.Text = "2º Número"
        Me.LblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(185, 91)
        Me.TxtNum1.Multiline = True
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(108, 39)
        Me.TxtNum1.TabIndex = 3
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(185, 160)
        Me.TxtNum2.Multiline = True
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(108, 39)
        Me.TxtNum2.TabIndex = 4
        '
        'LblResultado
        '
        Me.LblResultado.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LblResultado.Location = New System.Drawing.Point(182, 285)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(111, 42)
        Me.LblResultado.TabIndex = 5
        Me.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCalcular.Location = New System.Drawing.Point(185, 226)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(108, 43)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSair.Location = New System.Drawing.Point(295, 337)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(87, 38)
        Me.BtnSair.TabIndex = 7
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.LightBlue
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpar.Location = New System.Drawing.Point(108, 337)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(87, 38)
        Me.BtnLimpar.TabIndex = 8
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'RadSoma
        '
        Me.RadSoma.AutoSize = True
        Me.RadSoma.Location = New System.Drawing.Point(30, 37)
        Me.RadSoma.Name = "RadSoma"
        Me.RadSoma.Size = New System.Drawing.Size(56, 20)
        Me.RadSoma.TabIndex = 9
        Me.RadSoma.TabStop = True
        Me.RadSoma.Text = "Soma"
        Me.RadSoma.UseVisualStyleBackColor = True
        '
        'RadSubtração
        '
        Me.RadSubtração.AutoSize = True
        Me.RadSubtração.Location = New System.Drawing.Point(30, 70)
        Me.RadSubtração.Name = "RadSubtração"
        Me.RadSubtração.Size = New System.Drawing.Size(81, 20)
        Me.RadSubtração.TabIndex = 10
        Me.RadSubtração.TabStop = True
        Me.RadSubtração.Text = "Subtração"
        Me.RadSubtração.UseVisualStyleBackColor = True
        '
        'RadMultiplicação
        '
        Me.RadMultiplicação.AutoSize = True
        Me.RadMultiplicação.Location = New System.Drawing.Point(30, 108)
        Me.RadMultiplicação.Name = "RadMultiplicação"
        Me.RadMultiplicação.Size = New System.Drawing.Size(98, 20)
        Me.RadMultiplicação.TabIndex = 11
        Me.RadMultiplicação.TabStop = True
        Me.RadMultiplicação.Text = "Multiplicação"
        Me.RadMultiplicação.UseVisualStyleBackColor = True
        '
        'RadDivisão
        '
        Me.RadDivisão.AutoSize = True
        Me.RadDivisão.Location = New System.Drawing.Point(30, 147)
        Me.RadDivisão.Name = "RadDivisão"
        Me.RadDivisão.Size = New System.Drawing.Size(64, 20)
        Me.RadDivisão.TabIndex = 12
        Me.RadDivisão.TabStop = True
        Me.RadDivisão.Text = "Divisão"
        Me.RadDivisão.UseVisualStyleBackColor = True
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LblAutor.Location = New System.Drawing.Point(4, 359)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(63, 16)
        Me.LblAutor.TabIndex = 14
        Me.LblAutor.Text = "DiogoDias"
        Me.LblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpOperação
        '
        Me.GrpOperação.Controls.Add(Me.RadSoma)
        Me.GrpOperação.Controls.Add(Me.RadSubtração)
        Me.GrpOperação.Controls.Add(Me.RadMultiplicação)
        Me.GrpOperação.Controls.Add(Me.RadDivisão)
        Me.GrpOperação.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GrpOperação.Location = New System.Drawing.Point(317, 91)
        Me.GrpOperação.Name = "GrpOperação"
        Me.GrpOperação.Size = New System.Drawing.Size(200, 178)
        Me.GrpOperação.TabIndex = 15
        Me.GrpOperação.TabStop = False
        Me.GrpOperação.Text = "Operação"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 384)
        Me.Controls.Add(Me.GrpOperação)
        Me.Controls.Add(Me.LblAutor)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.LblNum1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Form1"
        Me.Text = "Programa 11"
        Me.GrpOperação.ResumeLayout(False)
        Me.GrpOperação.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblNum1 As Label
    Friend WithEvents LblNum2 As Label
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents LblResultado As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents RadSoma As RadioButton
    Friend WithEvents RadSubtração As RadioButton
    Friend WithEvents RadMultiplicação As RadioButton
    Friend WithEvents RadDivisão As RadioButton
    Friend WithEvents LblAutor As Label
    Friend WithEvents GrpOperação As GroupBox
End Class
