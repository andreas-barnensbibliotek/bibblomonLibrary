Public Class BibblomonMainController
    Private _dalobj As New bokemonDAL
    Public Function getbaseUserAndMonsterList(ByVal userid As Integer) As bokemonInfo
        Dim retobj As New bokemonInfo
        Try
            retobj = _dalobj.getUserbokemon(userid)
            retobj.Status = "All user bokemon"
        Catch ex As Exception
            retobj.Status = "nått blev fel"
        End Try

        Return retobj

    End Function

    Public Function getbaseAllMonsterList(ByVal userid As Integer) As bokemonInfo
            Dim retobj As New bokemonInfo

        Try
            retobj = _dalobj.getAllbokemon(userid)
            retobj.Status = "All bokemons"
            Catch ex As Exception
                retobj.Status = "nått blev fel"
            End Try

            Return retobj

        End Function



        Public Function getbaseAllDrakarList(ByVal userid As Integer) As bokemonInfo
            Dim retobj As New bokemonInfo

        Try
            retobj = _dalobj.getAllbokdrakar(userid)
            retobj.Status = "Alla bokdrakar"
            Catch ex As Exception
                retobj.Status = "nått blev fel"
            End Try

            Return retobj

        End Function


        Public Function MonsterToUserList(ByVal userid As Integer, ByVal monsterid As Integer) As bokemonInfo
            Dim retobj As New bokemonInfo

        Dim monsterobj As New bokemonfightInfo
            Dim loggerobj As New bokemonlogInfo
            Dim MonsterMaxPoint As Integer = 0

            If monsterid > 0 Then

            monsterobj = _dalobj.isBokemonInUserList(userid, monsterid) 'monsterxp är samma som monsterscore tills monsterscore når maxpoint, sedan ökar bara monsterxp
            MonsterMaxPoint = _dalobj.getBokemonmaxpoint(monsterid)

            If monsterobj.CurrentXP > 0 Then

                    monsterobj.GameScore = calcMonsterScore("upd")
                    monsterobj.NewScore = monsterobj.CurrentScore + monsterobj.GameScore

                    If monsterobj.NewScore > MonsterMaxPoint Then
                        monsterobj.NewScore = MonsterMaxPoint

                    End If

                    monsterobj.NewXP = monsterobj.CurrentXP + monsterobj.GameScore

                    Dim newlevel As Integer = calcMonsterLevel(monsterobj.NewScore)

                Dim isupdated As Boolean = _dalobj.updMonsterToUser(userid, monsterid, newlevel, monsterobj.NewScore, monsterobj.NewXP)
                retobj = _dalobj.getUserbokemon(userid)

                ' Add to log -------------------------------------
                loggerobj.Scorepoints = monsterobj.GameScore
                    loggerobj.Logtyp = 2
                    loggerobj.Userid = userid
                    loggerobj.Monid = monsterid
                    loggerobj.Logtext = "update bokemon"
                Dim updatelog As Boolean = _dalobj.addMonsterLog(loggerobj)

                If isupdated Then
                        retobj.Status = "Monster updated to user: " & userid
                    Else
                        retobj.Status = "Nått blev fel när monster skulle uppdateras till user" & userid
                    End If

                Else
                Dim isadded As Boolean = _dalobj.addMonsterToUser(userid, monsterid)
                retobj = _dalobj.getUserbokemon(userid)
                If isadded Then
                        retobj.Status = "Monster added to user: " & userid
                    Else
                        retobj.Status = "Nått blev fel när monster skulle läggas till user" & userid
                    End If

                End If
            Else

                retobj.Status = "Nått blev fel när monster skulle läggas till. Monsterid= " & monsterid
            End If
            'addTimetoNext(userid, timetn)

            Return retobj

        End Function

        Public Function MonsterGameplay(ByVal userid As Integer, ByVal monsterid As Integer, VinnOrLose As String) As bokemonInfo
            Dim retobj As New bokemonInfo

        Dim fightlog As New bokemonlogInfo
            Dim fightobj As New bokemonfightInfo
            Dim MonsterMaxPoint As Integer = 0
            Dim newmonsXP As Integer = 0
            Dim tmpfightPoint As Integer = 0


            If monsterid > 0 Then

            fightobj = _dalobj.isBokemonInUserList(userid, monsterid) 'monsterxp är samma som monsterscore tills monsterscore når maxpoint, sedan ökar bara monsterxp
            MonsterMaxPoint = _dalobj.getBokemonmaxpoint(monsterid)

            If fightobj.CurrentScore >= 1000 Then
                    fightobj.GameScore = calcMonsterScore(VinnOrLose)

                    If VinnOrLose = "win" Then
                        fightobj.NewScore = fightobj.CurrentScore + fightobj.GameScore
                        fightobj.GameXP = fightobj.GameScore
                        fightlog.WinLose = 1

                    Else 'if lose
                        If (fightobj.CurrentScore - fightobj.GameScore) > 1000 Then
                            fightobj.NewScore = fightobj.CurrentScore - fightobj.GameScore

                        Else
                            fightobj.NewScore = 1000

                        End If

                        fightobj.GameXP = 100
                        fightlog.WinLose = 0

                    End If

                    fightobj.NewXP = fightobj.CurrentXP + fightobj.GameXP

                    Dim newlevel As Integer = calcMonsterLevel(fightobj.NewScore)

                Dim isupdated As Boolean = _dalobj.updMonsterToUser(userid, monsterid, newlevel, fightobj.NewScore, fightobj.NewXP)
                retobj = _dalobj.getUserbokemon(userid)

                ' Add to log -------------------------------------
                fightlog.Scorepoints = fightobj.GameScore
                    fightlog.Logtyp = 1
                    fightlog.Userid = userid
                    fightlog.Monid = monsterid
                    fightlog.Logtext = "Fight"
                Dim updatelog As Boolean = _dalobj.addMonsterLog(fightlog)

                If isupdated Then
                        retobj.Status = "Monster game is a " & VinnOrLose & " and is updated to user: " & userid
                    Else
                        retobj.Status = "Nått blev fel när monsterXp skulle uppdateras till user" & userid
                    End If

                Else
                    retobj.Status = "Nått blev fel när monsterxp skulle räknas ut" & userid
                End If
            Else

                retobj.Status = "Nått blev fel när monster skulle läggas till. Monsterid= " & monsterid
            End If
            'addTimetoNext(userid, timetn)

            Return retobj

        End Function

    Public Function getHighscorelist() As bibblomonHighscoreInfo
        Dim retobj As New bibblomonHighscoreInfo
        Dim highscorelist As New List(Of bokemonHighscoreInfo)
        Try
            retobj.HighScoreList = _dalobj.getHighscore()
            retobj.Status = "Highscorelista hämtad"
        Catch ex As Exception
            retobj.Status = "ERROR vid hämtning av Highscorelista"
        End Try

        Return retobj

    End Function


    Private Function calcMonsterScore(ByVal typ As String) As Integer
            Dim retval As Integer

            Select Case typ
                Case "upd"
                    retval = 200 'öka med 200poäng

                Case "win"
                    retval = randomscore(True)

                Case "lose"
                    retval = randomscore(False)

            End Select

            Return retval
        End Function


        Private Function calcMonsterLevel(ByVal monScore As Integer) As Integer
            Dim retval As Integer
            If monScore >= 1000 Then
                Dim tmplv = monScore / 1000
                retval = Math.Round(tmplv, 0)
            Else
                retval = 1
            End If

            Return retval
        End Function


        Private Function randomscore(iswintyp As Boolean) As Integer
            Dim RandomClass As New Random()
            Dim RandomNumber As Integer

            If iswintyp Then
                RandomNumber = RandomClass.Next(300, 700)
            Else
                RandomNumber = RandomClass.Next(150, 400)
            End If

            Return RandomNumber
        End Function
    End Class