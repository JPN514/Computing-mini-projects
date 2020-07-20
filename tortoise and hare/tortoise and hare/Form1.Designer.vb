<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PboHare = New System.Windows.Forms.PictureBox()
        Me.PboTortoise = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PboHare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PboTortoise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboHare
        '
        Me.PboHare.Image = CType(resources.GetObject("PboHare.Image"), System.Drawing.Image)
        Me.PboHare.Location = New System.Drawing.Point(440, 288)
        Me.PboHare.Name = "PboHare"
        Me.PboHare.Size = New System.Drawing.Size(105, 94)
        Me.PboHare.TabIndex = 1
        Me.PboHare.TabStop = False
        '
        'PboTortoise
        '
        Me.PboTortoise.Image = CType(resources.GetObject("PboTortoise.Image"), System.Drawing.Image)
        Me.PboTortoise.Location = New System.Drawing.Point(440, 98)
        Me.PboTortoise.Name = "PboTortoise"
        Me.PboTortoise.Size = New System.Drawing.Size(73, 133)
        Me.PboTortoise.TabIndex = 2
        Me.PboTortoise.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(26, 417)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 35)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(437, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Starting Post"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(582, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PboTortoise)
        Me.Controls.Add(Me.PboHare)
        Me.Name = "Form1"
        Me.Text = "Hare and Tostoise race"
        CType(Me.PboHare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PboTortoise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PboHare As System.Windows.Forms.PictureBox
    Friend WithEvents PboTortoise As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
