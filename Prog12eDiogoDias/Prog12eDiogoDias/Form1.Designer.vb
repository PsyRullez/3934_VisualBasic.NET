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
        Me.TxtLista = New System.Windows.Forms.TextBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(101, 40)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(208, 20)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "Listar números de 1 a 12"
        Me.LblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtLista
        '
        Me.TxtLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtLista.Location = New System.Drawing.Point(285, 98)
        Me.TxtLista.Multiline = True
        Me.TxtLista.Name = "TxtLista"
        Me.TxtLista.Size = New System.Drawing.Size(102, 428)
        Me.TxtLista.TabIndex = 1
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.Orange
        Me.BtnSair.Location = New System.Drawing.Point(331, 544)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 2
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'BtnListar
        '
        Me.BtnListar.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnListar.Location = New System.Drawing.Point(172, 544)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(75, 23)
        Me.BtnListar.TabIndex = 3
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpar.Location = New System.Drawing.Point(12, 544)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 4
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 593)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.TxtLista)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents TxtLista As TextBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnLimpar As Button
End Class
