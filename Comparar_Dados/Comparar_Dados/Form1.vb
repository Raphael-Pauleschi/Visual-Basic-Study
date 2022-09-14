Public Class Form1
    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        Dim idade1, idade2 As Integer
        'inserindo os valores das text boxes nessa variaveis
        'CInt converte as Strings em int
        idade1 = CInt(tbtIdade1.Text)
        idade2 = CInt(tbtIdade2.Text)

        If idade1 > idade2 Then
            MessageBox.Show("A idade " & idade1 & " anos é maior que " & idade2 & " anos")
        ElseIf idade2 > idade1 Then
            MessageBox.Show("A idade " & idade2 & " anos é maior que " & idade1 & " anos")
        Else
            MessageBox.Show("A idade " & idade1 & " anos é igual que " & idade2 & " anos")
        End If

        Limpar_Campos()

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar_Campos()
    End Sub

    Private Sub Limpar_Campos()
        tbtIdade1.Clear()
        tbtIdade2.Clear()
    End Sub
End Class
