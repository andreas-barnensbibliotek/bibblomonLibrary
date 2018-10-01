Public Class bokemonDAL
#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionstringHandler
    Private _linqObj As New bibblomonLinqDataContext(connectionObj.CurrentConnectionString)
#End Region

    Public Function getUserbokemon(ByVal userid As Integer) As bokemonInfo
        Dim usermonsters As New bokemonInfo
        Dim totalscore As Integer = 0
        Dim usermonsterlist As New List(Of bokemonsterInfo)

        Dim monsterlist = From m In _linqObj.AJ_getMonsterlistExt(userid)
                          Select m

        For Each monst In monsterlist
            Dim mon As New bokemonsterInfo
            mon.MonId = monst.monId
            mon.BokemonSrc = monst.monstersrc
            mon.Bokemoninfo = monst.monsterinfo
            mon.Monsternamn = monst.monsternamn
            mon.BokemonScore = monst.MonsterScore
            mon.BokemonXP = monst.MonsterXP
            mon.BokemonLevel = monst.monlevel
            mon.BasePoints = monst.basepoint
            mon.Bonus = monst.bonus
            totalscore += monst.MonsterXP
            usermonsterlist.Add(mon)

        Next
        usermonsters.BokemonList = usermonsterlist
        usermonsters.Monvalue = totalscore
        usermonsters.Userid = userid
        usermonsters.TimeToNext = getmonstertimetonext(userid)

        Return usermonsters

    End Function

    Public Function getAllbokemon(ByVal userid As Integer) As bokemonInfo
        Dim usermonsters As New bokemonInfo
        Dim usermonsterlist As New List(Of bokemonsterInfo)

        Dim monsterlist = From m In _linqObj.tblmonsterLists
                          Select m

        For Each monst In monsterlist
            Dim mon As New bokemonsterInfo
            mon.MonId = monst.monId
            mon.BokemonSrc = monst.monstersrc
            mon.Bokemoninfo = monst.monsterinfo
            mon.Monsternamn = monst.monsternamn
            mon.BokemonScore = getbokemonscore(monst.basepoint, monst.bonus)
            mon.BasePoints = monst.basepoint
            mon.Bonus = monst.bonus
            usermonsterlist.Add(mon)

        Next
        usermonsters.BokemonList = usermonsterlist
        usermonsters.Userid = userid
        usermonsters.TimeToNext = getmonstertimetonext(userid)

        Return usermonsters

    End Function

    Public Function getAllbokdrakar(ByVal userid As Integer) As bokemonInfo
        Dim bokdrakar As New bokemonInfo
        Dim bokdraklistan As New List(Of bokemonsterInfo)

        Dim monsterlist = From m In _linqObj.tblmonsterDrakelists
                          Select m

        For Each monst In monsterlist
            Dim mon As New bokemonsterInfo
            mon.MonId = monst.drakId
            mon.BokemonSrc = monst.draksrc
            mon.Bokemoninfo = monst.drakinfo
            mon.Monsternamn = monst.draknamn
            mon.BokemonScore = getbokemonscore(monst.drakbasepoint, monst.drakbonus)
            mon.BasePoints = monst.drakbasepoint
            mon.Bonus = monst.drakbonus
            bokdraklistan.Add(mon)

        Next
        bokdrakar.BokemonList = bokdraklistan
        bokdrakar.Userid = userid

        Return bokdrakar

    End Function

    Private Function getbokemonscore(ByVal basepoint As Integer, ByVal bonus As Integer) As Integer
        Dim ret As Integer
        If bonus > 0 Then
            ret = (bonus / 100) * basepoint
            ret = basepoint + ret
        Else
            ret = basepoint
        End If
        Return ret

    End Function
    Public Function getmonstertimetonext(ByVal userid As Integer) As Integer
        Dim ret As Integer = 0

        Dim ntn = From c In _linqObj.tblmonsters
                  Where c.Userid = userid
                  Select c

        For Each usr In ntn
            ret = usr.timetonext
        Next

        Return ret
    End Function


    Public Function updMonsterTimeToNext(ByVal userid As Integer, ByVal timetn As Integer) As Boolean
        Dim ret As Boolean = False

        Dim utm = (From t In _linqObj.tblmonsters
                   Where t.Userid = userid
                   Select t).First()

        Try
            utm.timetonext = timetn
            _linqObj.SubmitChanges()

            ret = True
        Catch ex As Exception
            ret = False
        End Try

        Return ret
    End Function


    Public Function addMonsterToUser(ByVal userid As Integer, ByVal monsterid As Integer) As Boolean
        Dim Inlagd As Boolean = False

        Try
            Dim utm As New tblmonsterToUser
            utm.monid = monsterid
            utm.userid = userid
            utm.monlevel = 1
            utm.MonsterScore = 1000
            utm.MonsterXP = 1000

            _linqObj.tblmonsterToUsers.InsertOnSubmit(utm)
            _linqObj.SubmitChanges()

            Inlagd = True

        Catch ex As Exception
            Inlagd = False
        End Try

        Return Inlagd
    End Function


    Public Function updMonsterToUser(ByVal userid As Integer, ByVal monsterid As Integer, ByVal monlev As Integer, ByVal monscore As Integer, ByVal monXP As Integer) As Boolean
        Dim ret As Boolean = False

        Dim utm = (From t In _linqObj.tblmonsterToUsers
                   Where t.userid = userid And t.monid = monsterid
                   Select t).First()
        Try

            utm.monlevel = monlev
            utm.MonsterScore = monscore
            utm.MonsterXP = monXP
            _linqObj.SubmitChanges()

            ret = True
        Catch ex As Exception
            ret = False
        End Try

        Return ret

    End Function

    Public Function getBokemonmaxpoint(monsterid As Integer) As Integer
        Dim ret As Integer = 0
        Dim monsterlist = (From t In _linqObj.tblmonsterLists
                           Where t.monId = monsterid
                           Select t).First()

        Try

            ret = monsterlist.maxpoint
        Catch ex As Exception
            ret = 0
        End Try

        Return ret
    End Function

#Region "Bokemon Loghandler"

    Public Function addMonsterLog(logobj As bokemonlogInfo) As Boolean
        Dim Inlagd As Boolean = False

        Try
            Dim utm As New tblmonsterLog
            utm.logtype = logobj.Logtyp
            utm.Userid = logobj.Userid
            utm.monid = logobj.Monid
            utm.winlose = logobj.WinLose
            utm.points = logobj.Scorepoints
            utm.logtext = logobj.Logtext
            utm.datum = DateTime.Now

            _linqObj.tblmonsterLogs.InsertOnSubmit(utm)
            _linqObj.SubmitChanges()

            Inlagd = True

        Catch ex As Exception
            Inlagd = False
        End Try

        Return Inlagd
    End Function
#End Region

#Region "HighscoreHandler"
    Public Function getHighscore() As List(Of bokemonHighscoreInfo)
        Dim highscorelistan As New List(Of bokemonHighscoreInfo)
        Dim platsnr As Integer = 0

        Dim HSlist = From m In _linqObj.AJ_getMonsterHighscore(5)
                     Select m

        For Each monst In HSlist
            platsnr += 1
            Dim mon As New bokemonHighscoreInfo
            mon.Platsnr = platsnr
            mon.Bokemonusername = monst.DisplayName
            mon.Bokemonuserscore = monst.highscore
            highscorelistan.Add(mon)

        Next

        Return highscorelistan

    End Function

#End Region
#Region "Bokemon HELPER"

    Public Function isBokemonInUserList(ByVal userid As Integer, ByVal monsterid As Integer) As bokemonfightInfo

        Dim ret As New bokemonfightInfo

        Dim utm = From t In _linqObj.tblmonsterToUsers
                  Where t.userid = userid And t.monid = monsterid
                  Select t
        Try
            If utm.Count > 0 Then
                For Each mon In utm
                    ret.CurrentXP = mon.MonsterXP
                    ret.CurrentScore = mon.MonsterScore
                Next
            End If

        Catch ex As Exception
            ret.CurrentXP = -999999
            ret.CurrentScore = -999999
        End Try

        Return ret

    End Function

#End Region
End Class
