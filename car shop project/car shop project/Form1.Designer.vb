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
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblFilePhoto = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblRecordId = New System.Windows.Forms.Label()
        Me.cbmMake = New System.Windows.Forms.ComboBox()
        Me.lblSalesperson = New System.Windows.Forms.Label()
        Me.cbmSalesperson = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkSold = New System.Windows.Forms.CheckBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.nudMileage = New System.Windows.Forms.NumericUpDown()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dtpDateSold = New System.Windows.Forms.DateTimePicker()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.pboCar = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMileage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(50, 35)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(54, 13)
        Me.lblRecord.TabIndex = 0
        Me.lblRecord.Text = "Record Id"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(50, 72)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(34, 13)
        Me.lblMake.TabIndex = 1
        Me.lblMake.Text = "Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(50, 111)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(50, 147)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 3
        Me.lblColour.Text = "Colour"
        Me.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(50, 184)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Location = New System.Drawing.Point(50, 215)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(46, 13)
        Me.lblMileage.TabIndex = 5
        Me.lblMileage.Text = "Milieage"
        Me.lblMileage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(50, 249)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(103, 13)
        Me.lblRegNo.TabIndex = 6
        Me.lblRegNo.Text = "Registration Number"
        Me.lblRegNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(50, 283)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 13)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price (£)"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilePhoto
        '
        Me.lblFilePhoto.AutoSize = True
        Me.lblFilePhoto.Location = New System.Drawing.Point(50, 314)
        Me.lblFilePhoto.Name = "lblFilePhoto"
        Me.lblFilePhoto.Size = New System.Drawing.Size(99, 13)
        Me.lblFilePhoto.TabIndex = 8
        Me.lblFilePhoto.Text = "File Name Of Photo"
        Me.lblFilePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(50, 351)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 9
        Me.lblComments.Text = "Comments"
        Me.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecordId
        '
        Me.lblRecordId.AutoSize = True
        Me.lblRecordId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecordId.Location = New System.Drawing.Point(186, 35)
        Me.lblRecordId.Name = "lblRecordId"
        Me.lblRecordId.Size = New System.Drawing.Size(2, 15)
        Me.lblRecordId.TabIndex = 10
        '
        'cbmMake
        '
        Me.cbmMake.FormattingEnabled = True
        Me.cbmMake.Items.AddRange(New Object() {"Audi", "Ford", "Mini", "Peugeot", "Renault"})
        Me.cbmMake.Location = New System.Drawing.Point(186, 72)
        Me.cbmMake.Name = "cbmMake"
        Me.cbmMake.Size = New System.Drawing.Size(121, 21)
        Me.cbmMake.Sorted = True
        Me.cbmMake.TabIndex = 11
        '
        'lblSalesperson
        '
        Me.lblSalesperson.AutoSize = True
        Me.lblSalesperson.Enabled = False
        Me.lblSalesperson.Location = New System.Drawing.Point(403, 111)
        Me.lblSalesperson.Name = "lblSalesperson"
        Me.lblSalesperson.Size = New System.Drawing.Size(65, 13)
        Me.lblSalesperson.TabIndex = 12
        Me.lblSalesperson.Text = "Salesperson"
        '
        'cbmSalesperson
        '
        Me.cbmSalesperson.Enabled = False
        Me.cbmSalesperson.FormattingEnabled = True
        Me.cbmSalesperson.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbmSalesperson.Location = New System.Drawing.Point(474, 111)
        Me.cbmSalesperson.Name = "cbmSalesperson"
        Me.cbmSalesperson.Size = New System.Drawing.Size(121, 21)
        Me.cbmSalesperson.TabIndex = 13
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Enabled = False
        Me.lblDate.Location = New System.Drawing.Point(406, 147)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 13)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Date Sold"
        '
        'chkSold
        '
        Me.chkSold.AutoSize = True
        Me.chkSold.Location = New System.Drawing.Point(409, 72)
        Me.chkSold.Name = "chkSold"
        Me.chkSold.Size = New System.Drawing.Size(53, 17)
        Me.chkSold.TabIndex = 15
        Me.chkSold.Text = "Sold?"
        Me.chkSold.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(186, 111)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 16
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(186, 147)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(121, 20)
        Me.txtColour.TabIndex = 17
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(186, 249)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(121, 20)
        Me.txtReg.TabIndex = 18
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(186, 314)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(121, 20)
        Me.txtFileName.TabIndex = 19
        '
        'rtbComments
        '
        Me.rtbComments.Location = New System.Drawing.Point(186, 351)
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbComments.Size = New System.Drawing.Size(189, 53)
        Me.rtbComments.TabIndex = 20
        Me.rtbComments.Text = ""
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(186, 184)
        Me.nudYear.Maximum = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1993, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 20)
        Me.nudYear.TabIndex = 21
        Me.nudYear.Value = New Decimal(New Integer() {1993, 0, 0, 0})
        '
        'nudMileage
        '
        Me.nudMileage.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudMileage.Location = New System.Drawing.Point(186, 215)
        Me.nudMileage.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudMileage.Name = "nudMileage"
        Me.nudMileage.Size = New System.Drawing.Size(120, 20)
        Me.nudMileage.TabIndex = 22
        '
        'nudPrice
        '
        Me.nudPrice.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPrice.Location = New System.Drawing.Point(186, 283)
        Me.nudPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(120, 20)
        Me.nudPrice.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(409, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(490, 381)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dtpDateSold
        '
        Me.dtpDateSold.Enabled = False
        Me.dtpDateSold.Location = New System.Drawing.Point(474, 147)
        Me.dtpDateSold.Name = "dtpDateSold"
        Me.dtpDateSold.Size = New System.Drawing.Size(121, 20)
        Me.dtpDateSold.TabIndex = 26
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(313, 314)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(62, 23)
        Me.btnImage.TabIndex = 27
        Me.btnImage.Text = "Find"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'pboCar
        '
        Me.pboCar.Location = New System.Drawing.Point(409, 184)
        Me.pboCar.Name = "pboCar"
        Me.pboCar.Size = New System.Drawing.Size(186, 152)
        Me.pboCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboCar.TabIndex = 28
        Me.pboCar.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 416)
        Me.Controls.Add(Me.pboCar)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.dtpDateSold)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.nudPrice)
        Me.Controls.Add(Me.nudMileage)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.rtbComments)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.chkSold)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cbmSalesperson)
        Me.Controls.Add(Me.lblSalesperson)
        Me.Controls.Add(Me.cbmMake)
        Me.Controls.Add(Me.lblRecordId)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblFilePhoto)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblRecord)
        Me.Name = "Form1"
        Me.Text = "Enter Car Details"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMileage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRecord As System.Windows.Forms.Label
    Friend WithEvents lblMake As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblMileage As System.Windows.Forms.Label
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblFilePhoto As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblRecordId As System.Windows.Forms.Label
    Friend WithEvents cbmMake As System.Windows.Forms.ComboBox
    Friend WithEvents lblSalesperson As System.Windows.Forms.Label
    Friend WithEvents cbmSalesperson As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents chkSold As System.Windows.Forms.CheckBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtColour As System.Windows.Forms.TextBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMileage As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents dtpDateSold As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents pboCar As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
