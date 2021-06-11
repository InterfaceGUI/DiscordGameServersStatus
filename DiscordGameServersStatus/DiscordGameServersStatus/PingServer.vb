Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Server.Ping
    Public NotInheritable Class PingServer

        Public Property IsOnline As Boolean

        Private Sub New(ByVal isonlone As Boolean)
            Me.IsOnline = isonlone
        End Sub

        Public Shared Function Ping(ByVal sIP As String, ByVal nPort As Integer) As PingServer

            'Dim endPoint As New IPEndPoint(IPAddress.Parse(Dns.GetHostEntry(sIP).AddressList(0).ToString), nPort)

            Dim endPoint As New IPEndPoint(IPAddress.Parse(sIP), nPort)
            Try
                Dim sclient As Socket = New Socket(AddressFamily.InterNetwork， SocketType.Stream， ProtocolType.Tcp)
                Dim a = sclient.BeginConnect(endPoint, Nothing, Nothing)

                Return New PingServer(a.AsyncWaitHandle.WaitOne(1000, True))
            Catch ex As Exception
                Return New PingServer(False)
            End Try
        End Function

    End Class



    Public NotInheritable Class MinecraftServerInfo

        Public Property ServerMotd As String

        Public Property MaxPlayerCount As Int64

        Public Property IsOnline As Boolean

        Public Property CurrentPlayerCount As Int64

        Public Property MinecraftVersion As String

        Public Property ErrorMessage As String

        Public Property isError As String

        Private Sub New(ByVal isonlone As Boolean, ByVal motd As String, ByVal maxplayers As Int64, ByVal playercount As Int64, Version As String, Optional isError As Boolean = False, Optional ErrorMessage As String = "")
            Me.IsOnline = isonlone
            Me.ServerMotd = motd
            Me.MaxPlayerCount = maxplayers
            Me.CurrentPlayerCount = playercount
            Me.MinecraftVersion = Version
            Me.isError = isError
            Me.ErrorMessage = ErrorMessage
        End Sub

        Public Shared Function GetServerInformation(ByVal ip As String, ByVal port As Integer) As MinecraftServerInfo
            Try
                Dim request As HttpWebRequest  '宣告Http請求

                Dim response As HttpWebResponse = Nothing '宣告Http伺服器回應

                request = WebRequest.Create("https://mcapi.us/server/status?ip=" & ip & "&port=" & port) '那個API調用部分

                response = request.GetResponse() '取得回應  p.s. 這裡並未使用異步、可能會出現wpf凍結等待伺服器回傳資料

                Dim reader As New StreamReader(response.GetResponseStream()) '宣告資料流讀取 ，並取得回應得資料流

                Dim jData As String '宣告json
                While reader.Peek >= 0
                    jData = reader.ReadToEnd()
                End While

                Dim dict As JObject = CType(JsonConvert.DeserializeObject(jData), JObject) '宣告dict是個json物件，並且反序列化輸入的字串

                Dim Players As players = JsonConvert.DeserializeObject(Of players)(dict("players").ToString) '抓出資料

                Dim server As server = JsonConvert.DeserializeObject(Of server)(dict("server").ToString)


                'MsgBox("狀態: " & IIf(dict("online"), "Online", "False") & vbLf & "玩家人數:" & Players & vbLf & "版本: " & server.name)



                '取得MC伺服器 線上狀態
                If dict("online").ToString = "False" Then

                    If dict("status").ToString = "error" Then
                        Return New MinecraftServerInfo(False, "", 0, 0, Nothing, True, dict("error").ToString)
                    End If

                    Return New MinecraftServerInfo(False, "", 0, 0, Nothing)
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
