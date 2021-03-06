Public Class Form1
    Public ship As Ship = New Ship
    Private Gen As Random = New Random()
    Public ast(99) As Asteroid
    Public logicalAst As Integer = 4
    Private keysPressed As New HashSet(Of Keys)
    Private Sub form1_keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keysPressed.Add(e.KeyCode)
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        keysPressed.Remove(e.KeyCode)
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ship.LeftRight >= -4 And keysPressed.Contains(Keys.A) Then
            ship.LeftRight -= 2

        End If
        If ship.LeftRight <= 4 And keysPressed.Contains(Keys.D) Then
            ship.LeftRight += 2
        End If
        If ship.UpDown >= -4 And keysPressed.Contains(Keys.W) Then
            ship.UpDown -= 2
        End If
        If ship.UpDown <= 4 And keysPressed.Contains(Keys.S) Then
            ship.UpDown += 2
        End If
        If ship.LeftRight >= -2 And ship.UpDown >= -2 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.W) Then
            ship.UpDown -= 1
            ship.UpDown -= 1
        End If
        If ship.LeftRight >= -2 And ship.UpDown <= 2 And keysPressed.Contains(Keys.A) AndAlso keysPressed.Contains(Keys.S) Then
            ship.LeftRight -= 1
            ship.UpDown += 1
        End If
        If ship.LeftRight <= 2 And ship.UpDown >= -2 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.W) Then
            ship.LeftRight += 1
            ship.UpDown -= 1
        End If
        If ship.LeftRight <= 2 And ship.UpDown <= 2 And keysPressed.Contains(Keys.D) AndAlso keysPressed.Contains(Keys.S) Then
            ship.LeftRight += 1
            ship.UpDown += 1
        End If

        If ship.Left <= 0 Then
            ship.Left = 0
            ship.LeftRight = -ship.LeftRight
        End If
        If ship.Left >= Width - 45 Then
            ship.Left = Width - 45
            ship.LeftRight = -ship.LeftRight
        End If
        If ship.Top <= 0 Then
            ship.Top = 0
            ship.UpDown = -ship.UpDown
        End If
        If ship.Top >= Height - (ship.Height * 2 + 10) Then
            ship.Top = Height - (ship.Height * 2 + 10)
            ship.UpDown = -ship.UpDown
        End If
        For i As Integer = 0 To logicalAst
            If ast(i).Top >= Height + 75 Then
                Dim AsteroSize = Gen.Next(35, 75)
                ast(i).Top = -75
                ast(i).Left = Gen.Next(0, Width - ast(i).Width)
                ast(i).Width = AsteroSize
                ast(i).Height = AsteroSize
                ast(i).UpDown = Gen.Next(3, 8)
                ast(i).BackColor = Color.Black
            End If
            ast(i).Top += ast(i).UpDown
        Next i
        ship.Left += ship.LeftRight
        ship.Top += ship.UpDown
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ship.Deceleration()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Add(ship)
        Dim bmp As Bitmap = My.Resources.asteroid
        bmp.MakeTransparent(Color.Magenta)
        For i As Integer = 0 To logicalAst
            Dim AsteroSize = Gen.Next(35, 75)
            ast(i) = New Asteroid
            ast(i).Left = Gen.Next(0, Width - ast(i).Width)
            ast(i).Width = AsteroSize
            ast(i).Height = AsteroSize
            ast(i).UpDown = Gen.Next(3, 8)
            ast(i).Image = bmp
            ast(i).SizeMode = PictureBoxSizeMode.Zoom
            Controls.Add(ast(i))

        Next i
        Timer1.Start()
        Timer2.Start()
        ShipG()
    End Sub

    Private Sub ShipG()
        Dim myPen As Brush
        Dim a As New Point(410, 600)
        Dim a1 As New Point(390, 600)
        Dim b As New Point(370, 640)
        Dim c As New Point(430, 640)
        Dim myPoint As Point() = {a, a1, b, c}

        myPen = New SolidBrush(Color.Red)
        Dim myGraphics As Graphics = CreateGraphics()
        myGraphics.FillPolygon(myPen, myPoint)
    End Sub

End Class
