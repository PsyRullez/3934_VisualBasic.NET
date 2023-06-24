<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblValorMax = New System.Windows.Forms.Label()
        Me.TxtValorMax = New System.Windows.Forms.TextBox()
        Me.LblValoresaSortear = New System.Windows.Forms.Label()
        Me.TxtNúmeroDeValores = New System.Windows.Forms.TextBox()
        Me.BtnSortearNumeros = New System.Windows.Forms.Button()
        Me.TxtNúmerosSorteados = New System.Windows.Forms.TextBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblTittle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(399, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor Minimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(559, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1"
        '
        'LblValorMax
        '
        Me.LblValorMax.AutoSize = True
        Me.LblValorMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LblValorMax.Location = New System.Drawing.Point(396, 85)
        Me.LblValorMax.Name = "LblValorMax"
        Me.LblValorMax.Size = New System.Drawing.Size(104, 17)
        Me.LblValorMax.TabIndex = 2
        Me.LblValorMax.Text = "Valor Maximo"
        '
        'TxtValorMax
        '
        Me.TxtValorMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.TxtValorMax.Location = New System.Drawing.Point(533, 82)
        Me.TxtValorMax.Multiline = True
        Me.TxtValorMax.Name = "TxtValorMax"
        Me.TxtValorMax.Size = New System.Drawing.Size(43, 20)
        Me.TxtValorMax.TabIndex = 3
        Me.TxtValorMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblValoresaSortear
        '
        Me.LblValoresaSortear.AutoSize = True
        Me.LblValoresaSortear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LblValoresaSortear.Location = New System.Drawing.Point(260, 129)
        Me.LblValoresaSortear.Name = "LblValoresaSortear"
        Me.LblValoresaSortear.Size = New System.Drawing.Size(240, 17)
        Me.LblValoresaSortear.TabIndex = 4
        Me.LblValoresaSortear.Text = "Quantos Valores quer Sortear ?"
        '
        'TxtNúmeroDeValores
        '
        Me.TxtNúmeroDeValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNúmeroDeValores.Location = New System.Drawing.Point(533, 126)
        Me.TxtNúmeroDeValores.Multiline = True
        Me.TxtNúmeroDeValores.Name = "TxtNúmeroDeValores"
        Me.TxtNúmeroDeValores.Size = New System.Drawing.Size(43, 20)
        Me.TxtNúmeroDeValores.TabIndex = 5
        Me.TxtNúmeroDeValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSortearNumeros
        '
        Me.BtnSortearNumeros.Location = New System.Drawing.Point(393, 164)
        Me.BtnSortearNumeros.Name = "BtnSortearNumeros"
        Me.BtnSortearNumeros.Size = New System.Drawing.Size(107, 23)
        Me.BtnSortearNumeros.TabIndex = 6
        Me.BtnSortearNumeros.Text = "Sortear Numeros"
        Me.BtnSortearNumeros.UseVisualStyleBackColor = True
        '
        'TxtNúmerosSorteados
        '
        Me.TxtNúmerosSorteados.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TxtNúmerosSorteados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNúmerosSorteados.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtNúmerosSorteados.Location = New System.Drawing.Point(78, 209)
        Me.TxtNúmerosSorteados.Multiline = True
        Me.TxtNúmerosSorteados.Name = "TxtNúmerosSorteados"
        Me.TxtNúmerosSorteados.Size = New System.Drawing.Size(315, 30)
        Me.TxtNúmerosSorteados.TabIndex = 7
        Me.TxtNúmerosSorteados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(263, 276)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(107, 23)
        Me.BtnSair.TabIndex = 8
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'LblTittle
        '
        Me.LblTittle.AutoSize = True
        Me.LblTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.LblTittle.Location = New System.Drawing.Point(198, 19)
        Me.LblTittle.Name = "LblTittle"
        Me.LblTittle.Size = New System.Drawing.Size(172, 17)
        Me.LblTittle.TabIndex = 9
        Me.LblTittle.Text = "Sorteador de Números"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 311)
        Me.Controls.Add(Me.LblTittle)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.TxtNúmerosSorteados)
        Me.Controls.Add(Me.BtnSortearNumeros)
        Me.Controls.Add(Me.TxtNúmeroDeValores)
        Me.Controls.Add(Me.LblValoresaSortear)
        Me.Controls.Add(Me.TxtValorMax)
        Me.Controls.Add(Me.LblValorMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblValorMax As Label
    Friend WithEvents TxtValorMax As TextBox
    Friend WithEvents LblValoresaSortear As Label
    Friend WithEvents TxtNúmeroDeValores As TextBox
    Friend WithEvents BtnSortearNumeros As Button
    Friend WithEvents TxtNúmerosSorteados As TextBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents LblTittle As Label
End Class
