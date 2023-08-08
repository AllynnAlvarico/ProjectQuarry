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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pickaxe_animation = New System.Windows.Forms.ImageList(Me.components)
        Me.pickaxe_img = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gamelog = New System.Windows.Forms.Label()
        Me.addLogs = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.openIntventory = New System.Windows.Forms.Button()
        CType(Me.pickaxe_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 1000
        '
        'pickaxe_animation
        '
        Me.pickaxe_animation.ImageStream = CType(resources.GetObject("pickaxe_animation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.pickaxe_animation.TransparentColor = System.Drawing.Color.Transparent
        Me.pickaxe_animation.Images.SetKeyName(0, "pixil-frame1.png")
        Me.pickaxe_animation.Images.SetKeyName(1, "pixil-frame2.png")
        Me.pickaxe_animation.Images.SetKeyName(2, "pixil-frame3.png")
        Me.pickaxe_animation.Images.SetKeyName(3, "pixil-frame4.png")
        Me.pickaxe_animation.Images.SetKeyName(4, "pixil-frame5.png")
        '
        'pickaxe_img
        '
        Me.pickaxe_img.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.pickaxe_img.BackColor = System.Drawing.Color.White
        Me.pickaxe_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pickaxe_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pickaxe_img.Image = Global.ProjectQuarry.My.Resources.Resources.pixil_frame1
        Me.pickaxe_img.Location = New System.Drawing.Point(12, 510)
        Me.pickaxe_img.Name = "pickaxe_img"
        Me.pickaxe_img.Size = New System.Drawing.Size(32, 32)
        Me.pickaxe_img.TabIndex = 2
        Me.pickaxe_img.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectQuarry.My.Resources.Resources.Upper_UI1904x50
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1904, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "animate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(414, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'gamelog
        '
        Me.gamelog.BackColor = System.Drawing.Color.White
        Me.gamelog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gamelog.Location = New System.Drawing.Point(12, 53)
        Me.gamelog.MaximumSize = New System.Drawing.Size(300, 455)
        Me.gamelog.MinimumSize = New System.Drawing.Size(300, 455)
        Me.gamelog.Name = "gamelog"
        Me.gamelog.Size = New System.Drawing.Size(300, 455)
        Me.gamelog.TabIndex = 5
        '
        'addLogs
        '
        Me.addLogs.Location = New System.Drawing.Point(371, 519)
        Me.addLogs.Name = "addLogs"
        Me.addLogs.Size = New System.Drawing.Size(75, 23)
        Me.addLogs.TabIndex = 6
        Me.addLogs.Text = "Logs"
        Me.addLogs.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(452, 519)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Clear Logs"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'openIntventory
        '
        Me.openIntventory.Location = New System.Drawing.Point(767, 214)
        Me.openIntventory.Name = "openIntventory"
        Me.openIntventory.Size = New System.Drawing.Size(75, 23)
        Me.openIntventory.TabIndex = 8
        Me.openIntventory.Text = "Inventory"
        Me.openIntventory.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.openIntventory)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.addLogs)
        Me.Controls.Add(Me.gamelog)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pickaxe_img)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(1918, 1030)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pickaxe_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gameTimer As Timer
    Friend WithEvents pickaxe_img As PictureBox
    Friend WithEvents pickaxe_animation As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gamelog As Label
    Friend WithEvents addLogs As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents openIntventory As Button
End Class
