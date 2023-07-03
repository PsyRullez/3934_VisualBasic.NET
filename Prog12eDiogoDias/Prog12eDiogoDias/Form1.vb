Public Class Form1
    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Dim i As Integer


        For i = 1 To 12
            TxtLista.Text += i & ControlChars.CrLf
        Next

        BtnLimpar.Enabled = True
        BtnListar.Enabled = False
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLimpar.Enabled = False
        BtnListar.Enabled = True
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtLista.Clear()

        BtnLimpar.Enabled = False
        BtnListar.Enabled = True
    End Sub
End Class
