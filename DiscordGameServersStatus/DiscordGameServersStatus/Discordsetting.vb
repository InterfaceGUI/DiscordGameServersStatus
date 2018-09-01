Public Class Discordsetting
    Private Sub Discordsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextboxChannel.Text = My.Settings.channel
        TextBoxToken.Text = My.Settings.token
    End Sub

    Private Sub Button1_取消(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_確定(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.token = TextBoxToken.Text
        My.Settings.channel = TextboxChannel.Text
        My.Settings.Save()
        Me.Dispose()
    End Sub
End Class