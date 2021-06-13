<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DGSS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DGSS))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.serverlistButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.儲存設定檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.載入設定檔ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "DisocrdBOT設定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.StartButton)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.serverlistButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 310)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("微軟正黑體", 13.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10分鐘", "20分鐘", "30分鐘", "60分鐘"})
        Me.ComboBox1.Location = New System.Drawing.Point(95, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 30)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(95, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "停止"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "廣播間隔"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(6, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "狀態:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartButton.Location = New System.Drawing.Point(6, 172)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(178, 93)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "啟動"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(178, 30)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "立即發送訊息"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'serverlistButton
        '
        Me.serverlistButton.Location = New System.Drawing.Point(6, 68)
        Me.serverlistButton.Name = "serverlistButton"
        Me.serverlistButton.Size = New System.Drawing.Size(178, 30)
        Me.serverlistButton.TabIndex = 0
        Me.serverlistButton.Text = "伺服器列表"
        Me.serverlistButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(323, 44)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 51)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(283, 120)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 191)
        Me.TextBox1.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(429, 44)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 51)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Button5"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MainTimer
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(-2, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "未知版本"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.儲存設定檔ToolStripMenuItem, Me.載入設定檔ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        '儲存設定檔ToolStripMenuItem
        '
        Me.儲存設定檔ToolStripMenuItem.Name = "儲存設定檔ToolStripMenuItem"
        Me.儲存設定檔ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.儲存設定檔ToolStripMenuItem.Text = "儲存設定檔"
        '
        '載入設定檔ToolStripMenuItem
        '
        Me.載入設定檔ToolStripMenuItem.Name = "載入設定檔ToolStripMenuItem"
        Me.載入設定檔ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.載入設定檔ToolStripMenuItem.Text = "載入設定檔"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "DiscordGameServersStatus.exe.config"
        Me.SaveFileDialog1.Filter = "DiscordGameServersStatus.exe.config|Config"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "DiscordGameServersStatus.exe.config"
        Me.OpenFileDialog1.Filter = "DiscordGameServersStatus.exe.config|Config"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Discord Game Status"
        '
        'DGSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 341)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "DGSS"
        Me.Text = "DiscordGameServersStatus"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StartButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents serverlistButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents MainTimer As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 儲存設定檔ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents 載入設定檔ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
