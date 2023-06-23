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
        Me.LblNumeroSorteado = New System.Windows.Forms.Label()
        Me.BtnSortear = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblDev = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTittle
        '
        Me.LblTittle.BackColor = System.Drawing.Color.Transparent
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTittle.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTittle.Location = New System.Drawing.Point(118, 41)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(298, 50)
        Me.LblTittle.TabIndex = 0
        Me.LblTittle.Text = "Sorteador de Números"
        Me.LblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNumeroSorteado
        '
        Me.LblNumeroSorteado.BackColor = System.Drawing.Color.LightCoral
        Me.LblNumeroSorteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.LblNumeroSorteado.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblNumeroSorteado.Location = New System.Drawing.Point(87, 108)
        Me.LblNumeroSorteado.Name = "LblNumeroSorteado"
        Me.LblNumeroSorteado.Size = New System.Drawing.Size(342, 95)
        Me.LblNumeroSorteado.TabIndex = 1
        Me.LblNumeroSorteado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSortear
        '
        Me.BtnSortear.Location = New System.Drawing.Point(92, 226)
        Me.BtnSortear.Name = "BtnSortear"
        Me.BtnSortear.Size = New System.Drawing.Size(75, 23)
        Me.BtnSortear.TabIndex = 2
        Me.BtnSortear.Text = "Sortear"
        Me.BtnSortear.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(364, 226)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 3
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'LblDev
        '
        Me.LblDev.AutoSize = True
        Me.LblDev.Location = New System.Drawing.Point(12, 269)
        Me.LblDev.Name = "LblDev"
        Me.LblDev.Size = New System.Drawing.Size(59, 13)
        Me.LblDev.TabIndex = 4
        Me.LblDev.Text = "Diogo Dias"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 300)
        Me.Controls.Add(Me.LblDev)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnSortear)
        Me.Controls.Add(Me.LblNumeroSorteado)
        Me.Controls.Add(Me.LblTittle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTittle As Label
    Friend WithEvents LblNumeroSorteado As Label
    Friend WithEvents BtnSortear As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblDev As Label
End Class
