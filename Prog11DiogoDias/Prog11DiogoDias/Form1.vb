Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Declaração de num1 e 2 como variaveis locais Inteiras
        Dim num1 As Integer = Integer.Parse(TxtNum1.Text)
        Dim num2 As Integer = Integer.Parse(TxtNum2.Text)
        'Opção Soma Ativa
        If RadSoma.Checked Then
            Dim resultado As Integer = num1 + num2
            LblResultado.Text = "A Soma é:" & resultado.ToString()
        End If
        'Opção Subtração Ativa
        If RadSubtração.Checked Then
            Dim resultado As Integer = num1 - num2
            LblResultado.Text = "A Subtração é:" & resultado.ToString()
        End If
        'Opção Multiplicação Ativa
        If RadMultiplicação.Checked Then
            Dim resultado As Integer = num1 * num2
            LblResultado.Text = "A Multiplicação é:" & resultado.ToString()
        End If
        'Opção Divisão Ativa
        If RadDivisão.Checked Then
            Dim resultado As Integer = num1 / num2
            LblResultado.Text = "A Divisão é:" & resultado.ToString()
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        'Limpar num1, num2 e Resultado
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        LblResultado.Text = ""
        'Reseta a Opção para 0
        RadSoma.Checked = False
        RadSubtração.Checked = False
        RadMultiplicação.Checked = False
        RadDivisão.Checked = False
    End Sub
End Class
