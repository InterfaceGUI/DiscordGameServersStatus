Imports Discord
Imports Discord.WebSocket
Public Class Form1
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
End Class
