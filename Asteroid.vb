Public Class Asteroid
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
        Top = -75
        LeftSpeed = 0
    End Sub

End Class
