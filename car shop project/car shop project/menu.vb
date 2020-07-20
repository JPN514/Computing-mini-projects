Public Class menu

    Private Sub btnAddCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCar.Click
        Me.Hide()
        Form1.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnDisplayCars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayCars.Click
        Me.Hide()
        frmShowCars.ShowDialog()
        Me.Show()
    End Sub
End Class