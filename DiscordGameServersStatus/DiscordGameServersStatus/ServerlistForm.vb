
Imports System.Collections.Specialized
Imports System.ComponentModel

Public Class ServerlistForm
    Dim labelServername(10) As Label
    Dim labelServerip(10) As Label
    Dim labelServerGmae(10) As Label
    Dim textboxServername(10) As TextBox
    Dim textboxServerip(10) As TextBox
    Dim comboboxGames(10) As ComboBox
    Dim serverCount As Int16 = 0
    Dim CVCcombox As DataGridViewComboBoxColumn
    Dim GameList As String() = {"其他", "Minecraft", "Source引擎"}

    Private Sub ServerlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowHeadersWidth = 50
        If My.Settings.ServersName IsNot Nothing Then

            For i = 0 To My.Settings.ServersName.Count - 1

                生成按鈕(i, My.Settings.ServersName(i), My.Settings.Serversip(i), My.Settings.ServersGame(i), My.Settings.ServerEN(i))

            Next

            serverCount = My.Settings.ServersName.Count - 1

        ElseIf My.Settings.ServersName IsNot Nothing Or My.Settings.ServersName IsNot "" Then

            ' 生成按鈕(0)

        End If

        Dim cboCol1 As DataGridViewComboBoxColumn

        cboCol1 = DataGridView1.Columns.Item(1)

        For Each x In GameList

            cboCol1.Items.Add(x)

        Next
        If DataGridView1.Rows.Count > 10 Then
            DataGridView1.AllowUserToAddRows = False
        Else
            DataGridView1.AllowUserToAddRows = True
        End If

    End Sub
    Private Sub DgvGrn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.DefaultValuesNeeded
        e.Row.Cells(1).Value = GameList(0)
        e.Row.Cells(2).Value = "A Server"
    End Sub
    Private Sub DataGridView1_UserDeletedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        If DataGridView1.Rows.Count > 10 Then
            DataGridView1.AllowUserToAddRows = False
        Else
            DataGridView1.AllowUserToAddRows = True
        End If
    End Sub
    Private Sub DataGridView1_UserAddedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        If DataGridView1.Rows.Count > 10 Then
            DataGridView1.AllowUserToAddRows = False
        Else
            DataGridView1.AllowUserToAddRows = True
        End If

        If DataGridView1.Rows.Count > 11 Then

            If DataGridView1.Rows(DataGridView1.CurrentRow.Index).IsNewRow <> True Then

                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        If DataGridView1.SelectedCells(0).RowIndex = 0 Then
            Exit Sub
        End If
        Dim TEN
        Dim TGL
        Dim TSN
        Dim TSIP
        Dim Selects As Integer
        TEN = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(0).Value
        TGL = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(1).Value
        TSN = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(2).Value
        TSIP = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(3).Value
        Selects = DataGridView1.SelectedCells(0).RowIndex
        DataGridView1.Rows(Selects).Cells(0).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex - 1).Cells(0).Value
        DataGridView1.Rows(Selects).Cells(1).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex - 1).Cells(1).Value
        DataGridView1.Rows(Selects).Cells(2).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex - 1).Cells(2).Value
        DataGridView1.Rows(Selects).Cells(3).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex - 1).Cells(3).Value


        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedCells(0).RowIndex - 1)
        DataGridView1.Rows.Insert(Selects - 1, New Object() {TEN, TGL, TSN, TSIP})
        DataGridView1.Rows(Selects).Selected = False
        DataGridView1.Rows(Selects - 1).Selected = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedCells(0).RowIndex = 9 Then
            Exit Sub
        End If
        Dim TEN
        Dim TGL
        Dim TSN
        Dim TSIP
        Dim Selects As Integer
        TEN = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(0).Value
        TGL = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(1).Value
        TSN = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(2).Value
        TSIP = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells(3).Value
        Selects = DataGridView1.SelectedCells(0).RowIndex
        DataGridView1.Rows(Selects).Cells(0).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex + 1).Cells(0).Value
        DataGridView1.Rows(Selects).Cells(1).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex + 1).Cells(1).Value
        DataGridView1.Rows(Selects).Cells(2).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex + 1).Cells(2).Value
        DataGridView1.Rows(Selects).Cells(3).Value = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex + 1).Cells(3).Value


        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedCells(0).RowIndex + 1)
        DataGridView1.Rows.Insert(Selects + 1, New Object() {TEN, TGL, TSN, TSIP})
        DataGridView1.Rows(Selects).Selected = False
        DataGridView1.Rows(Selects + 1).Selected = True

    End Sub

    Private Sub 生成按鈕(ByVal Amount As Int16, Optional Servername As String = "", Optional Serverip As String = "", Optional Games As Int16 = 0, Optional EN As String = "")

        DataGridView1.Rows.Add(New Object() {IIf(EN = 1, True, False), Nothing, Servername, Serverip})
        Dim dgvcc As New DataGridViewComboBoxCell
        For Each x In GameList
            dgvcc.Items.Add(x)
        Next
        Try
            dgvcc.Value = dgvcc.Items(Games)

        Catch ex As Exception

        End Try
        DataGridView1.Item(1, Amount) = dgvcc

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ServersName As New StringCollection()
        Dim Serversip As New StringCollection()
        Dim ServersGame As New StringCollection()
        Dim ServerEN As New StringCollection()

        For i = 0 To DataGridView1.Rows.Count - 1
            Try
                If DataGridView1.Rows(i).Cells(2).Value Is Nothing Then
                    Continue For
                ElseIf DataGridView1.Rows(i).Cells(2).Value Is "" Then
                    Continue For
                End If
                If DataGridView1.Rows(i).Cells(3).Value Is Nothing Then
                    Continue For
                ElseIf DataGridView1.Rows(i).Cells(3).Value Is "" Then
                    Continue For
                End If
            Catch ex As Exception

            End Try


            ServersName.Add(DataGridView1.Rows(i).Cells(2).Value)
            Serversip.Add(DataGridView1.Rows(i).Cells(3).Value)

            ServersGame.Add(Array.IndexOf(GameList, DataGridView1.Rows(i).Cells(1).Value))
            ServerEN.Add(IIf(DataGridView1.Rows(i).Cells(0).Value, 1, 0))
        Next
        My.Settings.ServerEN = ServerEN
        My.Settings.ServersGame = ServersGame
        My.Settings.Serversip = Serversip
        My.Settings.ServersName = ServersName
        My.Settings.serverCount = serverCount
        My.Settings.Save()
        Me.Dispose()
    End Sub

    Private Sub ServerlistForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        While DataGridView1.Rows.Count <> 1
            Try
                DataGridView1.Rows.RemoveAt(0)
            Catch ex As Exception
                If DataGridView1.Rows.Count = 0 Then
                    Exit While
                End If
            End Try

        End While
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Try
            Dim rectangle As New Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DataGridView1.RowHeadersWidth - 4, e.RowBounds.Height)
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DataGridView1.RowHeadersDefaultCellStyle.Font,
               rectangle, DataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.Right)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class