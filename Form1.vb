Public Class Form1
    Public ship As Ship = New Ship
    Public L, Up As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If L >= -5 And e.KeyCode = Keys.A Then
            L -= 1
        End If
        If L <= 5 And e.KeyCode = Keys.D Then
            L += 1
        End If
        If L <= 5 And e.KeyCode = Keys.W Then
            If Up >= -5 Then
                Up -= 1
            End If
        End If
        If L <= 5 And e.KeyCode = Keys.S Then
            If Up <= 5 Then
                Up += 1
            End If
        End If


    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
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
