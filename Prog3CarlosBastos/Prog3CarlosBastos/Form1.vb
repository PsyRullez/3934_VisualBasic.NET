Public Class Form1
    Private Sub TxtCaixa_TextChanged(sender As Object, e As EventArgs) Handles TxtCaixa.TextChanged

    End Sub

    Private Sub BtnEscrever_Click(sender As Object, e As EventArgs) Handles BtnEscrever.Click
        LblEscrever.Text = TxtCaixa.Text
    End Sub

    Private Sub BtnApagar_Click(sender As Object, e As EventArgs) Handles BtnApagar.Click
        LblEscrever.Text = ""
        TxtCaixa.Text = ""
    End Sub
End Class
