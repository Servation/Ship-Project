Public Class Form1
    Public ship As Ship = New Ship
    Public L, Up As Double
    Private keysPressed As New HashSet(Of Keys)
    Private Sub form1_keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keysPressed.Add(e.KeyCode)
        If L >= -6 And Up >= -6 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.W) Then
            L -= 2
            Up -= 2
        ElseIf L >= -6 And Up <= 6 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.S) Then
            L -= 2
            Up += 2
        ElseIf L <= 6 And Up >= -6 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.W) Then
            L += 2
            Up -= 2
        ElseIf L <= 6 And Up <= 6 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.S) Then
            L += 2
            Up += 2
        ElseIf L >= -6 And keysPressed.Contains(Keys.A) Then
            L -= 2
        ElseIf L <= 6 And keysPressed.Contains(Keys.D) Then
            L += 2
        ElseIf Up >= -6 And keysPressed.Contains(Keys.W) Then
            Up -= 2
        ElseIf Up <= 6 And keysPressed.Contains(Keys.S) Then
            Up += 2
        End If



    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        keysPressed.Remove(e.KeyCode)
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim xMouse As Integer = MousePosition().X
        'Dim yMouse As Integer = MousePosition().Y
        'L = xMouse
        'Up = yMouse

        If ship.Left < 0 Or ship.Left > Me.Width - 40 Then
            L = -L
        End If
        If ship.Top < 0 Or ship.Top > Me.Height - ship.Height * 2 + 10 Then
            Up = -Up
        End If

        ship.Left += L
        ship.Top += Up
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If L > 0 Then
            L -= 1
        End If
        If L < 0 Then
            L += 1
        End If
        If Up > 0 Then
            Up -= 1
        End If
        If Up < 0 Then
            Up += 1
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(ship)
        Timer1.Start()
        Timer2.Start()
    End Sub

End Class
