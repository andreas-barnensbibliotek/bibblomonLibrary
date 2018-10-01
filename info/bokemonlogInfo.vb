Imports Microsoft.VisualBasic

Public Class bokemonlogInfo

    Public Sub New()

        _logtype = 0
        _userid = 0
        _monid = 0
        _winlose = 0
        _scorepoints = 0
        _logtext = ""

    End Sub


    Private _logtype As Integer
    Public Property Logtyp() As Integer
        Get
            Return _logtype
        End Get
        Set(ByVal value As Integer)
            _logtype = value
        End Set
    End Property

    Private _userid As Integer
    Public Property Userid() As Integer
        Get
            Return _userid
        End Get
        Set(ByVal value As Integer)
            _userid = value
        End Set
    End Property

    Private _monid As Integer
    Public Property Monid() As Integer
        Get
            Return _monid
        End Get
        Set(ByVal value As Integer)
            _monid = value
        End Set
    End Property

    Private _winlose As Integer
    Public Property WinLose() As Integer
        Get
            Return _winlose
        End Get
        Set(ByVal value As Integer)
            _winlose = value
        End Set
    End Property

    Private _scorepoints As Integer
    Public Property Scorepoints() As Integer
        Get
            Return _scorepoints
        End Get
        Set(ByVal value As Integer)
            _scorepoints = value
        End Set
    End Property

    Private _logtext As String
    Public Property Logtext() As String
        Get
            Return _logtext
        End Get
        Set(ByVal value As String)
            _logtext = value
        End Set
    End Property
End Class
