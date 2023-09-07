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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.LblLadoA = New System.Windows.Forms.Label()
        Me.LblLaboB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblLadoC = New System.Windows.Forms.Label()
        Me.RBox = New System.Windows.Forms.GroupBox()
        Me.RPerimetro = New System.Windows.Forms.RadioButton()
        Me.RArea = New System.Windows.Forms.RadioButton()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtC = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Crimson
        Me.BtnSair.Location = New System.Drawing.Point(12, 400)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(131, 38)
        Me.BtnSair.TabIndex = 0
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Turquoise
        Me.BtnLimpar.Location = New System.Drawing.Point(657, 400)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(131, 38)
        Me.BtnLimpar.TabIndex = 1
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnCalcular.Location = New System.Drawing.Point(328, 400)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(131, 38)
        Me.BtnCalcular.TabIndex = 2
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'LblTittle
        '
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(289, 12)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(134, 38)
        Me.LblTittle.TabIndex = 3
        Me.LblTittle.Text = "Triângulo"
        Me.LblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Location = New System.Drawing.Point(22, 470)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(56, 13)
        Me.LblDev.TabIndex = 4
        Me.LblDev.Text = "DiogoDias"
        '
        'LblLadoA
        '
        Me.LblLadoA.AutoSize = True
        Me.LblLadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblLadoA.Location = New System.Drawing.Point(21, 158)
        Me.LblLadoA.Name = "LblLadoA"
        Me.LblLadoA.Size = New System.Drawing.Size(61, 20)
        Me.LblLadoA.TabIndex = 5
        Me.LblLadoA.Text = "LadoA"
        '
        'LblLaboB
        '
        Me.LblLaboB.AutoSize = True
        Me.LblLaboB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblLaboB.Location = New System.Drawing.Point(21, 214)
        Me.LblLaboB.Name = "LblLaboB"
        Me.LblLaboB.Size = New System.Drawing.Size(61, 20)
        Me.LblLaboB.TabIndex = 6
        Me.LblLaboB.Text = "LadoB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(539, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LblLadoC
        '
        Me.LblLadoC.AutoSize = True
        Me.LblLadoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblLadoC.Location = New System.Drawing.Point(21, 277)
        Me.LblLadoC.Name = "LblLadoC"
        Me.LblLadoC.Size = New System.Drawing.Size(61, 20)
        Me.LblLadoC.TabIndex = 9
        Me.LblLadoC.Text = "LadoC"
        '
        'RBox
        '
        Me.RBox.Controls.Add(Me.RPerimetro)
        Me.RBox.Controls.Add(Me.RArea)
        Me.RBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RBox.Location = New System.Drawing.Point(540, 231)
        Me.RBox.Name = "RBox"
        Me.RBox.Size = New System.Drawing.Size(253, 148)
        Me.RBox.TabIndex = 10
        Me.RBox.TabStop = False
        Me.RBox.Text = "Seleciona uma Opção"
        '
        'RPerimetro
        '
        Me.RPerimetro.AutoSize = True
        Me.RPerimetro.Location = New System.Drawing.Point(6, 93)
        Me.RPerimetro.Name = "RPerimetro"
        Me.RPerimetro.Size = New System.Drawing.Size(80, 17)
        Me.RPerimetro.TabIndex = 1
        Me.RPerimetro.TabStop = True
        Me.RPerimetro.Text = "Perímetro"
        Me.RPerimetro.UseVisualStyleBackColor = True
        '
        'RArea
        '
        Me.RArea.AutoSize = True
        Me.RArea.Location = New System.Drawing.Point(6, 46)
        Me.RArea.Name = "RArea"
        Me.RArea.Size = New System.Drawing.Size(51, 17)
        Me.RArea.TabIndex = 0
        Me.RArea.TabStop = True
        Me.RArea.Text = "Área"
        Me.RArea.UseVisualStyleBackColor = True
        '
        'LblResultado
        '
        Me.LblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblResultado.Location = New System.Drawing.Point(290, 231)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(216, 116)
        Me.LblResultado.TabIndex = 14
        Me.LblResultado.Text = "Resultado"
        Me.LblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(115, 158)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(94, 20)
        Me.TxtA.TabIndex = 15
        Me.TxtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(115, 214)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(94, 20)
        Me.TxtB.TabIndex = 16
        Me.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(115, 274)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(94, 20)
        Me.TxtC.TabIndex = 17
        Me.TxtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.RBox)
        Me.Controls.Add(Me.LblLadoC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblLaboB)
        Me.Controls.Add(Me.LblLadoA)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.LblTittle)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Name = "Form1"
        Me.Text = "Prog20DiogoDias"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RBox.ResumeLayout(False)
        Me.RBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LblTittle As Label
    Friend WithEvents LblDev As Label
    Friend WithEvents LblLadoA As Label
    Friend WithEvents LblLaboB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblLadoC As Label
    Friend WithEvents RBox As GroupBox
    Friend WithEvents RPerimetro As RadioButton
    Friend WithEvents RArea As RadioButton
    Friend WithEvents LblResultado As Label
    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents TxtC As TextBox
End Class
