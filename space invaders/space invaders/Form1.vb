Public Class Form1
    Dim pbo(5) As PictureBox
    Dim distance As Integer = 5
    Dim move As Integer = 5


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            pbobullet.Left = pbobullet.Left - move
        End If
        If e.KeyCode = Keys.D Then
            pbobullet.Left = pbobullet.Left + move
        End If

        If e.KeyCode = Keys.F Then
            tmrbullet.Enabled = True
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbo(1) = PictureBox1
        pbo(2) = PictureBox2
        pbo(3) = PictureBox3
        pbo(4) = PictureBox4
        pbo(5) = PictureBox5


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        For cnt = 1 To 5
            pbo(cnt).Left = pbo(cnt).Left + distance
        Next

        If pbo(5).Right > Me.Right Then
            distance = distance * -1
            For cnt = 1 To 5
                pbo(cnt).Top = pbo(cnt).Top + 30
            Next
        ElseIf pbo(1).Left < 0 Then
            distance = distance * -1
            For cnt = 1 To 5
                pbo(cnt).Top = pbo(cnt).Top + 30
            Next
        End If

        If Timer1.Interval > 50 Then
            Timer1.Interval = Timer1.Interval - 5
        End If



    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    

    Private Sub tmrbullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrbullet.Tick
        pbobullet.Top = pbobullet.Top - 10
        For cnt = 1 To 5
            If pbobullet.Bounds.IntersectsWith(pbo(cnt).Bounds) And pbo(cnt).Visible = True Then
                pbo(cnt).Visible = False
                pbobullet.Top = Me.Height + 30
                tmrbullet.Enabled = False
            ElseIf pbobullet.Bounds.IntersectsWith(pbo(cnt).Bounds) And pbo(cnt).Visible = False Then
                pbo(cnt).Visible = False
                pbobullet.Top = Me.Height + 30
                tmrbullet.Enabled = False
            End If
        Next

    End Sub
End Class
