Imports Discord
Imports Discord.WebSocket
Imports System.Collections.Specialized
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports DiscordGameServersStatus.Server.Ping
Imports SSQLib
Public Class DGSS
    Dim Discord As DiscordSocketClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Discord = New DiscordSocketClient(New DiscordSocketConfig With {
                                          .WebSocketProvider = Net.Providers.WS4Net.WS4NetProvider.Instance,
                                          .UdpSocketProvider = Net.Providers.UDPClient.UDPClientProvider.Instance,
                                          .MessageCacheSize = 20
        })
    End Sub

    Private Sub DisocrdBOT設定_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Discordsetting.Show()
    End Sub

    Private Sub 伺服器列表_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ServerlistForm.Show()
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim endPoint As New IPEndPoint(IPAddress.Parse("185.38.148.140"), 27015)

        Dim SSQ As SSQL = New SSQL()
        Dim server As ServerInfo = SSQ.Server(endPoint)
        TextBox1.Text = server.MaxPlayers

    End Sub


End Class
