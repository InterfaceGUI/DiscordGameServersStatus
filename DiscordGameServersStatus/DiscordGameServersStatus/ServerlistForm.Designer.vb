<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerlistForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CEnable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GameType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ServerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnIP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(801, 335)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "伺服器列表"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CEnable, Me.GameType, Me.ServerName, Me.ServerIP, Me.ColumnIP})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(9, 26)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(783, 300)
        Me.DataGridView1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(1082, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(45, 41)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Location = New System.Drawing.Point(1104, 247)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(14, 17)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(867, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 40)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "確定"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(825, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "▼"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button_Add
        '
        Me.button_Add.Location = New System.Drawing.Point(825, 166)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(30, 30)
        Me.button_Add.TabIndex = 1
        Me.button_Add.Text = "▲"
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Location = New System.Drawing.Point(849, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 1090)
        Me.Panel3.TabIndex = 2
        Me.Panel3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "全部隱藏"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(825, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "顯示/隱藏 IP"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(17, 66)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 28)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "全部顯示"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CEnable
        '
        Me.CEnable.HeaderText = "啟用"
        Me.CEnable.Name = "CEnable"
        Me.CEnable.Width = 37
        '
        'GameType
        '
        Me.GameType.HeaderText = "遊戲類型"
        Me.GameType.Name = "GameType"
        Me.GameType.Width = 150
        '
        'ServerName
        '
        Me.ServerName.HeaderText = "伺服器名稱"
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServerName.Width = 200
        '
        'ServerIP
        '
        Me.ServerIP.HeaderText = "伺服器IP"
        Me.ServerIP.Name = "ServerIP"
        Me.ServerIP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServerIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ServerIP.Width = 250
        '
        'ColumnIP
        '
        Me.ColumnIP.HeaderText = "隱藏IP?"
        Me.ColumnIP.Name = "ColumnIP"
        Me.ColumnIP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ServerlistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 356)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.button_Add)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ServerlistForm"
        Me.Text = "ServerlistForm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents button_Add As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents CEnable As DataGridViewCheckBoxColumn
    Friend WithEvents GameType As DataGridViewComboBoxColumn
    Friend WithEvents ServerName As DataGridViewTextBoxColumn
    Friend WithEvents ServerIP As DataGridViewTextBoxColumn
    Friend WithEvents ColumnIP As DataGridViewCheckBoxColumn
End Class
