Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadSim_CheckedChanged(sender As Object, e As EventArgs) Handles RadSim.CheckedChanged

    End Sub

    Private Sub RadNao_CheckedChanged(sender As Object, e As EventArgs) Handles RadNao.CheckedChanged

    End Sub

    Private Sub BtnResponder_Click(sender As Object, e As EventArgs) Handles BtnResponder.Click
        If RadSim.Checked = True Then
            LblResposta.Text = "Parabéns, pode vir a ser um grande Programador!"
        End If
        If RadNao.Checked = True Then
            LblResposta.Text = "Tente outra area!"
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
