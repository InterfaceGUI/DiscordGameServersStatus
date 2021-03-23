Public Class Discordsetting
    Private Sub Discordsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextboxChannel.Text = My.Settings.channel
        TextBoxToken.Text = My.Settings.token
        TextBox1.Text = My.Settings.dcServerID
    End Sub

    Private Sub Button1_取消(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_確定(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxToken.Text = "" Then MsgBox("Token不可留空!")
        If TextboxChannel.Text = 0 Then MsgBox("ChanneID不可留空!")
        If TextBox1.Text = 0 Then MsgBox("ServerID不可留空!")
        My.Settings.token = TextBoxToken.Text
        My.Settings.channel = TextboxChannel.Text
        My.Settings.dcServerID = TextBox1.Text
        My.Settings.Save()
        Me.Dispose()
    End Sub

End Class