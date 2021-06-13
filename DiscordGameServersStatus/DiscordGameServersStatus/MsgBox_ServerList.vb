Imports System.ComponentModel

Public Class MsgBox_ServerList
    Private Sub MsgBox_ServerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "更新資訊:" & vbCrLf & "+ 新增最小化執行"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class