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
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblCombustível = New System.Windows.Forms.Label()
        Me.LblPreço = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.TxtCombustivel = New System.Windows.Forms.TextBox()
        Me.TxtPreco = New System.Windows.Forms.TextBox()
        Me.BtnInserir = New System.Windows.Forms.Button()
        Me.LstMarca = New System.Windows.Forms.ListBox()
        Me.LstModelo = New System.Windows.Forms.ListBox()
        Me.LstCombustivel = New System.Windows.Forms.ListBox()
        Me.LstPreco = New System.Windows.Forms.ListBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(302, 9)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(159, 25)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "Lista de Carros"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblMarca.Location = New System.Drawing.Point(41, 74)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(72, 25)
        Me.LblMarca.TabIndex = 1
        Me.LblMarca.Text = "Marca"
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblModelo.Location = New System.Drawing.Point(231, 74)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(83, 25)
        Me.LblModelo.TabIndex = 2
        Me.LblModelo.Text = "Modelo"
        '
        'LblCombustível
        '
        Me.LblCombustível.AutoSize = True
        Me.LblCombustível.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblCombustível.Location = New System.Drawing.Point(385, 74)
        Me.LblCombustível.Name = "LblCombustível"
        Me.LblCombustível.Size = New System.Drawing.Size(131, 25)
        Me.LblCombustível.TabIndex = 3
        Me.LblCombustível.Text = "Combustível"
        '
        'LblPreço
        '
        Me.LblPreço.AutoSize = True
        Me.LblPreço.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblPreço.Location = New System.Drawing.Point(617, 74)
        Me.LblPreço.Name = "LblPreço"
        Me.LblPreço.Size = New System.Drawing.Size(68, 25)
        Me.LblPreço.TabIndex = 4
        Me.LblPreço.Text = "Preço"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(11, 116)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(149, 20)
        Me.TxtMarca.TabIndex = 5
        Me.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(196, 116)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(149, 20)
        Me.TxtModelo.TabIndex = 6
        Me.TxtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCombustivel
        '
        Me.TxtCombustivel.Location = New System.Drawing.Point(380, 116)
        Me.TxtCombustivel.Name = "TxtCombustivel"
        Me.TxtCombustivel.Size = New System.Drawing.Size(149, 20)
        Me.TxtCombustivel.TabIndex = 7
        Me.TxtCombustivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPreco
        '
        Me.TxtPreco.Location = New System.Drawing.Point(575, 116)
        Me.TxtPreco.Name = "TxtPreco"
        Me.TxtPreco.Size = New System.Drawing.Size(149, 20)
        Me.TxtPreco.TabIndex = 8
        Me.TxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnInserir
        '
        Me.BtnInserir.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnInserir.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnInserir.Location = New System.Drawing.Point(325, 185)
        Me.BtnInserir.Name = "BtnInserir"
        Me.BtnInserir.Size = New System.Drawing.Size(83, 30)
        Me.BtnInserir.TabIndex = 9
        Me.BtnInserir.Text = "Inserir"
        Me.BtnInserir.UseVisualStyleBackColor = False
        '
        'LstMarca
        '
        Me.LstMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LstMarca.FormattingEnabled = True
        Me.LstMarca.ItemHeight = 16
        Me.LstMarca.Location = New System.Drawing.Point(11, 243)
        Me.LstMarca.Name = "LstMarca"
        Me.LstMarca.Size = New System.Drawing.Size(147, 228)
        Me.LstMarca.TabIndex = 10
        '
        'LstModelo
        '
        Me.LstModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LstModelo.FormattingEnabled = True
        Me.LstModelo.ItemHeight = 16
        Me.LstModelo.Location = New System.Drawing.Point(196, 243)
        Me.LstModelo.Name = "LstModelo"
        Me.LstModelo.Size = New System.Drawing.Size(147, 228)
        Me.LstModelo.TabIndex = 11
        '
        'LstCombustivel
        '
        Me.LstCombustivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LstCombustivel.FormattingEnabled = True
        Me.LstCombustivel.ItemHeight = 16
        Me.LstCombustivel.Location = New System.Drawing.Point(380, 243)
        Me.LstCombustivel.Name = "LstCombustivel"
        Me.LstCombustivel.Size = New System.Drawing.Size(147, 228)
        Me.LstCombustivel.TabIndex = 12
        '
        'LstPreco
        '
        Me.LstPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LstPreco.FormattingEnabled = True
        Me.LstPreco.ItemHeight = 16
        Me.LstPreco.Location = New System.Drawing.Point(575, 243)
        Me.LstPreco.Name = "LstPreco"
        Me.LstPreco.Size = New System.Drawing.Size(147, 228)
        Me.LstPreco.TabIndex = 13
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Orange
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLimpar.Location = New System.Drawing.Point(130, 519)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(99, 30)
        Me.BtnLimpar.TabIndex = 14
        Me.BtnLimpar.Text = "Limpar Tudo"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnListar
        '
        Me.BtnListar.BackColor = System.Drawing.Color.Orange
        Me.BtnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnListar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnListar.Location = New System.Drawing.Point(307, 519)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(99, 30)
        Me.BtnListar.TabIndex = 15
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Green
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSair.Location = New System.Drawing.Point(496, 519)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(99, 30)
        Me.BtnSair.TabIndex = 16
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblDev.Location = New System.Drawing.Point(12, 585)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(97, 20)
        Me.LblDev.TabIndex = 17
        Me.LblDev.Text = "Diogo Dias"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 619)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.LstPreco)
        Me.Controls.Add(Me.LstCombustivel)
        Me.Controls.Add(Me.LstModelo)
        Me.Controls.Add(Me.LstMarca)
        Me.Controls.Add(Me.BtnInserir)
        Me.Controls.Add(Me.TxtPreco)
        Me.Controls.Add(Me.TxtCombustivel)
        Me.Controls.Add(Me.TxtModelo)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.LblPreço)
        Me.Controls.Add(Me.LblCombustível)
        Me.Controls.Add(Me.LblModelo)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblCombustível As Label
    Friend WithEvents LblPreço As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents TxtCombustivel As TextBox
    Friend WithEvents TxtPreco As TextBox
    Friend WithEvents BtnInserir As Button
    Friend WithEvents LstMarca As ListBox
    Friend WithEvents LstModelo As ListBox
    Friend WithEvents LstCombustivel As ListBox
    Friend WithEvents LstPreco As ListBox
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblDev As Label
End Class
