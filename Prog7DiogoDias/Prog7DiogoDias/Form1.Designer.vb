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
        Me.TxtPrimeiroNum = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNum = New System.Windows.Forms.TextBox()
        Me.BtnSomar = New System.Windows.Forms.Button()
        Me.LblResultado = New System.Windows.Forms.Label()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtPrimeiroNum
        '
        Me.TxtPrimeiroNum.Location = New System.Drawing.Point(514, 60)
        Me.TxtPrimeiroNum.Multiline = True
        Me.TxtPrimeiroNum.Name = "TxtPrimeiroNum"
        Me.TxtPrimeiroNum.Size = New System.Drawing.Size(124, 39)
        Me.TxtPrimeiroNum.TabIndex = 0
        '
        'TxtSegundoNum
        '
        Me.TxtSegundoNum.Location = New System.Drawing.Point(514, 131)
        Me.TxtSegundoNum.Multiline = True
        Me.TxtSegundoNum.Name = "TxtSegundoNum"
        Me.TxtSegundoNum.Size = New System.Drawing.Size(124, 39)
        Me.TxtSegundoNum.TabIndex = 1
        '
        'BtnSomar
        '
        Me.BtnSomar.Location = New System.Drawing.Point(514, 215)
        Me.BtnSomar.Name = "BtnSomar"
        Me.BtnSomar.Size = New System.Drawing.Size(124, 46)
        Me.BtnSomar.TabIndex = 2
        Me.BtnSomar.Text = "Somar"
        Me.BtnSomar.UseVisualStyleBackColor = True
        '
        'LblResultado
        '
        Me.LblResultado.Location = New System.Drawing.Point(514, 314)
        Me.LblResultado.Name = "LblResultado"
        Me.LblResultado.Size = New System.Drawing.Size(124, 35)
        Me.LblResultado.TabIndex = 3
        Me.LblResultado.Text = "Label1"
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(289, 388)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(104, 40)
        Me.BtnLimpar.TabIndex = 4
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(534, 388)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(104, 40)
        Me.BtnSair.TabIndex = 5
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Diogo Dias"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(178, 60)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 39)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "Indique o 1º Número"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(178, 131)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 39)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "Indique o 2º Número"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(178, 307)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(138, 25)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "Resultado"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 435)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.LblResultado)
        Me.Controls.Add(Me.BtnSomar)
        Me.Controls.Add(Me.TxtSegundoNum)
        Me.Controls.Add(Me.TxtPrimeiroNum)
        Me.Name = "Form1"
        Me.Text = "Programa 7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPrimeiroNum As TextBox
    Friend WithEvents TxtSegundoNum As TextBox
    Friend WithEvents BtnSomar As Button
    Friend WithEvents LblResultado As Label
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox

    Private Sub TxtPrimeiroNum_TextChanged(sender As Object, e As EventArgs) Handles TxtPrimeiroNum.TextChanged
        Dim numericValue As Decimal
        If Decimal.TryParse(TxtPrimeiroNum.Text, numericValue) Then
            ' Valid numeric input
        Else
            TxtPrimeiroNum.Text = ""
        End If
    End Sub

    Private Sub TxtSegundoNum_TextChanged(sender As Object, e As EventArgs) Handles TxtSegundoNum.TextChanged
        Dim numericValue As Decimal
        If Decimal.TryParse(TxtSegundoNum.Text, numericValue) Then
            ' Valid numeric input
        Else
            TxtSegundoNum.Text = ""
        End If
    End Sub

    Private Sub BtnSomar_Click(sender As Object, e As EventArgs) Handles BtnSomar.Click
        Dim primeiroNum As Decimal
        Dim segundoNum As Decimal

        If Decimal.TryParse(TxtPrimeiroNum.Text, primeiroNum) AndAlso Decimal.TryParse(TxtSegundoNum.Text, segundoNum) Then
            Dim resultado As Decimal = primeiroNum + segundoNum
            LblResultado.Text = resultado.ToString()
        Else
            LblResultado.Text = "Invalid input"
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtPrimeiroNum.Text = " "
        TxtSegundoNum.Text = " "
        LblResultado.Text = " "
    End Sub

    Private Sub LblResultado_Click(sender As Object, e As EventArgs) Handles LblResultado.Click

    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
