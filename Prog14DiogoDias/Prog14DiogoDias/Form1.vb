Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim num1 As Integer
        If Not Integer.TryParse(TxtNum1.Text, num1) Then
            MsgBox("Erro")
            TxtNum1.Text = ""
            TxtNum2.Text = "" 'BugPreventing
            TxtNum1.Focus()
            Return
        End If
        Dim num2 As Integer
        If Not Integer.TryParse(TxtNum1.Text, num2) Then
            MsgBox("Erro")
            TxtNum1.Text = "" 'durante os teste, o mesmo na condiçao de erro só um dos campos
            TxtNum2.Text = ""
            TxtNum2.Focus()
            Return
        End If
        Dim Operacao = TxtOperacao.Text

        Select Case Operacao
            Case "+"
                Dim resultado As Integer = num1 + num2
                TxtResultado.Text = "A Soma é:" & resultado.ToString()
            Case "-"
                Dim resultado As Integer = num1 - num2
                TxtResultado.Text = "A Subtração é:" & resultado.ToString()
            Case "*"
                Dim resultado As Integer = num1 * num2
                TxtResultado.Text = " A Multiplicação é:" & resultado.ToString()
            Case "/"
                Dim resultado As Integer = num1 / num2
                TxtResultado.Text = "A Divisão deste resultado é:" & resultado.ToString()
            Case Else
                TxtResultado.Text = "Erro"
        End Select

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        TxtOperacao.Text = ""
    End Sub
End Class
