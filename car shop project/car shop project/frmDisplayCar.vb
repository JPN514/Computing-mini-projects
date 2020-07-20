Public Class frmDisplayCar

    Private Sub frmDisplayCar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "carfile.txt", OpenMode.Random, , , Len(ThisCar))

        FileGet(1, ThisCar, position)
        FileClose(1)

        lblRecordId.Text = ThisCar.recordId
        cbmMake.Text = ThisCar.Make
        txtModel.Text = ThisCar.Model
        txtColour.Text = ThisCar.Colour
        nudYear.Value = ThisCar.Year
        nudMileage.Value = ThisCar.Mileage
        txtReg.Text = ThisCar.RegistrationNumber
        nudPrice.Value = ThisCar.Price
        'Try
        '    pboCar.Image = Image.FromFile(ThisCar.imagefile)
        'Catch
        'End Try

    End Sub

    
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
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
    
End Class