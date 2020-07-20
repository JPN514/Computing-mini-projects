Public Class Form1

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tortoise_step As Integer
        Dim hare_step As Integer
        Randomize()
        tortoise_step = Rnd() * 10
        hare_step = Rnd() * 10
        pboHare.Left = pboHare.Left - hare_step
        pboTortoise.Left = pboTortoise.Left - tortoise_step

        If pboHare.Left <= 0 And pboHare.Left < pboTortoise.Left Then
            Timer1.Enabled = False
            MsgBox("the hare has won")


        ElseIf pboTortoise.Left <= 0 And pboTortoise.Left < pboHare.Left Then
            Timer1.Enabled = False
            MsgBox("the tortoise has won")
        End If

    End Sub
End Class
