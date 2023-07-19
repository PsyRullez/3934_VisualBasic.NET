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
        Me.LstNumeros = New System.Windows.Forms.ListBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSortear = New System.Windows.Forms.Button()
        Me.BtnOrdenar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstNumeros
        '
        Me.LstNumeros.FormattingEnabled = True
        Me.LstNumeros.Location = New System.Drawing.Point(90, 53)
        Me.LstNumeros.Name = "LstNumeros"
        Me.LstNumeros.Size = New System.Drawing.Size(220, 316)
        Me.LstNumeros.TabIndex = 0
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(444, 78)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(98, 36)
        Me.BtnLimpar.TabIndex = 1
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSortear
        '
        Me.BtnSortear.Location = New System.Drawing.Point(444, 148)
        Me.BtnSortear.Name = "BtnSortear"
        Me.BtnSortear.Size = New System.Drawing.Size(98, 36)
        Me.BtnSortear.TabIndex = 2
        Me.BtnSortear.Text = "Sortear"
        Me.BtnSortear.UseVisualStyleBackColor = True
        '
        'BtnOrdenar
        '
        Me.BtnOrdenar.Location = New System.Drawing.Point(444, 225)
        Me.BtnOrdenar.Name = "BtnOrdenar"
        Me.BtnOrdenar.Size = New System.Drawing.Size(98, 36)
        Me.BtnOrdenar.TabIndex = 3
        Me.BtnOrdenar.Text = "Ordenar"
        Me.BtnOrdenar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(444, 305)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(98, 36)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 450)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnOrdenar)
        Me.Controls.Add(Me.BtnSortear)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.LstNumeros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstNumeros As ListBox
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSortear As Button
    Friend WithEvents BtnOrdenar As Button
    Friend WithEvents BtnSair As Button
End Class
