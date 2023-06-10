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
        TxtNum1 = New TextBox()
        TxtNum2 = New TextBox()
        BtnMaior = New Button()
        BtnLimpar = New Button()
        LblResultado = New Label()
        BtnSair = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TxtNum1
        ' 
        TxtNum1.Location = New Point(43, 38)
        TxtNum1.Multiline = True
        TxtNum1.Name = "TxtNum1"
        TxtNum1.Size = New Size(129, 35)
        TxtNum1.TabIndex = 0
        ' 
        ' TxtNum2
        ' 
        TxtNum2.Location = New Point(330, 38)
        TxtNum2.Multiline = True
        TxtNum2.Name = "TxtNum2"
        TxtNum2.Size = New Size(129, 35)
        TxtNum2.TabIndex = 1
        ' 
        ' BtnMaior
        ' 
        BtnMaior.Location = New Point(43, 185)
        BtnMaior.Name = "BtnMaior"
        BtnMaior.Size = New Size(129, 43)
        BtnMaior.TabIndex = 2
        BtnMaior.Text = "Qual é o Maior?"
        BtnMaior.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpar
        ' 
        BtnLimpar.Location = New Point(330, 185)
        BtnLimpar.Name = "BtnLimpar"
        BtnLimpar.Size = New Size(129, 43)
        BtnLimpar.TabIndex = 3
        BtnLimpar.Text = "Limpar"
        BtnLimpar.UseVisualStyleBackColor = True
        ' 
        ' LblResultado
        ' 
        LblResultado.Location = New Point(43, 283)
        LblResultado.Name = "LblResultado"
        LblResultado.Size = New Size(416, 50)
        LblResultado.TabIndex = 4
        ' 
        ' BtnSair
        ' 
        BtnSair.BackColor = Color.Red
        BtnSair.Location = New Point(455, 352)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(77, 43)
        BtnSair.TabIndex = 5
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Bottom
        Label2.Location = New Point(0, 392)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 6
        Label2.Text = "Diogo Dias"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(89, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 15)
        Label3.TabIndex = 7
        Label3.Text = "1º Número"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(371, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 8
        Label4.Text = "2º Número"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(544, 407)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnSair)
        Controls.Add(LblResultado)
        Controls.Add(BtnLimpar)
        Controls.Add(BtnMaior)
        Controls.Add(TxtNum2)
        Controls.Add(TxtNum1)
        Name = "Form1"
        Text = "Programa 8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents BtnMaior As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents LblResultado As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
