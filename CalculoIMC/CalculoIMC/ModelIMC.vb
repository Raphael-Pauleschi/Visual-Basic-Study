﻿Public Class ModelIMC
    Private imc As Decimal
    Private peso As Decimal
    Private altura As Decimal

    Public Sub New()
    End Sub

    Public Sub New(peso As Decimal, altura As Decimal)
        Me.peso = peso
        Me.altura = altura
    End Sub

    Public Property pImc As Decimal
        Get
            Return imc
        End Get
        Set(value As Decimal)
            imc = value
        End Set
    End Property

    Public Property pPeso As Decimal
        Get
            Return peso
        End Get
        Set(value As Decimal)
            peso = value
        End Set
    End Property

    Public Property pAltura As Decimal
        Get
            Return altura
        End Get
        Set(value As Decimal)
            altura = value
        End Set
    End Property

    Public Function calcularIMC(peso As Decimal, altura As Decimal)
        imc = peso / (altura * altura)
        Return imc
    End Function
    Public Function classificarIMC(imc As Decimal)
        Dim classificacao As String
        If (imc < 8.5) Then
            classificacao = "Desnutrido"
        ElseIf (imc < 25) Then
            classificacao = "Adequado"
        ElseIf (imc < 30) Then
            classificacao = "Sobrepeso"
        ElseIf (imc < 35) Then
            classificacao = "Obesidade Nível I"
        Else
            classificacao = "Obesidade Nível II"
        End If
        Return classificacao
    End Function
End Class
