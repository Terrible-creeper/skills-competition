Imports System
Imports System.IO.Ports
Imports System.Threading

Public Class Form1

#Region "Dim"
    Dim swtimerstatus, ledselect, vr, SW1, SW2, SW3, SW4, vrstatus, segstatus, seg7, time_index, sw1timer, sw2timer, senttime, LED_value, sw1_last, sw2_last, sw3_last, sw4_last, sw1_now, sw2_now, sw3_now, sw4_now As Integer
    Dim test, comPORT As String
    Dim link_time_now, link_time_last As DateTime
    Dim link_status, LED_status(10), RGB_status(8), LEDnum(8) As Boolean
    Dim seg_data(10), RGB_data(10) As Byte

    Declare Function Beep Lib "kernel32" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer

#End Region

#Region "Sub"
    Private Sub vrstat()
        If vrstatus = 0 Then
            ledselect = LED_value
        ElseIf vrstatus = 1 Then
            Dim vrvalue As Integer = Math.Round(vr / 50 * 8)
            Select Case vrvalue
                Case 0
                    ledselect = 0
                    LED0.BackgroundImage = My.Resources._on
                    LED1.BackgroundImage = My.Resources._on
                    LED2.BackgroundImage = My.Resources._on
                    LED3.BackgroundImage = My.Resources._on
                    LED4.BackgroundImage = My.Resources._on
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 1
                    ledselect = 1
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources._on
                    LED2.BackgroundImage = My.Resources._on
                    LED3.BackgroundImage = My.Resources._on
                    LED4.BackgroundImage = My.Resources._on
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 2
                    ledselect = 3
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources._on
                    LED3.BackgroundImage = My.Resources._on
                    LED4.BackgroundImage = My.Resources._on
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 3
                    ledselect = 7
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources._on
                    LED4.BackgroundImage = My.Resources._on
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 4
                    ledselect = 15
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources.off
                    LED4.BackgroundImage = My.Resources._on
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 5
                    ledselect = 31
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources.off
                    LED4.BackgroundImage = My.Resources.off
                    LED5.BackgroundImage = My.Resources._on
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 6
                    ledselect = 63
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources.off
                    LED4.BackgroundImage = My.Resources.off
                    LED5.BackgroundImage = My.Resources.off
                    LED6.BackgroundImage = My.Resources._on
                    LED7.BackgroundImage = My.Resources._on
                Case 7
                    ledselect = 127
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources.off
                    LED4.BackgroundImage = My.Resources.off
                    LED5.BackgroundImage = My.Resources.off
                    LED6.BackgroundImage = My.Resources.off
                    LED7.BackgroundImage = My.Resources._on
                Case 8
                    ledselect = 255
                    LED0.BackgroundImage = My.Resources.off
                    LED1.BackgroundImage = My.Resources.off
                    LED2.BackgroundImage = My.Resources.off
                    LED3.BackgroundImage = My.Resources.off
                    LED4.BackgroundImage = My.Resources.off
                    LED5.BackgroundImage = My.Resources.off
                    LED6.BackgroundImage = My.Resources.off
                    LED7.BackgroundImage = My.Resources.off
            End Select
        End If
    End Sub
    Private Sub seg()
        If segstatus = 0 Then
            seg7 = senttime
        ElseIf segstatus = 1 Then
            Dim drive As System.IO.DriveInfo = My.Computer.FileSystem.GetDriveInfo("C:\")
            Dim freespace As Integer = drive.TotalFreeSpace / 1024 / 1024 / 1024
            If freespace.ToString.Length = 3 Then
                seg7 = freespace.ToString.Substring(1, 2)
            ElseIf freespace.ToString.Length = 2 Then
                seg7 = freespace.ToString.Substring(0, 2)
            ElseIf freespace.ToString.Length = 1 Then
                seg7 = freespace.ToString.Substring(0, 1)
            End If
        End If
    End Sub
#End Region

#Region "Link"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sw1_now = 1
        sw2_now = 1
        sw3_now = 1
        sw4_now = 1
        segstatus = 0

        link_time_last = DateTime.Now
        link_status = False
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next
        ComboBox1.SelectedItem = My.Settings.last_COM
        comPORT = ComboBox1.SelectedItem
        Dim t As Threading.Tasks.Task = Threading.Tasks.Task.Factory.StartNew(AddressOf SerialTest)
    End Sub

    Private Sub SerialTest()
        SerialPort1.BaudRate = 38400
        Try
            SerialPort1.Open()
            link_status = True
        Catch ex As Exception
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.last_COM = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If link_status = False Then
            Try
                SerialPort1.PortName = My.Settings.last_COM
                SerialPort1.BaudRate = 38400
                SerialPort1.Open()
                link_status = True
            Catch ex As Exception
            End Try
        Else
            SerialPort1.Close()
            link_status = False
        End If
    End Sub

#End Region

#Region "SerialData"

    Private Sub relink()
        Try
            If SerialPort1.IsOpen = True Then
                SerialPort1.Close()
            End If
            SerialPort1.Open()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SW()
        If SW1 = 5 Then
            Dim year As String = DateTime.Now.Year
            senttime = year.Substring(0, 2)
        ElseIf SW1 = 4 Then
            senttime = DateTime.Now.Month
        ElseIf SW1 = 3 Then
            senttime = DateTime.Now.Day
        ElseIf SW1 = 2 Then
            senttime = DateTime.Now.Hour
        ElseIf SW1 = 1 Then
            senttime = DateTime.Now.Minute
        ElseIf SW1 = 0 Then
            senttime = DateTime.Now.Second
        End If

        If sw1_now = 0 Then
            sw1timer = sw1timer + 1
        Else
            sw1timer = 0
        End If
        If sw2_now = 0 Then
            sw2timer = sw2timer + 1
        Else
            sw2timer = 0
        End If

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim buff() As Byte
        Dim j As Integer = 0
        ReDim buff(SerialPort1.BytesToRead - 1)
        SerialPort1.Read(buff, 0, buff.Length)

        If buff.Length >= 9 Then
            If buff(0) = &H3A Then

                link_time_last = DateTime.Now

                vr = Val(buff(1))
                sw1_now = buff(3)
                sw2_now = buff(4)
                sw3_now = buff(5)
                sw4_now = buff(6)

                If sw1_now = 0 Then
                    S1.BackColor = Color.Gold
                Else
                    S1.BackColor = Color.Gray
                End If
                If sw2_now = 0 Then
                    S2.BackColor = Color.Gold
                Else
                    S2.BackColor = Color.Gray
                End If
                If sw3_now = 0 Then
                    S3.BackColor = Color.Gold
                Else
                    S3.BackColor = Color.Gray
                End If
                If sw4_now = 0 Then
                    S4.BackColor = Color.Gold
                Else
                    S4.BackColor = Color.Gray
                End If

            End If

        End If

    End Sub

#End Region

#Region "Timer"

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        link_time_now = DateTime.Now
        Dim a1 As Integer = DateDiff(DateInterval.Second, link_time_last, link_time_now)
        Dim status As Boolean = True

        If a1 < 1 Then
            Label5.Text = "Device Online"
            Label5.BackColor = Color.LawnGreen
        Else
            Label5.Text = "Device Offline"
            Label5.BackColor = Color.Red
            Label8.Text = "VR電壓:    "
        End If

        Dim drive As System.IO.DriveInfo = My.Computer.FileSystem.GetDriveInfo("C:\")
        Dim freespace As Integer = drive.TotalFreeSpace / 1024 / 1024 / 1024
        Dim totalspace As Integer = drive.TotalSize / 1024 / 1024 / 1024

        Dim data(10) As Byte
        Try
            RGB_data(0) = &H3A
            RGB_data(1) = &H1
            RGB_data(2) = segstatus
            RGB_data(3) = ColorDialog1.Color.R.ToString()
            RGB_data(4) = ColorDialog1.Color.G.ToString()
            RGB_data(5) = ColorDialog1.Color.B.ToString()
            RGB_data(6) = Math.Round((freespace / totalspace) * 8)
            RGB_data(7) = &H0
            RGB_data(8) = &H0
            RGB_data(9) = &H0
            SerialPort1.Write(RGB_data, 0, 10)
        Catch ex As Exception
        End Try

        Dim th2 As Threading.Tasks.Task = Threading.Tasks.Task.Factory.StartNew(AddressOf SW)

        If sw1timer > 20 AndAlso sw2timer > 20 AndAlso swtimerstatus = 0 Then
            swtimerstatus = 1
            If segstatus = 0 Then
                segstatus = 1
                Form3.Show()
            ElseIf segstatus = 1 Then
                segstatus = 0
                time_index = 0
            End If
        ElseIf sw1timer < 20 AndAlso sw2timer < 20 AndAlso swtimerstatus = 1 Then
            swtimerstatus = 0
        End If

        vrstat()
        seg()

        Try
            data(0) = &H3A
            data(1) = &H0
            data(2) = IntToBCD(seg7)
            data(3) = ledselect
            data(4) = &H0
            data(5) = &H0
            data(6) = &H0
            data(7) = &H0
            data(8) = &H0
            data(9) = &H0
            SerialPort1.Write(data, 0, 10)
        Catch ex As Exception
            Dim th1 As Threading.Tasks.Task = Threading.Tasks.Task.Factory.StartNew(AddressOf relink)
        End Try

        Label8.Text = "VR電壓:    " & vr / 10 & "V"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Time.Text = "Now Time:   " & DateTime.Now.ToString("HH:mm:ss")
        Dim cdrive As System.IO.DriveInfo = My.Computer.FileSystem.GetDriveInfo("C:\")
        Label6.Text = "C槽剩餘: " & (cdrive.TotalFreeSpace / 1024 / 1024 / 1024).ToString("#.#0") & "  GB" & "，共 " & (cdrive.TotalSize / 1024 / 1024 / 1024).ToString("#.#0") & "  GB"
        Label7.Text = "電腦名稱:    " & My.Computer.Name
    End Sub

    Private Sub Linkstatus_Tick(sender As Object, e As EventArgs) Handles Linkstatus.Tick
        If link_status = True Then
            Button1.Text = "Disconnect"
            Button1.BackColor = Color.LawnGreen
            ComboBox1.Enabled = False
            Timer1.Enabled = True
        Else
            Button1.Text = "Connect"                                '改變文字為Connect
            Button1.BackColor = Color.Red
            Label5.Text = "Device Offline"
            Label5.BackColor = Color.Red
            ComboBox1.Enabled = True
            Timer1.Enabled = False

            Label8.Text = "VR電壓:    "
        End If
    End Sub

    Private Sub SW_Timer_Tick(sender As Object, e As EventArgs) Handles SW_Timer.Tick
        If sw1_now = 0 And sw1_last = 1 Then
            If time_index < 5 Then
                time_index = time_index + 1
                SW1 = time_index
            ElseIf time_index = 5 Then
                time_index = 0
                SW1 = time_index
            End If
        End If
        If sw2_now = 0 And sw2_last = 1 Then

        End If
        If sw3_now = 0 And sw3_last = 1 Then

        End If
        If sw4_now = 0 And sw4_last = 1 Then

        End If

        sw1_last = sw1_now
        sw2_last = sw2_now
    End Sub

#End Region

#Region "LEDClick"
    Private Sub LED0_Click(sender As Object, e As EventArgs) Handles LED0.Click
        vrstatus = 0
        If LED_status(0) = False Then
            LEDs(True, 0)
            LED_status(0) = True
        ElseIf LED_status(0) = True Then
            LEDs(False, 0)
            LED_status(0) = False
        End If
    End Sub

    Private Sub LED1_Click(sender As Object, e As EventArgs) Handles LED1.Click
        vrstatus = 0
        If LED_status(1) = False Then
            LEDs(True, 1)
            LED_status(1) = True
        ElseIf LED_status(1) = True Then
            LEDs(False, 1)
            LED_status(1) = False
        End If
    End Sub

    Private Sub LED2_Click(sender As Object, e As EventArgs) Handles LED2.Click
        vrstatus = 0
        If LED_status(2) = False Then
            LEDs(True, 2)
            LED_status(2) = True
        ElseIf LED_status(2) = True Then
            LEDs(False, 2)
            LED_status(2) = False
        End If
    End Sub

    Private Sub LED3_Click(sender As Object, e As EventArgs) Handles LED3.Click
        vrstatus = 0
        If LED_status(3) = False Then
            LEDs(True, 3)
            LED_status(3) = True
        ElseIf LED_status(3) = True Then
            LEDs(False, 3)
            LED_status(3) = False
        End If
    End Sub

    Private Sub LED4_Click(sender As Object, e As EventArgs) Handles LED4.Click
        vrstatus = 0
        If LED_status(4) = False Then
            LEDs(True, 4)
            LED_status(4) = True
        ElseIf LED_status(4) = True Then
            LEDs(False, 4)
            LED_status(4) = False
        End If
    End Sub

    Private Sub LED5_Click(sender As Object, e As EventArgs) Handles LED5.Click
        vrstatus = 0
        If LED_status(5) = False Then
            LEDs(True, 5)
            LED_status(5) = True
        ElseIf LED_status(5) = True Then
            LEDs(False, 5)
            LED_status(5) = False
        End If
    End Sub

    Private Sub LED6_Click(sender As Object, e As EventArgs) Handles LED6.Click
        vrstatus = 0
        If LED_status(6) = False Then
            LEDs(True, 6)
            LED_status(6) = True
        ElseIf LED_status(6) = True Then
            LEDs(False, 6)
            LED_status(6) = False
        End If
    End Sub

    Private Sub LED7_Click(sender As Object, e As EventArgs) Handles LED7.Click
        vrstatus = 0
        If LED_status(7) = False Then
            LEDs(True, 7)
            LED_status(7) = True
        ElseIf LED_status(7) = True Then
            LEDs(False, 7)
            LED_status(7) = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vrstatus = 0
        LED_value = 85
        LED0.BackgroundImage = My.Resources.off
        LED1.BackgroundImage = My.Resources._on
        LED2.BackgroundImage = My.Resources.off
        LED3.BackgroundImage = My.Resources._on
        LED4.BackgroundImage = My.Resources.off
        LED5.BackgroundImage = My.Resources._on
        LED6.BackgroundImage = My.Resources.off
        LED7.BackgroundImage = My.Resources._on
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        vrstatus = 0
        LED_value = 170
        LED0.BackgroundImage = My.Resources._on
        LED1.BackgroundImage = My.Resources.off
        LED2.BackgroundImage = My.Resources._on
        LED3.BackgroundImage = My.Resources.off
        LED4.BackgroundImage = My.Resources._on
        LED5.BackgroundImage = My.Resources.off
        LED6.BackgroundImage = My.Resources._on
        LED7.BackgroundImage = My.Resources.off
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If vrstatus = 0 Then
            vrstatus = 1
        ElseIf vrstatus = 1 Then
            vrstatus = 0
        End If

    End Sub

#End Region

#Region "ResetLED"

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        vrstatus = 0
        resetLED()
    End Sub

    Sub resetLED()
        LED_value = 0
        LED0.BackgroundImage = My.Resources._on
        LED1.BackgroundImage = My.Resources._on
        LED2.BackgroundImage = My.Resources._on
        LED3.BackgroundImage = My.Resources._on
        LED4.BackgroundImage = My.Resources._on
        LED5.BackgroundImage = My.Resources._on
        LED6.BackgroundImage = My.Resources._on
        LED7.BackgroundImage = My.Resources._on
    End Sub
#End Region

#Region "Other"

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles RGB0.Click
        ColorDialog1.ShowDialog()
        RGB0.BackColor = Color.FromArgb(ColorDialog1.Color.A.ToString(), ColorDialog1.Color.R.ToString(), ColorDialog1.Color.G.ToString(), ColorDialog1.Color.B.ToString())
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'e.KeyChar = (Char)48~57 -------> 0~9
        'e.KeyChar = (Char)8 -----------> Backpace
        'e.KeyChar = (Char)13-----------> Enter
        If e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) Or e.KeyChar = Chr(13) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Len(TextBox2.Text) = 2 Then
            If TextBox2.Text <> "" Then

                seg_data(0) = &H3A
                seg_data(1) = &H3
                seg_data(2) = IntToBCD(Val(TextBox2.Text))
                For i As Integer = 3 To 9
                    seg_data(i) = &H0
                Next
                Timer1.Enabled = False
                Try
                    SerialPort1.Write(seg_data, 0, 10)
                    Timer1.Enabled = True
                Catch
                End Try

            End If
        Else
            TextBox2.Text = ""
        End If
    End Sub
#End Region

#Region "LED"
    Sub LEDs(status As Boolean, LED As UInteger)
        Dim value As Integer = 2 ^ LED
        If status = True Then
            LED_value = LED_value + value
            LEDnum(LED) = True
        ElseIf status = False Then
            LED_value = LED_value - value
            LEDnum(LED) = False
        End If
    End Sub
#End Region

#Region "SWClick"
    Private Sub S1_Click(sender As Object, e As EventArgs) Handles S1.Click
        Form2.Show()
    End Sub

    Private Sub S2_Click(sender As Object, e As EventArgs) Handles S2.Click
        Dim filetest As Boolean = My.Computer.FileSystem.FileExists("C:\C2.txt")
        If filetest = True Then
            MsgBox("檔案已存在")
        Else
            MsgBox("檔案不存在")
        End If
    End Sub

    Private Sub S3_Click(sender As Object, e As EventArgs) Handles S3.Click
        Form3.Show()
    End Sub

    Private Sub beepsound()
        Thread.Sleep(1)
        Beep(550, 500)
        Thread.Sleep(500)
    End Sub

    Private Sub S4_Click(sender As Object, e As EventArgs) Handles S4.Click
        Dim t As Threading.Tasks.Task = Threading.Tasks.Task.Factory.StartNew(AddressOf beepsound)
    End Sub
#End Region

    Function IntToBCD(value As Integer)
        Dim num As String = value

        If num.Length = 1 Then
            num = "0" & num
        End If

        Dim data1 As String = ""

        Dim bcd(9) As String
        bcd(0) = "0000"
        bcd(1) = "0001"
        bcd(2) = "0010"
        bcd(3) = "0011"
        bcd(4) = "0100"
        bcd(5) = "0101"
        bcd(6) = "0110"
        bcd(7) = "0111"
        bcd(8) = "1000"
        bcd(9) = "1001"

        For i As Integer = 1 To num.Length
            data1 = data1 & bcd(num.Substring(i - 1, 1))
        Next

        Dim require As Integer = Convert.ToUInt64(data1, 2)
        RichTextBox1.Text = data1 & vbNewLine & require & vbNewLine & segstatus
        Return require
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class

