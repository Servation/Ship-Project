Public Class Form1
    Public ship As Ship = New Ship
    Public ast As Asteroid = New Asteroid
    Private keysPressed As New HashSet(Of Keys)
    Private Sub form1_keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keysPressed.Add(e.KeyCode)
        If ship.LeftRight >= -6 And ship.UpDown >= -6 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.W) Then
            ship.UpDown -= 2
            ship.UpDown -= 2
        ElseIf ship.LeftRight >= -6 And ship.UpDown <= 6 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.S) Then
            ship.LeftRight -= 2
            ship.UpDown += 2
        ElseIf ship.LeftRight <= 6 And ship.UpDown >= -6 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.W) Then
            ship.LeftRight += 2
            ship.UpDown -= 2
        ElseIf ship.LeftRight <= 6 And ship.UpDown <= 6 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.S) Then
            ship.LeftRight += 2
            ship.UpDown += 2
        ElseIf ship.LeftRight >= -6 And keysPressed.Contains(Keys.A) Then
            ship.LeftRight -= 2
        ElseIf ship.LeftRight <= 6 And keysPressed.Contains(Keys.D) Then
            ship.LeftRight += 2
        ElseIf ship.UpDown >= -6 And keysPressed.Contains(Keys.W) Then
            ship.UpDown -= 2
        ElseIf ship.UpDown <= 6 And keysPressed.Contains(Keys.S) Then
            ship.UpDown += 2
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

        If ship.Left <= 0 Then
            ship.Left = 0
            ship.LeftRight = -ship.LeftRight
        ElseIf ship.Left >= Me.Width - 45 Then
            ship.Left = Me.Width - 45
            ship.LeftRight = -ship.LeftRight
        End If
        If ship.Top <= 0 Then
            ship.Top = 0
            ship.UpDown = -ship.UpDown
        ElseIf ship.Top >= Me.Height - (ship.Height * 2 + 10) Then
            ship.Top = Me.Height - (ship.Height * 2 + 10)
            ship.UpDown = -ship.UpDown
        End If

        If ast.Top <= 0 Then
            ast.Top = 0
            ast.UpDown = -ast.UpDown
        ElseIf ast.Top >= Me.Height - (ship.Height * 2 + 10) Then
            ast.Top = Me.Height - (ship.Height * 2 + 10)
            ast.UpDown = -ast.UpDown
        End If

        ast.Top += ast.UpDown
        ship.Left += ship.LeftRight
        ship.Top += ship.UpDown
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ship.LeftRight > 0 Then
            ship.LeftRight -= 1
        End If
        If ship.LeftRight < 0 Then
            ship.LeftRight += 1
        End If
        If ship.UpDown > 0 Then
            ship.UpDown -= 1
        End If
        If ship.UpDown < 0 Then
            ship.UpDown += 1
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(ship)
        Me.Controls.Add(ast)
        Timer1.Start()
        Timer2.Start()
    End Sub

End Class
