Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Dim OBJ
    Dim STAR
    Dim TELE
    Dim DOME
    Dim CAM
    Dim MAutoguider
    Dim B1
    Dim B2
    Dim B3
    Dim B4
    Dim B5
    Dim B6
    Dim B9
    Dim B10
    Dim s
    Dim dp
    Dim currentdp

    Dim SKYD ' DOME POSITION

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If B1 = 0 Then
            Try
                Button1.Text = "CONNECTED"
                Button1.BackColor = Color.GreenYellow
                SerialPort1.PortName = "com8"
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Open()
                SerialPort1.Write("8")

                B1 = 1
                Button4.Enabled = True
                Button5.Enabled = True
                Button6.Enabled = True
                Button9.Enabled = True
                Button8.Enabled = True

            Catch ex As Exception
                Button1.Text = "COMMS ERROR"
                B1 = 0
                Button1.BackColor = Color.Transparent
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button9.Enabled = False
                Button8.Enabled = False
                SerialPort1.Close()

            End Try
        Else
            B1 = 0
            Button1.Text = "CONNECT"
            Button1.BackColor = Color.Transparent
            SerialPort1.Close()
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button9.Enabled = False
            Button8.Enabled = False
            SerialPort1.Close()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BUTTON2.Click
        If B2 = 0 Then


            Try
                OBJ = CreateObject("THESKY64.SKY6OBJECTINFORMATION")
                STAR = CreateObject("THESKY64.SKY6STARCHART")
                TELE = CreateObject("TheSky64.SKY6RASCOMTele")
                DOME = CreateObject("Thesky64.sky6Dome")
                MAutoguider = CreateObject("THESKY64.CCDSOFTCAMERA")
                CAM = CreateObject("THESKY64.CCDSOFTCAMERA")
                ' Call TELE.CONNECT()
                Call DOME.connect()
                B2 = 1
                BUTTON2.Text = "CONNECTED"
                BUTTON2.BackColor = Color.GreenYellow
                Timer2.Enabled = True
                Button3.Enabled = True


            Catch ex As Exception
                MsgBox("THE SKY X ERROR")
                B2 = 0
                BUTTON2.Text = "CONNECT"
                Timer2.Enabled = False
                Button3.Enabled = False
            End Try
        Else
            B2 = 0
            BUTTON2.Text = "THE SKY X"
            BUTTON2.BackColor = Color.Transparent
            Timer2.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Try
            Call DOME.GETAZEL()
            SKYD = Math.Round(DOME.DAZ, 0)
            TextBox3.Text = dp

        Catch ex As Exception
            MsgBox("DOME COMMS ERROR")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If B3 = 0 Then
            Try
                Button3.Text = ("CAMERA ON")
                CAM.CONNECT()
                MAutoguider.AUTOGUIDER = 1
                B3 = 1
                Button3.BackColor = Color.GreenYellow
            Catch ex As Exception
                MsgBox("CAMERA ERROR")
                B3 = 0
                Button3.Text = "CAMERA OFF"
                Button1.BackColor = Color.Transparent
            End Try
        Else
            B3 = 0
            Button3.Text = "CAMERA OFF"
            CAM.DISCONNECT()
            MAutoguider.AUTOGUIDER = 0
            Button3.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.MouseDown
        If B4 = 0 Then
            Button4.Text = "MOVING"
            SerialPort1.Write("4")
            Button5.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            ' Button10.Enabled = False
            B4 = 1
            Button4.BackColor = Color.GreenYellow
        Else
            Button4.Text = "WEST"
            B4 = 0
            Button5.Enabled = True
            Button6.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            'Button10.Enabled = True
            SerialPort1.Write("8")
            Button4.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If B5 = 0 Then
            Button5.Text = "MOVING"
            SerialPort1.Write("3")
            Button4.Enabled = False
            Button6.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            ' Button10.Enabled = False
            B5 = 1
            Button5.BackColor = Color.GreenYellow
        Else
            Button5.Text = "EAST"
            B5 = 0
            Button4.Enabled = True
            Button6.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            'Button10.Enabled = True
            SerialPort1.Write("8")
            Button5.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If B6 = 0 Then
            Button6.Text = "DOME OPENING"
            Timer3.Enabled = True
            SerialPort1.Write("2")
            Button6.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            B6 = 1
        Else
            Button6.Text = "DOME CLOSING"
            Timer4.Enabled = True
            SerialPort1.Write("5")
            Button6.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            B6 = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'DOME OPENING 
        Button6.Text = "DOME OPEN"
        Button6.BackColor = Color.GreenYellow
        Timer3.Enabled = False
        Button6.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        SerialPort1.Write("8")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'DOME CLOSING
        Button6.Text = "DOME CLOSED"
        Button6.BackColor = Color.Transparent
        Timer4.Enabled = False
        SerialPort1.Write("8")
        Button6.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If B9 = 0 Then
            Button9.Text = "DUST OPEN"
            SerialPort1.Write("8")
            Timer5.Enabled = True
            Button9.Enabled = False
            Timer3.Enabled = False
            Button6.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button8.Enabled = False
            B9 = 1
            Button9.BackColor = Color.GreenYellow
        Else
            Button9.Text = "DUST CLOSED"
            SerialPort1.Write("9")
            Button9.Enabled = False
            Button6.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button8.Enabled = False
            Timer5.Enabled = True
            Button9.BackColor = Color.Transparent
            B9 = 0

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        SerialPort1.Write("8")
        Timer5.Enabled = False
        Button9.Enabled = True
        Button6.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        dp = dp + 1
    End Sub
End Class
