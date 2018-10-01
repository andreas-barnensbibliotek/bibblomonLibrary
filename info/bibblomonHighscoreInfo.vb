Public Class bibblomonHighscoreInfo
    Private _highscorelist As List(Of bokemonHighscoreInfo)
    Public Property HighScoreList() As List(Of bokemonHighscoreInfo)
        Get
            Return _highscorelist
        End Get
        Set(ByVal value As List(Of bokemonHighscoreInfo))
            _highscorelist = value
        End Set
    End Property
    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
End Class
