<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowCars
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
        Me.lstCars = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCars
        '
        Me.lstCars.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCars.FormattingEnabled = True
        Me.lstCars.ItemHeight = 16
        Me.lstCars.Location = New System.Drawing.Point(12, 14)
        Me.lstCars.Name = "lstCars"
        Me.lstCars.Size = New System.Drawing.Size(659, 244)
        Me.lstCars.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(383, 343)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 47)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Car"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(465, 343)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 47)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmShowCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 402)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstCars)
        Me.Name = "frmShowCars"
        Me.Text = "frmShowCars"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCars As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
