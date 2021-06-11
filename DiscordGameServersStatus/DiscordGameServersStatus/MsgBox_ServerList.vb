Imports System.ComponentModel

Public Class MsgBox_ServerList
    Private Sub MsgBox_ServerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "更新資訊:" & vbCrLf & "+ 修復些許BUG" & vbCrLf & vbCrLf & "Note: 在 'DisocrdBOT設定' 裡面新增加 'Inline Mode'(並排顯示)" & vbCrLf & "以及 'Show Error Message'(顯示詳細錯誤訊息) " & "和改變訊息顏色。"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class