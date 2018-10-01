Imports Microsoft.VisualBasic

Public Class bokemonfightInfo
    Public Sub New()

        _currentScore = 0
        _currentXP = 0
        _gameScore = 0
        _gameXP = 0
        _newXP = 0
        _newScore = 0

    End Sub

    Private _currentScore As Integer
    Public Property CurrentScore() As Integer
        Get
            Return _currentScore
        End Get
        Set(ByVal value As Integer)
            _currentScore = value
        End Set
    End Property

    Private _currentXP As Integer
    Public Property CurrentXP() As Integer
        Get
            Return _currentXP
        End Get
        Set(ByVal value As Integer)
            _currentXP = value
        End Set
    End Property

    Private _gameScore As Integer
    Public Property GameScore() As Integer
        Get
            Return _gameScore
        End Get
        Set(ByVal value As Integer)
            _gameScore = value
        End Set
    End Property

    Private _gameXP As Integer
    Public Property GameXP() As Integer
        Get
            Return _gameXP
        End Get
        Set(ByVal value As Integer)
            _gameXP = value
        End Set
    End Property

    Private _newXP As Integer
    Public Property NewXP() As Integer
        Get
            Return _newXP
        End Get
        Set(ByVal value As Integer)
            _newXP = value
        End Set
    End Property

    Private _newScore As Integer
    Public Property NewScore() As Integer
        Get
            Return _newScore
        End Get
        Set(ByVal value As Integer)
            _newScore = value
        End Set
    End Property
End Class
