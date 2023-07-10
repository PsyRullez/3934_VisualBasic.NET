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
        Me.BtnInserirNotas = New System.Windows.Forms.Button()
        Me.LblNotasdosTestes = New System.Windows.Forms.Label()
        Me.LblTittleMedia = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.LstNotas = New System.Windows.Forms.ListBox()
        Me.LblMedia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(81, 25)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(269, 25)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "Calcular média dos Testes"
        '
        'BtnInserirNotas
        '
        Me.BtnInserirNotas.BackColor = System.Drawing.Color.Blue
        Me.BtnInserirNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInserirNotas.ForeColor = System.Drawing.Color.White
        Me.BtnInserirNotas.Location = New System.Drawing.Point(86, 76)
        Me.BtnInserirNotas.Name = "BtnInserirNotas"
        Me.BtnInserirNotas.Size = New System.Drawing.Size(287, 50)
        Me.BtnInserirNotas.TabIndex = 1
        Me.BtnInserirNotas.Text = "Inserir as notas dos testes"
        Me.BtnInserirNotas.UseVisualStyleBackColor = False
        '
        'LblNotasdosTestes
        '
        Me.LblNotasdosTestes.AutoSize = True
        Me.LblNotasdosTestes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblNotasdosTestes.Location = New System.Drawing.Point(12, 161)
        Me.LblNotasdosTestes.Name = "LblNotasdosTestes"
        Me.LblNotasdosTestes.Size = New System.Drawing.Size(130, 17)
        Me.LblNotasdosTestes.TabIndex = 2
        Me.LblNotasdosTestes.Text = "Notas dos testes"
        '
        'LblTittleMedia
        '
        Me.LblTittleMedia.AutoSize = True
        Me.LblTittleMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittleMedia.Location = New System.Drawing.Point(353, 181)
        Me.LblTittleMedia.Name = "LblTittleMedia"
        Me.LblTittleMedia.Size = New System.Drawing.Size(131, 17)
        Me.LblTittleMedia.TabIndex = 3
        Me.LblTittleMedia.Text = "Média dos testes"
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Crimson
        Me.BtnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSair.Location = New System.Drawing.Point(460, 370)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(79, 37)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.IndianRed
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLimpar.Location = New System.Drawing.Point(281, 370)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(79, 37)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Location = New System.Drawing.Point(12, 428)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(59, 13)
        Me.LblDev.TabIndex = 6
        Me.LblDev.Text = "Diogo Dias"
        '
        'LstNotas
        '
        Me.LstNotas.FormattingEnabled = True
        Me.LstNotas.Location = New System.Drawing.Point(26, 181)
        Me.LstNotas.Name = "LstNotas"
        Me.LstNotas.Size = New System.Drawing.Size(116, 238)
        Me.LstNotas.TabIndex = 7
        '
        'LblMedia
        '
        Me.LblMedia.BackColor = System.Drawing.Color.Beige
        Me.LblMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblMedia.Location = New System.Drawing.Point(353, 232)
        Me.LblMedia.Name = "LblMedia"
        Me.LblMedia.Size = New System.Drawing.Size(139, 65)
        Me.LblMedia.TabIndex = 8
        Me.LblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(605, 450)
        Me.Controls.Add(Me.LblMedia)
        Me.Controls.Add(Me.LstNotas)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblTittleMedia)
        Me.Controls.Add(Me.LblNotasdosTestes)
        Me.Controls.Add(Me.BtnInserirNotas)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Prog15DiogoDias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents BtnInserirNotas As Button
    Friend WithEvents LblNotasdosTestes As Label
    Friend WithEvents LblTittleMedia As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblDev As Label
    Friend WithEvents LstNotas As ListBox
    Friend WithEvents LblMedia As Label
End Class
