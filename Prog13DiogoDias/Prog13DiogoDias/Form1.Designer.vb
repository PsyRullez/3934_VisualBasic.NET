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
        Me.LblNumeroSorteado = New System.Windows.Forms.Label()
        Me.LblMensagem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NudNum = New System.Windows.Forms.NumericUpDown()
        Me.BtnVerificar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnNovoJogo = New System.Windows.Forms.Button()
        CType(Me.NudNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNumeroSorteado
        '
        Me.LblNumeroSorteado.BackColor = System.Drawing.Color.Green
        Me.LblNumeroSorteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblNumeroSorteado.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblNumeroSorteado.Location = New System.Drawing.Point(330, 26)
        Me.LblNumeroSorteado.Name = "LblNumeroSorteado"
        Me.LblNumeroSorteado.Size = New System.Drawing.Size(97, 60)
        Me.LblNumeroSorteado.TabIndex = 0
        Me.LblNumeroSorteado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMensagem
        '
        Me.LblMensagem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.LblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblMensagem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblMensagem.Location = New System.Drawing.Point(122, 123)
        Me.LblMensagem.Name = "LblMensagem"
        Me.LblMensagem.Size = New System.Drawing.Size(492, 60)
        Me.LblMensagem.TabIndex = 1
        Me.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(194, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escolhe um número entre 1 e 100"
        '
        'NudNum
        '
        Me.NudNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NudNum.Location = New System.Drawing.Point(334, 248)
        Me.NudNum.Name = "NudNum"
        Me.NudNum.Size = New System.Drawing.Size(64, 26)
        Me.NudNum.TabIndex = 3
        Me.NudNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnVerificar
        '
        Me.BtnVerificar.BackColor = System.Drawing.Color.Aqua
        Me.BtnVerificar.Location = New System.Drawing.Point(310, 305)
        Me.BtnVerificar.Name = "BtnVerificar"
        Me.BtnVerificar.Size = New System.Drawing.Size(117, 23)
        Me.BtnVerificar.TabIndex = 4
        Me.BtnVerificar.Text = "Verificar escolha"
        Me.BtnVerificar.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Red
        Me.BtnSair.Location = New System.Drawing.Point(497, 400)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(117, 23)
        Me.BtnSair.TabIndex = 5
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnNovoJogo
        '
        Me.BtnNovoJogo.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnNovoJogo.Location = New System.Drawing.Point(126, 400)
        Me.BtnNovoJogo.Name = "BtnNovoJogo"
        Me.BtnNovoJogo.Size = New System.Drawing.Size(117, 23)
        Me.BtnNovoJogo.TabIndex = 6
        Me.BtnNovoJogo.Text = "Novo Jogo"
        Me.BtnNovoJogo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnNovoJogo)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnVerificar)
        Me.Controls.Add(Me.NudNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblMensagem)
        Me.Controls.Add(Me.LblNumeroSorteado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NudNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumeroSorteado As Label
    Friend WithEvents LblMensagem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NudNum As NumericUpDown
    Friend WithEvents BtnVerificar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnNovoJogo As Button
End Class
