Imports Microsoft.VisualBasic

Public Class bokemonHighscoreInfo

    Public Sub New()
        _bokemonuserid = 0
        _bokemonusername = ""
        _bokemonuserscore = 0
    End Sub
    Private _platsnr As Integer
    Public Property Platsnr() As Integer
        Get
            Return _platsnr
        End Get
        Set(ByVal value As Integer)
            _platsnr = value
        End Set
    End Property
    Private _bokemonuserid As Integer
    Public Property bokeminuserid() As Integer
        Get
            Return _bokemonuserid
        End Get
        Set(ByVal value As Integer)
            _bokemonuserid = value
        End Set
    End Property
    Private _bokemonusername As String
    Public Property Bokemonusername() As String
        Get
            Return _bokemonusername
        End Get
        Set(ByVal value As String)
            _bokemonusername = value
        End Set
    End Property

    Private _bokemonuserscore As Integer
    Public Property Bokemonuserscore() As Integer
        Get
            Return _bokemonuserscore
        End Get
        Set(ByVal value As Integer)
            _bokemonuserscore = value
        End Set
    End Property
End Class
