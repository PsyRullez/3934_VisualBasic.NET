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
        BtnEsquerdo = New Button()
        BtnDireito = New Button()
        LblMensagem = New Label()
        BtnSair = New Button()
        LblAutor = New Label()
        SuspendLayout()
        ' 
        ' BtnEsquerdo
        ' 
        BtnEsquerdo.Location = New Point(78, 63)
        BtnEsquerdo.Name = "BtnEsquerdo"
        BtnEsquerdo.Size = New Size(116, 43)
        BtnEsquerdo.TabIndex = 0
        BtnEsquerdo.Text = "Esquerdo"
        BtnEsquerdo.UseVisualStyleBackColor = True
        ' 
        ' BtnDireito
        ' 
        BtnDireito.Location = New Point(567, 63)
        BtnDireito.Name = "BtnDireito"
        BtnDireito.Size = New Size(116, 43)
        BtnDireito.TabIndex = 1
        BtnDireito.Text = "Direito"
        BtnDireito.UseVisualStyleBackColor = True
        ' 
        ' LblMensagem
        ' 
        LblMensagem.Location = New Point(205, 183)
        LblMensagem.Name = "LblMensagem"
        LblMensagem.Size = New Size(343, 67)
        LblMensagem.TabIndex = 2
        ' 
        ' BtnSair
        ' 
        BtnSair.BackColor = Color.Red
        BtnSair.Location = New Point(691, 346)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(75, 23)
        BtnSair.TabIndex = 3
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = False
        ' 
        ' LblAutor
        ' 
        LblAutor.AutoSize = True
        LblAutor.Location = New Point(32, 328)
        LblAutor.Name = "LblAutor"
        LblAutor.Size = New Size(64, 15)
        LblAutor.TabIndex = 4
        LblAutor.Text = "Diogo Dias"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(771, 377)
        Controls.Add(LblAutor)
        Controls.Add(BtnSair)
        Controls.Add(LblMensagem)
        Controls.Add(BtnDireito)
        Controls.Add(BtnEsquerdo)
        Name = "Form1"
        Text = "Programa5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnEsquerdo As Button
    Friend WithEvents BtnDireito As Button
    Friend WithEvents LblMensagem As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblAutor As Label
End Class
