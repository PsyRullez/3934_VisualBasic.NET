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
        TxtCaixa = New TextBox()
        BtnEscrever = New Button()
        BtnApagar = New Button()
        LblEscrever = New Label()
        LblAutor = New Label()
        SuspendLayout()
        ' 
        ' TxtCaixa
        ' 
        TxtCaixa.Location = New Point(217, 82)
        TxtCaixa.Multiline = True
        TxtCaixa.Name = "TxtCaixa"
        TxtCaixa.Size = New Size(401, 50)
        TxtCaixa.TabIndex = 0
        ' 
        ' BtnEscrever
        ' 
        BtnEscrever.Location = New Point(217, 216)
        BtnEscrever.Name = "BtnEscrever"
        BtnEscrever.Size = New Size(75, 23)
        BtnEscrever.TabIndex = 1
        BtnEscrever.Text = "Escrever"
        BtnEscrever.UseVisualStyleBackColor = True
        ' 
        ' BtnApagar
        ' 
        BtnApagar.Location = New Point(543, 216)
        BtnApagar.Name = "BtnApagar"
        BtnApagar.Size = New Size(75, 23)
        BtnApagar.TabIndex = 2
        BtnApagar.Text = "Apagar"
        BtnApagar.UseVisualStyleBackColor = True
        ' 
        ' LblEscrever
        ' 
        LblEscrever.Location = New Point(217, 381)
        LblEscrever.Name = "LblEscrever"
        LblEscrever.Size = New Size(401, 39)
        LblEscrever.TabIndex = 3
        ' 
        ' LblAutor
        ' 
        LblAutor.AutoSize = True
        LblAutor.Location = New Point(714, 426)
        LblAutor.Name = "LblAutor"
        LblAutor.Size = New Size(74, 15)
        LblAutor.TabIndex = 4
        LblAutor.Text = "CarlosBastos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblAutor)
        Controls.Add(LblEscrever)
        Controls.Add(BtnApagar)
        Controls.Add(BtnEscrever)
        Controls.Add(TxtCaixa)
        Name = "Form1"
        Text = "Programa3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtCaixa As TextBox
    Friend WithEvents BtnEscrever As Button
    Friend WithEvents BtnApagar As Button
    Friend WithEvents LblEscrever As Label
    Friend WithEvents LblAutor As Label
End Class
