Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles player.Click

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Me.player.Left -= 25
            Case Keys.Up
                Me.player.Top -= 25
            Case Keys.Right
                Me.player.Left += 25
            Case Keys.Down
                Me.player.Top += 25
        End Select
    End Sub

    Dim largura = 0

    Dim altura1 = 0
    Dim altura2 = 0
    Dim altura3 = 0
    Dim altura4 = 0

    Dim num1 = Int((10 * Rnd()) + 7)
    Dim num2 = Int((10 * Rnd()) + 7)
    Dim num3 = Int((10 * Rnd()) + 7)
    Dim num4 = Int((10 * Rnd()) + 7)


    Sub Spawn()

        square1.Location = New Point(26, 20)
        square2.Location = New Point(100, 20)
        square3.Location = New Point(208, 20)
        square4.Location = New Point(259, 20)
        player.Location = New Point(209, 662)

        largura = 0

        altura1 = 0
        altura2 = 0
        altura3 = 0
        altura4 = 0

        num1 = Int((10 * Rnd()) + 7)
        num2 = Int((10 * Rnd()) + 7)
        num3 = Int((10 * Rnd()) + 7)
        num4 = Int((10 * Rnd()) + 7)

        Timer2.Enabled = True


    End Sub

    Sub Inicializa()

        square1.Top += num1
        altura1 += num1

        If altura1 > 650 Then
            square1.Location = New Point(26, 12)
            altura1 = 0
            num1 = Int((10 * Rnd()) + 7)
        End If

        square2.Top += num2
        altura2 += num2

        If altura2 > 650 Then
            square2.Location = New Point(87, 12)
            altura2 = 0
            num2 = Int((10 * Rnd()) + 7)
        End If

        square3.Top += num3
        altura3 += num3

        If altura3 > 650 Then
            square3.Location = New Point(148, 12)
            altura3 = 0
            num3 = Int((10 * Rnd()) + 7)
        End If

        square4.Top += num4
        altura4 += num4

        If altura4 > 650 Then
            square4.Location = New Point(209, 12)
            altura4 = 0
            num4 = Int((10 * Rnd()) + 7)
        End If
    End Sub

    Sub Cheat()
        Call Inicializa()
        Call Spawn()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call Inicializa()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each falling As PictureBox In {square1, square2, square3, square4}
            If player.Bounds.IntersectsWith(falling.Bounds) Then
                num1 = 0
                num2 = 0
                num3 = 0
                num4 = 0
                Timer2.Enabled = False
                Dim resposta = MsgBox("Perdeste. Novo jogo?" & vbCrLf, vbYesNo, "Game Over")
                If resposta = vbYes Then Call Cheat()
                If resposta = vbNo Then Me.Close()
            End If
        Next
    End Sub
End Class
