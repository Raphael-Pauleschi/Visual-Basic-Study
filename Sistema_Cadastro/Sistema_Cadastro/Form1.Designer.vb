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
        Me.lblAluno = New System.Windows.Forms.Label()
        Me.lblRGMAluno = New System.Windows.Forms.Label()
        Me.lblNomeAluno = New System.Windows.Forms.Label()
        Me.btnExibirAluno = New System.Windows.Forms.Button()
        Me.tbtNomeAluno = New System.Windows.Forms.TextBox()
        Me.tbtRgmAluno = New System.Windows.Forms.TextBox()
        Me.tbtTituloProfessor = New System.Windows.Forms.TextBox()
        Me.tbtNomeProfessor = New System.Windows.Forms.TextBox()
        Me.lblExibirProfessor = New System.Windows.Forms.Button()
        Me.lblNomeProfessor = New System.Windows.Forms.Label()
        Me.lblTituloProfessor = New System.Windows.Forms.Label()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAluno
        '
        Me.lblAluno.AutoSize = True
        Me.lblAluno.Location = New System.Drawing.Point(21, 9)
        Me.lblAluno.Name = "lblAluno"
        Me.lblAluno.Size = New System.Drawing.Size(34, 13)
        Me.lblAluno.TabIndex = 0
        Me.lblAluno.Text = "Aluno"
        '
        'lblRGMAluno
        '
        Me.lblRGMAluno.AutoSize = True
        Me.lblRGMAluno.Location = New System.Drawing.Point(45, 42)
        Me.lblRGMAluno.Name = "lblRGMAluno"
        Me.lblRGMAluno.Size = New System.Drawing.Size(32, 13)
        Me.lblRGMAluno.TabIndex = 1
        Me.lblRGMAluno.Text = "RGM"
        '
        'lblNomeAluno
        '
        Me.lblNomeAluno.AutoSize = True
        Me.lblNomeAluno.Location = New System.Drawing.Point(45, 86)
        Me.lblNomeAluno.Name = "lblNomeAluno"
        Me.lblNomeAluno.Size = New System.Drawing.Size(35, 13)
        Me.lblNomeAluno.TabIndex = 2
        Me.lblNomeAluno.Text = "Nome"
        '
        'btnExibirAluno
        '
        Me.btnExibirAluno.Location = New System.Drawing.Point(264, 37)
        Me.btnExibirAluno.Name = "btnExibirAluno"
        Me.btnExibirAluno.Size = New System.Drawing.Size(75, 23)
        Me.btnExibirAluno.TabIndex = 3
        Me.btnExibirAluno.Text = "&Exibir"
        Me.btnExibirAluno.UseVisualStyleBackColor = True
        '
        'tbtNomeAluno
        '
        Me.tbtNomeAluno.Location = New System.Drawing.Point(102, 83)
        Me.tbtNomeAluno.Name = "tbtNomeAluno"
        Me.tbtNomeAluno.Size = New System.Drawing.Size(237, 20)
        Me.tbtNomeAluno.TabIndex = 4
        '
        'tbtRgmAluno
        '
        Me.tbtRgmAluno.Location = New System.Drawing.Point(102, 39)
        Me.tbtRgmAluno.Name = "tbtRgmAluno"
        Me.tbtRgmAluno.Size = New System.Drawing.Size(156, 20)
        Me.tbtRgmAluno.TabIndex = 5
        '
        'tbtTituloProfessor
        '
        Me.tbtTituloProfessor.Location = New System.Drawing.Point(102, 158)
        Me.tbtTituloProfessor.Name = "tbtTituloProfessor"
        Me.tbtTituloProfessor.Size = New System.Drawing.Size(156, 20)
        Me.tbtTituloProfessor.TabIndex = 11
        '
        'tbtNomeProfessor
        '
        Me.tbtNomeProfessor.Location = New System.Drawing.Point(102, 202)
        Me.tbtNomeProfessor.Name = "tbtNomeProfessor"
        Me.tbtNomeProfessor.Size = New System.Drawing.Size(237, 20)
        Me.tbtNomeProfessor.TabIndex = 10
        '
        'lblExibirProfessor
        '
        Me.lblExibirProfessor.Location = New System.Drawing.Point(264, 156)
        Me.lblExibirProfessor.Name = "lblExibirProfessor"
        Me.lblExibirProfessor.Size = New System.Drawing.Size(75, 23)
        Me.lblExibirProfessor.TabIndex = 9
        Me.lblExibirProfessor.Text = "&Exibir"
        Me.lblExibirProfessor.UseVisualStyleBackColor = True
        '
        'lblNomeProfessor
        '
        Me.lblNomeProfessor.AutoSize = True
        Me.lblNomeProfessor.Location = New System.Drawing.Point(45, 205)
        Me.lblNomeProfessor.Name = "lblNomeProfessor"
        Me.lblNomeProfessor.Size = New System.Drawing.Size(35, 13)
        Me.lblNomeProfessor.TabIndex = 8
        Me.lblNomeProfessor.Text = "Nome"
        '
        'lblTituloProfessor
        '
        Me.lblTituloProfessor.AutoSize = True
        Me.lblTituloProfessor.Location = New System.Drawing.Point(45, 161)
        Me.lblTituloProfessor.Name = "lblTituloProfessor"
        Me.lblTituloProfessor.Size = New System.Drawing.Size(33, 13)
        Me.lblTituloProfessor.TabIndex = 7
        Me.lblTituloProfessor.Text = "Titulo"
        '
        'lblProfessor
        '
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Location = New System.Drawing.Point(21, 128)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(51, 13)
        Me.lblProfessor.TabIndex = 6
        Me.lblProfessor.Text = "Professor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 300)
        Me.Controls.Add(Me.tbtTituloProfessor)
        Me.Controls.Add(Me.tbtNomeProfessor)
        Me.Controls.Add(Me.lblExibirProfessor)
        Me.Controls.Add(Me.lblNomeProfessor)
        Me.Controls.Add(Me.lblTituloProfessor)
        Me.Controls.Add(Me.lblProfessor)
        Me.Controls.Add(Me.tbtRgmAluno)
        Me.Controls.Add(Me.tbtNomeAluno)
        Me.Controls.Add(Me.btnExibirAluno)
        Me.Controls.Add(Me.lblNomeAluno)
        Me.Controls.Add(Me.lblRGMAluno)
        Me.Controls.Add(Me.lblAluno)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAluno As Label
    Friend WithEvents lblRGMAluno As Label
    Friend WithEvents lblNomeAluno As Label
    Friend WithEvents btnExibirAluno As Button
    Friend WithEvents tbtNomeAluno As TextBox
    Friend WithEvents tbtRgmAluno As TextBox
    Friend WithEvents tbtTituloProfessor As TextBox
    Friend WithEvents tbtNomeProfessor As TextBox
    Friend WithEvents lblExibirProfessor As Button
    Friend WithEvents lblNomeProfessor As Label
    Friend WithEvents lblTituloProfessor As Label
    Friend WithEvents lblProfessor As Label
End Class
