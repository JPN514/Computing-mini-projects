Public Class frmShowCars

    Private Sub frmShowCars_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call showCars()
    End Sub

    Sub showCars()
        FileOpen(1, "carfile.txt", OpenMode.Binary)
        lstCars.Items.Clear()
        Do While Not EOF(1)
            FileGet(1, ThisCar)
            lstCars.Items.Add(Format(ThisCar.recordId, "000") & ThisCar.Make & ThisCar.Model &
            ThisCar.Year & Format(ThisCar.Price, "currency"))
        Loop
        FileClose(1)
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        position = CInt(Mid(lstCars.Text, 1, 3))
        Me.Hide()
        frmDisplayCar.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class