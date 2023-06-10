Public Class Form1

    Private Sub BtnJuntar_Click(sender As Object, e As EventArgs) Handles BtnJuntar.Click
        LblJuntos.Text = TxtNome.Text & " " & TxtApelido.Text
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LblJuntos.Text = ""
    End Sub

    Private Sub BtnAmarelo_Click(sender As Object, e As EventArgs) Handles BtnAmarelo.Click
        LblJuntos.ForeColor = Color.Yellow
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub

    Private Sub btnVermelho_Click(sender As Object, e As EventArgs) Handles btnVermelho.Click
        LblJuntos.ForeColor = Color.Red
    End Sub

    Private Sub BtnAzul_Click(sender As Object, e As EventArgs) Handles BtnAzul.Click
        LblJuntos.ForeColor = Color.Blue
    End Sub
End Class
