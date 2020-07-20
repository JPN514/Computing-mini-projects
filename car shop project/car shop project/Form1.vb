Public Class Form1

    Private Sub chkSold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSold.CheckedChanged
        If chkSold.Checked Then
            lblSalesperson.Enabled = True
            cbmSalesperson.Enabled = True
            lblDate.Enabled = True
            dtpDateSold.Enabled = True
        Else
            lblSalesperson.Enabled = False
            cbmSalesperson.Enabled = False
            lblDate.Enabled = False
            dtpDateSold.Enabled = False
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Call AddCarToFile()
    End Sub

    Sub AddCarToFIle()
        Dim position As Integer
        ' get last car ID form the system
        FileOpen(1, "carfile.txt", OpenMode.Random, , , Len(ThisCar))
        position = LOF(1) / Len(ThisCar) ' position gets set to number of records
        position = position + 1
        lblRecordId.Text = position ' new record number/car id

        ThisCar.recordId = lblRecordId.Text
        ThisCar.Make = cbmMake.Text
        ThisCar.Model = txtModel.Text
        ThisCar.Colour = txtColour.Text
        ThisCar.Year = nudYear.Value
        ThisCar.price = nudPrice.Value


        ThisCar.SalesPerson = cbmSalesperson.Text
        ThisCar.DateSold = dtpDateSold.Value


        FilePut(1, ThisCar, position)
        FileClose(1)
    End Sub

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        Dim filename As String
        Dim returnvalue As Integer

        ' get image from networked files
        OpenFileDialog1.Title = " Find Car Image "
        returnvalue = OpenFileDialog1.ShowDialog()
        ' return value is checked to ensure open button was clicked OK value
        If returnvalue = DialogResult.OK Then
            filename = OpenFileDialog1.FileName
            pboCar.Image = Image.FromFile(filename)
            pboCar.Image.Save(txtReg.Text & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            txtFileName.Text = txtReg.Text & ".jpeg"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    
End Class


