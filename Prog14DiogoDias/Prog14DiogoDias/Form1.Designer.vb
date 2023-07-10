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
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.TxtOperacao = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.Lbl1Num = New System.Windows.Forms.Label()
        Me.Lbl2Num = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(483, 31)
        Me.TxtNum1.Multiline = True
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(121, 43)
        Me.TxtNum1.TabIndex = 0
        Me.TxtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(483, 154)
        Me.TxtNum2.Multiline = True
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(121, 43)
        Me.TxtNum2.TabIndex = 1
        Me.TxtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtOperacao
        '
        Me.TxtOperacao.Location = New System.Drawing.Point(282, 245)
        Me.TxtOperacao.Multiline = True
        Me.TxtOperacao.Name = "TxtOperacao"
        Me.TxtOperacao.Size = New System.Drawing.Size(121, 43)
        Me.TxtOperacao.TabIndex = 2
        Me.TxtOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(483, 294)
        Me.TxtResultado.Multiline = True
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(121, 43)
        Me.TxtResultado.TabIndex = 3
        Me.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(204, 9)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(172, 20)
        Me.LblTittle.TabIndex = 4
        Me.LblTittle.Text = "Máquina de Calcular"
        '
        'Lbl1Num
        '
        Me.Lbl1Num.AutoSize = True
        Me.Lbl1Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl1Num.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Lbl1Num.Location = New System.Drawing.Point(310, 54)
        Me.Lbl1Num.Name = "Lbl1Num"
        Me.Lbl1Num.Size = New System.Drawing.Size(93, 20)
        Me.Lbl1Num.TabIndex = 5
        Me.Lbl1Num.Text = "1º Número"
        '
        'Lbl2Num
        '
        Me.Lbl2Num.AutoSize = True
        Me.Lbl2Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl2Num.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Lbl2Num.Location = New System.Drawing.Point(310, 177)
        Me.Lbl2Num.Name = "Lbl2Num"
        Me.Lbl2Num.Size = New System.Drawing.Size(93, 20)
        Me.Lbl2Num.TabIndex = 6
        Me.Lbl2Num.Text = "2º Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(102, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Operação(+; -; *; /)"
        '
        'LblResultado
        '
        Me.LblResultado.AutoSize = True
        Me.LblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblResultado.Location = New System.Drawing.Point(349, 317)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(91, 20)
        Me.LblResultado.TabIndex = 8
        Me.LblResultado.Text = "Resultado"
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblDev.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LblDev.Location = New System.Drawing.Point(12, 415)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(97, 20)
        Me.LblDev.TabIndex = 9
        Me.LblDev.Text = "Diogo Dias"
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Lime
        Me.BtnSair.Location = New System.Drawing.Point(483, 366)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(104, 40)
        Me.BtnSair.TabIndex = 10
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Lime
        Me.BtnLimpar.Location = New System.Drawing.Point(208, 366)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(104, 40)
        Me.BtnLimpar.TabIndex = 11
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Red
        Me.BtnCalcular.Location = New System.Drawing.Point(483, 234)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(104, 40)
        Me.BtnCalcular.TabIndex = 12
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(611, 444)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl2Num)
        Me.Controls.Add(Me.Lbl1Num)
        Me.Controls.Add(Me.LblTittle)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtOperacao)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents TxtOperacao As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents LblTittle As Label
    Friend WithEvents Lbl1Num As Label
    Friend WithEvents Lbl2Num As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResultado As Label
    Friend WithEvents LblDev As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnCalcular As Button
End Class
