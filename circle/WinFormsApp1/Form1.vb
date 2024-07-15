Public Class Form1
    Dim a, b, c, d, sm, t As Integer
    Dim ta, tb, tc, td As Single
    Dim gg As Graphics
    Dim br1 As New SolidBrush(Color.Red)
    Dim br2 As New SolidBrush(Color.Blue)
    Dim br3 As New SolidBrush(Color.Green)
    Dim br4 As New SolidBrush(Color.Yellow)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = Val(TextBox4.Text)
        sm = a + b + c + d
        ta = a / sm * 360
        tb = b / sm * 360
        tc = c / sm * 360
        td = d / sm * 360
        t = 0
        gg = PictureBox1.CreateGraphics
        gg.Clear(Color.White)
        Dim myrect As New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height)
        gg.FillPie(br1, myrect, t, ta)
        t += ta
        gg.FillPie(br2, myrect, t, tb)
        t += tb
        gg.FillPie(br3, myrect, t, tc)
        t += tc
        gg.FillPie(br4, myrect, t, td)
        t += td

    End Sub
End Class
