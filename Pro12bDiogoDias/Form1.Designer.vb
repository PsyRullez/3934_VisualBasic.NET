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
        LblTittle = New Label()
        LblNumerosSorteados = New Label()
        BtnSortear = New Button()
        BtnSair = New Button()
        SuspendLayout()
        ' 
        ' LblTittle
        ' 
        LblTittle.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblTittle.ForeColor = Color.Red
        LblTittle.Location = New Point(169, 30)
        LblTittle.Name = "LblTittle"
        LblTittle.Size = New Size(226, 30)
        LblTittle.TabIndex = 0
        LblTittle.Text = "Sorteador de Números"
        LblTittle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblNumerosSorteados
        ' 
        LblNumerosSorteados.BackColor = Color.Orange
        LblNumerosSorteados.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblNumerosSorteados.Location = New Point(73, 128)
        LblNumerosSorteados.Name = "LblNumerosSorteados"
        LblNumerosSorteados.Size = New Size(370, 42)
        LblNumerosSorteados.TabIndex = 1
        LblNumerosSorteados.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnSortear
        ' 
        BtnSortear.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSortear.Location = New Point(22, 259)
        BtnSortear.Name = "BtnSortear"
        BtnSortear.Size = New Size(75, 42)
        BtnSortear.TabIndex = 2
        BtnSortear.Text = "Sortear"
        BtnSortear.UseVisualStyleBackColor = True
        ' 
        ' BtnSair
        ' 
        BtnSair.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSair.Location = New Point(409, 259)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New Size(75, 42)
        BtnSair.TabIndex = 3
        BtnSair.Text = "Sair"
        BtnSair.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 313)
        Controls.Add(BtnSair)
        Controls.Add(BtnSortear)
        Controls.Add(LblNumerosSorteados)
        Controls.Add(LblTittle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents LblNumerosSorteados As Label
    Friend WithEvents BtnSortear As Button
    Friend WithEvents BtnSair As Button
End Class
