Public Class Form1
    Private Sub BtnEscrever_Click(sender As Object, e As EventArgs) Handles BtnEscrever.Click
        LblTexto.Text = TxtNome.Text & " " & TxtApelido.Text
        TxtNome.Text = ""
        TxtApelido.Text = ""
    End Sub

    Private Sub BtnApagar_Click(sender As Object, e As EventArgs) Handles BtnApagar.Click
        LblTexto.Text = ""
        TxtNome.Text = ""
        TxtApelido.Text = ""
    End Sub
End Class
