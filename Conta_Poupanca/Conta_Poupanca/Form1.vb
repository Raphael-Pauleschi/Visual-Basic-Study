Public Class Form1
    Dim obj_conta As New Poupanca()
    Private Sub bntCriar_Click(sender As Object, e As EventArgs) Handles bntCriar.Click
        obj_conta.PConta = CInt(tbtConta.Text)
        obj_conta.PNome = tbtCliente.Text
        obj_conta.PAniversario = CInt(tbtAniversario.Text)
        obj_conta.PSaldo = CDec(tbtSaldoInicial.Text)
        MessageBox.Show("Numero da Conta: " & tbtConta.Text & Chr(13) &
                        "Nome do Cliente: " & tbtCliente.Text & Chr(13) &
                        "Saldo: R$ " & tbtSaldoInicial.Text & Chr(13) &
                        "Aniversário da conta: Dia " & tbtAniversario.Text, "Usuário criado com sucesso")
    End Sub

    Private Sub bntDepositar_Click(sender As Object, e As EventArgs) Handles bntDepositar.Click
        obj_conta.Depositar(CDec(tbtValor.Text))
        MessageBox.Show("Valor de R$" & tbtValor.Text & " depositado", "Sucesso")
        writeSaldo()
    End Sub

    Private Sub bntSacar_Click(sender As Object, e As EventArgs) Handles bntSacar.Click
        If (CDec(tbtValor.Text) <= obj_conta.PSaldo) Then
            obj_conta.Sacar(CDec(tbtValor.Text))
            MessageBox.Show("Valor de R$" & tbtValor.Text & " sacado", "Sucesso")
        End If
        MessageBox.Show("Não há saldo o suficiente", "Falha")
        writeSaldo()
    End Sub
    Private Sub writeSaldo()
        tbtSaldoAtual.Text = obj_conta.PSaldo
    End Sub
End Class
