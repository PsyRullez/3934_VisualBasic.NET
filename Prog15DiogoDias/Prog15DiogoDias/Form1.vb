Imports System.Drawing.Text

Public Class Form1

    Dim Nota As Integer
    Dim NTestes As Integer
    Dim Média As Single
    Dim VectorNotas(10) As Integer

    Private Sub ValidarNota()


        If Nota >= 1 And Nota <= 20 Then
            NTestes = NTestes + 1
            LstNotas.Items.Add("Teste " & NTestes & ":" & Nota)

            VectorNotas(NTestes) = Nota
        ElseIf Nota <> 0 Then
            MsgBox("Nota Inválida: Valor entre 1 e 20")

        End If
    End Sub

    Private Function CalcularMedia() As Single
        Dim Média As Single
        Dim Soma As Integer
        Dim i As Integer

        For i = 1 To NTestes
            Soma = Soma + VectorNotas(i)
        Next

        Média = Soma / NTestes
        Return Média

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NTestes = 0

        BtnInserirNotas.Enabled = True
        BtnLimpar.Enabled = False
    End Sub

    Private Sub BtnInserirNotas_Click(sender As Object, e As EventArgs) Handles BtnInserirNotas.Click
        NTestes = 0
        Dim Ler As String
        Do
            Ler = InputBox("Qual a Nota do " & NTestes + 1 & "º Teste", "Inserir Nota")
            If IsNumeric(Ler) Then
                Nota = CInt(Ler)
                ValidarNota()
            Else MsgBox("Nota Inválida: Valor entre 1 e 20")
            End If
        Loop While Nota <> 0

        LblMedia.Text = CalcularMedia().ToString

        BtnInserirNotas.Enabled = False
        BtnLimpar.Enabled = True

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        LstNotas.Items.Clear()
        LblMedia.Text = ""

        For i = 0 To NTestes
            VectorNotas(i) = 0
        Next
        NTestes = 0

        BtnInserirNotas.Enabled = True
        BtnLimpar.Enabled = False
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Close()
    End Sub
End Class
