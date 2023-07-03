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
        Me.TxtLista = New System.Windows.Forms.TextBox()
        Me.TxtPriNum = New System.Windows.Forms.TextBox()
        Me.TxtUltNum = New System.Windows.Forms.TextBox()
        Me.LblPriNumero = New System.Windows.Forms.Label()
        Me.LblUltNum = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(151, 29)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(130, 20)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "Listar Números"
        '
        'TxtLista
        '
        Me.TxtLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.TxtLista.Location = New System.Drawing.Point(335, 124)
        Me.TxtLista.Multiline = True
        Me.TxtLista.Name = "TxtLista"
        Me.TxtLista.Size = New System.Drawing.Size(127, 468)
        Me.TxtLista.TabIndex = 1
        Me.TxtLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPriNum
        '
        Me.TxtPriNum.Location = New System.Drawing.Point(80, 165)
        Me.TxtPriNum.Name = "TxtPriNum"
        Me.TxtPriNum.Size = New System.Drawing.Size(100, 20)
        Me.TxtPriNum.TabIndex = 2
        Me.TxtPriNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUltNum
        '
        Me.TxtUltNum.Location = New System.Drawing.Point(80, 259)
        Me.TxtUltNum.Name = "TxtUltNum"
        Me.TxtUltNum.Size = New System.Drawing.Size(100, 20)
        Me.TxtUltNum.TabIndex = 3
        Me.TxtUltNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPriNumero
        '
        Me.LblPriNumero.AutoSize = True
        Me.LblPriNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblPriNumero.Location = New System.Drawing.Point(76, 131)
        Me.LblPriNumero.Name = "LblPriNumero"
        Me.LblPriNumero.Size = New System.Drawing.Size(141, 20)
        Me.LblPriNumero.TabIndex = 4
        Me.LblPriNumero.Text = "Primeiro Número"
        '
        'LblUltNum
        '
        Me.LblUltNum.AutoSize = True
        Me.LblUltNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblUltNum.Location = New System.Drawing.Point(76, 224)
        Me.LblUltNum.Name = "LblUltNum"
        Me.LblUltNum.Size = New System.Drawing.Size(127, 20)
        Me.LblUltNum.TabIndex = 5
        Me.LblUltNum.Text = "Último Número"
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Orange
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BtnSair.Location = New System.Drawing.Point(12, 516)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 6
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnListar
        '
        Me.BtnListar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BtnListar.Location = New System.Drawing.Point(12, 423)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(75, 23)
        Me.BtnListar.TabIndex = 7
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.BtnLimpar.Location = New System.Drawing.Point(12, 335)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 8
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblDev.Location = New System.Drawing.Point(8, 595)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(97, 20)
        Me.LblDev.TabIndex = 9
        Me.LblDev.Text = "Diogo Dias"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 619)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblUltNum)
        Me.Controls.Add(Me.LblPriNumero)
        Me.Controls.Add(Me.TxtUltNum)
        Me.Controls.Add(Me.TxtPriNum)
        Me.Controls.Add(Me.TxtLista)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents TxtLista As TextBox
    Friend WithEvents TxtPriNum As TextBox
    Friend WithEvents TxtUltNum As TextBox
    Friend WithEvents LblPriNumero As Label
    Friend WithEvents LblUltNum As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblDev As Label
End Class
