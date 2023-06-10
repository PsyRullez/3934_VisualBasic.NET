<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtNome = New TextBox()
        TxtApelido = New TextBox()
        BtnJuntar = New Button()
        BtnLimpar = New Button()
        LblJuntos = New Label()
        BtnAmarelo = New Button()
        btnVermelho = New Button()
        BtnAzul = New Button()
        BtnSair = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' TxtNome
        ' 
        TxtNome.Location = New Point(78, 38)
        TxtNome.Multiline = True
        TxtNome.Name = "TxtNome"
        TxtNome.Size = New Size(167, 39)
        TxtNome.TabIndex = 0
        ' 
        ' TxtApelido
        ' 
        TxtApelido.Location = New Point(492, 38)
        TxtApelido.Multiline = True
        TxtApelido.Name = "TxtApelido"
        TxtApelido.Size = New Size(167, 39)
        TxtApelido.TabIndex = 1
        ' 
        ' BtnJuntar
        ' 
        BtnJuntar.Location = New Point(78, 97)
        BtnJuntar.Name = "BtnJuntar"
        BtnJuntar.Size = New Size(167, 39)
        BtnJuntar.TabIndex = 2
        BtnJuntar.Text = "Juntar Nomes"
        BtnJuntar.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.Location = New Point(492, 113)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(167, 39)
        BtnLimpar.TabIndex = 3
        BtnLimpar.Text = "Limpar Nomes"
        BtnLimpar.UseVisualStyleBackColor = True
        ' 
        ' LblJuntos
        ' 
        LblJuntos.Location = New Point(78, 170)
        LblJuntos.Name = "LblJuntos"
        LblJuntos.Size = New Size(581, 57)
        LblJuntos.TabIndex = 4
        ' 
        ' BtnAmarelo
        ' 
        BtnAmarelo.Location = New Point(149, 295)
        BtnAmarelo.Name = "BtnAmarelo"
        BtnAmarelo.Size = New Size(96, 31)
        BtnAmarelo.TabIndex = 5
        BtnAmarelo.Text = "Amarelo"
        BtnAmarelo.UseVisualStyleBackColor = True
        ' 
        ' btnVermelho
        ' 
        btnVermelho.Location = New Point(316, 295)
        btnVermelho.Name = "btnVermelho"
        btnVermelho.Size = New Size(96, 31)
        btnVermelho.TabIndex = 6
        btnVermelho.Text = "Vermelho"
        btnVermelho.UseVisualStyleBackColor = True
        ' 
        ' BtnAzul
        ' 
        BtnAzul.Location = New Point(492, 295)
        BtnAzul.Name = "BtnAzul"
        BtnAzul.Size = New Size(96, 31)
        BtnAzul.TabIndex = 7
        BtnAzul.Text = "Azul"
        BtnAzul.UseVisualStyleBackColor = True
        ' 
        ' BtnSair
        ' 
        BtnSair.Location = New Point(316, 381)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(96, 31)
        BtnSair.TabIndex = 8
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 9
        TextBox1.Text = "Nome"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(532, 12)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 10
        TextBox2.Text = "Apelido"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(BtnSair)
        Controls.Add(BtnAzul)
        Controls.Add(btnVermelho)
        Controls.Add(BtnAmarelo)
        Controls.Add(LblJuntos)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnJuntar)
        Controls.Add(TxtApelido)
        Controls.Add(TxtNome)
        Name = "Form1"
        Text = "Programa 6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtApelido As TextBox
    Friend WithEvents BtnJuntar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblJuntos As Label
    Friend WithEvents BtnAmarelo As Button
    Friend WithEvents btnVermelho As Button
    Friend WithEvents BtnAzul As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
