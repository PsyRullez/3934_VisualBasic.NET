Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        LblNomes.Text = "Carlos Bastos"

    End Sub

    Private Sub BtnApagar_Click(sender As Object, e As EventArgs) Handles BtnApagar.Click
        LblNomes.Text = ""
    End Sub
End Class
