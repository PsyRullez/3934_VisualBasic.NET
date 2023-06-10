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
        BtnOk = New Button()
        BtnApagar = New Button()
        LblNomes = New Label()
        SuspendLayout()
        ' 
        ' BtnOk
        ' 
        BtnOk.Location = New Point(127, 440)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(136, 76)
        BtnOk.TabIndex = 0
        BtnOk.Text = "OK"
        BtnOk.UseVisualStyleBackColor = True
        ' 
        ' BtnApagar
        ' 
        BtnApagar.Location = New Point(504, 440)
        BtnApagar.Name = "BtnApagar"
        BtnApagar.Size = New Size(127, 76)
        BtnApagar.TabIndex = 1
        BtnApagar.Text = "Apagar"
        BtnApagar.UseVisualStyleBackColor = True
        ' 
        ' LblNomes
        ' 
        LblNomes.AutoSize = True
        LblNomes.Location = New Point(348, 175)
        LblNomes.Name = "LblNomes"
        LblNomes.Size = New Size(77, 15)
        LblNomes.TabIndex = 2
        LblNomes.Text = "Carlos Bastos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(818, 586)
        Controls.Add(LblNomes)
        Controls.Add(BtnApagar)
        Controls.Add(BtnOk)
        Name = "Form1"
        Text = "Programa2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnApagar As Button
    Friend WithEvents LblNomes As Label
End Class
