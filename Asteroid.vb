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
    Public Sub randSize()
        Dim Gen As Random = New Random()
        Dim AsteroSize = Gen.Next(35, 75)
        Width = AsteroSize
        Height = AsteroSize
    End Sub
    Public Sub randSpeed()
        Dim Gen As Random = New Random()
        TopSpeed = Gen.Next(3, 8)
    End Sub
    Public Sub randX(ViewSize As Integer)
        Dim Gen As Random = New Random()
        Dim Spot = Gen.Next(0, ViewSize - Width)
        Left = Spot
    End Sub
    Public Sub New()
        MyBase.New()
        randSize()
        BackColor = Color.Black
        Top = -75
        randX(800)
        randSpeed()
        LeftSpeed = 0
    End Sub

End Class
