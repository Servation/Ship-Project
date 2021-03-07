﻿Public Class Ship
    Inherits PictureBox
    Private TopSpeed, LeftSpeed As Double

    Public Property UpDown As Double
        Get
            Return TopSpeed
        End Get
        Set(value As Double)
            TopSpeed = value
        End Set
    End Property
    Public Property LeftRight As Double
        Get
            Return LeftSpeed
        End Get
        Set(value As Double)
            LeftSpeed = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.BackColor = Color.Green
        Me.Width = 30
        Me.Height = 30
        Me.Top = 370
        Me.Left = 370
        TopSpeed = 0
        LeftSpeed = 0
    End Sub

End Class
