Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Form1
    Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
        Dim PrimNum As Integer
        Dim UltNum As Integer
        Dim i As Integer

        PrimNum = Val(TxtPriNum.Text)
        UltNum = Val(TxtUltNum.Text)

        For i = PrimNum To UltNum
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
        TxtLista.Clear() 'TxtLista = "" '

        BtnLimpar.Enabled = False
        BtnListar.Enabled = True
    End Sub
End Class
