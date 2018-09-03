
Imports System.Collections.Specialized

Public Class ServerlistForm
    Dim labelServername(10) As Label
    Dim labelServerip(10) As Label
    Dim labelServerGmae(10) As Label
    Dim textboxServername(10) As TextBox
    Dim textboxServerip(10) As TextBox
    Dim comboboxGames(10) As ComboBox
    Dim serverCount As Int16 = 0

    Dim GameList As String() = {"其他", "Minecraft", "Source引擎"}

    Private Sub ServerlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ServersName IsNot Nothing Then
            For i = 0 To My.Settings.ServersName.Count - 1
                生成按鈕(i, My.Settings.ServersName(i), My.Settings.Serversip(i), My.Settings.ServersGame(i))
            Next
            serverCount = My.Settings.ServersName.Count - 1
        ElseIf My.Settings.ServersName IsNot Nothing Or My.Settings.ServersName IsNot "" Then
            生成按鈕(0)
        End If
    End Sub
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click

        serverCount += 1
        生成按鈕(serverCount)

        If serverCount = 9 Then
            button_Add.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button_Add.Visible = True
        If serverCount <> 0 Then
            labelServername(serverCount).Parent = Panel3

            labelServerip(serverCount).Parent = Panel3

            labelServerGmae(serverCount).Parent = Panel3

            textboxServername(serverCount).Parent = Panel3
            textboxServername(serverCount) = Nothing
            textboxServerip(serverCount).Parent = Panel3
            textboxServerip(serverCount) = Nothing
            comboboxGames(serverCount).Parent = Panel3

            serverCount -= 1
            Panel3.Controls.Clear()
        End If
    End Sub

    Private Sub 生成按鈕(ByVal Amount As Int16, Optional Servername As String = "", Optional Serverip As String = "", Optional Games As Int16 = 0)
        labelServername(Amount) = New Label With {
            .Parent = Panel1,
            .AutoSize = False,
            .Height = 33,
            .Width = 113,
            .Top = 0 + 140 * Amount,
            .Left = 0,
            .BorderStyle = BorderStyle.FixedSingle,
            .Text = "伺服器名稱",
            .TextAlign = ContentAlignment.MiddleCenter
        }

        labelServerip(Amount) = New Label With {
            .Parent = Panel1,
            .AutoSize = False,
            .Height = 33,
            .Width = 113,
            .Top = 140 * Amount + 36,
            .Left = 0,
            .BorderStyle = BorderStyle.FixedSingle,
            .Text = "伺服器IP",
            .TextAlign = ContentAlignment.MiddleCenter
        }
        labelServerGmae(Amount) = New Label With {
            .Parent = Panel1,
            .AutoSize = False,
            .Height = 32,
            .Width = 113,
            .Top = 140 * Amount + 72,
            .Left = 0,
            .BorderStyle = BorderStyle.FixedSingle,
            .Text = "遊戲類型",
            .TextAlign = ContentAlignment.MiddleCenter
        }
        textboxServername(Amount) = New TextBox With {
            .Parent = Panel1,
            .Height = 33,
            .Width = 165,
            .Top = 0 + 140 * Amount,
            .Left = 113,
            .BorderStyle = BorderStyle.Fixed3D,
            .Text = Servername
        }
        textboxServerip(Amount) = New TextBox With {
            .Parent = Panel1,
            .Height = 33,
            .Width = 165,
            .Top = 140 * Amount + 36,
            .Left = 113,
            .BorderStyle = BorderStyle.Fixed3D,
            .Text = Serverip
        }

        comboboxGames(Amount) = New ComboBox With {
            .Parent = Panel1,
            .Height = 32,
            .Width = 165,
            .Top = 140 * Amount + 72,
            .Left = 113,
            .DropDownStyle = ComboBoxStyle.DropDownList
        }
        For Each n In GameList
            comboboxGames(Amount).Items.Add(n)
        Next


        comboboxGames(Amount).SelectedIndex = Games


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ServersName As New StringCollection()
        Dim Serversip As New StringCollection()
        Dim ServersGame As New StringCollection()

        For i = 0 To textboxServername.Count - 1

            If textboxServername(i) Is Nothing Then
                Exit For
            ElseIf textboxServername(i).Text Is "" Then
                Exit For
            End If

            ServersName.Add(textboxServername(i).Text)
            Serversip.Add(textboxServerip(i).Text)
            ServersGame.Add(comboboxGames(i).SelectedIndex)
        Next
        My.Settings.ServersGame = ServersGame
        My.Settings.Serversip = Serversip
        My.Settings.ServersName = ServersName
        My.Settings.serverCount = serverCount
        My.Settings.Save()
        Me.Dispose()
    End Sub
End Class