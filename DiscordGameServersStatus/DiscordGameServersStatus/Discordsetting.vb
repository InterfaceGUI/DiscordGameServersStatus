Imports Discord
Imports Discord.WebSocket

Public Class Discordsetting
    Private Sub Discordsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextboxChannel.Text = My.Settings.channel
        TextBoxToken.Text = My.Settings.token
        TextBox1.Text = My.Settings.dcServerID
        CheckBox2.Checked = My.Settings.ShowErrorMsg
        CheckBox1.Checked = My.Settings.IsInlineMode
        ColorDialog1.Color = My.Settings.Color
        Label4.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_取消(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_確定(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxToken.Text = "" Then MsgBox("Token不可留空!")
        If TextboxChannel.Text = "0" Then MsgBox("ChanneID不可留空!")
        If TextBox1.Text = "0" Then MsgBox("ServerID不可留空!")
        My.Settings.token = TextBoxToken.Text
        My.Settings.channel = TextboxChannel.Text
        My.Settings.dcServerID = TextBox1.Text
        My.Settings.ShowErrorMsg = CheckBox2.Checked
        My.Settings.IsInlineMode = CheckBox1.Checked
        My.Settings.Save()
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ColorDialog1.ShowDialog()
        My.Settings.Color = ColorDialog1.Color
        Label4.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxToken.Text = "" Then MsgBox("Token不可留空!")
        My.Settings.token = TextBoxToken.Text
        My.Settings.Save()
        SelectServer_Channel.ShowDialog()
        TextboxChannel.Text = My.Settings.channel
        TextBox1.Text = My.Settings.dcServerID

    End Sub

    Private Sub TextBoxToken_TextChanged(sender As Object, e As EventArgs) Handles TextBoxToken.TextChanged
        If TextBoxToken.Text.Length > 10 Then
            Button3.Enabled = True
        End If
    End Sub


End Class