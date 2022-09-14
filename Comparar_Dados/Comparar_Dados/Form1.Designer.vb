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
        Me.lblIdade1 = New System.Windows.Forms.Label()
        Me.lblIdade2 = New System.Windows.Forms.Label()
        Me.tbtIdade1 = New System.Windows.Forms.TextBox()
        Me.tbtIdade2 = New System.Windows.Forms.TextBox()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdade1
        '
        Me.lblIdade1.AutoSize = True
        Me.lblIdade1.Location = New System.Drawing.Point(21, 30)
        Me.lblIdade1.Name = "lblIdade1"
        Me.lblIdade1.Size = New System.Drawing.Size(112, 13)
        Me.lblIdade1.TabIndex = 0
        Me.lblIdade1.Text = "Digite a primeira Idade"
        '
        'lblIdade2
        '
        Me.lblIdade2.AutoSize = True
        Me.lblIdade2.Location = New System.Drawing.Point(21, 68)
        Me.lblIdade2.Name = "lblIdade2"
        Me.lblIdade2.Size = New System.Drawing.Size(116, 13)
        Me.lblIdade2.TabIndex = 1
        Me.lblIdade2.Text = "Digite a segunda idade"
        '
        'tbtIdade1
        '
        Me.tbtIdade1.Location = New System.Drawing.Point(163, 27)
        Me.tbtIdade1.Name = "tbtIdade1"
        Me.tbtIdade1.Size = New System.Drawing.Size(157, 20)
        Me.tbtIdade1.TabIndex = 2
        '
        'tbtIdade2
        '
        Me.tbtIdade2.Location = New System.Drawing.Point(163, 65)
        Me.tbtIdade2.Name = "tbtIdade2"
        Me.tbtIdade2.Size = New System.Drawing.Size(157, 20)
        Me.tbtIdade2.TabIndex = 3
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(24, 118)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(296, 34)
        Me.btnComparar.TabIndex = 4
        Me.btnComparar.Text = "&Comparar Idades"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(24, 173)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(296, 35)
        Me.btnLimpar.TabIndex = 5
        Me.btnLimpar.Text = "&Limpar Dados"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 240)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.tbtIdade2)
        Me.Controls.Add(Me.tbtIdade1)
        Me.Controls.Add(Me.lblIdade2)
        Me.Controls.Add(Me.lblIdade1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparador de Dados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdade1 As Label
    Friend WithEvents lblIdade2 As Label
    Friend WithEvents tbtIdade1 As TextBox
    Friend WithEvents tbtIdade2 As TextBox
    Friend WithEvents btnComparar As Button
    Friend WithEvents btnLimpar As Button
End Class
