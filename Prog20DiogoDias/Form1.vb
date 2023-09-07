Imports System

Public Class Form1

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        ' Limpa os valores das caixas de texto.
        TxtA.Text = ""
        TxtB.Text = ""
        TxtC.Text = ""

        ' Limpa o texto do rótulo.
        LblResultado.Text = ""

        ' Limpa os valores dos botoes de radio.
        RArea.Checked = False
        RPerimetro.Checked = False

    End Sub

    Private Function Validar()

        If IsNumeric(TxtA.Text) = False Then
            MsgBox("Só pode inserir valores.")
            TxtA.Text = ""
            Return False
        End If

        If Not IsNumeric(TxtB.Text) Then
            MsgBox("Só pode inserir valores.")
            TxtB.Text = ""
            Return False
        End If

        If Not IsNumeric(TxtC.Text) Then
            TxtC.Text = ""
            Return False
        End If
        Return True
    End Function

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        ' Busca de valores das caixas.
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim S As Double
        Dim Area As Double
        Dim P As Double

        If Validar() = True Then


            a = Double.Parse(TxtA.Text)
            b = Double.Parse(TxtB.Text)
            c = Double.Parse(TxtC.Text)
            ' Check se os valores são numericos.


            ' Calculo do perimetro.
            If RArea.Checked = True Then
                S = (a + b + c) / 2

                ' Area usando a formula Heron .

                Area = Math.Sqrt(S * (S - a) * (S - b) * (S - c))
                LblResultado.Text = Format(Area, "0.00")
            End If

            If RPerimetro.Checked = True Then
                P = a + b + c
                LblResultado.Text = Format(P, "0.00")
            End If


        End If

        ' Resultado.


    End Sub

    Private Sub RArea_CheckedChanged(sender As Object, e As EventArgs) Handles RArea.CheckedChanged

    End Sub

    Private Sub RPerimetro_CheckedChanged(sender As Object, e As EventArgs) Handles RPerimetro.CheckedChanged

    End Sub

    Private Sub LblResultado_Click(sender As Object, e As EventArgs) Handles LblResultado.Click

    End Sub

    Private Sub TxtA_TextChanged(sender As Object, e As EventArgs) Handles TxtA.TextChanged

    End Sub

    Private Sub TxtB_TextChanged(sender As Object, e As EventArgs) Handles TxtB.TextChanged

    End Sub

    Private Sub TxtC_TextChanged(sender As Object, e As EventArgs) Handles TxtC.TextChanged

    End Sub
End Class
