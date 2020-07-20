<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnDisplayCars = New System.Windows.Forms.Button()
        Me.btnDisplayImages = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Shop"
        '
        'btnAddCar
        '
        Me.btnAddCar.Location = New System.Drawing.Point(151, 107)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(138, 43)
        Me.btnAddCar.TabIndex = 1
        Me.btnAddCar.Text = "Add Car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'btnDisplayCars
        '
        Me.btnDisplayCars.Location = New System.Drawing.Point(151, 156)
        Me.btnDisplayCars.Name = "btnDisplayCars"
        Me.btnDisplayCars.Size = New System.Drawing.Size(138, 43)
        Me.btnDisplayCars.TabIndex = 2
        Me.btnDisplayCars.Text = "Display Car List"
        Me.btnDisplayCars.UseVisualStyleBackColor = True
        '
        'btnDisplayImages
        '
        Me.btnDisplayImages.Location = New System.Drawing.Point(151, 205)
        Me.btnDisplayImages.Name = "btnDisplayImages"
        Me.btnDisplayImages.Size = New System.Drawing.Size(138, 43)
        Me.btnDisplayImages.TabIndex = 3
        Me.btnDisplayImages.Text = "Display Car Images"
        Me.btnDisplayImages.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 398)
        Me.Controls.Add(Me.btnDisplayImages)
        Me.Controls.Add(Me.btnDisplayCars)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "menu"
        Me.Text = "menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddCar As System.Windows.Forms.Button
    Friend WithEvents btnDisplayCars As System.Windows.Forms.Button
    Friend WithEvents btnDisplayImages As System.Windows.Forms.Button
End Class
