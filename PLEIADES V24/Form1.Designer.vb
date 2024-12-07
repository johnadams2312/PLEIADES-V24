<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BUTTON2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(327, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(327, 187)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONNECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BUTTON2
        '
        Me.BUTTON2.Location = New System.Drawing.Point(80, 108)
        Me.BUTTON2.Name = "BUTTON2"
        Me.BUTTON2.Size = New System.Drawing.Size(110, 23)
        Me.BUTTON2.TabIndex = 1
        Me.BUTTON2.Text = "THE SKY X"
        Me.BUTTON2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TIME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DOME POSITION"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(80, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "CAMERA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(12, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "WEST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(151, 67)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "EAST"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(80, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "DOME CLOSED"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 29000
        '
        'Timer4
        '
        Me.Timer4.Interval = 27000
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(80, 377)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "SET UP"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(80, 290)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "TRACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(80, 246)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(110, 23)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "COVER CLOSED"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Timer5
        '
        Me.Timer5.Interval = 17000
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(327, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 13
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(650, 386)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(110, 23)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "spare"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "SKY DOME"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(327, 227)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SHUT DOWN"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(80, 338)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 23)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "SHUT DOWN"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Timer6
        '
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(660, 440)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 19
        '
        'Timer7
        '
        Me.Timer7.Interval = 750
        '
        'Timer8
        '
        Me.Timer8.Interval = 30000
        '
        'Timer9
        '
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.Location = New System.Drawing.Point(282, 269)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(110, 23)
        Me.Button12.TabIndex = 20
        Me.Button12.Text = "HOME SCOPE"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 462)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BUTTON2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "PLEIADES DOME CONTROL V24"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BUTTON2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Timer5 As Timer
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Timer6 As Timer
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Button12 As Button
End Class
