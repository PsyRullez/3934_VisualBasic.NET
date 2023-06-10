Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        LblResultado.Text = ""
    End Sub

    Private Sub BtnMaior_Click(sender As Object, e As EventArgs) Handles BtnMaior.Click
        Dim num1 As Integer
        Dim num2 As Integer

        If Integer.TryParse(TxtNum1.Text, num1) AndAlso Integer.TryParse(TxtNum2.Text, num2) Then
            If num1 > num2 Then
                LblResultado.Text = "O Número maior é o " & num1.ToString()
            ElseIf num2 > num1 Then
                LblResultado.Text = "O Número maior é o " & num2.ToString()
            Else
                LblResultado.Text = "Os Números são iguais a " & num1.ToString()
            End If
        Else
            LblResultado.Text = "Insira números válidos nos campos."
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
