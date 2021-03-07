Public Class Asteroid
    Inherits PictureBox
    Private TopSpeed, LeftSpeed As Double
    Private AsteroSize As Integer

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
        AsteroSize = Gen.Next(35, 75)
    End Sub

    Public Sub New()
        MyBase.New()
        randSize()
        Me.BackColor = Color.Black
        Me.Width = AsteroSize
        Me.Height = AsteroSize
        Me.Top = 0
        Me.Left = 60
        TopSpeed = 5
        LeftSpeed = 0
    End Sub

End Class
