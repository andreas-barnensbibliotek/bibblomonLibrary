Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BibblomonLibrary

<TestClass()> Public Class BibblomonMainControllerTEST

    <TestMethod()> Public Sub highscoreTEST()
        Dim dalobj As New bokemonDAL
        Dim retobj As New bibblomonHighscoreInfo
        Dim listobj As New List(Of bokemonHighscoreInfo)

        listobj = dalobj.getHighscore()
        retobj.HighScoreList = listobj
        retobj.Status = "fixat"



    End Sub

End Class