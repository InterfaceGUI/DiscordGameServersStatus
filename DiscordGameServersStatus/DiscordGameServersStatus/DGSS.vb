Imports Discord
Imports Discord.WebSocket
Imports System.Net
Imports DiscordGameServersStatus.Server.Ping
Imports SSQLib
Public Class DGSS

    Dim Discord As DiscordSocketClient
    Dim Start As Boolean
    Dim Time() As Int32 = {600000, 1200000, 1800000, 3600000} ' 10分鐘,20分鐘,30分鐘,60分鐘
    Dim msg As Rest.RestUserMessage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '取得版本資訊
        If Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            Label4.Text = "Ver：" & Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If
        '--------------------------------------

        '初始化Dsicord-------------------
        Discord = New DiscordSocketClient(New DiscordSocketConfig With {
                                          .WebSocketProvider = Net.Providers.WS4Net.WS4NetProvider.Instance,
                                          .MessageCacheSize = 20
        })
        '--------------------------------------

        ComboBox1.SelectedIndex = My.Settings.Timer
        MainTimer.Interval = Time(My.Settings.Timer)
        Button4.Enabled = False

        If Not My.Settings.WMessage_ServerList Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            MsgBox_ServerList.ShowDialog()
        End If
    End Sub

    Private Async Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If My.Settings.token Is "" Then
            MsgBox("請先設定DiscordBot", 0 + 48)
            Discordsetting.ShowDialog()
            Exit Sub
        End If
        Start = Not Start
        If Start Then
            Try
                Await Discord.LoginAsync(TokenType.Bot, My.Settings.token)
                Await Discord.StartAsync
                Label2.Text = "已啟動"
                Label2.ForeColor = Drawing.Color.Green
                StartButton.Text = "停止"
                MainTimer.Enabled = True
                Button4.Enabled = True
                Button1.Enabled = False
                serverlistButton.Enabled = False
            Catch ex As Exception
                Start = False
                Label2.Text = "錯誤"
                Label2.ForeColor = Drawing.Color.Red
                MsgBox("錯誤訊息：" & vbCrLf & ex.Message, 0 + 16, "啟動BOT失敗")
                StartButton.Text = "啟動"
                MainTimer.Enabled = False
                Button4.Enabled = False
                Button1.Enabled = True
                serverlistButton.Enabled = True
            End Try
        Else
            Await Discord.LogoutAsync
            Await Discord.StopAsync
            StartButton.Text = "啟動"
            Label2.Text = "停止"
            Label2.ForeColor = Drawing.Color.Black
            MainTimer.Enabled = False
            Button4.Enabled = False
            Button1.Enabled = True
            serverlistButton.Enabled = True
        End If
    End Sub

    Private Function GetServersinfo() As List(Of EmbedFieldBuilder)
        Dim EmbedField As New List(Of EmbedFieldBuilder)
        Try
            Dim ip As String
            For i = 0 To My.Settings.serverCount

                Dim NShowIP As Boolean = IIf(My.Settings.showIP(i) = 1, True, False)

                If My.Settings.ServerEN(i) = 0 Then
                    Continue For
                End If


                Dim msg As String = ""
                Dim ServerName As String = My.Settings.ServersName(i)
                Try
                    ip = My.Settings.Serversip(i).Split(":")(0)
                Catch ex As NullReferenceException
                    MsgBox(ex.Message)
                Catch ex As Exception

                End Try

                Dim port As String
                Dim online() As String = {"離線 :negative_squared_cross_mark:", "線上 :white_check_mark:"}
                Try
                    port = My.Settings.Serversip(i).Split(":")(1)
                Catch ex As IndexOutOfRangeException
                    port = Nothing
                End Try

                Try
                    ip = Dns.GetHostByName(ip).AddressList(0).ToString()
                Catch ex As Exception
                End Try


                '  ------------------------------其他-----------------------------------
                If My.Settings.ServersGame(i) = "0" Then

                    Try
                        If port Is Nothing Then port = 0
                        Dim ping As PingServer = PingServer.Ping(ip, port)

                        If ping.IsOnline Then
                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i))) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            End If

                        Else

                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i)) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            End If

                        End If
                    Catch ex As Exception

                    End Try




                    '------------------------------MInecraft-----------------------------------
                ElseIf My.Settings.ServersGame(i) = "1" Then

                    If port Is Nothing Then port = 25565
                    Try
                        Dim ping As MinecraftServerInfo = MinecraftServerInfo.GetServerInformation(ip, port)
                        If ping.IsOnline Then

                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i)) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            End If

                            msg &= "**遊戲版本：**" & ping.MinecraftVersion & vbCrLf & "**人數：**" & ping.CurrentPlayerCount & "/" & ping.MaxPlayerCount & vbCrLf

                        Else

                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i)) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            End If

                        End If
                    Catch ex As Exception

                    End Try



                    '------------------------------Source引擎-----------------------------------
                ElseIf My.Settings.ServersGame(i) = "2" Then

                    If port Is Nothing Then port = 27015
                    Try
                        Dim SSQ As SSQL = New SSQL()
                        Dim endPoint As New IPEndPoint(IPAddress.Parse(ip), port)
                        Dim ping As ServerInfo = Nothing
                        Dim isonline As Boolean = False

                        Try
                            ping = SSQ.Server(endPoint)
                            isonline = True
                        Catch ex As SSQLServerException
                            isonline = False
                        End Try

                        If isonline Then

                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i)) & vbCrLf & "**狀態：**" & online(1) & vbCrLf
                            End If

                            msg &= "**伺服器名稱：**" & ping.Name & vbCrLf

                            msg &= "**遊戲：**" & ping.Game & "** 版本：**" & ping.Version & vbCrLf & "**人數：**" & ping.PlayerCount & "/" & ping.MaxPlayers & vbCrLf
                            msg &= "**地圖：**" & ping.Map & vbCrLf

                        Else

                            If port Is Nothing Then
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & ip) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            Else
                                msg = IIf(NShowIP, "", "**伺服器IP：**" & My.Settings.Serversip(i)) & vbCrLf & "**狀態：**" & online(0) & vbCrLf
                            End If

                        End If
                    Catch ex As Exception

                    End Try

                    '--------------------------------------------------------------------------------


                End If


                If msg IsNot "" Then
                    EmbedField.Add(New EmbedFieldBuilder With {
                                       .IsInline = True,
                                       .Name = ServerName,
                                       .Value = msg
                                       })
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return EmbedField
    End Function
    Dim message As Rest.RestUserMessage = Nothing
    Private Async Sub MainTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick, Button4.Click
        Dim embed As EmbedBuilder
        Try
            embed = New EmbedBuilder With {
                                                .Title = "各伺服器狀態",
                                                .Description = "",
                                                .Color = New Color(0, 255, 0),
                                                .Fields = GetServersinfo(),
                                                .Timestamp = Date.UtcNow,
                                                .Footer = New EmbedFooterBuilder With {
                                                .IconUrl = "https://i.imgur.com/UNPFf1f.jpg",
                                                .Text = "BOT made by 科技狼(Tech wolf)"
                                                }
                                                }

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            message = Await Discord.GetGuild(Discord.Guilds(0).Id).GetTextChannel(My.Settings.channel).GetMessageAsync(My.Settings.MessageID)
        Catch ex As Exception


        End Try

        Try
            If message Is Nothing Then
                message = Await Discord.GetGuild(Discord.Guilds(0).Id).GetTextChannel(My.Settings.channel).SendMessageAsync("", False, embed)
                My.Settings.MessageID = message.Id
                My.Settings.Save()
            Else
                Await message.ModifyAsync(Function(x)
                                              x.Content = ""
                                              x.Embed = embed.Build
                                          End Function)
            End If
        Catch ex As Exception



        End Try



    End Sub

    Private Sub DisocrdBOT設定_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Discordsetting.ShowDialog()
    End Sub

    Private Sub 伺服器列表_Click(sender As Object, e As EventArgs) Handles serverlistButton.Click
        ServerlistForm.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.Timer = ComboBox1.SelectedIndex
        MainTimer.Interval = Time(ComboBox1.SelectedIndex)
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Async Sub DGSS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Await Discord.LogoutAsync
            Await Discord.StopAsync
        Catch ex As Exception
        End Try
    End Sub


End Class
