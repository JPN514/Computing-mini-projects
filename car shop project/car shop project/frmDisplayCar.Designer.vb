<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayCar
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
        Me.pboCar = New System.Windows.Forms.PictureBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.dtpDateSold = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.nudMileage = New System.Windows.Forms.NumericUpDown()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.chkSold = New System.Windows.Forms.CheckBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cbmSalesperson = New System.Windows.Forms.ComboBox()
        Me.lblSalesperson = New System.Windows.Forms.Label()
        Me.cbmMake = New System.Windows.Forms.ComboBox()
        Me.lblRecordId = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblFilePhoto = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        CType(Me.pboCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMileage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboCar
        '
        Me.pboCar.Location = New System.Drawing.Point(402, 173)
        Me.pboCar.Name = "pboCar"
        Me.pboCar.Size = New System.Drawing.Size(186, 152)
        Me.pboCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboCar.TabIndex = 57
        Me.pboCar.TabStop = False
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(306, 303)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(62, 23)
        Me.btnImage.TabIndex = 56
        Me.btnImage.Text = "Find"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'dtpDateSold
        '
        Me.dtpDateSold.Enabled = False
        Me.dtpDateSold.Location = New System.Drawing.Point(467, 136)
        Me.dtpDateSold.Name = "dtpDateSold"
        Me.dtpDateSold.Size = New System.Drawing.Size(121, 20)
        Me.dtpDateSold.TabIndex = 55
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(483, 370)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 54
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(402, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'nudPrice
        '
        Me.nudPrice.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPrice.Location = New System.Drawing.Point(179, 272)
        Me.nudPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(120, 20)
        Me.nudPrice.TabIndex = 52
        '
        'nudMileage
        '
        Me.nudMileage.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudMileage.Location = New System.Drawing.Point(179, 204)
        Me.nudMileage.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudMileage.Name = "nudMileage"
        Me.nudMileage.Size = New System.Drawing.Size(120, 20)
        Me.nudMileage.TabIndex = 51
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(179, 173)
        Me.nudYear.Maximum = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1993, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 20)
        Me.nudYear.TabIndex = 50
        Me.nudYear.Value = New Decimal(New Integer() {1993, 0, 0, 0})
        '
        'rtbComments
        '
        Me.rtbComments.Location = New System.Drawing.Point(179, 340)
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbComments.Size = New System.Drawing.Size(189, 53)
        Me.rtbComments.TabIndex = 49
        Me.rtbComments.Text = ""
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(179, 303)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(121, 20)
        Me.txtFileName.TabIndex = 48
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(179, 238)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(121, 20)
        Me.txtReg.TabIndex = 47
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(179, 136)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(121, 20)
        Me.txtColour.TabIndex = 46
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(179, 100)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 45
        '
        'chkSold
        '
        Me.chkSold.AutoSize = True
        Me.chkSold.Location = New System.Drawing.Point(402, 61)
        Me.chkSold.Name = "chkSold"
        Me.chkSold.Size = New System.Drawing.Size(53, 17)
        Me.chkSold.TabIndex = 44
        Me.chkSold.Text = "Sold?"
        Me.chkSold.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Enabled = False
        Me.lblDate.Location = New System.Drawing.Point(399, 136)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 13)
        Me.lblDate.TabIndex = 43
        Me.lblDate.Text = "Date Sold"
        '
        'cbmSalesperson
        '
        Me.cbmSalesperson.Enabled = False
        Me.cbmSalesperson.FormattingEnabled = True
        Me.cbmSalesperson.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbmSalesperson.Location = New System.Drawing.Point(467, 100)
        Me.cbmSalesperson.Name = "cbmSalesperson"
        Me.cbmSalesperson.Size = New System.Drawing.Size(121, 21)
        Me.cbmSalesperson.TabIndex = 42
        '
        'lblSalesperson
        '
        Me.lblSalesperson.AutoSize = True
        Me.lblSalesperson.Enabled = False
        Me.lblSalesperson.Location = New System.Drawing.Point(396, 100)
        Me.lblSalesperson.Name = "lblSalesperson"
        Me.lblSalesperson.Size = New System.Drawing.Size(65, 13)
        Me.lblSalesperson.TabIndex = 41
        Me.lblSalesperson.Text = "Salesperson"
        '
        'cbmMake
        '
        Me.cbmMake.FormattingEnabled = True
        Me.cbmMake.Items.AddRange(New Object() {"Audi", "Ford", "Mini", "Peugeot", "Renault"})
        Me.cbmMake.Location = New System.Drawing.Point(179, 61)
        Me.cbmMake.Name = "cbmMake"
        Me.cbmMake.Size = New System.Drawing.Size(121, 21)
        Me.cbmMake.Sorted = True
        Me.cbmMake.TabIndex = 40
        '
        'lblRecordId
        '
        Me.lblRecordId.AutoSize = True
        Me.lblRecordId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecordId.Location = New System.Drawing.Point(179, 24)
        Me.lblRecordId.Name = "lblRecordId"
        Me.lblRecordId.Size = New System.Drawing.Size(2, 15)
        Me.lblRecordId.TabIndex = 39
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(43, 340)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(56, 13)
        Me.lblComments.TabIndex = 38
        Me.lblComments.Text = "Comments"
        Me.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilePhoto
        '
        Me.lblFilePhoto.AutoSize = True
        Me.lblFilePhoto.Location = New System.Drawing.Point(43, 303)
        Me.lblFilePhoto.Name = "lblFilePhoto"
        Me.lblFilePhoto.Size = New System.Drawing.Size(99, 13)
        Me.lblFilePhoto.TabIndex = 37
        Me.lblFilePhoto.Text = "File Name Of Photo"
        Me.lblFilePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(43, 272)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 13)
        Me.lblPrice.TabIndex = 36
        Me.lblPrice.Text = "Price (£)"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(43, 238)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(103, 13)
        Me.lblRegNo.TabIndex = 35
        Me.lblRegNo.Text = "Registration Number"
        Me.lblRegNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Location = New System.Drawing.Point(43, 204)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(46, 13)
        Me.lblMileage.TabIndex = 34
        Me.lblMileage.Text = "Milieage"
        Me.lblMileage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(43, 173)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 33
        Me.lblYear.Text = "Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(43, 136)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 32
        Me.lblColour.Text = "Colour"
        Me.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(43, 100)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 31
        Me.lblModel.Text = "Model"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(43, 61)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(34, 13)
        Me.lblMake.TabIndex = 30
        Me.lblMake.Text = "Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Location = New System.Drawing.Point(43, 24)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(54, 13)
        Me.lblRecord.TabIndex = 29
        Me.lblRecord.Text = "Record Id"
        Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDisplayCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 416)
        Me.Controls.Add(Me.pboCar)
        Me.Controls.Add(Me.btnImage)
        Me.Controls.Add(Me.dtpDateSold)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
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
        Me.Name = "frmDisplayCar"
        Me.Text = "frmDisplayCar"
        CType(Me.pboCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMileage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboCar As System.Windows.Forms.PictureBox
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents dtpDateSold As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents nudPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMileage As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtColour As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents chkSold As System.Windows.Forms.CheckBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cbmSalesperson As System.Windows.Forms.ComboBox
    Friend WithEvents lblSalesperson As System.Windows.Forms.Label
    Friend WithEvents cbmMake As System.Windows.Forms.ComboBox
    Friend WithEvents lblRecordId As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblFilePhoto As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents lblMileage As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblMake As System.Windows.Forms.Label
    Friend WithEvents lblRecord As System.Windows.Forms.Label
End Class
