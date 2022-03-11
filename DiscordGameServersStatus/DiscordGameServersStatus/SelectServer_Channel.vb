Imports System.ComponentModel
Imports Discord
Imports Discord.WebSocket
Public Class SelectServer_Channel

    Dim selectGuild As String
    Dim DC As DiscordSocketClient
    Private Async Sub SelectServer_Channel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
        Try
            DC = DGSS.DiscordClient
            Await DC.LoginAsync(TokenType.Bot, My.Settings.token)
            Await DC.StartAsync
            DGSS.Start = True
        Catch ex As Exception

        End Try
    End Sub

    Private Delegate Sub UpdataUICallBack(ByVal index As Int16, ByVal vaule As Object)
    Private Sub UpdataUI(ByVal index As Int16, ByVal vaule As Object)
        If Me.InvokeRequired() Then
            Dim cb As New UpdataUICallBack(AddressOf UpdataUI)
            Me.Invoke(cb, index, vaule)
        Else

            Select Case index
                Case 0

                Case 1
                    ToolStripProgressBar1.Style = ProgressBarStyle.Blocks
                    ToolStripProgressBar1.Value = vaule
                Case 6
                    ToolStripProgressBar1.Style = ProgressBarStyle.Blocks
                    ToolStripProgressBar1.Value = vaule
            End Select
        End If
    End Sub

    Private Delegate Sub ServerListViewCallBack(ByVal item As ListViewItem)
    Public Sub UpdateServerListView(ByVal item As ListViewItem)
        If Me.InvokeRequired() Then
            Dim cb As New ServerListViewCallBack(AddressOf UpdateServerListView)
            Me.Invoke(cb, item)
        Else

            ListView1.Items.Add(item)

        End If
    End Sub

    Private Async Sub SelectServer_Channel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub

    Public Function GetImageFromURL(ByVal url As String) As Drawing.Image

        Dim retVal As Drawing.Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.channel = ListView2.SelectedItems(0).SubItems(2).Text
        My.Settings.dcServerID = ListView2.SelectedItems(0).SubItems(3).Text
        My.Settings.Save()
        DGSS.StartButton.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim channels = DGSS.DiscordClient.GetGuild(sender.id)
    End Sub


    Dim selectGuids As New List(Of String)
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        selectGuids.Clear()



        For Each x As ListViewItem In ListView1.Items
            If x.Selected Then
                selectGuids.Add(x.SubItems(1).Text)
            End If
        Next
        If selectGuids.Count <> 0 Then
            ShowChannel()
        Else

        End If
    End Sub

    Private Sub ShowChannel()

        If Not BackgroundWorker_GETServerList.IsBusy Then
            ListView2.Items.Clear()
            BackgroundWorker_GetChannel.RunWorkerAsync()
        End If

    End Sub

    Private Async Sub BackgroundWorker_GetChannel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_GetChannel.DoWork


        For Each selectguid In selectGuids
            Dim guidname = DC.GetGuild(selectguid).Name
            Dim r = DC.GetGuild(selectguid).TextChannels
            Dim numberToCompute As Int16 = r.Count
            Dim k As Int16 = 1

            For Each x As SocketTextChannel In r

                Dim item As New ListViewItem
                item.Text = x.Name
                item.SubItems.Add(guidname)
                item.SubItems.Add(x.Id.ToString)
                item.SubItems.Add(selectguid)

                UpdataUI(6, CInt((k / numberToCompute) * 100))
                k += 1
                UpdateChannelListView(item)
            Next

        Next

        UpdataUI(6, 0)


    End Sub

    Private Delegate Sub ChannelListViewCallBack(ByVal item As ListViewItem)
    Private Sub UpdateChannelListView(ByVal item As ListViewItem)
        If Me.InvokeRequired() Then
            Dim cb As New ServerListViewCallBack(AddressOf UpdateChannelListView)
            Me.Invoke(cb, item)
        Else

            ListView2.Items.Add(item)

        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count <> 0 Then

            Button1.Enabled = True
        End If
    End Sub
End Class