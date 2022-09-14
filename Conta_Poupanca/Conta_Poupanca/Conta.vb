Public Class Conta
    Private saldo As Decimal
    Private conta As Integer
    Private nome As String

    Public Sub New()
    End Sub

    Public Sub New(saldo As Decimal, conta As Integer, nome As String)
        Me.saldo = saldo
        Me.conta = conta
        Me.nome = nome
    End Sub

    Public Property PSaldo As Decimal
        Get
            Return saldo
        End Get
        Set(value As Decimal)
            saldo = value
        End Set
    End Property

    Public Property PConta As Integer
        Get
            Return conta
        End Get
        Set(value As Integer)
            conta = value
        End Set
    End Property

    Public Property PNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property
End Class
