Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim peso As Decimal = CDec(txbPeso.Text)
        Dim altura As Decimal = CDec(txbAltura.Text)

        Dim obj_imc As New ModelIMC(peso, altura)

        Dim resultado As Decimal = obj_imc.calcularIMC(obj_imc.pPeso, obj_imc.pAltura)
        Dim classificacao As String = obj_imc.classificarIMC(obj_imc.pImc)
        MessageBox.Show("O IMC é:" & resultado & " e a sua classificação é: " & classificacao)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txbPeso.Clear()
        txbAltura.Clear()
    End Sub
End Class
