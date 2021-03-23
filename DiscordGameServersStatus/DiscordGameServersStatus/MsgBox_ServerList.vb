Imports System.ComponentModel

Public Class MsgBox_ServerList
    Private Sub MsgBox_ServerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "更新資訊:" & vbCrLf & "+ 修復些許BUG" & vbCrLf & "+ 更新DisocrdBOT套件" & vbCrLf & vbCrLf & "Note: 在'DisocrdBOT設定'裡面多增加'Discord伺服器ID' 欄位" & vbCrLf & "記得填入指定要廣播的伺服器ID!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class