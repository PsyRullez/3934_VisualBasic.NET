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
        BtnClicar = New Button()
        Label = New Label()
        SuspendLayout()
        ' 
        ' BtnClicar
        ' 
        BtnClicar.Location = New Point(256, 242)
        BtnClicar.Name = "BtnClicar"
        BtnClicar.Size = New Size(165, 54)
        BtnClicar.TabIndex = 0
        BtnClicar.Text = "Clicar"
        BtnClicar.UseVisualStyleBackColor = True
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(306, 578)
        Label.Name = "Label"
        Label.Size = New Size(77, 15)
        Label.TabIndex = 1
        Label.Text = "Carlos Bastos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(705, 615)
        Controls.Add(Label)
        Controls.Add(BtnClicar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnClicar As Button
    Friend WithEvents Label As Label
End Class
