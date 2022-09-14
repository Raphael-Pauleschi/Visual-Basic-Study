<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblAniversario = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblSaldoAtual = New System.Windows.Forms.Label()
        Me.tbtConta = New System.Windows.Forms.TextBox()
        Me.tbtCliente = New System.Windows.Forms.TextBox()
        Me.tbtAniversario = New System.Windows.Forms.TextBox()
        Me.tbtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.tbtValor = New System.Windows.Forms.TextBox()
        Me.tbtSaldoAtual = New System.Windows.Forms.TextBox()
        Me.bntCriar = New System.Windows.Forms.Button()
        Me.bntSacar = New System.Windows.Forms.Button()
        Me.bntDepositar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(37, 23)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(35, 13)
        Me.lblConta.TabIndex = 0
        Me.lblConta.Text = "Conta"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(37, 49)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(37, 80)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldoInicial.TabIndex = 2
        Me.lblSaldoInicial.Text = "Saldo"
        '
        'lblAniversario
        '
        Me.lblAniversario.AutoSize = True
        Me.lblAniversario.Location = New System.Drawing.Point(37, 109)
        Me.lblAniversario.Name = "lblAniversario"
        Me.lblAniversario.Size = New System.Drawing.Size(59, 13)
        Me.lblAniversario.TabIndex = 3
        Me.lblAniversario.Text = "Aniversário"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(61, 169)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 4
        Me.lblValor.Text = "Valor"
        '
        'lblSaldoAtual
        '
        Me.lblSaldoAtual.AutoSize = True
        Me.lblSaldoAtual.Location = New System.Drawing.Point(300, 169)
        Me.lblSaldoAtual.Name = "lblSaldoAtual"
        Me.lblSaldoAtual.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldoAtual.TabIndex = 5
        Me.lblSaldoAtual.Text = "Saldo"
        '
        'tbtConta
        '
        Me.tbtConta.Location = New System.Drawing.Point(140, 23)
        Me.tbtConta.Name = "tbtConta"
        Me.tbtConta.Size = New System.Drawing.Size(205, 20)
        Me.tbtConta.TabIndex = 6
        '
        'tbtCliente
        '
        Me.tbtCliente.Location = New System.Drawing.Point(140, 49)
        Me.tbtCliente.Name = "tbtCliente"
        Me.tbtCliente.Size = New System.Drawing.Size(205, 20)
        Me.tbtCliente.TabIndex = 7
        '
        'tbtAniversario
        '
        Me.tbtAniversario.Location = New System.Drawing.Point(140, 109)
        Me.tbtAniversario.Name = "tbtAniversario"
        Me.tbtAniversario.Size = New System.Drawing.Size(205, 20)
        Me.tbtAniversario.TabIndex = 8
        '
        'tbtSaldoInicial
        '
        Me.tbtSaldoInicial.Location = New System.Drawing.Point(140, 80)
        Me.tbtSaldoInicial.Name = "tbtSaldoInicial"
        Me.tbtSaldoInicial.Size = New System.Drawing.Size(205, 20)
        Me.tbtSaldoInicial.TabIndex = 9
        '
        'tbtValor
        '
        Me.tbtValor.Location = New System.Drawing.Point(64, 187)
        Me.tbtValor.Name = "tbtValor"
        Me.tbtValor.Size = New System.Drawing.Size(83, 20)
        Me.tbtValor.TabIndex = 10
        '
        'tbtSaldoAtual
        '
        Me.tbtSaldoAtual.Location = New System.Drawing.Point(303, 185)
        Me.tbtSaldoAtual.Name = "tbtSaldoAtual"
        Me.tbtSaldoAtual.Size = New System.Drawing.Size(93, 20)
        Me.tbtSaldoAtual.TabIndex = 11
        '
        'bntCriar
        '
        Me.bntCriar.Location = New System.Drawing.Point(369, 58)
        Me.bntCriar.Name = "bntCriar"
        Me.bntCriar.Size = New System.Drawing.Size(75, 23)
        Me.bntCriar.TabIndex = 12
        Me.bntCriar.Text = "&Criar"
        Me.bntCriar.UseVisualStyleBackColor = True
        '
        'bntSacar
        '
        Me.bntSacar.Location = New System.Drawing.Point(190, 205)
        Me.bntSacar.Name = "bntSacar"
        Me.bntSacar.Size = New System.Drawing.Size(75, 24)
        Me.bntSacar.TabIndex = 13
        Me.bntSacar.Text = "&Sacar"
        Me.bntSacar.UseVisualStyleBackColor = True
        '
        'bntDepositar
        '
        Me.bntDepositar.Location = New System.Drawing.Point(190, 169)
        Me.bntDepositar.Name = "bntDepositar"
        Me.bntDepositar.Size = New System.Drawing.Size(75, 23)
        Me.bntDepositar.TabIndex = 14
        Me.bntDepositar.Text = "&Depositar"
        Me.bntDepositar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(456, 274)
        Me.Controls.Add(Me.bntDepositar)
        Me.Controls.Add(Me.bntSacar)
        Me.Controls.Add(Me.bntCriar)
        Me.Controls.Add(Me.tbtSaldoAtual)
        Me.Controls.Add(Me.tbtValor)
        Me.Controls.Add(Me.tbtSaldoInicial)
        Me.Controls.Add(Me.tbtAniversario)
        Me.Controls.Add(Me.tbtCliente)
        Me.Controls.Add(Me.tbtConta)
        Me.Controls.Add(Me.lblSaldoAtual)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblAniversario)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblConta)
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Name = "Form1"
        Me.Text = "Conta Poupança"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConta As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents lblAniversario As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblSaldoAtual As Label
    Friend WithEvents tbtConta As TextBox
    Friend WithEvents tbtCliente As TextBox
    Friend WithEvents tbtAniversario As TextBox
    Friend WithEvents tbtSaldoInicial As TextBox
    Friend WithEvents tbtValor As TextBox
    Friend WithEvents tbtSaldoAtual As TextBox
    Friend WithEvents bntCriar As Button
    Friend WithEvents bntSacar As Button
    Friend WithEvents bntDepositar As Button
End Class
