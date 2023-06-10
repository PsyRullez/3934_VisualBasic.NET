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
        BtnEscrever = New Button()
        BtnApagar = New Button()
        LblTexto = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TxtNome
        ' 
        TxtNome.Location = New Point(196, 49)
        TxtNome.Multiline = True
        TxtNome.Name = "TxtNome"
        TxtNome.Size = New Size(414, 41)
        TxtNome.TabIndex = 0
        ' 
        ' TxtApelido
        ' 
        TxtApelido.Location = New Point(196, 96)
        TxtApelido.Multiline = True
        TxtApelido.Name = "TxtApelido"
        TxtApelido.Size = New Size(414, 41)
        TxtApelido.TabIndex = 1
        ' 
        ' BtnEscrever
        ' 
        BtnEscrever.Location = New Point(196, 269)
        BtnEscrever.Name = "BtnEscrever"
        BtnEscrever.Size = New Size(90, 35)
        BtnEscrever.TabIndex = 2
        BtnEscrever.Text = "Escrever"
        BtnEscrever.UseVisualStyleBackColor = True
        ' 
        ' BtnApagar
        ' 
        BtnApagar.Location = New Point(523, 269)
        BtnApagar.Name = "BtnApagar"
        BtnApagar.Size = New Size(87, 35)
        BtnApagar.TabIndex = 3
        BtnApagar.Text = "Apagar"
        BtnApagar.UseVisualStyleBackColor = True
        ' 
        ' LblTexto
        ' 
        LblTexto.Location = New Point(196, 395)
        LblTexto.Name = "LblTexto"
        LblTexto.Size = New Size(414, 26)
        LblTexto.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(702, 419)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 5
        Label1.Text = "Carlos Bastos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LblTexto)
        Controls.Add(BtnApagar)
        Controls.Add(BtnEscrever)
        Controls.Add(TxtApelido)
        Controls.Add(TxtNome)
        Name = "Form1"
        Text = "Programa4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtApelido As TextBox
    Friend WithEvents BtnEscrever As Button
    Friend WithEvents BtnApagar As Button
    Friend WithEvents LblTexto As Label
    Friend WithEvents Label1 As Label
End Class
