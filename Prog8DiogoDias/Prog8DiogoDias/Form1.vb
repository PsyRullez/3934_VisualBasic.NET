Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        LblResultado.Text = ""
    End Sub

    Private Sub BtnMaior_Click(sender As Object, e As EventArgs) Handles BtnMaior.Click
        Dim num1 As Integer = Val(TxtNum1.Text)
        Dim num2 As Integer = Val(TxtNum2.Text)

        If num1 > num2 Then
            LblResultado.Text = "O Número maior é o " + Str(num1)
        Else
            LblResultado.Text = "O Número maior é o " + Str(num2)
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
