Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Gaming.Minecraft

    Public NotInheritable Class MinecraftServerInfo

        Public Property ServerMotd As String

        Public Property MaxPlayerCount As Int64

        Public Property IsOnline As Boolean

        Public Property CurrentPlayerCount As Int64

        Public Property MinecraftVersion As String

        Private Sub New(ByVal isonlone As Boolean, ByVal motd As String, ByVal maxplayers As Int64, ByVal playercount As Int64, Version As String)
            Me.IsOnline = isonlone
            Me.ServerMotd = motd
            Me.MaxPlayerCount = maxplayers
            Me.CurrentPlayerCount = playercount
            Me.MinecraftVersion = Version
        End Sub

        Public Shared Function GetServerInformation(ByVal ip As String, ByVal port As Integer) As MinecraftServerInfo
            Try
                Dim request As HttpWebRequest
                Dim response As HttpWebResponse = Nothing
                request = WebRequest.Create("https://mcapi.us/server/status?ip=" & ip & "&port=" & port)
                response = request.GetResponse()
                Dim reader As New StreamReader(response.GetResponseStream())
                Dim jData As String
                While reader.Peek >= 0
                    jData = reader.ReadToEnd()
                End While
                Dim dict As JObject = CType(JsonConvert.DeserializeObject(jData), JObject)
                Dim Players As players = JsonConvert.DeserializeObject(Of players)(dict("players").ToString)
                Dim server As server = JsonConvert.DeserializeObject(Of server)(dict("server").ToString)
                If dict("online").ToString = "False" Then
                    Return New MinecraftServerInfo(False, "", 0, 0, Nothing)
                ElseIf dict("online").ToString = "True" Then
                End If
                Return New MinecraftServerInfo(True, dict("motd"), Players.max, Players.now, server.name)
            Catch ex As Exception
                Return New MinecraftServerInfo(False, "", 0, 0, Nothing)
            End Try

        End Function
    End Class
    Public Structure server
        Dim name As String
        Dim protocol As Int16
    End Structure
    Public Structure players
        Dim max As Int64
        Dim now As Int64
    End Structure
End Namespace