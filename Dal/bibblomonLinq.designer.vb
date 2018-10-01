﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="AJDNNDatabase_v5")>  _
Partial Public Class bibblomonLinqDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Inserttblmonster(instance As tblmonster)
    End Sub
  Partial Private Sub Updatetblmonster(instance As tblmonster)
    End Sub
  Partial Private Sub Deletetblmonster(instance As tblmonster)
    End Sub
  Partial Private Sub InserttblmonsterToUser(instance As tblmonsterToUser)
    End Sub
  Partial Private Sub UpdatetblmonsterToUser(instance As tblmonsterToUser)
    End Sub
  Partial Private Sub DeletetblmonsterToUser(instance As tblmonsterToUser)
    End Sub
  Partial Private Sub InserttblmonsterDrakelist(instance As tblmonsterDrakelist)
    End Sub
  Partial Private Sub UpdatetblmonsterDrakelist(instance As tblmonsterDrakelist)
    End Sub
  Partial Private Sub DeletetblmonsterDrakelist(instance As tblmonsterDrakelist)
    End Sub
  Partial Private Sub InserttblmonsterList(instance As tblmonsterList)
    End Sub
  Partial Private Sub UpdatetblmonsterList(instance As tblmonsterList)
    End Sub
  Partial Private Sub DeletetblmonsterList(instance As tblmonsterList)
    End Sub
  Partial Private Sub InserttblmonsterLog(instance As tblmonsterLog)
    End Sub
  Partial Private Sub UpdatetblmonsterLog(instance As tblmonsterLog)
    End Sub
  Partial Private Sub DeletetblmonsterLog(instance As tblmonsterLog)
    End Sub
  Partial Private Sub InserttblmonsterLogtyper(instance As tblmonsterLogtyper)
    End Sub
  Partial Private Sub UpdatetblmonsterLogtyper(instance As tblmonsterLogtyper)
    End Sub
  Partial Private Sub DeletetblmonsterLogtyper(instance As tblmonsterLogtyper)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.BibblomonLibrary.My.MySettings.Default.AJDNNDatabase_v5ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tblmonsters() As System.Data.Linq.Table(Of tblmonster)
		Get
			Return Me.GetTable(Of tblmonster)
		End Get
	End Property
	
	Public ReadOnly Property tblmonsterToUsers() As System.Data.Linq.Table(Of tblmonsterToUser)
		Get
			Return Me.GetTable(Of tblmonsterToUser)
		End Get
	End Property
	
	Public ReadOnly Property tblmonsterDrakelists() As System.Data.Linq.Table(Of tblmonsterDrakelist)
		Get
			Return Me.GetTable(Of tblmonsterDrakelist)
		End Get
	End Property
	
	Public ReadOnly Property tblmonsterLists() As System.Data.Linq.Table(Of tblmonsterList)
		Get
			Return Me.GetTable(Of tblmonsterList)
		End Get
	End Property
	
	Public ReadOnly Property tblmonsterLogs() As System.Data.Linq.Table(Of tblmonsterLog)
		Get
			Return Me.GetTable(Of tblmonsterLog)
		End Get
	End Property
	
	Public ReadOnly Property tblmonsterLogtypers() As System.Data.Linq.Table(Of tblmonsterLogtyper)
		Get
			Return Me.GetTable(Of tblmonsterLogtyper)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.AJ_getMonsterHighscore")>  _
	Public Function AJ_getMonsterHighscore(<Global.System.Data.Linq.Mapping.ParameterAttribute(DbType:="Int")> ByVal antal As System.Nullable(Of Integer)) As ISingleResult(Of AJ_getMonsterHighscoreResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), antal)
		Return CType(result.ReturnValue,ISingleResult(Of AJ_getMonsterHighscoreResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.AJ_getMonsterlistExt")>  _
	Public Function AJ_getMonsterlistExt(<Global.System.Data.Linq.Mapping.ParameterAttribute(DbType:="Int")> ByVal userid As System.Nullable(Of Integer)) As ISingleResult(Of AJ_getMonsterlistExtResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), userid)
		Return CType(result.ReturnValue,ISingleResult(Of AJ_getMonsterlistExtResult))
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonster")>  _
Partial Public Class tblmonster
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Monsterid As Integer
	
	Private _Userid As System.Nullable(Of Integer)
	
	Private _timetonext As System.Nullable(Of Integer)
	
	Private _totalscore As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMonsteridChanging(value As Integer)
    End Sub
    Partial Private Sub OnMonsteridChanged()
    End Sub
    Partial Private Sub OnUseridChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnUseridChanged()
    End Sub
    Partial Private Sub OntimetonextChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OntimetonextChanged()
    End Sub
    Partial Private Sub OntotalscoreChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OntotalscoreChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Monsterid", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Monsterid() As Integer
		Get
			Return Me._Monsterid
		End Get
		Set
			If ((Me._Monsterid = value)  _
						= false) Then
				Me.OnMonsteridChanging(value)
				Me.SendPropertyChanging
				Me._Monsterid = value
				Me.SendPropertyChanged("Monsterid")
				Me.OnMonsteridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Userid", DbType:="Int")>  _
	Public Property Userid() As System.Nullable(Of Integer)
		Get
			Return Me._Userid
		End Get
		Set
			If (Me._Userid.Equals(value) = false) Then
				Me.OnUseridChanging(value)
				Me.SendPropertyChanging
				Me._Userid = value
				Me.SendPropertyChanged("Userid")
				Me.OnUseridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_timetonext", DbType:="Int")>  _
	Public Property timetonext() As System.Nullable(Of Integer)
		Get
			Return Me._timetonext
		End Get
		Set
			If (Me._timetonext.Equals(value) = false) Then
				Me.OntimetonextChanging(value)
				Me.SendPropertyChanging
				Me._timetonext = value
				Me.SendPropertyChanged("timetonext")
				Me.OntimetonextChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_totalscore", DbType:="Int")>  _
	Public Property totalscore() As System.Nullable(Of Integer)
		Get
			Return Me._totalscore
		End Get
		Set
			If (Me._totalscore.Equals(value) = false) Then
				Me.OntotalscoreChanging(value)
				Me.SendPropertyChanging
				Me._totalscore = value
				Me.SendPropertyChanged("totalscore")
				Me.OntotalscoreChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonsterToUser")>  _
Partial Public Class tblmonsterToUser
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _monid As System.Nullable(Of Integer)
	
	Private _userid As System.Nullable(Of Integer)
	
	Private _MonsterScore As System.Nullable(Of Integer)
	
	Private _monlevel As System.Nullable(Of Integer)
	
	Private _MonsterXP As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OnmonidChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnmonidChanged()
    End Sub
    Partial Private Sub OnuseridChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnuseridChanged()
    End Sub
    Partial Private Sub OnMonsterScoreChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnMonsterScoreChanged()
    End Sub
    Partial Private Sub OnmonlevelChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnmonlevelChanged()
    End Sub
    Partial Private Sub OnMonsterXPChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnMonsterXPChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monid", DbType:="Int")>  _
	Public Property monid() As System.Nullable(Of Integer)
		Get
			Return Me._monid
		End Get
		Set
			If (Me._monid.Equals(value) = false) Then
				Me.OnmonidChanging(value)
				Me.SendPropertyChanging
				Me._monid = value
				Me.SendPropertyChanged("monid")
				Me.OnmonidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_userid", DbType:="Int")>  _
	Public Property userid() As System.Nullable(Of Integer)
		Get
			Return Me._userid
		End Get
		Set
			If (Me._userid.Equals(value) = false) Then
				Me.OnuseridChanging(value)
				Me.SendPropertyChanging
				Me._userid = value
				Me.SendPropertyChanged("userid")
				Me.OnuseridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MonsterScore", DbType:="Int")>  _
	Public Property MonsterScore() As System.Nullable(Of Integer)
		Get
			Return Me._MonsterScore
		End Get
		Set
			If (Me._MonsterScore.Equals(value) = false) Then
				Me.OnMonsterScoreChanging(value)
				Me.SendPropertyChanging
				Me._MonsterScore = value
				Me.SendPropertyChanged("MonsterScore")
				Me.OnMonsterScoreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monlevel", DbType:="Int")>  _
	Public Property monlevel() As System.Nullable(Of Integer)
		Get
			Return Me._monlevel
		End Get
		Set
			If (Me._monlevel.Equals(value) = false) Then
				Me.OnmonlevelChanging(value)
				Me.SendPropertyChanging
				Me._monlevel = value
				Me.SendPropertyChanged("monlevel")
				Me.OnmonlevelChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MonsterXP", DbType:="Int")>  _
	Public Property MonsterXP() As System.Nullable(Of Integer)
		Get
			Return Me._MonsterXP
		End Get
		Set
			If (Me._MonsterXP.Equals(value) = false) Then
				Me.OnMonsterXPChanging(value)
				Me.SendPropertyChanging
				Me._MonsterXP = value
				Me.SendPropertyChanged("MonsterXP")
				Me.OnMonsterXPChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonsterDrakelist")>  _
Partial Public Class tblmonsterDrakelist
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _drakId As Integer
	
	Private _draknamn As String
	
	Private _draksrc As String
	
	Private _drakinfo As String
	
	Private _drakbasepoint As System.Nullable(Of Integer)
	
	Private _drakbonus As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OndrakIdChanging(value As Integer)
    End Sub
    Partial Private Sub OndrakIdChanged()
    End Sub
    Partial Private Sub OndraknamnChanging(value As String)
    End Sub
    Partial Private Sub OndraknamnChanged()
    End Sub
    Partial Private Sub OndraksrcChanging(value As String)
    End Sub
    Partial Private Sub OndraksrcChanged()
    End Sub
    Partial Private Sub OndrakinfoChanging(value As String)
    End Sub
    Partial Private Sub OndrakinfoChanged()
    End Sub
    Partial Private Sub OndrakbasepointChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OndrakbasepointChanged()
    End Sub
    Partial Private Sub OndrakbonusChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OndrakbonusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_drakId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property drakId() As Integer
		Get
			Return Me._drakId
		End Get
		Set
			If ((Me._drakId = value)  _
						= false) Then
				Me.OndrakIdChanging(value)
				Me.SendPropertyChanging
				Me._drakId = value
				Me.SendPropertyChanged("drakId")
				Me.OndrakIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_draknamn", DbType:="NVarChar(50)")>  _
	Public Property draknamn() As String
		Get
			Return Me._draknamn
		End Get
		Set
			If (String.Equals(Me._draknamn, value) = false) Then
				Me.OndraknamnChanging(value)
				Me.SendPropertyChanging
				Me._draknamn = value
				Me.SendPropertyChanged("draknamn")
				Me.OndraknamnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_draksrc", DbType:="NVarChar(250)")>  _
	Public Property draksrc() As String
		Get
			Return Me._draksrc
		End Get
		Set
			If (String.Equals(Me._draksrc, value) = false) Then
				Me.OndraksrcChanging(value)
				Me.SendPropertyChanging
				Me._draksrc = value
				Me.SendPropertyChanged("draksrc")
				Me.OndraksrcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_drakinfo", DbType:="NVarChar(500)")>  _
	Public Property drakinfo() As String
		Get
			Return Me._drakinfo
		End Get
		Set
			If (String.Equals(Me._drakinfo, value) = false) Then
				Me.OndrakinfoChanging(value)
				Me.SendPropertyChanging
				Me._drakinfo = value
				Me.SendPropertyChanged("drakinfo")
				Me.OndrakinfoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_drakbasepoint", DbType:="Int")>  _
	Public Property drakbasepoint() As System.Nullable(Of Integer)
		Get
			Return Me._drakbasepoint
		End Get
		Set
			If (Me._drakbasepoint.Equals(value) = false) Then
				Me.OndrakbasepointChanging(value)
				Me.SendPropertyChanging
				Me._drakbasepoint = value
				Me.SendPropertyChanged("drakbasepoint")
				Me.OndrakbasepointChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_drakbonus", DbType:="Int")>  _
	Public Property drakbonus() As System.Nullable(Of Integer)
		Get
			Return Me._drakbonus
		End Get
		Set
			If (Me._drakbonus.Equals(value) = false) Then
				Me.OndrakbonusChanging(value)
				Me.SendPropertyChanging
				Me._drakbonus = value
				Me.SendPropertyChanged("drakbonus")
				Me.OndrakbonusChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonsterList")>  _
Partial Public Class tblmonsterList
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _monId As Integer
	
	Private _monsternamn As String
	
	Private _monstersrc As String
	
	Private _monsterinfo As String
	
	Private _basepoint As System.Nullable(Of Integer)
	
	Private _bonus As System.Nullable(Of Integer)
	
	Private _maxpoint As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnmonIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnmonIdChanged()
    End Sub
    Partial Private Sub OnmonsternamnChanging(value As String)
    End Sub
    Partial Private Sub OnmonsternamnChanged()
    End Sub
    Partial Private Sub OnmonstersrcChanging(value As String)
    End Sub
    Partial Private Sub OnmonstersrcChanged()
    End Sub
    Partial Private Sub OnmonsterinfoChanging(value As String)
    End Sub
    Partial Private Sub OnmonsterinfoChanged()
    End Sub
    Partial Private Sub OnbasepointChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnbasepointChanged()
    End Sub
    Partial Private Sub OnbonusChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnbonusChanged()
    End Sub
    Partial Private Sub OnmaxpointChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnmaxpointChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property monId() As Integer
		Get
			Return Me._monId
		End Get
		Set
			If ((Me._monId = value)  _
						= false) Then
				Me.OnmonIdChanging(value)
				Me.SendPropertyChanging
				Me._monId = value
				Me.SendPropertyChanged("monId")
				Me.OnmonIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monsternamn", DbType:="NVarChar(50)")>  _
	Public Property monsternamn() As String
		Get
			Return Me._monsternamn
		End Get
		Set
			If (String.Equals(Me._monsternamn, value) = false) Then
				Me.OnmonsternamnChanging(value)
				Me.SendPropertyChanging
				Me._monsternamn = value
				Me.SendPropertyChanged("monsternamn")
				Me.OnmonsternamnChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monstersrc", DbType:="NVarChar(250)")>  _
	Public Property monstersrc() As String
		Get
			Return Me._monstersrc
		End Get
		Set
			If (String.Equals(Me._monstersrc, value) = false) Then
				Me.OnmonstersrcChanging(value)
				Me.SendPropertyChanging
				Me._monstersrc = value
				Me.SendPropertyChanged("monstersrc")
				Me.OnmonstersrcChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monsterinfo", DbType:="NVarChar(500)")>  _
	Public Property monsterinfo() As String
		Get
			Return Me._monsterinfo
		End Get
		Set
			If (String.Equals(Me._monsterinfo, value) = false) Then
				Me.OnmonsterinfoChanging(value)
				Me.SendPropertyChanging
				Me._monsterinfo = value
				Me.SendPropertyChanged("monsterinfo")
				Me.OnmonsterinfoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_basepoint", DbType:="Int")>  _
	Public Property basepoint() As System.Nullable(Of Integer)
		Get
			Return Me._basepoint
		End Get
		Set
			If (Me._basepoint.Equals(value) = false) Then
				Me.OnbasepointChanging(value)
				Me.SendPropertyChanging
				Me._basepoint = value
				Me.SendPropertyChanged("basepoint")
				Me.OnbasepointChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_bonus", DbType:="Int")>  _
	Public Property bonus() As System.Nullable(Of Integer)
		Get
			Return Me._bonus
		End Get
		Set
			If (Me._bonus.Equals(value) = false) Then
				Me.OnbonusChanging(value)
				Me.SendPropertyChanging
				Me._bonus = value
				Me.SendPropertyChanged("bonus")
				Me.OnbonusChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_maxpoint", DbType:="Int")>  _
	Public Property maxpoint() As System.Nullable(Of Integer)
		Get
			Return Me._maxpoint
		End Get
		Set
			If (Me._maxpoint.Equals(value) = false) Then
				Me.OnmaxpointChanging(value)
				Me.SendPropertyChanging
				Me._maxpoint = value
				Me.SendPropertyChanged("maxpoint")
				Me.OnmaxpointChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonsterLog")>  _
Partial Public Class tblmonsterLog
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _LogID As Integer
	
	Private _logtype As System.Nullable(Of Integer)
	
	Private _Userid As System.Nullable(Of Integer)
	
	Private _monid As System.Nullable(Of Integer)
	
	Private _winlose As System.Nullable(Of Integer)
	
	Private _points As System.Nullable(Of Integer)
	
	Private _logtext As String
	
	Private _datum As System.Nullable(Of Date)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnLogIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnLogIDChanged()
    End Sub
    Partial Private Sub OnlogtypeChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnlogtypeChanged()
    End Sub
    Partial Private Sub OnUseridChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnUseridChanged()
    End Sub
    Partial Private Sub OnmonidChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnmonidChanged()
    End Sub
    Partial Private Sub OnwinloseChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnwinloseChanged()
    End Sub
    Partial Private Sub OnpointsChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnpointsChanged()
    End Sub
    Partial Private Sub OnlogtextChanging(value As String)
    End Sub
    Partial Private Sub OnlogtextChanged()
    End Sub
    Partial Private Sub OndatumChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OndatumChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LogID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property LogID() As Integer
		Get
			Return Me._LogID
		End Get
		Set
			If ((Me._LogID = value)  _
						= false) Then
				Me.OnLogIDChanging(value)
				Me.SendPropertyChanging
				Me._LogID = value
				Me.SendPropertyChanged("LogID")
				Me.OnLogIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logtype", DbType:="Int")>  _
	Public Property logtype() As System.Nullable(Of Integer)
		Get
			Return Me._logtype
		End Get
		Set
			If (Me._logtype.Equals(value) = false) Then
				Me.OnlogtypeChanging(value)
				Me.SendPropertyChanging
				Me._logtype = value
				Me.SendPropertyChanged("logtype")
				Me.OnlogtypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Userid", DbType:="Int")>  _
	Public Property Userid() As System.Nullable(Of Integer)
		Get
			Return Me._Userid
		End Get
		Set
			If (Me._Userid.Equals(value) = false) Then
				Me.OnUseridChanging(value)
				Me.SendPropertyChanging
				Me._Userid = value
				Me.SendPropertyChanged("Userid")
				Me.OnUseridChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monid", DbType:="Int")>  _
	Public Property monid() As System.Nullable(Of Integer)
		Get
			Return Me._monid
		End Get
		Set
			If (Me._monid.Equals(value) = false) Then
				Me.OnmonidChanging(value)
				Me.SendPropertyChanging
				Me._monid = value
				Me.SendPropertyChanged("monid")
				Me.OnmonidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_winlose", DbType:="Int")>  _
	Public Property winlose() As System.Nullable(Of Integer)
		Get
			Return Me._winlose
		End Get
		Set
			If (Me._winlose.Equals(value) = false) Then
				Me.OnwinloseChanging(value)
				Me.SendPropertyChanging
				Me._winlose = value
				Me.SendPropertyChanged("winlose")
				Me.OnwinloseChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_points", DbType:="Int")>  _
	Public Property points() As System.Nullable(Of Integer)
		Get
			Return Me._points
		End Get
		Set
			If (Me._points.Equals(value) = false) Then
				Me.OnpointsChanging(value)
				Me.SendPropertyChanging
				Me._points = value
				Me.SendPropertyChanged("points")
				Me.OnpointsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logtext", DbType:="NVarChar(500)")>  _
	Public Property logtext() As String
		Get
			Return Me._logtext
		End Get
		Set
			If (String.Equals(Me._logtext, value) = false) Then
				Me.OnlogtextChanging(value)
				Me.SendPropertyChanging
				Me._logtext = value
				Me.SendPropertyChanged("logtext")
				Me.OnlogtextChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_datum", DbType:="Date")>  _
	Public Property datum() As System.Nullable(Of Date)
		Get
			Return Me._datum
		End Get
		Set
			If (Me._datum.Equals(value) = false) Then
				Me.OndatumChanging(value)
				Me.SendPropertyChanging
				Me._datum = value
				Me.SendPropertyChanged("datum")
				Me.OndatumChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tblmonsterLogtyper")>  _
Partial Public Class tblmonsterLogtyper
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _logtypid As Integer
	
	Private _logtyp As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlogtypidChanging(value As Integer)
    End Sub
    Partial Private Sub OnlogtypidChanged()
    End Sub
    Partial Private Sub OnlogtypChanging(value As String)
    End Sub
    Partial Private Sub OnlogtypChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logtypid", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property logtypid() As Integer
		Get
			Return Me._logtypid
		End Get
		Set
			If ((Me._logtypid = value)  _
						= false) Then
				Me.OnlogtypidChanging(value)
				Me.SendPropertyChanging
				Me._logtypid = value
				Me.SendPropertyChanged("logtypid")
				Me.OnlogtypidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_logtyp", DbType:="NVarChar(50)")>  _
	Public Property logtyp() As String
		Get
			Return Me._logtyp
		End Get
		Set
			If (String.Equals(Me._logtyp, value) = false) Then
				Me.OnlogtypChanging(value)
				Me.SendPropertyChanging
				Me._logtyp = value
				Me.SendPropertyChanged("logtyp")
				Me.OnlogtypChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class AJ_getMonsterHighscoreResult
	
	Private _highscore As System.Nullable(Of Integer)
	
	Private _DisplayName As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_highscore", DbType:="Int")>  _
	Public Property highscore() As System.Nullable(Of Integer)
		Get
			Return Me._highscore
		End Get
		Set
			If (Me._highscore.Equals(value) = false) Then
				Me._highscore = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DisplayName", DbType:="NVarChar(128) NOT NULL", CanBeNull:=false)>  _
	Public Property DisplayName() As String
		Get
			Return Me._DisplayName
		End Get
		Set
			If (String.Equals(Me._DisplayName, value) = false) Then
				Me._DisplayName = value
			End If
		End Set
	End Property
End Class

Partial Public Class AJ_getMonsterlistExtResult
	
	Private _monId As Integer
	
	Private _monsternamn As String
	
	Private _monstersrc As String
	
	Private _basepoint As System.Nullable(Of Integer)
	
	Private _bonus As System.Nullable(Of Integer)
	
	Private _monsterinfo As String
	
	Private _MonsterScore As System.Nullable(Of Integer)
	
	Private _MonsterXP As System.Nullable(Of Integer)
	
	Private _monlevel As System.Nullable(Of Integer)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monId", DbType:="Int NOT NULL")>  _
	Public Property monId() As Integer
		Get
			Return Me._monId
		End Get
		Set
			If ((Me._monId = value)  _
						= false) Then
				Me._monId = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monsternamn", DbType:="NVarChar(50)")>  _
	Public Property monsternamn() As String
		Get
			Return Me._monsternamn
		End Get
		Set
			If (String.Equals(Me._monsternamn, value) = false) Then
				Me._monsternamn = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monstersrc", DbType:="NVarChar(250)")>  _
	Public Property monstersrc() As String
		Get
			Return Me._monstersrc
		End Get
		Set
			If (String.Equals(Me._monstersrc, value) = false) Then
				Me._monstersrc = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_basepoint", DbType:="Int")>  _
	Public Property basepoint() As System.Nullable(Of Integer)
		Get
			Return Me._basepoint
		End Get
		Set
			If (Me._basepoint.Equals(value) = false) Then
				Me._basepoint = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_bonus", DbType:="Int")>  _
	Public Property bonus() As System.Nullable(Of Integer)
		Get
			Return Me._bonus
		End Get
		Set
			If (Me._bonus.Equals(value) = false) Then
				Me._bonus = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monsterinfo", DbType:="NVarChar(500)")>  _
	Public Property monsterinfo() As String
		Get
			Return Me._monsterinfo
		End Get
		Set
			If (String.Equals(Me._monsterinfo, value) = false) Then
				Me._monsterinfo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MonsterScore", DbType:="Int")>  _
	Public Property MonsterScore() As System.Nullable(Of Integer)
		Get
			Return Me._MonsterScore
		End Get
		Set
			If (Me._MonsterScore.Equals(value) = false) Then
				Me._MonsterScore = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MonsterXP", DbType:="Int")>  _
	Public Property MonsterXP() As System.Nullable(Of Integer)
		Get
			Return Me._MonsterXP
		End Get
		Set
			If (Me._MonsterXP.Equals(value) = false) Then
				Me._MonsterXP = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_monlevel", DbType:="Int")>  _
	Public Property monlevel() As System.Nullable(Of Integer)
		Get
			Return Me._monlevel
		End Get
		Set
			If (Me._monlevel.Equals(value) = false) Then
				Me._monlevel = value
			End If
		End Set
	End Property
End Class
