Imports System.ComponentModel

Public Class MsgBox_ServerList
    Private Sub MsgBox_ServerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "已更新了伺服器列表，請至伺服器列表確認。" & vbCrLf & "注意!'啟用'選項勾選才會開啟該伺服器查詢(廣播)"
    End Sub

    Private Sub MsgBox_ServerList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.WMessage_ServerList = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class