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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.square2 = New System.Windows.Forms.PictureBox()
        Me.square3 = New System.Windows.Forms.PictureBox()
        Me.square4 = New System.Windows.Forms.PictureBox()
        Me.square1 = New System.Windows.Forms.PictureBox()
        Me.player = New System.Windows.Forms.PictureBox()
        CType(Me.square2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.square3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.square4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.square1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'square2
        '
        Me.square2.Image = Global.JogoNovo.My.Resources.Resources.square
        Me.square2.Location = New System.Drawing.Point(110, 20)
        Me.square2.Name = "square2"
        Me.square2.Size = New System.Drawing.Size(67, 62)
        Me.square2.TabIndex = 7
        Me.square2.TabStop = False
        '
        'square3
        '
        Me.square3.Image = Global.JogoNovo.My.Resources.Resources.square
        Me.square3.Location = New System.Drawing.Point(208, 20)
        Me.square3.Name = "square3"
        Me.square3.Size = New System.Drawing.Size(67, 62)
        Me.square3.TabIndex = 6
        Me.square3.TabStop = False
        '
        'square4
        '
        Me.square4.Image = Global.JogoNovo.My.Resources.Resources.square
        Me.square4.Location = New System.Drawing.Point(300, 20)
        Me.square4.Name = "square4"
        Me.square4.Size = New System.Drawing.Size(67, 62)
        Me.square4.TabIndex = 4
        Me.square4.TabStop = False
        '
        'square1
        '
        Me.square1.Image = Global.JogoNovo.My.Resources.Resources.square
        Me.square1.Location = New System.Drawing.Point(26, 20)
        Me.square1.Name = "square1"
        Me.square1.Size = New System.Drawing.Size(67, 62)
        Me.square1.TabIndex = 1
        Me.square1.TabStop = False
        '
        'player
        '
        Me.player.Image = Global.JogoNovo.My.Resources.Resources.player
        Me.player.Location = New System.Drawing.Point(209, 662)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(50, 50)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 733)
        Me.Controls.Add(Me.square2)
        Me.Controls.Add(Me.square3)
        Me.Controls.Add(Me.square4)
        Me.Controls.Add(Me.square1)
        Me.Controls.Add(Me.player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.square2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.square3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.square4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.square1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents player As PictureBox
    Friend WithEvents square1 As PictureBox
    Friend WithEvents square4 As PictureBox
    Friend WithEvents square3 As PictureBox
    Friend WithEvents square2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
