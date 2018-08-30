Public Class ServerlistForm
    Dim lableServername(10) As Label
    Dim lableServerip(10) As Label
    Dim lableServerGmae(10) As Label
    Dim button_remove(10) As Button
    Dim textboxServername(10) As TextBox
    Dim textboxServerip(10) As TextBox
    Dim comboboxGames(10) As ComboBox
    Dim button_Add As New Button
    Dim serverCount As Int16 = 0
    Private Sub ServerlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With button_Add
            .Text = "增加伺服器"
            .Top = 140
            .Width = 280
            .Height = 30
            .Left = 0
            .Parent = Panel1
        End With
        AddHandler button_Add.Click, AddressOf Button


        生成按鈕(0)


    End Sub
    Private Sub Button()
        serverCount += 1
        button_Add.Top += 140
        生成按鈕(serverCount)
        If serverCount = 9 Then
            button_Add.Visible = False
        End If
    End Sub

    Private Sub 生成按鈕(ByVal Amount As Int16, Optional Servername As String = "", Optional Serverip As String = "", Optional Games As Int16 = 0)
        lableServername(Amount) = New Label With {
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

        lableServerip(Amount) = New Label With {
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
        lableServerGmae(Amount) = New Label With {
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
        textboxServername(Amount) = New TextBox With {
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
        comboboxGames(Amount).Items.Add("其他")
        comboboxGames(Amount).Items.Add("Minecraft")
        comboboxGames(Amount).SelectedIndex = 0
    End Sub
End Class