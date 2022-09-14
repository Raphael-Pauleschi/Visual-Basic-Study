Public Class Poupanca
    Inherits Conta

    Dim aniversario As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(saldo As Decimal, conta As Integer, nome As String, aniversario As Integer)
        MyBase.New(saldo, conta, nome)
        Me.PAniversario = aniversario
    End Sub

    Public Property PAniversario As Integer
        Get
            Return aniversario
        End Get
        Set(value As Integer)
            aniversario = value
        End Set
    End Property
    Public Sub Sacar(valor As Decimal)
        PSaldo -= valor
    End Sub
    Public Sub Depositar(valor As Decimal)
        PSaldo += valor
    End Sub

End Class
