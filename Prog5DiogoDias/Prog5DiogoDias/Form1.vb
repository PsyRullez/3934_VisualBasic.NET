Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEsquerdo.Click
        LblMensagem.Text = "Clicou no botão Esquerdo!"
    End Sub

    Private Sub BtnDireito_Click(sender As Object, e As EventArgs) Handles BtnDireito.Click
        LblMensagem.Text = "Clicou no botão Direito!"
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
