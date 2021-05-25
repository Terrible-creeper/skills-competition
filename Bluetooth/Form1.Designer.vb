<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RGB0 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.LED0 = New System.Windows.Forms.Button()
        Me.LED1 = New System.Windows.Forms.Button()
        Me.LED2 = New System.Windows.Forms.Button()
        Me.LED3 = New System.Windows.Forms.Button()
        Me.LED7 = New System.Windows.Forms.Button()
        Me.LED6 = New System.Windows.Forms.Button()
        Me.LED5 = New System.Windows.Forms.Button()
        Me.LED4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.S2 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.S4 = New System.Windows.Forms.Button()
        Me.S3 = New System.Windows.Forms.Button()
        Me.SW_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Linkstatus = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 65)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(5, 35)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 38400
        Me.SerialPort1.PortName = "COM3"
        Me.SerialPort1.ReadTimeout = 500
        Me.SerialPort1.ReceivedBytesThreshold = 10
        Me.SerialPort1.WriteTimeout = 500
        '
        'Timer1
        '
        '
        'RGB0
        '
        Me.RGB0.BackColor = System.Drawing.Color.Transparent
        Me.RGB0.Font = New System.Drawing.Font("微軟正黑體", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RGB0.ForeColor = System.Drawing.Color.Black
        Me.RGB0.Location = New System.Drawing.Point(14, 31)
        Me.RGB0.Margin = New System.Windows.Forms.Padding(2)
        Me.RGB0.Name = "RGB0"
        Me.RGB0.Size = New System.Drawing.Size(50, 35)
        Me.RGB0.TabIndex = 10
        Me.RGB0.Text = "Color"
        Me.RGB0.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.Location = New System.Drawing.Point(14, 31)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 33)
        Me.TextBox2.TabIndex = 32
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button16.Location = New System.Drawing.Point(159, 31)
        Me.Button16.Margin = New System.Windows.Forms.Padding(2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(70, 30)
        Me.Button16.TabIndex = 34
        Me.Button16.Text = "Write"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button17.Location = New System.Drawing.Point(233, 31)
        Me.Button17.Margin = New System.Windows.Forms.Padding(2)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(68, 30)
        Me.Button17.TabIndex = 35
        Me.Button17.Text = "Show"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'LED0
        '
        Me.LED0.BackColor = System.Drawing.Color.Transparent
        Me.LED0.BackgroundImage = Global.Bluetooth.My.Resources.Resources.off1
        Me.LED0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED0.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED0.Location = New System.Drawing.Point(320, 44)
        Me.LED0.Name = "LED0"
        Me.LED0.Size = New System.Drawing.Size(38, 38)
        Me.LED0.TabIndex = 37
        Me.LED0.UseVisualStyleBackColor = False
        '
        'LED1
        '
        Me.LED1.BackColor = System.Drawing.Color.Transparent
        Me.LED1.BackgroundImage = CType(resources.GetObject("LED1.BackgroundImage"), System.Drawing.Image)
        Me.LED1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED1.Location = New System.Drawing.Point(274, 44)
        Me.LED1.Name = "LED1"
        Me.LED1.Size = New System.Drawing.Size(38, 38)
        Me.LED1.TabIndex = 38
        Me.LED1.UseVisualStyleBackColor = False
        '
        'LED2
        '
        Me.LED2.BackColor = System.Drawing.Color.Transparent
        Me.LED2.BackgroundImage = CType(resources.GetObject("LED2.BackgroundImage"), System.Drawing.Image)
        Me.LED2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED2.Location = New System.Drawing.Point(230, 44)
        Me.LED2.Name = "LED2"
        Me.LED2.Size = New System.Drawing.Size(38, 38)
        Me.LED2.TabIndex = 39
        Me.LED2.UseVisualStyleBackColor = False
        '
        'LED3
        '
        Me.LED3.BackColor = System.Drawing.Color.Transparent
        Me.LED3.BackgroundImage = CType(resources.GetObject("LED3.BackgroundImage"), System.Drawing.Image)
        Me.LED3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED3.Location = New System.Drawing.Point(186, 44)
        Me.LED3.Name = "LED3"
        Me.LED3.Size = New System.Drawing.Size(38, 38)
        Me.LED3.TabIndex = 40
        Me.LED3.UseVisualStyleBackColor = False
        '
        'LED7
        '
        Me.LED7.BackColor = System.Drawing.Color.Transparent
        Me.LED7.BackgroundImage = CType(resources.GetObject("LED7.BackgroundImage"), System.Drawing.Image)
        Me.LED7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED7.Location = New System.Drawing.Point(12, 44)
        Me.LED7.Name = "LED7"
        Me.LED7.Size = New System.Drawing.Size(38, 38)
        Me.LED7.TabIndex = 41
        Me.LED7.UseVisualStyleBackColor = False
        '
        'LED6
        '
        Me.LED6.BackColor = System.Drawing.Color.Transparent
        Me.LED6.BackgroundImage = CType(resources.GetObject("LED6.BackgroundImage"), System.Drawing.Image)
        Me.LED6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED6.Location = New System.Drawing.Point(56, 44)
        Me.LED6.Name = "LED6"
        Me.LED6.Size = New System.Drawing.Size(38, 38)
        Me.LED6.TabIndex = 42
        Me.LED6.UseVisualStyleBackColor = False
        '
        'LED5
        '
        Me.LED5.BackColor = System.Drawing.Color.Transparent
        Me.LED5.BackgroundImage = CType(resources.GetObject("LED5.BackgroundImage"), System.Drawing.Image)
        Me.LED5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED5.Location = New System.Drawing.Point(100, 44)
        Me.LED5.Name = "LED5"
        Me.LED5.Size = New System.Drawing.Size(38, 38)
        Me.LED5.TabIndex = 43
        Me.LED5.UseVisualStyleBackColor = False
        '
        'LED4
        '
        Me.LED4.BackColor = System.Drawing.Color.Transparent
        Me.LED4.BackgroundImage = CType(resources.GetObject("LED4.BackgroundImage"), System.Drawing.Image)
        Me.LED4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LED4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LED4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LED4.Location = New System.Drawing.Point(144, 47)
        Me.LED4.Name = "LED4"
        Me.LED4.Size = New System.Drawing.Size(36, 35)
        Me.LED4.TabIndex = 44
        Me.LED4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.LED0)
        Me.GroupBox1.Controls.Add(Me.LED1)
        Me.GroupBox1.Controls.Add(Me.LED2)
        Me.GroupBox1.Controls.Add(Me.LED7)
        Me.GroupBox1.Controls.Add(Me.LED6)
        Me.GroupBox1.Controls.Add(Me.LED5)
        Me.GroupBox1.Controls.Add(Me.LED4)
        Me.GroupBox1.Controls.Add(Me.LED3)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 125)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LED"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(294, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 31)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "VR%"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(318, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "LED7"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(272, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "LED6"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(227, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "LED5"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(182, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 17)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "LED4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(140, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "LED3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "LED2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "LED1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 31)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Odd"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "LED0"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(154, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 31)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(84, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 31)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Even"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RGB0)
        Me.GroupBox2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 82)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WS2812"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button17)
        Me.GroupBox3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 82)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "7SEG DATA"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(623, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "COM Port"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Time)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 335)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(346, 187)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Infomation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "VR電壓:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "電腦名稱:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 24)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "C槽剩餘:      GB，共:      GB "
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.BackColor = System.Drawing.Color.Transparent
        Me.Time.Location = New System.Drawing.Point(6, 60)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(217, 24)
        Me.Time.TabIndex = 54
        Me.Time.Text = "NowTime:    HH:mm:ss"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(79, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Device Offline"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(79, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Status"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'S1
        '
        Me.S1.Location = New System.Drawing.Point(6, 39)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(44, 31)
        Me.S1.TabIndex = 53
        Me.S1.Text = "S1"
        Me.S1.UseVisualStyleBackColor = True
        '
        'S2
        '
        Me.S2.Location = New System.Drawing.Point(56, 39)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(41, 31)
        Me.S2.TabIndex = 54
        Me.S2.Text = "S2"
        Me.S2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.S4)
        Me.GroupBox6.Controls.Add(Me.S3)
        Me.GroupBox6.Controls.Add(Me.S1)
        Me.GroupBox6.Controls.Add(Me.S2)
        Me.GroupBox6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(401, 326)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ButtonStatus"
        '
        'S4
        '
        Me.S4.Location = New System.Drawing.Point(150, 39)
        Me.S4.Name = "S4"
        Me.S4.Size = New System.Drawing.Size(41, 31)
        Me.S4.TabIndex = 56
        Me.S4.Text = "S4"
        Me.S4.UseVisualStyleBackColor = True
        '
        'S3
        '
        Me.S3.Location = New System.Drawing.Point(103, 39)
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(41, 31)
        Me.S3.TabIndex = 55
        Me.S3.Text = "S3"
        Me.S3.UseVisualStyleBackColor = True
        '
        'SW_Timer
        '
        Me.SW_Timer.Enabled = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(623, 144)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(146, 252)
        Me.RichTextBox1.TabIndex = 56
        Me.RichTextBox1.Text = ""
        '
        'Linkstatus
        '
        Me.Linkstatus.Enabled = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(528, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 31)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "VR%"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(835, 534)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "109學年度工業類科學生技藝競賽電腦修護職種第二站崗位號碼：00"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RGB0 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents LED0 As System.Windows.Forms.Button
    Friend WithEvents LED1 As System.Windows.Forms.Button
    Friend WithEvents LED2 As System.Windows.Forms.Button
    Friend WithEvents LED3 As System.Windows.Forms.Button
    Friend WithEvents LED7 As System.Windows.Forms.Button
    Friend WithEvents LED6 As System.Windows.Forms.Button
    Friend WithEvents LED5 As System.Windows.Forms.Button
    Friend WithEvents LED4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents S2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents S4 As System.Windows.Forms.Button
    Friend WithEvents S3 As System.Windows.Forms.Button
    Friend WithEvents SW_Timer As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Linkstatus As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
